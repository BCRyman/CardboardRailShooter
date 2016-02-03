using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    [SerializeField]
    GameObject bulletOBJ;
    Vector3 temp = Vector3.zero;
    Vector3 temp1 = Vector3.zero;
    public void InputUpdate()
    {
        temp.x = -Input.GetAxis("Mouse Y");
        temp.y = Input.GetAxis("Mouse X");
        temp.z = 0f;
        Camera.main.gameObject.transform.Rotate(temp * 100 * Time.deltaTime);
        
        temp1 = Camera.main.gameObject.transform.localEulerAngles;
        temp1.z = 0;
        Camera.main.gameObject.transform.localEulerAngles = temp1;
        
        if(Input.GetMouseButtonDown(0))
        {
            //do the shoot at the middle of the screens
            GameObject.Instantiate(bulletOBJ, 
                                   Camera.main.transform.position, 
                                   Camera.main.transform.rotation);
        }
    }
}
