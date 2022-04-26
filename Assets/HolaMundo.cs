using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolaMundo : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {

        if (num1 > num2)
        {
            int a = num1;
            while (num1 >= a && a >= num2)
            {
                Debug.Log(a);
                a--;
            }
        }
        else
        {
            Debug.Log("Vuelva a escribir los números");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Holamundo()
    {
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter++;
        }

    }
}
