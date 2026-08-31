namespace CarromArena.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Board Cosmetic Finish & Pocket Design #205
    /// Controls wood lacquer shaders, center mandala patterns, and particle sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "BoardSkinCatalog_205", menuName = "CarromArena/Cosmetics/Board Skin #205")]
    public class BoardSkinCatalog_205 : ScriptableObject
    {
        public enum FinishTier { Standard, Premium, TournamentGold, CyberNeon }

        [SerializeField] private string skinId = "BOARD_SKIN_205";
        [SerializeField] private string skinName = "Royal Lacquer #205";
        [SerializeField] private FinishTier tier = FinishTier.TournamentGold;
        [SerializeField] private Color borderWoodColor = new Color(0.35f, 0.15f, 0.05f, 1.0f);
        [SerializeField] private int unlockPoints = 1000 + (205 * 50);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public FinishTier Tier => tier;
        public int UnlockPoints => unlockPoints;
    }
}
