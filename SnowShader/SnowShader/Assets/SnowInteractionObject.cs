using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowInteractionObject : DrawTracks
{
    public float widthTrailObject;
    public float opacityTrailObject;
    public MeshCollider meshCollider;

    public override void Start()
    {
        widthTrail = widthTrailObject;
        opacityTrail = opacityTrailObject;
        meshCollider = GetComponent<MeshCollider>();

        base.Start();
    }
}
