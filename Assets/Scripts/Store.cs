using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class Store : MonoBehaviour
{
    [SerializeField] Text GoldDisplay, CashDisplay;
    public int Gold = 0;
    public float Cash = 0;
    public int Goldperclick = 1;
    public int Goldperclick2 = 1;
    public int Goldperclick3 = 1;
    public int Goldperclick4 = 1;
    public int Goldperclick5 = 1;
    public int Goldperclick6 = 1;
    string path, Data;
    
    public float Cclick = 1;
    public float Cclick2 = 1;
    public float Cclick3 = 1;
    public float Cclick4 = 1;
    public float Cclick5 = 1;
    public float Cclick6 = 1;

    private bool buttom = true;
    public GameObject b1,b2, b3, b4, b5, b6;
    private int pressCount = 0;


    public void Start()
    {

        string data = File.ReadAllText(Application.persistentDataPath + "/Android/obb/com.DeafaultCompany.Tower/data.txt/data.txt");
        Debug.Log(data);
        // Create the text file if it doesn't exist
        if (!File.Exists(Application.persistentDataPath + "/Android/obb/com.DeafaultCompany.Tower/data.txt"))
        {
            using (StreamWriter sw = new StreamWriter(Application.persistentDataPath + "/Android/obb/com.DeafaultCompany.Tower/data.txt/data.txt"))
            {
                sw.WriteLine("0" + pressCount++);
                string dataPath = Application.persistentDataPath;
                string path = Application.persistentDataPath + "/data.json";
                string Data = System.IO.File.ReadAllText(path);
                Debug.Log(path);
            }
        }
    }




    public void clicked()
    {
        Gold += Goldperclick;
        Cash -= Cclick;
        GoldDisplay.text = "Gems: " + Gold;
        CashDisplay.text = "Cash:" + Cash;

      

    }

    public void clicked2()
    {
        Gold += Goldperclick2;
        Cash -= Cclick2;
        GoldDisplay.text = "Gems: " + Gold;
        CashDisplay.text = "Cash:" + Cash;

     
    }


    public void clicked3()
    {
        Gold += Goldperclick3;
        Cash -= Cclick3;
        GoldDisplay.text = "Gems: " + Gold;
        CashDisplay.text = "Cash:" + Cash;

     
    }


    public void clicked4()
    {
        Gold += Goldperclick4;
        Cash -= Cclick4;
        GoldDisplay.text = "Gems: " + Gold;
        CashDisplay.text = "Cash:" + Cash;

     
    }


    public void clicked5()
    {
        Gold += Goldperclick5;
        Cash -= Cclick5;
        GoldDisplay.text = "Gems: " + Gold;
        CashDisplay.text = "Cash:" + Cash;

       
    }


    public void clicked6()
    {
        Gold += Goldperclick6;
        Cash -= Cclick6;
        GoldDisplay.text = "Gems: " + Gold;
        CashDisplay.text = "Cash:" + Cash;

       
    }


    public void BDisable()
    {
        if (Cash <= 99)
        {
            b6.SetActive(false);
        }

        if (Cash <= 65)
        {
            b5.SetActive(false);
            b6.SetActive(false);
        }

        if (Cash <= 40)
        {
            b4.SetActive(false);
            b5.SetActive(false);
            b6.SetActive(false);
        }

        if (Cash <= 25)
        {
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
            b6.SetActive(false);
        }

        if (Cash <= 15)
        {
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
            b6.SetActive(false);
        }

        if (Cash <= 0)
        {
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
            b6.SetActive(false);
        }
    }

    public void OnButtonPress()
    {
        // Write the current time to a text file
        using (StreamWriter sw = new StreamWriter("data.json"))
        {

            pressCount++;
            Debug.Log("Writing to data.txt");
            sw.WriteLine(pressCount);
            sw.WriteLine(DateTime.Now);
            string dataPath = Application.persistentDataPath + "/Android/obb/com.DeafaultCompany.Tower/data.txt";
            Debug.Log(dataPath);
        }
    }

}
