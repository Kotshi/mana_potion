using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {
    public int JumpCount;

	// Use this for initialization
	void Start () {
        JumpCount = 0;
    }

    void OnTriggerEnter2D() {
        JumpCount = 0;
    }
}
