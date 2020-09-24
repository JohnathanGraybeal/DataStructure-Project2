//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Homework 1 String Handling 
//	File Name:		Tools.cs
//	Description:	various tools that may be of use such as string tokenization and pausing a program
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Johnathan Graybeal, graybealjw@etsu.edu
//	Created:		Thursday, February 6, 2020	
//	Copyright:		Johnathan Graybeal,2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Console;


namespace Project2
{
    /// <summary>
    /// Provides Various Tools to use including pausing the program and string tokenization 
    /// </summary>    
    static class Tools
    {

        public static List<String> TokensList;
        /// <summary>
        /// takes a given string and tokenize it by
        /// given delimiters putting each word and delimiter on separate lines
        /// </summary>
        /// <param name="line"></param>
        /// <param name="delims"></param>
        /// <returns>String[] tokens</returns>
        #region Tokenize
        public static List<String> Tokenize(string line, string delims)
        {
            TokensList = new List<string>();//the list of tokens to be returned 
            char[] delimiters = delims.ToCharArray();//convert the string of delims into a char array


            try
            {
                line = line.Trim();
                int col = line.IndexOfAny(delimiters); // the column index of any delimiter 
                int startingPos = 0; // starting position 
                while (line.IndexOfAny(delimiters) != -1) // while a delimiter exists 
                {
                    col = line.IndexOfAny(delimiters);
                    if (col > 1
                    ) // if a delimiter isn't the first character all characters up to the delimiter is a token 
                    {
                        TokensList.Add(line.Substring(startingPos, col));
                        line = line.Remove(startingPos, col);
                        line = line.Trim();
                    }

                    col = line.IndexOfAny(delimiters);
                    if (col == 1) // if a delimiter is the first character it is a token  
                    {
                        TokensList.Add(line.Substring(startingPos, col));
                        line = line.Remove(startingPos, col);
                        line = line.Trim();
                    }


                }

                if (col == -1) // if no more delimiters exist the rest of the string is a token 
                {
                    TokensList.Add(line.Substring(startingPos, line.Length));
                    line = line.Remove(startingPos, line.Length);
                }

            }
            catch (NullReferenceException)
            {
                Application.Exit();
            }
            
            return TokensList;
        }
        #endregion

        /// <summary>
        /// for each loop to display values in the TokensList
        /// </summary>
        
        #region DisplayToken
        public static void DisplayTokens()
        {

            int index = 1;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("No.\tToken");
            WriteLine("---\t---");
            ForegroundColor = ConsoleColor.DarkBlue;


            foreach (String val in TokensList)
            {


                WriteLine($"{index}.\t{val}");
                index++;


                if (index % 20 == 0)
                {
                    Pause();

                }


            }

            ReadKey();
        } 
        #endregion

        #region MenuTools
        /// <summary>
        /// Pauses the program by asking the user to press a key once a key is pressed the program resumes 
        /// </summary>
        public static void Pause()
        {
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;

            WriteLine("Press The Enter Key To Continue");
            ReadLine();
            ForegroundColor = ConsoleColor.DarkBlue;
        }

        /// <summary>
        /// displays a welcome message for the user 
        /// </summary>
        /// <param name="message"></param>
        public static void WelcomeMessage(
            string message = "Welcome Please Enter Your Credentials Below to Start Using This Program ")
        {
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            WriteLine(message);
            ForegroundColor = ConsoleColor.DarkBlue;
        }

        /// <summary>
        /// Provides menu options for the user to select from 
        /// </summary>
        public static void Menu()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("1. Make List from a file\n2.Add Name To List\n3.Remove a name from the list\n4.Sort the list\n5.Quit");
            ForegroundColor = ConsoleColor.DarkBlue;
        }
    }

    #endregion


}
