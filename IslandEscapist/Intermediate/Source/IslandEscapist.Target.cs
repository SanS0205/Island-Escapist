using UnrealBuildTool;

public class IslandEscapistTarget : TargetRules
{
	public IslandEscapistTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("IslandEscapist");
	}
}
