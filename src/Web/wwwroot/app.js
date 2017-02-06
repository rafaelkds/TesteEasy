export class App {
    configureRouter(config, router) {
        this.router = router;
        config.title = 'CRUD Easy';
        config.map([
            { route: ['', 'cadastrar'],  name: 'cadastro',   moduleId: 'cadastro', nav: true, title: 'Cadastro' },
            { route: 'editar/:id',  name: 'editar',   moduleId: 'cadastro', title: 'Editar' },
            { route: 'candidatos',  name: 'candidatos',   moduleId: 'candidatos', nav: true, title: 'Candidatos' }
        ]);
    }

}