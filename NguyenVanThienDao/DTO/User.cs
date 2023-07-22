using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class User
    {
        private string id;
        public string Id { 
            get { return id; } 
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string info;
        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private bool gender;
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public User(string id,string name, DateTime dob, string info, bool gender)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dob;
            this.info = info;
            this.gender = gender;
        }

    }
}
