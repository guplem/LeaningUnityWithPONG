using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviuor : MonoBehaviour
{
    private Rigidbody rb; 
    [SerializeField] float goalLimit;
    private DiscoController discoController;
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        discoController = GetComponent<DiscoController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (rb.position.x>goalLimit || rb.position.x<-goalLimit)
        {
            Debug.Log("Goal detected by the disc.", this);

            int scorer = 0;
            if (rb.position.x < -goalLimit)
                scorer = 1;

            GameManager.instance.RegisterGoal(scorer);

        }

        
    }
}
