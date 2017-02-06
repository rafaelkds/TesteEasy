import {Client} from './client';

export class Cadastro {
        
    constructor(){
        this.niveisConhecimento = [0, 1, 2, 3, 4, 5];
        this.pagina = 1;
    }

    activate(params) {
        new Client().get('candidato/'+params.id)
            .then(data => this.candidato = data.data)
            .catch(data => {
                console.log(data)
            });
    }

    cadastrar() {
        if(!this.candidato.horasAteQuatro && !this.candidato.horasQuatroASeis && !this.candidato.horasSeisAOito 
            && !this.candidato.horasAcimaDeOito && !this.candidato.horasFimDeSemana)
            return;

        if(!this.candidato.periodoManha && !this.candidato.periodoTarde && !this.candidato.periodoNoite 
            && !this.candidato.periodoMadrugada && !this.candidato.periodoComercial)
            return;

        if(!this.candidato.id) {
            new Client().post('candidato', this.candidato)
                .then(data => {
                    console.log(data);
                })
                .catch(data => {
                    console.log(data);
                });
        } else {
            new Client().put('candidato/'+this.candidato.id, this.candidato)
                .then(data => {
                    console.log(data);
                })
                .catch(data => {
                    console.log(data);
                });
        }
    }

    proxima(){
        this.pagina++;
    }

    voltar(){
        this.pagina--;
    }
}