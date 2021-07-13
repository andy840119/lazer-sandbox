﻿using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Graphics.UserInterfaceV2;
using osu.Game.Rulesets.Sandbox.Configuration;

namespace osu.Game.Rulesets.Sandbox.UI.Settings
{
    public class ColourPickerDropdown : SettingsDropdownContainer
    {
        private readonly Bindable<string> hexColour = new Bindable<string>();

        private OsuColourPicker picker;
        private readonly SandboxRulesetSetting lookup;

        public ColourPickerDropdown(string name, SandboxRulesetSetting lookup)
            : base(name)
        {
            this.lookup = lookup;
        }

        protected override Drawable CreateContent() => picker = new OsuColourPicker();

        [BackgroundDependencyLoader]
        private void load(SandboxRulesetConfigManager rulesetConfig)
        {
            rulesetConfig.BindWith(lookup, hexColour);
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();

            picker.Current.Value = Colour4.FromHex(hexColour.Value);
            picker.Current.BindValueChanged(c =>
            {
                hexColour.Value = c.NewValue.ToHex();
            });
        }
    }
}
