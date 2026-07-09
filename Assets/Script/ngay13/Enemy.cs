using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData data;

    private float _currentHealh;
    private float _attackPower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _currentHealh =  data.maxHealh;
        _attackPower = data.attackPower;
        gameObject.name = data.enemyName;

        Debug.Log ($"{data.enemyName} có máu tối đa { data.maxHealh} HP , sức mạnh tấn công  { data.attackPower} ATK " );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
