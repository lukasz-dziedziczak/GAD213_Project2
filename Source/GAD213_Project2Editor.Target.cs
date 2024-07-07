

using UnrealBuildTool;
using System.Collections.Generic;

public class GAD213_Project2EditorTarget : TargetRules
{
	public GAD213_Project2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GAD213_Project2" } );
	}
}
