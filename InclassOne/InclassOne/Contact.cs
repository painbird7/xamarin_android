using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace InclassOne
{
    [Table("ContactDB")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactType { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}