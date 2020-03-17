using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text lengthWayText;
    public Text percentText;
    public Text timeText;
    public Text numberObjectsText;

    public Transform planet;
    public Transform player;
    Vector3 lastPosPlayer;
    float angleWay;
    public static float lengthWay;
    static float lengthWay1;
    const float Pi = 3.14f;

    public static float time = 0f;
    float timer;

    float anglePercent;
    public static float percentWay;

    public static float countCreateOblect;

    public static float numberObjects;
    public static bool changeColor;
    void Start()
    {        
        lengthWayText.text = $"{lengthWay} m";
        percentText.text = $"{percentWay} %";
        timeText.text = $"{time} c";
    }
    
    void Update()
    {
        if (!DiedPlayer.DeathPlayer)
        {
            lengthWayText.text = $"{lengthWay} m";
            percentText.text = $"{percentWay} %";
            timeText.text = $"{time} c";
            numberObjectsText.text = $"{numberObjects}";

            angleWay = Vector3.Angle(lastPosPlayer, player.up);
            float lengthStep = (Pi * 201f * angleWay) / 180;
            lengthWay1 += lengthStep;
            lengthWay = Mathf.Round(lengthWay1);
            lastPosPlayer = player.up;
            
            if (!CheckDown.down)
            {
                anglePercent = Vector3.SignedAngle(planet.up, player.up, Vector3.up);
            }
            if (CheckDown.down)
            {
                anglePercent = 360f - Vector3.SignedAngle(planet.up, player.up, Vector3.up);
            }
            percentWay = Mathf.Round(anglePercent / 3.6f);

            timer += Time.deltaTime;
            time = Mathf.Round(timer);
             
            if (CheckDown.start)
            {
                changeColor = true;
                CheckDown.start = false;
                lengthWay = 0f;
                lengthWay1 = 0;
                percentWay = 0f;
                CheckDown.down = false;
                time = 0;
                timer = 0;
                CheckDown.countDown = 1f;
                numberObjects = 0f;
            }                
        }
    }
    public static void ResetToZero()
    {
        lengthWay = 0f;
        percentWay = 0f;
        lengthWay1 = 0f;
        CheckDown.down = false;
        time = 0f;
        CheckDown.countDown = 1f;

        numberObjects = 0f;        
    }
}
