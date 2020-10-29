using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {
		public Color startColor;
		public Color mouseOverColor;
		bool mouseOver = false;

		void OnMouseEnter(){
			mouseOver = true;
			GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);

		}
		void OnMouseExit(){
			mouseOver = false;
			GetComponent<Renderer>().material.SetColor("_Color", startColor);
		}
		void Update(){
		}
}
