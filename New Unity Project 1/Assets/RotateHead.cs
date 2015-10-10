using UnityEngine;
using System.Collections;

public class RotateHead : MonoBehaviour {

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float[] PlayerPos = new float[] { Screen.width / 2, Screen.height / 2 };
        float rotation;

        rotation = Mathf.Atan((Input.mousePosition.y - PlayerPos[1]) / Mathf.Abs(Input.mousePosition.x - PlayerPos[0])) * (180 / Mathf.PI);
        gameObject.transform.eulerAngles = new Vector3(0, 0, rotation);
    }
}
