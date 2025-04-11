using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _anim;
    private PlayerMovement _pm;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       if (_pm.MoveDirection.x != 0 || _pm.MoveDirection.y != 0 ){
        _anim.SetBool("Move", true);
       } else {_anim.SetBool("Move", false);}
    }
}
