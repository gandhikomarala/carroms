namespace CarromArena.Coins
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Piece (Coin/Striker/Queen) Physical Specification #015
    /// Defines mass ratios, collision radiuses, point values, and highlight shaders.
    /// </summary>
    [CreateAssetMenu(fileName = "PieceDefinition_015", menuName = "CarromArena/Piece #015")]
    public class CarromPieceDefinition_015 : ScriptableObject
    {
        public enum PieceType { LightCoin, DarkCoin, QueenRed, Striker }

        [SerializeField] private string pieceId = "PIECE_015";
        [SerializeField] private PieceType type = PieceType.LightCoin;
        [SerializeField] private float massGrams = 5.25f + (15 * 0.02f);
        [SerializeField] private float radiusMm = 15.5f;
        [SerializeField] private int pointValue = 10;
        [SerializeField] private Color pieceColor = new Color(0.95f, 0.95f, 0.9f, 1.0f);

        public PieceType Type => type;
        public float MassGrams => massGrams;
        public float RadiusMm => radiusMm;
        public int PointValue => pointValue;
        public Color PieceColor => pieceColor;

        public bool RequiresQueenCover()
        {
            return type == PieceType.QueenRed;
        }
    }
}
