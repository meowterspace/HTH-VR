#pragma strict
var reindeer : Animator;

function Start () {

}

function Update () {
if(Input.GetKey(KeyCode.Alpha1)){
reindeer.SetBool("Idle",true);
reindeer.SetBool("Walk",false);
}
if(Input.GetKey(KeyCode.Alpha2)){
reindeer.SetBool("Walk",true);
reindeer.SetBool("Idle",false);
reindeer.SetBool("Backward",false);
}
if(Input.GetKey(KeyCode.Alpha3)){
reindeer.SetBool("Backward",true);
reindeer.SetBool("Walk",false);
reindeer.SetBool("Idle",false);
}
if(Input.GetKey(KeyCode.Alpha4)){
reindeer.SetBool("Trotting",true);
reindeer.SetBool("Backward",false);
reindeer.SetBool("Walk",false);
reindeer.SetBool("Idle",false);
}
if(Input.GetKey(KeyCode.Alpha5)){
reindeer.SetBool("Galloping",true);
reindeer.SetBool("Trotting",false);
}
if(Input.GetKey(KeyCode.Alpha6)){
reindeer.SetBool("Eating",true);
reindeer.SetBool("Galloping",false);
}
if(Input.GetKey(KeyCode.Alpha7)){
reindeer.SetBool("Lay",true);
reindeer.SetBool("Eating",false);
reindeer.SetBool("Up",false);
}
if(Input.GetKey(KeyCode.Alpha8)){
reindeer.SetBool("Lay",false);
reindeer.SetBool("Up",true);
}
if(Input.GetKey(KeyCode.Alpha9)){
reindeer.SetBool("Up",false);
reindeer.SetBool("Attack1",true);
reindeer.SetBool("Attack2",false);
reindeer.SetBool("Die",false);
}
if(Input.GetKey(KeyCode.Alpha0)){
reindeer.SetBool("Attack1",false);
reindeer.SetBool("Attack2",true);
reindeer.SetBool("Die",false);
}
if(Input.GetKey(KeyCode.Keypad0)){
reindeer.SetBool("Attack2",false);
reindeer.SetBool("Attack1",false);
reindeer.SetBool("Die",true);
}
}