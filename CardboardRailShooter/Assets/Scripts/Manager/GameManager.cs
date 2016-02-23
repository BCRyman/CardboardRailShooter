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
    
    private UIManager uiManager;
    public UIManager UIManager
    {
        get{return uiManager;}
    }
    
    private ScoreManager scoreManager;
    public ScoreManager ScoreManager
    {
        get{return scoreManager;}
    }
    [SerializeField]
    bool paused = false;
    public bool Paused
    {
        get{return paused;}
        set{paused = value;}
    }
    private void Awake()
    {
        Instance = this;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        inputManager = GetComponent<InputManager>();
        railManager = GetComponent<RailManager>();
        uiManager = GetComponent<UIManager>();
        scoreManager = GetComponent<ScoreManager>();
        
        //Debug
        scoreManager.CurrentScore = 0;
    }
    
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if(!paused)
        {
           
            railManager.RailUpdate();
        }
         inputManager.InputUpdate();
    }
    
   
}
