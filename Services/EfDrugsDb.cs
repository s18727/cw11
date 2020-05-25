using APBD11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD11.Services
{
    public class EfDrugsDb : IDrugsDb
    {
        private readonly DrugsDbContext _context;
        public EfDrugsDb(DrugsDbContext context)
        {
            _context = context;
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            if (doctor.FirstName.Equals(""))
            {
                throw new Exception("brak imienia");
            }
            if (doctor.LastName.Equals(""))
            {
                throw new Exception("brak nazwiska");
            }
            if (doctor.Email.Equals(""))
            {
                throw new Exception("brak maila");
            }

            doctor.IdDoctor = _context.Doctors.Max().IdDoctor + 1;
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }

        public void DeleteDoctor(int id)
        {
            var doc = _context.Doctors.FirstOrDefault(doc => doc.IdDoctor == id);
            if (doc == null)
            {
                throw new Exception();
            }
            _context.Doctors.Remove(doc);
            _context.SaveChanges();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public Doctor ModifyDoctor(Doctor doc)
        {
            var dok = _context.Doctors.FirstOrDefault(dok => dok.IdDoctor == doc.IdDoctor);
            if (dok == null)
            {
                throw new Exception();
            }

            dok.FirstName = doc.FirstName != null ? doc.FirstName : dok.FirstName;
            dok.LastName = doc.LastName != null ? doc.LastName : dok.LastName;
            dok.Email = doc.Email != null ? doc.Email : dok.Email;

            _context.Doctors.Update(dok);
            _context.SaveChanges();

            return dok;
        }

        public void Seed()
        {
            var doctor1 = new Doctor
            {
                IdDoctor = 1,
                FirstName = "Andrzej",
                LastName = "Grabowski",
                Email = "andrzej.grabowski@med.pl"
            };

            var doctor2 = new Doctor
            {
                IdDoctor = 2,
                FirstName = "Paulina",
                LastName = "Mono",
                Email = "paulina.mono@med.pl"
            };

            _context.Doctors.Add(doctor1);
            _context.Doctors.Add(doctor2);

            var patient1 = new Patient
            {
                IdPatient = 1,
                FirstName = "Andrzej",
                LastName = "Nowak",
                Birthdate = DateTime.Now
            };

            var patient2 = new Patient
            {
                IdPatient = 2,
                FirstName = "Karol",
                LastName = "Banan",
                Birthdate = DateTime.Now
            };

            _context.Patients.Add(patient1);
            _context.Patients.Add(patient2);

            var prescription1 = new Prescription
            {
                IdPrescritpion = 1,
                Date = DateTime.Now,
                DueDate = DateTime.Now,
                IdPatient = 1,
                IdDoctor = 2
            };

            var prescription2 = new Prescription
            {
                IdPrescritpion = 2,
                Date = DateTime.Now,
                DueDate = DateTime.Now,
                IdPatient = 2,
                IdDoctor = 1
            };

            _context.Prescriptions.Add(prescription1);
            _context.Prescriptions.Add(prescription2);

            var medicament1 = new Medicament
            {
                IdMedicament = 1,
                Name = "C",
                Description = "wzmocnienie",
                Type = "profilaktyczny"
            };

            var medicament2 = new Medicament
            {
                IdMedicament = 2,
                Name = "apap",
                Description = "na ból głowy",
                Type = "przeciwbólowy"
            };

            _context.Medicaments.Add(medicament1);
            _context.Medicaments.Add(medicament2);

            var prescription_medicament1 = new Prescription_Medicament
            {
                IdMedicament = 1,
                IdPrescritpion = 1,
                Dose = 100,
                Details = "-"
            };

            var prescription_medicament2 = new Prescription_Medicament
            {
                IdMedicament = 2,
                IdPrescritpion = 2,
                Dose = 600,
                Details = "-"
            };

            _context.Prescriptions_Medicaments.Add(prescription_medicament1);
            _context.Prescriptions_Medicaments.Add(prescription_medicament2);
        }
    }
}
