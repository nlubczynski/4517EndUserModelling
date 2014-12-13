using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLibrary.Utility
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class VectorHouse
    {
        private ArrayList   _objects;

        public VectorHouse()
        {
            _objects = new ArrayList();
        }

        public bool AddObject(Models.House obj)
        {
            if (obj != null)
            {
                _objects.Add(obj);
                return true;
            }
            else
                return false;
        }

        public bool SetAt(int i, object obj)
        {
            if (obj != null)
            {
                _objects[i] = obj;
                return true;
            }
            else
                return false;
        }

        public int size()
        {
            return _objects.Count;
        }

        public Models.House GetAt(int i)
        {
            return (Models.House)_objects[i];
        }

        public void RemoveAt(int i)
        {
            _objects.RemoveAt(i);
        }
    }
}
