using System;

public class MeleeEnemy : DefaultEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        // ���g�̎��ӂɋߋ����G�l�~�[��3,4��������
        Random rand = new System.Random();
        int spawnRandNum = rand.Next(3, 5);

        // ���������͌�قǒǉ�
        for (int i = 0; i < spawnRandNum; i++)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        
    }
}
