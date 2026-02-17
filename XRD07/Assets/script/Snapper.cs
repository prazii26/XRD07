using UnityEngine;

public class snapper : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Part")
        {
            other.gameObject.transform.position = transform.position;
        }
    }
}