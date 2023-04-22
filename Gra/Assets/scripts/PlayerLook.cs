using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerLook : MonoBehaviour 
{
    public Camera Camera;
    private float xRotation = 0f;

    public float sensivitity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        xRotation -= (mouseY * Time.deltaTime) * sensivitity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        Camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * sensivitity);
    }
}
