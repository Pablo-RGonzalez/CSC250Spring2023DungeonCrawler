using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    private bool isMoving;
    public GameObject thePlayer;
    public Vector3 targetPosition = Vector3.zero;
    public bool hasEntered = false;
    public bool SceneLoaded;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        MasterData md = new MasterData();
        this.isMoving = false;
        this.hasEntered = true;
        this.SceneLoaded = false;
        print(MasterData.whereDidIComeFrom);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.isMoving == false)
        {   
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Exits") && this.hasEntered == true)
        {
            if(other.gameObject == this.northExit && this.hasEntered == false)
            {
                MasterData.whereDidIComeFrom = "north";
                SceneManager.LoadScene("GoingNorthExitingFromSouthScene");
                this.hasEntered = false;
            }
            else if (other.gameObject == this.southExit && this.hasEntered == false)
            {
                MasterData.whereDidIComeFrom = "south";
                SceneManager.LoadScene("GoingSouthExitingFromNorthScene");
                this.hasEntered = false;
            }
            else if (other.gameObject == this.eastExit && this.hasEntered == false)
            {
                MasterData.whereDidIComeFrom = "east";
                SceneManager.LoadScene("GoingEastExitingFromWestScene");
                this.hasEntered = false;
            }
            else if (other.gameObject == this.westExit && this.hasEntered == false)
            {
                MasterData.whereDidIComeFrom = "west";
                SceneManager.LoadScene("GoingWestExitingFromEastScene");
                this.hasEntered = false;
            }

             // Loads new scene 

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.hasEntered = false;
        }

            if (other.gameObject == this.northExit)
            {
                SceneManager.LoadScene("GoingNorthExitingFromSouthScene");
                this.hasEntered = false;
            }
            if (other.gameObject == this.southExit)
            {
                SceneManager.LoadScene("GoingSouthExitingFromNorthScene");
                this.hasEntered = false;
            }
            if (other.gameObject == this.eastExit)
            {
                SceneManager.LoadScene("GoingEastExitingFromWestScene");
                this.hasEntered = false;
            }
            if (other.gameObject == this.westExit)
            {
                SceneManager.LoadScene("GoingWestExitingFromEastScene");
                this.hasEntered = false;
            }
      
    }
}
