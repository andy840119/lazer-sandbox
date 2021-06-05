﻿using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Overlays;
using osu.Game.Overlays.Notifications;
using osu.Game.Overlays.Settings;
using osu.Game.Rulesets.Sandbox.Configuration;
using osu.Game.Rulesets.Sandbox.Extensions;
using osu.Game.Screens.Menu;

namespace osu.Game.Rulesets.Sandbox.UI
{
    public class SandboxSettingsSubsection : RulesetSettingsSubsection
    {
        protected override string Header => "Sandbox";

        [Resolved]
        private OsuGame game { get; set; }

        [Resolved]
        private NotificationOverlay notifications { get; set; }

        public SandboxSettingsSubsection(Ruleset ruleset)
            : base(ruleset)
        {
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            var config = (SandboxRulesetConfigManager)Config;

            Children = new Drawable[]
            {
                new SettingsButton
                {
                    Text = "Open Main Screen",
                    Action = () =>
                    {
                        try
                        {
                            var screenStack = game.GetScreenStack();
                            if (!(screenStack.CurrentScreen is MainMenu))
                            {
                                notifications.Post(new SimpleErrorNotification
                                {
                                    Text = "This feature can be used only in Main menu!"
                                });
                                return;
                            }

                            var settingOverlay = game.GetSettingsOverlay();
                            //screenStack?.Push(new VisualizerScreen());
                            settingOverlay?.Hide();
                        }
                        catch
                        {
                        }
                    }
                }
            };
        }
    }
}
