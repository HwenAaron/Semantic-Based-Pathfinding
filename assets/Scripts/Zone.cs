﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{


    public int zoneId;
    public Renderer renderer;
    public int width;
    public int height;
    public Vector3 topLeft; //the 4 corners of the zone
    public Vector3 topRight;
    public Vector3 bottomLeft;
    public Vector3 bottomRight;


    //constructor
    public Zone(int zoneId, Renderer renderer)
    {
        this.zoneId = zoneId;
        this.renderer = renderer;
        FindZoneCorners();
    }


    public void FindZoneCorners()
    {
        //get the dimensions of this zone
        float approxLeft = renderer.bounds.center.x - (renderer.bounds.size.x / 2);
        float approxRight = renderer.bounds.center.x + (renderer.bounds.size.x / 2);
        float approxBottom = renderer.bounds.center.z - (renderer.bounds.size.z / 2);
        float approxTop = renderer.bounds.center.z + (renderer.bounds.size.z / 2);
        float approxY = renderer.bounds.center.y;

        //convert dimensions into Vector3s
        topLeft = new Vector3(approxLeft, approxY, approxTop);
        topRight = new Vector3(approxRight, approxY, approxTop);
        bottomLeft = new Vector3(approxLeft, approxY, approxBottom);
        bottomRight = new Vector3(approxRight, approxY, approxBottom);

        /*
        Debug.Log("new zone");
        Debug.Log("tl" + topLeft);
        Debug.Log("tr" + topRight);
        Debug.Log("bl" + bottomLeft);
        Debug.Log("br" + bottomRight);
        */

    }



}