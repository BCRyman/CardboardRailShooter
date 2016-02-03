using UnityEngine;
using System.Collections;

public class RailPoint : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("SOMETHING IN HERE");
        if(col.gameObject.tag == "Player")
        {
            GameManager.Instance.RailManager.TriggerNextPoint();
        }
    }
}
