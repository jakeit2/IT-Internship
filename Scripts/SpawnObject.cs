using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour
{
    public GameObject Desk;
    public Vector3 spawnSpot = new Vector3(0,1,0);


    void OnTriggerEnter(Collider button)
    {
        Vector3 temp = transform.rotation.eulerAngles;
        temp.x = -90.0f;
        transform.rotation = Quaternion.Euler(temp);
        GameObject deskSpawn = (GameObject)Instantiate(Desk, new Vector3(0,1,0), transform.rotation);
        Destroy(gameObject);
       
    }

}
