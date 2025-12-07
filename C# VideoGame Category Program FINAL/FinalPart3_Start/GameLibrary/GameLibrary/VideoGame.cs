/*
 * Author:Ethan Tolliver
 * Final Part 3 Fall 2025
 * CIS-199-50-4258
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class VideoGame
    {
        /* 1. Create Required Backing Fields and properties */
        // Backing fields
        private int gameID;
        private double playtime;
        private bool isCompleted;
        // Properties
        public int GameID // Must be between 0 and 9999 (inclusive)
        {
            get
            {
                return gameID;
            }
            set
            {
                if (value >= 0 && value <= 9999)
                    gameID = value;
            }
        }

        public double Playtime // Must be greater than or equal to 0
        {
            get
            {
                return playtime;
            }
            set
            {
                if (value >= 0)
                    playtime = value;
            }
        }

        public string Title {get; set;}
        public string Publisher { get; set; }
        public string Genre { get; set; }

        /* 2. Create constructor */
        public VideoGame(int id, string title, string publisher, string genre, double playtime)
        {
            GameID = id;
            Title = title;
            Publisher = publisher;
            Genre = genre;
            Playtime = playtime;
            isCompleted = false;
        }

        /* 3. VideoGame Methods */
        public void MarkCompleted()
        {
            isCompleted = true;
        }

        public void MarkNotCompleted()
        {
            isCompleted = false;
        }

        public bool CompletionStatus()
        {
            return isCompleted;
        }

        /* 4. Override ToString() */
        public override string ToString()
        {
            return $"Title: {Title}\nID: {GameID}\nPublisher: {Publisher}\nGenre: {Genre}\nPlay time: {Playtime}\nCompleted: {isCompleted}\n\n";
        }
    }
}
