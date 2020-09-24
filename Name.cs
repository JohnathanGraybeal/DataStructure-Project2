//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 2
//	File Name:		Name.cs
//	Description:	Decomposes a given name into it's separate pieces 
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Johnathan Graybeal, graybealjw@etsu.edu
//	Created:		Thursday, February 22 , 2020	
//	Copyright:		Johnathan Graybeal,2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Text.RegularExpressions;
using static Project2.Tools;
namespace Project2
{
    /// <summary>
    /// Decomposes a given string and provides a CompareTo and Equals method for comparisons between names 
    /// </summary>
    class Name:IEquatable<Name>,IComparable<Name>
    {
        #region Attributes

        public String OriginalName;//the original name entered 
        public String First;//first name 
        public String Rest;// rest of the name 
        public String Last;//last name 
        public String Suffix;//suffix if any 
        private Regex _pattern;//the pattern to match 
        private Match _match; //matched pattern 
        private NameListForm form = new NameListForm();
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor 
        /// </summary>
        public Name()
        {
            this.First = " ";
            this.Rest = " ";
            this.Last = " ";
            this.Suffix = " ";
        }
        /// <summary>
        /// copy constructor 
        /// </summary>
        /// <param name="other" the name object that is copying the current one ></param>

        public Name(Name other)
        {

            this.First = other.First;
            this.Rest = other.Rest;
            this.Last = other.Last;
            this.Suffix = other.Suffix;
           
            
        }

        /// <summary>
        /// Decomposes a name into it's parts and ensures that there are no null values 
        /// </summary>
        /// <param name="name"></param>
        public Name(String name)

        {
            
            NameDecomposition(name);
            
        } 
        #endregion

        /// <summary>
        /// Decomposes a given name into it's separate parts using RegEx
        /// </summary>
        /// <param name="name"></param>

        #region Decomposition

        
        public void NameDecomposition(String name)
            
        {
            
            this.OriginalName = name;
            Tools.Tokenize(name, ":;/?+_()*&^%$#@! ");

            if (Tools.TokensList.Count <= 4 && Tools.TokensList[0].Contains(",") && Tools.TokensList[1].Contains(".") && Tools.TokensList[2].Contains("."))//	First name Middle initial. Last name or first middle initial. Last, suffix or first, middle initial. last initial. //TODO NOT WORKING 
            {
                if (Tools.TokensList[2].Contains(","))//does last name contain a , 
                {
                    _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);//does a , come after last name 
                    _match = _pattern.Match(Tools.TokensList[3]);
                    if (_match.Success == true)
                    {
                        this.First = Tools.TokensList[0];
                        this.Rest = Tools.TokensList[1];
                        this.Last = Tools.TokensList[2];
                        this.Suffix = Tools.TokensList[3];

                    }
                }
                _pattern = new Regex(@"[a-z]{1}.", RegexOptions.IgnoreCase);//one word character followed by a period indicating a middle initial 
                _match = _pattern.Match(Tools.TokensList[1]);
                if (_match.Success == true)
                {
                    this.First = Tools.TokensList[0];
                    this.Rest = Tools.TokensList[1];
                    this.Last = Tools.TokensList[2];
                }


            }//end if 


            if (!Tools.TokensList[0].Contains(".") || !Tools.TokensList[0].Contains("-") || !Tools.TokensList[0].Contains(","))//First name last name or first last, suffix 
            {
                _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)//when pattern is firstname lastname 
                {
                    this.First = Tools.TokensList[0];
                    this.Last = Tools.TokensList[1];
                }

