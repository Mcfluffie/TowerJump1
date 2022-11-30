using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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

    public float Cclick = 1;
    public float Cclick2 = 1;
    public float Cclick3 = 1;
    public float Cclick4 = 1;
    public float Cclick5 = 1;
    public float Cclick6 = 1;

    private bool buttom = true;
    public GameObject b1,b2, b3, b4, b5, b6;


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



}
