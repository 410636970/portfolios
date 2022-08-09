using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform OriginalParent
    {
        get;
        set;
    }

    void Awake()
    {
        this.OriginalParent = this.transform.parent;
    }
}
