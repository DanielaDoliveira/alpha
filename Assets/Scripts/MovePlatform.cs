using System;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform platform, startPoint, endPoint;
    private Transform _target;
    private int direction = 1;
    public float speed = 1.5f;

  [SerializeField]  private bool _switch;
    private void OnDrawGizmos()
    {
        if (platform != null && startPoint != null && endPoint != null)
        {
            Gizmos.DrawLine(platform.position, startPoint.position);
            Gizmos.DrawLine(platform.position, endPoint.position);
        }
    }

  
    private void Update()
    {
        _switch = IsEndPoint();
        if (!_switch)
            _target = endPoint;
        else
            _target = startPoint;
        Move(_target);
    }

    private void Move(Transform target)
    {
            
            platform.transform.position= Vector3.MoveTowards(platform.position, 
                target.position, Time.deltaTime * speed);
    
    }

    private bool IsEndPoint()
    {
        if (platform.position == endPoint.position)
            return true;
        
        else if(platform.position == startPoint.position)
            return false;

        return _switch;
    }

   
}
