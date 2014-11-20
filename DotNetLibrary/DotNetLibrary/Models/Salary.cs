using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Models
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Salary
    {
        public double Wage { get; set; }
        public double Tax { get; set; }

        public Salary()
        {
            Wage = 0;
            Tax = 0;
        }
    }
}
