/// @description Lógica de fechar a caixa
if (visible && can_close) {
    // Verifica se o jogador clicou com o mouse ou apertou Espaço
    if (mouse_check_button_pressed(mb_left) || keyboard_check_pressed(vk_space)) {
        visible = false;
        can_close = false; // Bloqueia novamente para o próximo diálogo
    }
}