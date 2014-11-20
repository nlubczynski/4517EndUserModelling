using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Models
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class LifeTile
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public LifeTile()
        {
            Name = "DefaultLifeTile";
            Value = 0;
        }
    }
}
