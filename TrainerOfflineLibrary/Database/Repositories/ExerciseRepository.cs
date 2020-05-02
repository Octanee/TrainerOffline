using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database.Repositories.Interfaces;
using TrainerOfflineLibrary.Enums;
using TrainerOfflineLibrary.Models;

namespace TrainerOfflineLibrary.Database.Repositories
{
    public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(GymContext context) : base(context)
        {
        }

        public IEnumerable<Exercise> GetExercisesOfType(Exercise_type type)
        {
            return GymContext.Exercises
                .Where(e => e.Exercise_type == type)
                .OrderBy(e => e.Name)
                .ToList();
        }

        public IEnumerable<Exercise> GetExercisesOfBodypart(Bodypart bodypart)
        {
            return GymContext.Exercises
                .Where(e => e.Bodypart == bodypart)
                .OrderBy(e => e.Name)
                .ToList();
        }

        public GymContext GymContext
        {
            get { return Context as GymContext; }
        }
    }
}
