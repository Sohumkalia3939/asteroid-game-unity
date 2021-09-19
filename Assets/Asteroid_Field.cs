using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Field : MonoBehaviour
{
    public GameObject enemy;
    public Controller controller;

    public float x;
    public float z;
    public float y;
    public float enemycount;
    public GameObject player;
    public float AmountToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<Controller>();

        //asteroid.SetActive(false);
        StartCoroutine(EnemyDrop());

    }
   void Update()
    {
        Debug.Log("Player position is: " + player.transform.position.y);

    }

    IEnumerator EnemyDrop()
    {
        while (enemycount < AmountToSpawn* controller.runspeed)
        {
            x = Random.Range(-1.77f, 1.77f);
            z = Random.Range(-300, 1);
            y = Random.Range(10, 400);
            Instantiate(enemy, new Vector3(x, player.transform.position.y+y, player.transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            int move = (int)controller.moveSpeed;
            //enemycount += 1*move;
            enemycount += 3f * Time.deltaTime;

        }

    }
}


