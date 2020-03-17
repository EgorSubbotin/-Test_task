using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiedPlayer : MonoBehaviour
{
    public static bool DeathPlayer = true;
    public GameObject panelDeath;
    
    public GameObject panelPlay;
    public static int countScore;
    public Text myScore;

    [SerializeField]
    private GameObject fadePanel;
    [SerializeField]
    private Animator fadeAnim;

    private void Start()
    {
        StartCoroutine(PlayDiedRestart());
    }

    IEnumerator PlayDiedRestart()
    {
        fadePanel.SetActive(true);
        fadeAnim.Play("FageroOUT");
        yield return new WaitForSeconds(4f);
        DeathPlayer = false;
        fadePanel.SetActive(false);
    }    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Primitive")
        {
            panelPlay.SetActive(false);
            ShowScore();
            DeathPlayer = true;
            Time.timeScale = 0f;
            panelDeath.SetActive(true);
            countScore = 0;
            ControlPlayer.moveSpeed = 25;
        }
    }
    void ShowScore()
    {
        myScore.text = countScore.ToString();
        GameController.instance.SetMyScore(countScore);
    }
}
