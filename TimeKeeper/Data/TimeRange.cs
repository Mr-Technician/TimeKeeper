using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeKeeper.Data
{
    public class TimeRange
    {
        public Guid Guid { get; set; }
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }

        public TimeSpan GetTime() => Start != null && End != null ? End.Value - Start.Value : default;

        public TimeRange() => Guid = Guid.NewGuid();
    }
}
