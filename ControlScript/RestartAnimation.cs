using UnityEngine;
using System.Collections;

public class RestartAnimation : MonoBehaviour {
	
	public GameObject Building;
	// Use this for initialization
	void OnClick()
	{
		Building.GetComponent<ReturnButton>().AnimationStart();
	}
}
