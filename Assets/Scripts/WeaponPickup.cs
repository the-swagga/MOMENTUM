using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private GameObject weapon;
    [SerializeField] private GameObject pickup;

    private void Start()
    {
        weapon.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            weapon.SetActive(true);
            pickup.SetActive(false);
        }
    }
}
