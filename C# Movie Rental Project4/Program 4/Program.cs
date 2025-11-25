//Ethan Tolliver
//Program 4
//11/24/2025
//CIS-199-50-4258
//This program creates a MovieRental class with properties and methods to manage movie rentals.
/* 1. You would give the class protected access to allow derived classes to access it.
 * 2. A property is a class member that controls access to a private field using get and set. It allows us to protect data, validate values before saving, prevent harmful data, and control values.
 * 3. If you do not provide a constructor, C# provides a default parameterless constructor that initializes fields to their default values.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        public static void DisplayMovies(MovieRental[] movies)// Method to display movie details
        {
            foreach (MovieRental movie in movies)// Iterate through each movie in the array
            {
                Console.WriteLine(movie.ToString());
                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        static void Main(string[] args)
        {
            // Create instances of MovieRental
            MovieRental movie1 = new MovieRental("The Matrix", 3.99, 148, 25, true);// Instance 1
            MovieRental movie2 = new MovieRental("Parasite", 4.99, 148, 30, false);// Instance 2
            MovieRental movie3 = new MovieRental("Princess Mononoke", 5.99, 169, 15, true);// Instance 3
            MovieRental movie4 = new MovieRental("The Empire Strikes Back", 2.99, 175, 40, true);// Instance 4
            MovieRental movie5 = new MovieRental("The Shining", 3.49, 154, 20, false);// Instance 5

            MovieRental[] movieList = new MovieRental[] { movie1, movie2, movie3, movie4, movie5 };// Array of MovieRental instances

            Console.WriteLine("*****Before Changes*****");// Display initial movie details
            Console.WriteLine();
            DisplayMovies(movieList);// Display initial movie details

            // Modify properties
            movie1.RetailPrice = 2.49;
            movie2.MakeAvailable();
            movie3.MakeUnavailable();
            movie4.TimesRented = 10;
            movie5.RuntimeMinutes = -5;

            Console.WriteLine();
            Console.WriteLine("*****After Changes*****");// Display modified movie details
            Console.WriteLine();
            DisplayMovies(movieList);// Display modified movie details

        } 
    }
}
