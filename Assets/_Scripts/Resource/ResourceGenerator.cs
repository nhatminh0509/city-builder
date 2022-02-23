using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MyMonoBehaviour
{
    [SerializeField] protected List<ResourceHolder> resourceHolders;

    protected override void LoadComponents()
    {
        this.LoadHolders();
    }

    protected virtual void LoadHolders()
    {
        if (this.resourceHolders.Count > 0) return;
        Transform resourcesTrans = transform.Find("Resources");
        if (resourcesTrans != null)
        {
            foreach (Transform resourceTrans in resourcesTrans)
            {
                ResourceHolder resourceHolder = resourceTrans.GetComponent<ResourceHolder>();
                Debug.Log(resourceHolder);
                if (resourceHolder == null) continue;
                this.resourceHolders.Add(resourceHolder);
            }
        }

    }
}
