using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gameManager;
    Boolean livecheck;
    void Start()
    {
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
         gameManager.AddLives(-1);
          other.GetComponent<AnimalHunger>().FeedAnimal(1);//for sliderbar

         //this destory other.gameobject destrys our player do as so if live==0 Destroy player
        //  Destroy(other.gameObject);
        //  Destroy(gameObject);
        /*if(live==0)
        {
           Destroy(gameObject);
        }*/
        livecheck=gameManager.check();
        if(livecheck==false)
        {
            Destroy(other.gameObject); //check method in gameManager returns false when live is 0
          Debug.Log("GameOver!!");
        }


        }
        else if(other.CompareTag("Animal"))
        {
        //   gameManager.AddScore(5);
        other.GetComponent<AnimalHunger>().FeedAnimal(1);
         Destroy(gameObject);//problem
        //  Destroy(other.gameObject);
        }
       
    }
}
