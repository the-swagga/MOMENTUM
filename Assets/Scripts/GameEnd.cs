using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerMovement pm;

    [SerializeField] private UIManager uiManager;

    private void Start()
    {
        pm = player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (pm != null && other.CompareTag("Player"))
            uiManager.GameEnd();
            pm.GameEnd();
    }
}
