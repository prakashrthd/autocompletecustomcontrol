using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteCustomControl.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }

        public static List<Patient> AllPatients
        {
            get
            {
                return new List<Patient>()
                {
                    new Patient{ PatientId=1, PatientName="Prakash Rathod" },
                    new Patient{ PatientId=2, PatientName="Sanket Dehbar" },
                    new Patient{ PatientId=3, PatientName="Amol Jain" },
                    new Patient{ PatientId=4, PatientName="Ananad Shah" },
                    new Patient{ PatientId=4, PatientName="Bharat Jograna" },
                    new Patient{ PatientId=4, PatientName="Pratik Soni" },
                    new Patient{ PatientId=4, PatientName="Kaushik Patel" },
                };
            }
        }

        public static IEnumerable<Patient> GetPatients(string name)
        {
            return AllPatients.Where<Patient>(x => x.PatientName.ToLower().StartsWith(name.ToLower())).ToList();
        }
    }
}