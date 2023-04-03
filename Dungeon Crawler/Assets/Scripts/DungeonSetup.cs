using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;
    public bool northOn, southOn, eastOn, westOn;
    

    // Start is called before the first frame update 
    void Start()
    {
        
        if (northOn == true)
        {
            this.northExit.SetActive(true);
        }
        else if (northOn == false)
        {
            this.northExit.SetActive(false);
        }
        if (southOn == true)
        {
            this.southExit.SetActive(true);
        }
        else if (southOn == false)
        {
            this.southExit.SetActive(false);
        }
        if (eastOn == true)
        {
            this.eastExit.SetActive(true);
        }
        else if (eastOn == false)
        {
            this.eastExit.SetActive(false);
        }
        if (westOn == true)
        {
            this.westExit.SetActive(true);
        }
        else if (westOn == false)
        {
            this.westExit.SetActive(false);
        }


        //Homework answer should be in here
    }

    // Update is called once per frame
    void Update()
    {

    }
}
