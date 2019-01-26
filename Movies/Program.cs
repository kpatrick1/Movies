using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {

            MovieDB movieDB = new MovieDB();
            ConsoleUI con = ConsoleUI.getUI();
            Boolean moreTasks = true;
            do
            {
                Choices choice = con.getChoice();
                switch (choice)
                {
                    case Choices.LIST: con.outputMovies(movieDB.getAllMovies()); break;
                    case Choices.BYRATING: con.outputMovies(movieDB.getAllMoviesByRating(con.getRating())); break;
                    case Choices.BYGENRE: con.outputMovies(movieDB.getAllMoviesByGenre(con.getGenre())); break;
                    case Choices.DELETE:
                        Console.WriteLine(movieDB.deleteMovieByIndex(con.getMovieToDelete(movieDB.getAllMovies()))); break;
                    case Choices.EXIT: moreTasks = false;
                        break;
                }
            } while (moreTasks);


        }
    }
}
