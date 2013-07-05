using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class ChasingState : SKState<SomeClass,StandardDemoStates>
{
	override public StandardDemoStates stateId
	{
		get { return StandardDemoStates.Chasing; }
	}
	
	
	public override void begin()
	{
		Debug.Log( "started chasing" );
	}
	
	
	public override void reason()
	{
		// here we would check to see if what we are chasing is too far. if it is we can pop state
	}
	
	
	public override void update( float deltaTime )
	{
		// do the actual chasing and once complete either pop to the previous state or set it directly
	}

	
	public override void end()
	{
		Debug.Log( "done chasing" );
	}

}
