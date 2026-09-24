using UnityEngine;

public class OrcScript : EnemyBase
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
        //print("Orc is attacking player");
        OuputText("Orc is attacking player");
    }
}
