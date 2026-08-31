namespace CarromArena.Striker
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Striker Tuning & Skill Modifier #105
    /// Controls impulse force scaling, spin drag coefficients, and aim preview line precision.
    /// </summary>
    [CreateAssetMenu(fileName = "StrikerSkill_105", menuName = "CarromArena/Striker #105")]
    public class StrikerSkillDefinition_105 : ScriptableObject
    {
        [Header("Striker Mechanics")]
        [SerializeField] private string strikerId = "STRIKER_105";
        [SerializeField] private float maxShotForce = 45.0f + (105 * 0.1f);
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
