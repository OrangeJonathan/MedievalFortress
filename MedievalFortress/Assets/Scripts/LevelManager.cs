using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform startPoint;
    public static Transform[] path;
    private void Awake()
    {
        path = new Transform[transform.childCount];
        for (int i = 0; i < path.Length; i++)
        {
            path[i] = transform.GetChild(i);
        }   
    }
}
