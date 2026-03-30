using UnityEngine;
using UnityEngine.InputSystem; 

public class CharacterController : MonoBehaviour
{
    private InputAction _moveAction;

    public float moveSpeed = 5f; 
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Starting Play");
        _moveAction = InputSystem.actions.FindAction("Move"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = _moveAction.ReadValue<Vector2>();
        
        Debug.Log(input.ToString());
    }
}
