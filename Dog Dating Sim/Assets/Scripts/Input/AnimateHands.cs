using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHands : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public InputActionProperty GripAction;
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        float indTrigVal = pinchAction.action.ReadValue<float>();
        if (indTrigVal > 0)
            Debug.Log($"index trigger button: {indTrigVal}");
        anim.SetFloat("Trigger", indTrigVal);
        

        float gripTrigVal = GripAction.action.ReadValue<float>();
        anim.SetFloat("Grip", gripTrigVal);
        if(gripTrigVal > 0)
        Debug.Log($"Grip trigger button: {gripTrigVal}");


    }
}
