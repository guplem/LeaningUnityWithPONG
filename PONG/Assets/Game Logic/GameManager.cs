using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private DiscoController discoController;
    public int puntuacionleft { get; private set; }
    public int puntuacionright { get; private set; }

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogWarning("More than one GameManager has been created!", this);
    }

    public void RegisterGoal(int scorer)
    {
        if (scorer == 0)
            puntuacionleft += 1;
        else if (scorer == 1)
            puntuacionright += 1;

        discoController.DiscOnGoal();
        
        Debug.Log("Registered goal!  Current score: " + puntuacionleft + " - " + puntuacionright, this);

        UIManager.instance.UpdateScore();
    }

}
