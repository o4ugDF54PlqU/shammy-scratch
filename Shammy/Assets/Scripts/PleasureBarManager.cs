using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PleasureBarManager : MonoBehaviour
{
    public static Image PleasureMeter;
    public float maxPleasure;
    public float pleasureLossPerSecond;
    public static float pleasure = 50;

    // value should be between 0 to 1</param>
    public static void setBarValue(float value)
    {
        if (value > 0)
        {
            PleasureMeter.fillAmount = value;
        }
        else
        {
            PleasureMeter.fillAmount = 0;
        }
    }
 
    public static float GetBarValue()
    {
        return PleasureMeter.fillAmount;
    }

    public static void addPleasure(float value)
    {
        pleasure += value;
    }

    private void Start()
    {
        PleasureMeter = GetComponent<Image>();
    }

    void Update()
    {
        setBarValue(pleasure/maxPleasure);
    }

    void FixedUpdate()
    {
        pleasure -= pleasureLossPerSecond * Time.deltaTime;
    }
}
