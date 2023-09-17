// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class proj0913 : ModuleRules
{
	public proj0913(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
