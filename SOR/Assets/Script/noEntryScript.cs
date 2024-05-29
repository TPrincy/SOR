using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using System;

public class noEntryScript : MonoBehaviour
{

    [Header("Script References")] 
    public PlayerMovement playerMovement;
    public PlayerCam playerCam;

    [SerializeField] public NPCConversation guardConversation;

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
