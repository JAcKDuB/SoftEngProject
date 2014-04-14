using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
namespace Library
{
    /// <summary>
    /// Class Patron
    /// </summary>
    [Serializable]
    public class Patron : object
    {
        //Patron member data
        public string _name { get; set; }
        public string _address { get; set; }
        public string _phoneNumber { get; set; }
        private uint _cardNumber;
        public uint CardNumber { get { return _cardNumber; } }
        public uint _maxCheckouts { get; set; }
        public bool _overdueMedia { get; set; }
        private DateTime _birthday;
        private int ageThreshold = 18;
        public SortedDictionary<uint, Media> _currentChecked { get; set; }
        public static Patron _none = new Patron();
        public static Patron None { get {return _none;} set {_none = value;} }

        //validation and display messages/popups
        static Regex validator;
        private string noneChecked = "This patron does not have any checked-out books to be removed.";
        public static string nameDisplay = "\nName: ";

        /// <summary>
        /// Purpose: default constructor
        /// </summary>
        public Patron()
        {
            _name = "";
            _address = "";
            _birthday = DateTime.Today;
            _phoneNumber = "";
            _overdueMedia = false;
            _currentChecked = new SortedDictionary<uint, Media>();
            _maxCheckouts = 0;
            _cardNumber = 0;
        }
        /// <summary>
        /// Purpose: parameterized constructor
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cardNumber">uint</param>
        /// <param name="address">string</param>
        /// <param name="phoneNumber">string</param>
        /// <param name="birthday">DateTime</param>
        public Patron(string name, uint cardNumber, string address, string phoneNumber, DateTime birthday)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _birthday = birthday;
            _overdueMedia = false;
            _cardNumber = cardNumber;
            _currentChecked = new SortedDictionary<uint, Media>();
            if (getAge() >= ageThreshold)
            {
                _maxCheckouts = 6; //adult
            }
            else
            {
                _maxCheckouts = 3; //child
            }
        }
        
        /// <summary>
        /// Purpose: to return number of checked books
        /// </summary>
        /// <returns>int</returns>
        public int getNumChecked()
        {
            return _currentChecked.Count;
        }
        /// <summary>
        /// Purpose:calculate age based on birthday
        /// </summary>
        /// <returns>int</returns>
        public int getAge()
        {
            int _age = 0;
            return _age = ((DateTime.Now.Year - _birthday.Year) * 372 +
                (DateTime.Now.Month - _birthday.Month) * 31 + (DateTime.Now.Day - _birthday.Day)) / 372;
        }
        /// <summary>
        /// Purpose: to validate patron info from GUI before saving new object
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="address">string</param>
        /// <param name="city">string</param>
        /// <param name="state">string</param>
        /// <param name="zip">string</param>
        /// <param name="phone">string</param>
        /// <param name="cardNumber">string</param>
        /// <returns></returns>
        public static bool validate(string name, string address, string city, string state, string zip, string phone, string cardNumber)
        {
            validator = new Regex(@"((\d{1,6}\-\d{1,6})|(\d{1,6}\\\d{1,6})|(\d{1,6})(\/)(\d{1,6})|(\w{1}\-?\d{1,6})|(\w{1}\s\d{1,6})|((P\.?O\.?\s)((BOX)|(Box))(\s\d{1,6}))|((([R]{2})|([H][C]))(\s\d{1,6}\s)((BOX)|(Box))(\s\d{1,6}))?)$");
            if (!validator.Match(address).Success)
            {
                MessageBox.Show(address + " was an invalid entry for address. Please try again.");
                return false;
            }
            validator = new Regex(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$");
            if (!validator.Match(city).Success)
            {
                MessageBox.Show(city + "was an invalid entry for city. Please try again.");
                return false;
            }
            validator = new Regex("[A-Z]{2}");
            if (!validator.Match(state).Success)
            {
                MessageBox.Show(state + "was an invalid entry for state. Please try again.");
                return false;
            }
            validator = new Regex(@"^\d{5}$");
            if (!validator.Match(zip).Success)
            {
                MessageBox.Show(zip + "was an invalid entry for zip code. Please try again.");
                return false;
            }
            validator = new Regex(@"^(?:\([1-9]\d{2}\)\ ?|[1-9]\d{2}(?:\-?|\ ?))[1-9]\d{2}[- ]?\d{4}$");
            if (!validator.Match(phone).Success)
            {
                MessageBox.Show(phone + "was an invalid entry for phone number. Please try again.");
                return false;
            }
            validator = new Regex("[0-9]+");
            if (!validator.Match(cardNumber).Success)
            {
                MessageBox.Show(cardNumber + "was an invalid entry for card number. Please try again.");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Purpose: to add media to the _checkedout SortedDictionary (check out)
        /// </summary>
        /// <param name="media">Media</param>
        /// <param name="ID">media ID</param>
        public virtual void addMedia(Media media, uint ID)
        {
            if(_currentChecked.Count <= _maxCheckouts)
            {
                _currentChecked.Add(ID, media);
            }
            else
            {
                MessageBox.Show("You have reached the maximum(" + _maxCheckouts + ") number of checkouts allowed\n");
            }
        }
        /// <summary>
        /// Purpose: Check in media/ remove from _checkedout SD
        /// </summary>
        /// <param name="media">Media</param>
        /// <param name="ID">ID</param>
        public virtual void removeMedia(Media media, uint ID)
        {
            if (_currentChecked.Count == 0)
            {
                MessageBox.Show(noneChecked);
            }
            _currentChecked.Remove(ID);
        }

        /// <summary>
        /// Purpose: display Patron object
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return String.Format(nameDisplay+ _name);
        }
        /// <summary>
        /// Purpose: determine media type allowed
        /// </summary>
        /// <param name="m">Media</param>
        /// <returns>bool</returns>
        public bool allowed(Media m)
        {
            if (getAge() < 18 && m.Mtype == MediaType.ADULTBOOK)
            {
                MessageBox.Show("Checkout not allowed due to age restriction on Adult Books.");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Purpose: determine if patron has overdue books
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>bool</returns>
        public bool overdueBooks(DateTime date)
        {
            bool overdue = false;
            foreach (KeyValuePair<uint,Media> mm in this._currentChecked)
            {
                if (mm.Value.Overdue(date))
                {
                    overdue = true;
                    MessageBox.Show("Checkout not allowed due to overdue books.");
                }
                else
                {
                    overdue = false;
                }
            }
            return overdue;
           
        }
    }

}
