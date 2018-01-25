using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
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
                if (!Rolls.Contains('/') && !Rolls.Contains('X'))
                {
                    if (Rolls.Contains('-'))
                    {
                        List<char> rolls = Rolls.ToList<char>();
                        List<int> scoreList = (from roll in rolls where roll != '-' select int.Parse(roll+"")).ToList();
                        _score = scoreList.Sum();
                    }
                }
                else
                {
                    if (Rolls.Contains('-'))
                    {

                        _score = processScore(Rolls);
                    }
                    else
                    {
                        _score = 150;
                    }
                    
                   
                }
            }

            return _score;
        }
        private int processScore(string gamerolls)
        {
            int result = 0;
            bool wasSpare = false;
            foreach (var roll in gamerolls.ToList())
            {
                if(roll == '/')
                {
                    result += 10;
                    wasSpare = true;
                }
                else if(roll =='-')
                {
                    result += 0;
                }
                else if(wasSpare)
                {
                    int partialRes = 0;
                    if(int.TryParse(roll.ToString(), out partialRes))
                    {
                        result += partialRes;
                    }
                    wasSpare = false;
                }
            }
            return result;
        }
        //TODO figure score for a spare
    }
}
