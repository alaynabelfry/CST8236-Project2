using UnityEngine;
using System.Collections;

public class ChangeMaterials : MonoBehaviour {
    public Material[] materials;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        if (Input.GetKeyDown(KeyCode.Alpha1)|| Input.GetKeyDown(KeyCode.Keypad1)) {
            if (materials[0] != null)
            {
                renderer.material = materials[0];
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (materials[1] != null)
            {
                renderer.material = materials[1];
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (materials[2] != null)
            {
                renderer.material = materials[2];
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            if (materials[3] != null)
            {
                renderer.material = materials[3];
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            if (materials[4] != null)
            {
                renderer.material = materials[4];
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            if (materials[5] != null)
            {
                renderer.material = materials[5];
            }
        }
    }
}
