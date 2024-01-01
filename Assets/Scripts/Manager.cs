using PathCreation;
using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public PathCreator pathCreator;
    public float minY = -2f;
    public float maxY = 2f;
    public float minZ = -2f;
    public float maxZ = 2f;
    public int numPoints = 10;


    void Start()
    {
        List<Vector3> waypoints = new List<Vector3>();

        float constantXOffset = 20f; // Constant X offset between points

        for (int i = 1; i < numPoints; i++)
        {
            float x = i * constantXOffset;
            float y = Random.Range(minY, maxY);
            float z = Random.Range(minZ, maxZ);

            //waypoints.Add(new Vector3(x, y, z));
            pathCreator.bezierPath.AddSegmentToEnd(new Vector3(x, y, z));
        }

        pathCreator.GetComponent<RoadMeshCreator>().flattenSurface = true;
        pathCreator.GetComponent<RoadMeshCreator>().TriggerUpdate();

        //bool closedLoop = false; // Change to true if you want to close the loop
        //BezierPath bezierPath = new BezierPath(waypoints, closedLoop, PathSpace.xyz);
        //pathCreator.bezierPath = bezierPath;

    }
}
