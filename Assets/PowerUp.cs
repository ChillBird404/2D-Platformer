using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public Vector3 scaleMultiplier = new Vector3(1.5f, 1.5f, 1f);


    //private bool PowerUp() //=> ShrinkPlayer = -2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerScale Player = collision.GetComponent<PlayerScale>();
            if (Player != null)
            {
                Player.scaleMultiplier = scaleMultiplier;
                Player.ShrinkPlayer();  
            }
        }

        //collision.GetComponent<powerUpComponent>().AddPoints(powerUp = );
        Destroy(gameObject);


        //if (collision.CompareTag("PowerUp"))
        {
            //PlayerScale PowerUp = collision.GetComponent<PlayerScale>();
            //if (PowerUp != null)
            {
                //Player.Grow(multiplayer * -2);
                //Player.Shrink(PlayerScale * -2);
                //PowerUp.changePlayerScale = -2;
            }
            //powerUp = true;
        }
    }

 
}

