using DotNetLibrary.Models;
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
    public class VectorUser
    {
        private ArrayList   _objects;

        public VectorUser()
        {
            _objects = new ArrayList();
        }

        public bool AddObject(User user)
        {
            if (user != null)
            {
                _objects.Add(user);
                return true;
            }
            else
                return false;
        }

        public bool SetAt(int i, User user)
        {
            if (user != null)
            {
                _objects[i] = user;
                return true;
            }
            else
                return false;
        }

        public int size()
        {
            return _objects.Count;
        }

        public object GetAt(int i)
        {
            return (User)_objects[i];
        }

        public void RemoveAt(int i)
        {
            _objects.RemoveAt(i);
        }
    }
}
