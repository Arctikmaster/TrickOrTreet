using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerenterscroll : MonoBehaviour
{

    [SerializeField] private GameObject OpendScroll;
    [SerializeField] private GameObject text;

    public GameObject GOWordArray;
    public int taskArrayLength;

    private void OnTriggerEnter(Collider other)
    {

        if (OpendScroll)
        {
            taskArrayLength = GOWordArray.GetComponent<WordArray>().arrayLength;
            GOWordArray.GetComponent<WordArray>().lengthNumber = Random.Range(0, taskArrayLength);
        }
        if (OpendScroll)
        {
            OpendScroll.SetActive(false);
            text.SetActive(false);


        }
    }

}
