using UnityEngine;
using System.Collections;

public class DeathPlane : MonoBehaviour {

    public void OnTriggerEnter(Collider obj)
    {
        obj.transform.position.Set(0f, 1f, 0f);
    }
}
