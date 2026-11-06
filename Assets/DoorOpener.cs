using System;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Door.SetActive(false);
    }
}
