namespace MovieLibrary {

    angular.module("MovieLibrary", ['ngRoute'])
        .config(function($routeProvider) {
            //$routeProvider.when('/', {
            // templateUrl: '/path/to/view',
            // controller: MovieLibrary.Controllers.ControllerClass,
            // controllerAs: 'views variable name for controller'
            //});
            $routeProvider.when('/', { template: 'Hello World!' });
        });
}