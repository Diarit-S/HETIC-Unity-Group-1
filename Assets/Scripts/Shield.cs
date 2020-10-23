using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float ShieldPower = 10;
    public float ShieldUsingSpeed = 100;
    float timer = 0;
    
    // GameObject ShieldObject;

    // Rigidbody rb;
    // MeshRenderer mr;
    // Renderer r;
    // gameObject.SetActive(false);
    // public GameObject Shield;
    // GameObject Copy = gameObject;

    void Start()
    {
        
        // gameObject.SetActive(false);
        // ShieldObject = gameObject;
        // gameObject.SetActive(false);
        // r = GetComponent<GameObject>();
        // rb = GetComponent<Rigidbody>();
        // mr = GetComponent<MeshRenderer>();
        // rb.detectCollisions = false;
        // mr.enabled = false;
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
        if (Input.GetKey(KeyCode.G))
        {
            gameObject.SetActive(true);

            print("a key was pressed");
            UseField();
        }
        else {
            gameObject.SetActive(false);

            // ShieldObject.SetActive(false);
            // mr.enabled = false;
            // rb.detectCollisions = false;
        }
    }
}
