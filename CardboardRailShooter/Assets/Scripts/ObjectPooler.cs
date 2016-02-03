using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum ObjectType
{
    Bullet
}
public class ObjectPooler : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;
	List<GameObject> BulletList;
    
    void Awake()
    {
        BulletList = new List<GameObject>();
        PopulateLists();
    }
    
    
    
    void PopulateLists()
    {
        for(int i = 0; i < 20; i++)
        {
            BulletList.Add((GameObject)GameObject.Instantiate(bulletPrefab,
                                                              Vector3.zero, 
                                                              Quaternion.identity));
        }
    }
    
    
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }
    
    List<GameObject> tempList;
    GameObject tempObj;
    public GameObject CreateObject(ObjectType type, Vector3 pos, Quaternion rot)
    {
        switch(type)
        {
            case ObjectType.Bullet:
                tempList = BulletList;
            break;
        }
        
        for(int i = 0; i < tempList.Count; i++)
        {
            if(!tempList[i].activeInHierarchy)
            {
                tempList[i].SetActive(true);
                tempObj = tempList[i];
                break;
            }
        }
        return tempObj;
    }
}
