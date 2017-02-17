import {Client} from './client';

export class Candidatos {

    constructor(){
        this.buscarCandidatos();
    }

    excluir(){
        new Client().delete('candidato/' + this.selecionado)
            .then(data => {
                console.log(data);
                this.buscarCandidatos();
                this.exibirMensagem(['Candidato excluído.']);
            })
            .catch(data => {
                console.log(data)
            });
    }

    selecionarParaExcluir(id){
        this.pergunta = `Confirmar exclusão do candidato ${id}?`;
        this.selecionado = id;
    }

    exibirMensagem(msg){
        this.mensagens = msg;
        $('#mensagem-modal').modal('show');
    }

    buscarCandidatos(){
        new Client().get('candidato')
            .then(data => this.pessoas = data.data)
            .catch(data => {
                console.log(data)
            });
    }
}