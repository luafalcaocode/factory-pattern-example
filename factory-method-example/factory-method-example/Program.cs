using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using factory_method_example.Movies;

namespace factory_method_example
{
    class Program
    {
        static void Main(string[] args)
        {
            InternationalMovieCreator imc = new InternationalMovieCreator();
            NationalMovieCreator nmc = new NationalMovieCreator();

            Console.WriteLine("Filmes internacionais: \n");

            imc.Locate(MovieTypeEnum.Matrix);
            Console.WriteLine();
            imc.Locate(MovieTypeEnum.LOTR);

            Console.WriteLine();

            Console.WriteLine("Filmes nacionais: \n");

            nmc.Locate(MovieTypeEnum.DoAltoDaCompadecida);
            Console.WriteLine();
            nmc.Locate(MovieTypeEnum.LisbelaEoPrisioneiro);

            Console.ReadKey();
        }
    }
}
