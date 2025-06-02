using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        // Change the color of the object to gray when it collides with something
        Debug.Log("Something hit me!");
    }
}
