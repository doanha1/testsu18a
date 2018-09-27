using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qwertyuiopå : MonoBehaviour
{
    //int, float, double, bool, char, string
    public string sentence1;
    public string sentence2;
    public string sentence3;

    public float number;
    public float tri;
    public float angle;
    public float pieces;
    public string username;
    public float radius;
    public float count;

    public bool IsChecked;
    public int MyIntValue = 10;

    void Start()
    {
        Debug.Log("Doan Ha\nLBS Kreativa gymnasiet\nSU18a\nSpelutveckling");
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
        Uppgift8();
        Uppgift9();
        Uppgift10();
        Uppgift11();

        if (IsChecked == true)
        {
            Debug.Log("It's true.");
        }
        else
        {
            Debug.Log("Nej");
        }
    }


    void Uppgift1()
    {
        Debug.Log(string.Format("Svaret på (963 * 421) - (175463 / 87) är {0}", (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {
        Debug.Log(string.Format("Skriver in tre meningar sentence1 = {0} sentence2 {1} sentence3 {2}", sentence1, sentence2, sentence3));
    }

    void Uppgift3()
    {
        Debug.Log(string.Format("skriva in ett tal {0} upphöjt med 2 = {1} och kvadratroten ur number = {2}", number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }

    void Uppgift4()
    {
        Debug.Log(string.Format("Triangel med höjden 8 och basen {0} är {1}m^2", tri, (tri * 8 / 2)));
    }

    void Uppgift5()
    {
        Debug.Log(string.Format("Delar tårtan i delar med vinkel {0} så får man {1} bitar", angle, (360 / angle)));
        Debug.Log(string.Format("Delar tårtan i bitar {0} så får man vinkeln {1}", pieces, (360 / pieces)));
    }

    void Uppgift6()
    {
        Debug.Log(string.Format("skriv ditt namn " + "This is {0} Sparta", username));
    }

    void Uppgift7()
    {

    }

    void Uppgift8()
    {

    }

    void Uppgift9()
    {
        count += 1;

    }

    void Uppgift10()
    {

    }

    void Uppgift11()
    {

    }

    void Update()
    {
        // == lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >= större än eller lika med
        // < mindre än
        // > större än
        // && och (and)
        // || eller (or)

        if (MyIntValue == 10 || IsChecked == true)
        {
            print("Måndag");
        }
        else if (MyIntValue == 9)
        {
            print("Tisdag");
        }
        else
        {
        //    print("Okänt dag");
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Reload");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //0 1 2 3 4 5 6 7 8 9
            MyIntValue = Random.Range(0, 10);
            //0.032f, 10.000f
            print(Random.Range(0f, 10f));
            print("Lean left");
        }
    }

}
