using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerOfflineLibrary.Models
{
    public class Routine
    {
        /// <summary>
        /// ID of the Routine
        /// </summary>
        [Key]
        public int RoutineID { get; set; }

        /// <summary>
        /// Name of the Routine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Day of the week when the Routine is performed
        /// Can be a null
        /// </summary>
        public DayOfWeek? DayOfWeek { get; set; }

        /// <summary>
        /// List of planned series
        /// </summary>
        public List<Set> Sets { get; set; } = new List<Set>();
    }
}
