using UnityEngine;


public class DragonScript : EnemyBase
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackPlayer();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void AttackPlayer()
    {
        //print("Dragon is attacking player");
        OuputText("Dragon is attacking player");
    }
}

