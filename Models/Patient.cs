using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Models
{
    public class Patient
    {
        private int idPatient;

        public int GetIdPatient()
        {
            return idPatient;
        }

        public void SetIdPatient(int value)
        {
            idPatient = value;
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

        private DateTime birthdate;

        public DateTime GetBirthdate()
        {
            return birthdate;
        }

        public void SetBirthdate(DateTime value)
        {
            birthdate = value;
        }
    }
}
