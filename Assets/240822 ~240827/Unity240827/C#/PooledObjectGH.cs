using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObjectGH : MonoBehaviour
{
    private ObjectPoolGH pool;
    public ObjectPoolGH Pool
    { get { return pool; } set { pool = value; } }

    public void ReturnPool()
    {
        if (pool != null) { pool.ReturnPool(this); }
        else { Destroy(gameObject); }
    }
}
