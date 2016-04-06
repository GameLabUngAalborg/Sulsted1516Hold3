using UnityEngine;
using System.Collections;

public class craftingmenu : MonoBehaviour {
	public GameObject Panel;
	private bool open;
	// Use this for initialization
	void Start () {		
		open = false;
	
	}

	void Update(){
		if (Input.GetKey(KeyCode.I)) {
			Panel.SetActive (true); 
		} else {
			Panel.SetActive (false); 
		}
	}
			

	// Update is called once per frame
	/*void Update () {
		if (Input.GetKey (KeyCode.I)) {
			if (open == false) {
				Panel.SetActive (true);
				open = true;
			}
			else if (open==true) {
				Panel.SetActive (false);
				open = false;
			}
		}
	
	}*/
}
