using UnityEngine;
using UnityEngine.UI;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using System;
using LitJson;
//TODO: make it so that clicking on a region receieves the data based on its region ID
//There are a few imporant things for this program. Regions must be tagged as regions and merchandise/tables/etc must be tagged as merchandise so that they will be properly deleted. Regions must have a sphere collider, if they do not, then we need to add the code to support other kinds of colliders.
//TODO: have it check for the neccessary VR requirements


public class Region_Change : MonoBehaviour {
		public int totalSquareFootage = 0;
		public int numberRegion = 0;
		public GameObject[] gos;
		private Vector3 screenPoint;
		private Vector3 offset;
		public JsonData itemData;
		private string jsonString;
		public int producitivty, area, sales;
		public string floor, departmentID, stringToEdit;
		public long minimumSpeedG = 9;
		private string url;
		public GameObject emptyGraphPrefab;
		public WMG_Axis_Graph graph;
		public WMG_Series series1;
		public List<Vector2> data;
		public List<String> groups;
		public List<Vector2> series1Data;
		public bool useData2;
		public List<string> series1Data2;
		public bool isDataCompleted;

	// Use this for initialization
	//start the node server with node-dev VRteam.js



//http://10.132.5.99:8000/area/sum/session/1?departments%5B0%5D=27&sub_codes%5B0%5D=1&sub_codes%5B1%5D=2&box_floors%5B0%5D=1348

