using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDisco : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float initialForce;
    private Vector3 initialPosition;

    void Awake()
    {
        Debug.Log("Hello World!");
        rb = gameObject.GetComponent<Rigidbody>();
        initialPosition = rb.position;
    }

    public void StartNewRound()
    {
        rb.position = initialPosition;
        rb.velocity = Vector3.zero; // new Vector3(0,0,0)
        float xDir;
        if (Random.Range(0f, 1f) < 0.5f)
            xDir = -1;
        else
            xDir = 1;
        Vector3 randomDir = new Vector3(xDir,0, Random.Range(-1f, 1f)).normalized;
        rb.AddForce(randomDir*initialForce);
    }


}
