namespace CarromArena.UI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Carrom Match HUD Theme & Turn Indicator Skin #133
    /// Renders striker aim crosshairs, power gauges, and Queen status badges.
    /// </summary>
    [CreateAssetMenu(fileName = "CarromHUDTheme_133", menuName = "CarromArena/UI/HUD Theme #133")]
    public class CarromHUDTheme_133 : ScriptableObject
    {
        [SerializeField] private string themeId = "HUD_THEME_133";
        [SerializeField] private Color powerBarFill = new Color(0.95f, 0.75f, 0.15f, 1.0f);
        [SerializeField] private float aimLineDashLength = 0.5f;

        public string ThemeId => themeId;
        public Color PowerBarColor => powerBarFill;
    }
}
