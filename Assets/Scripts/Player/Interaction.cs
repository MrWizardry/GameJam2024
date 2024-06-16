using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject interfaceObject;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (interfaceObject != null)
        {
            interfaceObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            if (interfaceObject != null)
            {
                Debug.Log("Entrou");
                interfaceObject.SetActive(true);
            }
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
        }
    }
}
