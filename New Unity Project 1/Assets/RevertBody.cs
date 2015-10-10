using UnityEngine;
using System.Collections;

public class RevertBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.mousePosition.x);
        print(Screen.width / 2);
        if (Input.mousePosition.x < (Screen.width / 2))
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        else
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
