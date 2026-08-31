namespace CarromArena.Scoring
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match Score Calculator #129
    /// Evaluates coin point tallies, Queen cover multipliers, and tournament rankings.
    /// </summary>
    public class CarromScoreCalculator_129
    {
        public int ComputePlayerPoints(int whiteCoins, int blackCoins, bool hasQueen)
        {
            int baseScore = (whiteCoins * 10) + (blackCoins * 10);
            if (hasQueen)
            {
                baseScore += 30 + (129 % 5);
            }
            return baseScore;
        }
    }
}
