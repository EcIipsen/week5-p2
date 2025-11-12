using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    private int ammoAmount=0;
    public AudioClip noAmmoSound;
    public AudioClip shotGunReload;
    public AudioSource audioSource;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(ammoAmount>0){
                Shoot();
            }
            else{
                audioSource.PlayOneShot(noAmmoSound);
            }

        }
    }


void OnTriggerEnter(Collider other){
    if (other.gameObject.name=="AmmoBox"){
        ammoAmount+=20;
        audioSource.PlayOneShot(shotGunReload);

    other.gameObject.SetActive(false);
    }
    
}

void Shoot(){

}

    
}
