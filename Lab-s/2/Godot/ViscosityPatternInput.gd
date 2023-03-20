extends ItemList

# Values taken from https://en.wikipedia.org/wiki/List_of_viscosities
var Viscosities = {
	
	"Ammonia": 10.07e-6,
	"Air": 18.46e-6,
	"Water": 1.0016e-3,
	"Glycerol": 1.412,
	"Mercury": 1.526e-3,
	"Milk": 2.12e-3,
	"Sunflower oil": 48.8e-3,
	"Olive oil": 56.2e-3,
	"Honey": 6
};

signal OnViscositySelect(viscosityValue: float)

func _ready():
	
	for item in Viscosities:
		
		add_item(item);
		
	select(0);
	OnViscositySelect.emit(Viscosities["Ammonia"]);


func _on_item_selected(index):
	
	OnViscositySelect.emit(Viscosities[get_item_text(index)])
	
