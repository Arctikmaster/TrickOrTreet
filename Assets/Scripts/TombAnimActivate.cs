using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombAnimActivate : MonoBehaviour
{
    [SerializeField] private Animator thisAnimator;

    private void Start()
    {
        
    }

    public void Activateanim()
    {
        thisAnimator.SetTrigger("tapped");
    }

}
