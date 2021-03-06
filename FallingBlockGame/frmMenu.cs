﻿/// MAIN MENU FORM
///
/// This is the first form that the user will see. From here they can
/// play the game, Learn how to play the game, learn about the game, or
/// exit the program.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FallingBlockGame
{
    public partial class frmMenu : Form
    {
        string sWindowTitle = Application.ProductName;  //STRING used to store the standard window title

        //Run when the form has loaded
        public frmMenu()
        {

            //Initialize all components of the form
            InitializeComponent();
        }

        //Run when the form has loaded
        private void frmMenu_Load(object sender, EventArgs e)
        {

            //Set Window Title
            this.Text = sWindowTitle;

            //Try to set the location of the form to the owner form location
            try
            {

                //Set location in relation to owner form
                this.Location = this.Owner.Location;
            }

            //Otherwise, center the form
            catch
            {
                this.CenterToScreen();
            }
        }

        //Runs when the play button is clicked
        private void cmdPlay_Click(object sender, EventArgs e)
        {

            //Create a new instance of the form 'frmGamePlay'
            frmGamePlay frmGamePlay = new frmGamePlay();

            //Hide the main menu
            this.Hide();

            //Show the newly created form
            frmGamePlay.ShowDialog(this);

            //Close the current form
            //this.Close();
        }

        //Runs when the about button is clicked
        private void cmdAboutGame_Click(object sender, EventArgs e)
        {

            //Create a new instance of the form 'frmAbout'
            frmAbout frmAbout = new frmAbout();

            //Show the newly created form
            frmAbout.ShowDialog(this);
        }

        //Runs when the how to play button is clicked
        private void cmdHowToPlay_Click(object sender, EventArgs e)
        {

            //Create a new instance of the form 'frmHowToPlay'
            frmHowToPlay frmHowToPlay = new frmHowToPlay();

            //Show the newly created form
            frmHowToPlay.ShowDialog(this);
        }

        //Runs when the exit button is clicked
        private void cmdExit_Click(object sender, EventArgs e)
        {

            //Close the current form
            this.Close();
        }
    }
}
