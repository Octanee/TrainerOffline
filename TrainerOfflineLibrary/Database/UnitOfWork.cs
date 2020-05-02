using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database.Repositories;
using TrainerOfflineLibrary.Database.Repositories.Interfaces;

namespace TrainerOfflineLibrary.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GymContext gymContext;

        public UnitOfWork(GymContext context)
        {
            this.gymContext = context;

            Exercises = new ExerciseRepository(gymContext);
        }

        public IExerciseRepository Exercises { get; private set; }

        public int Complete()
        {
            return gymContext.SaveChanges();
        }

        public void Dispose()
        {
            gymContext.Dispose();
        }
    }
}
