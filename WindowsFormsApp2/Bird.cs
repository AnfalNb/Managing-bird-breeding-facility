using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Bird
    {
        public  string Serial {get;set;}
        public string species { get; set;  }
        public string subspecies { get; set;  }
        public DateTime hatch_date { get; set; }
        public string gender { get; set; }
        public string cage_number { get; set; }
        public string Mother_serial = null;
        public string Father_serial = null;
        public Bird()
        {
            Serial = "0";
            species = "NONE";
            subspecies = "NONE";
            hatch_date = DateTime.Now;
            gender = "NONE";
            cage_number = "0";
        }
        public Bird(string serial, string species, string subspecies, DateTime hatch_date, string gender, string cage_number, string mother_serial, string father_serial)
        {
            Serial = serial;
            this.species = species;
            this.subspecies = subspecies;
            this.hatch_date = hatch_date;
            this.gender = gender;
            this.cage_number = cage_number;
            Mother_serial = mother_serial;
            Father_serial = father_serial;
        }
    }
}
