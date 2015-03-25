using UnityEngine;
using System.Collections;

public class TakePhoto : MonoBehaviour {
	
	public GameObject RestartBtn;
	public GameObject TakePhotoBtn;
	
	
	void OnClick() //Use Gallary Screenshot
	{
		audio.Play();
		NGUITools.SetActive(RestartBtn, false);
		NGUITools.SetActive(TakePhotoBtn, false);
		animation.Play();
		StartCoroutine(ScreenshotManager.Save("MediaHub", "MediaHub"));

	}
	
	void AfterPhotoTaking()
	{
		NGUITools.SetActive(RestartBtn, true);
		NGUITools.SetActive(TakePhotoBtn, true);
		
	}
}
