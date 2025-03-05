
    using UnityEngine;

    public class PlayerAnimator: MonoBehaviour
    {

      

        public void State(Animator anim, int state)
        {
            
            anim.SetInteger("state", state);
        }

        public void Jump(Animator anim, bool isJumping)
        {
           anim.SetBool(("isJumping"),isJumping);
        }

      
    }
