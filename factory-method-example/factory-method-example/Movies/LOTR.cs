using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public class LOTR : Movie
    {
        public LOTR()
        {
            Title = "O Senhor dos Anéis: As Duas Torres";
            Genre = "Aventura";
            Year = 2004;
        }
    }
}
