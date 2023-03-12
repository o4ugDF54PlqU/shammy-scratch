using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itchySpot : MonoBehaviour
{
    public int pleasurePerSecond;
    public int bloodLossPerSecond;
    float itchiness;
    bool isItchy;
    bool viewing;
    private bool scratching = false;
    // Start is called before the first frame update
    void Start()
    {
        viewing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!isItchy)
        {
            return;
        }

        if (viewing && scratching)
        {
            BloodLossBarManager.addBloodLoss(bloodLossPerSecond * Time.deltaTime);
            itchiness -= Time.deltaTime;
            //Debug.Log(itchiness);

            if (0 >= itchiness)
            {
                Debug.Log("set not itchy");
                isItchy = false;
                GetComponent<SpriteRenderer>().enabled = false;
                BodySwitchManager.instance.SetLastScratchedSpot(this);
                return;
            }
        }
        else
        {
            PleasureBarManager.addPleasure(-0.25f * pleasurePerSecond * Time.deltaTime);
        }
    }

    public void SetItchy()
    {
        isItchy = true;
        itchiness = 4.0f;
        GetComponent<SpriteRenderer>().enabled = viewing;
    }

    public void ActivateScratch(bool willView)
    {
        scratching = false;
        viewing = willView;
        GetComponent<SpriteRenderer>().enabled = isItchy && willView;
    }

    private void OnMouseEnter()
    {
        if (!viewing || !isItchy)
        {
            return;
        }
        PleasureBarManager.addPleasure(pleasurePerSecond);
        scratching = true;
        Debug.Log("scratchy scratch");
    }

    private void OnMouseExit()
    {
        scratching = false;
    }
}
