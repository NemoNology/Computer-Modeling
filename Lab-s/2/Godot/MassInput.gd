extends SpinBox


func _ready():
	
	value_changed.emit(1.0);
