using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBuildings : MonoBehaviour {
	public ParticleSystem ps;

	public List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle> ();

	void OnEnable(){
		ps = GetComponent<ParticleSystem> ();
	}

	void OnParticleTrigger(){

		int enterParticleNumber = ps.GetTriggerParticles (ParticleSystemTriggerEventType.Exit, enter);


		for (int i = 0; i < enterParticleNumber; i++) {
			ParticleSystem.Particle p = enter [i];
			p.startColor = new Color32 (255, 0, 0, 255);
			enter [i] = p;
			Debug.Log ("Done");
		}

		ps.SetTriggerParticles (ParticleSystemTriggerEventType.Exit, enter);
	}

	void Update(){
		Debug.Log(ps.transform.localScale);
		Debug.Log (ps.transform.localPosition);
	}
}
