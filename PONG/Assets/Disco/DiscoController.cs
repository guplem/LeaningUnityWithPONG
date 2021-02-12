using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoController : MonoBehaviour
{
    private MovimientoDisco movimientoDisco;
    
    // Start is called before the first frame update
    void Awake()
    {
        movimientoDisco = GetComponent<MovimientoDisco>();
    }
    
    void Start()
    {
        movimientoDisco.StartNewRound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiscOnGoal()
    {
        movimientoDisco.StartNewRound();

    }
}
