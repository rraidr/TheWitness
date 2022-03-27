support: admin@placeholder-software.co.uk
documentation: https://wetsurfacedecals.readthedocs.io/en/latest/GettingStarted/WeatherIntegration/

Wet Stuff has several components which make it easy to integrate puddles with any dynamic weather system. It's easy to extend these components to support any weather system.

This package provides scripts for automatically tying wet decals for effects such as puddles and dripping rooflines into the current Enviro weather preset.

# Getting Started

## 1. Install Dependencies

This asset requires that you have purchased and install `Wet Stuff` and `Enviro`:

 - Wet Stuff: https://assetstore.unity.com/packages/tools/particles-effects/wet-stuff-118969?aid=1100lJDF
 - Enviro: https://assetstore.unity.com/packages/tools/particles-effects/enviro-sky-and-weather-33963?aid=1100lJDF

You may see scene and script errors until these two assets are installed.


## 2. Wetness Source

Add a Wetness source component anywhere into your scene. The script can be found at Assets/PlaceholderSoftware/WetStuff/Integrations/Enviro/EnviroWetness.cs.

This component extracts data about the current weather from Enviro, the other components use this data to automatically drive their behaviour in response to changes in the weather.

Once this component is in the scene the setup is complete, you can now use the drip line and auto puddle components in your scene.


## Drip Line

The Drip Line component is located in Assets/Plugins/PlaceholderSoftware/WetStuff/Weather/DripLine.cs and can be used to simulate dripping rooflines.

This component automatically configures a particle emitter to slowly drip water from a line and automatically sets up wet particle splatters where the particles hit the floor. The rate of dripping is automatically controlled by the weather integration.


An example setup prefab can be found in /Assets/PlaceholderSoftware/WetStuff/Prefabs. This is a component of Wet Stuff, rather than this integration asset. Please refer to the Wet Stuff documentation for more information.

## Auto Rain Puddle

The Auto Rain Puddle component is located in Assets/Plugins/PlaceholderSoftware/WetStuff/Weather/AutoRainPuddle.cs and can be used to simulate puddles which grow and shrink with the weather.

This component automatically animates wet decals to act like puddles in response to the weather integration.

An example setup prefab can be found in /Assets/PlaceholderSoftware/WetStuff/Prefabs. This is a component of Wet Stuff, rather than this integration asset. Please refer to the Wet Stuff documentation for more information.
