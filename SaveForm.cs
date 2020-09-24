//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 2 
//	File Name:		SaveForm.cs
//	Description:	Meant to be used like java's Input Dialog box takes a given input and assigns it to TextInput
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Johnathan Graybeal, graybealjw@etsu.edu
//	Created:		March 5, 2020	
//	Copyright:		Johnathan Graybeal,2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// a form that asks if the user would like to save 
    /// </summary>
    public partial class SaveForm : Form
    {
        public bool Saved;
      /// <summary>
      /// Initializes the components 
      /// </summary>
        public SaveForm()
        {
            InitializeComponent();
        }

       

      /// <summary>
      /// Answer yes to if the user wants to save 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void YesSaveButton_Click(object sender, EventArgs e)
        {
            Saved = true;
            this.Close();
        }

      /// <summary>
      /// Answer No to if the user wants to save 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void NoSaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
