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
    public class SetRepository : Repository<Set>, ISetRepository
    {
        public SetRepository(DbContext context) : base(context)
        {
        }

        public GymContext GymContext
        {
            get { return Context as GymContext; }
        }
    }
}
