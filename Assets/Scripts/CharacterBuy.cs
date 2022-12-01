using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBuy : MonoBehaviour
{

    public Text gems;
    public int gemCount;
    int gemValue = 1000;

 

    public void subtractGems()
    {
        gemCount = 50;
        gems.text = "gems:" + gemValue;
    }
}
