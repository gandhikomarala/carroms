namespace CarromArena.Physics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// 2D Board Surface Physics & Settlement Detector #066
    /// Tracks coin linear/rotational velocities and validates board settlement before next turn.
    /// </summary>
    public class BoardPhysicsTuning_066 : MonoBehaviour
    {
        [Header("Settlement Parameters")]
        [SerializeField] private float velocityStopThreshold = 0.05f;
        [SerializeField] private float settleDelaySeconds = 0.35f;
        [SerializeField] private float borderBounceRestitution = 0.85f;

        public bool IsBoardAtRest(Rigidbody2D[] activePieces)
        {
            foreach (var piece in activePieces)
            {
                if (piece != null && piece.velocity.sqrMagnitude > (velocityStopThreshold * velocityStopThreshold))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
