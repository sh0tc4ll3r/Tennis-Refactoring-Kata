namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private int _mScore1;
        private int _mScore2;

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _mScore1 += 1;
            else
                _mScore2 += 1;
        }

        public string GetScore()
        {
            if (_mScore1 == _mScore2)
            {
                return EqualsScore();
            }

            if (_mScore1 >= 4 || _mScore2 >= 4)
            {
                return Advantages();
            }

            return GeneralGameFlow("");
        }

        private string GeneralGameFlow(string score)
        {
            for (var i = 1; i < 3; i++)
            {
                score = ScoreTally(score, i);
            }

            return score;
        }

        private string ScoreTally(string score, int i)
        {
            int tempScore;
            if (i == 1) tempScore = _mScore1;
            else
            {
                score += "-";
                tempScore = _mScore2;
            }

            switch (tempScore)
            {
                case 0:
                    score += "Love";
                    break;
                case 1:
                    score += "Fifteen";
                    break;
                case 2:
                    score += "Thirty";
                    break;
                case 3:
                    score += "Forty";
                    break;
            }

            return score;
        }

        private string Advantages()
        {
            return (_mScore1 - _mScore2) switch
            {
                1 => "Advantage player1",
                -1 => "Advantage player2",
                >= 2 => "Win for player1",
                _ => "Win for player2"
            };
        }

        private string EqualsScore()
        {
            return _mScore1 switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
        }
    }
}

