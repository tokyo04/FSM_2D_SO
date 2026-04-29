using UnityEngine;

[CreateAssetMenu(menuName = "FSM/Idle")]
public class IdleStateSO : StateSO
{
    public StateSO chaseState;
    public override void Enter(EnemyController Enemy)
    {
        Debug.Log("Idle");
    }

    public override void Execute(EnemyController Enemy)
    {
        if (Enemy.DistanceToPlayer() <Enemy.chaseRange)
        {
            Enemy.ChangeState(chaseState);
        }
    }
    public override void Exit(EnemyController Enemy){}
}
