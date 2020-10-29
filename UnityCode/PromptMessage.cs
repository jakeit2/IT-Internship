using UnityEngine;
using System.Collections;

public class PromptMessage : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 50),
              "Press M to bring up Menu");
    }

}
