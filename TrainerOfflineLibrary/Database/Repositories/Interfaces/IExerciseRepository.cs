using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Enums;
using TrainerOfflineLibrary.Models;

namespace TrainerOfflineLibrary.Database.Repositories.Interfaces
{
    public interface IExerciseRepository : IRepository<Exercise>
    {
        IEnumerable<Exercise> GetExercisesOfBodypart(Bodypart bodypart);
        IEnumerable<Exercise> GetExercisesOfType(Exercise_type type);
    }
}
