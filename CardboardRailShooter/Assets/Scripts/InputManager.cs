using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {


    Vector3 temp = Vector3.zero;
    Vector3 temp1 = Vector3.zero;
    public void Update()
    {
        temp.x = -Input.GetAxis("Mouse Y");
        temp.y = Input.GetAxis("Mouse X");
        temp.z = 0f;
        Camera.main.gameObject.transform.Rotate(temp * 100 * Time.deltaTime);
        
        temp1 = Camera.main.gameObject.transform.localEulerAngles;
        temp1.z = 0;
        Camera.main.gameObject.transform.localEulerAngles = temp1;
    }
}
