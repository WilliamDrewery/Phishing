using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EmailNames : MonoBehaviour
{
    [SerializeField] public TextMeshPro Name;
   
    // Start is called before the first frame update
    void Start()
    {
        string[] ArrayNames = { "pablo.gonzales2006@bmail.com", "EdithSmith@yahu.com", "MargrettJones@mak.com","JiXingping@CCPemail.com","ZhaoHongShu@BlueNote.com","NigelBlamange@ukipmail.com","EvoRobotnik@eggguy.com","JanettNewham@bmail.com","HenryStickman@Outersloth.com", "BloosCloos@bluemail.com","JohnHalow@bungee.com","Patbaitman@sigma.com","juanramirez2001@bmail.com","Johnnyanime2004@atlace.org"};
        int randomNum = Random.Range(0, ArrayNames.Length);
        Name.text = ArrayNames[randomNum];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
