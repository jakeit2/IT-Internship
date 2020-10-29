using UnityEngine;
using System.Collections;

public class InGameMenu2 : MonoBehaviour
{

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
        cam14.enabled = true;
        cam15.enabled = true;
        cam16.enabled = true;
        cam17.enabled = true;

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

            if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 4 + 70, 100, 30),
                      "White Table"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject whitetableSpawn = (GameObject)Instantiate(WhiteTable, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);


        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 130, 120, 30),
                     "Wall Shelf 1"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject wallshelf1Spawn = (GameObject)Instantiate(WallShelf1, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 10, 100, 30),
                     "Hanger 1"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject hanger1Spawn = (GameObject)Instantiate(Hanger1, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 50, 140, 30),
                     "Table With Hanger"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject tablewithhangerSpawn = (GameObject)Instantiate(TablesWithHanger, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 90, 100, 30),
                    "Mannequinn"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject mannequinnSpawn = (GameObject)Instantiate(Mannequinn, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 + 30, 120, 30),
                    "Wall Shelf 2"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject wallshelf2Spawn = (GameObject)Instantiate(WallShelf2, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 4 + 30, 120, 30),
                    "Wider Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject widershelfSpawn = (GameObject)Instantiate(WiderShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 - 130, 140, 30),
                    "Wood Round Table"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject woodroundtableSpawn = (GameObject)Instantiate(WoodRoundTable, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 - 10, 100, 30),
                    "Counter 1"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject counter1Spawn = (GameObject)Instantiate(Counter1, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 - 50, 100, 30),
                    "Counter 2"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject counter2Spawn = (GameObject)Instantiate(Counter2, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 2 - 90, 125, 30),
                    "Triangle Hanger"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject trianglehangerSpawn = (GameObject)Instantiate(TriangleHanger, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 4 + 70, 120, 30),
                    "Over Hang Shelf "))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject overhangshelfSpawn = (GameObject)Instantiate(OverHangShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 10, 160, 30),
                    "Large Table With Shelves"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject largetablewithshelvesSpawn = (GameObject)Instantiate(LargeTableWithShelves, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 + 30, 140, 30),
                    "Table With Shelves"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject tablewithshlevesSpawn = (GameObject)Instantiate(TableWithShelves, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 4 - 50, Screen.height / 2 + 30, 100, 30),
                    "Glass Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject glassshelfSpawn = (GameObject)Instantiate(GlassShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 130, 160, 30),
                    "Frame With Mannequinns"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject framewithmannequinnsSpawn = (GameObject)Instantiate(FrameWithMannequinns, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 50, 120, 30),
                    "Metal Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject metalshlefSpawn = (GameObject)Instantiate(MetalShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 4 + 70, 120, 30),
                    "White Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject whiteshelfSpawn = (GameObject)Instantiate(WhiteShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 6 - 50, Screen.height / 4 + 30, 120, 30),
                    "Tall Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject tallshelfSpawn = (GameObject)Instantiate(TallShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 50, Screen.height / 2 + 30, 100, 30),
                    "Tall Table"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject talltablewithmannequinnSpawn = (GameObject)Instantiate(TallTableWithMannequinn, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 80, Screen.height / 4 + 30, 180, 30),
                    "White Table With Drawers"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject whitetablewithdrawersSpawn = (GameObject)Instantiate(WhiteTableWithDrawers, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 4 + 30, 240, 30),
                    "White Table With Glass Table on Top"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject whitetablewithglasstableontopSpawn = (GameObject)Instantiate(WhiteTableWithGlassTableOnTop, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 4 + 70, 120, 30),
                    "Glass Rack 1"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject glassrack1Spawn = (GameObject)Instantiate(GlassRack1, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 2 - 130, 100, 30),
                    "Hanger 2"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject hanger2Spawn = (GameObject)Instantiate(Hanger2, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 2 - 10, 100, 30),
                    "Hanger 3"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject hanger3Spawn = (GameObject)Instantiate(Hanger3, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 2 - 50, 100, 30),
                    "Double Shelf"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject doubleshelfSpawn = (GameObject)Instantiate(DoubleShelf, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 2 - 90, 140, 30),
                    "Pull Out Shelf 1"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject pulloutshelf1Spawn = (GameObject)Instantiate(PullOutShelf1, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 3 - 50, Screen.height / 2 + 30, 140, 30),
                    "Pull Out Shelf 2"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject pulloutshelf2Spawn = (GameObject)Instantiate(PullOutShelf2, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 50, Screen.height / 4 + 70, 140, 30),
                    "Glass Rack 2"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject glassrack2Spawn = (GameObject)Instantiate(GlassRack2, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 50, Screen.height / 2 - 130, 120, 30),
                    "Long Hanger"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject longhangerSpawn = (GameObject)Instantiate(LongHanger, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 50, Screen.height / 2 - 10, 140, 30),
                    "Metal Round Table"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject metalroundtableSpawn = (GameObject)Instantiate(MetalRoundTable, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 50, Screen.height / 2 - 50, 120, 30),
                    "Double Table"))
        {
            this.enabled = false;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.x = -90.0f;
            transform.rotation = Quaternion.Euler(temp);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            GameObject doubletableSpawn = (GameObject)Instantiate(DoubleTable, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

        }

        if (GUI.Button(new Rect(Screen.width / 12 - 50, Screen.height / 2 - 90, 140, 30),
                  "Wall Shelf 3"))
        {
          this.enabled = false;
          Vector3 temp = transform.rotation.eulerAngles;
          temp.x = -90.0f;
          transform.rotation = Quaternion.Euler(temp);
          Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
          GameObject wallshelf3Spawn = (GameObject)Instantiate(WallShelf3, Camera.main.transform.position + Camera.main.transform.forward * distance, transform.rotation);

       }

       if (Input.GetKeyDown(KeyCode.N))
          {
            
          }

    }
}
