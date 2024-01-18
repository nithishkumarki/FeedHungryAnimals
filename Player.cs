using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HorizontalInput;
    public float speed=10f;
    public GameObject projectilePrefab;
    
    public float xRange=15.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     HorizontalInput=Input.GetAxis("Horizontal") ;
    //  hinput=Input.GetAxis("Hforward");
     transform.Translate(Vector3.right *HorizontalInput*Time.deltaTime*speed); 

      if(transform.position.x<-xRange)
      {
        transform.position=new Vector3(-xRange,transform.position.y,transform.position.z);
      }
      else if(transform.position.x>xRange)
      {
        transform.position=new Vector3(xRange,transform.position.y,transform.position.z);
      }   

      if(Input.GetKeyDown(KeyCode.Space))
      {
        //Input-input manager,Getkeydown-instane click, Keycode for space bare
        //Instatntiate for creating a copy of object that we have

        Instantiate(projectilePrefab,new Vector3(transform.position.x,0,transform.position.z+2) ,transform.rotation);
      }
    }
}
