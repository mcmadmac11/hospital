using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Period
    {
        public DateTime start { get; private set; }
        public DateTime end { get; private set; }

        public Period(DateTime start, DateTime end)
        {
            this.start = start.Date;
            this.end = end.Date;
            VerifyTimeIsLinear();
        }

        private void VerifyTimeIsLinear()
        {
            if (start > end)
            {
                throw new ArgumentException("The start date may not be after the end date.");
            }
        }

    }
}
