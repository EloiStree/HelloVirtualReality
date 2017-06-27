
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomUtility : MonoBehaviour {


    public static Vector3 RandomInZone(Vector3 position, float range=5f) {
        return position + new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
    }

    public static Vector3 RandomInLine(Vector3 start, Vector3 end) {
        return start + (end - start) * Random.Range(0f, 1f);
    }

    internal static Color GetRandomColor(bool withTransparency)
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), withTransparency? Random.Range(0f, 1f):1f);
    }
}
