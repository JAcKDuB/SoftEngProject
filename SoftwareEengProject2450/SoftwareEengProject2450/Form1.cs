﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private SortedDictionary<uint, Media> mediaSD;
        private SortedDictionary<uint, Patron> patronSD;

        public Form1()
        {
            InitializeComponent();
            mediaSD = new SortedDictionary<uint, Media> { };
            patronSD = new SortedDictionary<uint, Patron> { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBox.Show("closing");
            //serialize and write dictionary to file
            base.OnFormClosing(e);
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
            foreach (KeyValuePair<uint, Patron> p in this.patronSD)
            {
                txtDisplayPatron.Items.Add(p);
            }
        }
        /// <summary>
        /// Purpose: to display all currently checked books per patron
        /// </summary>
        private void btnViewChkedPerPatron_Click(object sender, EventArgs e)
        {
            if (txtDisplayPatron.SelectedIndex.Equals(null))
            {
                MessageBox.Show("Please select a patron for which to view checked out media.");
            }
            Patron P = (Patron)txtDisplayPatron.SelectedItem; //=txtDisplayPatron.SelectedText
            displayChecked(P);

        }
        /// <summary>
        /// Purpose: helper for btnDisplayCheckedPerPatron
        /// </summary>
        /// <param name="P">Patron</param>
        private void displayChecked(Patron P)
        {
            foreach (KeyValuePair<uint, Media> m in P._currentChecked)
            {
                MessageBox.Show(m.Value.ToString());

            }
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
            foreach (KeyValuePair<uint, Media> m in mediaSD)
            {
                txtDisplayMedia.Items.Add(m.Value.ToString());
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
            }
        }
        private void btnAddMedia_Click()
        {
            saveNewMedia();
        }
        private void saveNewMedia()
        {
            Media m;
            if (txtMediaType.SelectedValue.ToString() == MediaType.CHILDBOOK.ToString())
            {
                m = new Media(txtMediaTitle.Text, uint.Parse(txtMediaNumCopies.Text), MediaType.CHILDBOOK);
            }
            if (txtMediaType.SelectedValue.ToString() == MediaType.ADULTBOOK.ToString())
            {
                m = new Media(txtMediaTitle.Text, uint.Parse(txtMediaNumCopies.Text), MediaType.ADULTBOOK);
            }
            if (txtMediaType.SelectedValue.ToString() == MediaType.DVD.ToString())
            {
                m = new Media(txtMediaTitle.Text, uint.Parse(txtMediaNumCopies.Text), MediaType.DVD);
            }
            if (txtMediaType.SelectedValue.ToString() == MediaType.VIDEO.ToString())
            {
                m = new Media(txtMediaType.Text, uint.Parse(txtMediaNumCopies.Text), MediaType.VIDEO);
            }

        }


    }
}
