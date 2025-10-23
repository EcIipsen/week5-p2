using UnityEngine;

public class isDoorOpen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        GameObject parent = transform.parent.gameObject;
        Animation OpenDoor= parent.GetComponent<Animation>();
        OpenDoor.Play("OpenDoor");
    }
}
