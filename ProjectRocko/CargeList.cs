using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRocko
{
    class CargeList : Controls
    {
        public CargeList()
        {
            Stat = false;
        }

        public List<string> ReadList()
        {
            string List = "List.txt";
            List<string> ListMusic = new List<string>();

            using (StreamReader sr = new StreamReader(@List))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    ListMusic.Add(line);
                }
            }
            return ListMusic;
        }
    }
}
