﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        // This (app) refers to the object that contains the application
        // logic.
        private PhoneApp app;
        private string fileName;
        bool change = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Try to add a new phone number to the list
            try
            {
                PhoneForm frm = new PhoneForm();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    app.NewPhone(frm.NewPhone);
                    this.lstNames.Items.Add(frm.NewPhone);
                    this.lstNames.SelectedIndex = 0;
                    change = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.  This will generate the Closing event
            // to write out the data.
            this.Close();
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the phone number for the selected name.
            this.txtPhone.Text = ((Phone)this.lstNames.SelectedItem).PhoneNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This presentation tier maintains phone information in
            // the list box.  The ArrayList is needed temporarily to
            // copy the phones from the business tier.

            ArrayList phones;
            string fileName = "";
            Program.errorFlag = false;

            // Set the filter for the open file dialog
            this.dlgOpenFile.Filter = DataAccess.FileFilter;

            // Get the name of the input file
            if (this.dlgOpenFile.ShowDialog() == DialogResult.OK)
                fileName = this.dlgOpenFile.FileName;
            else
            {
                Program.errorFlag = true;
                this.Close();
            }
            app = new PhoneApp();
            phones = app.ReadPhones(fileName);

            // Add each phone in the array list to the list box
            foreach (Phone p in phones)
                this.lstNames.Items.Add(p);
            if (this.lstNames.Items.Count > 0)
                this.lstNames.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This is called whenever the main form is closed
            // and causes the file to be written.
            if (!Program.errorFlag) app.WritePhones();
        }

        private void mnuMerge_Click(object sender, EventArgs e)
        {
            // Set the filter for the open file dialog
            this.dlgOpenFile.Filter = DataAccess.FileFilter;
            // Get the name of the input file
            if (this.dlgOpenFile.ShowDialog() == DialogResult.OK)
                fileName = this.dlgOpenFile.FileName;
            else
            {
                Program.errorFlag = true;
                this.Close();
            }

            //Enabling buttons
            mnuSave.Enabled = true;
            mnuEdit.Enabled = true;
            mnuRemove.Enabled = true;
            change = true;
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                lstNames.Items.RemoveAt(lstNames.SelectedIndex);
                change = true;
            }
            else
            {
                this.Close();
            }
        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            change = true;
            //Enabling buttons
            mnuSave.Enabled = true;
            mnuEdit.Enabled = true;
            mnuRemove.Enabled = true;
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            change = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if( change == true)
            {
                string message = "You have unsaved changes. Do you want to save these changes?";
                string title = "Unsaved Changes";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                result = MessageBox.Show(message, title, buttons);
                this.Close();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            change = false;
        }

        private void PhoneNumberDisplay()
        {
            txtPhone.Text = ((Phone)this.lstNames.SelectedItem).PhoneNumber;
        }
    }
}