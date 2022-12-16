using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_1 : MonoBehaviour 
{
	private float movementSpeed;
    private int startingPoint = 0;
    public Transform[] points;
    private Transform player;
    private bool patrol=true;
    private int i;
    void Start()
    {
        transform.position = points[startingPoint].position;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        distToPlayer = Vector2.Distance(transform.position, player.position);//dystans do gracza
        if (patrol)
        {
            if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
            {
                i++;
                if(i == points.Length)
                {
                    i = 0;
                }
            }
            transform.position = Vector2.MoveTowards(transform.position, points[i].position, movementSpeed * Time.deltaTime);
        }
        if(distToPlayer < 5f)
        {
            if(Vector2.Distance(transform.position, points[i].position) > 0.2f)//dopóki enemy jest wewnątrz punktów, idzie do gracza
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, movementSpeed * Time.deltaTime);
            }
            patrol=false;
        }
        if(distToPlayer < 5f)
        {
            patrol=true;
        }
    }
}