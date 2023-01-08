using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AppleNativePluginProcessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] assetPaths, string[] _, string[] _1, string[] _2)
    {
        foreach (string currPath in assetPaths)
        {
            if (currPath.EndsWith(".bundle") || currPath.EndsWith(".framework"))
            {
                string[] folders = currPath.Split('/');
                if (Array.IndexOf(folders, "iOS") > -1)
                {
                    Debug.Log("Updating settings for iOS native libarary at: " + currPath);
                    
                    PluginImporter importer = AssetImporter.GetAtPath(currPath) as PluginImporter;
                    importer.SetCompatibleWithEditor(false);
                    importer.SetCompatibleWithAnyPlatform(false);
                    importer.SetCompatibleWithPlatform(BuildTarget.iOS, true);
                    importer.SetCompatibleWithPlatform(BuildTarget.tvOS, false);
                    importer.SetCompatibleWithPlatform(BuildTarget.StandaloneOSX, false);
                }
                else if (Array.IndexOf(folders, "tvOS") > -1)
                {
                    Debug.Log("Updating settings for tvOS native libarary at: " + currPath);

                    PluginImporter importer = AssetImporter.GetAtPath(currPath) as PluginImporter;
                    importer.SetCompatibleWithEditor(false);
                    importer.SetCompatibleWithAnyPlatform(false);
                    importer.SetCompatibleWithPlatform(BuildTarget.iOS, false);
                    importer.SetCompatibleWithPlatform(BuildTarget.tvOS, true);
                    importer.SetCompatibleWithPlatform(BuildTarget.StandaloneOSX, false);
                }
                else if (Array.IndexOf(folders, "macOS") > -1)
                {
                    Debug.Log("Updating settings for macOS native libarary at: " + currPath);

                    PluginImporter importer = AssetImporter.GetAtPath(currPath) as PluginImporter;
                    importer.SetCompatibleWithEditor(false);
                    importer.SetCompatibleWithAnyPlatform(false);
                    importer.SetCompatibleWithPlatform(BuildTarget.iOS, false);
                    importer.SetCompatibleWithPlatform(BuildTarget.tvOS, false);
                    importer.SetCompatibleWithPlatform(BuildTarget.StandaloneOSX, true);
                }
            }
        }
    }
}
