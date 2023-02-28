using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void getRed(){
         GetComponent<Renderer>().material.color = Color.red; 
    }
    public void getGreen(){
        GetComponent<Renderer>().material.color = Color.green; 
    }
    public void getBlue(){
        GetComponent<Renderer>().material.color = Color.blue; 
    }
}