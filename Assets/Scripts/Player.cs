using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public float jumpInput;
    public float speed=10f;
    public GameObject projectilePrefab;
    
    public float xRange=15f;
    public Transform projectileSpwanPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     HorizontalInput=Input.GetAxis("Horizontal") ;
     VerticalInput=Input.GetAxis("Vertical");

    //  hinput=Input.GetAxis("Hforward");
      if(Input.GetKeyDown(KeyCode.Z))
      {
        // transform.position=new Vector3(transform.position.x,transform.position.y+10,transform.position.z);
        transform.position=new Vector3(transform.position.x,transform.position.y+10,transform.position.z);
      }
     transform.Translate(Vector3.right *HorizontalInput*Time.deltaTime*speed); 
     transform.Translate(Vector3.forward*VerticalInput*Time.deltaTime*speed);

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
        //cookie - location,speed ....
        //Input-input manager,Getkeydown-instane click, Keycode for space bare
        //Instatntiate for creating a copy of object that we have

       //my method // Instantiate(projectilePrefab,new Vector3(transform.position.x,0,transform.position.z+2) ,projectilePrefab.transform.rotation);
        Instantiate(projectilePrefab,projectileSpwanPoint.position,projectilePrefab.transform.rotation);
      }
    }
}
