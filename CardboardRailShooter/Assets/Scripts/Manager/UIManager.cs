using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    [SerializeField]
    GameObject pauseMenu;
    public void PauseGame()
    {
        GameManager.Instance.Paused = true;
        pauseMenu.SetActive(true);
    }
    
    public void UnPauseGame()
    {
        GameManager.Instance.Paused = false;  
        pauseMenu.SetActive(false); 
    }
    
    public void EndScreen(bool victory)
    {
        if(victory)
        {
            //show EndOfLevel with results
        }
        else
        {
            //show game over screen
        }
    }
}
