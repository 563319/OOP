using TMPro;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
        OuputText("Enemy is attacking player");
    }
    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
        //DebugText("");
    }
    protected void OuputText(string input)
    {
        text.text = input;
    }
    
}
