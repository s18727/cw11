using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Models
{
    public class DrugsDbContext : DbContext
    {
        private DbSet<Doctor> doctors;

        public DbSet<Doctor> GetDoctors()
        {
            return doctors;
        }

        public void SetDoctors(DbSet<Doctor> value)
        {
            doctors = value;
        }

        private DbSet<Patient> patients;

        public DbSet<Patient> GetPatients()
        {
            return patients;
        }

        public void SetPatients(DbSet<Patient> value)
        {
            patients = value;
        }

        private DbSet<Medicament> medicaments;

        public DbSet<Medicament> GetMedicaments()
        {
            return medicaments;
        }

        public void SetMedicaments(DbSet<Medicament> value)
        {
            medicaments = value;
        }

        private DbSet<Prescription> prescriptions;

        public DbSet<Prescription> GetPrescriptions()
        {
            return prescriptions;
        }

        public void SetPrescriptions(DbSet<Prescription> value)
        {
            prescriptions = value;
        }

        private DbSet<Prescription_Medicament> prescriptions_Medicaments;

        public DbSet<Prescription_Medicament> GetPrescriptions_Medicaments()
        {
            return prescriptions_Medicaments;
        }

        public void SetPrescriptions_Medicaments(DbSet<Prescription_Medicament> value)
        {
            prescriptions_Medicaments = value;
        }

        public DrugsDbContext() { }

        public DrugsDbContext(DbContextOptions options)
        :base(options){

        }

    }
}
