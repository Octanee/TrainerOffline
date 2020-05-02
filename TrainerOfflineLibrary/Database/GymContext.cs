namespace TrainerOfflineLibrary.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TrainerOfflineLibrary.Models;

    public class GymContext : DbContext
    {

        public GymContext()
            : base("name=GymContext")
        {

        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Routine> Routines { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<SetLog> SetLogs { get; set; }
        public DbSet<BodyWeightLog> BodyWeightLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

 
}