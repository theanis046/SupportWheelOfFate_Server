using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core
{
    public class Shift
    {
        public int shiftId { get; set; } = 0;
        public Engineer engineer { get; set; }
    }
}
