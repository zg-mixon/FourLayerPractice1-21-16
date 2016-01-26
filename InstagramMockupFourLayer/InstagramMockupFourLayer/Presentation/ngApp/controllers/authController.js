var InstagramMockupFourLayer;
(function (InstagramMockupFourLayer) {
    var Controllers;
    (function (Controllers) {
        var AuthController = (function () {
            function AuthController($http) {
                this.$http = $http;
            }
            AuthController.prototype.register = function (user) {
                this.$http.post('/api/account/register', user)
                    .then(function (response) {
                    console.log('Registered a new user!');
                })
                    .catch(function (response) {
                    console.log(response);
                });
            };
            return AuthController;
        })();
        Controllers.AuthController = AuthController;
    })(Controllers = InstagramMockupFourLayer.Controllers || (InstagramMockupFourLayer.Controllers = {}));
})(InstagramMockupFourLayer || (InstagramMockupFourLayer = {}));
//# sourceMappingURL=authController.js.map