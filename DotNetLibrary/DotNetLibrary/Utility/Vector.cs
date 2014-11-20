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
        private bool        _initiated;

        public Vector(Type type)
        {
            // Store the type
            _type = type;

            // Initiate the underlying array
            _objects = new ArrayList();
            _initiated = true;
        }

        public Vector()
        {
            _initiated = false;
        }

        public void setType(object type)
        {
            // Store the type
            _type = type.GetType();

            // Initiate the underlying array
            _initiated = true;
        }

        public bool AddObject(object obj)
        {
            if (_initiated) return false;

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
            if (_initiated) return false;

            if (obj.GetType() == _type)
            {
                _objects[i] = obj;
                return true;
            }
            else
                return false;
        }

        public object GetAt(int i)
        {
            return _objects[i];
        }

        public void RemoveAt(int i)
        {
            if (_initiated) return;
            _objects.RemoveAt(i);
        }
    }
}
