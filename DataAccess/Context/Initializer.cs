using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class Initializer : CreateDatabaseIfNotExists<Contexts>
    {


        protected override void Seed(Contexts context)
        {

            Student bob = new Student("Bob", 85);
            Student Hans = new Student("Hans", 20);
            Student keld = new Student("keld", 31);
            Student ingolf = new Student("ingolf", 54);
            Student lars = new Student("lars", 40);
            Student trille = new Student("trille", 20);

            Course Mathematics = new Course("Math", "Bld 203, Room 201");
            Course English = new Course("English", "Bld 5, Room 2");

            context.Courses.Add(Mathematics);
            context.Courses.Add(English);

            context.Students.Add(bob);
            context.Students.Add(Hans);
            context.Students.Add(keld);
            context.Students.Add(ingolf);
            context.Students.Add(lars);
            context.Students.Add(trille);


            Mathematics.Students.Add(bob);
 

            Mathematics.Students.Add(Hans);

            Mathematics.Students.Add(keld);

            English.Students.Add(bob);


            English.Students.Add(Hans);

            English.Students.Add(trille);

            English.Students.Add(lars);


            context.Courses.Add(Mathematics);
 

            context.SaveChanges();
            

        }


    }
}
