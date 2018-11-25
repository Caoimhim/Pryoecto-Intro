﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    //Amount of players
    [Range(1, 2)]
    //Setting player number
    public int iPNumber = 1;
    //inventory
    private int iBombs = 1;

    //delcare the bomb boject
    public GameObject bombPrefab;

    //characterstics
    private Rigidbody rigidBody;
    private Transform playerTransform;
    private Animator animator;

    //initializing
    void Start()
    {
       rigidBody = GetComponent<Rigidbody> ();
       playerTransform = transform;
       
        //call animator here
    }
        void Update ()
    {
        UpdateMovement();
    }
    private void UpdateMovement ()
    {
        //animation

        if ( iPNumber == 1)
        {
            UpdateP1Movement();
        }
        else
        {
            UpdateP2Movement();
        }
    }


    private void UpdateP1Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * 4f * Time.deltaTime);
            //Need to also call animation here
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 4f * Time.deltaTime);
        }
        //Add drop bomb here

    }

    private void UpdateP2Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * 4f * Time.deltaTime);
            //Need to also call animation here
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 4f * Time.deltaTime);
        }
        //Add drop bomb here as well

    }



}



