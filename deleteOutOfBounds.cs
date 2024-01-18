using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class deleteOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound=50f;
    private float lowBound=-20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        {
            //gameObject-current gameobject;
            Destroy(gameObject);
        }
        else if(transform.position.z<lowBound)
        {
            Debug.Log("Game Over!!");
            Destroy(gameObject);
        }
    }
}
