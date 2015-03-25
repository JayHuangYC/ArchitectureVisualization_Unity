using UnityEngine;
using System.Collections;

public class SwitchOffFlareLight : MonoBehaviour {
	
	public GameObject Light_Flare;

	void OffLight()
	{
		Light_Flare.SetActive(false); // .enabled = false;
	}
}
