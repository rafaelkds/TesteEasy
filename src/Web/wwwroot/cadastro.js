import {Client} from './client';

export class Cadastro {

    constructor(){
        this.candidato = { conhecimento: {} };
        this.niveisConhecimento = [0, 1, 2, 3, 4, 5];
        this.tecnologias = [
            {titulo: 'Ionic', parametro: 'ionic', obrigatorio: true},
            {titulo: 'Android', parametro: 'android', obrigatorio: true},
            {titulo: 'IOS', parametro: 'ios', obrigatorio: true},
            {titulo: 'HTML', parametro: 'html', obrigatorio: false},
            {titulo: 'CSS', parametro: 'css', obrigatorio: false},
            {titulo: 'Bootstrap', parametro: 'bootstrap', obrigatorio: true},
            {titulo: 'JQuery', parametro: 'jquery', obrigatorio: true},
            {titulo: 'AngularJS', parametro: 'angular', obrigatorio: true},
            {titulo: 'Java', parametro: 'java', obrigatorio: false},
            {titulo: 'Asp.Net MVC', parametro: 'asp', obrigatorio: true},
            {titulo: 'C', parametro: 'c', obrigatorio: false},
            {titulo: 'C++', parametro: 'cplusplus', obrigatorio: false},
            {titulo: 'Cake', parametro: 'cake', obrigatorio: false},
            {titulo: 'Django', parametro: 'django', obrigatorio: false},
            {titulo: 'Majento', parametro: 'majento', obrigatorio: false},
            {titulo: 'PHP', parametro: 'php', obrigatorio: true},
            {titulo: 'Wordpress', parametro: 'wordpress', obrigatorio: true},
            {titulo: 'Python', parametro: 'python', obrigatorio: false},
            {titulo: 'Ruby', parametro: 'ruby', obrigatorio: false},
            {titulo: 'SQL Server', parametro: 'sqlServer', obrigatorio: false},
            {titulo: 'MySQL', parametro: 'mySql', obrigatorio: false},
            {titulo: 'Salesforce', parametro: 'salesforce', obrigatorio: false},
            {titulo: 'Photoshop', parametro: 'photoshop', obrigatorio: false},
            {titulo: 'Illustrator', parametro: 'illustrator', obrigatorio: false},
            {titulo: 'SEO', parametro: 'seo', obrigatorio: false}
        ];
        this.pagina = 1;
    }

    activate(params) {
        if(params.id)
            new Client().get('candidato/'+params.id)
                .then(data => {
                    console.log(data);
                    this.candidato = data.data;
                })
                .catch(data => {
                    console.log(data)
                });
    }

    cadastrar() {
        if(this.pagina == 1 && $("input[name='grupo-horas']:checked").length == 0){
            this.exibirMensagem(['Field "What is your willingness to work today?" is mandatory.',
                            'Campo "Qual é sua disponibilidade para trabalhar hoje?" é obrigatório.']);
            return;
        }

        if(this.pagina == 1 && $("input[name='grupo-periodo']:checked").length == 0){
            this.exibirMensagem(['Field "What\'s the best time to work for you?" is mandatory.',
                            'Campo "Pra você qual é o melhor horário para trabalhar?" é obrigatório.']);
            return;
        }

        if(this.pagina < 3){
            this.pagina++;
            return;
        }

        if(!this.candidato.id) {
            new Client().post('candidato', this.candidato)
                .then(data => {
                    console.log(data);
                    this.exibirMensagem(['Cadastro enviado.']);
                })
                .catch(data => {
                    console.log(data);
                });
        } else {
            new Client().put('candidato/'+this.candidato.id, this.candidato)
                .then(data => {
                    console.log(data);
                    this.exibirMensagem(['Cadastro atualizado.']);
                })
                .catch(data => {
                    console.log(data);
                });
        }
    }

    voltar(){
        this.pagina--;
    }

    exibirMensagem(msg){
        this.mensagens = msg;
        $('#mensagem-modal').modal('show');
    }
}