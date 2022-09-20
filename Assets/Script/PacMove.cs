using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    public Rigidbody2D pacman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 targetPos = pacman.position + movement * Time.deltaTime * speed;

        pacman.MovePosition(targetPos);
    }
}
