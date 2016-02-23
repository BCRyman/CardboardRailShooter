using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {

    [SerializeField]
    GameObject pauseMenu;
    
    [SerializeField]
    Text scoreText;
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
    
    public void UpdateScoreText(int val)
    {
        scoreText.text = "Score: "+val;
    }
}
