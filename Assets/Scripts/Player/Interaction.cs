using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject interfaceObject;
    public GameObject uiConv;
    private GameObject player;
    private Movement movement;
    private bool isPlayerInTrigger = false; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (interfaceObject != null)
        {
            interfaceObject.SetActive(false);
        }
        if (uiConv != null)
        {
            uiConv.SetActive(false); 
        }
        if(player != null)
        {
            movement = player.GetComponent<Movement>();
        }
    }

    void Update()
    {

        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            if (uiConv != null)
            {
                uiConv.SetActive(true);
            }
            if(movement != null)
            {
                movement.enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            if (interfaceObject != null)
            {
                interfaceObject.SetActive(true);
            }
            isPlayerInTrigger = true; 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            if (interfaceObject != null)
            {
                interfaceObject.SetActive(false);
            }
            isPlayerInTrigger = false; 
        }
    }
}
