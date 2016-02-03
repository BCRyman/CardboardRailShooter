using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	int speed = 5;
	// Update is called once per frame
	void Update () {
	   this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
