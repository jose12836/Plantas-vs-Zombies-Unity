using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorGirasol : MonoBehaviour {

	public float frecuenciaDeSoles = 1;
	public GameObject Sol;

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds (frecuenciaDeSoles);
			GameObject go = Instantiate (Sol, transform.position + Vector3.up*Random.Range(-4f,3f) + Vector3.left*Random.Range(-7f,5f), Sol.transform.rotation) as GameObject;

			Destroy (go, 10);
		}
		
	}
}
