﻿using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Rulesets.Sandbox.Screens.Visualizer.Components;
using osu.Game.Rulesets.Sandbox.Screens.Visualizer.Components.Settings;
using osu.Game.Rulesets.Sandbox.UI.Settings;

namespace osu.Game.Rulesets.Sandbox.Screens.Visualizer
{
    public class VisualizerScreen : SandboxScreenWithSettings
    {
        protected override Drawable CreateBackground() => new Container
        {
            RelativeSizeAxes = Axes.Both,
            Children = new Drawable[]
            {
                new StoryboardContainer(),
                new Particles()
            }
        };

        protected override Drawable CreateContent() => new LayoutController();

        protected override SandboxSettingsSection[] CreateSettingsSections() => new SandboxSettingsSection[]
        {
            new TrackSection(),
            new VisualizerSection(),
            new BackgroundSection()
        };
    }
}
