namespace CarromArena.Scoring
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match Score Calculator #280
    /// Evaluates coin point tallies, Queen cover multipliers, and tournament rankings.
    /// </summary>
    public class CarromScoreCalculator_280
    {
        public int ComputePlayerPoints(int whiteCoins, int blackCoins, bool hasQueen)
        {
            int baseScore = (whiteCoins * 10) + (blackCoins * 10);
            if (hasQueen)
            {
                baseScore += 30 + (280 % 5);
            }
            return baseScore;
        }
    }
}
