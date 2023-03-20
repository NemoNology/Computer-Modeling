extends LineEdit

func _ready():
	
	text = "0";

func _on_viscosity_pattern_input_on_viscosity_select(viscosityValue):
	
	text = str(viscosityValue);
	text_changed.emit(text);
