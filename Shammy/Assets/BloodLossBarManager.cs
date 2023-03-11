using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodLossBarManager : MonoBehaviour
{
    public static Image BloodLossMeter;
    public float maxBloodLoss;
    public static float BloodLoss = 0;

    // value should be between 0 to 1</param>
    public static void setBarValue(float value)
    {
        if (value > 0)
        {
            BloodLossMeter.fillAmount = value;
        }
        else
        {
            BloodLossMeter.fillAmount = 0;
        }
    }
 
    public static float GetBarValue()
    {
        return BloodLossMeter.fillAmount;
    }

    public static void addBloodLoss(float value)
    {
        BloodLoss += value;
    }

    private void Start()
    {
        BloodLossMeter = GetComponent<Image>();
    }

    void Update()
    {
        setBarValue(BloodLoss/maxBloodLoss);
    }
}
