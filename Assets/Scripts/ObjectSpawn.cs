using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjectSpawner;
    [SerializeField]
    private GameObject Player;
    public GameObject Rock;
    public GameObject Missile;
    public GameObject Platform;
    public GameObject Comet;
    public GameObject Steel;

    private int scored;
    private float Rspawner;
    private float Pspawner;
    private float Mspawner;
    private float Cspawner;
    private float Sspawner;

        
    // Start is called before the first frame update
    void Start()
    {
        Rock.SetActive(true);
        Missile.SetActive(false);
        Platform.SetActive(true);
        Comet.SetActive(false);
        Steel.SetActive(false);

    }
    private void Update()
    {
       scored= Player.GetComponent<Movement>().score;
        if(scored>=35)
        {
            Missile.SetActive(true);
        }

        if(scored>=105)
        {
            Comet.SetActive(true);
        }

        if(scored>= 195)
        {
            Steel.SetActive(true);
        }



        if(Time.time>Rspawner+Random.Range(0.25f,9f))
        {
            RockSpawner();
            Rspawner = Time.time;
        }
        if(Time.time>Pspawner+Random.Range(15f,35f))
        {
            PlatformSpawner();
            Pspawner = Time.time;
        }
        if (Time.time > Mspawner + Random.Range(7f, 18f))
        {
            MissileSpawner();
            Mspawner = Time.time;
        }
        if (Time.time > Cspawner + Random.Range(15f, 28f))
        {
            CometSpawner();
            Cspawner = Time.time;
        }
        if (Time.time > Sspawner + Random.Range(14f, 34f))
        {
            SteelSpawner();
            Sspawner = Time.time;
        }
    }
    private void RockSpawner()
    {
        Vector3 RSpawnLock = new Vector3(ObjectSpawner.transform.position.x, -4,0);
        Debug.Log("Rock Spawned");
        Instantiate(Rock, RSpawnLock, Quaternion.identity);
    }
    private void PlatformSpawner()
    {
        Vector3 PSpawnLock = new Vector3(ObjectSpawner.transform.position.x, Random.Range(-4f,2),0);
        Debug.Log("Platform Spawned");
        Instantiate(Platform, PSpawnLock, Quaternion.identity);
    }
    private void MissileSpawner()
    {
        Vector3 MSpawnLock = new Vector3(ObjectSpawner.transform.position.x, Random.Range(-2f,5), 0);
        Debug.Log("Missile Spawned");
        Instantiate(Missile, MSpawnLock, Quaternion.identity);
    }
    private void CometSpawner()
    {
        Vector3 CSpawnLock = new Vector3(ObjectSpawner.transform.position.x, -4, 0);
        Debug.Log("Comet Spawned");
        Instantiate(Comet, CSpawnLock, Quaternion.identity);
    }
    private void SteelSpawner()
    {
        Vector3 SSpawnLock = new Vector3(ObjectSpawner.transform.position.x, -4, 0);
        Debug.Log("Steel Spawned");
        Instantiate(Steel, SSpawnLock, Quaternion.identity);
    }

}
