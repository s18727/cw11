using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Models
{
    public class Medicament
    {
        private int idMedicament;

        public int GetIdMedicament()
        {
            return idMedicament;
        }

        public void SetIdMedicament(int value)
        {
            idMedicament = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private string description;

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        private string type;

        public string GetType()
        {
            return type;
        }

        public void SetType(string value)
        {
            type = value;
        }
    }
}
