using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	// Use this for initialization
    private LevelManager lm;
    void OnTriggerEnter2D(Collider2D trigger)
    {
        //print ("trigger");
		lm = GameObject.FindObjectOfType<LevelManager>();
		lm.loadlevel("Loose");
        
    }
    void OnCollisionEnter2D(Collision2D collsion)
    {
      //print ("collision");
      
    }
}
