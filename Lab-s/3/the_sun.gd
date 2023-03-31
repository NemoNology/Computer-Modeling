extends StaticBody2D

var G = 6.67384; # Gravity const
var R = 696340000; # metres
var M = 1.989e30; # kg.
var g = 274; # m/s

var testMass = 100;

var startDist = 1;

func _ready():
	
	while (Gravity(testMass) > ):


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass


func Gravity(mass: int):
	
	return G * mass * (M / R**2);
