﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Cage
    {
        public string CageSerial { get; set; }
        public string Length { get; set;}
        public string Width { get; set;}
        public string Height { get; set;}
        public string Material { get; set;}

        public Cage()
        {
            CageSerial = "None";
            Length= "0"; Width = "0";
            Height = "0";
            Material = "None";
        }
        public Cage(string cageSerial, string length, string width, string height, string material)
        {
            CageSerial = cageSerial;
            Length = length;
            Width = width;
            Height = height;
            Material = material;
        }
    }
}