using PlaceholderSoftware.WetStuff.Weather;
using UnityEngine;

namespace PlaceholderSoftware.WetStuff.Integrations.Enviro
{
    /// <summary>
    ///     Provides environmental wetness values from Enviro.
    /// </summary>
    public class EnviroWetness
        : BaseExternalWetnessSource
    {
#pragma warning disable 0649
        [SerializeField, Range(-1, 1), Tooltip("Current change-per-second in environmental wetness")]
        private float _editorRainIntensity;
#pragma warning restore 0649
        
        public override float RainIntensity
        {
            get
            {
#if UNITY_EDITOR
                // If we're in edit mode then return the value from the inspector sliders
                if (!UnityEditor.EditorApplication.isPlaying)
                    return _editorRainIntensity;
#endif

                var instance = EnviroSkyMgr.instance;
                if (instance == null)
                    return 0;

                var weather = instance.Weather;
                if (weather == null)
                    return 0;

                var preset = weather.currentActiveWeatherPreset;
                if (preset == null)
                    return 0;

                var wetness = weather.wetness;
                if (wetness < preset.wetnessLevel)
                    return wetness;
                else
                    return -0.5f;
            }
        }
    }
}