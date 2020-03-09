using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    
    const string MY_SCORE = "MyScore";
    void Start()
    {
        InstantianVeriables();
        if (instance != null)
        {
            Destroy(gameObject);            
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }            
    }
    public void InstantianVeriables()
    {
        if (!PlayerPrefs.HasKey("InstantianVeriables"))
        {            
            PlayerPrefs.SetInt(MY_SCORE, 0);
            PlayerPrefs.SetInt("InstantianVeriables", 0);
        }
    }
    
    public void SetMyScore(int myScore) { PlayerPrefs.SetInt(MY_SCORE, myScore); }
    public int GetMyScore() { return PlayerPrefs.GetInt(MY_SCORE); }
}
