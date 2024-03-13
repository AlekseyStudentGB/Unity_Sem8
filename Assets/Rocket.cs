using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Transform mainCamera;
    public Transform start;
    public Transform finish;

    private Vector3 target;
    private bool check;
    private Vector3 vec;
    private float speed = 1;
    private float speedRocet; 

    void Start()
    {   check = true; 
        target = finish.position;  
        transform.position = start.position;
        transform.LookAt(target);
        
    }

    
    void Update()

    {   //transform.Rotate(2,0,0);
        vec.Set(transform.position.x,3,-6);
        mainCamera.position = vec;
        //transform.LookAt(target);
        speedRocet = Time.deltaTime * speed;
        if (speedRocet<0){ 
            speedRocet = 0;
        }
        if(check){
            transform.position = Vector3.MoveTowards(transform.position, target, speedRocet);
        }
        if (transform.position == target){
            if(target == finish.position){
                target = start.position;
                transform.LookAt(target);
            }else{
                target = finish.position;
                transform.LookAt(target);
            }

        }
    }
    public void UpSpeed(){
        speed += 0.5f;
    }
    public void DwnSpeed(){
        speed -= 0.5f;
        
    }
}
