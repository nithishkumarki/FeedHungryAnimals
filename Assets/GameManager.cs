using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score=0;
    public int live=3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddLives(int value)
    {
        live+=value;
        if(live<0)
        {
            Debug.Log("GameOver");
            live=0;
        }
        Debug.Log("Live="+live);

    }
    public void AddScore(int value)
    {
        score+=value;
        Debug.Log("Score="+score);
    }
    public Boolean check()
    {
        if(live<=0)
        {
            return false;
        }
        else{
            return true;
        }
    }
}
