using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    internal class Album
    {
        //Album name, artist name, and number of tracks
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void getAlbumName()
        {
            Console.WriteLine("What is the album name? ");
            albumName = Console.ReadLine();
            Console.WriteLine("Nice one!");
        }

        public void getArtistName()
        {
            Console.WriteLine("What is the artist's name? ");
            artistName = Console.ReadLine();
        }

        public void getNumTracks()
        {
            Console.WriteLine("How many tracks is on " + albumName + " by " + artistName + "? ");
            numOfTracks = int.Parse(Console.ReadLine());
        }

        public void getAlbumData()
        {
            getAlbumName();
            getArtistName();
            getNumTracks();
        }

        public void displayAlbumData() 
        {
            Console.WriteLine("You entered:");
            Console.WriteLine("Album Name: " + albumName + ".");
            Console.WriteLine("Artist Name: " + artistName + ".");
            Console.WriteLine("Number of Tracks: " + numOfTracks + ".");
        } 

        public void Start()
        {
            getAlbumData();
            displayAlbumData();
            Console.WriteLine("Enjoy the tunes! :) ");
        }
    }
}
