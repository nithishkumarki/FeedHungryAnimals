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
    public float sideSpwanMinZ=-20f;
    public float sideSpwanMaxz=20f;
    public float sideSpwanx=20f;
    void Start()
    {
        //for time delay for prefabs
        InvokeRepeating("SpwanRandomAnimal",startDelay,endDelay);
        InvokeRepeating("SpwanLeftAnimal",startDelay,endDelay);
        InvokeRepeating("SpwanRightAnimal",startDelay,endDelay);
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
    //    var sideSpwanx=20f;

             int animalIndex=Random.Range(0,animalPrefabs.Length);// index for array of prefab
            //  Vector3 spwanloc=new Vector3(Random.Range(-spwanRangeX,spwanRangeX),0,spwanPositionZ);//loacation for prefab origin
             Vector3 spwanloc=new Vector3(Random.Range(-10,10),0,spwanPositionZ);//loacation for prefab origin

             Instantiate(animalPrefabs[animalIndex],spwanloc,animalPrefabs[animalIndex].transform.rotation);//Main
    }
    void SpwanLeftAnimal()
    {
        Vector3 rotation=new Vector3(0,90,0);
        int animalIndex=Random.Range(0,animalPrefabs.Length);
        Vector3 spwanleftloc=new Vector3(-sideSpwanx,0,Random.Range(sideSpwanMinZ,sideSpwanMaxz));
        Instantiate(animalPrefabs[animalIndex],spwanleftloc,Quaternion.Euler(rotation));
    }
     void SpwanRightAnimal()
    {
        Vector3 rotation=new Vector3(0,-90,0);
        int animalIndex=Random.Range(0,animalPrefabs.Length);

        Vector3 spwanleftloc=new Vector3(sideSpwanx,0,Random.Range(sideSpwanMinZ,sideSpwanMaxz));
        Instantiate(animalPrefabs[animalIndex],spwanleftloc,Quaternion.Euler(rotation));
    }
}
