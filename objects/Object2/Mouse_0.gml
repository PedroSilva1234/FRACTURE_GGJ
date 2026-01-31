global.conta_obj += 1;

if (global.conta_obj >= 4 && !global.mascara_caos) {
    global.mascara_caos = true;
    // Cria a máscara no local desejado (Instantiate)
    instance_create_layer(x, y, "Instances", obj_mascara_caos);
    show_debug_message("A Máscara do Caos surgiu!");
}

instance_destroy(); // Desativa o objeto clicado