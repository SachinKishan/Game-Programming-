using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDungeonTravel : MonoBehaviour
{
	[SerializeField]GameObject currentDungeon;
	bool canMove=true;
	
    // Start is called before the first frame update
    void Start()
    {
	
	
    }

    // Update is called once per frame
    void Update()
    {
	PlayerInput();        
    }

	void PlayerInput()
	{
		 if(Input.GetKeyDown(KeyCode.Space)&&canMove)
        	{
            		Generator.main.InstantiateDungeon();
			currentDungeon=Generator.main.currentDungeon;
			//StartCoroutine(LerpPosition(currentDungeon.transform.position,1f));
        	}
	}

    IEnumerator LerpPosition(Vector2 targetPosition, float duration)
    {
	canMove=false;
        float time = 0;
        Vector2 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector2.Lerp(startPosition,new Vector2(targetPosition.x,targetPosition.y), time / duration);
            time += Time.deltaTime;
            yield return null;
        }
	canMove=true;        
        transform.position = targetPosition;
    }
}
