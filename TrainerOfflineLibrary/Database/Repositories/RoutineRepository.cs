using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database.Repositories.Interfaces;
using TrainerOfflineLibrary.Models;

namespace TrainerOfflineLibrary.Database.Repositories
{
    public class RoutineRepository : Repository<Routine>, IRoutineRepository
    {
        public RoutineRepository(GymContext context) : base(context)
        {
        }

        public GymContext GymContext
        {
            get { return Context as GymContext; }
        }
    }
}
