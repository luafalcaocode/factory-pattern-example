using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method_example.Movies
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Genre: {0}", Genre);
            Console.WriteLine("Year: {0}", Year);
        }
    }
}
