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
    public interactionsManager interactionsManager;
    public clericInteract clericInteract;

    [SerializeField] GameObject endzonecollider;

    private void Update()
    {
        if (!ConversationManager.Instance.IsConversationActive && clericInteract.isTalking)
        {
            clericInteract.endConvo();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(questManager.collectedBow && questManager.collectedScroll)
        {
            clericInteract.isTalking = true;
            
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            playerCam.enabled = false;
            playerMovement.enabled = false;
            ConversationManager.Instance.StartConversation(clericInteract.gaurdDialogueItemCollect);
            Destroy (endzonecollider);

        }
        else
        {
            clericInteract.isTalking = true;
            
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            playerCam.enabled = false;
            playerMovement.enabled = false;
            ConversationManager.Instance.StartConversation(clericInteract.gaurdConversaation);
        }
    }
}
