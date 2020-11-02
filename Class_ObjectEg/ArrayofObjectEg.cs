using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectEg
{
    class Movie
    {
        int id;
         string moviename;
        //DateTime year;

       internal  Movie(int id, string moviename) //DateTime year)
        {
            this.id = id;
            this.moviename = moviename;
            //this.year = year;
        }

       internal  void DisplayMovie()
        {
            Console.WriteLine(" id:{0}|| Moviename:{1}", id, moviename);
        }
    }
    class ArrayofObjectEg
    {
        static void Main()
        {
            Movie movie = new Movie(101, "Dangal");
            movie.DisplayMovie();
            //Applying array to objects to fetch multiple movie info
            //array of object
            //datatype [] arrayname = new datatype[size];
            Console.WriteLine("enter the No. of Inputs ");
            int size = Convert.ToInt32(Console.ReadLine());
            Movie[] mov = new Movie[size];
            int id;
            string moviename;

            for (int i=0;i< size; i++)
            {
                Console.WriteLine(" Enter the movie id and movie name");
                id = Convert.ToInt32(Console.ReadLine());
                moviename = Console.ReadLine();
                mov[i] = new Movie(id, moviename);
            }

            for (int i = 0; i < size; i++)
            {
                mov[i].DisplayMovie();
            }
            Console.Read();
        }
    }
}
