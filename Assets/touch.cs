using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    void onCollisionEnter(Collision collision)
    {
        UnityEditor.EditorApplication.isPlaying = false;
     //   Application.Quit();
    }
}
