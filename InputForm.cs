//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 2 
//	File Name:		InputForm.cs 
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
    /// Form that takes a user Input from a text box then closes the form the data
    /// from input is to be used to either add to a list or remove a name from the list 
    /// </summary>
    public partial class InputForm : Form
    {
        private string TextInput;//The input that the user enters into the TextBox 
        /// <summary>
        /// Initializes components needed for the form 
        /// </summary>
        public InputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// returns the value from TextInput
        /// </summary>
        /// <returns></returns>
        public string GetTextInput()
        {
            return this.TextInput;
        }

        /// <summary>
        /// Sets Text Input to whatever the user enters into the text box then upon clicking the ok button the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            TextInput = textBox1.Text;
            this.Close();
        }


        /// <summary>
        /// if the user closes the input screen and there is text in the text box it is assigned to TextInput 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                TextInput = textBox1.Text;
            }
        }


        /// <summary>
        /// When the enter key is pressed the text in the text box is assigned to Text input
        /// then the form closes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                TextInput = textBox1.Text;
                this.Close();
            }
        }
    }
}
