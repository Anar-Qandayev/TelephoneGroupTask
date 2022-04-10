using System;
using System.Collections.Generic;
using System.Text;

namespace CallTask.Models
{
    public class Contact
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Number { get; set; }

        static Contact()
        {
            _id = 0;
        }
        private Contact()
        {
            _id++;
            Id = _id;
        }

        public Contact(string fullname, string number) : this()
        {
            Fullname = fullname;
            Number = number;
        }
    }
}
