using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class questManager : MonoBehaviour
{
    public interactionsManager interactionsManager;
    public clericInteract clericInteract;
    
    public bool isInRangeCollectable = false;
    public bool isInRangeClericNPC = false;
    public bool isInRangeArcherNPC = false;

    public GameObject InteractText;
    public GameObject ScrollUI;

    private void Update()
    {
        //collectable pick up check
        if (Input.GetKeyDown(KeyCode.E) && isInRangeCollectable)
        {
            Destroy(gameObject);
            InteractText.SetActive(false);
            ScrollUI.SetActive(true);
            //add in a bool to say that the player has the item
        }
        else if(Input.GetKeyDown(KeyCode.E) && isInRangeClericNPC)
        {
            clericInteract.talk();
        }
    }
}
