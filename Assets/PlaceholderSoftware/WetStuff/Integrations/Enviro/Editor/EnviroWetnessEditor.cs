using UnityEditor;

namespace PlaceholderSoftware.WetStuff.Integrations.Enviro.Editor
{
    [CustomEditor(typeof(EnviroWetness))]
    public class EnviroWetnessEditor
        : BaseExternalWetnessSourceEditor
    {
        public EnviroWetnessEditor()
            : base("Enviro", "_editorRainIntensity")
        {
        }
    }
}
