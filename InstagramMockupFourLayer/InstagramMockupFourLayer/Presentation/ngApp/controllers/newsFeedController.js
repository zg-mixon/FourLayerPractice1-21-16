var InstagramMockupFourLayer;
(function (InstagramMockupFourLayer) {
    var Controllers;
    (function (Controllers) {
        var NewsFeedController = (function () {
            function NewsFeedController($http) {
                var _this = this;
                this.$http = $http;
                $http.get('api/posts') //NewsFeed Posts
                    .then(function (response) {
                    _this.posts = response.data;
                });
            }
            return NewsFeedController;
        })();
        Controllers.NewsFeedController = NewsFeedController;
    })(Controllers = InstagramMockupFourLayer.Controllers || (InstagramMockupFourLayer.Controllers = {}));
})(InstagramMockupFourLayer || (InstagramMockupFourLayer = {}));
//# sourceMappingURL=newsFeedController.js.map