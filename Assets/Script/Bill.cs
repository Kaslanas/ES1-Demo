using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Bill : MonoBehaviour
{

    [SerializeField]public bool inWindZone = false;
    public GameObject windZone;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        


    }

        void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Cible")){
                Destroy(collision.gameObject);}
        

        
    }

    void OnTriggerEnter(Collider coll)
    {

        if(coll.gameObject.CompareTag("SPEED"))
        {
            windZone = coll.gameObject;
            inWindZone = true;
        }

        if(coll.gameObject.CompareTag("Finish"))
        {
            print("Game Finsih");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }


    void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.CompareTag("SPEED"))
        {
            inWindZone = false;

        }
    }

    private void FixedUpdate(){

     if(inWindZone){


            rb.AddForce(windZone.GetComponent<ZonedeVitess>().direction * windZone.GetComponent<ZonedeVitess>().force);

        }

    }
}
