using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Perception : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _pawn;
    private Vector3 _checkDirection;
    [SerializeField] private float _distance;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void CheckDistance()
    {
        _checkDirection = _player.transform.position -_pawn.transform.position;
        RaycastHit hit;
        if(Physics.Raycast(_pawn.transform.position,_checkDirection, out hit, _distance))
        {
            if (hit.collider.gameObject.GetComponent<PlayerController>())
            {
                _pawn.GetComponentInChildren<IA_Controller>().PlayerNear = true;
            }
            else
            {
                _pawn.GetComponentInChildren<IA_Controller>().PlayerNear = true;
            }
        }
        else
        {
            _pawn.GetComponentInChildren<IA_Controller>().PlayerNear = true;
        }
    }

}
