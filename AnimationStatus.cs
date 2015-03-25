using UnityEngine;
using System.Collections;

public class AnimationStatus : MonoBehaviour {
	
	
	public bool buildingStopAnimated;
	public GameObject ImageTarget;
	public GameObject RestartBtn;
	public Light BuildingLight;
	public GameObject PhotoBtn;
	public AudioClip AnimClip;
	public AudioSource Music;
	
	// Use this for initialization
	void Start () {
		buildingStopAnimated = false;
		Music = ImageTarget.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void AnimationStart()
	{
		buildingStopAnimated = false;
		animation.Play("RW_Construction_Animation");	
		ImageTarget.GetComponent<LogicControl>().StartAnimation = true;
		ImageTarget.GetComponent<LogicControl>().showStatic = true;
		NGUITools.SetActive(PhotoBtn, false);
	}
	
	void BeforeAnimationStop()
	{
		buildingStopAnimated = true;
		RestartBtn.GetComponent<UIPlayTween>().Play(false);
		NGUITools.SetActive(PhotoBtn, true);
		RestartBtn.GetComponentInChildren<UILabel>().text = "Restart";
		BuildingLight.GetComponent<Animation>().Stop();
		

		
		//ImageTarget.GetComponent<LogicControl>().StartAnimation = false;// .showStatic = buildingStopAnimated;
	}
	
	void AnimationStop()
	{
		/*
		Music.Stop();
		Music.clip = ImageTarget.GetComponent<LogicControl>().AmbientClip;
		Music.loop = true;		
		Music.Play();
		*/
		ImageTarget.GetComponent<LogicControl>().StartAnimation = false;// .showStatic = buildingStopAnimated;
		
	}
	
	
	void MusicStart()
	{
		
		Music.Stop();
		Music.clip = AnimClip;
		Music.loop = false;
		Music.Play();
		
		//Start light shadow
		BuildingLight.GetComponent<Animation>().Play("LightAnimation_Building");
		
	}
}
