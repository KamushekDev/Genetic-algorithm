using System;
using Types;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    public CollectableType type;
    public int healthChange;
    public Action<GameObject> DestroyMe;

    public void Collect()
    {
        var go = gameObject;
        DestroyMe(go);
        Destroy(go);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}