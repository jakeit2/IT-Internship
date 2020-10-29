using UnityEngine;
using System.Collections;

public class MoveOnMouseDrag : MonoBehaviour
{
    static int selectedId;

    public float speed = 100.0f;
    private Vector3 offset;


    void Update()
    {
      if (selectedId == GetInstanceID())
      {
        if (Input.GetKey(KeyCode.Q)) transform.Translate( new Vector3(0,1,0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.E)) transform.Translate( new Vector3(0,-1,0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.Z)) transform.Translate( new Vector3(-1,0,0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.C)) transform.Translate( new Vector3(1,0,0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.X)) transform.localScale += new Vector3(1F, 0, 0);
        if (Input.GetKey(KeyCode.V)) transform.localScale += new Vector3(0, 1F, 0);
        if (Input.GetKey(KeyCode.B)) transform.localScale += new Vector3(0, 0, 1F);
        if (Input.GetKey(KeyCode.F)) transform.localScale += new Vector3(-1F, 0, 0);
        if (Input.GetKey(KeyCode.G)) transform.localScale += new Vector3(0, -1F, 0);
        if (Input.GetKey(KeyCode.T)) transform.localScale += new Vector3(0, 0, -1F);
        if (Input.GetKey(KeyCode.R)) Destroy(gameObject);
      }
    }

    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 50.0f));

    }

    void OnMouseDrag()
      {

        if (Input.GetKey(KeyCode.W))

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))

            transform.Rotate(-Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))

            transform.Rotate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))

            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);

        selectedId = GetInstanceID();

        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 50.0f);

        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
      }


}
