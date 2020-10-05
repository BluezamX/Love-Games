using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField]
    private float lifespan;

    void Update()
    {
        lifespan -= Time.deltaTime;
        if (lifespan <= 0)
            Destroy(this.gameObject);
    }
}
