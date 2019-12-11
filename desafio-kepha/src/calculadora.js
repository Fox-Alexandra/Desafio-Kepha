import React, { Component } from 'react';
import '../src/assets/CSS/style.css';
import poster from '../src/assets/Imagens/poster3.png';

export default class Calculadora extends Component {

    constructor()
    {
        super();

        // this.state = {
        //     valor: "",
        //     unidade: "",
        //     formConversor: {
        //         valor: "",
        //         unidade: "",
        //     }
        // };

        this.state = {
            valor: "",
            unidade: "",
            respValor: "", //estado para o resultado do valor
            respUnidade: "", //estado para o resultado da unidade de medida
        };
    }

    atualizaEstado(event){ //função para a atualização dos valores inseridos nos estados
        event.preventDefault(); //previne a atualização da pág

        if (this.state.unidade === "Litro") { //entrar na função litro
            this.calcLitro()
        } else if (this.state.unidade === "Metro") { //entrar na função metro
            this.calcMetro()
        }
        
    }

    calcMetro() { //função converter metro
        alert("Entrou POrraaa!")
    }

    calcLitro() { //função converter litro
        var respValor = "50"
        var respUnidade = "Onça"
        this.setState({respUnidade: respUnidade}) //recebe a unidade convertida
        this.setState({respValor: respValor}) //recebe o valor convertido
    }

    // // função para cadastrar participante
    // InsercaoValor(event){      
    //     event.preventDefault(); //Previne a atualização da pág

    //     //seta um objeto para os participantes
    //     let Valor = {
    //         valor: this.state.valor,
    //         unidade: this.state.unidade
    //     }

    // }

    
    render() {
        return (
            //div criada para a estilização do body
            <div className="body"> 
            <main>

                <section id="poster"> 
                    <img src={poster} alt="" />
                </section>

                <div className="titulo">
                    <h1>Conversor de medidas</h1>
                </div>

                {/* sessao aonde contém o a calculadora do app */}
                <section id="conteudo">

                    <div className="sombra_titulo"></div>

                    <form 
                        // onSubmit={this.InsercaoValor.bind(this)}
                        name="calculadora" 
                        method="post" 
                        id="formulario">

                        {/* sessao aonde será inserido o valor que deseja ser convertido */}
                        <div className="valor"> 
                            <label htmlFor="valor">Valor que deseja converter<br/></label>
                            <input 
                                value={this.state.valor}
                                type="number" 
                                name="valor" 
                                id="valor"
                                onChange={event => this.setState({valor: event.target.value})}
                            />
                        </div>

                        {/* sessao aonde será selecionado a unidade de medida desejada que deseja ser convertido */}
                        <div className="unidade">
                            <label htmlFor="unidade">Unidade de Medida<br/></label>
                            <select name="unidade" id="unidade"
                                value={this.state.unidade} 
                                onChange={event => this.setState({unidade: event.target.value})}
                            >
                                <option disabled>Unidade</option>
                                <option >Selecione</option>
                                <option>Litro</option>
                                <option>Metro</option>
                                <option>Quilo</option>
                                <option>Graus Celcius (°C)</option>
                            </select>
                        </div>

                        <div id="buttons">
                        <div>
                            <button  className="button_calcular" onClick={this.atualizaEstado.bind(this)}>Calcular</button >
                        </div>
                    </div>
                    </form>

                    <div id="resultado">
                        <p className="vResultado">
                            <span>{this.state.respUnidade}</span> {/* Resultado printado da unidade de medida */}
                            <span>{this.state.respValor}</span> {/* Resultado printado do valor */}
                        </p>
                    </div>

                </section>
            </main>
            </div>
        );
    }
}