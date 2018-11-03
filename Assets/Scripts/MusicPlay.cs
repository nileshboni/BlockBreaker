using UnityEngine;
using System.Collections;

public class MusicPlay : MonoBehaviour {

	static MusicPlay instance=null;
//	static int couns
	// Use this for initialization
	void Awake()
	{
		if(instance!=null)							//you can also use count for the if condition 
		{
			GameObject.Destroy(gameObject);
			Debug.Log("duplicate destroyed");
		}
		else
		{
			instance=this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	void Start () {
//		if(instance!=null)							//you can also use count for the if condition 
//		{
//			GameObject.Destroy(gameObject);
//			Debug.Log("duplicate destroyed");
//		}
//		else
//		{
//		   instance=this;
//		   GameObject.DontDestroyOnLoad(gameObject);
//		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
