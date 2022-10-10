using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public class NationalMovieCreator : MovieCreator
    {
        protected override Movie Create(MovieTypeEnum movieType)
        {
            switch (movieType)
            {
                case MovieTypeEnum.DoAltoDaCompadecida:
                    return new DoAltoDaCompadecida();
                case MovieTypeEnum.LisbelaEoPrisioneiro:
                    return new LisbelaEoPrisioneiro();
                default:
                    return null;
            }
        }
    }
}
