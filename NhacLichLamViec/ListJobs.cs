using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.NhacLichLamViec
{
    [Serializable]
    public class ListJobs
    {
        private List<Job> job;


        public List<Job> Job { get => job; set => job = value; }
    }
}
