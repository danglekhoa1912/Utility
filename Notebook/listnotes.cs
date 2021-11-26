using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.Notebook
{
    [Serializable]
    public class listnotes
    {
        private List<Note> note;

        public List<Note> Note
        {
            get => note;
            set => note = value;
        }

    }
}
