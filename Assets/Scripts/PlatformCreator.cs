using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using PathCreation;
using UnityEditor;
using System.Linq;

public class PlatformCreator : MonoBehaviour
{
    public PathCreator pathCreator; // Reference to the PathCreator component.
    public float m_width = 10f;


    private void Start()
    {
        pathCreator = GetComponent<PathCreator>();
        GeneratePlatform();
        //print(pathCreator.path.localPoints.Length);
        print(pathCreator.path.NumPoints);
    }

    //void GeneratePlatform()
    //{
    //    for(int i = 0; i < pathCreator.path.NumPoints; i++)
    //    {
    //        Vector3 right = Vector3.Cross(pathCreator.path.GetDirection(i / pathCreator.path.NumPoints), pathCreator.path.GetNormal(i)).normalized;

    //        GameObject obj1 = new GameObject("Point " + i + " 1");
    //        GameObject obj2 = new GameObject("Point " + i + " 1");

    //        obj1.transform.position = pathCreator.path.GetPoint(i) + (right * m_width);
    //        obj2.transform.position = pathCreator.path.GetPoint(i) + (-right * m_width);
    //    }
    //}
    void GeneratePlatform()
    {
        for (int i = 0; i < pathCreator.path.NumPoints; i++)
        {
            float t = i / (float)(pathCreator.path.NumPoints); // Corrected to iterate over all points.
            Vector3 forward = pathCreator.path.GetDirection(t);

            // Calculate the 'right' vector by rotating the forward vector 90 degrees.
            Vector3 right = Quaternion.Euler(0, 90, 0) * forward;

            GameObject obj1 = new GameObject("Point " + i + " 1");
            GameObject obj2 = new GameObject("Point " + i + " 2");

            obj1.transform.position = pathCreator.path.GetPointAtTime(t) + (right * m_width);
            obj2.transform.position = pathCreator.path.GetPointAtTime(t) - (right * m_width);
        }
    }
}
