using System;
using System.Collections.Generic;
using System.Linq;

namespace c__Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            AscentContext db = new();


            var country = new Country { Name = "Russia" };

            var ascent1 = new Ascent
            {
                DateStart = new DateTime(2022, 01, 01),
                DateEnd = new DateTime(2022, 01, 09),
                Mountain = new Mountain
                {
                    Name = "Elbrus",
                    Height = 5642,
                    Country = country
                },
                Group = new Group
                {
                    Name = "Elbrus Climbers",
                    Climbers = new List<Climber>() {
                        new Climber { Name = "Alex", Address = "Moscow" },
                        new Climber { Name = "Semion", Address = "Moscow" },
                    }
                }
            };
            var ascent2 = new Ascent
            {
                DateStart = new DateTime(2021, 01, 01),
                DateEnd = new DateTime(2021, 01, 01),
                Mountain = new Mountain
                {
                    Name = "Kudikyna",
                    Height = 2315,
                    Country = country
                },
                Group = new Group
                {
                    Name = "Kudikina Climbers",
                    Climbers = new List<Climber>() {
                        new Climber { Name = "Vladislav", Address = "Moscow" },
                        new Climber { Name = "Gennadiy", Address = "Moscow" },
                    }
                }
            };

            db.Ascents.Add(ascent1);
            db.Ascents.Add(ascent2);
            db.SaveChanges();

            var mnts = db.Mountains;

            foreach (var mnt in mnts)
            {
                foreach (var asc in mnt.Ascents.OrderBy(x => x.DateStart))
                {
                    Console.WriteLine(
                        $"Mountain {mnt.Name}, ascent date - {asc.DateStart.ToString("dd.MM.yyyy")}, group - {asc.Group.Name}"
                    );
                }
                Console.WriteLine("_________________________________________________________");
            }
        }
    }
}

