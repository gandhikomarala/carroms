namespace CarromArena.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Board Cosmetic Finish & Pocket Design #282
    /// Controls wood lacquer shaders, center mandala patterns, and particle sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "BoardSkinCatalog_282", menuName = "CarromArena/Cosmetics/Board Skin #282")]
    public class BoardSkinCatalog_282 : ScriptableObject
    {
        public enum FinishTier { Standard, Premium, TournamentGold, CyberNeon }

        [SerializeField] private string skinId = "BOARD_SKIN_282";
        [SerializeField] private string skinName = "Royal Lacquer #282";
        [SerializeField] private FinishTier tier = FinishTier.TournamentGold;
        [SerializeField] private Color borderWoodColor = new Color(0.35f, 0.15f, 0.05f, 1.0f);
        [SerializeField] private int unlockPoints = 1000 + (282 * 50);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public FinishTier Tier => tier;
        public int UnlockPoints => unlockPoints;
    }
}
