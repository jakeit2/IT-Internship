using UnityEngine;
using System.Collections;

public class PromptMessage2 : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(120, 10, 100, 50),
              "Press N to bring up Names of Despartments");
    }
}
