using UnrealBuildTool;

public class ASG2FightingGameTarget : TargetRules
{
	public ASG2FightingGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ASG2FightingGame");
	}
}
