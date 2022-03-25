using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text framesDisplay;

    // Update is called once per frame
    void Update()
    {
        float fps = 1 / Time.unscaledDeltaTime;
        framesDisplay.text = "" + (int)fps;
    }
}
