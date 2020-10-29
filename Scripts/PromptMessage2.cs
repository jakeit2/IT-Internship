using UnityEngine;
using System.Collections;

public class PromptMessage2 : MonoBehaviour
{
    void OnGUI()
    {

      GUI.Label(new Rect(1600, 20, 100, 50),
            "Region Changer");

      GUI.Label(new Rect(1800, 20, 100, 50),
            "Department Selection");

      GUI.Label(new Rect(1600, 40, 100, 50),
            "Press M to bring up Menu");

      GUI.Label(new Rect(1600, 80, 100, 50),
            "Press R to Destroy Object That is Selected");

      GUI.Label(new Rect(1600, 140, 100, 100),
            "Press Q To Move Forward");

      GUI.Label(new Rect(1600, 170, 100, 100),
            "Press E To Move Back ");

      GUI.Label(new Rect(1600, 210, 100, 100),
            "Press Z To Move Left");

      GUI.Label(new Rect(1600, 260, 100, 100),
            "Press C To Move Right");

      GUI.Label(new Rect(1600, 320, 100, 100),
            "Press WASD To Rotate While Dragging Object");

      GUI.Label(new Rect(1600, 380, 100, 100),
            "Press XVBFGT To Change The Scale of Object");

      GUI.Label(new Rect(1800, 60, 100, 100),
            "Press N to bring up Names of Despartments When On Main Screen");

    }
}
