import {Client} from './client';

export class App {
    constructor() {
        this.message = 'Welcome to Aurelia!';
    }
    
    buscar() {
        new Client().get('candidato', this.sucesso, this.fracasso);

    }

    sucesso(data){
        console.log(data);
    }

    fracasso(erro){
        console.log(erro);
    }

}