using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UIElements;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] float speed = 5; //platform vel
    [SerializeField] int startingPoint; //determinador pto inicio
    [SerializeField] Transform[] points; //[] array
    int i; //index indice array = pto persigue
    [SerializeField] bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        //Al inicio la platform se tp = valor startingPoint
        transform.position = points[startingPoint].position;
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        
    }
    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
        isFacingRight = !isFacingRight;
    }

    void MoveEnemy()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            Flip();
            i++; //suma 1 al valor del indice, persigue sig pto
            if (i == points.Length) i = 0; //resetea circuito ptos
        }

        //mueve platform a punto array que sea = al valor i
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
