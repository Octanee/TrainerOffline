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

        private IBodyWeightLogRepository bodyWeightLog;
        private IExerciseRepository exercises;
        private IRoutineRepository routine;
        private ISetRepository set;
        private ISetLogRepository setLog;
        private ITrainingPlanRepository trainingPlan;

        public UnitOfWork(GymContext context)
        {
            this.gymContext = context;
        }

        public IBodyWeightLogRepository BodyWeightLog
        {
            get
            {
                if (bodyWeightLog == null)
                {
                    bodyWeightLog = new BodyWeightLogRepository(gymContext);
                }
                return bodyWeightLog;
            }
        }

        public IExerciseRepository Exercises
        {
            get
            {
                if (exercises == null)
                {
                    exercises = new ExerciseRepository(gymContext);
                }
                return exercises;
            }
        }

        public IRoutineRepository Routine
        {
            get
            {
                if (routine == null)
                {
                    routine = new RoutineRepository(gymContext);
                }
                return routine;
            }
        }

        public ISetRepository Set
        {
            get
            {
                if (set == null)
                {
                    set = new SetRepository(gymContext);
                }
                return set;
            }
        }

        public ISetLogRepository SetLog
        {
            get
            {
                if (setLog == null)
                {
                    setLog = new SetLogRepository(gymContext);
                }
                return setLog;
            }
        }

        public ITrainingPlanRepository TrainingPlan
        {
            get
            {
                if (trainingPlan == null)
                {
                    trainingPlan = new TrainingPlanRepository(gymContext);
                }
                return trainingPlan;
            }
        }

        public int Save()
        {
            return gymContext.SaveChanges();
        }

        public void Dispose()
        {
            gymContext.Dispose();
        }
    }
}
