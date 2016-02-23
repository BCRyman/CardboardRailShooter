using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour  {

	private int currentScore;
    public int CurrentScore
    {
        get{return currentScore;}
        set{
            currentScore = value;
            GameManager.Instance.UIManager.UpdateScoreText(currentScore);
            }
    }
    
}
