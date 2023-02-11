using System;
using UnityEngine;

/// <summary>
/// Calls events and passes colliders as arguments if some of the messages call
/// </summary>
public class TriggerDetector : MonoBehaviour
{
    public event Action<Collider> OnTrigerEnter;
    public event Action<Collider> OnTrigerStay;
    public event Action<Collider> OnTrigerExit;

    private void OnTriggerEnter(Collider other)
    {
        OnTrigerEnter?.Invoke(other);
    }
    private void OnTriggerStay(Collider other)
    {
        OnTrigerStay?.Invoke(other);
    }
    private void OnTriggerExit(Collider other)
    {
        OnTrigerExit?.Invoke(other);
    }
}

