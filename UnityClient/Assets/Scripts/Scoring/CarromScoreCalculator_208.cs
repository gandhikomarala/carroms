namespace CarromArena.Scoring
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match Score Calculator #208
    /// Evaluates coin point tallies, Queen cover multipliers, and tournament rankings.
    /// </summary>
    public class CarromScoreCalculator_208
    {
        public int ComputePlayerPoints(int whiteCoins, int blackCoins, bool hasQueen)
        {
            int baseScore = (whiteCoins * 10) + (blackCoins * 10);
            if (hasQueen)
            {
                baseScore += 30 + (208 % 5);
            }
            return baseScore;
        }
    }
}
