using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Toggel ()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void UnToggle ()
    {
        this.gameObject.GetComponent<Renderer>().enabled = true;
    }
}
