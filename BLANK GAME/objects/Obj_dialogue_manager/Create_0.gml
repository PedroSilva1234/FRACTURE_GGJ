/// @description Inicialização do Gerenciador
visible = false;         // A caixa começa invisível
can_close = false;       // Trava de segurança para o fechamento
speech_text = "";        // Variável que guarda o texto atual
actor_name = "";         // Variável que guarda o nome do personagem

// Função global que os botões chamam para iniciar o diálogo
global.show_speech = function(_sprite, _text, _name) {
    with(Obj_dialogue_manager) { 
        visible = true;
        speech_text = _text;
        actor_name = _name;
        
        // Resetamos a trava e iniciamos o alarme toda vez que abrir
        can_close = false; 
        alarm[0] = 10; // Espera 10 frames (~1/6 de segundo) para permitir fechar
    }
}