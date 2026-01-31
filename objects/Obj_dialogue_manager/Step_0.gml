
if (visible) {
    
    if (char_index < string_length(speech_text)) {
        char_index += text_speed;
        
        text_current = string_copy(speech_text, 1, floor(char_index));
    }

    
    if (can_close) {
        if (mouse_check_button_pressed(mb_left) || keyboard_check_pressed(vk_space)) {
          
            if (char_index < string_length(speech_text)) {
                char_index = string_length(speech_text);
                text_current = speech_text;
            } else {
                
                visible = false;
            }
        }
    }
}