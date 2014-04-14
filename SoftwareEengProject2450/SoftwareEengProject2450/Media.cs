using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Library
{
    public enum MediaType {ADULTBOOK, CHILDBOOK, DVD, VIDEO };
    [Serializable]
	public class Media
	{
        
		// ********************************* Variables ***************************************
 
        public static string _id = "\nID Number: ";
        public static string _title = "\nTitle: ";
        public static string _author = " Author: ";
        public static string _checkedout = " Checked Out? ";

		// ******************************** Properties ***************************************

        private Patron _borrower;
		public static uint UniqueTitleCount { get; private set; }
        private MediaType mType;
        public MediaType Mtype {get { return mType; }}
        public DateTime dateCheckedOut { get; set; }
        private TimeSpan loanTime;
        private uint id = 0;
        public uint ID { get { return id; } set { id = value; } }
		public string Title { get; private set; }
        public string Author { get; private set; }
		public bool CheckedOut { get; private set; }
        private TimeSpan MAX_CHILD_LOAN = new TimeSpan(7, 0, 0, 0);
        private TimeSpan MAX_ADULT_LOAN = new TimeSpan(14, 0, 0, 0);
        private TimeSpan MAX_DVD_LOAN = new TimeSpan(2, 0, 0, 0);
        private TimeSpan MAX_VIDEO_LOAN = new TimeSpan(3, 0, 0, 0);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date">Datetime - from GUI</param>
        /// <returns>bool</returns>
        public bool Overdue(DateTime date)
        {
            TimeSpan diff = date.Subtract(this.dateCheckedOut);
            if (this.mType == MediaType.ADULTBOOK && diff >= MAX_ADULT_LOAN)
            {
                return true;
            }
            if (this.mType == MediaType.CHILDBOOK && diff >= MAX_CHILD_LOAN)
            {
                return true;
            }
            if (this.mType == MediaType.DVD && diff >= MAX_DVD_LOAN)
            {
                return true;
            }
            if (this.mType == MediaType.VIDEO && diff >= MAX_VIDEO_LOAN)
            {
                return true;
            }
            return false;
        }
      
		public Patron Borrower
		{
			get { return _borrower; }
			private set 
			{
  				if (value != null)
				{
					_borrower = value;
				}
				else
				{
					throw new Exception("Null reference, Patron was null");
				}
			}
		}

		// ******************************* Constructors **************************************

		public Media() { }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="title">string</param>
        /// <param name="numberOfCopies">uint</param>
        /// <param name="mType">MediaType</param>
		public Media(string title, string author, MediaType mType)
		{
            Title = title;
            Author = author;
            setLoanTime(mType);
            CheckedOut = false;
			ID = ++UniqueTitleCount;
            Borrower = Patron.None;
            this.mType = mType;
		}

		// ********************************* Methods *****************************************

        /// <summary>
        /// Set allowed loan time based on MediaType
        /// </summary>
        /// <param name="mt">MediaType</param>
        public void setLoanTime(MediaType mt)
        {
            if (mt == MediaType.CHILDBOOK)
            {
                loanTime = MAX_CHILD_LOAN;
            }
            if (mt == MediaType.ADULTBOOK)
            {
                loanTime = MAX_ADULT_LOAN;
            }
            if (mt == MediaType.DVD)
            {
                loanTime = MAX_DVD_LOAN;
            }
            if (mt == MediaType.VIDEO)
            {
                loanTime = MAX_VIDEO_LOAN;
            }
        }
        //*****************************************************

        public TimeSpan getLoanTime()
        {
            return loanTime;
        }
		/// <summary>
		/// Checks the book out, assigns borrower
		/// </summary>
		/// <param name="borrower">Patron borrowing the media</param>
		public bool CheckOut(Patron borrower, DateTime dateChecked)
		{
          //call checkout from patron, which needs to check age for eligibility
            //has patron already checked maximum number of items?
            //is book already checked out?
            
            if (CheckedOut == false && borrower._currentChecked.Count <= borrower._maxCheckouts)
            {
                CheckedOut = true;
                borrower.addMedia(this, this.ID);
                dateCheckedOut = dateChecked;
                Borrower = borrower;
                return true;
            }
            else
            {
                return false;
            }
		}

		// *********************************************************

        /// <summary>
        /// Checks the book in, releases borrower
        /// </summary>
		/// <param name="verbose">Turns message boxes on (default) or off</param>
		/// <returns>Success state</returns>
		public bool CheckIn(bool verbose = true)
		{
            if (Borrower != Patron.None)
            {
                CheckedOut = false;
                Borrower.removeMedia(this, this.ID);
                Borrower = Patron.None;
                return true;
            }
            else
            {
                MessageBox.Show("The book was not previously checked out!");
                return false;
            }
		}

        //************************************************************

        public override string ToString()
        {
            return String.Format(_title+Title+ _checkedout + CheckedOut + "\n");
        }

        //************************************************************

        /// <summary>
        /// Sets up media class for use
        /// </summary>
        /// <param name="last">Last used ID</param>
        public static void Setup(uint last)
        {
            UniqueTitleCount = last;
        }

		// ***********************************************************************************
	}
}
