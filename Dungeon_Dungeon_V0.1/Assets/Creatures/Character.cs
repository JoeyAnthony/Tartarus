using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    protected List<Weapon> weapons = new List<Weapon>();
    protected Rigidbody charRigidbody;
    
    protected void CharacterInit()
    {
        charRigidbody = GetComponent<Rigidbody>(); 
    }

    // Use this for initialization
    public virtual void Start()
    {
    }

    // Update is called once per frame
    public virtual void Update()
    {
      
    }
}
