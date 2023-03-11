using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limbButton : MonoBehaviour
{
    public int limb;
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
        BodySwitchManager.changeLimb(limb);
        Debug.Log("Square clicked!");
    }
}
