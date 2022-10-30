using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent enemy;
    [SerializeField]
    Transform player;
    public bool _hunt = false;
    private int firstime = 0;
    [SerializeField]
    private Collider _colider;
    private void OnTriggerEnter(Collider _colider)
    {
        if ( !_hunt && firstime == 0)
        {
            firstime = 1;
            _hunt = true;   
        }
    }

    public void HuntOff() { _hunt = false; }
    void Update()
    {
        if (_hunt) { 
        enemy.SetDestination(player.position);
        }
    }
}
