﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    private GameObject MyEnemies;
    public Camera fpsCam;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyEnemies = GameObject.FindGameObjectWithTag("Wall");
        if (Input.GetButtonDown("Fire"))
        {
           
            Shoot();
        }
    }

    void Shoot ()
    {
     
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
            Debug.Log(hit.transform.name);



            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {

                
                target.TakeDamage(damage);
                
            }
         

            
        }
    }
}