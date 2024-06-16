using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Transform player;
    public Transform npc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.position, npc.position);   

        if(distance <= 2 && Input.GetKeyDown("e"))
        {
            //Pode adicionar o sistema de diálogo aqui 
            Debug.Log("Conversa");
        }
    }
}
