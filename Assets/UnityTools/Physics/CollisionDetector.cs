using System;
using UnityEngine;

/// <summary>
/// Calls events and passes collisions as arguments if some of the messages call
/// </summary>
public class CollisionDetector : MonoBehaviour
{
    public event Action<Collider> OnCollisonEnter;
    public event Action<Collider> OnCollisonStay;
    public event Action<Collider> OnCollisonExit;

    private void OnTriggerEnter(Collider other)
    {
        OnCollisonEnter?.Invoke(other);
    }
    private void OnTriggerStay(Collider other)
    {
        OnCollisonStay?.Invoke(other);
    }
    private void OnTriggerExit(Collider other)
    {
        OnCollisonExit?.Invoke(other);
    }
}
