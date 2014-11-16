using UnityEngine;
using System.Collections;

public class PlantBite {//: MonoBehaviour {
	//#pragma strict

	//private HingeJoint jawTop;// : HingeJoint;
	//private var jawBottom : HingeJoint;
	//private var isBiting : boolean;

	public HingeJoint jawTop;
	public HingeJoint jawBottom;
	public bool isBiting;

	void Start () {
		this.isBiting = false;
		HingeJoint[] joints = GetComponentsInChildren(HingeJoint);
		foreach (HingeJoint joint in joints) {
			if(joint.name == "instance_0") {
				this.jawBottom = joint;
			} else if(joint.name == "instance_1") {
				this.jawTop = joint;
			}
		}
	}

	void Update () {
		if(this.isBiting)
		{
			if(jawTop.motor.targetVelocity < 0) {
				if(jawTop.angle <= -39) {
					jawTop.motor.targetVelocity = 50;
					jawTop.motor.force = 10;
				}
			}
			else if(jawTop.motor.targetVelocity > 0) {
				if(jawTop.angle >= 0) {
					stopBite();
				}
			}
			
			if(jawBottom.motor.targetVelocity > 0) {
				if(jawBottom.angle >= 39) {
					jawBottom.motor.targetVelocity = -50;
					jawBottom.motor.force = 10;
				}
			}
			else if(jawBottom.motor.targetVelocity < 0) {
				if(jawBottom.angle <= 0) {
					stopBite();
				}
			}
		}
	}

	void bite() {
		if(!this.isBiting)
		{
			this.isBiting = true;
			jawTop.rigidbody.freezeRotation = false;
			jawBottom.rigidbody.freezeRotation = false;
		
			jawTop.useMotor = true;
			jawTop.useSpring = false;
			jawBottom.useMotor = true;
			jawBottom.useSpring = false;
			
			jawTop.motor.targetVelocity = -500;
			jawBottom.motor.targetVelocity = 500;
			
			jawTop.motor.force = 100;
			jawBottom.motor.force = 100;
		}
	}

	void stopBite() {
		isBiting = false;
		
		jawTop.motor.force = 0;
		jawBottom.motor.force = 0;
		jawTop.motor.targetVelocity = 0;
		jawBottom.motor.targetVelocity = 0;
		
		jawTop.useMotor = false;
		jawTop.useSpring = true;
		
		jawBottom.useMotor = false;
		jawBottom.useSpring = true;
		
		jawTop.rigidbody.freezeRotation = true;
		jawBottom.rigidbody.freezeRotation = true;
	}
}