using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Models
{
    public class Prescription
    {
        private int idPrescritpion;

        public int GetIdPrescritpion()
        {
            return idPrescritpion;
        }

        public void SetIdPrescritpion(int value)
        {
            idPrescritpion = value;
        }

        private DateTime date;

        public DateTime GetDate()
        {
            return date;
        }

        public void SetDate(DateTime value)
        {
            date = value;
        }

        private DateTime dueDate;

        public DateTime GetDueDate()
        {
            return dueDate;
        }

        public void SetDueDate(DateTime value)
        {
            dueDate = value;
        }

        private int idPatient;

        public int GetIdPatient()
        {
            return idPatient;
        }

        public void SetIdPatient(int value)
        {
            idPatient = value;
        }

        private Patient patient;

        public Patient GetPatient()
        {
            return patient;
        }

        public void SetPatient(Patient value)
        {
            patient = value;
        }

        private int idDoctor;

        public int GetIdDoctor()
        {
            return idDoctor;
        }

        public void SetIdDoctor(int value)
        {
            idDoctor = value;
        }

        private Doctor doctor;

        public Doctor GetDoctor()
        {
            return doctor;
        }

        public void SetDoctor(Doctor value)
        {
            doctor = value;
        }
    }
}
