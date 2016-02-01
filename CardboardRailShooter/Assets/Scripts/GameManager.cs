using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager instance;
    public static GameManager Instance
    {
        get{
            return instance;
        }
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
    
    private InputManager inputManager;
    public InputManager InputManager
    {
        get{return inputManager;}
    }
    private void Awake()
    {
        Instance = this;
        Cursor.lockState = CursorLockMode.Locked;
        inputManager = GetComponent<InputManager>();
    }
    
    private void Update()
    {
        inputManager.Update();
    }
}
