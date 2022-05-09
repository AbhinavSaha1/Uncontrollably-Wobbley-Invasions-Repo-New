using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakForceBar : MonoBehaviour
{
    [SerializeField]
    private int maxForce = 11;
    [SerializeField]
    private int minForce = 1;

    public int CurrentVal;
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    private void Start()
    {
        //SetInitialForce();
    }
    public void SetInitialForce()
    {
        CurrentVal = minForce;
        slider.maxValue = maxForce;
        slider.value = CurrentVal;

        gradient.Evaluate(1f);
        fill.color = gradient.Evaluate(1f);
    }

    public void SetForce(int force)
    {
        slider.value = force;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }


}
