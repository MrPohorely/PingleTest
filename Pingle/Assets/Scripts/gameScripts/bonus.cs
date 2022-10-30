using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class bonus : MonoBehaviour
{
    private bool _isPicked= false;
    [SerializeField]
    private SphereCollider _colider;
    [SerializeField]
    private UnityEvent OnHit = new UnityEvent();


    private void OnTriggerEnter(Collider _colider)
    {
        if ( !_isPicked)
        {
            OnHit.Invoke();

        }
    }
}
