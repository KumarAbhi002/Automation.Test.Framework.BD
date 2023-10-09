using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BD.ASA.Infrastructure.ElementActions
{
    public  class ElementActions
    {
        public void Click(string name)
        {
            //element.click();
            Console.WriteLine($"Performed clicked operation on {name} string");
        }
        public void RightClick()
        {

        }
        public void DoubleClick()
        {

        }
        public void EnterText()
        {

        }
        public void ClearText()
        {

        }
    }
}
