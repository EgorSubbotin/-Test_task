using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{    
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        Statistics.ResetToZero();
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
        Statistics.ResetToZero();
    }
}
