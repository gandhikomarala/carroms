namespace CarromArena.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Board Cosmetic Finish & Pocket Design #120
    /// Controls wood lacquer shaders, center mandala patterns, and particle sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "BoardSkinCatalog_120", menuName = "CarromArena/Cosmetics/Board Skin #120")]
    public class BoardSkinCatalog_120 : ScriptableObject
    {
        public enum FinishTier { Standard, Premium, TournamentGold, CyberNeon }

        [SerializeField] private string skinId = "BOARD_SKIN_120";
        [SerializeField] private string skinName = "Royal Lacquer #120";
        [SerializeField] private FinishTier tier = FinishTier.TournamentGold;
        [SerializeField] private Color borderWoodColor = new Color(0.35f, 0.15f, 0.05f, 1.0f);
        [SerializeField] private int unlockPoints = 1000 + (120 * 50);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public FinishTier Tier => tier;
        public int UnlockPoints => unlockPoints;
    }
}
