using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BloodLossBarManager : MonoBehaviour
{
    public static Image BloodLossMeter;
    public float maxBloodLoss;
    public static int bloodLossPerSecond;
    public static float maxBloodLossStatic;
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

        if (BloodLoss >= maxBloodLossStatic)
        {
            SceneManager.LoadScene("Victory");
        }
    }

    private void Start()
    {
        bloodLossPerSecond = 4;
        BloodLossMeter = GetComponent<Image>();
        maxBloodLossStatic = maxBloodLoss;
        BloodLoss = 0;
    }

    void Update()
    {
        //addBloodLoss(-3f * BloodLossBarManager.bloodLossPerSecond * Time.deltaTime);
        setBarValue(BloodLoss/maxBloodLoss);
    }
}
