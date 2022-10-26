using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeractivate : MonoBehaviour
{
    [SerializeField] private GameObject scroll;
    [SerializeField] private GameObject opendScroll;

    private void OnTriggerEnter(Collider other)
    {
        if (scroll)
        {

            
            

        }
        if (scroll)
        {
            Invoke("unactivatescroll", 1);
        }
    }

    public void ActivateOpenScroll()
    {
        opendScroll.SetActive(true);
    }
    public void unactivatescroll()
    {
        scroll.SetActive(false);
    }







}
