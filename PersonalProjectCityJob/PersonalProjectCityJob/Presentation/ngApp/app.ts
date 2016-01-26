namespace PersonalProjectCityJob {
    
    angular.module('PersonalProjectCityJob', ['ngRoute'])
        .config(function ($routeProvider: ng.route.IRouteProvider) {
            
            $routeProvider.when('/', { template: 'Hello World!' });
        });
}