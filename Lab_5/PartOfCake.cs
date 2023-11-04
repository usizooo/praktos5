using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class PartOfCake : IWorkingMenuItem
    {
        public uint Price { get; private set; }

        public string ActionInfo { get; set; }

        public PartOfCake(uint price)
        {
            Price = price;
            ActionInfo = $" - {Price}";
        }

        public void DoWork(MenuItem callingItem) 
            => Order.AddRecordToCheck($"\t> {callingItem.Name} - {Price};\n", Price);
    }
}
