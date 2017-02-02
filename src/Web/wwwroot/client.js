import {HttpClient} from 'aurelia-fetch-client';

export class Client {
    constructor(){
        this.client = new HttpClient();
        this.client.configure(config => {
            config.withBaseUrl('http://localhost:56567/api/')
                .rejectErrorResponses();
        });
    }

    get(recurso, sucesso, fracasso) {

        this.client.fetch(recurso)
            .then(response =>
                response.json().then(data => {
                    sucesso(data);
                }))
            .catch(error =>
                error.json().then(data => {
                    data.status = error.status;
                    data.ok = error.ok;
                    fracasso(data);
                }));
        
    }
}