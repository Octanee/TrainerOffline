using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerOfflineLibrary.Models
{
    public class TrainingPlan
    {
        /// <summary>
        /// Training plan ID
        /// </summary>
        [Key] 
        public int TrainingPlanID { get; set; }

        /// <summary>
        /// Name of the Training Plan
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of planned routines
        /// </summary>
        public List<Routine> Routines { get; set; } = new List<Routine>();
    }
}
