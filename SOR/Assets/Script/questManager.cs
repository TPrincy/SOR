using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using Fungus;

public class questManager : MonoBehaviour
{
    [Header("Script References")]
    public interactionsManager interactionsManager;
    public clericInteract clericInteract;

    [Header("Bools")]
    public bool isInRangeScroll = false;
    public bool isInRangeBow = false;
    public bool isInRangeClericNPC = false;
    public bool isInRangeArcherNPC = false;
    public static bool collectedScroll = false;
    public static bool collectedBow = false;

    [Header("UI Objects")]
    public GameObject InteractText;
    public GameObject ScrollUI;
    public GameObject BowUI;

    [Header("Collectable Game Objects")]
    public GameObject Scroll;
    public GameObject Bow;

    [Header("Object Pos Tracker")]
    public Transform ScrollPos;
    public Transform BowPos;
    public Transform DumpPos;

    private void Update()
    {
        //collectable pick up check
        if (Input.GetKeyDown(KeyCode.E) && isInRangeScroll)
        {
            //gets rid of the interacable object
            ScrollPos.position = new Vector3(0,0,0);

            collectedScroll = true;

            //removes the text from the screen
            InteractText.SetActive(false);

            //adds to the hub that the player as collected an item
            ScrollUI.SetActive(true);


        }
        
        else if(Input.GetKeyDown(KeyCode.E) && isInRangeBow)
        {

            //deactivates object so it can't be interacted with
            BowPos.position = new Vector3(0, 0, 0);

            //removes the text from the screen
            InteractText.SetActive(false);

            //adds to the hub that the player as collected an item
            BowUI.SetActive(true);

            //changes the cashed npc convo to the next set
            collectedBow = true;
        }

        else if(Input.GetKeyDown(KeyCode.E) && isInRangeClericNPC && collectedScroll)
        {
            ScrollUI.SetActive(false);
            clericInteract.clecicItemConvo();
        }

        else if (Input.GetKeyDown(KeyCode.E) && isInRangeClericNPC && !collectedScroll)
        {
            clericInteract.clericTalk();
        }

        else if(Input.GetKeyDown(KeyCode.E) && isInRangeArcherNPC && !collectedBow)
        {
            clericInteract.archerTalk();
        }

        else if( Input.GetKeyDown(KeyCode.E) && isInRangeArcherNPC && collectedBow)
        {
            BowUI.SetActive(false);
            clericInteract.archerItemConvo();
        }
    }
}
