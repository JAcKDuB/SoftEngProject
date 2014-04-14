namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlLibrary = new System.Windows.Forms.TabControl();
            this.tabLibraryMain = new System.Windows.Forms.TabPage();
            this.lstvwMediaList = new System.Windows.Forms.ListView();
            this.clmTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCheckedOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblPatronDispName = new System.Windows.Forms.Label();
            this.txtPatronItemsCheckedOut = new System.Windows.Forms.ListBox();
            this.btnClearGUI = new System.Windows.Forms.Button();
            this.txtDisplayPatron = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtSearchMedia = new System.Windows.Forms.TextBox();
            this.btnSearchMedia = new System.Windows.Forms.Button();
            this.lblSelectMedia = new System.Windows.Forms.Label();
            this.txtSearchPatron = new System.Windows.Forms.TextBox();
            this.btnSearchPatron = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabListOverdue = new System.Windows.Forms.TabPage();
            this.btnDisplayOverdue = new System.Windows.Forms.Button();
            this.dateTimeOverdue = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayOverdueMedia = new System.Windows.Forms.RichTextBox();
            this.tabAddRemovePatron = new System.Windows.Forms.TabPage();
            this.txtMediaType = new System.Windows.Forms.ComboBox();
            this.txtPatronCardNum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnRemoveMedia = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddMedia = new System.Windows.Forms.Button();
            this.btnAddPatron = new System.Windows.Forms.Button();
            this.txtMediaRemoveID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemovePatron = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMediaAuthor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMediaTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatronDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatronZip = new System.Windows.Forms.TextBox();
            this.txtPatronState = new System.Windows.Forms.TextBox();
            this.txtPatronCity = new System.Windows.Forms.TextBox();
            this.txtPatronAddress = new System.Windows.Forms.TextBox();
            this.txtPatronPhone = new System.Windows.Forms.TextBox();
            this.txtPatronName = new System.Windows.Forms.TextBox();
            this.lblpatronName = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tabControlLibrary.SuspendLayout();
            this.tabLibraryMain.SuspendLayout();
            this.tabListOverdue.SuspendLayout();
            this.tabAddRemovePatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLibrary
            // 
            this.tabControlLibrary.Controls.Add(this.tabLibraryMain);
            this.tabControlLibrary.Controls.Add(this.tabListOverdue);
            this.tabControlLibrary.Controls.Add(this.tabAddRemovePatron);
            this.tabControlLibrary.Location = new System.Drawing.Point(12, 12);
            this.tabControlLibrary.Name = "tabControlLibrary";
            this.tabControlLibrary.SelectedIndex = 0;
            this.tabControlLibrary.Size = new System.Drawing.Size(1004, 555);
            this.tabControlLibrary.TabIndex = 2;
            // 
            // tabLibraryMain
            // 
            this.tabLibraryMain.Controls.Add(this.lstvwMediaList);
            this.tabLibraryMain.Controls.Add(this.btnCheckOut);
            this.tabLibraryMain.Controls.Add(this.lblPatronDispName);
            this.tabLibraryMain.Controls.Add(this.txtPatronItemsCheckedOut);
            this.tabLibraryMain.Controls.Add(this.btnClearGUI);
            this.tabLibraryMain.Controls.Add(this.txtDisplayPatron);
            this.tabLibraryMain.Controls.Add(this.dateTimePicker);
            this.tabLibraryMain.Controls.Add(this.label2);
            this.tabLibraryMain.Controls.Add(this.btnCheckIn);
            this.tabLibraryMain.Controls.Add(this.txtSearchMedia);
            this.tabLibraryMain.Controls.Add(this.btnSearchMedia);
            this.tabLibraryMain.Controls.Add(this.lblSelectMedia);
            this.tabLibraryMain.Controls.Add(this.txtSearchPatron);
            this.tabLibraryMain.Controls.Add(this.btnSearchPatron);
            this.tabLibraryMain.Controls.Add(this.label1);
            this.tabLibraryMain.Location = new System.Drawing.Point(4, 22);
            this.tabLibraryMain.Name = "tabLibraryMain";
            this.tabLibraryMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibraryMain.Size = new System.Drawing.Size(996, 529);
            this.tabLibraryMain.TabIndex = 0;
            this.tabLibraryMain.Text = "Library Main";
            this.tabLibraryMain.UseVisualStyleBackColor = true;
            // 
            // lstvwMediaList
            // 
            this.lstvwMediaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTitle,
            this.clmCheckedOut,
            this.clmID});
            this.lstvwMediaList.Location = new System.Drawing.Point(354, 161);
            this.lstvwMediaList.Name = "lstvwMediaList";
            this.lstvwMediaList.Size = new System.Drawing.Size(296, 226);
            this.lstvwMediaList.TabIndex = 32;
            this.lstvwMediaList.UseCompatibleStateImageBehavior = false;
            this.lstvwMediaList.View = System.Windows.Forms.View.Details;
            this.lstvwMediaList.SelectedIndexChanged += new System.EventHandler(this.lstvwMediaList_SelectedIndexChanged);
            // 
            // clmTitle
            // 
            this.clmTitle.Text = "Title";
            this.clmTitle.Width = 140;
            // 
            // clmCheckedOut
            // 
            this.clmCheckedOut.Text = "Checked Out To";
            this.clmCheckedOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCheckedOut.Width = 110;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmID.Width = 40;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(367, 403);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(267, 23);
            this.btnCheckOut.TabIndex = 27;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblPatronDispName
            // 
            this.lblPatronDispName.AutoSize = true;
            this.lblPatronDispName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatronDispName.Location = new System.Drawing.Point(683, 134);
            this.lblPatronDispName.Name = "lblPatronDispName";
            this.lblPatronDispName.Size = new System.Drawing.Size(107, 18);
            this.lblPatronDispName.TabIndex = 31;
            this.lblPatronDispName.Text = "Patron Name";
            // 
            // txtPatronItemsCheckedOut
            // 
            this.txtPatronItemsCheckedOut.Location = new System.Drawing.Point(686, 162);
            this.txtPatronItemsCheckedOut.Name = "txtPatronItemsCheckedOut";
            this.txtPatronItemsCheckedOut.Size = new System.Drawing.Size(275, 147);
            this.txtPatronItemsCheckedOut.TabIndex = 25;
            this.txtPatronItemsCheckedOut.SelectedIndexChanged += new System.EventHandler(this.txtPatronItemsCheckedOut_SelectedIndexChanged);
            // 
            // btnClearGUI
            // 
            this.btnClearGUI.Location = new System.Drawing.Point(750, 383);
            this.btnClearGUI.Name = "btnClearGUI";
            this.btnClearGUI.Size = new System.Drawing.Size(141, 43);
            this.btnClearGUI.TabIndex = 29;
            this.btnClearGUI.Text = "Clear All";
            this.btnClearGUI.UseVisualStyleBackColor = true;
            this.btnClearGUI.Click += new System.EventHandler(this.btnClearGUI_Click);
            // 
            // txtDisplayPatron
            // 
            this.txtDisplayPatron.FormattingEnabled = true;
            this.txtDisplayPatron.Location = new System.Drawing.Point(29, 162);
            this.txtDisplayPatron.MultiColumn = true;
            this.txtDisplayPatron.Name = "txtDisplayPatron";
            this.txtDisplayPatron.Size = new System.Drawing.Size(296, 264);
            this.txtDisplayPatron.TabIndex = 8;
            this.txtDisplayPatron.SelectedIndexChanged += new System.EventHandler(this.txtDisplayPatron_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(28, 54);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Select Date";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(686, 324);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(267, 23);
            this.btnCheckIn.TabIndex = 26;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtSearchMedia
            // 
            this.txtSearchMedia.Location = new System.Drawing.Point(354, 134);
            this.txtSearchMedia.Name = "txtSearchMedia";
            this.txtSearchMedia.Size = new System.Drawing.Size(195, 20);
            this.txtSearchMedia.TabIndex = 18;
            // 
            // btnSearchMedia
            // 
            this.btnSearchMedia.Location = new System.Drawing.Point(555, 132);
            this.btnSearchMedia.Name = "btnSearchMedia";
            this.btnSearchMedia.Size = new System.Drawing.Size(95, 23);
            this.btnSearchMedia.TabIndex = 20;
            this.btnSearchMedia.Text = "Search";
            this.btnSearchMedia.UseVisualStyleBackColor = true;
            // 
            // lblSelectMedia
            // 
            this.lblSelectMedia.AutoSize = true;
            this.lblSelectMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMedia.Location = new System.Drawing.Point(351, 104);
            this.lblSelectMedia.Name = "lblSelectMedia";
            this.lblSelectMedia.Size = new System.Drawing.Size(105, 18);
            this.lblSelectMedia.TabIndex = 16;
            this.lblSelectMedia.Text = "Select Media";
            // 
            // txtSearchPatron
            // 
            this.txtSearchPatron.Location = new System.Drawing.Point(29, 134);
            this.txtSearchPatron.Name = "txtSearchPatron";
            this.txtSearchPatron.Size = new System.Drawing.Size(196, 20);
            this.txtSearchPatron.TabIndex = 5;
            // 
            // btnSearchPatron
            // 
            this.btnSearchPatron.Location = new System.Drawing.Point(230, 132);
            this.btnSearchPatron.Name = "btnSearchPatron";
            this.btnSearchPatron.Size = new System.Drawing.Size(95, 23);
            this.btnSearchPatron.TabIndex = 7;
            this.btnSearchPatron.Text = "Search";
            this.btnSearchPatron.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Patron";
            // 
            // tabListOverdue
            // 
            this.tabListOverdue.Controls.Add(this.btnDisplayOverdue);
            this.tabListOverdue.Controls.Add(this.dateTimeOverdue);
            this.tabListOverdue.Controls.Add(this.label4);
            this.tabListOverdue.Controls.Add(this.label3);
            this.tabListOverdue.Controls.Add(this.displayOverdueMedia);
            this.tabListOverdue.Location = new System.Drawing.Point(4, 22);
            this.tabListOverdue.Name = "tabListOverdue";
            this.tabListOverdue.Padding = new System.Windows.Forms.Padding(3);
            this.tabListOverdue.Size = new System.Drawing.Size(996, 529);
            this.tabListOverdue.TabIndex = 1;
            this.tabListOverdue.Text = "List Overdue Media";
            this.tabListOverdue.UseVisualStyleBackColor = true;
            // 
            // btnDisplayOverdue
            // 
            this.btnDisplayOverdue.Location = new System.Drawing.Point(362, 54);
            this.btnDisplayOverdue.Name = "btnDisplayOverdue";
            this.btnDisplayOverdue.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayOverdue.TabIndex = 29;
            this.btnDisplayOverdue.Text = "Go!";
            this.btnDisplayOverdue.UseVisualStyleBackColor = true;
            this.btnDisplayOverdue.Click += new System.EventHandler(this.btnDisplayOverdue_Click);
            // 
            // dateTimeOverdue
            // 
            this.dateTimeOverdue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOverdue.Location = new System.Drawing.Point(142, 55);
            this.dateTimeOverdue.Name = "dateTimeOverdue";
            this.dateTimeOverdue.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOverdue.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Overdue Books";
            // 
            // displayOverdueMedia
            // 
            this.displayOverdueMedia.Location = new System.Drawing.Point(24, 97);
            this.displayOverdueMedia.Name = "displayOverdueMedia";
            this.displayOverdueMedia.ReadOnly = true;
            this.displayOverdueMedia.Size = new System.Drawing.Size(947, 364);
            this.displayOverdueMedia.TabIndex = 0;
            this.displayOverdueMedia.Text = "";
            // 
            // tabAddRemovePatron
            // 
            this.tabAddRemovePatron.Controls.Add(this.txtMediaType);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronCardNum);
            this.tabAddRemovePatron.Controls.Add(this.label20);
            this.tabAddRemovePatron.Controls.Add(this.label19);
            this.tabAddRemovePatron.Controls.Add(this.btnRemoveMedia);
            this.tabAddRemovePatron.Controls.Add(this.btnRemove);
            this.tabAddRemovePatron.Controls.Add(this.btnAddMedia);
            this.tabAddRemovePatron.Controls.Add(this.btnAddPatron);
            this.tabAddRemovePatron.Controls.Add(this.txtMediaRemoveID);
            this.tabAddRemovePatron.Controls.Add(this.label14);
            this.tabAddRemovePatron.Controls.Add(this.label15);
            this.tabAddRemovePatron.Controls.Add(this.label16);
            this.tabAddRemovePatron.Controls.Add(this.txtRemovePatron);
            this.tabAddRemovePatron.Controls.Add(this.label18);
            this.tabAddRemovePatron.Controls.Add(this.txtMediaAuthor);
            this.tabAddRemovePatron.Controls.Add(this.label17);
            this.tabAddRemovePatron.Controls.Add(this.txtMediaTitle);
            this.tabAddRemovePatron.Controls.Add(this.label13);
            this.tabAddRemovePatron.Controls.Add(this.label11);
            this.tabAddRemovePatron.Controls.Add(this.label12);
            this.tabAddRemovePatron.Controls.Add(this.label5);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronDateofBirth);
            this.tabAddRemovePatron.Controls.Add(this.label10);
            this.tabAddRemovePatron.Controls.Add(this.label9);
            this.tabAddRemovePatron.Controls.Add(this.label8);
            this.tabAddRemovePatron.Controls.Add(this.label7);
            this.tabAddRemovePatron.Controls.Add(this.label6);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronZip);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronState);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronCity);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronAddress);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronPhone);
            this.tabAddRemovePatron.Controls.Add(this.txtPatronName);
            this.tabAddRemovePatron.Controls.Add(this.lblpatronName);
            this.tabAddRemovePatron.Location = new System.Drawing.Point(4, 22);
            this.tabAddRemovePatron.Name = "tabAddRemovePatron";
            this.tabAddRemovePatron.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddRemovePatron.Size = new System.Drawing.Size(996, 529);
            this.tabAddRemovePatron.TabIndex = 2;
            this.tabAddRemovePatron.Text = "Add  or Remove New Patron/Media";
            this.tabAddRemovePatron.UseVisualStyleBackColor = true;
            // 
            // txtMediaType
            // 
            this.txtMediaType.FormattingEnabled = true;
            this.txtMediaType.Items.AddRange(new object[] {
            "NONE",
            "ADULTBOOK",
            "CHILDBOOK",
            "DVD",
            "VIDEO"});
            this.txtMediaType.Location = new System.Drawing.Point(661, 182);
            this.txtMediaType.Name = "txtMediaType";
            this.txtMediaType.Size = new System.Drawing.Size(200, 21);
            this.txtMediaType.TabIndex = 12;
            // 
            // txtPatronCardNum
            // 
            this.txtPatronCardNum.Location = new System.Drawing.Point(194, 108);
            this.txtPatronCardNum.Name = "txtPatronCardNum";
            this.txtPatronCardNum.Size = new System.Drawing.Size(200, 20);
            this.txtPatronCardNum.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Library Card Number: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(530, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Media Type: ";
            // 
            // btnRemoveMedia
            // 
            this.btnRemoveMedia.Location = new System.Drawing.Point(661, 476);
            this.btnRemoveMedia.Name = "btnRemoveMedia";
            this.btnRemoveMedia.Size = new System.Drawing.Size(200, 23);
            this.btnRemoveMedia.TabIndex = 17;
            this.btnRemoveMedia.Text = "Remove Media";
            this.btnRemoveMedia.UseVisualStyleBackColor = true;
            this.btnRemoveMedia.Click += new System.EventHandler(this.btnRemoveMedia_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(194, 472);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Patron";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddMedia
            // 
            this.btnAddMedia.Location = new System.Drawing.Point(661, 216);
            this.btnAddMedia.Name = "btnAddMedia";
            this.btnAddMedia.Size = new System.Drawing.Size(200, 23);
            this.btnAddMedia.TabIndex = 13;
            this.btnAddMedia.Text = "Add Media";
            this.btnAddMedia.UseVisualStyleBackColor = true;
            this.btnAddMedia.Click += new System.EventHandler(this.btnAddMedia_Click);
            // 
            // btnAddPatron
            // 
            this.btnAddPatron.Location = new System.Drawing.Point(194, 351);
            this.btnAddPatron.Name = "btnAddPatron";
            this.btnAddPatron.Size = new System.Drawing.Size(200, 23);
            this.btnAddPatron.TabIndex = 9;
            this.btnAddPatron.Text = "Add Patron";
            this.btnAddPatron.UseVisualStyleBackColor = true;
            this.btnAddPatron.Click += new System.EventHandler(this.btnAddPatron_Click);
            // 
            // txtMediaRemoveID
            // 
            this.txtMediaRemoveID.Location = new System.Drawing.Point(661, 435);
            this.txtMediaRemoveID.Name = "txtMediaRemoveID";
            this.txtMediaRemoveID.Size = new System.Drawing.Size(200, 20);
            this.txtMediaRemoveID.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(543, 438);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Media ID: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(698, 396);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 18);
            this.label15.TabIndex = 37;
            this.label15.Text = "Remove Media";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(224, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 18);
            this.label16.TabIndex = 36;
            this.label16.Text = "Remove Patron";
            // 
            // txtRemovePatron
            // 
            this.txtRemovePatron.Location = new System.Drawing.Point(194, 435);
            this.txtRemovePatron.Name = "txtRemovePatron";
            this.txtRemovePatron.Size = new System.Drawing.Size(200, 20);
            this.txtRemovePatron.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Library Card Number: ";
            // 
            // txtMediaAuthor
            // 
            this.txtMediaAuthor.Location = new System.Drawing.Point(661, 144);
            this.txtMediaAuthor.Name = "txtMediaAuthor";
            this.txtMediaAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtMediaAuthor.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(558, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Author:";
            // 
            // txtMediaTitle
            // 
            this.txtMediaTitle.Location = new System.Drawing.Point(661, 105);
            this.txtMediaTitle.Name = "txtMediaTitle";
            this.txtMediaTitle.Size = new System.Drawing.Size(200, 20);
            this.txtMediaTitle.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(566, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Title: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(694, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Add New Media";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Add New Patron";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of Birth: ";
            // 
            // txtPatronDateofBirth
            // 
            this.txtPatronDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPatronDateofBirth.Location = new System.Drawing.Point(194, 145);
            this.txtPatronDateofBirth.Name = "txtPatronDateofBirth";
            this.txtPatronDateofBirth.Size = new System.Drawing.Size(200, 20);
            this.txtPatronDateofBirth.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Zip:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone Number: ";
            // 
            // txtPatronZip
            // 
            this.txtPatronZip.Location = new System.Drawing.Point(194, 320);
            this.txtPatronZip.Name = "txtPatronZip";
            this.txtPatronZip.Size = new System.Drawing.Size(200, 20);
            this.txtPatronZip.TabIndex = 8;
            // 
            // txtPatronState
            // 
            this.txtPatronState.Location = new System.Drawing.Point(194, 287);
            this.txtPatronState.MaxLength = 2;
            this.txtPatronState.Name = "txtPatronState";
            this.txtPatronState.Size = new System.Drawing.Size(200, 20);
            this.txtPatronState.TabIndex = 7;
            // 
            // txtPatronCity
            // 
            this.txtPatronCity.Location = new System.Drawing.Point(194, 254);
            this.txtPatronCity.Name = "txtPatronCity";
            this.txtPatronCity.Size = new System.Drawing.Size(200, 20);
            this.txtPatronCity.TabIndex = 6;
            // 
            // txtPatronAddress
            // 
            this.txtPatronAddress.Location = new System.Drawing.Point(194, 219);
            this.txtPatronAddress.Name = "txtPatronAddress";
            this.txtPatronAddress.Size = new System.Drawing.Size(200, 20);
            this.txtPatronAddress.TabIndex = 5;
            // 
            // txtPatronPhone
            // 
            this.txtPatronPhone.Location = new System.Drawing.Point(194, 183);
            this.txtPatronPhone.Name = "txtPatronPhone";
            this.txtPatronPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPatronPhone.TabIndex = 4;
            // 
            // txtPatronName
            // 
            this.txtPatronName.Location = new System.Drawing.Point(194, 72);
            this.txtPatronName.Name = "txtPatronName";
            this.txtPatronName.Size = new System.Drawing.Size(200, 20);
            this.txtPatronName.TabIndex = 1;
            // 
            // lblpatronName
            // 
            this.lblpatronName.AutoSize = true;
            this.lblpatronName.Location = new System.Drawing.Point(89, 75);
            this.lblpatronName.Name = "lblpatronName";
            this.lblpatronName.Size = new System.Drawing.Size(41, 13);
            this.lblpatronName.TabIndex = 0;
            this.lblpatronName.Text = "Name: ";
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.Location = new System.Drawing.Point(837, 573);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 39);
            this.btnQuit.TabIndex = 27;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 624);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.tabControlLibrary);
            this.Name = "Form1";
            this.Text = "Library";
            this.tabControlLibrary.ResumeLayout(false);
            this.tabLibraryMain.ResumeLayout(false);
            this.tabLibraryMain.PerformLayout();
            this.tabListOverdue.ResumeLayout(false);
            this.tabListOverdue.PerformLayout();
            this.tabAddRemovePatron.ResumeLayout(false);
            this.tabAddRemovePatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLibrary;
        private System.Windows.Forms.TabPage tabLibraryMain;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtSearchMedia;
        private System.Windows.Forms.Button btnSearchMedia;
        private System.Windows.Forms.Label lblSelectMedia;
        private System.Windows.Forms.TextBox txtSearchPatron;
        private System.Windows.Forms.Button btnSearchPatron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabListOverdue;
        private System.Windows.Forms.TabPage tabAddRemovePatron;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDisplayOverdue;
        private System.Windows.Forms.DateTimePicker dateTimeOverdue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox displayOverdueMedia;
        private System.Windows.Forms.ListBox txtDisplayPatron;
        private System.Windows.Forms.TextBox txtPatronName;
        private System.Windows.Forms.Label lblpatronName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtPatronDateofBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPatronZip;
        private System.Windows.Forms.TextBox txtPatronState;
        private System.Windows.Forms.TextBox txtPatronCity;
        private System.Windows.Forms.TextBox txtPatronAddress;
        private System.Windows.Forms.TextBox txtPatronPhone;
        private System.Windows.Forms.TextBox txtMediaTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMediaRemoveID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemovePatron;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRemoveMedia;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddMedia;
        private System.Windows.Forms.Button btnAddPatron;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPatronCardNum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox txtMediaType;
        private System.Windows.Forms.Button btnClearGUI;
        private System.Windows.Forms.TextBox txtMediaAuthor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox txtPatronItemsCheckedOut;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblPatronDispName;
        private System.Windows.Forms.ListView lstvwMediaList;
        private System.Windows.Forms.ColumnHeader clmTitle;
        private System.Windows.Forms.ColumnHeader clmCheckedOut;
        private System.Windows.Forms.ColumnHeader clmID;

    }
}

