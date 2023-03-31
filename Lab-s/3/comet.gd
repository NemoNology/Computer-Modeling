extends CharacterBody2D


var koef = 3e-13;

var G = 6.67e-11;
var M = 1.98892e+30;

var _X = 840;
var _Y = 472;

var _speed = 10;
var _alpha = 30;

signal on_silulation_end();
signal on_move(x, y, vx, vy);

func _ready():
	
	velocity = Vector2(0, 0);

func SimulationStart():
	
	SimulationStop();
	
	velocity.x = koef * _speed * 0.5;
	velocity.y = -koef * _speed * 0.5;


func _physics_process(delta):
	
	on_move.emit(position.x, position.y, velocity.x, velocity.y);
	
	if velocity == Vector2.ZERO:
		return;
		
	var x = position.x;
	var y = position.y;
	
	var fb = koef * -G * M * 1 / (sqrt(x * x + y * y)**3) * delta;
		
	velocity.x += fb * x;
	velocity.y += fb * y;

	move_and_slide()


func SimulationStop():
	
	on_silulation_end.emit();
	position = Vector2(_X, _Y);
	velocity = Vector2.ZERO;


func _on_input_speed_value_changed(value):
	
	_speed = value;
	SimulationStop();


func _on_start_pressed():
	
	SimulationStart();


func _on_stop_pressed():
	
	SimulationStop();
	
