using System;
using System.Collections.Generic;
using System.Linq;

namespace c__Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitContext db = new();

            var doctor = new Doctor { Name = "Petr Hiler" };
            var patient = new Patient { Name = "Linda Diziz", Gender = "Female", BirthDate = new DateTime(1994, 03, 7), Address = "Kostroma, Bolshaya st. 74/1" };
            var patient2 = new Patient { Name = "Henry Ilnes", Gender = "Male", BirthDate = new DateTime(2000, 11, 11), Address = "Moscow, Lenina st. 1a" };
            var medicine = new Medicine { Name = "Panaceya", UseMethod = "Just take it in!", Effects = "Relief everything, pain fades down", SideEffects = "Never mentioned" };
            var visit = new Visit
            {
                VisitDate = new DateTime(2020, 11, 11),
                VisitPlace = "Home|Kostroma, Bolshaya st. 74/1",
                Diagnosis = "COVID-19",
                Recommendation = "Drink a lot of water, eat VitaminC pills twice a day, stay in bed.",
                Patient = patient,
                Doctor = doctor,
                Medicine = medicine
            };
            var visit2 = new Visit
            {
                VisitDate = new DateTime(2021, 11, 11),
                VisitPlace = "Home|Moscow, Lenina st. 1a",
                Diagnosis = "Fly",
                Recommendation = "Wait for 7 days, it will ends soon,",
                Patient = patient2,
                Doctor = doctor
            };
            db.Visits.Add(visit);
            db.Visits.Add(visit2);
            db.Medicines.Add(medicine);
            db.Patients.Add(patient);
            db.Patients.Add(patient);
            db.Doctors.Add(doctor);
            db.SaveChanges();

            var vst = db.Visits;
            var med = db.Medicines;
            //visitsInCurrentDayCounter
            var vCounter = 0;
            //patientsWithCurrentIllnessCounter
            var pCounter = 0;
            var currentIllness = "COVID-19";

            foreach (var vs in vst)
            {
                if (vs.VisitDate == new DateTime(2021, 11, 11))
                {
                    vCounter++;
                    Console.WriteLine(
                        $"Visit {vs.Id}, visit date - {vs.VisitDate.ToString("dd.MM.yyyy")}"
                    );
                }
                Console.WriteLine("_________________________________________________________");

                if (vs.Diagnosis == currentIllness)
                {
                    pCounter++;
                }
            }
            Console.WriteLine($"__pCounter_=_{pCounter}_______vCounter_=_{vCounter}_______");

            var specialInputedId = 1;

            foreach (var md in med)
            {
                if (md.Id == specialInputedId)
                {
                    Console.WriteLine(
                        $"Side effects of the medicine {md.Name} are '{ md.SideEffects}'"
                    );
                }
            }
        }
    }
}

