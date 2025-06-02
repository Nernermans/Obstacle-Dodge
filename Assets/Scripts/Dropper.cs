using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    
    MeshRenderer myMeshRenderer;

    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        // this will make the object invisible
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            // this will make the object visible and allow it to fall
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
