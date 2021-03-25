using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected const string PLAYER_NAME = "Player";

    protected Vector3 MoveDirection = Vector3.zero;
    public float Velocity = 5;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, 10);

        if( rand < 3)
        {
            var target_player = GameObject.Find(PLAYER_NAME);

            if(target_player != null)
            {
                MoveDirection = target_player.transform.position - transform.position;
                MoveDirection.Normalize();
            }
        }

        if(MoveDirection.Equals(Vector3.zero))
        {
            MoveDirection = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MoveDirection * Velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
