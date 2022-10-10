using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSpawn : MonoBehaviour
{
    public GameObject downSpawnPoint;

    // balloons
    public GameObject blueBallonObj;
    public GameObject pinkBalloonObj;
    public GameObject yellowBalloonObj;
    [SerializeField]

    private List<GameObject> balloonsList = new List<GameObject>();

    float spawnRate = 1.5f;
    float nextSpawn = 0.0f;

    float randX;
    Vector2 positionToSpawn;

    // может удалить из-за динамической ширины экрана
    GameObject leftPos;
    GameObject rightPos;
    private void setSpawnWidth()
    {
        leftPos = downSpawnPoint.transform.Find("LeftSide").gameObject;
        rightPos = downSpawnPoint.transform.Find("RightSide").gameObject;
    }
    //

    void Start()
    {
        setSpawnWidth();
        initBalloonsList();
    }

    void Update()
    {
        SpawnBalloon();
    }

    private void SpawnBalloon()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            randX = Random.Range(leftPos.transform.position.x, rightPos.transform.position.x);
            positionToSpawn = new Vector2(randX, downSpawnPoint.transform.position.y);

            Instantiate(getBalloon(), positionToSpawn, Quaternion.identity);
        }
    }

    private void initBalloonsList()
    {
        balloonsList.Add(blueBallonObj);
        balloonsList.Add(pinkBalloonObj);
        balloonsList.Add(yellowBalloonObj);
    }

    private GameObject getBalloon()
    {
        int balloonIndex = Random.Range(0, balloonsList.Count);
        return balloonsList[balloonIndex];
    }
}
