using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class MenuItem
    {
        public string Name { get; private set; }

        private List<MenuItem> items = new List<MenuItem>();

        public readonly IWorkingMenuItem WorkingMenuItem;

        public MenuItem(string name, List<MenuItem> items, IWorkingMenuItem workingObject = null)
        {
            Name = name;
            this.items = items;
            WorkingMenuItem = workingObject;
        }

        public void DoWork()
        {
            int currentItem = 0;
            bool window = true;

            if (items.Count == 0)
            { 
                WorkingMenuItem.DoWork(this);
                return;
            }
            while (window)
            {
                Console.Clear(); 
                ConsoleSettings.PrintMenuItems(items, currentItem);
                ConsoleSettings.PrintOrderInfo();
                Console.WriteLine("Управляйте стрелками, Enter - выбор пункта меню");

                var action = Console.ReadKey();
                switch (action.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentItem = (currentItem - 1) % items.Count < 0 
                            ? items.Count - 1 
                            : (currentItem - 1) % items.Count;
                        break;
                    case ConsoleKey.DownArrow:
                        currentItem = (currentItem + 1) % items.Count;
                        break;
                    case ConsoleKey.Enter:
                        items[currentItem].DoWork();
                        if (Name != "Root")
                            window = false;
                        break;
                    default:
                        ConsoleSettings.ErrorMassage("Некорректный ввод, попытайтесь снова");
                        break;
                }
            }
        }
    }
}
