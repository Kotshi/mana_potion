using UnityEngine;
using System.Collections;

public class RevertBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.mousePosition.x < (Screen.width / 2))
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        else
            gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
