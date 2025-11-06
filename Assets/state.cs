using UnityEngine;

public class state : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical");
        Animator animator = GetComponentInChildren<Animator>();
        animator.SetFloat("movementSpeed", movement);
    }
}
