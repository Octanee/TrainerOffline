using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerOfflineLibrary.Models
{
    public class SetLog
    {
        /// <summary>
        /// ID of Set log
        /// </summary>
        [Key] 
        public int SetLogID { get; set; }

        /// <summary>
        /// Set to be saved
        /// </summary>
        public Set Set { get; set; }

        /// <summary>
        /// Date of performance a Set
        /// </summary>
        public DateTime PerformanceDate { get; set; }

    }
}
