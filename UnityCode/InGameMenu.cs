using UnityEngine;
using System.Collections;

public class InGameMenu : MonoBehaviour
{
    public GameObject menuBackground;
    public Vector3 spawnSpot = new Vector3(20, 1, 10);
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera cam8;
    public Camera cam9;
    public Camera cam10;
    public Camera cam11;
    public Camera cam12;
    public Camera cam13;
    public Camera cam14;
    public Camera cam15;
    public Camera cam16;
    public Camera cam17;

    GameObject menuBG;
    Transform mainCamera;


    void Start()
    {

        this.enabled = true;
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
        cam8.enabled = false;
        cam9.enabled = false;
        cam10.enabled = false;
        cam11.enabled = false;
        cam12.enabled = false;
        cam13.enabled = false;
        cam14.enabled = false;
        cam15.enabled = false;
        cam16.enabled = false;
        cam17.enabled = false;
    }

    void OnEnable()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        menuBG = (GameObject)Instantiate(menuBackground);
        menuBG.transform.parent = mainCamera;
        menuBG.transform.localPosition = menuBG.transform.position;
        Time.timeScale = 0f;
        Debug.Log("PAUSE");
    }

    void OnDisable()
    {
        Destroy(menuBG);
        Time.timeScale = 1f;
        Debug.Log("RESUME");
    }

    void OnGUI()
    {

        if (GUI.Button(new Rect(Screen.width / 10 - 50, Screen.height / 5 - 40, 100, 30),
                      "Sales"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam1.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 8 - 40, 100, 30),
                      "Dockers"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam3.enabled = !cam3.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 13 - 50, Screen.height / 3 - 40, 100, 30),
                      "Fitting Rooms"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam4.enabled = !cam4.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 4 - 45, Screen.height / 3 - 40, 100, 30),
                      "Michael Kors"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam5.enabled = !cam5.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 13 - 90, Screen.height / 2 - 60, 100, 30),
                      "Bar III"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam6.enabled = !cam6.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 9 - 30, Screen.height / 2 - 70, 130, 30),
                      "Customer Service"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam7.enabled = !cam7.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 3 - 40, 100, 30),
                      "Eagle"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam8.enabled = !cam8.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 10 - 50, Screen.height / 2 + 20, 100, 30),
                      "Alfani 1"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam9.enabled = !cam9.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 4 - 45, Screen.height / 2 + 10, 100, 30),
                      "Alfani 2"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam10.enabled = !cam10.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 2 + 10, 100, 30),
                      "Calvin Klein"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam11.enabled = !cam11.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 10 - 50, Screen.height / 2 + 220, 140, 30),
                      "Polo Ralph Lauren"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam12.enabled = !cam12.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 10 - 50, Screen.height / 2 + 380, 100, 30),
                      "Nautica"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam13.enabled = !cam13.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 3 - 30, Screen.height / 2 + 380, 150, 30),
                      "Assorted Underwear"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam14.enabled = !cam14.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 2 + 80, Screen.height / 8 - 100, 100, 30),
                      "Doors"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam15.enabled = !cam15.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 2 + 80, Screen.height / 5 - 80, 100, 30),
                      "Assorted Stuff"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam16.enabled = !cam16.enabled;
        }

        if (GUI.Button(new Rect(Screen.width / 2 + 80, Screen.height / 3 + 40, 100, 30),
                      "Escalators"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
            cam17.enabled = !cam17.enabled;
        }
    }

}
