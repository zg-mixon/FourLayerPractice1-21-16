namespace InstagramMockupFourLayer {
    
    angular.module('InstagramMockupFourLayer', ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {
            
            $routeProvider.when('/', {
                templateUrl: '/Presentation/ngApp/views/newsFeed.html',
                controller: InstagramMockupFourLayer.Controllers.NewsFeedController,
                controllerAs: 'controller'
            })
            $routeProvider.when('/profile/:username', {
                templateUrl: '/Presentation/ngApp/views/newsFeed.html',
                controller: InstagramMockupFourLayer.Controllers.ProfileFeedController,
                controllerAs: 'controller'
            })
            $routeProvider.when('/register', {
                templateUrl: '/Presentation/ngApp/views/registration.html',
                controller: InstagramMockupFourLayer.Controllers.AuthController,
                controllerAs: 'controller'
            })
            $routeProvider.when('/friends', {
                templateUrl: '/Presentation/ngApp/views/friendsList.html',
                controller: InstagramMockupFourLayer.Controllers.FriendsListController,
                controllerAs: 'controller'
            });
        });
}