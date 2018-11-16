using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;


[CreateAssetMenu(menuName="NTSC/Signal Settings")]
public class NTSCSignalSettings : ScriptableObject 
{
    public float signalResolution;
    public float signalResolutionI;
    public float signalResolutionQ;

    public Vector2 videoSize;
    public Vector2 textureSize;
    public Vector2 outputSize;

    public float blackLevel;
    public float contrast;
    public float tvVerticalResolution;
}