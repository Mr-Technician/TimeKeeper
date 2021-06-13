using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeKeeper.Data
{
    /// <summary>
    /// Stores the times recorded for a day
    /// </summary>
    public class Day
    {
        /// <summary>
        /// Stores the times worked within a day
        /// </summary>
        public IList<UniqueTimeSpan> Times { get; set; }

        /// <summary>
        /// The day the times are logged for
        /// </summary>
        public DateTime Date { get; set; }

        public Day(DateTime date)
        {
            Date = date;
        }
    }
}
