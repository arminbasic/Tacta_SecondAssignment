using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class GameModel
    {

        public string[,] LetterArray { get; set; }

        public List<string> Words { get; set; }

        public List<int> ResultPerWord { get; set; }

        public int TotalResult { get; set; }

        public List<string> Words1 { get; set; }

        public List<int> ResultPerWord1 { get; set; }

        public int TotalResult1 { get; set; }

    }
}
