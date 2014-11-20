using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Models
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Job
    {
        public string Name { get; set; }
        public bool DegreeRequired { get; set; }

        public Job()
        {
            Name = "NoJob";
            DegreeRequired = false;
        }
 
    }
}
