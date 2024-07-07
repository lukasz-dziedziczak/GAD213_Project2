

using UnrealBuildTool;
using System.Collections.Generic;

public class GAD213_Project2Target : TargetRules
{
	public GAD213_Project2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GAD213_Project2" } );
	}
}
