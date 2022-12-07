using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public List<GameObject> characters;

    void Start()
    {
        //Initialize character list
    }

    public void Characterselect(int index)
    {
        if (PlayerPrefs.GetInt("Character" + index) == 1)
        {
            //Disable all other characters
            foreach (GameObject character in characters)
            {
                character.SetActive(false);
            }
            //Enable selected character
            characters[index].SetActive(true);
        }
        else
        {
            //Display message that character is not available
        }
    }
}
