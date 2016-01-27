namespace InstagramMockupFourLayer.Controllers {

    export class AuthController {

        constructor(private $http: ng.IHttpService, private $window: ng.IWindowService, private $location: ng.ILocationService) { }

        public register(user): void {

            this.$http.post('/api/account/register', user)
                .then((response) => {
                    console.log('Registered a new user!');
                })
                .catch((response) => {
                    console.log(response);
                });
        }

        //login method with Identity
        public login(username, password): void {
            let data = `grant_type=password&username=${username}&password=${password}`;
            console.log("Logging in");
            this.$http.post('/token', data, {
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            })
                .then((response) => {
                    this.$window.localStorage.setItem('token', response.data['access_token']);
                    this.$location.path('/');
                })
                .catch((response) => {
                    console.log(response);
                });
        }
        public logout() {
            this.$window.localStorage.removeItem('token');
        }
    }
}
            
