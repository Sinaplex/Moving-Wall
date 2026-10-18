
using System.Collections;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    [Header("Movement Points")]
    public Transform targetPoint;

    [Header("Timing")]
    public float startDelay = 0f;
    public float moveToTargetTime = 2f;
    public float waitAtTarget = 1f;
    public float moveBackTime = 2f;
    public float waitAtStart = 1f;

    [Header("Options")]
    public bool startAutomatically = true;
    public bool loop = true;

    private Vector3 startPosition;
    private Coroutine moveCoroutine;

    private void Awake()
    {
        startPosition = transform.position;
    }

    private void Start()
    {
        if (startAutomatically)
        {
            moveCoroutine = StartCoroutine(MoveRoutine());
        }
    }

    public void StartMoving()
    {
        if (moveCoroutine == null && targetPoint != null)
        {
            moveCoroutine = StartCoroutine(MoveRoutine());
        }
    }

    private IEnumerator MoveRoutine()
    {
        if (targetPoint == null)
        {
            Debug.LogError("MovingWall: Target Point is not assigned!", this);
            moveCoroutine = null;
            yield break;
        }

        if (startDelay > 0f)
            yield return new WaitForSeconds(startDelay);

        do
        {
            // حرکت از مکان اول به مقصد
            yield return MoveBetween(
                startPosition,
                targetPoint.position,
                moveToTargetTime
            );

            // مکث در مقصد
            if (waitAtTarget > 0f)
                yield return new WaitForSeconds(waitAtTarget);

            // حرکت از مقصد به مکان اول
            yield return MoveBetween(
                targetPoint.position,
                startPosition,
                moveBackTime
            );

            // مکث در مکان اول
            if (waitAtStart > 0f)
                yield return new WaitForSeconds(waitAtStart);

        } while (loop);

        moveCoroutine = null;
    }

    private IEnumerator MoveBetween(
        Vector3 from,
        Vector3 to,
        float duration)
    {
        if (duration <= 0f)
        {
            transform.position = to;
            yield break;
        }

        float timer = 0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;

            float progress = Mathf.Clamp01(timer / duration);

            transform.position = Vector3.Lerp(
                from,
                to,
                progress
            );

            yield return null;
        }

        transform.position = to;
    }
}
