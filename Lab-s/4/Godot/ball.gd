extends CharacterBody2D

const g = 9.81;

var _stringLength = 0.2;
var _startAngleRad = deg_to_rad(30);
var _startSpeed = deg_to_rad(5);


var _speed;
var frequency: float;
var amplituda: float;
var startPhase: float;

var _isSimulationProcessing: bool = false;
var time = 0;

signal OnForDiagnostic(time: float, _speed: float);

func _on_ready():
	
	position.y = _stringLength * 3e2;
	position.x = 0;
	position = position.rotated(_startAngleRad);
	Recalculate();
	OnForDiagnostic.emit(time, _speed);


func _physics_process(delta):
	
	if (!_isSimulationProcessing):
		return;
	
	_speed = -(g / _stringLength) * sin(Solution(time));
	
	OnForDiagnostic.emit(time, _speed);
	
	position = position.rotated(_speed * delta**2);
	time += delta;


func Recalculate():
	
	frequency = sqrt(_stringLength / g);
	startPhase = atan(-_startSpeed / (_stringLength * frequency * _startAngleRad));
	amplituda = sqrt(_startAngleRad**2 + _startSpeed**2 / (_stringLength * frequency)**2);


func Solution(t: float):
	
	return amplituda * cos(frequency * t + startPhase);

func _on_input_string_length_value_changed(value):

	_stringLength = value;
	_on_stop_pressed();


func _on_input_start_angle_value_changed(value):
	
	_startAngleRad = deg_to_rad(value);
	_on_stop_pressed();


func _on_input_start_speed_value_changed(value):
	
	_startSpeed = deg_to_rad(value);
	_on_stop_pressed();


func _on_start_pressed():
	
	_isSimulationProcessing = true;


func _on_stop_pressed():
	
	_isSimulationProcessing = false;
	position.y = _stringLength * 3e2;
	position.x = 0;
	position = position.rotated(_startAngleRad);
	time = 0;
	_speed = 0;
	OnForDiagnostic.emit(time, _startSpeed);
	Recalculate();
