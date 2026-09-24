using UnityEngine;

public class FriendlyOrcScript : OrcScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void AttackPlayer()
    {
        
        text.text = ("Friendly Orc is attacking player");
    }
}
