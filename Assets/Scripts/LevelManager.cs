using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadlevel(string name)
	{
	   Debug.Log("level");
	   Brick.breakablecount=0;
	   Application.LoadLevel(name);
	}
	public void quitlevel()
	{
		Debug.Log("level");
		Application.Quit();
	}
	public void LoadNextLevel()
	{
		Brick.breakablecount=0;
	  Application.LoadLevel(Application.loadedLevel +1);
	}
	public void BrickDestroyed()
	{
		print (Brick.breakablecount);
	   if(Brick.breakablecount<=0)
	   {
	        LoadNextLevel();
	   }
	}
}  
