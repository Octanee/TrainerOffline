using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Enums;

namespace TrainerOfflineLibrary.Models
{
    public class Exercise
    {
        /// <summary>
        /// Id of Exercise
        /// </summary>
        [Key]
        public int ExcerciseID { get; set; }

        /// <summary>
        /// Name of the Exercise
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Body part that works while performing the Exercise
        /// </summary>
        public Bodypart Bodypart { get; set; }

        /// <summary>
        /// The type of Exercise, what type of series is performed for a given Exercise
        /// </summary>
        public Exercise_type Exercise_type { get; set; }

        /// <summary>
        /// Note about performing the exercise
        /// Can be a null
        /// </summary>
        public string Note { get; set; }
    }
}
