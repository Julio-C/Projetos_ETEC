<?php

include ('conexao.php');

if (!$conexao) {
    echo "não foi possivel conectar ao banco";
    exit;
} else {
    echo "conexão criada com sucesso";
}
