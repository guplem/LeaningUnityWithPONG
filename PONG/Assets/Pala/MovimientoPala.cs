using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    [SerializeField] private KeyCode up;
    [SerializeField] private KeyCode down;
    private Transform trans;
    [SerializeField] private float velocity;
    [SerializeField] private float borderLimit;
    

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float direction = 0.0f;

        if (Input.GetKey(up))
            direction = direction+1;
        if (Input.GetKey(down))
            direction = direction-1;

        float movimiento = direction * Time.deltaTime * velocity;
        float posZ = trans.position.z + movimiento;

        if (posZ>borderLimit)
        {
            posZ = borderLimit;
        }
        else if(posZ<-borderLimit)
        {
            posZ = -borderLimit;
        }
        
        trans.position = new Vector3(trans.position.x, trans.position.y, posZ);

    }
}
