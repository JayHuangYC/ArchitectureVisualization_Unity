using UnityEngine;
using System.Collections;

public class ParticleControl : MonoBehaviour {
	
	//public bool[] playParticle = false;
	public GameObject[] particle;
	public Transform[] transform;
	// Use this for initialization
	
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void Play_01_pFx_RainbowExplosion()
	{
		Instantiate(particle[0], transform[0].position, transform[0].rotation);
	}
	
	void Play_02_pFx_DigitalSquare()
	{
		Instantiate(particle[1], transform[1].position, transform[1].rotation);
	}
	
	void Play_03_pFx_SoleSmoke01()
	{
		Instantiate(particle[2], transform[2].position, transform[2].rotation);
	}
	
		void Play_04a_pFx_FloorBox01()
	{
		Instantiate(particle[3], transform[3].position, transform[3].rotation);
	}
	
		void Play_04b_pFx_FloorBox01()
	{
		Instantiate(particle[4], transform[4].position, transform[4].rotation);
	}
	
		void Play_04c_pFx_FloorBox01()
	{
		Instantiate(particle[5], transform[5].position, transform[5].rotation);
	}
	
		void Play_04d_pFx_FloorBox01()
	{
		Instantiate(particle[6], transform[6].position, transform[6].rotation);
	}
	
		void Play_04e_pFx_FloorBox01()
	{
		Instantiate(particle[7], transform[7].position, transform[7].rotation);
	}
	
		void Play_05a_pFx_GreenSpace()
	{
		Instantiate(particle[8], transform[8].position, transform[8].rotation);
	}
	
		void Play_05b_pFx_GreenSpace()
	{
		Instantiate(particle[9], transform[9].position, transform[9].rotation);
	}
	
		void Play_05c_pFx_GreenSpace()
	{
		Instantiate(particle[10], transform[10].position, transform[10].rotation);
	}
	
		void Play_05d_pFx_GreenSpace()
	{
		Instantiate(particle[11], transform[11].position, transform[11].rotation);
	}
	
		void Play_06_pFx_GlitterBox()
	{
		Instantiate(particle[12], transform[12].position, transform[12].rotation);
	}
	
		void Play_07_Stream_Light01()
	{
		Instantiate(particle[13], transform[13].position, transform[13].rotation);
	}
		void Play_07_Stream_Light02()
	{
		Instantiate(particle[14], transform[14].position, transform[14].rotation);
	}
	
		void Play_08_Stream_Light01()
	{
		Instantiate(particle[15], transform[15].position, transform[15].rotation);
	}
	
		void Play_08_Stream_Light02()
	{
		Instantiate(particle[16], transform[16].position, transform[16].rotation);
	}
	
		void Play_09_pFx_Fireworks()
	{
		Instantiate(particle[17], transform[17].position, transform[17].rotation);
	}
}
