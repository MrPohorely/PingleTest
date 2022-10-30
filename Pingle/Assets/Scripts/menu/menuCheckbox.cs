using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCheckbox : MonoBehaviour
{
    public void checkActive(GameObject _obj)
    {
        bool _state = _obj.activeSelf;
        _obj.SetActive(!_state);
    }
}
