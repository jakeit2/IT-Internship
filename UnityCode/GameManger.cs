using UnityEngine;
using System.Collections;

public class GameManger : MonoBehaviour
{
    InGameMenu igm;
    InGameMenu2 igm2;

    public Camera[] allCams;

    void Awake()
    {
        igm = gameObject.GetComponent<InGameMenu>();
        igm2 = gameObject.GetComponent<InGameMenu2>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            igm.enabled = !igm.enabled;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            igm2.enabled = !igm2.enabled;
        }


    }

}
