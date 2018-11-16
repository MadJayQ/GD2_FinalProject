using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSettings : MonoBehaviour {

	public NTSCSignalSettings NTSCSettings;
    private static SceneSettings s_Instance;
    public static SceneSettings Instance
    {
        get
        {
            if (s_Instance == null)
            {
                s_Instance = GameObject.FindObjectOfType(
                    typeof(SceneSettings)
                ) as SceneSettings; //Initialize our network handler
            }

            return s_Instance;
        }
    }
}
