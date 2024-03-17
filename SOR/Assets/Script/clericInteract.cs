using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using System;

public class clericInteract : MonoBehaviour
{
    public questManager questManager;
    public interactionsManager interactionsManager;
    public PlayerCam playerCam;
    public Camera cam;

    [SerializeField] public NPCConversation clericConversation;

    public void talk()
    { 
        cam.enabled = false;
        ConversationManager.Instance.StartConversation(clericConversation);
    }
}
