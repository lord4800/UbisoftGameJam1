using UnityEngine;
using System.Collections;

public class Drink : MonoBehaviour {
	public bool FuckThisShit = false;
	public bool FuckTShit = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider myTrigger) 
	{
		if (myTrigger.gameObject.name == "New Sprite")
			//if (myTrigger.tag = player)
		{
			FuckThisShit = true;
			Debug.Log("Box went through!");
		}

	}
	void  OnTriggerExit (Collider myTrigger) 
	{
		if (myTrigger.gameObject.name == "New Sprite")
			//if (myTrigger.tag = player)
		{
			FuckThisShit = false;
			Debug.Log("Box went through!");
		}
		
	}
}
