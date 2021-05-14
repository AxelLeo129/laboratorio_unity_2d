using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Animator animador;
    private Rigidbody2D rb;
    [SerializeField] private float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.animador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0)
        {
            transform.position += new Vector3(0.01f, 0, 0);
        }
        else if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0)
        {
            transform.position += new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetButtonDown("Jump"))
        {
            if(this.rb && Mathf.Abs(this.rb.velocity.y) < 0.05f)
            {
                this.rb.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
            }
        }
    }
}