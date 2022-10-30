using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider))]
public class enemy : MonoBehaviour
{

    private bool _isDestroyed = false;
    private float _startTime = 0f;
    [SerializeField]
    private Material _material;
    [SerializeField]
    private GameObject _obj;
    [SerializeField]
    private float _disolveDur = 10f;
    private float _disolveCur = 0f;
    [SerializeField]
    private Collider _colider; 
    [SerializeField]
    private UnityEvent OnHit = new UnityEvent();

    private void OnTriggerEnter(Collider _colider)
    {
        if (_obj != null && !_isDestroyed)
        {
            OnHit.Invoke();
           
        }
    } 



    public void DestroidEnemy()
    {
            Debug.Log("enemy destroyed");
        _startTime = Time.time;
        _isDestroyed = true;
            
    }
    private void Update()
    {
        if (_isDestroyed)
        {
            _material.SetFloat("disolveSlider", _disolveCur);
            _disolveCur = Mathf.Lerp(0, 100, (Time.time - _startTime) * _disolveDur) / 100;
            if (_material.GetFloat("disolveSlider") >= 1)
            {
                Debug.Log("disolve finish");
                _obj.SetActive(false);
                _material.SetFloat("disolveSlider", -0.1f);
            }
        }
    }
}
