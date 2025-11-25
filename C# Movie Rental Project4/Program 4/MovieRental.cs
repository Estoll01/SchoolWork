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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class MovieRental// Movie rental class
    {
        // Default values
        private const double DEFAULT_PRICE = 1.00;// Default retail price
        private const int DEFAULT_RUNTIME = 90;// Default runtime in minutes
        private const int DEFAULT_TIMES_RENTED = 0;// Default times rented

        // Properties
        public string Title// Movie title
        {
            get { return _title; }
            set { _title = value; }
        }
        public double RetailPrice// Movie retail price
        {
            get { return _retailPrice; }
            set
            {
                if (value > 0)
                    _retailPrice = value;
                else
                    _retailPrice = DEFAULT_PRICE; // Default to $1.00 if invalid price
            }
        }
        public int RuntimeMinutes// Movie runtime in minutes
        {
            get { return _runtimeMinutes; }
            set
            {
                if (value > 0)
                    _runtimeMinutes = value;
                else
                    _runtimeMinutes = DEFAULT_RUNTIME; // Default to 90 minutes if invalid runtime
            }
        }
        public int TimesRented// Number of times the movie has been rented
        {
            get { return _timesRented; }
            set
            {
                if (value >= 0)
                    _timesRented = value;
                else
                    _timesRented = DEFAULT_TIMES_RENTED; // Default to 0 if invalid times rented
            }
        }
        public bool Available// Availability status of the movie
        {
            get { return _available; }
            set { _available = value; }
        }

        // Private fields
        private string _title;// Movie title
        private double _retailPrice;// Movie retail price
        private int _runtimeMinutes;// Movie runtime in minutes
        private int _timesRented;// Number of times the movie has been rented
        private bool _available;// Availability status of the movie

        public MovieRental(string title, double retailPrice, int runtimeMinutes, int timesRented, bool available)// Constructor
        {
            Title = title;
            RetailPrice = retailPrice;
            RuntimeMinutes = runtimeMinutes;
            TimesRented = timesRented;
            Available = available;
        }

        //Methods
        public void MakeAvailable()// Make the movie available for rent
        {
            Available = true;
        }

        public void MakeUnavailable()// Make the movie unavailable for rent
        {
            Available = false;
        }

        public bool isAvailable()// Check if the movie is available for rent
        {
            return Available;
        }

        public override string ToString()// Override ToString method to display movie details
        {
            return $"Title: {Title}{Environment.NewLine}" +
                   $"Retail Price: ${RetailPrice}{Environment.NewLine}" +
                   $"Runtime: {RuntimeMinutes} minutes{Environment.NewLine}" +
                   $"Times Rented: {TimesRented}{Environment.NewLine}" +
                   $"Available: {Available}";
        }
    }
}
