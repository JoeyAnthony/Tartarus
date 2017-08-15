using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private Vector3 moveVec = new Vector3(0, 0, 0);
    public enum Keys{A, B, X, Y, LeftBumper, RightBumper, Back, Start, LeftClick, RightClick}
    private bool[] isPressed = new bool[20];

    // Use this for initialization
    void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        //Check A Button on Xbox Controller
        if (Input.GetButton("AButton"))
        {
            SetButtonTrue(Keys.A);
        }
        else if (!Input.GetButton("AButton"))
        {
            SetButtonFalse(Keys.A);
        }

        //Check X Button on Xbox Controller
        if (Input.GetButton("X"))
        {
            SetButtonTrue(Keys.X);
        }
        else if (!Input.GetButton("X"))
        {
            SetButtonFalse(Keys.X);
        }

        //Check Y Button on Xbox Controller
        if (Input.GetButton("Y"))
        {
            SetButtonTrue(Keys.Y);
        }
        else if (!Input.GetButton("Y"))
        {
            SetButtonFalse(Keys.Y);
        }

        //Check B Button on Xbox Controller
        if (Input.GetButton("B"))
        {
            SetButtonTrue(Keys.B); 
        }
        else if (!Input.GetButton("B"))
        {
            SetButtonFalse(Keys.B);
        }

        moveVec.x = Input.GetAxis("LeftAnalogX");
        //print(moveVec.x);
        moveVec.z = Input.GetAxis("LeftAnalogY");
        //print(moveVec.y);
    }

    public bool GetKey(Keys button)
    {
        return  isPressed[(int)button];
    }

    public Vector3 getLeftAxis()
    {
        return moveVec;
    }

    //sets button in isPressed to true
    private void SetButtonTrue(Keys button)
    {
        //Check A Button on Xbox Controller
        isPressed[(int)button] = true;

        //print(button.ToString());
        //print(isPressed[(int)button]);
    }

    //sets buttion in isPressed to false
    private void SetButtonFalse(Keys button)
    {
        isPressed[(int)button] = false;

        //print(button.ToString());
        //print(isPressed[(int)button]);
        
    }

}