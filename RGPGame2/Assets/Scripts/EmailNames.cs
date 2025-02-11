using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EmailNames : MonoBehaviour
{
    [SerializeField] public TextMeshPro Name;
    float time;
    public GameObject Email;
    [SerializeField] public Rigidbody2D RB;
    public Vector2 Direction;
    public Vector2 speed;
   
    // Start is called before the first frame update
    void Start()
    {
        string[] ArrayNames = { "pablo.gonzales2006@bmail.com", "EdithSmith@yahu.com", "MargrettJones@mak.com","JiXingping@CCPemail.com","ZhaoHongShu@BlueNote.com",
            "NigelBlamange@ukipmail.com","EvoRobotnik@eggguy.com","JanettRackham@bmail.com","HenryStickman@Outersloth.com", "BloosCloos@bluemail.com","JohnHalow@bungee.com","Patbaitman@sigma.com","juanramirez2001@bmail.com","Johnnyanime2004@atlace.org"};
        int randomNum = Random.Range(0, ArrayNames.Length);
        Name.text = ArrayNames[randomNum];
        Direction=new Vector2 (Random.Range(-1f,1f), Random.Range(-1f,1f));
        time = 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2)
        {
            speed = new Vector2(Random.Range(1,3), Random.Range(1,3));
            RB.velocity = speed*Direction;
            Direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            
            time = 0;
            
        }
        print(time);
    }
}
