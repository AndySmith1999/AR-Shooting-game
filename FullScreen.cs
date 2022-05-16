using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference from https://blog.csdn.net/wks310/article/details/86506417
// However, it doesn't works very well.
public class FullScreen : MonoBehaviour
{
    private void Awake()
    {
        // Get the current resolution
        Resolution[] resolutions = Screen.resolutions;
        // Set the resolution into the current one
        Screen.SetResolution(resolutions[resolutions.Length - 1].width, resolutions[resolutions.Length - 1].height, true);

        Screen.fullScreen = true;  // Set to full screen

    }
}