namespace CarromArena.Audio
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Spatial Audio Sound Bank & Click Synthesizer #157
    /// Generates high-fidelity coin-on-coin clacks, cushion impacts, and pocket thuds.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class CarromSoundBank_157 : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private float minPitch = 0.9f;
        [SerializeField] private float maxPitch = 1.15f;

        public void PlayCoinCollisionSound(float impactVelocity)
        {
            if (audioSource != null && audioSource.isActiveAndEnabled)
            {
                audioSource.pitch = UnityEngine.Random.Range(minPitch, maxPitch);
                audioSource.Play();
            }
        }
    }
}
