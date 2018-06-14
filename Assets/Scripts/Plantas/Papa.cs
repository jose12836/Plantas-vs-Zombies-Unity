using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Papa : MonoBehaviour {
	
	public GameObject Explosion;
	public Transform Detector;
	public LayerMask layerZombie;

	IEnumerator Start () {
		
		while (true) {
			yield return new WaitForSeconds (1);
			RaycastHit2D hit = Physics2D.Raycast (Detector.position, Vector3.right,0.9f,layerZombie);
			if (hit.collider != null) {	
				print("BUM");
				GameObject go = Instantiate (Explosion, transform.position , Explosion.transform.rotation) as GameObject;
				Destroy (go, 1f);
				Destroy(gameObject);


			}
		}


	}
}
