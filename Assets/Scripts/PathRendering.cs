using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRendering : MonoBehaviour
{
    private LineRenderer _lineRendererComponent;
    
    void Start()
    {
        _lineRendererComponent = GetComponent<LineRenderer>();
    }

    public void ShowPath(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[50];
        _lineRendererComponent.positionCount = points.Length;

        for (int i = 0; i < points.Length; i++)
        {
            float timePath = i * 0.1f;
            points[i] = origin + speed * timePath; // + Physics.gravity * timePath * timePath / 2f  // если нужно учесть гравитацию

        }
        _lineRendererComponent.SetPositions(points);
    }
}
