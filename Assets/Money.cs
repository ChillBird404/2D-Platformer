using UnityEngine;

public class Money : MonoBehaviour
{
    public float Coin = 1;

    public float AddMoney = 1;
    public int moeney = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<CoinComponent>().AddPoints(Coin);
        Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}