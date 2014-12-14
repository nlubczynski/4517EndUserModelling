using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetLibrary.Models;

namespace DotNetLibrary.Utility
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class VectorSalary
    {
        private ArrayList   _objects;

        public VectorSalary()
        {
            _objects = new ArrayList();
        }

        public bool AddObject(Salary salary)
        {
            if (salary!= null)
            {
                _objects.Add(salary);
                return true;
            }
            else
                return false;
        }

        public bool SetAt(int i, Salary salary)
        {
            if (salary != null)
            {
                _objects[i] = salary;
                return true;
            }
            else
                return false;
        }

        public int size()
        {
            return _objects.Count;
        }

        public Salary GetAt(int i)
        {
            return (Salary)_objects[i];
        }

        public void RemoveAt(int i)
        {
            _objects.RemoveAt(i);
        }
    }
}
