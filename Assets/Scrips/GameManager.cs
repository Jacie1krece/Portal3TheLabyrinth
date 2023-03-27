using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int timeToEnd;
    bool gamePaused = false;
    bool endGame = false;
    bool win = false;
    public int points = 0;
    public int redKey = 0;
    public int greenKey = 0;
    public int blueKey = 0;
    public static GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        if (timeToEnd <= 0)
        {
            timeToEnd = 180;
        }

        InvokeRepeating("Timer", 2, 1);
    }
    void Timer()
    {
        timeToEnd--;
        Debug.Log($"Time: {timeToEnd}s. Points: {points}");
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
    }
    public void AddTime(int timeToAdd)
    {
        timeToEnd += timeToAdd;
    }
    public void FreezeTime(int freeze)
    {
        CancelInvoke("Timer");
        InvokeRepeating("Timer", freeze, 1);
    }
    public void AddKey(KeyColor color)
    {
        if(color == KeyColor.Red)
        {
            redKey++;
        }
        if(color == KeyColor.Green)
        {
            greenKey++;
        }
        if(color == KeyColor.Blue)
        {
            blueKey++;
        }
    }
}
