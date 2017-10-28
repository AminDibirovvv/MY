using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 50f;
    public float jumperPower = 50f;

    public bool graunded;
    private Rigidbody2D Hero;
    private Animator anim;

    // Use this for initialization
    void Start () {
        Hero = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float xMove = Input.GetAxis("Horizontal") * speed;
        float yMove = Input.GetAxis("Vertical") * speed;
        Hero.AddForce(new Vector2(xMove, yMove));
        anim.SetBool("Grounded", graunded);
        anim.SetFloat("Speed",Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        Hero.AddForce((Vector2.right * speed) * h);
    }


}
