using System;
using UnityEngine;


public class GenericAnimatorController : MonoBehaviour
{
    [SerializeField]protected Animator _animator;
    private string TriggerName;
    public TriggerData triggerData;

    protected virtual void Start()
    {
        if (_animator == null)
        {
            _animator = GetComponent<Animator>();
        }
    }


    public void FireTrigger(string triggerName)
    {
        _animator.SetTrigger(triggerName);
    }

    public void SetTriggerName(string triggerName)
    {
        TriggerName = triggerName;
    }
    public void SetInt(int value)
    {
        _animator.SetInteger(TriggerName,value);
    }

    public void SetInt(TriggerData data)
    {
        _animator.SetInteger(data.triggerName, data.value);
    }



}

[Serializable]
public class TriggerData
{
    public string triggerName;
    public int value;
}
