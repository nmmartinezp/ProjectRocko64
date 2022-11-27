using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectRocko
{
    class CargeUb : Controls
    {
        public CargeUb()
        {
            Stat = false;
        }

        public string ReadUb()
        {
            string Ub = "Ub.txt";
            string Ubn = string.Empty;

            using (StreamReader sr = new StreamReader(@Ub))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Ubn = line;
                }
            }
            return Ubn;
        }
    }
}
