using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColor : MonoBehaviour
{
    ParticleSystem.ColorOverLifetimeModule col;
    Color[] colors;

    void Start()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        col = ps.colorOverLifetime;
        colors = new Color[] { Color.red, Color.green, Color.yellow, Color.white, Color.cyan, Color.black, Color.blue, Color.gray};
    }
    
    void FixedUpdate()
    {
        if (Statistics.changeColor)
        {
            Statistics.changeColor = false;            
            int r = Random.Range(0, colors.Length);
            int g = Random.Range(0, colors.Length);
            
            col.color = new ParticleSystem.MinMaxGradient(colors[r], colors[g]);   
        }        
    }
}
