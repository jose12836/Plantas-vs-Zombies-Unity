using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaSandia : MonoBehaviour {

	public float frecuencia = 1;
	public GameObject Sandia;
	public Transform cañon;
	public LayerMask layerZombie;

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds (frecuencia);

			RaycastHit2D hit = Physics2D.Raycast (cañon.position, Vector3.right,13,layerZombie);
			if (hit.collider != null) {

				GameObject go = Instantiate (Sandia, cañon.position, Sandia.transform.rotation) as GameObject;
				Destroy (go, 2);

			}
		}

	}
}
