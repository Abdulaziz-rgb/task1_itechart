using System;

namespace task1_itechart
{
    public class Player
    {
        private int Rank;
        private string Name;
        private string Title;
        private string Country;
        private int Rating;
        private int Games;
        public int BirthYear;

        public Player(string rowData)
        {
             string[] data = rowData.Split(';');
            
            // Parsing data into properties
            this.Rank = Convert.ToInt16(data[0]);
            this.Name = data[1];
            this.Title = data[2];
            this.Country = data[3];
            this.Rating = Convert.ToInt16(data[4]);
            this.Games = Convert.ToInt16(data[5]);
            this.BirthYear = Convert.ToInt16(data[6]);
        }
        
        // Overriding default Object.ToString() method into more readable format
        public override string ToString()
        {
            string str = $"{Rank}: {Name} - {Title} - {Country} - {Rating} - {Games} - {BirthYear}";
            return str;
        }
    }
}