using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {
    public int JumpCount;
    public bool QuickFall;
 
	// Use this for initialization
	void Start () {
        JumpCount = 0;
    }

    void OnTriggerStay2D() {
        JumpCount = 0;
        QuickFall = true;
    }
}
