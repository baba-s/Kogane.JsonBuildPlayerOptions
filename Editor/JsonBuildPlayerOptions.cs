using System;
using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEngine;

namespace Kogane
{
    [Serializable]
    [SuppressMessage( "ReSharper", "InconsistentNaming" )]
    [SuppressMessage( "ReSharper", "NotAccessedField.Local" )]
    public struct JsonBuildPlayerOptions
    {
        [SerializeField] private string[] scenes;
        [SerializeField] private string   locationPathName;
        [SerializeField] private string   assetBundleManifestPath;
        [SerializeField] private string   targetGroup;
        [SerializeField] private string   target;
        [SerializeField] private string   subtarget;
        [SerializeField] private string   options;
        [SerializeField] private string[] extraScriptingDefines;

        public JsonBuildPlayerOptions( BuildPlayerOptions value )
        {
            scenes                  = value.scenes;
            locationPathName        = value.locationPathName;
            assetBundleManifestPath = value.assetBundleManifestPath;
            targetGroup             = value.targetGroup.ToString();
            target                  = value.target.ToString();
            subtarget               = value.subtarget.ToString();
            options                 = value.options.ToString();
            extraScriptingDefines   = value.extraScriptingDefines;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}