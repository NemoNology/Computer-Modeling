extends CharacterBody2D

const g = 9.8;

var _stringLength = 0.2;
var _startAngleDegree = 30;
var _startSpeed = 5;

var frequency: float;
var amplituda: float;
var startPhase: float;

func _on_ready():
	
	Recalculate();



func Recalculate():
	
	frequency = sqrt(_stringLength / g);
	startPhase = atan(-_startSpeed / (_stringLength * frequency * _startAngleDegree));
	amplituda = sqrt(_startAngleDegree**2 + _startSpeed**2 / (_stringLength * frequency)**2);
