using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private SortedDictionary<uint, Media> mediaSD;
        private SortedDictionary<uint, Patron> patronSD;

        //stacks
        //each time a patron or media object is removed the id is stored on the stack. 
        //When adding new patrons or media items we will use numbers on the stack before adding new items.

        Stack patronIDs = new Stack();
        Stack mediaIDs = new Stack();
        private Media m;
        DataBaseReadWrite db = new DataBaseReadWrite("patron.bin","media.bin");
        private string noPatron = "Error: No patron selected. Please click the patron's name, and then click the Select button.";
        private string noMedia = "Error: No media selected. Please click the name of the media to be checked in/out, and then click the Select button.";
        public Form1()
        {
            InitializeComponent();
            mediaSD = new SortedDictionary<uint, Media> { };
            patronSD = new SortedDictionary<uint, Patron> { };
            txtMediaType.SelectedIndex = 0;
            db.readCatalog(ref mediaSD);
            db.readPatron(ref patronSD);
            txtPatronItemsCheckedOut.SelectionMode = SelectionMode.MultiExtended;
            lblPatronDispName.Text = string.Empty;
            Media.Setup(mediaSD.Keys.Last());
            UpdateScreens();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnClosed(EventArgs e)
        {
            db.writeCatalog(mediaSD);
            db.writePatron(patronSD);
            base.OnClosed(e);
        }
        /// <summary>
        /// Purpose: to display all patrons
        /// </summary>
        private void btnDisplayAllPatrons_Click(object sender, EventArgs e)
        {
            displayPatrons();
        }
        /// <summary>
        /// Purpose: helper for btnDisplayAllPatrons
        /// </summary>
        private void displayPatrons()
        {
            txtDisplayPatron.Items.Clear();

            foreach (KeyValuePair<uint, Patron> p in this.patronSD)
            {
                txtDisplayPatron.Items.Add(p.Value);
                txtDisplayPatron.DisplayMember = "_name";
            }
        }

        /// <summary>
        /// Purpose: helper for btnDisplayCheckedPerPatron
        /// </summary>
        /// <param name="P">Patron</param>
        private void displayChecked(Patron P)
        {
            String str = P._name + " has ";
            
            if (P._currentChecked.Count > 0)
            {
                str += "checked out:\n\n";
                foreach (KeyValuePair<uint, Media> m in P._currentChecked)
                {
                    str += "\t" + m.Value.Title + "\n";
                }
            }
            else
            {
                str += "nothing checked out.";
            }

            MessageBox.Show(str);
        }
        /// <summary>
        /// Purpose: to display all media items
        /// </summary>
        private void btnDisplayAllMedia_Click(object sender, EventArgs e)
        {
            displayMedia();
        }
        private void displayMedia()
        {
            lstvwMediaList.Items.Clear();

            foreach (KeyValuePair<uint, Media> m in mediaSD)
            {
                ListViewItem item = new ListViewItem(m.Value.Title);
                item.SubItems.Add(m.Value.Borrower._name);
                item.SubItems.Add(m.Value.ID.ToString());
                lstvwMediaList.Items.Add(item);
            }

        }

        private void btnAddPatron_Click(object sender, EventArgs e)
        {
            saveNewPatron();
        }
        private void saveNewPatron()
        {
            if (Patron.validate(txtPatronName.Text, txtPatronAddress.Text, txtPatronCity.Text, txtPatronState.Text, txtPatronZip.Text, txtPatronPhone.Text, txtPatronCardNum.Text))
            {
                string combinedAddress = string.Concat(txtPatronAddress.Text, " ,", txtPatronCity.Text, ", ", txtPatronState.Text, ", ", txtPatronZip.Text);
                patronSD.Add(uint.Parse(txtPatronCardNum.Text), new Patron(txtPatronName.Text, uint.Parse(txtPatronCardNum.Text), combinedAddress, txtPatronPhone.Text, txtPatronDateofBirth.Value));
                MessageBox.Show("Patron added successfully!");
                UpdateScreens();
                ClearAddPatronFields();
            }
        }
        private void btnAddMedia_Click(object sender, EventArgs e)
        {
            saveNewMedia();
        }
        private void saveNewMedia()
        {
            
            if (validateMedia())
            {
                if (txtMediaType.SelectedIndex == 1)
                {
                    m = new Media(txtMediaTitle.Text, txtMediaAuthor.Text, MediaType.ADULTBOOK);
                    mediaSD.Add(m.ID, m);
                }
                if (txtMediaType.SelectedIndex == 2)
                {
                    m = new Media(txtMediaTitle.Text,txtMediaAuthor.Text, MediaType.CHILDBOOK);
                    mediaSD.Add(m.ID, m);
                }
                if (txtMediaType.SelectedIndex == 3)
                {
                    m = new Media(txtMediaTitle.Text, txtMediaAuthor.Text,MediaType.DVD);
                    mediaSD.Add(m.ID, m);
                }
                if (txtMediaType.SelectedIndex == 4)
                {
                    m = new Media(txtMediaType.Text,txtMediaAuthor.Text, MediaType.VIDEO);
                    mediaSD.Add(m.ID, m);
                }
                MessageBox.Show("Media item '" +txtMediaTitle.Text+"' added successfully!");
                UpdateScreens();
                ClearAddMediaFields();
            }
           
        }
        private bool validateMedia()
        {
            if (string.IsNullOrEmpty(txtMediaTitle.Text))
            {
                MessageBox.Show("Please enter a title to add a book.");
                return false;
            }
            if (string.IsNullOrEmpty(txtMediaAuthor.Text))
            {
                MessageBox.Show("Please enter the author to add a book.");
                return false;
            }
            if (txtMediaType.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose a media type.");
                return false;
            }
            return true;
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Patron p;
            uint cardNumber;
            if (!uint.TryParse(txtRemovePatron.Text, out cardNumber))
            {
                MessageBox.Show("Please enter a valid library card number");
            }
            else
            {
                if (!patronSD.TryGetValue(cardNumber, out p))
                {
                    if (patronSD.Count == 0)
                    {
                        MessageBox.Show("No patrons to remove.");
                    }
                    else
                    MessageBox.Show("No patron with such ID exists.");
                }
                else
                {
                    MessageBox.Show("Removed "+p.ToString());
                    patronSD.Remove(cardNumber);
                    UpdateScreens();
                    ClearRemovePatronFields();
                }
            }
        }

        private void btnRemoveMedia_Click(object sender, EventArgs e)
        {
            uint i;
            Media M;
            if (!uint.TryParse(txtMediaRemoveID.Text, out i))
            {
                MessageBox.Show("Please enter a valid media ID number");
            }
            else
            {
                if (!mediaSD.TryGetValue(i, out M))
                {
                    if (mediaSD.Count == 0)
                    {
                        MessageBox.Show("No media items to remove.");
                    }
                    else
                    MessageBox.Show("No media with such ID exists.");
                }
                else
                {
                    if (M.Borrower != Patron.None)
                    {
                        if (!M.CheckIn(false))
                        {
                            MessageBox.Show("Failed to remove " + M.Title + " from patron " + M.Borrower._name);
                        }
                    }

                    MessageBox.Show(M.Title + " removed.");
                    mediaSD.Remove(i);
                    UpdateScreens();
                    ClearRemoveMediaFields();
                }
            }
        }

        private void btnClearGUI_Click(object sender, EventArgs e)
        {
            ClearMainGUI();
        }

        /// <summary>
        /// Clears everything on the main page
        /// </summary>
        private void ClearMainGUI()
        {
            txtSearchMedia.Clear();
            txtSearchPatron.Clear();
            dateTimePicker.Value = DateTime.Today;
            lblPatronDispName.Text = string.Empty;
            txtDisplayPatron.SelectedIndex = -1;
            UpdateScreens();
        }

        private void btnDisplayOverdue_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<uint, Media> mm in this.mediaSD)
            {
                if(mm.Value.Overdue(dateTimeOverdue.Value))
                {
                    displayOverdueMedia.Text += mm.Value.ToString();
                }
            }  
        }

        /// <summary>
        /// Updates the patron name label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDisplayPatron_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDisplayPatron.SelectedIndex != -1)
            {
                Patron patron = txtDisplayPatron.SelectedItem as Patron;
                lblPatronDispName.Text = "Checked out to: " + patron._name;
                UpdatePatronItemsCheckedOut(patron);
            }
        }

        /// <summary>
        /// Fills the list box with the items the patron currently has checked out
        /// </summary>
        /// <param name="patron"></param>
        private void UpdatePatronItemsCheckedOut(Patron patron)
        {
            txtPatronItemsCheckedOut.Items.Clear();

            foreach (KeyValuePair<uint, Media> m in patron._currentChecked)
            {
                Media media = m.Value;
                txtPatronItemsCheckedOut.Items.Add(media);
                txtPatronItemsCheckedOut.DisplayMember = "Title";
            }

            if (txtPatronItemsCheckedOut.Items.Count > 0)
            {
                txtPatronItemsCheckedOut.SelectedIndex = 0;
            }

            CheckCheckInButton();
        }       

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutMedia();            
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInMedia();
        }

        /// <summary>
        /// Checks out media
        /// </summary>
        private void CheckOutMedia()
        {
            if (txtDisplayPatron.SelectedIndex == -1)
            {
                MessageBox.Show(noPatron);
            }

            if (lstvwMediaList.SelectedItems.Count <= 0)
            {
                MessageBox.Show(noMedia);
            }
            else
            {
                Patron p = (Patron)txtDisplayPatron.SelectedItem;

                //Check to see if checkout possible
                if (!p.overdueBooks(dateTimePicker.Value) && p.allowed(m))
                {
                    bool success = true;

                    // For multiple check outs, check that each one is successful
                    foreach (ListViewItem item in lstvwMediaList.SelectedItems)
                    {
                        if (success)
                        {
                            Media media = mediaSD[(uint)Convert.ToInt32(item.SubItems[clmID.Index].Text)];
                            
                            success = media.CheckOut(p, dateTimePicker.Value) ? true : false;
                        }
                    }

                    // Print results
                    if (success)
                    {
                        MessageBox.Show("Check out successful!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the requested media item is already checked out.");
                    }                   

                    // Update info on main screen
                    UpdatePatronItemsCheckedOut(p);
                    displayMedia();
                    CheckCheckInButton();
                }
            }
        }

        /// <summary>
        /// Checks in the media
        /// </summary>
        private void CheckInMedia()
        {
            if (txtDisplayPatron.SelectedIndex == -1)
            {
                MessageBox.Show(noPatron);
            }
            if (txtPatronItemsCheckedOut.SelectedIndex == -1)
            {
                MessageBox.Show(noMedia);
            }
            else
            {
                Patron patron = txtDisplayPatron.SelectedItem as Patron;
                bool success = true;

                // For multiple check ins, check that each is successful
                foreach (object o in txtPatronItemsCheckedOut.SelectedItems)
                {
                    if (success)
                    {
                        Media media = o as Media;

                        if (patron._currentChecked.ContainsKey(media.ID))
                        {
                            success = media.CheckIn() ? true : false;
                        }
                    }
                }

                // Print results
                if (success)
                {
                    MessageBox.Show("Check in successful!");
                }
                else
                {
                    MessageBox.Show("Check in failed!");
                }

                // Update info on main screen
                UpdatePatronItemsCheckedOut(patron);
                displayMedia();
                CheckCheckInButton();
            }
        }

        private void lstvwMediaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvwMediaListChange();
        }        

        /// <summary>
        /// Handles when index selections change on the media ListView
        /// </summary>
        private void lstvwMediaListChange()
        {
            if (lstvwMediaList.SelectedItems.Count > 0)
            {
                bool selectionNotCheckedOut = true;

                // Check to see if any of the selected items are already checked out
                foreach (ListViewItem item in lstvwMediaList.SelectedItems)
                {
                    if (selectionNotCheckedOut)
                    {
                        Media media = mediaSD[(uint)Convert.ToInt32(item.SubItems[clmID.Index].Text)];

                        selectionNotCheckedOut = media.CheckedOut ? false : true;
                    }
                }

                // Toggle button if user can check media out
                if (selectionNotCheckedOut && txtDisplayPatron.SelectedItems.Count > 0)
                {
                    btnCheckOut.Enabled = true;
                }
                else
                {
                    btnCheckOut.Enabled = false;
                }
            }
        }

        private void txtPatronItemsCheckedOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCheckInButton();
        }

        /// <summary>
        /// Updates all the text boxes on main
        /// </summary>
        private void UpdateScreens()
        {
            if (txtDisplayPatron.SelectedIndex != -1)
            {
                UpdatePatronItemsCheckedOut(txtDisplayPatron.SelectedItem as Patron);
            }
            else
            {
                txtPatronItemsCheckedOut.Items.Clear();
            }

            displayMedia();
            displayPatrons();

            if (txtDisplayPatron.SelectedItems.Count == 0)
            {
                btnCheckOut.Enabled = false;
            }

            CheckCheckInButton();
        }

        /// <summary>
        /// Clears all boxes related to adding media
        /// </summary>
        private void ClearAddMediaFields()
        {
            txtMediaType.Text = string.Empty;
            txtMediaAuthor.Text = string.Empty;
            txtMediaTitle.Text = string.Empty;
        }

        /// <summary>
        /// Clears all boxes related to adding patrons
        /// </summary>
        private void ClearAddPatronFields()
        {
            txtPatronName.Text = string.Empty;
            txtPatronCardNum.Text = string.Empty;
            txtPatronPhone.Text = string.Empty;
            txtPatronAddress.Text = string.Empty;
            txtPatronCity.Text = string.Empty;
            txtPatronState.Text = string.Empty;
            txtPatronZip.Text = string.Empty;
            txtPatronDateofBirth.Value = DateTime.Today;
        }

        /// <summary>
        /// Clears all boxes related to removing patrons
        /// </summary>
        private void ClearRemovePatronFields()
        {
            txtRemovePatron.Text = string.Empty;
        }

        /// <summary>
        /// Clears all boxes related to removing media
        /// </summary>
        private void ClearRemoveMediaFields()
        {
            txtMediaRemoveID.Text = string.Empty;
        }

        /// <summary>
        /// Determines whether or not to disable the CheckIn button
        /// </summary>
        private void CheckCheckInButton()
        {
            if (txtPatronItemsCheckedOut.SelectedItems.Count > 0)
            {
                btnCheckIn.Enabled = true;
            }
            else
            {
                btnCheckIn.Enabled = false;
            }
        }
    }
}
