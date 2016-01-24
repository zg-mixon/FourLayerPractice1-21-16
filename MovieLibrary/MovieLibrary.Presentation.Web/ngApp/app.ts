namespace MovieLibrary.Presentation.Web {

    angular.module("MovieLibrary.Presentation.Web", ['ngRoute'])
        .config(function($routeProvider) {
            //$routeProvider.when('/', {
            // templateUrl: '/path/to/view',
            // controller: MovieLibrary.Presentation.Web.Controllers.ControllerClass,
            // controllerAs: 'views variable name for controller'
            //});
            $routeProvider.when('/', { template: 'Hello World!' });
        });
}