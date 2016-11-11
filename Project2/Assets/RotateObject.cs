using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {
    public float rotationSpeed=1;

	void Update () {
        transform.Rotate(Vector3.right * Time.deltaTime*rotationSpeed*10);

        transform.Rotate(Vector3.up * Time.deltaTime*rotationSpeed*10, Space.World);
    }
}
