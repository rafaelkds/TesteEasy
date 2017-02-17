export class App {
    configureRouter(config, router) {
        this.router = router;
        config.title = 'CRUD Easy';
        config.map([
            { route: ['', 'cadastrar', 'editar/:id'],  name: 'cadastro',   moduleId: 'cadastro', nav: true, title: 'Cadastro' },
            { route: 'candidatos',  name: 'candidatos',   moduleId: 'candidatos', nav: true, title: 'Candidatos' }
        ]);
    }

}