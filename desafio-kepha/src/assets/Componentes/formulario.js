import React, { Component } from 'react';


export default class Formulario extends Component {

    constructor()
    {
        super();

        this.state = {
            valor: "",
            unidade: "",
            respValor1: "", //estado para o resultado do valor
            respUnidade1: "", //estado para o resultado da unidade de medida
            respValor2: "", //estado para o resultado do valor convertido para a segunda unidade de medida
            respUnidade2: "", //estado para o resultado da segunda unidade de medida
        };
    }

    atualizaEstado(event){ //função para a atualização dos valores inseridos nos estados
        event.preventDefault(); //previne a atualização da pág

        if (this.state.unidade === "Litro") { //entrar na função litro
            this.calcLitro()
        } else if (this.state.unidade === "Metro") { //entrar na função metro
            this.calcMetro()
        } else if (this.state.unidade === "Quilo") {
            this.calcQuilo()
        } else if (this.state.unidade === "Graus Celcius (°C)") {
            this.calcGraus()
        } else if (this.state.valor === "") {
            alert("Por favor, insira um valor!")
        }else {
            alert("Por favor, selecione a unidade de medida que deseja converter!")
        }
        
    }

    calcLitro() { //função converter litros
        var respValor1 = (this.state.valor * 33.814)+" us fl oz"
        var respUnidade1 = "Onça: "
        this.setState({respUnidade1: respUnidade1}) //recebe a unidade convertida
        this.setState({respValor1: respValor1}) //recebe o valor convertido

        var respValor2 = (this.state.valor * 0.26417)+" us gal lqd"
        var respUnidade2 = "Galões: "
        this.setState({respUnidade2: respUnidade2}) //recebe a unidade convertida
        this.setState({respValor2: respValor2}) //recebe o valor convertido
    }

    calcMetro() { //função converter metros
        var respValor1 = (this.state.valor * 0.00062137)+" mi"
        var respUnidade1 = "Milhas"
        this.setState({respUnidade1: respUnidade1}) //recebe a unidade convertida
        this.setState({respValor1: respValor1}) //recebe o valor convertido

        var respValor2 = (this.state.valor * 3.2808)+" ft"
        var respUnidade2 = "Pés"
        this.setState({respUnidade2: respUnidade2}) //recebe a unidade convertida
        this.setState({respValor2: respValor2}) //recebe o valor convertido
    }

    calcQuilo() { //função converter quilos
        var respValor1 = (this.state.valor *  2.2046)+" lb"
        var respUnidade1 = "Libras: "
        this.setState({respUnidade1: respUnidade1}) //recebe a unidade convertida
        this.setState({respValor1: respValor1}) //recebe o valor convertido

        var respValor2 = (this.state.valor * 35.274)+"oz"
        var respUnidade2 = "Onças: "
        this.setState({respUnidade2: respUnidade2}) //recebe a unidade convertida
        this.setState({respValor2: respValor2}) //recebe o valor convertido
    }

    calcGraus() { //função converter graus
        var respValor1 = (this.state.valor * (1) +  273.15 )+" K"
        var respUnidade1 = "Kelvin: "
        this.setState({respUnidade1: respUnidade1}) //recebe a unidade convertida
        this.setState({respValor1: respValor1}) //recebe o valor convertido

        var respValor2 = (this.state.valor * (9/5) + 32)+" °F"
        var respUnidade2 = "Fahrenheit: "
        this.setState({respUnidade2: respUnidade2}) //recebe a unidade convertida
        this.setState({respValor2: respValor2}) //recebe o valor convertido
    }

    render() {
        return (
            <>
                <form 
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
            </>
        );
    }

}

export default Formulario;
