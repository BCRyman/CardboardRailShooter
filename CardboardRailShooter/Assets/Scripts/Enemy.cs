using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    [SerializeField]
    int health, enemyValue;
    
    
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Yo");
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
            GameManager.Instance.ScoreManager.CurrentScore += enemyValue;
            Destroy(this.gameObject);
            
        }
    }
}
