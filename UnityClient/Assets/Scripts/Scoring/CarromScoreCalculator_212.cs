namespace CarromArena.Scoring
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match Score Calculator #212
    /// Evaluates coin point tallies, Queen cover multipliers, and tournament rankings.
    /// </summary>
    public class CarromScoreCalculator_212
    {
        public int ComputePlayerPoints(int whiteCoins, int blackCoins, bool hasQueen)
        {
            int baseScore = (whiteCoins * 10) + (blackCoins * 10);
            if (hasQueen)
            {
                baseScore += 30 + (212 % 5);
            }
            return baseScore;
        }
    }
}