                if (Tools.TokensList.Count == 3 && Tools.TokensList[1].Contains(","))//when pattern is firstname lastname, suffix
                {
                    _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        this.First = Tools.TokensList[0];
                        this.Last = Tools.TokensList[1];
                        this.Suffix = Tools.TokensList[2];

                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 4 && Tools.TokensList[2].Contains(","))//	First middle last, suffix 
            {
                _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                        _match = _pattern.Match(Tools.TokensList[2]);
                        if (_match.Success == true)
                        {
                            this.First = Tools.TokensList[0];
                            this.Rest = Tools.TokensList[1];
                            this.Last = Tools.TokensList[2];
                            this.Suffix = Tools.TokensList[3];

                        }
                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 2 && Tools.TokensList[1].Contains("-"))//	First name hyphenated last name  
            {
                _pattern = new Regex(@"[a-z]+-[a-z]+", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[1]);

                if (_match.Success == true)
                {
                    this.First = Tools.TokensList[0];
                    this.Last = Tools.TokensList[1];
                }
            }

            if (Tools.TokensList.Count <= 4 && Tools.TokensList[0].Contains(".") && Tools.TokensList[1].Contains("."))//	First name initial. middle name initial. last name  or First name initial. middle name. last name, suffix 
            {
                _pattern = new Regex(@"[a-z]{1}.", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        this.First = Tools.TokensList[0];
                        this.Rest = Tools.TokensList[1];
                        this.Last = Tools.TokensList[2];
                        if (Tools.TokensList.Count == 4)
                        {
                            _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                            _match = _pattern.Match(Tools.TokensList[3]);
                            if (_match.Success == true)
                            {
                                this.First = Tools.TokensList[0];
                                this.Rest = Tools.TokensList[1];
                                this.Last = Tools.TokensList[2];
                                this.Suffix = Tools.TokensList[3];


                            }
                        }

                    }
                }




            }//end if

            if (Tools.TokensList.Count == 3 && Tools.TokensList[1].Contains(".") && Tools.TokensList[2].Contains(".") && Tools.TokensList[2].Contains(","))//	Last name, middle initial. First initial.
            {
                _pattern = new Regex(@"[a-z]{1}.", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[1]);
                if (_match.Success == true)
                {
                    _match = _pattern.Match(Tools.TokensList[2]);
                    if (_match.Success)
                    {
                        _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                        _match = _pattern.Match(Tools.TokensList[0]);
                        if (_match.Success == true)
                        {
                            this.Last = Tools.TokensList[0];
                            this.Rest = Tools.TokensList[1];
                            this.First = Tools.TokensList[2];
                        }
                    }
                }

            }//end if 

            if (Tools.TokensList.Count == 4 && Tools.TokensList[0].Contains(",") && Tools.TokensList[1].Contains(".") && Tools.TokensList[2].Contains(",")) //	Last, middle initial. First, suffix. 

            {
                _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _pattern = new Regex(@"[a-z]{1}.", RegexOptions.IgnoreCase);
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                        _match = _pattern.Match(Tools.TokensList[2]);
                        if (_match.Success == true)
                        {
                            this.Last = Tools.TokensList[0];
                            this.Suffix = Tools.TokensList[3];
                            this.Rest = Tools.TokensList[1];
                            this.First = Tools.TokensList[2];


                        }
                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 2 && Tools.TokensList[0].Contains(","))//	Last, first
            {
                _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        this.Last = Tools.TokensList[0];
                        this.First = Tools.TokensList[1];

                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 3 && Tools.TokensList[0].Contains(".") && !Tools.TokensList[1].Contains(".")) //	Prefix. First last 
            {
                _pattern = new Regex(@"[a-z]+.", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        _match = _pattern.Match(Tools.TokensList[2]);
                        if (_match.Success == true)
                        {

                            this.First = Tools.TokensList[1];
                            this.Last = Tools.TokensList[2];
                        }
                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 4 && Tools.TokensList[1].Contains(".") && !Tools.TokensList[2].Contains(",")) //First middle initial. Last last
            {
                _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _pattern = new Regex(@"[a-z]{1}.", RegexOptions.IgnoreCase);
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                        _match = _pattern.Match(Tools.TokensList[2]);
                        if (_match.Success == true)
                        {
                            _match = _pattern.Match(Tools.TokensList[3]);
                            if (_match.Success == true)
                            {
                                this.First = Tools.TokensList[0];
                                this.Rest = Tools.TokensList[1];
                                this.Last = Tools.TokensList[2] + " " + Tools.TokensList[3];
                            }
                        }
                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 3 && Tools.TokensList[0].Contains("'") && Tools.TokensList[1].Contains(","))//	First letter of last name’ rest of last name, first  
            {
                _pattern = new Regex(@"[a-z]{1}'", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _pattern = new Regex(@"[a-z]+,", RegexOptions.IgnoreCase);

                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        _pattern = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
                        _match = _pattern.Match(Tools.TokensList[2]);
                        if (_match.Success == true)
                        {
                            this.Last = Tools.TokensList[0] + " " + Tools.TokensList[1];
                            this.First = Tools.TokensList[2];
                        }


                    }
                }
            }//end if 

