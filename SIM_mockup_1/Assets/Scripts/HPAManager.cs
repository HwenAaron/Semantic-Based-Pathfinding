using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPAManager : MonoBehaviour {


    //references
    public Map m;
   //public Transform agent;
    //public Transform goal;



    // used for testing and other debugging
	// Use this for initialization
	void Start () {
        m.GetMapDimensions();
        m.BuildCellGrid(.2f);
        m.DefineZones();
        m.FindThresholds();
	}
    /*
    public void LevelFindPath(Vector3 startPos, Vector3 targetPos)
    {
        Cell start = m.CellFromWorldPos(startPos);
        Cell target = m.CellFromWorldPos(targetPos);
        
        Cell c;
        Zone z;
        if (start.zoneId == target.zoneId)
        {
            AStarALgo.FindPath(start, target);
        }
        else
        {

            /*
             * pseu·do·code:
             * 
             * 1. identify which zone target is in. 
             * z = start.zone;
             * 2. identify all the thresholds of that zone
             * float shortestDist = distance(z.thresholdList[0], target)
             * c = z.thresholdList(0);
             * for (int i = 1; z.thresholdsList(); i ++)
             * {   
             *      float dist = distance(z.thresholdList[i], target)          * }
             *      if dist < shrotestDist
             *          shortestDist = dist;
             *          c = z.thresholdList[i];
             * {
             * 3. Traverse each threshold while calculating the distance to from that threshold to the target
             * 4. Kepp track of the shortest distance threshold set c to that threshold.
             * findPath(start, c)
             * 6. Move start into the next zone by checkign the two zones that the threshold is connecting.
             * for (int i = 0; c.edgeToNeighbors; i++)
             *      if !c.edgeToNeighbors[i].isWalkable
             *          continue;
             *      if c.zone!=start.zone
             *          start = c.walkForward //agent enters next zone
             *          break
             * 
             * Cell newStart = start.WorldPosition
             * HPAFindPath(Vector3 newStart, Vector3 targetPos);
             *
        }



    }
    */
}
