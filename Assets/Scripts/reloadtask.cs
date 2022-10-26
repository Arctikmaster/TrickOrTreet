using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadtask : MonoBehaviour
{
    [SerializeField] private Animator scrollAniator;
    [SerializeField] private Animator textAnimator;


    public void DeactivateScroll()
    {
        scrollAniator.SetTrigger("Reload");
    }

    public void DiscardText()
    {

        textAnimator.SetTrigger("undo");

    }
    public void InvokeingDeactivateScroll()
    {
        Invoke("DeactivateScroll", 1);
    }

}
