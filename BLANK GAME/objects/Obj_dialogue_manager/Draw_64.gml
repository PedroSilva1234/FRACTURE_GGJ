/// @description Desenho da Interface (Fixa na tela)
if (visible) {
    var _box_x = 100; // Posição X da caixa na tela
    var _box_y = 500; // Posição Y da caixa na tela
    
    // 1. Desenha o fundo (O sprite que você criou)
    draw_sprite(spr_dialogue_box, 0, _box_x, _box_y); 

    // 2. Configurações de Texto
    draw_set_color(c_white); // Cor do texto
    draw_set_font(-1);       // Usa a fonte padrão do GameMaker
    draw_set_halign(fa_left); // Alinhamento à esquerda

    // 3. Desenha o Nome e a Fala
    var _margin = 40;
    draw_text(_box_x + _margin, _box_y + 30, actor_name);
    
    // Desenha o texto com quebra de linha automática (largura max: 600)
    draw_text_ext(_box_x + _margin, _box_y + 70, speech_text, 20, 600);
}