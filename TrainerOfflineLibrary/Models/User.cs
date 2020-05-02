using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerOfflineLibrary.Models
{
    public class User
    {
        /// <summary>
        /// User ID
        /// </summary>
        [Key] 
        public int UserID { get; set; }

        /// <summary>
        /// Name of the User
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Current performed training plan
        /// </summary>
        public TrainingPlan CurrentTrainingPlan { get; set; }
    }
}
