using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float Point;
    public Text text;

    void Start()
    {
        Point = 0f;
    }

    void Update()
    {
        text.text = Point.ToString();
    }



}
