using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Levier : MonoBehaviour
{

[SerializeField] public GameObject Obstacle;
[SerializeField] public float Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentRotation = transform.rotation.eulerAngles.x;


        if(currentRotation > Target){

            Obstacle.SetActive(false);


        }


        
    }

}
