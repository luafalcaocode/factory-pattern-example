using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public abstract class MovieCreator
    {
        public Movie Locate(MovieTypeEnum movieType)
        {
            Movie movie;

            movie = Create(movieType);

            movie.Print();

            return movie;
        }

        protected abstract Movie Create(MovieTypeEnum movieType);
    }
}
