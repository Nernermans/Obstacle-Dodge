using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField]float yAngle = 0f;
    [SerializeField] float zAngle = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this will rotate the object around the y-axis
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
