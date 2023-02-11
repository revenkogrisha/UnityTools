using System;
using UnityEngine;

/// <summary>
/// Calls events and passes collisions as arguments if some of the messages call
/// </summary>
public class CollisionDetector : MonoBehaviour
{
    public event Action<Collision> OnCollisonEnter;
    public event Action<Collision> OnCollisonStay;
    public event Action<Collision> OnCollisonExit;

    private void OnCollisionEnter(Collision collision)
    {
        OnCollisonEnter?.Invoke(collision);
    }
    private void OnCollisionStay(Collision collision)
    {
        OnCollisonStay?.Invoke(collision);
    }
    private void OnCollisionExit(Collision collision)
    {
        OnCollisonExit?.Invoke(collision);
    }
}
