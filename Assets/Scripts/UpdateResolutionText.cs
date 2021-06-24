using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateResolutionText : MonoBehaviour
{
    public Text resolutionText;
    void Update()
    {
        resolutionText.text = Screen.width + "x" + Screen.height;
    }
}
