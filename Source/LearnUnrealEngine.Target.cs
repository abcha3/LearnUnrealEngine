// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LearnUnrealEngineTarget : TargetRules
{
	public LearnUnrealEngineTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange(new[] {"LearnUnrealEngine"});
	}
}