using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public static class Order
    {
        public static uint Amount { get; set; } = 0;

        public static string Check { get; private set; } = string.Empty;

        public static void AddRecordToCheck(string record, uint price)
        {
            Amount += price;
            Check += record;
        }
        
        public static void Complete(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(new string('-', 60));
                streamWriter.WriteLine($"Заказ от {DateTime.Now}");
                streamWriter.Write(Check);
                streamWriter.WriteLine($"Итоговая сумма: {Amount}");
            }

            Check = string.Empty;
            Amount = 0;
        }
    }
}