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
    
    private RailManager railManager;
    public RailManager RailManager
    {
        get {return railManager;}
    }
    
    private void Awake()
    {
        Instance = this;
       // Cursor.lockState = CursorLockMode.Locked;
        inputManager = GetComponent<InputManager>();
        railManager = GetComponent<RailManager>();
    }
    
    private void Update()
    {
        inputManager.InputUpdate();
        railManager.RailUpdate();
    }
}
