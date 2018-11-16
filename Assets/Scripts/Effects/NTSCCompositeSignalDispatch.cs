using System;

using UnityEngine;


[RequireComponent(typeof(Camera))]
public class NTSCCompositeSignalDispatch : MonoBehaviour 
{
    public Material material;
    
    void Start() 
    {
        if(!SystemInfo.supportsImageEffects || 
            material == null || 
            material.shader == null || 
            !material.shader.isSupported)
        {
            enabled = false;
            return; //Don't try to dispatch this effect
        }
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        var hasSignal = material.GetFloat("signalResolution");
        Graphics.Blit(source, destination, material);
    }
}