namespace CarromArena.Board
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Board Physical Surface & Wood Texture Definition #236
    /// Controls board dimensions, pocket radiuses, baseline coordinates, and friction coefficients.
    /// </summary>
    [CreateAssetMenu(fileName = "BoardDefinition_236", menuName = "CarromArena/Board #236")]
    public class BoardDefinitionCatalog_236 : ScriptableObject
    {
        public enum WoodFinish { Rosewood, AcrylicGloss, NeonCyber, RoyalIvory, MarbleElite }

        [Header("Board Surface Properties")]
        [SerializeField] private string boardId = "BOARD_236";
        [SerializeField] private string boardTitle = "Tournament Arena #236";
        [SerializeField] private WoodFinish finish = WoodFinish.Rosewood;
        [SerializeField] private float surfaceFriction = 0.985f;
        [SerializeField] private float pocketRadiusCm = 4.45f;
        [SerializeField] private float cushionBounciness = 0.88f;

        public string BoardId => boardId;
        public string BoardTitle => boardTitle;
        public float SurfaceFriction => surfaceFriction;
        public float PocketRadiusCm => pocketRadiusCm;
        public float CushionBounciness => cushionBounciness;

        public Vector2 ClampStrikerToBaseline(Vector2 requestedPos, float baselineLength)
        {
            float halfLen = baselineLength * 0.5f;
            return new Vector2(Mathf.Clamp(requestedPos.x, -halfLen, halfLen), requestedPos.y);
        }
    }
}
