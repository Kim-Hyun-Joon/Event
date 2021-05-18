using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public delegate void Boost(Character character);

    public event Boost playerBoost;

    public string playerName = "Didi";

    public float hp = 100;
    public float defense = 50;
    public float damage = 30;

    private void Start() {
        playerBoost(this);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerBoost(this);
        }
    }
}
