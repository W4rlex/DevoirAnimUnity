using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum IA_State
{
    None,
    Idle,
    Patrol,
    PlayerSeen,
    PlayerNear
}

public class IA_Controller : MonoBehaviour
{

    private IA_State _state = IA_State.None;
    [SerializeField] private Animator _animator;
    public bool PlayerNear = false;
    [SerializeField] private UnityEngine.AI.NavMeshAgent _agent;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        CheckTransition();
        Behaviour();
    }

    private void Behaviour()
    {
        switch (_state)
        {
            case IA_State.None:
                
                break;

            case IA_State.Idle:
                
                break;

            case IA_State.Patrol:
                
                break;

            case IA_State.PlayerSeen:
                
                break;

            case IA_State.PlayerNear:
                
                break;
        }
    }

    private void CheckTransition()
    {
        switch (_state)
        {
            case IA_State.None:

                if (PlayerNear)
                {
                    _state = IA_State.PlayerNear;
                }
                break;

            case IA_State.Idle:

                if (PlayerNear)
                {
                    _state = IA_State.PlayerNear;
                    _animator.SetBool("Near", true);
                }
                break;

            case IA_State.Patrol:

                if (PlayerNear)
                {
                    _state = IA_State.PlayerNear;
                    _animator.SetBool("Near", true);
                }
                break;

            case IA_State.PlayerSeen:

                if (PlayerNear)
                {
                    _state = IA_State.PlayerNear;
                    _animator.SetBool("Near", true);
                }

                break;

            case IA_State.PlayerNear:

                if (!PlayerNear)
                {
                    _state = IA_State.Patrol;
                    _animator.SetBool("Near", false);
                }

                break;
        }
    }

}
