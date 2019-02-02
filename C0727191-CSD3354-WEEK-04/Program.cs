using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0727191_CSD3354_WEEK_04
{
    class Program
    {
        static void Main(string[] args)
        {

            countryside c = new countryside();

        }
    }
    class village
    {
        public bool isAstrildeHere;
        public village nextvillage;
        public village prevvillage;
        public String villagename;


    }


    class countryside
    {
        village Maple;
        village Toronto;
        village Ajax;

        public void run()
        {
            Maple = new village();
            Maple.villagename = "Toronto";
            Maple.nextvillage= Toronto;
        }
        
    }
}