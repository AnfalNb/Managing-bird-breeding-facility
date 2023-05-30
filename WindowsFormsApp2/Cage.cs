using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cage
    {
        public string CageSerial { get; set; }
        public double Length { get; set;}
        public double Width { get; set;}
        public double Height { get; set;}
        public string Material { get; set;}
        //public string UserID { get; set; }
        public Cage()
        {
            CageSerial = "None";
            Length= 0; Width = 0;
            Height = 0;
            Material = "None";
            //UserID = "None";
        }
        public Cage(string cageSerial, double length, double width, double height, string material)
        {
            CageSerial = cageSerial;
            Length = length;
            Width = width;
            Height = height;
            Material = material;
            //UserID = UserID;
        }
    }
}
