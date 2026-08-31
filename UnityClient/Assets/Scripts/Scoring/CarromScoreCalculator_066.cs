namespace CarromArena.Scoring
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match Score Calculator #066
    /// Evaluates coin point tallies, Queen cover multipliers, and tournament rankings.
    /// </summary>
    public class CarromScoreCalculator_066
    {
        public int ComputePlayerPoints(int whiteCoins, int blackCoins, bool hasQueen)
        {
            int baseScore = (whiteCoins * 10) + (blackCoins * 10);
            if (hasQueen)
            {
                baseScore += 30 + (66 % 5);
            }
            return baseScore;
        }
    }
}
