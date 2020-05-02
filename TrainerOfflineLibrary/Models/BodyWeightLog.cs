using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerOfflineLibrary.Models
{
    public class BodyWeightLog
    {
        /// <summary>
        /// ID of Body Weight Log
        /// </summary>
        [Key]
        public int BodyWeightLogID { get; set; }

        /// <summary>
        /// Current body weight
        /// </summary>
        public float BodyWeight { get; set; }

        /// <summary>
        /// Date of measurement a body weight
        /// </summary>
        public DateTime MeasurementDate { get; set; }
    }
}
