using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBuy : MonoBehaviour
{
    public int currency;
    public List<GameObject> characters;
    public List<int> characterPrices;
    public Text Gems;

    void Start()
    {
        //Initialize shop with character list and their prices
    }

    public void BuyCharacter(int index)
    {
        if (currency >= characterPrices[index])
        {
            currency -= characterPrices[index];
            Gems.text = "Gems:" + currency;
            GameObject character = Instantiate(characters[index]);
            //Add character to player's inventory or enable character selection in game
        }
        else
        {
            //Display message that player does not have enough currency
        }
    }



}
