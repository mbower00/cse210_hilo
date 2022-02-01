﻿using cse210_hilo.Game;


namespace cse210_hilo
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            
            Card test = new Card();
            Director director = new Director();
            director.StartGame();
        }
    }
}