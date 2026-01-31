
if (visible) {
    var _screen_w = display_get_gui_width();
    var _box_w = 800;
    var _box_h = 180;
    var _box_x = (_screen_w - _box_w) / 2; 
    var _box_y = 540; 
    
   
    draw_sprite_stretched(spr_dialogue_box, 0, _box_x, _box_y, _box_w, _box_h);

   
    draw_set_font(-1); 
    
    
    draw_set_color(c_yellow);
    draw_text(_box_x + 40, _box_y + 25, ">> " + string_upper(actor_name));

    
    draw_set_color(c_white);
   
    draw_text_ext(_box_x + 40, _box_y + 70, text_current, 25, _box_w - 80);
}