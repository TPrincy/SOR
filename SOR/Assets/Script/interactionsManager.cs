using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Fungus;
using DialogueEditor;

public class interactionsManager : MonoBehaviour
{
    
    public questManager questManager;

    void Update()
    {

    }

    void Start()
    {
        //Ensures that when the gamestart the interact text is disabled from start
        questManager.InteractText.SetActive(false);
    }
    
    void OnTriggerEnter(Collider other)
    {
        //enables the interact text when the player enters the detection box of the interactable object
        questManager.InteractText.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
        if (CompareTag("Collect"))
        {
            questManager.isInRangeCollectable = true;
            print("collectable in range");
        }
        else if (CompareTag("Cleric"))
        {
            questManager.isInRangeNPC = true;
            print("NPC in range");
        }
    }

    void OnTriggerExit(Collider other)
    {
        questManager.isInRangeCollectable = false;
        questManager.isInRangeNPC = false;
        //disables the interact text when the player leaves the detection range of the object
        questManager.InteractText.SetActive(false);
    }


}
