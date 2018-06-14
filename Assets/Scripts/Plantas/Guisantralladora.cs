using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guisantralladora : MonoBehaviour {

	public float frecuencia = 1;
	public GameObject Guisante;
	public Transform cañon;
	public LayerMask layerZombie;

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds (frecuencia);

			RaycastHit2D hit = Physics2D.Raycast (cañon.position, Vector3.right,13,layerZombie);
			if (hit.collider != null) {

				GameObject go = Instantiate (Guisante, cañon.position, Guisante.transform.rotation) as GameObject;
				yield return new WaitForSeconds (0.1f);
				GameObject go1 = Instantiate (Guisante, cañon.position, Guisante.transform.rotation) as GameObject;
				yield return new WaitForSeconds (0.1f);
				GameObject go2 = Instantiate (Guisante, cañon.position, Guisante.transform.rotation) as GameObject;
				Destroy (go, 2);
				Destroy (go1, 2);
				Destroy (go2, 2);

			}
		}

	}
}
