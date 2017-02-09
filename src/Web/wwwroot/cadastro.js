import {Client} from './client';

export class Cadastro {

    constructor(){
        this.candidato = {};
        this.niveisConhecimento = [0, 1, 2, 3, 4, 5];
        this.tecnologias = [
            {titulo: 'Ionic', parametro: 'Ionic'},
            {titulo: 'Android', parametro: 'Android'},
            {titulo: 'IOS', parametro: 'Ios'},
            {titulo: 'HTML', parametro: 'Html'},
            {titulo: 'CSS', parametro: 'Css'},
            {titulo: 'Bootstrap', parametro: 'Bootstrap'},
            {titulo: 'JQuery', parametro: 'Jquery'},
            {titulo: 'AngularJS', parametro: 'Angular'},
            {titulo: 'Java', parametro: 'Java'},
            {titulo: 'Asp.Net MVC', parametro: 'Asp'},
            {titulo: 'C', parametro: 'C'},
            {titulo: 'C++', parametro: 'Cplusplus'},
            {titulo: 'Cake', parametro: 'Cake'},
            {titulo: 'Django', parametro: 'Django'},
            {titulo: 'Majento', parametro: 'Majento'},
            {titulo: 'PHP', parametro: 'Php'},
            {titulo: 'Wordpress', parametro: 'Wordpress'},
            {titulo: 'Python', parametro: 'Python'},
            {titulo: 'Ruby', parametro: 'Ruby'},
            {titulo: 'SQL Server', parametro: 'SqlServer'},
            {titulo: 'MySQL', parametro: 'MySql'},
            {titulo: 'Salesforce', parametro: 'Salesforce'},
            {titulo: 'Photoshop', parametro: 'Photoshop'},
            {titulo: 'Illustrator', parametro: 'Illustrator'},
            {titulo: 'SEO', parametro: 'Seo'}
        ];
        this.pagina = 1;
    }

    activate(params) {
        if(params.id)
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