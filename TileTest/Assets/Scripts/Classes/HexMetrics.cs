using UnityEngine;

public static class HexMetrics
{
    public const float rootThreeOverTwo = 0.86025404f;
    public const float outRadius = 10f;
    public const float innerRadius = outRadius * rootThreeOverTwo;

    public static Vector3[] corners = {
           new Vector3(0f, 0f, outRadius),
           new Vector3(innerRadius, 0f, 0.5f * outRadius),
           new Vector3(innerRadius, 0f, -0.5f * outRadius),
           new Vector3(0f, 0f, -outRadius),
           new Vector3(-innerRadius, 0f, -0.5f * outRadius),
           new Vector3(-innerRadius, 0f, 0.5f * outRadius)
    };
}
