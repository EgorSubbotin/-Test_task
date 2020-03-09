using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiedPlayer : MonoBehaviour
{
    public static bool DeathPlayer;
    public GameObject panelDeath;
    public Text score;
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
        yield return new WaitForSeconds(3f);       
        fadePanel.SetActive(false);
    }

    private void FixedUpdate()
    {
        score.text = $"{countScore}";

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
            GeneraterPoint.countPoint = 0;
            ControlPlayer.moveSpeed = 40;
        }        
    }
    void ShowScore()
    {
        myScore.text = countScore.ToString();
        GameController.instance.SetMyScore(countScore);
    }
}
