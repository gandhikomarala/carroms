namespace CarromArena.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Board Cosmetic Finish & Pocket Design #253
    /// Controls wood lacquer shaders, center mandala patterns, and particle sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "BoardSkinCatalog_253", menuName = "CarromArena/Cosmetics/Board Skin #253")]
    public class BoardSkinCatalog_253 : ScriptableObject
    {
        public enum FinishTier { Standard, Premium, TournamentGold, CyberNeon }

        [SerializeField] private string skinId = "BOARD_SKIN_253";
        [SerializeField] private string skinName = "Royal Lacquer #253";
        [SerializeField] private FinishTier tier = FinishTier.TournamentGold;
        [SerializeField] private Color borderWoodColor = new Color(0.35f, 0.15f, 0.05f, 1.0f);
        [SerializeField] private int unlockPoints = 1000 + (253 * 50);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public FinishTier Tier => tier;
        public int UnlockPoints => unlockPoints;
    }
}
