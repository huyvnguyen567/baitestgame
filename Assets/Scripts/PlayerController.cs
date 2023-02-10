using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bulletPrefabs;
    float time = 0;
    public float delayTime = 0.1f;
    
    void Update()
    {
        Move();
        SpawnBullet();
    }
    //Player di chuyển được trên màn hình
    private void Move()
    {
        float horInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(horInput, verInput, 0);
        if (transform.position.x >= 3.8f)
        {
            transform.position = new Vector3(3.8f, transform.position.y, 0);
        }
        if (transform.position.x <= -3.8f)
        {
            transform.position = new Vector3(-3.8f, transform.position.y, 0);
        }
        if (transform.position.y <= -8.6f)
        {
            transform.position = new Vector3(transform.position.x, -8.6f, 0);
        }
        if (transform.position.y <= -8.6f)
        {
            transform.position = new Vector3(transform.position.x, -8.6f, 0);
        }
        if (transform.position.y >= 8.6f)
        {
            transform.position = new Vector3(transform.position.x, 8.6f, 0);
        }
    }
    //Player bắn ra đạn với chu kì 0.1s sẽ sinh ra 1 viên đạn
    private void SpawnBullet()
    {
        time = time + Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (time > delayTime)
            {
                Instantiate(bulletPrefabs, transform.position + new Vector3(0, 1.7f, 0), Quaternion.identity);
                time = 0;
            }
        }
    }    
}
