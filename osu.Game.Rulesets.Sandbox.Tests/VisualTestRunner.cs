﻿using System;
using osu.Framework;
using osu.Framework.Platform;
using osu.Game.Tests;

namespace osu.Game.Rulesets.Sandbox.Tests
{
    public static class VisualTestRunner
    {
        [STAThread]
        public static int Main(string[] args)
        {
            using (DesktopGameHost host = Host.GetSuitableHost(@"osu", true))
            {
                host.Run(new OsuTestBrowser());
                return 0;
            }
        }
    }
}
