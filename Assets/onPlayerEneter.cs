using UnityEngine;

public class onPlayerEneter : MonoBehaviour
{
    public GameObject targetObject;
    public void OnTriggerEnter(Collider other)
        {
            Debug.Log("collided with " + other.gameObject.name);
            if (other.CompareTag("Player"))
            {
                // Destroy the target object
                if (targetObject != null)
                {
                    targetObject.SetActive(true);
                }
                else Debug.Log("No target object to destroy");
            }
            else return;
        }
}
