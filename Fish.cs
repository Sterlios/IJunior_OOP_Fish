using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    class Fish
    {
        public static int Id;
        private Random _random;
        private int _health;
        private int _id;

        public bool IsAlive => _health > 0;

        public Fish()
        {
            int minHelth = 10;
            int maxHelth = 20;

            _random = new Random();
            Id++;
            _id = Id;
            _health = _random.Next(minHelth, maxHelth);
        }

        static Fish()
        {
            Id = 0;
        }

        public void Olden()
        {
            _health--;
        }

        public override string ToString()
        {
            return "Рыба " + _id + " (HP " + _health + ")";
        }
    }
}
