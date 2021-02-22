using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public DiscoController discoController;
    public int puntuacionleft { get; private set; }
    public int puntuacionright { get; private set; }

    public static GameManager instance;
    [SerializeField] private GameObject mainMenu; 
    [SerializeField] private GameObject gameplayElements; 

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogWarning("More than one GameManager has been created!", this);
    }

    public void StartGame()
    {
        Debug.Log("START");
        mainMenu.SetActive(false);
        Instantiate(gameplayElements, Vector3.zero, Quaternion.identity);
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
