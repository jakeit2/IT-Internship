public class createLineGraph : Monobehaviour {
void Start () {
  Debug.Log("Started.");
  string salesurl = "http://localhost:3001/test2";
  string areaurl = "http://localhost:3001/test2";
  StartCoroutine(startJSON(salesurl, areaurl));

  if(isDataCompleted){
    GameObject graphGO = GameObject.Instantiate(emptyGraphPrefab);
    graphGO.transform.SetParent(this.transform, false);
    graph = graphGO.GetComponent<WMG_Axis_Graph>();
    series1 = graph.addSeries();
    graph.xAxis.AxisMaxValue = 5;
    List<string> groups = new List<string>();
    graph.groups.SetList(groups);
    graph.useGroups = true;
    graph.xAxis.LabelType = WMG_Axis.labelTypes.groups;
    graph.xAxis.AxisNumTicks = groups.Count;
    series1.seriesName = "Sales Data"; //name of the key at the bottom
    groups.Add("Q1");
    groups.Add("Q2");
    groups.Add("Q3"); //Adds the X labels
    groups.Add("Q4");
    series1.UseXDistBetweenToSpace = true;
    series1.pointValues.SetList(data);
  }
  else
  {

    Debug.Log("Data could not be loaded, please exit the region and try to exit again. If this does not work, check your network connection speed and make sure there are no problems with it. If all of that is a success, then check the status of the database. It could be under maintenance. If you think that this is a bug, please report it.");
  }
}

void update();

}
}
