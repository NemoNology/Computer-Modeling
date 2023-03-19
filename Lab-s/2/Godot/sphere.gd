extends CharacterBody2D

var posX = 360;
var posY = 260;

var G = 9.81;

var _speed;
var _mass = 1; 
var _gravity;
var _radius = 0.5;
var _viscosity = 0.48e-5;

var _time = 0.0;

signal OnSimulationStop;
signal OnSimulateProcess(newTime);


func SimulationStart():
	
	_time = 0.0;
	position.x = posX;
	position.y = posY;
	_gravity = _mass * G;
	_speed = (_gravity - (6 * PI * _viscosity * _radius)) / _mass;
	velocity.y = _speed;


func _physics_process(delta):
	
	if (velocity.y == 0):
		
		return;
	
	_speed = (_gravity - (6 * PI * _viscosity * _radius) * velocity.y) / _mass;
	
	if not is_on_floor():
		velocity.y += delta * _speed;

	move_and_slide()
	
	OnSimulateProcess.emit(_time);
	_time += delta;

func SimulationStop():
	
	velocity.y = 0;


func _on_collision_body_entered(body):
	
	OnSimulationStop.emit();
	SimulationStop();
	
