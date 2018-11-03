using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	private Ball ball;
	public bool autoplay= false;
	
	void Start () {
	   ball= GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	  if(!autoplay)
	  {
			MoveWithMouse();
	  }
	  else
	  {
			Autoplay();
	  }
	

	}
	void Autoplay()
	{
		Vector3 paddlepos=new Vector3(0f,this.transform.position.y,0f);
		Vector3 ballpos= ball.transform.position;
		paddlepos.x=Mathf.Clamp(ballpos.x,0.010f,15f);
		this.transform.position=paddlepos;
	}
	void MoveWithMouse()
	{
		Vector3 paddlepos=new Vector3(0f,this.transform.position.y,0f);
		float mousepos=Input.mousePosition.x/Screen.width*16;
		paddlepos.x=Mathf.Clamp(mousepos,0.5f,15.497f);
		this.transform.position=paddlepos;
	}
}
