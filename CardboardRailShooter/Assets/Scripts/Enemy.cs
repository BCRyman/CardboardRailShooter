using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    [SerializeField]
    int health;
    
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            ChangeHealth(-1);
            ObjectPooler.Instance.ReleaseObject(col.gameObject);
        }
    }
    
    void ChangeHealth(int amount)
    {
        health += amount;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
