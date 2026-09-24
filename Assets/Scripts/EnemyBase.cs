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
        text.text = ("Enemy is attacking player");
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
    
}
