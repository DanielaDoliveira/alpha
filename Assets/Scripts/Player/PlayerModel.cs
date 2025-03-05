using System;
using UnityEngine;

public class PlayerModel: MonoBehaviour
{

  [HideInInspector]  public Rigidbody2D _Rigidbody;
   public Animator _Animator;
   [HideInInspector] public PlayerAnimator _playerAnimator;
    [HideInInspector]public int TotalLife;
    [HideInInspector]public int Speed;
    public LayerMask layer;
    public bool isJumping;
    public float JumpForce;
    public void Start()
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
        _Animator = GetComponent<Animator>();
        _playerAnimator = GetComponent<PlayerAnimator>();
     

    }

  
    
}
