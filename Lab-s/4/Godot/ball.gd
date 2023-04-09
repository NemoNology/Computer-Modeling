extends CharacterBody2D

const g = 9.8;

var _stringLength = 0.2;
var _startAngleRad = deg_to_rad(30);
var _speed = deg_to_rad(5);

var frequency: float;
var amplituda: float;
var startPhase: float;

var _isSimulationProcessing: bool = false;
var time = 0;



func _on_ready():
	
	position.y = _stringLength * 3e2;
	position.x = 0;
	Rotate(_startAngleRad);
	Recalculate();


func _physics_process(delta):
	
	if (!_isSimulationProcessing):
		return;
	
	_speed = -(g / _stringLength) * sin(Solution(time));
	Rotate(_speed * delta**2);
	time += delta;
	
	

func Recalculate():
	
	frequency = sqrt(_stringLength / g);
	startPhase = atan(-_speed / (_stringLength * frequency * _startAngleRad));
	amplituda = sqrt(_startAngleRad**2 + _speed**2 / (_stringLength * frequency)**2);


func Solution(t: float):
	
	return amplituda * cos(frequency * t + startPhase);

func Rotate(angleRad: float):
	
	position.y = _stringLength * 3e2;
	position.x = 0;
	position = position.rotated(angleRad);


func _on_input_string_length_value_changed(value):

	_stringLength = value;
	_on_stop_pressed();


func _on_input_start_angle_value_changed(value):
	
	_startAngleRad = deg_to_rad(value);
	_on_stop_pressed();


func _on_input_start_speed_value_changed(value):
	
	_speed = deg_to_rad(value);
	_on_stop_pressed();


func _on_start_pressed():
	
	_isSimulationProcessing = true;


func _on_stop_pressed():
	
	_isSimulationProcessing = false;
	Recalculate();
