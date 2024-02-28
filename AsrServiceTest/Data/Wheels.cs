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
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name = "Wheels";
        public string Name
        {
            get { return name; }
        }
        private int price = 300;
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
        public Wheels()
        {
            _random = new Random();
            State = _random.Next(0, 2);
        }
    }
}
