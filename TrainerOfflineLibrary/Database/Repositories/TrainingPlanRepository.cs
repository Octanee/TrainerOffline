using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database.Repositories.Interfaces;
using TrainerOfflineLibrary.Models;

namespace TrainerOfflineLibrary.Database.Repositories
{
    public class TrainingPlanRepository : Repository<TrainingPlan>, ITrainingPlanRepository
    {
        public TrainingPlanRepository(DbContext context) : base(context)
        {
        }

        public GymContext GymContext
        {
            get { return Context as GymContext; }
        }
    }
}
