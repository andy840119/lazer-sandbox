using NUnit.Framework;
using osu.Game.Tests.Visual;

namespace osu.Game.Rulesets.Sandbox.Tests
{
    [TestFixture]
    public class TestSceneOsuPlayer : PlayerTestScene
    {
        protected override Ruleset CreatePlayerRuleset() => new SandboxRuleset();
    }
}
