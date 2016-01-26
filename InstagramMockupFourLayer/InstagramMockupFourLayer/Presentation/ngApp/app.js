var InstagramMockupFourLayer;
(function (InstagramMockupFourLayer) {
    angular.module('InstagramMockupFourLayer', ['ngRoute'])
        .config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: '/Presentation/ngApp/views/newsFeed.html',
            controller: InstagramMockupFourLayer.Controllers.NewsFeedController,
            controllerAs: 'controller'
        });
    });
})(InstagramMockupFourLayer || (InstagramMockupFourLayer = {}));
//# sourceMappingURL=app.js.map