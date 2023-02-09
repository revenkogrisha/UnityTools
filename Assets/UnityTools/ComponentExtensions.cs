﻿using UnityEngine;

namespace UnityTools
{
	public static class ComponentExtensions
	{
		public static bool TryGetComponentInParent<T>(this Component component, out T item)
			where T : MonoBehaviour
		{
			var parent = component.transform.parent;
			return parent.TryGetComponent<T>(out item);
		}

        public static bool TryGetComponentsInParent<T>(this Component component, out T[] items)
			where T : MonoBehaviour
        {
            var parent = component.transform.parent;
			items = parent.GetComponents<T>();

			return items != null;
        }
    }
}