using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Prefab for dropping apples
    public GameObject applePrefab;
    
    // edges of screen
    [Header("Directions")]
   
    public float chanceToChange = .1f;
    public float speed = 1f;
    public float leftSide;
    public float rightSide;

    [Header("Drop Time")]
    public float timeBetDrop = 1f;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropApple", 3f, timeBetDrop);
    }
    
    // Update is called once per frame
    void Update()
    {
        //Movement
        Vector3 treePos = transform.position;
        treePos.x += speed * Time.deltaTime;
        transform.position = treePos;
        //Changes directions when tree hits edges or randomly
        if(Random.value <= chanceToChange || treePos.x > rightSide || treePos.x < leftSide)
        {
            speed = speed * -1;
        }



    }
    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }

    

}

