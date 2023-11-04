using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public interface IWorkingMenuItem
    {
        public string ActionInfo { get; set; }
        public void DoWork(MenuItem callingItem);
    }
}