using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public int Speed;
    public int Accelleration;
    public int JumpSpeed;
    private Rigidbody2D rg2d;
	// Use this for initialization
	void Start () {
        rg2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rg2d.velocity.x < Speed)
            rg2d.AddForce(Vector2.right * Accelleration * Input.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
           rg2d.velocity = new Vector2(rg2d.velocity.x, JumpSpeed);
         }

    void OnCollisionStay()
    {
       print("test");
    }
}
