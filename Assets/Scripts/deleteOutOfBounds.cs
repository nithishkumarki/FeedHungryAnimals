using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class deleteOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound=50f;
    private float lowBound=-50f;
    private float sideBound=50f;
    private GameManager gameManager;
    void Start()
    {
        //In the Start method, we will setup the reference to the new variable
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        {
            //gameObject-current gameobject;
            // gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.z<lowBound)
        {
            //  Debug.Log("Missed an animal!!");
            // gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        if(transform.position.x>sideBound)
        {
            // gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x<-sideBound){
            Destroy(gameObject);
        }
    }
}
