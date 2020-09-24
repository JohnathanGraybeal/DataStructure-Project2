//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 2 
//	File Name:		NameList.cs
//	Description:	Defines operators for a List<Name> and allows for sorting 
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Johnathan Graybeal, graybealjw@etsu.edu
//	Created:		Thursday, February 22 , 2020	
//	Copyright:		Johnathan Graybeal,2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace Project2
{
    /// <summary>
    /// creates a list of Names and defines several operators, and sorting methods 
    /// </summary>
    class NameList
    {
        #region Attributes
        private List<Name> names;
        private int Count; 
        #endregion

        /// <summary>
        /// default constructor creates a list of size 100 and sets the count 
        /// </summary>
        public NameList()
        {
            names = new List<Name>(100);
            SetCount();
        }
        #region Operators
        /// <summary>
        /// Addition operator lets you add a name to the list 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="nameToAdd"></param>
        /// <returns></returns>
       public static NameList operator +(NameList list, Name nameToAdd)

        {
            if (String.IsNullOrEmpty(nameToAdd.First) || String.IsNullOrEmpty(nameToAdd.Last))
            {
                throw new Exception("To add a item a first name and last name are required please try again ");
            }

          

            try
            {
                if (String.IsNullOrEmpty(nameToAdd.First) == false && String.IsNullOrEmpty(nameToAdd.Last) == false)
                {
                    list.names.Add(nameToAdd);
                }
            }
            catch (NullReferenceException)
            {

                throw;
            }

            return list;
        }
        /// <summary>
        /// Subtraction operator if the name exists in the list it lets you remove it 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="nameToRemove"></param>
        /// <returns></returns>
        public static NameList operator -(NameList list, Name nameToRemove)
        {
            if (list.names.Contains(nameToRemove))
            {
                int index = list.names.IndexOf(nameToRemove);
                list.names.RemoveAt(index);

            }
            else
            {
                
                throw new Exception($"The Name {nameToRemove.First} {nameToRemove.Rest} {nameToRemove.Last} does not exist in the current list ");
            }

            return list;


        }
        /// <summary>
        /// defines the index operator for a NameList<Name>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Name this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException($"{index} is not within a valid range");
                return names[index];

            }
            set
            {
                if (index >= 0 || index < Count)
                    names[index] = value;
            }
        } 
        #endregion

        #region CountSetterGetter
        /// <summary>
        /// set the count of the list 
        /// </summary>
        public void SetCount()
        {

            this.Count = names.Count;
        }

        /// <summary>
        /// return the count of the list 
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return Count;
        } 
        #endregion


        /// <summary>
        /// Sorts by last name
        /// </summary>
        /// <param name="originalList"></param>
        /// <returns></returns>
        public List<Name> SortedByLastName(List<Name> originalList)
        {
            List<Name> sorted = new List<Name>(originalList);

            sorted.Sort();

            return sorted;
        }

        /// <summary>
        /// Sorts by first name 
        /// </summary>
        /// <param name="originalList"></param>
        /// <returns></returns>
        public List<Name> SortedByFirstName(List<Name> originalList)
        {
            List<Name> sorted = new List<Name>(originalList);

            sorted.Sort(Name.AltCompareTo);

            return sorted;
        }

      
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
