using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  [HideInInspector]  public PlayerModel Player;
    public int Speed;
    private int saveSpeed;
 
    void Start()
    {
     
      Player = GetComponent<PlayerModel>();
      saveSpeed = Speed;
      Player.Speed = Speed;
    
    }

    private void SetAnimations()
    {
    
        if(Player._Rigidbody.linearVelocityX > 0 )
          Player._playerAnimator.State(Player._Animator,1);
         
         else
             Player._playerAnimator.State(Player._Animator,0);
    }


    private void AutoMove()
    {

    Player._Rigidbody.linearVelocity =  new Vector2(  Speed, Player._Rigidbody.linearVelocity.y);
    }

 
    
    
    public void Execute()
    {
        SpeedInput();
        SetAnimations();
       AutoMove();
    }

    private void SpeedInput()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Speed = saveSpeed;
        }
        
    }

    public void StopMove()
    {
        Speed = 0;
    }

   

}
