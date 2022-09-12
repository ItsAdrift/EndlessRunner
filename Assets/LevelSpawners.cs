using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawners : MonoBehaviour
{
    public Obstacle[] obstacles;

    public int amount;

    public void Awake()
    {
        GameObject lastObs = null;
        int lastIndex = 0;
       for (int i = 0; i < amount; i++)
        {
            int index = getRandomIndex();
            while (index == lastIndex)
            {
                index = getRandomIndex();
            }
            lastIndex = index;
            GameObject obj = Instantiate(obstacles[index].prefab);
            if (lastObs == null)
            {
                obj.transform.position = transform.position;
            } else
            {
                obj.transform.position = lastObs.GetComponent<ObstacleData>().nextPoint.position;
            }
                

            lastObs = obj;
        } 
    }

    public int getRandomIndex()
    {
        return Random.Range(0, obstacles.Length);
    }

}
