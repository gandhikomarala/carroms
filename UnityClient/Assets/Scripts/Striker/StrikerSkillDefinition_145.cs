namespace CarromArena.Striker
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Striker Tuning & Skill Modifier #145
    /// Controls impulse force scaling, spin drag coefficients, and aim preview line precision.
    /// </summary>
    [CreateAssetMenu(fileName = "StrikerSkill_145", menuName = "CarromArena/Striker #145")]
    public class StrikerSkillDefinition_145 : ScriptableObject
    {
        [Header("Striker Mechanics")]
        [SerializeField] private string strikerId = "STRIKER_145";
        [SerializeField] private float maxShotForce = 45.0f + (145 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 12.0f;
        [SerializeField] private float spinRetentionFactor = 0.92f;

        public string StrikerId => strikerId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;

        public Vector2 CalculateImpulseVector(Vector2 dragVector, float powerRatio)
        {
            float clampedPower = Mathf.Clamp01(powerRatio);
            return dragVector.normalized * (maxShotForce * clampedPower);
        }
    }
}
