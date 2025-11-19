using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float sensX = 5.0f;
    [SerializeField] private float sensY = 5.0f;

    [SerializeField] private Transform look;
    [SerializeField] private Transform weapon;
    private float rotX;
    private float rotY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY * Time.deltaTime;

        rotY += mouseX;
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -90.0f, 90.0f);

        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
        look.rotation = Quaternion.Euler(-0, rotY, 0);

        if (weapon != null)
        {
            Vector3 offset = transform.forward * 0.5f + transform.right * 0.375f + transform.up * -0.2f;
            weapon.position = transform.position + offset;
            weapon.rotation = transform.rotation;
        }
    }
}
