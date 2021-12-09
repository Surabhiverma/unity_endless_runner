using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public Transform tile1Obj;
    private Vector3 nextTileSpawn;
    public Transform bricksObj;
    private Vector3 nextBrickSpawn;
    private int randX;
 
    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 21;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTile() {
        yield return new WaitForSeconds (1);
        randX = Random.Range(-4,-1);
        nextBrickSpawn = nextTileSpawn;
        nextBrickSpawn.x = (float)(randX-0.23);
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(bricksObj, nextBrickSpawn, bricksObj.rotation);
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }
}
