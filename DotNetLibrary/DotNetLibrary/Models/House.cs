using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Models
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class House
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Insurance { get; set; }
        public string Description { get; set; }

        public House()
        {
            Name = "DefaultHouse";
            Price = 0;
            Insurance = 0;
            Description = "DefaultDescription";
        }
    }
}
