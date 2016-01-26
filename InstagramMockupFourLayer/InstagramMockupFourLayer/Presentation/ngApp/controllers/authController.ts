namespace InstagramMockupFourLayer.Controllers {

    export class AuthController {

        constructor(private $http: ng.IHttpService) { }

        public register(user): void {

            this.$http.post('/api/account/register', user)
                .then((response) => {
                    console.log('Registered a new user!');
                })
                .catch((response) => {
                    console.log(response);
                });
        }
    }
}
