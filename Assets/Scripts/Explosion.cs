using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	void Update(){
		transform.position += Vector3.right* 1 * Time.deltaTime;
	}
}
