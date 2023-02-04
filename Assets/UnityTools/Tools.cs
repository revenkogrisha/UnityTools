using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityTools
{
    public static class Tools
    {
        /// <summary>
        /// Invokes given methods if Collider container has component requested as generic type
        /// </summary>
        public static bool InvokeIfNotNull<T>(Collider contaiter, Action<T> handler)
        {
            if (contaiter.GetComponent<T>() != null)
            {
                handler?.Invoke(
                    contaiter.GetComponent<T>()
                    );

                return true;
            }

            return false;
        }

        /// <summary>
        /// Invokes given methods if Collider container has component requested as generic type
        /// </summary>
        public static bool InvokeIfNotNull<T>(Collider contaiter, params Action[] handlers)
        {
            if (contaiter.GetComponent<T>() != null)
            {
                foreach (var handler in handlers)
                    handler?.Invoke();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Takes other methods via Action param and invokes each method
        /// with given argument.
        /// </summary>
        public static void InvokeWithSameArgs<T>(T arg, params Action<T>[] actions)
        {
            foreach (var action in actions)
                action?.Invoke(arg);
        }

        /// <summary>
        /// Invokes given methods with given percent chance
        /// </summary>
        public static void InvokeWithChance(int percentChance, params Action[] actions)
        {
            var random = Random.Range(0, 101);
            if (random <= percentChance)
                foreach (var action in actions)
                    action?.Invoke();
        }

        /// <summary>
        /// Returns array with all materials attached to GameObject
        /// </summary
        public static Material[] GetAllMaterials(GameObject gameObject)
        {
            Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();
            var materials = new List<Material>();
            foreach (var renderer in renderers)
            {
                materials.Add(renderer.material);
            }

            return materials.ToArray();
        }
    }
}