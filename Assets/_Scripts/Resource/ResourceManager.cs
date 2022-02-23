using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager instance;

    [SerializeField] protected List<Resource> resources;

    protected void Awake()
    {
        if (ResourceManager.instance != null) Debug.LogError("On 1 Resource manager allow");
        ResourceManager.instance = this;
    }

    public virtual Resource AddResource(ResourceName resourceName, int number)
    {
        Resource resource = this.GetResourceByName(resourceName);
        
        resource.number += number;

        return resource;
    }

    protected virtual Resource GetResourceByName(ResourceName resourceName)
    {
        Resource resource = this.resources.Find((x) => x.resourceName == resourceName);
        if (resource == null)
        {
            resource = new Resource
            {
                resourceName = resourceName,
                number = 0
            };

            this.resources.Add(resource);
        }
        return resource;
    }

}
