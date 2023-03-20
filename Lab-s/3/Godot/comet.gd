extends CharacterBody2D


var G = 6.67e-11;
var M = 1.98892e+30;

var _X = 320;
var _Y = 320;

var _speed:float = 10;
var _alpha = 30;

signal on_silulation_end();

func _ready():
	
	velocity = Vector2(0, 0);

func SimulationStart():
	
	position = Vector2(_X, _Y);
	
	velocity.x = sin(deg_to_rad(_alpha)) * _speed;
	velocity.y = sqrt(_speed * _speed - velocity.x * velocity.x);


func _physics_process(delta):
	
	if velocity == Vector2.ZERO:
		
		return;
		
	velocity.x = G * M * position.x / (sqrt(pow(position.x * position.x + position.y * position.y, 3)));
	velocity.y = -G * M * position.y / (sqrt(pow(position.x * position.x + position.y * position.y, 3)));
	
	velocity.x *= delta;
	velocity.y *= delta;

	move_and_slide()


func SimulationStop():
	
	position = Vector2(_X, _Y);
	velocity = Vector2(0, 0);


func _on_input_speed_value_changed(value):
	
	_speed = value;
	SimulationStop();


func _on_start_pressed():
	
	SimulationStart();


func _on_stop_pressed():
	
	SimulationStop();
	on_silulation_end.emit();
	
