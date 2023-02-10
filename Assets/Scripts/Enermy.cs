using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public GameObject enermys;
    public List<WaveSO> waveSO;
    private int index =0;

    public float enermySpeed;

    private float time = 0;
    public float delayTime = 5;

    bool canDestroy = false;
    bool canMove = true;


    void Update()
    {
        EnermyFollowPath();
    }
    public bool CanDestroy()
    {
        return canDestroy;
    }    
    private void EnermyFollowPath()
    {
        time += Time.deltaTime;
        //Kẻ thù di chuyển thành hình chữ nhật
        if (time >= delayTime + 10 && canMove)
        {
            for (int i = 0; i < enermys.transform.childCount; i++)
            {
                enermys.transform.GetChild(i).position = Vector2.MoveTowards(enermys.transform.GetChild(i).position, waveSO[index + 3].GetWayPoints()[i].position, enermySpeed * Time.deltaTime);
            }
            if(time >= delayTime + 13)
            {
                canMove = false;
                canDestroy = true;
            }    

        }
        //Kẻ thù di chuyển thành hình tam giác
        else if (time >= delayTime + 5 && canMove)
        {
            for (int i = 0; i < enermys.transform.childCount; i++)
            {
                enermys.transform.GetChild(i).position = Vector2.MoveTowards(enermys.transform.GetChild(i).position, waveSO[index + 2].GetWayPoints()[i].position, enermySpeed * Time.deltaTime);
            }
        }
        //Kẻ thù di chuyển thành hình thoi
        else if (time >= delayTime && canMove)
        {
            for (int i = 0; i < enermys.transform.childCount; i++)
            {
                enermys.transform.GetChild(i).position = Vector2.MoveTowards(enermys.transform.GetChild(i).position, waveSO[index + 1].GetWayPoints()[i].position, enermySpeed * Time.deltaTime);
            }
        }
        //Kẻ thù di chuyển thành hình vuông
        else if (time < delayTime && canMove)
        {
            
            for (int i = 0; i < enermys.transform.childCount; i++)
            {
                enermys.transform.GetChild(i).position = Vector2.MoveTowards(enermys.transform.GetChild(i).position, waveSO[index].GetWayPoints()[i].position, enermySpeed * Time.deltaTime);
            }
        }
    }    
}
