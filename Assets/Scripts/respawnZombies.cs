using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnZombies : MonoBehaviour {

	public int[] tiempo;
	public GameObject Zombie;

	void Start () {

		for (int x = 0; x < tiempo.Length; x++) {
			Invoke ("InstanciarZombie", tiempo [x]);		
		}
	}
	void InstanciarZombie(){
		Instantiate (Zombie, transform.position , Zombie.transform.rotation);		
	}
}
