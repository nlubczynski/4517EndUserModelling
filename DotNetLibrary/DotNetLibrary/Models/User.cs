using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLibrary.Models
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class User
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public bool College { get; set; }        
        public bool Insurance { get; set; }
        public House House { get; set; }
        public Salary Salary { get; set; }
        public Job Job { get; set; }
        public Tile CurrentTile { get; set; }
        public Gender Gender { get; set; }
        public Stock Stock { get; set; }
        public Image Image { get; set; }
        public Utility.VectorLifeTile LifeTiles { get; private set; }
        public bool MissNextTurn { get; set; }

        public int NumberOfKids { get; set; }
        public User()
        {
            Name = "John Doe";
            Money = 0.0;
            College = false;
            Insurance = false;
            House = null;
            Salary = null;
            Job = null;
            CurrentTile = null;
            Gender = Gender.MALE;
            Stock = Stock.NO_STOCK;
            LifeTiles = new Utility.VectorLifeTile();
        }

        public User setImage(Image image)
        {
            this.Image = image;
            return this;
        }

        public User setName(string name)
        {
            this.Name = name;
            return this;
        }

        public User setMoney(double money)
        {
            this.Money = money;
            return this;
        }

        public User setGender(Gender gender)
        {
            this.Gender = gender;
            return this;
        }

        public User setCollege(bool college)
        {
            this.College = college;
            return this;
        }

        public User setInsurance(bool insurance)
        {
            this.Insurance = insurance;
            return this;
        }

        public User setHouse(House house)
        {
            this.House = house;
            return this;
        }

        public User setSalary(Salary salary)
        {
            this.Salary = salary;
            return this;
        }

        public User setJob(Job job)
        {
            this.Job = job;
            return this;
        }
            
        public User setCurrentTile(Tile tile)
        {
            this.CurrentTile = tile;
            return this;
        }
           
        public User setStock(Stock stock)
        {
            this.Stock = stock;
            return this;
        }

        public void addMoney(double d)
        {
            Money += d;
        }

        public void subtractMoney(double d)
        {
            addMoney(-d);
        }
        
    }
}
