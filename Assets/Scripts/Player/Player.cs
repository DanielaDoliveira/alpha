using System;
using UnityEngine;
//2.14  -> 2.09

//y 4.11  down -4.12
public class Player : MonoBehaviour
{
    private PlayerMove _move;
    private PlayerJump _jump;
  
    void Start()
    {
        _move = GetComponent<PlayerMove>();
        _jump = GetComponent<PlayerJump>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _move.Execute();
       
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jump.Execute();
        }
    }
}
