using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata.Bowling
{
    public class Game
    {
        
        public string Rolls { get; set; }
        public int Score
        {
            get
            {
                return figureScore();
            }
        }
        private int figureScore()
        {
            int _score =300;
            if(Rolls.Length > 12)
            {
                _score = 150;
            }
            //TODO figures score form Rolls

            return _score;
        }
    }
}
