//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 2 
//	File Name:		NameListForm.cs 
//	Description:	Gives Functionality to the main form and provides handlers
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Johnathan Graybeal, graybealjw@etsu.edu
//	Created:		March 6, 2020	
//	Copyright:		Johnathan Graybeal,2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Windows.Forms;



namespace Project2
{
    /// <summary>
    /// Handlers and functionality for the main NameList form
    /// </summary>
    public partial class NameListForm : Form
    {
        NameList list = new NameList();
        private Name name;
        private bool HasChanged;//indicates if the user has made changes
        public bool FormatChange;//indicates if the format of the names should change 

        #region Constructor
        /// <summary>
        /// Creates the components for the form 
        /// </summary>
        public NameListForm()
        {

            InitializeComponent();

        } 
        #endregion

        #region FormClosing
        /// <summary>
        /// when the user exits the program and there are unsaved changes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasChanged == true)
            {
                SaveForm save = new SaveForm();
                save.ShowDialog();
                if (save.Saved == true)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Title = "Save this list of names";
                    saveFile.Filter = "text files|*.txt";
                    saveFile.InitialDirectory = @"..\..\DataFiles";
                    if (saveFile.ShowDialog() == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                    StreamWriter write = null;

                    try
                    {
                        write = new StreamWriter(new FileStream(saveFile.FileName, FileMode.OpenOrCreate,
                            FileAccess.Write));
                        for (int i = 0; i < list.GetCount(); i++)
                        {
                            write.WriteLine(list[i].ToString());
                        }
                    }
                    finally
                    {
                        if (write != null)
                        {
                            write.Close();
                        }
                    }

                }


            }
        }

        #endregion


        #region Import From File


        /// <summary>
        /// Lets the user select a text file to import names from 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importFromAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = String.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "text files|*.txt;*.text";
            openFile.InitialDirectory = @"..\..\DataFiles";
            openFile.Title = "Select a file to build a list from";
            if (DialogResult.Cancel != openFile.ShowDialog())
            {
                file = openFile.FileName;
            }
            else
            {
                Application.Exit();
            }

            StreamReader rdr = null;
            try
            {

                rdr = new StreamReader(file);
                while (rdr.Peek() != -1)
                {
                        string names = rdr.ReadLine();
                        Name fileNames = new Name(names);
                        
                        list = list + fileNames;
                        this.List.Items.Add(fileNames);
                }

            }

            catch (IOException ex) 
            {
                
            }
            finally
            {

                if (rdr != null)
                {
                    rdr.Close();
                }


                list.SetCount();
                this.AmountOfNamesInList.Text = " Items in list:" + Convert.ToString(List.Items.Count);
                HasChanged = true;


                
            }
        }

        #endregion


        #region Save File
        /// <summary>
        /// Lets the user save the list to a  file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save this list of names";
            save.Filter = "text files|*.txt";
            save.InitialDirectory = @"..\..\DataFiles";
            if (save.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write));
                for (int i = 0; i < list.GetCount(); i++)
                {
                    writer.WriteLine(list[i].ToString());
                }
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }

                HasChanged = false;
            }
        }
        #endregion


        #region AddOrRemoveName
        /// <summary>
        /// adds a name to the list 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addANameToTheListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.ShowDialog();
            name = new Name(input.GetTextInput());
            list = list + name;
            list.SetCount();
            List.Items.Add(name);
            this.AmountOfNamesInList.Text = " Items in list:" + Convert.ToString(List.Items.Count);
            HasChanged = true;

        }

        /// <summary>
        /// Lets the user remove a name from the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeANameFromTheListToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            InputForm input = new InputForm();
            input.ShowDialog();
            name = new Name(input.GetTextInput());
            list = list - name;
            list.SetCount();
            List.Items.Clear();
            for (int i = 0; i < list.GetCount(); i++) //List.Items.Remove would not work so this is my workaround 
            {
                List.Items.Add(list[i]);
                this.AmountOfNamesInList.Text = " Items in list:" + Convert.ToString(List.Items.Count);
            }
            
            HasChanged = true;
        }

        #endregion


        #region HowToUseTheProgram
        /// <summary>
        /// Displays Instructions for how to use the program 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructionsForUsingThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Files:Click File then Import from file to import a list of names from a file. To save a file click File then save file\n\n\n" +
                "Editing the list: To add a name to the list you can either: go to edit then add a name to the list or you can just type a name " +
                "into the Original Name box. To remove a name go to edit then remove name.\n\n\nFormatting: The list is automatically in alphabetical order " +
                "to change the sorting click the Switch to First Name First button  ", "How To Use This Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


        #region AboutTheProgram
        /// <summary>
        /// Displays the AboutNameList form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutNameList aboutNameList = new AboutNameList();
            aboutNameList.ShowDialog();
        }
        #endregion


        #region ListClickHandler
        /// <summary>
        /// Upon  clicking a item in the list the text boxes are filled with relevant info 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Click(object sender, EventArgs e)  
        {
            
            if (List.SelectedItem != null)
            {
                OriginalName.Clear();
                LastName.Clear();
                RestOfName.Clear();
                Suffix.Clear();


                try
                {
                    this.OriginalName.Text = name.OriginalName;
                    this.LastName.Text = name.Last;
                    this.RestOfName.Text = name.Rest;
                    this.Suffix.Text = name.Suffix;
                }
                catch (NullReferenceException)
                {
                    

                }

                

            }
        }
        #endregion


        #region OriginalNameTextBoxFocusHandler
        /// <summary>
        /// When the user clicks in this test box it is cleared 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OriginalName_Enter(object sender, EventArgs e)
        {
            OriginalName.Clear();

        }
        #endregion


        #region EnterKeyPressedHandler

        /// <summary>
        /// after the user presses enter the text is converted to a name 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OriginalName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                name = new Name(OriginalName.Text);
                list = list + name;
                List.Items.Add(name);
                this.AmountOfNamesInList.Text = " Items in list:" + Convert.ToString(List.Items.Count);
                HasChanged = true;
                OriginalName.Clear();
            }

            
        }
        #endregion


        #region FormLoadEvent

        /// <summary>
        /// When the form loads show instructions for using the program 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NameListForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Files:Click File then Import from file to import a list of names from a file. To save a file click File then save file\n\n\n" +
                "Editing the list: To add a name to the list you can either: go to edit then add a name to the list or you can just type a name " +
                "into the Original Name box. To remove a name go to edit then remove name.\n\n\nFormatting: The list is automatically in alphabetical order " +
                "to change the sorting click the Switch to First Name First button  ", "How To Use This Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion

        
        /// <summary>
        /// Change the way that the names are formatted 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameFirstButton_Click(object sender, EventArgs e) 
        {
            FormatChange = true;
            

        }

       


        #region Timer
    /// <summary>
    /// Updates the current time every second 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Start();
            this.CurrentTime.Text = DateTime.Now.ToString("F");//specifies format of date 
        } 
        #endregion
    }
}
