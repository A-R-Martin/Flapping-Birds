using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float flappingStrength;
    public LogicManager logic;
    public bool birdIsAlive = true;



    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive ==true)
        {
            MyRigidbody.velocity = Vector2.up * flappingStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        logic.HighScore();
        logic.DisplayHighScore();
    }
}
