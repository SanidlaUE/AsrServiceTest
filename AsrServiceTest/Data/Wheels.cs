using AsrServiceTest.Data.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrServiceTest.Data
{
    internal class Wheels : IProduct
    {
        private int id;

        private string name = "Wheels";

        private int price = 300;

        private int state;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Price
        {
            get { return price; }
        }
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        private readonly Random _random;
        public Wheels()
        {
            _random = new Random();
            State = _random.Next(0, 2);
        }
    }
}
