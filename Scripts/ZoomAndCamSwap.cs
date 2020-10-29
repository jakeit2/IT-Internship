using UnityEngine;
using System.Collections;

public class ZoomAndCamSwap : MonoBehaviour {
	public int zoom = 5; //zoom amount
	public float normal = 0; //default view of the camera when not zoomed
	public float smooth = 5; //deterimes the speed of transition between zoomed in and not
	private bool zoomedIn = false;
	private Camera camera;

//  public GameObject camera1;
//	public GameObject camera2;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera>();
		normal = camera.fieldOfView;
	}
	/*void SwitchCam(bool newCam) {
			Debug.Log(newCam);
			camera1.SetActive(false);
			camera2.SetActive(false);
			if (newCam == true){
				camera2.SetActive(false);
				Debug.Log("True in if statement");
				camera1.SetActive(true);
			}
			if (newCam == false){
				camera1.SetActive(false);
				camera2.SetActive(true);
				Debug.Log("False in if statement");
			}
	} */
	void OnMouseDown(){

	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("z")){
			Debug.Log("Pressed Z");
			zoomedIn = !zoomedIn;
		}
		if(zoomedIn){
			Debug.Log("True!");
			camera.orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize, zoom, Time.deltaTime * smooth);
		}
		else 
		{
			Debug.Log("False!");
			camera.orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize, normal, Time.deltaTime * smooth);
		}

	}
}
