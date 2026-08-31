namespace CarromArena.AI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Deterministic Carrom AI Opponent Profile #011
    /// Plans candidate bank shots, pocket angle cuts, and applies deliberate difficulty error margins.
    /// </summary>
    [CreateAssetMenu(fileName = "AIBotProfile_011", menuName = "CarromArena/AI Profile #011")]
    public class CarromAIBotProfile_011 : ScriptableObject
    {
        public enum AIDifficulty { Easy, Medium, Hard, Expert }

        [SerializeField] private string botName = "Grandmaster Bot #011";
        [SerializeField] private AIDifficulty difficulty = AIDifficulty.Hard;
        [SerializeField] private float aimingAccuracyDegrees = 1.2f;
        [SerializeField] private float powerPrecisionPercent = 0.95f;
        [SerializeField] private bool canAttemptBankShots = true;

        public string BotName => botName;
        public AIDifficulty Difficulty => difficulty;

        public Vector2 ApplyAIMistakeOffset(Vector2 idealAimVector)
        {
            float maxError = difficulty switch
            {
                AIDifficulty.Easy => 8.0f,
                AIDifficulty.Medium => 4.0f,
                AIDifficulty.Hard => 1.5f,
                AIDifficulty.Expert => 0.3f,
                _ => 2.0f
            };
            float angleOffset = UnityEngine.Random.Range(-maxError, maxError);
            return Quaternion.Euler(0, 0, angleOffset) * idealAimVector;
        }
    }
}
