var InstagramMockupFourLayer;
(function (InstagramMockupFourLayer) {
    //define module
    angular.module('InstagramMockupFourLayer', ['ngRoute']);
    angular.module('InstagramMockupFourLayer').factory('authInterceptor', function ($q, $window, $location) {
        return {
            request: function (config) {
                config.headers = config.headers || {};
                var token = $window.localStorage.getItem('token');
                if (token) {
                    config.headers.Authorization = "Bearer " + token;
                }
                return config;
            },
            responseError: function (response) {
                if (response.status === 401) {
                    $location.path('/login');
                }
                return response || $q.when(response);
            }
        };
    });
    angular.module('InstagramMockupFourLayer')
        .config(function ($routeProvider, $httpProvider) {
        $routeProvider.when('/', {
            templateUrl: '/Presentation/ngApp/views/newsFeed.html',
            controller: InstagramMockupFourLayer.Controllers.NewsFeedController,
            controllerAs: 'controller'
        });
        $routeProvider.when('/profile/:username', {
            templateUrl: '/Presentation/ngApp/views/newsFeed.html',
            controller: InstagramMockupFourLayer.Controllers.ProfileFeedController,
            controllerAs: 'controller'
        });
        $routeProvider.when('/register', {
            templateUrl: '/Presentation/ngApp/views/registration.html',
            controller: InstagramMockupFourLayer.Controllers.AuthController,
            controllerAs: 'controller'
        });
        $routeProvider.when('/friends', {
            templateUrl: '/Presentation/ngApp/views/friendsList.html',
            controller: InstagramMockupFourLayer.Controllers.FriendsListController,
            controllerAs: 'controller'
        });
        $routeProvider.when('/login', {
            templateUrl: '/Presentation/ngApp/views/login.html',
            controller: InstagramMockupFourLayer.Controllers.AuthController,
            controllerAs: 'controller'
        });
        $httpProvider.interceptors.push('authInterceptor');
    });
})(InstagramMockupFourLayer || (InstagramMockupFourLayer = {}));
