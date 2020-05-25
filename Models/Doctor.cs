using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Models
{
    public class Doctor
    {
        private int idDoctor;

        public int GetIdDoctor()
        {
            return idDoctor;
        }

        public void SetIdDoctor(int value)
        {
            idDoctor = value;
        }

        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        private string lastName;

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        private string email;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }
    }
}
