using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RailManager : MonoBehaviour {

	[SerializeField]
    private List<RailPoint> pathList;
    [SerializeField]
    GameObject railCart;
    
    [SerializeField]
    int cartSpeed, pointCount;
    public void RailUpdate()
    {
        if(pointCount < pathList.Count)
            MoveTowardNextPoint();
        else
        {
            //UI Show End Level Report
            GameManager.Instance.UIManager.EndScreen(true);
        }
    }
    
    private void MoveTowardNextPoint()
    {
        Vector3 dir = pathList[pointCount].transform.position -railCart.transform.position;  
        railCart.transform.Translate(dir.normalized * cartSpeed * Time.deltaTime);
      //  railCart.transform.LookAt(pathList[pointCount].transform);
       // Vector3 temp = railCart.transform.localEulerAngles;
        //temp.x = 0; temp.z = 0;
        //railCart.transform.localEulerAngles = temp;
    }
    
    public void TriggerNextPoint()
    {
        pointCount++;
    }
    
    
}
