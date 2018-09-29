using System;

namespace SingleLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingleLinkedList Playlist = new SingleLinkedList();
            Playlist.Add(1);
            Playlist.Add(2);
            Playlist.Add(2);
            Playlist.Add(3);
            Playlist.Add(4);
            Playlist.Add(4);
            Playlist.Add(4);
            Playlist.Add(5);
            Playlist.PrintValues();

        }
    }
}
