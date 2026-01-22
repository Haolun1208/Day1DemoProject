using UnityEngine;

public class CountdownChallenge : MonoBehaviour
{
    float timer = 0.0f;
    float waitTime = 1.0f;

    int counter = 10;

    public GameObject Cube;

    void Update()
    {
        if (counter < 0)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            timer -= waitTime;

            Debug.Log("Time left: " + counter);

            if (counter == 0)
            {
                Debug.Log("TIMES UP");
                counter = -1;
                return;
            }

            counter = counter - 1;

                    if (Cube != null)
            {
                Cube.transform.position = Cube.transform.position + new Vector3(-0.2f, 0, 0);
            }
        }
    }
}
