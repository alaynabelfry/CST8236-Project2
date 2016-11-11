using UnityEngine;
using System.Collections;

public class ChangeProjection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Camera cam = GetComponent<Camera>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //switch between true/false orthographic/perspective
            cam.orthographic = !cam.orthographic;
        }

	}
}
