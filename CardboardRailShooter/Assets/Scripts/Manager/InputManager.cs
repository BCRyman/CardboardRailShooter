using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class InputManager : MonoBehaviour {

    [SerializeField]
    GameObject bulletOBJ;
    Vector3 temp = Vector3.zero;
    Vector3 temp1 = Vector3.zero;
    Ray ray;
    RaycastHit hit;
    bool shoot = false;
    public void InputUpdate()
    {
        temp.x = -Input.GetAxis("Mouse Y");
        temp.y = Input.GetAxis("Mouse X");
        temp.z = 0f;
        Camera.main.gameObject.transform.Rotate(temp * 100 * Time.deltaTime);
        
        temp1 = Camera.main.gameObject.transform.localEulerAngles;
        temp1.z = 0;
        Camera.main.gameObject.transform.localEulerAngles = temp1;
        shoot = false;
        if(Input.GetMouseButtonDown(0))
        {
            if(!EventSystem.current.IsPointerOverGameObject())
            {
           /* ray = Camera.main.ScreenPointToRay(new Vector3(0.5f,0.5f,0));
            if(Physics.Raycast(ray, out hit, 150))
            {
                if(hit.transform.tag != "UI")
                {
                    shoot = true;
                }
                //do the shoot at the middle of the screens
            }
            else
            {
                shoot = true;
            }
            
            if(shoot)
            {*/
            if(!GameManager.Instance.Paused)
                 ObjectPooler.Instance.GetObject(ObjectType.Bullet, 
                                    Camera.main.transform.position, 
                                    Camera.main.transform.rotation);
            
           // }   
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetRotation();
        }
    }
    
    void ResetRotation()
    {
        Camera.main.gameObject.transform.localEulerAngles = Camera.main.gameObject.transform.parent.transform.localEulerAngles;
    }
}