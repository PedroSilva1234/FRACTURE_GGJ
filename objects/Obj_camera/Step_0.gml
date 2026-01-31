
if (instance_exists(Obj_dialogue_manager)) {
    if (Obj_dialogue_manager.visible) {
        exit; 
    }
}


// 1. Configurações (Equivalente ao Header no C#)
var _pan_speed = 8;        // Velocidade da câmera
var _edge_size = 30;       // Margem em pixels para detectar o mouse nas bordas

// 2. Pegar a posição atual da câmera e dimensões da view
var _cam = view_camera[0];
var _cam_x = camera_get_view_x(_cam);
var _cam_y = camera_get_view_y(_cam);
var _cam_w = camera_get_view_width(_cam);
var _cam_h = camera_get_view_height(_cam);

// 3. Pegar posição do mouse na janela (Não na Room!)
var _mouse_x = window_mouse_get_x();
var _mouse_y = window_mouse_get_y();

// 4. Lógica de movimento (Baseada no script do Pedro)
if (_mouse_x < _edge_size) _cam_x -= _pan_speed;                         // Esquerda
if (_mouse_x > window_get_width() - _edge_size) _cam_x += _pan_speed;     // Direita
if (_mouse_y < _edge_size) _cam_y -= _pan_speed;                         // Cima
if (_mouse_y > window_get_height() - _edge_size) _cam_y += _pan_speed;    // Baixo

// 5. Aplicar o Clamp (Garantir que a câmera não saia da Room)
// A lógica é: x deve estar entre 0 e (Largura da Sala - Largura da Câmera)
_cam_x = clamp(_cam_x, 0, room_width - _cam_w);
_cam_y = clamp(_cam_y, 0, room_height - _cam_h);

// 6. Atualizar a posição da câmera
camera_set_view_pos(_cam, _cam_x, _cam_y);