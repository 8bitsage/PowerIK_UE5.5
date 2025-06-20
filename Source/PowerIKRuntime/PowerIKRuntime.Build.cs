/* 
Copyright 2020 Power Animated, All Rights Reserved.
Unauthorized copying, selling or distribution of this software is strictly prohibited.
*/

using UnrealBuildTool;
using System.IO;

public class PowerIKRuntime : ModuleRules
{
	public PowerIKRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		PrecompileForTargets = PrecompileTargetsType.Any;

		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
                "Core",
                "CoreUObject",
				"Engine",
				"AnimationCore",
                "AnimGraphRuntime",

				"ControlRig",
				"RigVM",
                "RenderCore",        
                "RHI",
				// ... add other public dependencies that you statically link with here ...
			}
			);

        PrivateDependencyModuleNames.AddRange(
			new string[]
			{
                "Renderer",  
                "StaticMeshDescription", 
				// ... add private dependencies that you statically link with here ...
			}
			);

        if (Target.bBuildEditor) // Only for Editor
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "UnrealEd",
                    "ToolMenus",
                    "EditorStyle",
                }
            );
        }


        DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        // get base folder
        string ModulePath = ModuleDirectory + '/';
        ModulePath = ModulePath.Replace('\\', '/');

        // add sdk include paths
        string IncludeDir = Path.Combine(ModulePath, "sdk", "include");
        PublicIncludePaths.Add(IncludeDir);

        // add sdk src paths (source code license only)
        string SrcDir = Path.Combine(ModulePath, "sdk", "src");
        PrivateIncludePaths.Add(SrcDir);
    }
}
