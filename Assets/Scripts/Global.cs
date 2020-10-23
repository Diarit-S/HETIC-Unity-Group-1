using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    // This is the normal speed of any moving element
    public float AccelFactor = 10;
    public float Speed = 10;
    public float Score = 0;
    public float Coins = 0;
    public float ScoreMultiplicator = 1;

    void Update() {
        if (Speed < 50) {
            Speed += Time.deltaTime / AccelFactor;
        }

        Score += Time.deltaTime * ScoreMultiplicator;
    }
}
