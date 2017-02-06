import {Client} from './client';

export class Candidatos {

    constructor(){
        new Client().get('candidato')
            .then(data => this.pessoas = data.data)
            .catch(data => {
                console.log(data)
            });
    }

    excluir(id){
        new Client().delete('candidato/' + id)
            .then(data => console.log(data))
            .catch(data => {
                console.log(data)
            });
    }
}