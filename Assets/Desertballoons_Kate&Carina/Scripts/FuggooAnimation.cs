using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuggooController : MonoBehaviour
{
    public Animation Fuggo;

    private void OnCollisionEnter(Collision col)
    {
        col.gameObject.GetComponent<FuggooController>().PlayAnimation();
    }

    public void PlayAnimation()
    {
        a_Fuggoo.Action.Play();
    }
}