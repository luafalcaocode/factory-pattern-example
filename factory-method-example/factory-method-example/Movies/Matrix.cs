using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public class Matrix : Movie
    {
        public Matrix()
        {
            Title = "Matrix";
            Genre = "Ficção Científica";
            Year = 1999;
        }
    }
}
