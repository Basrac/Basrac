using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // �浹�� ������Ʈ�� "Player" �±׸� ������ �ִٸ� ��Ȱ��ȭ �ڷ�ƾ�� �����մϴ�.
            StartCoroutine(DeactivateCloudAfterDelay(2.0f)); // 2�� �ڿ� ��Ȱ��ȭ
        }
    }

    private IEnumerator DeactivateCloudAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        // 2�� �Ŀ� ������ ��Ȱ��ȭ�մϴ�.
        gameObject.SetActive(false);
    }
}
