using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour
{
    public GameObject Desk;
    public Vector3 spawnSpot = new Vector3(0,1,0);
    public float rotationSpeed = 10.0f;
    public float lerpSpeed = 1.0f;

    private Vector3 speed = new Vector3();
    private Vector3 avgSpeed = new Vector3();
    private bool dragging = false;
    private Vector3 targetSpeedX = new Vector3();

    void OnMouseDown()
    {
        dragging = true;
    }

    void OnTriggerEnter(Collider button)
    {
        Vector3 temp = transform.rotation.eulerAngles;
        temp.x = -90.0f;
        transform.rotation = Quaternion.Euler(temp);
        GameObject deskSpawn = (GameObject)Instantiate(Desk, new Vector3(0,1,0), transform.rotation);
        Destroy(gameObject);
       
    }
    void Update()
    {

        if (Input.GetMouseButton(0) && dragging)
        {
            speed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
            avgSpeed = Vector3.Lerp(avgSpeed, speed, Time.deltaTime * 5);
        }
        else {
            if (dragging)
            {
                speed = avgSpeed;
                dragging = false;
            }
            var i = Time.deltaTime * lerpSpeed;
            speed = Vector3.Lerp(speed, Vector3.zero, i);
        }

        transform.Rotate(Camera.main.transform.up * speed.x * rotationSpeed, Space.World);
        transform.Rotate(Camera.main.transform.right * speed.y * rotationSpeed, Space.World);

    }
}
