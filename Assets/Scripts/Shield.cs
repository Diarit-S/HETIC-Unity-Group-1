using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float ShieldPower = 10;
    public float ShieldUsingSpeed = 100;
    float timer = 0;

    void Start()
    {
        
    }

    public void RechargeShield() {
        if (ShieldPower < 10)
        {
            ShieldPower++;
        }
    }

    public void UseField() {
         if (ShieldPower > 0)
        {
            timer ++;
            if (timer == ShieldUsingSpeed)
            {
                ShieldPower--;
                timer = 0;
            }
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            print("a key was pressed");
            UseField();
        }
    }
}
