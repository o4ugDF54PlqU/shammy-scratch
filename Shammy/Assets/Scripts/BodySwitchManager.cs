using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySwitchManager : MonoBehaviour
{
    public SpriteRenderer[] buttons;
    public GameObject[] backgrounds;
    private static SpriteRenderer[] buttonsStatic;
    private static GameObject[] backgroundsStatic;
    // Start is called before the first frame update
    void Start()
    {
        buttonsStatic = buttons;
        backgroundsStatic = backgrounds;
        changeButtonColor(buttonsStatic[0], Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMessageReceived(string message)
    {
        Debug.Log("Received message: " + message);
    }

    public static void changeLimb(int limb)
    {
        clear();
        changeButtonColor(buttonsStatic[limb], Color.green);
        backgroundsStatic[limb].SetActive(true);
    }

    public static void clear()
    {
        foreach (var button in buttonsStatic)
        {
            changeButtonColor(button, Color.red);
        }
        foreach (var background in backgroundsStatic)
        {
            background.SetActive(false);
        }
    }

    private static void changeButtonColor(SpriteRenderer button, Color newColor)
    {
        button.color = newColor;
        button.gameObject.GetComponent<limbButton>().currentColor = newColor;
    }
}
