extends SpinBox


func _ready():
	
	value = 10;
	value_changed.emit(value);
