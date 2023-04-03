extends Line2D

var point = Vector2.ZERO;

func _ready():
	
	width = 1;
	

func _physics_process(delta):
	
	point = get_parent().position;
	
	clear_points();
	add_point(Vector2.ZERO);
	add_point(point.rotated(deg_to_rad(180)));
