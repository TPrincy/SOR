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
    public PlayerCam playerCam;

    bool isTalking = false;

    [SerializeField] public NPCConversation clericConversation;

    private void Update()
    {
        if (!ConversationManager.Instance.IsConversationActive && isTalking)
        {
            endConvo();
        }
    }

    public void talk()
    {
        isTalking = true;

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        playerCam.enabled = false;
        playerMovement.enabled = false;
        ConversationManager.Instance.StartConversation(clericConversation);
    }

    public void endConvo()
    {
        isTalking = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerCam.enabled = true;
        playerMovement.enabled = true;
    }
}
