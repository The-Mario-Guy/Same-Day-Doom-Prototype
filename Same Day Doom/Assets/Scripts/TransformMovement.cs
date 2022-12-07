using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    public float speed = 3;
    public float run = 2;
    public bool isRunning = false;
    public bool isIdle = true;


    private Animator _playerAnim;
    private Rigidbody2D _playerRB;
    // Start is called before the first frame update
    void Start()
    {
      _playerAnim = GetComponent<Animator>();
       _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
       transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
      
       
       //Running
        if(Input.GetKey(KeyCode.Z))
        {
            isRunning = true;
            _playerAnim.SetBool("isRunning", isRunning);
            speed = 5;
            
        }
        else
        {   isRunning = false;         
            speed = 3;
           _playerAnim.SetBool("isIdle", isIdle);
        }

    }
}