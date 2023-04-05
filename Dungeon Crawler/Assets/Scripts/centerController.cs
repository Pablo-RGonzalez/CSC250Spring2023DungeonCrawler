using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class centerController : MonoBehaviour
{
    public GameObject thePlayer;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = thePlayer.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            thePlayer.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            print("I hit the center");
        }
    }
}

