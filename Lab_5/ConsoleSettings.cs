using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public static class ConsoleSettings
    {
        public static void PrintMenuItems(List<MenuItem> items, int currentItem)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == currentItem)
                {
                    Console.WriteLine
                    (
                        items[i].WorkingMenuItem != null
                        ? $"->\t{i + 1}. {items[i].Name} {items[i].WorkingMenuItem.ActionInfo}"
                        : $"->\t{i + 1}. {items[i].Name}"
                    );
                }
                else
                {
                    Console.WriteLine
                    (
                        items[i].WorkingMenuItem != null
                        ? $"\t{i + 1}. {items[i].Name} {items[i].WorkingMenuItem.ActionInfo}"
                        : $"\t{i + 1}. {items[i].Name}"
                    );
                }
            }
        }

        public static void PrintOrderInfo()
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"Сумма: {Order.Amount}");
            Console.WriteLine($"Чек заказа:\n{Order.Check}");
            Console.WriteLine(new string('-', 60));
        }

        public static void ErrorMassage(string errorInfo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorInfo);
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
