using UnrealBuildTool;
using System.Collections.Generic;

public class PacmanEditorTarget : TargetRules
{
	public PacmanEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Pacman" } );
	}
}
