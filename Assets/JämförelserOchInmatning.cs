using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JämförelserOchInmatning : MonoBehaviour
{
    public int userValue = 0;
    public int tärning = 10;

    void Start()
    {

    }

    void Update()
    {
        //Uppgift1
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        //Uppgift2
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (tärning == 10)
                print(tärning += Random.Range(1, 7));
            print(tärning -= Random.Range(1, 7));

            if (tärning >= 20)
            {
                print("gg");
            }

            if (tärning <= 0)
            {
                print("u sux");
            }   
        }
        
    }
}
