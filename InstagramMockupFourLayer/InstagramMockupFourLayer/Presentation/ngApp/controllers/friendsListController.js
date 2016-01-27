var InstagramMockupFourLayer;
(function (InstagramMockupFourLayer) {
    var Controllers;
    (function (Controllers) {
        var FriendsListController = (function () {
            function FriendsListController($http) {
                var _this = this;
                this.$http = $http;
                $http.get('/api/friends')
                    .then(function (response) {
                    _this.friends = response.data;
                });
            }
            return FriendsListController;
        })();
        Controllers.FriendsListController = FriendsListController;
    })(Controllers = InstagramMockupFourLayer.Controllers || (InstagramMockupFourLayer.Controllers = {}));
})(InstagramMockupFourLayer || (InstagramMockupFourLayer = {}));
