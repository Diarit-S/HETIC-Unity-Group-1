using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ammo : MonoBehaviour
{
    public Global GlobalRef;
    public Text TxtLife; 

    void Start() {
        GlobalRef = GameObject.FindObjectOfType<Global>();
        TxtLife.text = "Vies : " + GlobalRef.Ammo;
    }

    public void AddAmmo() {
        GlobalRef.Ammo++;
        TxtLife.text = "Vies : " + GlobalRef.Ammo;
    }

    public void RemoveAmmo() {
        GlobalRef.Ammo--;

        TxtLife.text = "Vies : " + GlobalRef.Ammo;
    }
}
