using UnityEngine;

public class PlayerScale : MonoBehaviour
{
    private Vector3 originalScale;
    private bool isBig = false;

    private void Start()
    {
       originalScale = transform.localScale;
    }

    public void Grow(float multipayer)
    {
        if (isBig)
        {
            transform.localScale = originalScale * multipayer;
            isBig = true;
        }

    }

    public void Shrink(float v)
    {
        if (!isBig)
        {
            transform.localScale = originalScale;
            isBig = false;
        }
    }

}
