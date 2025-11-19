using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponIdleMovement : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 45.0f;
    [SerializeField] private float bobDistance = 0.1f;
    [SerializeField] private float bobSpeed = 3.0f;

    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(startRot.eulerAngles.x, transform.eulerAngles.y + (rotSpeed * Time.deltaTime), startRot.eulerAngles.z);

        float newPos = startPos.y + Mathf.Sin(Time.time * bobSpeed) * bobDistance;
        transform.position = new Vector3(transform.position.x, newPos, startPos.z);
    }
}
