using UnityEngine;
using System.Collections;

public class PlayBGMusic : MonoBehaviour {
	
	public GameObject ImageTarget;
	public AudioSource Music;
	
	void Start()
	{
		Music = ImageTarget.GetComponent<AudioSource>();
	}
	
	void PlayBGAudioClip()
	{
		Music.Stop();
		Music.clip = ImageTarget.GetComponent<LogicControl>().AmbientClip;
		Music.loop = true;
		Music.Play();
	}

}
