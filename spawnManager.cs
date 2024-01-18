using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    // manages all the spwan(animals,their origin location,...)
    // Start is called before the first frame update
    public GameObject [] animalPrefabs;
    public float spwanRangeX=15f;
    public float spwanPositionZ=20f;
    public float startDelay=3f;
    public float endDelay=1.5f;
    void Start()
    {
        //for time delay for prefabs
        InvokeRepeating("SpwanRandomAnimal",startDelay,endDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
        // if(Input.GetKeyDown(KeyCode.S))
        // {
        //      SpwanRandomAnimal();
        // }
    }
    void SpwanRandomAnimal()
    {

             int animalIndex=Random.Range(0,animalPrefabs.Length);// index for array of prefab
             Vector3 spwanloc=new Vector3(Random.Range(-spwanRangeX,spwanRangeX),0,spwanPositionZ);//loacation for prefab origin

             Instantiate(animalPrefabs[animalIndex],spwanloc,animalPrefabs[animalIndex].transform.rotation);//Main
    }
}
