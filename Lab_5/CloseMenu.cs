using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class CloseMenu : IWorkingMenuItem
    {
        private string pathForOrder;

        public string ActionInfo { get; set; } = string.Empty;

        public CloseMenu(string pathForOrder) => this.pathForOrder = pathForOrder;

        public void DoWork(MenuItem callingItem)
        {
            Order.Complete(pathForOrder);
            Console.Clear();
            Console.WriteLine("Нажмите ESCAPE, если хотите закончить выполнение программы");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
