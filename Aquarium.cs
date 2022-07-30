using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    class Aquarium
    {
        private Random _random = new Random();
        private List<Fish> _fishList;
        private int _maxFishCount = 15;

        public Aquarium()
        {
            _fishList = new List<Fish>();
        }

        public bool TryAddFish()
        {
            if(_fishList.Count < _maxFishCount)
            {
                _fishList.Add(new Fish());
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryDeleteFish()
        {
            if (_fishList.Count > 0)
            {
                int randomIndex = _random.Next(_fishList.Count);

                _fishList.RemoveAt(randomIndex);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void OldenAllFish()
        {
            List<Fish> fishList = new List<Fish>();

            foreach (Fish fish in _fishList)
            {
                fishList.Add(fish);
            }

            foreach (Fish fish in fishList)
            {
                fish.Olden();

                if (fish.IsAlive == false)
                {
                    _fishList.Remove(fish);
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Аквариум:");

            for(int i = 0; i < _maxFishCount; i++)
            {
                Console.Write((i+1) + ") ");

                if(i < _fishList.Count)
                {
                    Console.WriteLine(_fishList[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
