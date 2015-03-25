using UnityEngine;
using System.Collections;

public class LogicControl : MonoBehaviour {
	
	public GameObject WholeMediaHub;
	public GameObject AnimatedBuilding;
	public GameObject StaticBuilding;
	public GameObject ARCamera;
	public GameObject RestartBtn;
	public GameObject PhotoBtn;
	public GameObject LoseTrackTexture;

	public AudioClip AmbientClip;
	
	//public Light Light_Flare;
	public GameObject Light_Flare;
		
	public bool StartAnimation;
	private bool tempStartStatus;
	public bool showStatic;
	private bool tempAnimationStatus;
	
	//private Animation anim;
	// Use this for initialization
	public bool TrackingStatus = false; //only set to false from beginning
	private bool tempTrackingStatus;
	public bool TriggerReset;
	
	
	void Start () {
	
		Reset();	
	}
	

	
	// Update is called once per frame
	void Update () {
		
		if(Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu)) 
			{	
				Application.Quit(); 
				return;
			}
		}
		
		if(TriggerReset == true)
		{
			Reset();
		}
		
		/*
		if (Input.GetMouseButtonDown(0))
        {
			RaycastHit hitInfo = new RaycastHit();
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
				string hitTarget = hitInfo.transform.gameObject.tag;
				Debug.Log ("Hit "+hitTarget);
				
				CheckHitTarget(hitTarget);
			}
		}	
		
		if(Input.touches.Length > 0)
		{
	       	RaycastHit hitTouch = new RaycastHit();
	        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.touches[0].position), out hitTouch))
			{
				string hitTarget = hitTouch.transform.gameObject.tag;
				Debug.Log ("Hit "+hitTarget);
				
				CheckHitTarget(hitTarget);
			}
		}
		*/
	
		if(StartAnimation != tempStartStatus)
		{
			if(StartAnimation == true)
			{
				tempStartStatus = StartAnimation;
				StaticBuilding.SetActive(false);
				Light_Flare.SetActive(true);
				Light_Flare.GetComponent<Animation>().Play("LightAnimation_2");
				AnimatedBuilding.SetActive(true);
				//RestartBtn.GetComponent<UIButton>().onClick();
				//anim.Play();
			}
			else
			{
				tempStartStatus = StartAnimation;
				StaticBuilding.SetActive(true);
				//Light_Flare.enabled = false;	
				AnimatedBuilding.SetActive(false);
				//anim.Stop();
				/*
				audio.clip = AmbientClip;
				audio.loop = true;
				audio.Play();
				*/
				//Fade in floor and tree
				WholeMediaHub.GetComponent<Animation>().Play("FadeInFloorTree");
			}	
		}
		
		/*
		if(showStatic != tempAnimationStatus)
		{
			if(showStatic == true)
			{
				tempAnimationStatus = showStatic;
				AnimatedBuilding.SetActive(false);
				StaticBuilding.SetActive(true);
				//Light_Flare.enabled = false;	
				//ARCamera.GetComponent<UI>().ShowResetBtn = true;
				//NGUITools.SetActive(ResetBtn, true);
			}
			
		}
		*/
		
		if(TrackingStatus != tempTrackingStatus)
		{
			if(TrackingStatus == true) //Tracking
			{
				tempTrackingStatus = TrackingStatus;
				
				//Show Restart Btns
				NGUITools.SetActive(RestartBtn, true);
				
				LoseTrackTexture.GetComponent<UIPlayTween>().Play(false);
				
				if(StartAnimation == false) //If animation has not started yet
				{
					if(showStatic == false)
					{
						Light_Flare.SetActive(true); 
						Light_Flare.GetComponent<Animation>().Play("LightAnimation_1");
					}
					//Show TakePhoto button
					NGUITools.SetActive(PhotoBtn, true);
					//Play Music (Ambient)
					audio.clip = AmbientClip;
					audio.loop = true;
					audio.Play();
				}
			}
			else //Lose Tracking
			{
				tempTrackingStatus = TrackingStatus;
				Light_Flare.SetActive(false); //.enabled = false;
				//Hide Btns
				NGUITools.SetActive(RestartBtn, false);
				NGUITools.SetActive(PhotoBtn, false);
				//Enable noise
				//ARCamera.GetComponent<NoiseEffect>().enabled = true;
				LoseTrackTexture.GetComponent<UIPlayTween>().Play(true);
				
				if(StartAnimation == false)
				{
					//Pause Music (Ambient)
					audio.Pause();
				}
				
			}
			
		}
		
	}
	/*
	void CheckHitTarget(string hitTarget)
	{
		switch (hitTarget)
		{
		case "Floor":
		{    //StartAnimation = true;
		   	//RestartBtn.GetComponent<UIButton>().onClick; //  GetComponent<UIPlayTween>().Play(true);    
			break;
		}
		}
	}*/
	
	void Reset()
	{
		StartAnimation = tempStartStatus = showStatic = tempAnimationStatus = false;
		tempTrackingStatus = true;
		AnimatedBuilding.SetActive(false);
		//anim = AnimatedBuilding.GetComponent<Animation>();			
		StaticBuilding.SetActive(false);
		/*
		if(TrackingStatus == true)
			Light_Flare.enabled = true;
		else
			Light_Flare.enabled = false;
		*/
		//Turn on the light flare
		Light_Flare.SetActive(true);// .enabled = true;
		Light_Flare.GetComponent<Animation>().Play("LightAnimation_1");
					
		TriggerReset = false;
		
		//ARCamera.GetComponent<UI>().ShowResetBtn = false;
		//NGUITools.SetActive(ResetBtn, false);
	}
	
	
	void OnApplicationPause() 
	{
    	Application.Quit(); 
		return;
		
	}
	
	
	
}
