using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    class Aquarium
    {
        private Random _random = new Random();
        private List<Fish> _fishes;
        private int _maxFishCount = 15;

        public Aquarium()
        {
            _fishes = new List<Fish>();
        }

        public bool TryAddFish()
        {
            if(_fishes.Count < _maxFishCount)
            {
                _fishes.Add(new Fish());
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryDeleteFish()
        {
            if (_fishes.Count > 0)
            {
                int randomIndex = _random.Next(_fishes.Count);

                _fishes.RemoveAt(randomIndex);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void OldenAllFish()
        {
            for(int i = 0; i < _fishes.Count; i++)
            {
                _fishes[i].Olden();

                if (_fishes[i].IsAlive == false)
                {
                    _fishes.Remove(_fishes[i]);
                    i--;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Аквариум:");

            for(int i = 0; i < _maxFishCount; i++)
            {
                Console.Write((i+1) + ") ");

                if(i < _fishes.Count)
                {
                    Console.WriteLine(_fishes[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
