using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace destroyOnEnter
{
    public class destroyOnEnter : MonoBehaviour
    {
        public GameObject targetObject;
        public GameObject showObject;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                // Destroy the target object
                if (targetObject != null)
                {
                    Destroy(targetObject);
                    showObject.SetActive(true);
                }
                else Debug.Log("No target object to destroy");
            }
            else return;
            if (showObject == null) return;
            else return;
        }
    } 
}
