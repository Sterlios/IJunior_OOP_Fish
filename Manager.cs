using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    class Manager
    {
        private const string _exit = "Exit";
        private const string _addFish = "Add";
        private const string _skip = "Skip";
        private const string _deleteFish = "Delete";
        private CursorPosition _commandPosition;

        public void Work()
        {
            Aquarium aquarium = new Aquarium();
            bool isContinue = true;

            while (isContinue)
            {
                Console.Clear();

                aquarium.ShowInfo();

                ShowMenu();

                ChooseCommand(aquarium, ref isContinue);

                aquarium.OldenAllFish();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nМеню: ");
            Console.WriteLine($"{_addFish} - Добавить рыбку. ");
            Console.WriteLine($"{_deleteFish} - Удалить рыбку. ");
            Console.WriteLine($"{_skip} - Пропустить итерацию. ");
            Console.WriteLine($"{_exit} - Выход. ");
        }
        private void ClearText(string text)
        {
            Console.SetCursorPosition(_commandPosition.X, _commandPosition.Y);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(_commandPosition.X, _commandPosition.Y);
        }

        private void ChooseCommand(Aquarium aquarium, ref bool isContinue)
        {
            Console.Write("Введите команду: ");
            bool isCorrect = false;
            _commandPosition = new CursorPosition(Console.CursorLeft, Console.CursorTop);

            while (isCorrect == false)
            {
                isCorrect = true;

                string command = Console.ReadLine();

                switch (command)
                {
                    case _addFish:
                        aquarium.TryAddFish();
                        break;
                    case _deleteFish:
                        aquarium.TryDeleteFish();
                        break;
                    case _skip:
                        break;
                    case _exit:
                        isContinue = false;
                        break;
                    default:
                        isCorrect = false;
                        break;
                }

                ClearText(command);
            }
        }
    }
}
