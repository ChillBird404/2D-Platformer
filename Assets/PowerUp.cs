using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float multiplayer = 2f;
    public float ScaleMode;
    public float PlayerScale = 5;
    public float shrink = -2;
    //public float change playerScale = 2;
    private bool powerUp;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerScale Player = collision.GetComponent<PlayerScale>();
            if (Player != null)
            {
                Player.Grow(multiplayer * -2);
                //Player.Shrink(PlayerScale * -2);
            }
            powerUp = true;
        }

        //collision.GetComponent<powerUpComponent>().AddPoints(powerUp = );
        Destroy(gameObject);
    }
}

