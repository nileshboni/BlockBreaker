using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	private Paddle paddle;
	private Vector3 paddletoballvector;
	private bool hasstarted=false;
	void Start () 
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddletoballvector= this.transform.position- paddle.transform.position;
		print (paddletoballvector.y);
	}
	
	// Update is called once per frame
	void Update () {
	  if(!hasstarted)
	  {
	      this.transform.position=paddle.transform.position+paddletoballvector;
	      if(Input.GetMouseButtonDown(0))
	      {
	        hasstarted=true;
	        //print ("lauch ball");
	        this.rigidbody2D.velocity=new Vector3(2f,10f);
	      }
	  }
	}
	void OnCollisionEnter2D(Collision2D collsion)
	{
		Vector2 tweak= new Vector2(Random.Range(0f,0.2f),Random.Range(0f,0.2f));
		if(hasstarted)
		{
		audio.Play();
		rigidbody2D.velocity+=tweak;
		}
	}
}
