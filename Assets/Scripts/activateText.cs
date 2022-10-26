using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateText : MonoBehaviour
{
    [SerializeField] private GameObject textGO;
    [SerializeField] private GameObject reloadGame;

    private void Awake()
    {
        Invoke("ActivateText", 0.8f);
    }

    private void Start()
    {
     
        Invoke("ActivateReload", 4f);
    }

    public void ActivateText()
    {

        textGO.SetActive(true);

    }

    public void ActivateReload()
    {
        reloadGame.SetActive(true);
    }

}
