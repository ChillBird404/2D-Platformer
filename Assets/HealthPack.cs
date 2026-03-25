using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private float healingValue;

    private void OnParticleTrigger()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

     private void OnTriggerEnter2D(Collider2D Collision)
    {
        Collision.GetComponent<HealthComponent>().AddHealth(healingValue);
        Destroy(gameObject);
    }


}
