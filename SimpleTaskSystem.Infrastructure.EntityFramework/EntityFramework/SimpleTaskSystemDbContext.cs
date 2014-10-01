using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;
using SimpleTaskSystem.People;
using SimpleTaskSystem.Tasks;

namespace SimpleTaskSystem.EntityFramework
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        public virtual IDbSet<Person> People { get; set; }
        public virtual IDbSet<Task> Tasks { get; set; }

        public SimpleTaskSystemDbContext()
            : base("TaskDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...

            modelBuilder.Entity<Person>().ToTable("StsPeople"); //Sample
            modelBuilder.Entity<Task>().ToTable("StsTasks").HasOptional(t => t.AssignedPerson);
        }
    }
}
