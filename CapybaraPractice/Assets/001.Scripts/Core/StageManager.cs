using UnityEngine;

public class StageManager : MonoBehaviour
{
    private static StageManager instance;
    public static StageManager Instance 
    { 
        get 
        {
            return instance;
        }
    }

    public int nowLevel;

    public void CheckMoveToNextLevel()
    {

    }
}

public class StageData
{
    public int maxLevel;
    public EnemyData[] enemyDatas;
}
