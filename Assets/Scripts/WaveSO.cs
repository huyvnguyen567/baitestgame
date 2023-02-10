using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave", fileName = "New Wave")]
public class WaveSO : ScriptableObject
{
    [SerializeField] Transform pathPrefabs;

    public List<Transform> GetWayPoints()
    {
        List<Transform> wayPoints = new List<Transform>();
        foreach(Transform child in pathPrefabs)
        {
            wayPoints.Add(child);
        }
        return wayPoints;
    }
}
