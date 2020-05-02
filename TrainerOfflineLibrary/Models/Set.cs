using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerOfflineLibrary.Models
{
    public class Set
    {
        /// <summary>
        /// Id of Set
        /// </summary>
        [Key] 
        public int SetID { get; set; }

        /// <summary>
        /// Exercise performed in a given Set
        /// </summary>
        public Exercise Exercise { get; set; }

        /// <summary>
        /// Weight performed in a given set
        /// Depends on the type of exercise
        /// Can be a null
        /// </summary>
        public float? Weight { get; set; }

        /// <summary>
        /// The number of minimum repetitions performed in a given set
        /// Depends on the type of exercise
        /// </summary>
        public int? RepetitionsMin { get; set; }

        /// <summary>
        /// The number of maximum repetitions performed in a given set
        /// Depends on the type of exercise
        /// </summary>
        public int? RepetitionsMax { get; set; }

        /// <summary>
        /// Distance traveled in a given set
        /// Depends on the type of exercise
        /// </summary>
        public int? Distance { get; set; }

        /// <summary>
        /// Duration of the set
        /// Depends on the type of exercise
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Rest time after a given series
        /// </summary>
        public int RestTime { get; set; }

        /// <summary>
        /// The routine in which the Set was performade
        /// </summary>
        public Routine Routine { get; set; }
    }
}
