using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Utility.NhacLichLamViec
{
    public class Job
    {
        private bool isDone;
        private Point timeStart;
        private string content;
        private DateTime dayJob;
        public bool IsDone { get => isDone; set => isDone = value; }
        public Point TimeStart { get => timeStart; set => timeStart = value; }
        public string Content { get => content; set => content = value; }
        public DateTime DayJob { get => dayJob; set => dayJob = value; }
    }
}
