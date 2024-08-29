using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObjectOne : MonoBehaviour
{
    private ObjectPoolOne pool;
    public ObjectPoolOne Pool

    { get { return pool; } set { pool = value; } }

    public void ReturnPool()
    {
        if (pool != null) { pool.ReturnPool(this); }
        else { Destroy(gameObject); }
    }
}
