using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteCustomControl.Models
{
    public class Lab
    {
        public int LabId { get; set; }
        public string LabName { get; set; }

        public static List<Lab> AllLabs
        {
            get
            {
                return new List<Lab>()
                {
                    new Lab{ LabId=1, LabName="X-Ray Lab" },
                    new Lab{ LabId=2, LabName="Sonography Lab" },
                    new Lab{ LabId=3, LabName="Radio Lab" },
                    new Lab{ LabId=4, LabName="Pathology Lab" },
                    new Lab{ LabId=4, LabName="Cardio Lab" }                   
                };
            }
        }

        public static IEnumerable<Lab> GetLabs(string name)
        {
            return AllLabs.Where<Lab>(x => x.LabName.ToLower().StartsWith(name.ToLower())).ToList();
        }
    }
}