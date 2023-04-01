extends Area2D


var G = 6.67e-11;
var M = 1.98892e+30;

var _X = -450;
var _Y = 0;

var _speed = 10;
var _alpha = 30;

var vx = 0;
var vy = 0;

signal on_silulation_start();
signal on_move(x, y, vx, vy);

func _ready():
	
	position = Vector2(_X, _Y);

func SimulationStart():
	
	position = Vector2(_X, _Y);
	
	vy = _speed * 0.5;
	vx = sqrt(_speed * _speed - vy * vy);
	
	on_move.emit(position.x, position.y, vx, vy);
	on_silulation_start.emit();


func _physics_process(delta):
	
	if vx == 0 and vy == 0:
		return;
		
	on_move.emit(position.x, position.y, vx, vy);
		
	var x = position.x;
	var y = position.y;
		
	vx = velo(vx, x, y, delta**2);
	vy = velo(vy, y, x, delta**2);

	position.x += vx * 3 * delta;
	position.y += vy * 3 * delta;	

func velo(vel: float, mainPos: float, secondPos: float, Dt: float):
	
	var k = sqrt(mainPos * mainPos + secondPos * secondPos);
	
	return (vel - (mainPos / (k**3) / Dt));


func SimulationStop():
	
	vx = 0;
	vy = 0;

func _on_body_entered(body):
	
	SimulationStop();

func _on_input_speed_value_changed(value):
	
	_speed = value;
	SimulationStop();


func _on_start_pressed():
	
	SimulationStart();


func _on_stop_pressed():
	
	SimulationStop();
	
