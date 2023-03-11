using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limbButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        BodySwitchManager.clearButtons();
        GetComponent<SpriteRenderer>().color = Color.green;
        Debug.Log("Square clicked!");
    }
}
