using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	int speed = 10;
	// Update is called once per frame
	void Update () {
	   this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
    
    void OnEnable()
    {
        StartCoroutine(CountDown());
    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(2);
        ObjectPooler.Instance.ReleaseObject(this.gameObject);
    }
}
