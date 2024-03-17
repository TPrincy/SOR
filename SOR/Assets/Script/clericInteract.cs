using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using System;

public class clericInteract : MonoBehaviour
{
    public questManager questManager;
    public interactionsManager interactionsManager;
    public Camera cam;
    

    [SerializeField] public NPCConversation clericConversation;

    public void talk()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        ConversationManager.Instance.StartConversation(clericConversation);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
}
