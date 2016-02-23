using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum ObjectType
{
    Bullet
}
public class ObjectPooler : MonoBehaviour {


    private static ObjectPooler instance;
    public static ObjectPooler Instance
    {
        get{return instance;}
        private set
        {
            if(instance != null)
            {
                Destroy(value);
            }
            else
            {
                instance = value;
            }
        }
    }
    
    [SerializeField]
    private GameObject bulletPrefab;
    private GameObject BulletParent;
	[SerializeField]
    List<GameObject> BulletList;
    
    void Awake()
    {
        Instance = this;
        BulletList = new List<GameObject>();
        PopulateLists();
    }
    
    
    GameObject tempObj;
    void PopulateLists()
    {
        BulletParent = new GameObject();
        for(int i = 0; i < 20; i++)
        {            
            tempObj = (GameObject)GameObject.Instantiate(bulletPrefab,
                                                              Vector3.zero, 
                                                              Quaternion.identity);
            tempObj.transform.parent = BulletParent.transform;
            tempObj.SetActive(false);
            BulletList.Add(tempObj);
        }
    }
    
    
    public void ReleaseObject(GameObject obj)
    {
        obj.SetActive(false);
    }
    
    List<GameObject> tempList;
    bool itemFound = false;
    public GameObject GetObject(ObjectType type, Vector3 pos, Quaternion rot)
    {
        
        switch(type)
        {
            case ObjectType.Bullet:
                tempList = BulletList;
            break;
        }
        itemFound = false;
        for(int i = 0; i < tempList.Count; i++)
        {
            if(!tempList[i].activeInHierarchy)
            {
              //  Debug.Log("ItemFound");
                tempList[i].SetActive(true);
                tempObj = tempList[i];
                tempObj.transform.position = pos;
                tempObj.transform.rotation = rot;
                itemFound = true;
                break;
            }
        }
        if(itemFound)
            return tempObj;
        else
            return CreateNewObject(type, pos, rot);
    }
    
    GameObject tempPrefab;
    public GameObject CreateNewObject(ObjectType type, Vector3 pos, Quaternion rot)
    {
        Debug.Log("Creating New Object");
        switch(type)
        {
            case ObjectType.Bullet:
                tempPrefab = bulletPrefab;
                tempList = BulletList;
                break;
        }
        
        tempList.Add((GameObject)GameObject.Instantiate(tempPrefab,pos, rot));
        return tempList[tempList.Count-1];
    }
}
