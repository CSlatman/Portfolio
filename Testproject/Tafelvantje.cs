using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject
{
    public class Tafelvantje
    {
        public List<int> GeefTafelVan (int tafelVan)
        {
            List<int> getallen = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                getallen.Add(i * tafelVan);
            }
            return getallen;
            
        }
    }
}
