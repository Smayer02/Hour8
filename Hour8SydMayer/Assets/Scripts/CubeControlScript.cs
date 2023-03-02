using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    private GameObject mainCamera;
    private bool mFlag = false;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //Code for moving based on arrow keys
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal > 0)
            transform.Translate(.05f, 0f, 0f);
        else if (hVal < 0)
            transform.Translate(-0.05f, 0f, 0f);
        
        if (vVal > 0)
            transform.Translate(0f, 0f, .05f);
        else if (vVal < 0)
            transform.Translate(0f, 0f, -0.05f);
        
        //Code for moving based on mouse movement
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        mxVal = Math.Abs(mxVal);
        myVal = Math.Abs(myVal);
        if (mxVal != 0 && mxVal >= myVal)
        //if (mxVal != 0)
            transform.Rotate(0f, .5f, 0f);
        if (myVal != 0 && myVal > mxVal)
        //if (myVal != 0)
           mainCamera.transform.Rotate(.5f, 0f, 0f);

        //Code for scaling based on M key
        if (Input.GetKeyDown(KeyCode.M)) {
            mFlag = !(mFlag);
            if (mFlag)
                transform.localScale = new Vector3(2f, 2f, 2f);
            else
                transform.localScale = new Vector3(1f, 1f, 1f);
        }
        
    }
}
