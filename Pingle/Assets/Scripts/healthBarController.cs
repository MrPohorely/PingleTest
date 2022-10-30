using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class healthBarController : MonoBehaviour
{

    [SerializeField]
    private int _max;
    public float _current;
    [SerializeField]
    private RectTransform _HPRect;
    private float _mainsize;
    // Start is called before the first frame update
    void Start()
    {
        _mainsize = _HPRect.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHPFill(float _damage)
    {

        _current = (float)_current + (float)_damage;
        if (_current > _max) { _current = _max; };
        
        float fillNum = ((float)_current * (float)_mainsize)/(float)_max;
        _HPRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (int)fillNum);
    }

}
