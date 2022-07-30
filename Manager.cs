using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    class Manager
    {
        private const string CommandExit = "Exit";
        private const string CommandAddFish = "Add";
        private const string CommandSkip = "Skip";
        private const string CommandDeleteFish = "Delete";

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

                Console.Write("Введите команду: ");
                bool isCorrect = false;
                _commandPosition = new CursorPosition(Console.CursorLeft, Console.CursorTop);

                while (isCorrect == false)
                {
                    isCorrect = true;

                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case CommandAddFish:
                            aquarium.TryAddFish();
                            break;
                        case CommandDeleteFish:
                            aquarium.TryDeleteFish();
                            break;
                        case CommandSkip:
                            break;
                        case CommandExit:
                            isContinue = false;
                            break;
                        default:
                            isCorrect = false;
                            break;
                    }

                    ClearText(command);
                }

                aquarium.OldenAllFish();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nМеню: ");
            Console.WriteLine($"{CommandAddFish} - Добавить рыбку. ");
            Console.WriteLine($"{CommandDeleteFish} - Удалить рандомную рыбку. ");
            Console.WriteLine($"{CommandSkip} - Пропустить итерацию. ");
            Console.WriteLine($"{CommandExit } - Выход. ");
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
    }
}
