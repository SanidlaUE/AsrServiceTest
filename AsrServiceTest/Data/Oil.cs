using AsrServiceTest.Data.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Data
{
    internal class Oil : IProduct
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name = "Oil";
        public string Name
        {
            get { return name; }
        }

        private int price = 200;
        public int Price
        {
            get { return price; }
        }
        private int state;
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        private readonly Random _random;
        public Oil()
        {
            _random = new Random();
            State = _random.Next(0, 2);
        }



    }
}
