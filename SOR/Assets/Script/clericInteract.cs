using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using System;

public class clericInteract : MonoBehaviour
{
    public questManager questManager;
    public interactionsManager interactionsManager;
    public PlayerMovement playerMovement;
    

    [SerializeField] public NPCConversation clericConversation;

    public void talk()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        //playerMovement.MyInput() = false;
        ConversationManager.Instance.StartConversation(clericConversation);
    }

    public void endConvo()
    {
        
    }
}
