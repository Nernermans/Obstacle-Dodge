using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            // Change the color of the object to gray when it collides with something
            gameObject.tag = "Hit";
            // Change the tag of the object to "Hit" when it collides with something
        }
        
       
    }
}
