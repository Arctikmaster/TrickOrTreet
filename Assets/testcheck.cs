using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcheck : MonoBehaviour
{
    [SerializeField] private Animator textAnimator;
    [SerializeField] private GameObject textGO;
    [SerializeField] private GameObject reloadButton;

    public GameObject GOWordArray;
    public int taskArrayLength;

    private void Update()
    {
        taskArrayLength = GOWordArray.GetComponent<WordArray>().arrayLength;
    }
    public void ChangeNumber()
        {
       
        GOWordArray.GetComponent<WordArray>().lengthNumber = Random.Range(0, taskArrayLength);
        }

    public void ActivateText()
    {
        textGO.SetActive(true);
        textAnimator.SetTrigger("Show");
    }
    
    public void ActivateButton()
    {
        reloadButton.SetActive(true);
    }

}
