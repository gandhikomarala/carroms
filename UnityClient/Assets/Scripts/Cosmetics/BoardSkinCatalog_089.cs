namespace CarromArena.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Board Cosmetic Finish & Pocket Design #089
    /// Controls wood lacquer shaders, center mandala patterns, and particle sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "BoardSkinCatalog_089", menuName = "CarromArena/Cosmetics/Board Skin #089")]
    public class BoardSkinCatalog_089 : ScriptableObject
    {
        public enum FinishTier { Standard, Premium, TournamentGold, CyberNeon }

        [SerializeField] private string skinId = "BOARD_SKIN_089";
        [SerializeField] private string skinName = "Royal Lacquer #089";
        [SerializeField] private FinishTier tier = FinishTier.TournamentGold;
        [SerializeField] private Color borderWoodColor = new Color(0.35f, 0.15f, 0.05f, 1.0f);
        [SerializeField] private int unlockPoints = 1000 + (89 * 50);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public FinishTier Tier => tier;
        public int UnlockPoints => unlockPoints;
    }
}
