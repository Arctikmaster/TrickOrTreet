using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapBounce : MonoBehaviour
{
    [SerializeField] private Rigidbody pumpkinCap;
    [SerializeField] private Collider pumpkinSwitch;

    private void Awake()
    {
        pumpkinCap = GetComponent<Rigidbody>();
        pumpkinSwitch = GetComponent<Collider>();
    }

    public void PressOnPumpkin()
    {
        pumpkinCap.AddForce(50, 500, 0);
        pumpkinCap.useGravity = true;
        pumpkinSwitch.enabled = true;
       
    }




}
