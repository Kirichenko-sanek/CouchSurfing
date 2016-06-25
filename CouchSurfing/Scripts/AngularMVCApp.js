var AngularMVCApp = angular.module('AngularMVCApp', ['ngRoute']);

AngularMVCApp.controller('LandingPageController', LandingPageController);
AwesomeAngularMVCApp.controller('RegisterController', RegisterController);

AngularMVCApp.factory('RegistrationFactory', RegistrationFactory);






var configFunction = function ($routeProvider) {
    $routeProvider.when('/routeOne',
        {
            templateUrl: 'routesDemo/one'
        })
        .when('/routeTwo/:donuts',
        {
            templateUrl: function(params) { return '/routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree',
        {
            templateUrl: 'routesDemo/three'
        })
        .when('/register',
        {
            templateUrl: '/Account/Register',
            controller: RegisterController
        });
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

AngularMVCApp.config(configFunction);