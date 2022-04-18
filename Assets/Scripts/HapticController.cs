using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class HapticController : MonoBehaviour
{
    public static HapticController instance;
    public XRBaseController leftController, rightController;
    public float amplitude = 0.5f;
    public float duration = 5f;


    private void Awake()
    {
        instance = this;
    }
    public void SendHaptic()
    {
        leftController.SendHapticImpulse(amplitude, duration);
        rightController.SendHapticImpulse(amplitude, duration);
    }
}
