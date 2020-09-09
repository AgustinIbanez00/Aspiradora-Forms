using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspiradora_Forms
{
    public enum PlaceState
    {
        CLEAN,
        DIRTY
    }

    public class Place
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public PlaceState State { get; set; }
        //public Cleaner Cleaner { get; set; }

    }
}
