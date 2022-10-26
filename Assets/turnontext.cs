using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnontext : MonoBehaviour
{
    [SerializeField] private GameObject OpendScroll;
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject activatebutton;
    

    private void OnTriggerEnter(Collider other)
    {
        if (OpendScroll)
        {
            text.SetActive(true);
            activatebutton.SetActive(true);
        }
    }
}
