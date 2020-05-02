using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database.Repositories.Interfaces;

namespace TrainerOfflineLibrary.Database
{
    public interface IUnitOfWork : IDisposable
    {
        IBodyWeightLogRepository BodyWeightLog { get; }
        IExerciseRepository Exercises { get; }
        IRoutineRepository Routine { get; }
        ISetRepository Set { get; }
        ISetLogRepository SetLog { get; }
        ITrainingPlanRepository TrainingPlan { get; }

        int Save();

    }
}
