using UnityEngine;

namespace PlaceholderSoftware.WetStuff.Integrations.Enviro.Demo
{
    public class DemoWeatherController
        : MonoBehaviour
    {
        private const float CycleTime = 30;

        public EnviroWeatherPreset RainingWeather;
        public EnviroWeatherPreset DryingWeather;

        private float _timer;

        private void Update ()
        {
            if (EnviroSky.instance.Weather.currentActiveWeatherPreset == null)
                return;

            _timer += Time.deltaTime;
            if (_timer >= CycleTime)
            {
                _timer %= CycleTime;

                if (EnviroSky.instance.Weather.currentActiveWeatherPreset == RainingWeather)
                    EnviroSky.instance.ChangeWeather(DryingWeather.Name);
                else
                    EnviroSky.instance.ChangeWeather(RainingWeather.Name);
            }
        }
    }
}
