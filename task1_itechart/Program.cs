using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using IronXL;
using IronXL.Logging;
using log4net;
using log4net.Config;
using static task1_itechart.Player;

namespace task1_itechart
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Configuring log4net
            BasicConfigurator.Configure();
            
            // Creating a Logger
            ILog logger =  LogManager.GetLogger(typeof(Program));
            
            
                
            var path = Path.GetFullPath("Top100ChessPlayers.csv");    
            // Reading the contents of the CSV file in the form of array strings
            string[] csvLines = File.ReadAllLines(path);
            
            // List Collection to store players' data
            var players = new List<Player>();

            for (int i = 1; i < csvLines.Length; i++)
            {
                Player player = new Player(csvLines[i]);
                players.Add(player);
            }

            // Getting first 10 players who are older 1980
            var first_10_Players = players.OrderBy(player => player.BirthYear).Take(10);
            
            // Displaying 10 players
            foreach (var player in first_10_Players)
            {
                // Displaying result in logger
                logger.Info(player);
            }
        }
    }
}