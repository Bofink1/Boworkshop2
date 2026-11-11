using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class NpcInteract : MonoBehaviour
{

    public PlayerInput Pinput;
    [Header("Proximity Alert")]
    public GameObject Proximity;

    [Header("Default Dialogue")]
    public DialogueNode startingDialogue;
    public GameObject DestroyOnClose;
    public GameObject LoadOnClose;
    private DialogueUI dialog;


   

    private void OnEnable()
    {
        Pinput.actions["Interact"].performed += OnInteract;
    }

    private void OnDisable()
    {
        Pinput.actions["Interact"].performed += OnInteract;
    }

    private bool playerInRange = false;

    private void Start()
    {

        Proximity.SetActive(false);
        dialog = FindFirstObjectByType<DialogueUI>();
    }

    private void Update()
    {
       /* if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("hello");
            DialogueNode dialogueToShow = GetAppropriateDialogue();
            dialog.StartDialogue(dialogueToShow);
        } */
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (playerInRange)
        {
            Debug.Log("hello");
            DialogueUI.ToBeDestroyed = DestroyOnClose;
            DialogueUI.ToBeLoaded = LoadOnClose;
            DialogueNode dialogueToShow = GetAppropriateDialogue();
            dialog.StartDialogue(dialogueToShow);
        } 
    }

  
    private DialogueNode GetAppropriateDialogue()
    {
      
            return startingDialogue;
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            playerInRange = true;
            Proximity.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            playerInRange = false;
            Proximity.SetActive(false);

        }
    }
}