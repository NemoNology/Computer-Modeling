extends CharacterBody2D

const g = 9.8;

var _stringLength = 0.2;
var _startAngleDegree = 30;
var _startSpeed = 5;

var frequency: float;
var amplituda: float;
var startPhase: float;

var isSimulationProcessing: bool = false;


func _on_ready():
	
	
	Recalculate();
	position.y = _stringLength * 3e2;
	Rotate(_startAngleDegree);
	print(position)
	
	

func _physics_process(delta):
	
	if (!isSimulationProcessing):
		return;
		
	
	
	
	

func Recalculate():
	
	frequency = sqrt(_stringLength / g);
	startPhase = atan(-_startSpeed / (_stringLength * frequency * _startAngleDegree));
	amplituda = sqrt(_startAngleDegree**2 + _startSpeed**2 / (_stringLength * frequency)**2);


func Rotate(angleDegree: float):
	
	position = position.rotated(deg_to_rad(angleDegree));
