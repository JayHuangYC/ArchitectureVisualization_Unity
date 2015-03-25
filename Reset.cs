using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	//public GUIStyle ResetStyle;
	public GameObject ImageTarget;
	public bool ShowResetBtn;
	//public bool tempShowResetBtn;
	
	// Use this for initialization
	void Start () {
		//ShowResetBtn = false;
	}
	
	void OnClick()
	{
		ImageTarget.GetComponent<LogicControl>().TriggerReset = true;
		//ShowResetBtn = false;
		
	}
	
	/*void OnGUI () {
	
		float btn = (Screen.height/8.0f); //Unit of Buttons
		float sw  = Screen.width;
		float sh  = Screen.height;
		float sc_x  = Screen.width/2f;
		float sc_y	= Screen.height/2f;
		
		if(ShowResetBtn)
		{
			if(GUI.Button(new Rect(0.5f*btn, (sh-2f*btn), (3f*btn), (1.5f*btn)), "Reset", ResetStyle)) 
			{
				ImageTarget.GetComponent<LogicControl>().TriggerReset = true;
				ShowResetBtn = false;
				
			}
		}
	}
	*/
}
