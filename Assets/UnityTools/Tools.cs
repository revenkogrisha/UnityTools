using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityTools
{
    public static class Tools
    {
        /// <summary>
        /// Invokes given methods if Collider container has component requested as generic type.
        /// Component of given generic type is used as argument for methods.
        /// </summary>
        public static bool InvokeIfNotNull<T>(Collider container, params Action<T>[] handlers)
        {
            var component = container.GetComponent<T>();
            var isNotComponentNull = component != null;
            if (isNotComponentNull)
                foreach (var handler in handlers)
                    handler?.Invoke(component);

            return isNotComponentNull;
        }

        /// <summary>
        /// Invokes given methods if Collider container has component requested as generic type.
        /// </summary>
        public static bool InvokeIfNotNull<T>(Collider container, params Action[] handlers)
        {
            var component = container.GetComponent<T>();
            var isNotComponentNull = component != null;
            if (isNotComponentNull)
                foreach (var handler in handlers)
                    handler?.Invoke();

            return isNotComponentNull;
        }

        /// <summary>
        /// Invokes given methods if Collider container has component requested as generic type.
        /// Component of given generic type is used as argument for methods.
        /// </summary>
        public static bool InvokeIfNotNull<T>(Collider2D container, params Action<T>[] handlers)
        {
            var component = container.GetComponent<T>();
            var isNotComponentNull = component != null;
            if (isNotComponentNull)
                foreach (var handler in handlers)
                    handler?.Invoke(component);

            return isNotComponentNull;
        }

        /// <summary>
        /// Invokes given methods if Collider container has component requested as generic type.
        /// </summary>
        public static bool InvokeIfNotNull<T>(Collider2D container, params Action[] handlers)
        {
            var component = container.GetComponent<T>();
            var isNotComponentNull = component != null;
            if (isNotComponentNull)
                foreach (var handler in handlers)
                    handler?.Invoke();

            return isNotComponentNull;
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
        public static bool InvokeWithChance(int percentChance, params Action[] actions)
        {
            var random = Random.Range(0, 101);
            var isChanceOccured = random <= percentChance;
            if (isChanceOccured)
                foreach (var action in actions)
                    action?.Invoke();

            return isChanceOccured;
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