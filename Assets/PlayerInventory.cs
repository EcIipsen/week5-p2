using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    private int ammoAmount=0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


void OnTriggerEnter(Collider other){
    if (other.gameObject.name=="AmmoBox"){
        ammoAmount+=20;
    other.gameObject.SetActive(false);
    }
    
}



    
}
