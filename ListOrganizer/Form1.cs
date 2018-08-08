using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data; // Plans
using MySql.Data.Entity; // Plans
using MySql.Data.MySqlClient; // Plans

namespace ListOrganizer
{
    public partial class frmListOrganizer : Form
    {
        public frmListOrganizer()
        {
            InitializeComponent();
        }

        string ItemInput = "";
        int numberEntries = 0;
        int numberInList = 0;
        string password = "";
        string passwordInput = "";
        string findEntry = "";
        string removeEntry = "";
        string enableTesting = "";
        int numberOfRemovals = 0;
        string disableWarningMessage = "";
        bool systemIsLocked;

        public void checkInputScript()
        {
            if (ItemInput.Length <= 500)
            {
                addEntry();
            }

            else
            {
                MessageBox.Show("The entry is too long", "Not valid for entry");
            }
        }

        private void preventClosing()
        {
            this.Closing += new CancelEventHandler(this.doNotClose);
        }

        private void doNotClose(Object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void allowClosing()
        {
            this.Closing += new CancelEventHandler(this.doClose);
        }

        private void doClose(Object sender, CancelEventArgs e)
        {
            e.Cancel = false; 
        }

        public void checkInput()
        {
            if (ItemInput != "")
            {
                checkInputScript();
            }

            else
            {
                // MessageBox.Show("Input is not valid, exiting the Addition GUI", "Exiting");
            }

            if (lstItemsViewer.Items.Count >= 17)
            {
                btnEntriesInList.Visible = true;
            }
        }

        public void addEntry()
        {
            numberInList++;
            lstItemsViewer.Items.Add(ItemInput + " (" + numberInList + ")");

            if (ItemInput.Length >= 51)
            {
                lstItemsViewer.HorizontalScrollbar = true;
            }
        }

        public void removeItemsAutomatically()
        {
            int index = lstItemsViewer.SelectedIndex;
            lstItemsViewer.Items.RemoveAt(index);
            numberOfRemovals++;
            numberInList = numberInList - 1;

            if (lstItemsViewer.Items.Count < 17)
            {
                btnEntriesInList.Visible = false;
            }

            else
            {
                btnEntriesInList.Visible = true;
            }

            /* for (int i = 0; i < lstItemsViewer.Items.Count; i++) // Planning to add updating later
            {
                int listInIndex = 0;
                lstItemsViewer.Items.Insert(listInIndex, ItemInput + " (" + numberInList + ")");
                listInIndex++;
            } */
        }

        public void removeEntryScript()
        {
            if (lstItemsViewer.SelectedIndex != -1)
            {
                this.removeEntry = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to remove the entry?\n\nONLY TYPE 'Yes' OR 'No'.", "Confirm Removal");

                if (removeEntry == "yes" || removeEntry == "Yes")
                {
                    removeItemsAutomatically();
                }

                else if (removeEntry == "no" || removeEntry == "No")
                {
                    MessageBox.Show("Please be careful.", "Notice");
                }

                else
                {
                    // MessageBox.Show("Input is not valid, exiting Removal GUI.", "Exiting");
                }
            }

            else
            {
                MessageBox.Show("You did not select a item.", "No selected item");
            }
        }

        public void testingCaller()
        {
            this.enableTesting = Microsoft.VisualBasic.Interaction.InputBox("Do you want to enable testing mode? (for development purpose, will remove this once this is finished)\n\nONLY TYPE 'Yes' or 'No", "Enable testing mode??");

            if (enableTesting == "yes" || enableTesting == "Yes")
            {
                enableTestingScript();
            }

            else if (enableTesting == "no" || enableTesting == "No")
            {
                disableTestingScript();
            }

            else
            {

            }
        }

        public void systemUnlockerScript()
        {
            this.passwordInput = Microsoft.VisualBasic.Interaction.InputBox("What is the password?", "Enter password");

            if (passwordInput == password)
            {
                if (lstItemsViewer.Items.Count >= 17)
                {
                    btnEntriesInList.Visible = true;
                    unlockSystem();
                }

                else
                {
                    unlockSystem();
                }

                MessageBox.Show("Password is correct, unlocking the system.", "Unlocking system");
            }

            else
            {
                MessageBox.Show("Password is incorrect, you shall not pass.", "Password is wrong");
            }
        }

        public void testingVisibilitySetting(bool value1, bool value2)
        {
            if (lstItemsViewer.Items.Count >= 17)
            {
                btnEnableAccess.Visible = value1;
                btnEntriesInList.Visible = value2;
            }

            else
            {
                btnEnableAccess.Visible = value1;
                btnEntriesInList.Visible = value1;     
            }          
        }

        public void unlockSystem()
        {
            allowClosing();
            btnRemoveEntry.Visible = true;
            btnNumberOfEntries.Visible = true;
            btnFindEntry.Visible = true;
            btnDisableAccess.Visible = true;
            btnAddEntry.Visible = true;
            lstItemsViewer.Visible = true;
            
            if (enableTesting == "yes")
            {
                testingVisibilitySetting(true, true);
                lblListOfItems.Text = "Testing Mode";
            }

            else
            {
                testingVisibilitySetting(false, true);
                lblListOfItems.Text = "The Item Organizer";
            }

            systemIsLocked = false;
        }

        public void enableTestingScript()
        {
            btnEntriesInList.Visible = true;
            btnRemoveEntry.Visible = true;
            btnNumberOfEntries.Visible = true;
            btnFindEntry.Visible = true;
            btnDisableAccess.Visible = true;
            btnAddEntry.Visible = true;
            lstItemsViewer.Visible = true;
            btnEnableAccess.Visible = true;
            lblListOfItems.Text = "Testing Mode";
        }

        public void disableTestingScript()
        {
            btnEntriesInList.Visible = false;
            btnEnableAccess.Visible = false;
            lblListOfItems.Text = "The Item Organizer";
        }

        public void lockSystem()
        {
            preventClosing();
            btnEntriesInList.Visible = false;
            btnRemoveEntry.Visible = false;
            btnNumberOfEntries.Visible = false;
            btnFindEntry.Visible = false;
            btnDisableAccess.Visible = false;
            btnAddEntry.Visible = false;
            lstItemsViewer.Visible = false;
            btnEnableAccess.Visible = true;
            lblListOfItems.Text = "Program is Locked";
            systemIsLocked = true;
        }

        private void frmListOrganizer_Load(object sender, EventArgs e)
        {
            btnEnableAccess.Visible = false;
            btnEntriesInList.Visible = false;
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            this.ItemInput = Microsoft.VisualBasic.Interaction.InputBox("Add the data here.\n\nFormat: (text)", "Add Data");
            checkInput();
        }

        private void btnNumberOfEntries_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstItemsViewer.Items.Count; i++)
            {
                numberEntries++;
            }