            if (Tools.TokensList.Count == 4 && Tools.TokensList[0].Contains("."))//	First name initial. Middle middle last name 
            {
                _pattern = new Regex(@"[a-z]{1}.", RegexOptions.IgnoreCase);
                _match = _pattern.Match(Tools.TokensList[0]);
                if (_match.Success == true)
                {
                    _pattern = new Regex(@"[a-z]+");
                    _match = _pattern.Match(Tools.TokensList[1]);
                    if (_match.Success == true)
                    {
                        _match = _pattern.Match(Tools.TokensList[2]);
                        if (_match.Success == true)
                        {
                            _match = _pattern.Match(Tools.TokensList[3]);
                            if (_match.Success == true)
                            {
                                this.First = Tools.TokensList[0];
                                this.Rest = Tools.TokensList[1] + " " + Tools.TokensList[2];
                                this.Last = Tools.TokensList[3];
                            }
                        }
                    }
                }
            }

        }




    

        #endregion

        #region Equals Implementation
        /// <summary>
        /// Override default Equals method so mine is always called 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public  bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);


            if ((obj is Name) )
                throw new ArgumentException($"Cannot compare a Name and a {obj.GetType()}");
            return Equals(obj as Name);

        }


        /// <summary>
        /// compares the attribute of two name objects 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Name other)
        {

            bool equals = false;
            try
            {
                if (!other.OriginalName.Equals(this.OriginalName))
                {
                    equals = false;
                }

                if (other.OriginalName.Equals(this.OriginalName))
                     
                {
                    equals = true;
                }
            }
            catch (NullReferenceException)
            {


            }

            return equals;
        }
        /// <summary>
        /// GetHashCode Overide 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
        /// <summary>
        /// Used to compares two name objects to determine ordering  
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Name other)
        {
            int compareVal;

            compareVal = this.Last.ToLower().CompareTo(other.Last);

            if (compareVal == 0)
            {
                compareVal = this.Rest.ToLower().CompareTo(other.Rest);

                if (compareVal == 0)
                {
                    compareVal = this.Suffix.ToLower().CompareTo(other.Suffix);
                }
            }

            return compareVal;
        }

        /// <summary>
        /// compares two name objects to determine ordering 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static int AltCompareTo(Name first, Name other)
        {
            int compareVal;

            compareVal = first.Rest.ToLower().CompareTo(other.Last);

            if (compareVal == 0)
            {
                compareVal = first.Last.ToLower().CompareTo(other.Rest);

                if (compareVal == 0)
                {
                    compareVal = first.Suffix.ToLower().CompareTo(other.Suffix);
                }
            }

            return compareVal;
        }


        /// <summary>
        /// displays info about the current object 
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override String ToString()
        
        {
            String info;
            info = ($"{First} {Rest} {Last}");
            System.Console.WriteLine(info);

            if (form.FormatChange == true)
            {
                info = ($"{Last} {Rest} {First}");
                System.Console.WriteLine(info);
            }

           



            return info;
        }
        


    }
}
