using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour {
	
	//Define the time duration
	public float Duration = 1.0f;
	
	void Start()
    {
        Destroy (gameObject, Duration);
    }
}
