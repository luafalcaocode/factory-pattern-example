using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public class InternationalMovieCreator : MovieCreator
    {
        protected override Movie Create(MovieTypeEnum movieType)
        {
            switch(movieType)
            {
                case MovieTypeEnum.LOTR:
                    return new LOTR();
                case MovieTypeEnum.Matrix:
                    return new Matrix();
                default:
                    return null;
            }
        }
    }
}
