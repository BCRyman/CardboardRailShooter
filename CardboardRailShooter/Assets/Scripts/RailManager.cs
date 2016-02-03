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
    }
    
    private void MoveTowardNextPoint()
    {
        
        railCart.transform.Translate(Vector3.forward * cartSpeed * Time.deltaTime);
        railCart.transform.LookAt(pathList[pointCount].transform);
        Vector3 temp = railCart.transform.localEulerAngles;
        temp.x = 0; temp.z = 0;
        railCart.transform.localEulerAngles = temp;
    }
    
    public void TriggerNextPoint()
    {
        pointCount++;
    }
}
