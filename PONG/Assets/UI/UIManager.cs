using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private TextMeshProUGUI textScoreLeft;
    [SerializeField] private TextMeshProUGUI textScoreRight;
    
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else 
            Debug.LogWarning("More than one UIManager has been created!", this);
    }

    private void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        textScoreLeft.text = GameManager.instance.puntuacionleft.ToString();
        textScoreRight.text = GameManager.instance.puntuacionright.ToString();
    }
}
