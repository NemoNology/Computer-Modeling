extends CharacterBody2D


#export var G = 9.81



func _physics_process(delta):
	
	
	speed = delta * G;
	
	if not is_on_floor():
		velocity.y += delta * 100;

	move_and_slide()
