using UnityEngine;
using System.Collections;

public class DragandRotate : MonoBehaviour
{

    public float speed = 100.0f;

    void OnMouseDown()
    {

        if (Input.GetKey(KeyCode.W))

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))

            transform.Rotate(-Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))

            transform.Rotate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))

            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);

        
    }


}
