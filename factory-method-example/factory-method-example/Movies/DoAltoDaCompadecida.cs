using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public class DoAltoDaCompadecida : Movie
    {
        public DoAltoDaCompadecida()
        {
            Title = "Do Alto da Compadecida";
            Genre = "Comédia";
            Year = 2007;
        }
    }
}
