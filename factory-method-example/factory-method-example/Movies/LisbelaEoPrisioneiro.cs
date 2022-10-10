using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public class LisbelaEoPrisioneiro : Movie
    {
        public LisbelaEoPrisioneiro()
        {
            Title = "Lisbela e o Prisioneiro";
            Genre = "Comédia Romântica";
            Year = 2006;
        }
    }
}
