grafico.css
    .grafico_ {
    width: 100 %; /*tamanho lateral do gráfico*/
    background - color: aliceblue;
    height: 200px; /*altura do gráfico, proporcional a 10 itens*/
}

.mes {
    width: 15 %;
    background - color: antiquewhite;
    height: 20px; /*se alterar altura, alterar também altura da tabela*/
    float: left;
}
.valor {
    width: 85 %;
    background - color: lightblue;
    height: 20px; /*altura igual a da classe Busca_nome*/
    float: right;
}
.mes_centralizado {
    position: relative;
    top: 50 %;
    transform: translateY(-50 %);
    text - align: center;
}
.barra_width {
    background - color: black;
    height: 14px;
    color: white;
    position: relative;
    top: 50 %;
    transform: translateY(-50 %);
    font - size: 12px;

}