using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TransformMovement : MonoBehaviour
{
    public float speed = 3;
    public float run = 2;
    public bool isRunning = false;
    public bool isIdle = true;
     public GameObject boxUI;

    public GameObject Box;
    public bool hasBox = false;
    private SpriteRenderer _boxSR;
    private SpriteRenderer _uiboxSR;
    public GameObject Timer;
    public GameObject Indicators;
    public GameObject Target;


    private Animator _playerAnim;
    private Rigidbody2D _playerRB;
    // Start is called before the first frame update
    void Start()
    {
      _playerAnim = GetComponent<Animator>();
      _playerRB = GetComponent<Rigidbody2D>();
      _boxSR = GetComponent<SpriteRenderer>();
    
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
            speed = 5;
            
        }
        else
        {   isRunning = false;         
            speed = 3;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.CompareTag("Box"))
      {
        hasBox = true;
        Box.gameObject.SetActive(false);
        boxUI.gameObject.SetActive(true);
        Indicators.gameObject.SetActive(true);
        Target.gameObject.SetActive(true);

      }
      if(other.gameObject.CompareTag("Target") && hasBox == true)
      {
        hasBox = false;
        Box.gameObject.SetActive(true);
        boxUI.gameObject.SetActive(false);
        Indicators.gameObject.SetActive(false);
        Target.gameObject.SetActive(false);
      }
    }
    
}