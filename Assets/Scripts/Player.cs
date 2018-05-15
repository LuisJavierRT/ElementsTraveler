using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization

	
	
	[SerializeField] private float speed;
	private Rigidbody2D rb;
	private Animator anim;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
		speed = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
			anim.SetTrigger("run");
			transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis("Vertical")*Time.deltaTime);
		}
		if(Input.GetKeyDown(KeyCode.W)){
			anim.SetTrigger("jump");
			rb.AddForce(new Vector2(0,6),ForceMode2D.Impulse);
		}
		else{
			anim.SetTrigger("idle");
		}
	}
}
