using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

    Controller control;
    
    private Player() : base()
    {
        
    }

    // Use this for initialization
    public override void Start ()
    {
        CharacterInit(); //this needs to be called first
        control = GetComponent<Controller>();
        //add first weapon
    }

    // Update is called once per frame
    public override void Update()
    {
        Vector3 v = control.getLeftAxis();
        v *= 50;
        charRigidbody.AddForce(v);
        
        
    }
}
