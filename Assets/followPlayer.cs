using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Vector3 offset=new Vector3(-10.67f,2.26f,0.52f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=player.transform.position+offset;
    }
}
