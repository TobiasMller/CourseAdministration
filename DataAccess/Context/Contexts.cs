using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;

namespace DataAccess.Context
{
    public class Contexts : DbContext, INotifyCollectionChanged
    {

        public Contexts() : base("SchoolContext") { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }


        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
