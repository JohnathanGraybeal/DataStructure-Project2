//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 2
//	File Name:		Driver.cs
//	Description:	Runs AboutNameList and NameListForm
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Johnathan Graybeal, graybealjw@etsu.edu
//	Created:		 March 5 , 2020	
//	Copyright:		Johnathan Graybeal,2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project2
{
    /// <summary>
    /// Shows the usage of the list by giving the user a choice to create a list from a file, add
    /// a name to a list, remove a name from the list, save and quit 
    /// </summary>
    class Driver
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AboutNameList());
            Application.Run(new NameListForm());
            
            
        }
        
        
    }
}
