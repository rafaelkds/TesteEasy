export class App {
    configureRouter(config, router) {
        this.router = router;
        config.title = 'Cadastro Candidatos Easy';
        config.map([
          { route: ['', 'cadastrar'],  name: 'cadastro',   moduleId: 'cadastro' }
        ]);
    }

}