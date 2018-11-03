using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	// Use this for initialization
	public AudioClip crack;
	private LevelManager lm;
	public Sprite[] HitSprite;
	public  GameObject smoke;
	public static int breakablecount =0;//only will be intitlaised once
	//private int maxhits;
	private int timeshit;
	private bool isBreakable;
	void Start () {
	     lm =GameObject.FindObjectOfType<LevelManager>();
	     timeshit=0;
		isBreakable=(this.tag=="Breakable");
		if(isBreakable)
		{
			breakablecount++;		
		}
	}
	void OnCollisionEnter2D(Collision2D collsion)
	{
        AudioSource.PlayClipAtPoint(crack,this.transform.position);
        if(isBreakable)
        {
			HandleHits();
        }
        
		
	}
	void HandleHits()
	{
		timeshit++;
		int maxhits=HitSprite.Length+1;
		if(timeshit >= maxhits)
		{
			breakablecount--;
			lm.BrickDestroyed();
			GameObject smokepuff=Instantiate(smoke,gameObject.transform.position,Quaternion.identity) as GameObject;
			smokepuff.particleSystem.startColor=gameObject.GetComponent<SpriteRenderer>().color;
			Debug.Log("destoryed");
			Destroy(gameObject);
			
		}//SimulateWin();
		else
		{
			LoadSprites();
		}
	}
	
	// Update is called once per frame
	void LoadSprites()
	{
	
	    int  spritehit=timeshit-1;
		if(HitSprite[spritehit])// in case we forgot to drag sprite in unity
		{
	    this.GetComponent<SpriteRenderer>().sprite=HitSprite[spritehit];
	    }
	
	}
	void Update () {
	
	}
	void SimulateWin()
	{
	    lm.LoadNextLevel();
	}
}
