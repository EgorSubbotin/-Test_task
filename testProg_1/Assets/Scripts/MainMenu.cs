using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text myScore;

    void Start()
    {        
        if (!DiedPlayer.DeathPlayer)
        {
            myScore.text = "0";
        }
        else if (DiedPlayer.DeathPlayer)
        {
            myScore.text = GameController.instance.GetMyScore().ToString();
        }                
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");        
        
    }
    public void QuittButton()
    {
        Application.Quit();
    }
}
