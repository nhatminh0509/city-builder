using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceHolder : MyMonoBehaviour
{
    [SerializeField] protected ResourceName resourceName;
    [SerializeField] protected float resourceCurrent = 0;
    [SerializeField] protected float resourceMax = Mathf.Infinity;

    protected override void LoadComponents()
    {
        LoadResourceName();
    }

    protected virtual void LoadResourceName()
    {
        string name = transform.name;
        this.resourceName = ResourceNameParser.FromString(name);
    }
}
