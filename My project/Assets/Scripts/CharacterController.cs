using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public bool mouse_over = false; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(mouse_over);
    }

    private void OnMouseEnter()
    {
        mouse_over = true;
    }
}
