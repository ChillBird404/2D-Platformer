using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript1 : SceneOpener
{
    public string NextLevelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       OpenScene(NextLevelName);
    }
}
