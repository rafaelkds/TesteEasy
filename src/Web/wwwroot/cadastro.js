import {Client} from './client';

export class Cadastro {
    //candidato = {};

    cadastrar() {
        if(!this.candidato.horasAteQuatro && !this.candidato.horasQuatroASeis && !this.candidato.horasSeisAOito 
            && !this.candidato.horasAcimaDeOito && !this.candidato.horasFimDeSemana)
            return;

        if(!this.candidato.periodoManha && !this.candidato.periodoTarde && !this.candidato.periodoNoite 
            && !this.candidato.periodoMadrugada && !this.candidato.periodoComercial)
            return;


        new Client().post('candidato', this.candidato, this.sucesso, this.fracasso);
    }

    sucesso(){
        console.log("GRAVOU");
    }

    fracasso(erro){
        console.log(erro);
    }
}