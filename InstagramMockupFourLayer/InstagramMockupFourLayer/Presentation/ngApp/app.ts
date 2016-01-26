namespace InstagramMockupFourLayer {
    
    angular.module('InstagramMockupFourLayer', ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {
            
            $routeProvider.when('/', {
                templateUrl: '/Presentation/ngApp/views/newsFeed.html',
                controller: InstagramMockupFourLayer.Controllers.NewsFeedController,
                controllerAs: 'controller'
            });
        });
}