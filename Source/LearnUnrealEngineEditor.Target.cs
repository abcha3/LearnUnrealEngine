// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LearnUnrealEngineEditorTarget : TargetRules
{
	public LearnUnrealEngineEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange(new[] {"LearnUnrealEngine"});
	}
}