	void Start () {
		Debug.Log("Started.");
		string salesurl = "http://localhost:3001/test2";
		string areaurl = "http://localhost:3001/test2";
		StartCoroutine(startJSON(salesurl, areaurl));

	}
	//checks network status and speed -- returns false if one of those parameters (or both) are not to standards
		void OnCollisionEnter(Collision col){
			Debug.Log("Collided!");
			if(col.gameObject.name == "dockers"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "sales"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "bar3"){
				string salesurl = "localhost:3001";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "alfani"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "polo_ralph_lauren"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "nautica"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "assorted_underwear"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "alfani2"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "calvin klein"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "michael kors"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
			if(col.gameObject.name == "eagle"){
				string salesurl = "";
				string areaurl = "";
				StartCoroutine(startJSON(salesurl, areaurl));
			}
		}
	public static bool IsNetworkAvailable(long minimumSpeed)
	{
		if (!NetworkInterface.GetIsNetworkAvailable())
			return false;

		foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
		{
			// discard because of standard reasons
			if ((ni.OperationalStatus != OperationalStatus.Up) ||
				(ni.NetworkInterfaceType == NetworkInterfaceType.Loopback) ||
				(ni.NetworkInterfaceType == NetworkInterfaceType.Tunnel))
				continue;

			// this allow to filter modems, serial, etc
			if (ni.Speed < minimumSpeed)
				continue;

			// discard virtual cards so this can be run on virtual machines, etc
			if ((ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) ||
				(ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
				continue;

			// discard "Microsoft Loopback Adapter", it will not show as NetworkInterfaceType.Loopback but as Ethernet Card.
			if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
				continue;

			return true;
		}
		return false;
	}
	IEnumerator startJSON(string areaURL, string salesURL)
	{
		var isDataCompleted = false;
		//TODO:if we really need a stringbuilder built for like dynamically getting data with one script, I can build one, but I do not see the point in that currently.
		Debug.Log("Building the JSON!");
	  WWW saleswww = new WWW(salesURL);
		WWW areawww = new WWW(areaURL);
		yield return saleswww;
		Debug.Log("Made it passed saleswww!");
		yield return areawww;
		Debug.Log("Made it passed areawww");
		if (IsNetworkAvailable(minimumSpeedG)) {
			if (areawww.error == null){
				Processjson(areawww.text, "area"); //whenever data is needed from the JSON, call it here
			}
			else
			{
				Debug.Log("ERROR:" + areawww.error);
			};
			if (saleswww.error == null)
			{
				Debug.Log("JSON ready and loaded!");
				Processjson(saleswww.text, "sales");
			}
			else
			{
				Debug.Log("ERROR: " + saleswww.error);
			};
		}
		else
		{
			Debug.Log("Your system does not meet the minimum network requirement of" + " " + minimumSpeedG + " " + "for loading the data. Please update your system to have the required network parameters. If you feel that this is a mistake, report the bug.");
			Application.Quit();
		};
	}
	public void Processjson(string jsonString, string parameter)
	{
			/*if(parameter == "area"){
			Debug.Log("Processing area data!");
			var salesitemData = JsonMapper.ToObject(jsonString);
			var grossArea = salesitemData["data"]["grossArea"];
			Debug.Log("The gross area is:" + " " + grossArea);
		} */
		if(parameter == "sales"){
			Debug.Log("Processing sales data!");
			var areaitemData = JsonMapper.ToObject(jsonString);
			List<Vector2> data = new List<Vector2>();
			int sales = (int) areaitemData["2016"];
			int sales2 = (int) areaitemData["2017"];
			int sales3 = (int) areaitemData["2018"];
			int sales4 = (int) areaitemData["2019"];
			data.Add(new Vector2(sales, 1));
			data.Add(new Vector2(sales2, 2));
			data.Add(new Vector2(sales3, 3));
			data.Add(new Vector2(sales4, 4));
			Debug.Log("The sales for 2016 is:" + " " + sales);
			var isDataCompleted = true;
		//	createLineGraph();
		}
		/*Debug.Log("Processing JSON!");
		itemData = JsonMapper.ToObject(jsonString);
		var floorID = itemData["floor"];
		var departmentID = itemData["department"];
		int storeArea = (int) itemData["area"];
		int sales = (int) itemData["sales"];
		Debug.Log("FloorID: " + " " + floorID + " " + "DepartmentID:" + " " + departmentID + " " + "Area:" + " " + storeArea + " " + "Sales:" + " " + sales);
		var producitivty = (sales / storeArea);
		//TODO: find a way to make it so that it can divide a larger numerator by lesser denominator
		Debug.Log("Producitivty:" + " " + producitivty + " " + "Sales: " + " " + sales + " " + "StoreArea: " + " " + storeArea);
		//OnGUI();
		*/
	}
	/*void OnGUI(){
		int sales = (int) itemData["sales"];
		int area = (int) itemData["area"];
		var producitivty = (sales / area);
		Debug.Log("Producitivty in onGUI: " + " " + producitivty);
		var producitivtyString = (producitivty.ToString());
		Debug.Log("String editted.");

	}*/
	void RegionCount() {
		//counts the number of regions by counting the number of objects with the tag "region" and placing them in an array and using the native .length function
		gos = GameObject.FindGameObjectsWithTag("region");
		numberRegion = gos.Length;
		Debug.Log (gos.Length);
	}
	void TakeEqualSpace(){
		//takes an equal amount of space from each section of the store, probably not the most realistic option, but it is one that could be used
		var totalArea = false;
		var addedSpace = true;

		int totalAreaStore = (int) itemData["area"];
		var spaceWanted = 0; //TODO: get user input for spaceWanted
		if (totalArea = true) {int spaceNeeded = (spaceWanted - totalAreaStore)/10;} //TODO: change the 2 to the input
		if (addedSpace = true) {int spaceNeeded = 2/10;}
		//int amountDeducted = (spaceNeeded / numberRegion)f; //TODO: go back and fix this
		//foreach (GameObject x in gos) {
		//transform.localScale += new Vector3 ((amountDeducted), 0, 0);
		//}
	}
	void DeleteLeastRegion(){
		//have it parse a spreadsheet for the least profitable section and the amount of space that you would either a) need to take space from b)completely get rid of
		var explosionPosition1 = transform.position;
		var explosionRadius1 = 10.0f;
		var destroyTotal = false;
		var neededSpace = 0;
		var leastRegion = 8; // TODO: change the 8 to whatever the result is after the query of the spreadsheet or whatever it may be
		Collider[] colliders = Physics.OverlapSphere(explosionPosition1, explosionRadius1);
		if (destroyTotal == true) {
			foreach (var col in colliders)
			{
				if (col.GetComponent<Collider>().tag == "merchandise")
				{
					Destroy(col.GetComponent<Collider>().gameObject);
				}
				if (col.GetComponent<Collider>().tag == "region")
				{
					Destroy(col.GetComponent<Collider>().gameObject);
					Debug.Log ("Deleted" + gameObject);
				}
			}
		};// else
		//neededSpace = 10 //TODO:have this scale with the inputted needed space from the user
		//leastRegion.transform.localScale += new Vector3((neededSpace),0,0);
	}
	void OnMouseDrag()
	{
		if (Input.GetMouseButtonDown(0)) {
			float distance_to_screen = Camera.main.WorldToScreenPoint (gameObject.transform.position).z;
			transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
		}
	}
	/*	void DeleteRegion(){ TODO: go back to this and fix it
			//every different brand needs to have a collider set with an accurate region border so that when one is changed, it can be accurately scaled automatically
			var explosionPosition = transform.position;
			var explosionRadius = GameObject.SphereCollider.radius;
			Collider[] colliders = Physics.OverlapSphere(explosionPosition, explosionRadius);
			foreach (var col in colliders)
			{
				if (col.GetComponent<Collider>().tag == "merchandise")
				{
					Destroy(col.GetComponent<Collider>().gameObject);
				}
				if (col.GetComponent<Collider>().tag == "region")
				{
					Destroy(col.GetComponent<Collider>().gameObject);
					Debug.Log ("Deleted" + gameObject);
				}
			}
		}*/
	// Update is called once per frame
	void Update () {

	}
}
