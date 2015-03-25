using UnityEngine;
using System.Collections;

public class ReturnButton : MonoBehaviour {
	
	public GameObject RestartBtn;
	
	// Use this for initialization
	void AnimationFinish()
	{
		RestartBtn.GetComponent<UIPlayTween>().Play(true);
		RestartBtn.GetComponentInChildren<UILabel>().text = "Restart";
		
	}
	
	public void AnimationStart()
	{
		animation.Play("Animation");
		
	}
}
