extends Line2D

var point = Vector2();

func _process(delta):
	
	global_position = Vector2(0, 0);
	global_rotation = 0;
	
	point = get_parent().global_position;
	
	add_point(point)
	



func _on_comet_on_silulation_start():
	
	clear_points();
