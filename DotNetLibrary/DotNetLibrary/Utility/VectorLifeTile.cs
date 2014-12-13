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
    public class VectorLifeTile
    {
        private ArrayList   _objects;

        public VectorLifeTile()
        {
            _objects = new ArrayList();
        }

        public bool AddObject(Models.LifeTile obj)
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

        public Models.LifeTile GetAt(int i)
        {
            return (Models.LifeTile)_objects[i];
        }

        public void RemoveAt(int i)
        {
            _objects.RemoveAt(i);
        }
    }
}
