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
    public class VectorTile
    {
        private ArrayList   _objects;

        public VectorTile()
        {
            _objects = new ArrayList();
        }

        public bool AddObject(Tile tile)
        {
            if (tile != null)
            {
                _objects.Add(tile);
                return true;
            }
            else
                return false;
        }

        public bool SetAt(int i, Tile tile)
        {
            if (tile != null)
            {
                _objects[i] = tile;
                return true;
            }
            else
                return false;
        }

        public int size()
        {
            return _objects.Count;
        }

        public Tile GetAt(int i)
        {
            return (Tile)_objects[i];
        }

        public void RemoveAt(int i)
        {
            _objects.RemoveAt(i);
        }
    }
}
