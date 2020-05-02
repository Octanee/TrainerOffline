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
        IExerciseRepository Exercises { get; }

        int Complete();

    }
}
