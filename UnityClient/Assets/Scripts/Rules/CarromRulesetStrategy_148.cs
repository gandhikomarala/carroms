namespace CarromArena.Rules
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match Ruleset Strategy #148
    /// Validates Queen cover confirmation, legal pocket sequences, foul penalties, and turn transfers.
    /// </summary>
    public class CarromRulesetStrategy_148
    {
        public enum MatchRuleMode { StandardTournament, CasualPoints, BoardClear }

        public bool ValidateTurnOutcome(bool pocketedAssignedCoin, bool pocketedQueen, bool coveredQueen, bool strikerPocketed)
        {
            if (strikerPocketed)
                return false; // Foul: Lose turn and penalty coin
            if (pocketedQueen && !coveredQueen)
                return true; // Retain turn to attempt Queen cover
            return pocketedAssignedCoin || (pocketedQueen && coveredQueen);
        }
    }
}
