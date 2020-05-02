using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database.Repositories.Interfaces;
using TrainerOfflineLibrary.Models;

namespace TrainerOfflineLibrary.Database
{
    public class SetLogRepository : Repository<SetLog>, ISetLogRepository
    {
        public SetLogRepository(DbContext context) : base(context)
        {
        }

        public GymContext GymContext
        {
            get { return Context as GymContext; }
        }
    }
}
