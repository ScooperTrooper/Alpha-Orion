using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Zoom : MonoBehaviour {

    public Camera Camera;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(Input.mouseScrollDelta.ToString());


        if (Input.mouseScrollDelta.y < 0 && Camera.orthographicSize < 30)
        {
            Camera.orthographicSize = Camera.orthographicSize + 1;
        }
        else if (Input.mouseScrollDelta.y > 0 && Camera.orthographicSize >2)
        {
            Camera.orthographicSize = Camera.orthographicSize - 1;
        }
		
	}
}
