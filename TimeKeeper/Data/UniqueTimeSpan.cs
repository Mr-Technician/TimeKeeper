using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeKeeper.Data
{
    public class UniqueTimeSpan
    {
        public Guid Guid { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public UniqueTimeSpan() => Guid = Guid.NewGuid();
    }
}
