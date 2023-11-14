using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 충돌한 오브젝트가 "Player" 태그를 가지고 있다면 비활성화 코루틴을 시작합니다.
            StartCoroutine(DeactivateCloudAfterDelay(2.0f)); // 2초 뒤에 비활성화
        }
    }

    private IEnumerator DeactivateCloudAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        // 2초 후에 구름을 비활성화합니다.
        gameObject.SetActive(false);
    }
}
