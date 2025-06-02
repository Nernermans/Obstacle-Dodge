using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
        // Print instructions to the console
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrow keys or WASD to move your character.");
        Debug.Log("Don't bump into walls or other objects!");
    }

    void movePlayer()
    {
        // variables below
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f; // No Vertical movement
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // end of variables
        transform.Translate(xValue, yValue, zValue);
    }
}