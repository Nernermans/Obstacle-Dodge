using UnityEngine;

public class Scorer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("You've bumped into an object this many times: ");
    }
}
