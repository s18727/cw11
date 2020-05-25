using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Models
{
    public class Prescription_Medicament
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

        private Medicament medicament;

        public Medicament GetMedicament()
        {
            return medicament;
        }

        public void SetMedicament(Medicament value)
        {
            medicament = value;
        }

        private int idPrescritpion;

        public int GetIdPrescritpion()
        {
            return idPrescritpion;
        }

        public void SetIdPrescritpion(int value)
        {
            idPrescritpion = value;
        }

        private Prescription prescription;

        public Prescription GetPrescription()
        {
            return prescription;
        }

        public void SetPrescription(Prescription value)
        {
            prescription = value;
        }

        private int? dose;

        public int? GetDose()
        {
            return dose;
        }

        public void SetDose(int? value)
        {
            dose = value;
        }

        private string details;

        public string GetDetails()
        {
            return details;
        }

        public void SetDetails(string value)
        {
            details = value;
        }
    }
}
