using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private Rigidbody2D _PlayerRB;
    private SpriteRenderer _boxSR;
    public bool hasBox = false;

    // Start is called before the first frame update
    void Start()
    {
        _PlayerRB = GetComponent<Rigidbody2D>();
        _boxSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
