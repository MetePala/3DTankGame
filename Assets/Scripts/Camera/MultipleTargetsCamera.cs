using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetsCamera : MonoBehaviour
{
    public static MultipleTargetsCamera Instance { get; set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance!= this)
        {
            Destroy(gameObject);
        }
    }

    [SerializeField]float minDistanceForZoom = 10f, maxPossibleDistance = 50f, smoothing = 0.5f, minY = 10f, maxY = 50f;
    [SerializeField] List<Transform> targets = new List<Transform>();

    Vector3 velocity;

    private void LateUpdate()
    {
        if(targets.Count ==0)
        {
            return;
        }
        Move();
        Zoom();
    }

    private void Zoom()
    {
        float greatestDistance = GetGreatestDistance();

        if(greatestDistance <minDistanceForZoom)
        {
            greatestDistance = 0f;
        }
        float newY = Mathf.Lerp(minY, maxY, greatestDistance / maxPossibleDistance);

        transform.position = new Vector3(transform.position.x, 
            Mathf.Lerp(transform.position.y, newY, Time.deltaTime),
            transform.position.z);
  
    }

    private float GetGreatestDistance()
    {
        Bounds bounds = EncapsulateTargets();
        return bounds.size.x > bounds.size.z ? bounds.size.x : bounds.size.z;
    }

    private void Move()
    {
        Vector3 centerPoint = GetCenterPoint();
        centerPoint.y = transform.position.y;

        transform.position = Vector3.SmoothDamp(transform.position, centerPoint, ref velocity, smoothing);


    }

    private Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }
        Bounds bounds = EncapsulateTargets();

        Vector3 center = bounds.center;


        return center;
    }
    private Bounds EncapsulateTargets()
    {
        Bounds bounds = new Bounds(targets[0].position, Vector3.zero);

        foreach (Transform target in targets)
        {
            bounds.Encapsulate(target.position);
        }
        return bounds;
    }
}
