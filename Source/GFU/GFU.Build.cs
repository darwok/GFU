// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GFU : ModuleRules
{
	public GFU(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GFU",
			"GFU/Variant_Platforming",
			"GFU/Variant_Platforming/Animation",
			"GFU/Variant_Combat",
			"GFU/Variant_Combat/AI",
			"GFU/Variant_Combat/Animation",
			"GFU/Variant_Combat/Gameplay",
			"GFU/Variant_Combat/Interfaces",
			"GFU/Variant_Combat/UI",
			"GFU/Variant_SideScrolling",
			"GFU/Variant_SideScrolling/AI",
			"GFU/Variant_SideScrolling/Gameplay",
			"GFU/Variant_SideScrolling/Interfaces",
			"GFU/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
