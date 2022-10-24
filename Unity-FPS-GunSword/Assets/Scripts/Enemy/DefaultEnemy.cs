using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �G�̃x�[�X�ɂȂ�e�N���X
public class DefaultEnemy : MonoBehaviour
{
    // ���F����
    [SerializeField] private float sightDistance = 100.0f;
    // �����̃X�s�[�h
    [SerializeField] private float walkSpeed = 10.0f;
    // ����̃X�s�[�h
    [SerializeField] private float runSpeed = 30.0f;
    // ���݂̎���
    [SerializeField] private float stunTime = 3.0f;
    // �Ƃ肠���������Ă��� ���łɂ����鎞��
    [SerializeField] private float deadTime = 3.0f; 

    // Start is called before the first frame update
    void Start()
    {
        // �G���[���Ȃ������߂̂���
        sightDistance = 100.0f;
        walkSpeed = 10.0f;
        runSpeed = 30.0f;
        stunTime = 3.0f;
        deadTime = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
