using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
        MasterData md = new MasterData();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {   
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed);
        }

    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Exits"))
        {
            MasterData.count++;
            SceneManager.LoadScene("Dungeon Room");

        }
    }
}


