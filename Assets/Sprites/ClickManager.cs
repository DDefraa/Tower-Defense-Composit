using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(click_st);
        //Debug.Log(click_dt);
    }

    public void OnClick()
    {

         ObjectCreator.click_st = true;
    }

    public void OnClick1()
    {
        ObjectCreator.click_dt = true;
    }

    public void OnClick2()
    {
        ObjectCreator.click_bf = true;
    }

}
