using Unity.VisualScripting;
using UnityEngine;

public class PlayerScale : MonoBehaviour
{
    private Vector3 originalScale;
    private bool isBig = false;
    private PlayerMotor PlayerMotor;

    public float SetNewScale = -2;
    private bool PlayerShrink;

    public Vector3 scaleMultiplier = new Vector3(1.5f, 1.5f, 1f);
    internal int changePlayerScale;

       
    public void ShrinkPlayer()
    {
        transform.localScale = Vector3.Scale(transform.localScale, scaleMultiplier);
        PlayerMotor._initScale = transform.localScale.x;
    }




    private void Start()
    {
       originalScale = transform.localScale;
        PlayerMotor = GetComponent<PlayerMotor>();
    }

}
