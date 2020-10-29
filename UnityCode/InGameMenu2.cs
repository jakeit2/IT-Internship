using UnityEngine;
using System.Collections;

public class InGameMenu2 : MonoBehaviour
{

    public GameObject menuBackground;
    public GameObject Desk;
    public GameObject Table;
    public GameObject Shelf;
    public GameObject Cabinet;
    public GameObject Hanger;
    public GameObject Clothes;
    public GameObject Mannequinn;
    public GameObject WallShelf;
    public GameObject WallHanger;
    public GameObject Mannequinn2;

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

    public Vector3 spawnSpot = new Vector3(0, 3, 0);

    public float distance;
    public float rotationSpeed = 10.0f;
    public float lerpSpeed = 1.0f;


    private Vector3 speed = new Vector3();
    private Vector3 avgSpeed = new Vector3();
    private bool dragging = false;
    private Vector3 targetSpeedX = new Vector3();
    private Vector3 SpawnPosition;



    GameObject menuBG;
    Transform mainCamera;


    void OnMouseDown()
    {
        dragging = true;
    }

    void Start()
    {

        this.enabled = false;
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = true;
        cam4.enabled = true;
        cam5.enabled = true;
        cam6.enabled = true;
        cam7.enabled = true;
        cam8.enabled = true;
        cam9.enabled = true;
        cam10.enabled = true;
        cam11.enabled = true;
        cam12.enabled = true;
        cam13.enabled = true;
        // cam14.enabled = false;
        // cam15.enabled = false;
        // cam16.enabled = false;
        // cam17.enabled = false;
    }


    void OnEnable()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        menuBG = (GameObject)Instantiate(menuBackground);
        menuBG.transform.parent = mainCamera;
        menuBG.transform.localPosition = menuBG.transform.position;
        Time.timeScale = 0f;
        Debug.Log("Spawn A Object");
    }

    void OnDisable()
    {
        Destroy(menuBG);
        Time.timeScale = 1f;
        Debug.Log("Play Mode");
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 10 - 50, Screen.height / 5 - 40, 100, 30),
                      "Go Back"))
        {
            this.enabled = false;
            cam1.enabled = !cam1.enabled;
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

            if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 3 - 40, 100, 30),
                      "Desk"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject deskSpawn = (GameObject)Instantiate(Desk, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);


        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 4 - 40, 100, 30),
                     "Table"))
        {
                this.enabled = false;
                Vector3 temp = transform.rotation.eulerAngles;
                temp.x = -90.0f;
                transform.rotation = Quaternion.Euler(temp);
                Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
                GameObject tableSpawn = (GameObject)Instantiate(Table, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 40, 100, 30),
                     "Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject shelfSpawn = (GameObject)Instantiate(Shelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 110, 100, 30),
                     "Cabinet"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject cabinetSpawn = (GameObject)Instantiate(Cabinet, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 + 20, 100, 30),
                     "Hanger"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject hangerSpawn = (GameObject)Instantiate(Hanger, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 + 80, 100, 30),
                     "Clothes"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject clothesSpawn = (GameObject)Instantiate(Clothes, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 + 80, 100, 30),
                    "Mannequinn 1"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject mannequinnSpawn = (GameObject)Instantiate(Mannequinn, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 + 20, 100, 30),
                    "Wall Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject wallshelfSpawn = (GameObject)Instantiate(WallShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 - 40, 100, 30),
                    "Wall Hanger"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject wallhangerSpawn = (GameObject)Instantiate(WallHanger, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 - 110, 100, 30),
                    "Mannequinn 2"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject mannequinn2Spawn = (GameObject)Instantiate(Mannequinn2, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        // if (Input.GetMouseButton(0) && dragging)
        //     {
        //         speed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        //         avgSpeed = Vector3.Lerp(avgSpeed, speed, Time.deltaTime * 5);
        //     }
        //     else {
        //         if (dragging)
        //         {
        //             speed = avgSpeed;
        //             dragging = false;
        //         }
        //         var i = Time.deltaTime * lerpSpeed;
        //         speed = Vector3.Lerp(speed, Vector3.zero, i);
        //     }
        //
        //     transform.Rotate(Camera.main.transform.up * speed.x * rotationSpeed, Space.World);
        //     transform.Rotate(Camera.main.transform.right * speed.y * rotationSpeed, Space.World);
        }

}
