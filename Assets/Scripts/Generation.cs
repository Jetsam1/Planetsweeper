using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    private const float Distance_to_spawn_part = 25f;

    [SerializeField]
    private Movement Player;
    [SerializeField]
    private Transform ground;
    [SerializeField]
    private Transform firstPart;

    private Vector3 lastEndPos;

    private void Awake()
    {
        lastEndPos = firstPart.Find("EndPoint").position;
        int startGround = 3;
        for(int i=0;i<startGround;i++)
        {
            spawnground();
        }
        spawnground();
    }
    private void Update()
    {
        if(Vector3.Distance(Player.transform.position,lastEndPos)< Distance_to_spawn_part)
        {
            spawnground();
        }

    }
    private void destruct()
    {

    }

    private void spawnground()
    {
       ground=spawnFloor(lastEndPos);
        lastEndPos = ground.Find("EndPoint").position;
    }

    private Transform spawnFloor(Vector3 SpawnPos)
    {
        Transform FloorTransform= Instantiate(ground, SpawnPos, Quaternion.identity);
        return FloorTransform;
    }

    // Start is called before the first frame update

}
