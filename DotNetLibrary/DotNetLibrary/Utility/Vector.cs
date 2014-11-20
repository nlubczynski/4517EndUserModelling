using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Utility
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Vector
    {
        private ArrayList   _objects;
        private Type        _type;

        public Vector(Type type)
        {
            // Store the type
            _type = type;

            // Initiate the underlying array
            _objects = new ArrayList();
        }

        public bool AddObject(object obj)
        {
            if (obj.GetType() == _type)
            {
                _objects.Add(obj);
                return true;
            }
            else
                return false;
        }

        public bool SetAt(int i, object obj)
        {
            if (obj.GetType() == _type)
            {
                _objects[i] = obj;
                return true;
            }
            else
                return false;
        }

        public void RemoveAt(int i)
        {
            _objects.RemoveAt(i);
        }

        public object this[int i]
        {
            get { return _objects[i]; }
        }
    }
}
