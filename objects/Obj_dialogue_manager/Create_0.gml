
visible = false;  
can_close = false; 
speech_text = ""; 
actor_name = ""; 
text_current = ""; 
char_index = 0;
text_speed = 0.5; 


global.show_speech = function(_sprite, _text, _name) {
    with(Obj_dialogue_manager) { 
        visible = true;
        speech_text = _text;
        actor_name = _name;
		
		
		text_current = "";
        char_index = 0;
        
        
        can_close = false; 
        alarm[0] = 10; 
    }
}