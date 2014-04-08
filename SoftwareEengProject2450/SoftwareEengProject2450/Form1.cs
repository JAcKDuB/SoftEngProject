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
            mediaSD = new SortedDictionary<uint,Media>{};
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

            txtDisplayPatron.Clear();
            foreach (KeyValuePair<uint,Patron> p in this.patronSD)
            {
                txtDisplayPatron.Text += p.Value.ToString();
            }
        }
        /// <summary>
        /// Purpose: to display all currently checked books per patron
        /// </summary>
        private void btnViewChkedPerPatron_Click(object sender, EventArgs e)
        {
            Patron P = new Patron(); //=txtDisplayPatron.SelectedText
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
            foreach (KeyValuePair<uint,Media> m in mediaSD)
            {
                txtDisplayMedia.Text += m.Value.ToString();
            }
        }
       
    }
}
