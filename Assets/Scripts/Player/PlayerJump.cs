using System;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerModel Player;
    public float JumpForce;
    public Transform point;
    public float radius = 0.22f;
  
    

    void Start()
    {
         
        Player = GetComponent<PlayerModel>();
        Player.layer = LayerMask.GetMask("GROUND");
        Player.isJumping = false;
    }

    // Update is called once per frame
    public void Execute()
    {
        Player._playerAnimator.Jump(Player._Animator,Player.isJumping);
        if (!Player.isJumping)
        {
          
            Player._Rigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            Player.isJumping = true;
        }
        

    }

    private void FixedUpdate()
    {
        OnHitGround();
    }

    private void OnHitGround()
    {
        Collider2D hit = Physics2D.OverlapCircle(point.position, radius, Player.layer);
        if (hit!=null)
        {
            Debug.Log(hit.name);
            Player.isJumping = false;
        }
        else
            Player.isJumping = true;
    }

 
   
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(point.position,radius);
        Gizmos.color = Color.blue;
    }


}