            MessageBox.Show("There are " + numberEntries + " entries here.", "Number of Entries");

            numberEntries = 0;
        }

        private void btnEntriesInList_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb1 = new StringBuilder();
            foreach (object items in lstItemsViewer.Items)
            {
                sb1.Append(items.ToString());
                sb1.Append("\n");
                sb1.Append(" ");
            }

            if (lstItemsViewer.Items.Count != 0)
            {
                MessageBox.Show(sb1.ToString(), "The list of entries");
            }

            else
            {
                MessageBox.Show("There are no entries here.", "No entries");
            }
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (lstItemsViewer.Items.Count == 0)
            {
                MessageBox.Show("There are no items to remove here.", "No items in list");
                numberInList = 0;
            }

            else
            {
                if (numberOfRemovals <= 2)
                {
                    removeEntryScript();
                }

                else if (numberOfRemovals == 3)
                {
                    this.disableWarningMessage = Microsoft.VisualBasic.Interaction.InputBox("The system has noticed you removing some items constantly, do you want to remove this warning?\n\nONLY TYPE 'Yes' or 'No'.", "Disable warning?");

                    if (disableWarningMessage == "yes" || disableWarningMessage == "Yes")
                    {
                        removeItemsAutomatically();
                    }

                    else if (disableWarningMessage == "no" || disableWarningMessage == "No")
                    {
                        removeItemsAutomatically();
                    }
                }

                else
                {
                    if (disableWarningMessage == "yes" || disableWarningMessage == "Yes")
                    {
                        removeItemsAutomatically();
                    }

                    else if (disableWarningMessage == "no" || disableWarningMessage == "No")
                    {
                        removeEntryScript();
                    }
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by DefyTheRush\n\nWhy is there unequal space? Some buttons do not appear until you do certain actions within the program such as:\n\nAdding more than 17 items will show a 'Show All Entries' button in the bottom middle area\n\nAll buttons will hide upon putting a locking passcode in 'Disable Access' but a 'Enable Access' (next to 'Disable Access') and 'Info' button will exist", "Information");
        }

        private void btnFindEntry_Click(object sender, EventArgs e)
        {
            if (lstItemsViewer.Items.Count == 0)
            {
                MessageBox.Show("There is nothing here to find.", "No items");
            }

            else
            {
                lstItemsViewer.ClearSelected();

                this.findEntry = Microsoft.VisualBasic.Interaction.InputBox("What is the item you are trying to look for?", "Find entry");

                int index = lstItemsViewer.FindString(findEntry);

                if (findEntry == "")
                {
                    // MessageBox.Show("Input is not valid, exiting Finder GUI", "Exiting");
                }

                else if (index < 0)
                {
                    MessageBox.Show("Item not found.", "Invalid search");
                    findEntry = String.Empty;
                }

                else
                {
                    lstItemsViewer.SelectedIndex = index;
                }
            }
        }

        private void btnDisableEntry_Click(object sender, EventArgs e)
        {
            this.password = Microsoft.VisualBasic.Interaction.InputBox("Enter a password. (it can be numbers or words)\n\nAlso KEEP THE PASSWORD SAFE.", "Enter passcode");

            if (password != "")
            {
                lockSystem();
                MessageBox.Show("Password accepted, locking the system.", "Locking the system");
            }

            else
            {
                // MessageBox.Show("Input is not valid, exiting the Password GUI.", "Exiting");
            }
        }

        private void btnEnableEntry_Click(object sender, EventArgs e)
        {
            if (enableTesting == "no" || enableTesting == "No" || enableTesting == "")
            {
                systemUnlockerScript();
            }

            else
            {
                if (!systemIsLocked)
                {
                    MessageBox.Show("In testing  mode you cannot modify this button unless you lock the system.", "Unlocking system while it is unlocked?");
                }

                else
                {
                    systemUnlockerScript();
                }
            }
        }

        private void lblListOfEntries_Click(object sender, EventArgs e)
        {
            if (systemIsLocked)
            {
                MessageBox.Show("You cannot enable testing mode if the system is locked.", "Trying to unlock the system through a old exploit?");
            }

            else if (!systemIsLocked)
            {
                testingCaller();
            }
        }
    }
}
