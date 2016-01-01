(function (ng) {
    'use strict';

    var appConfig = function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/app/index');
        $stateProvider
            .state('app', {
                url: '/app',
                abstract: true,
                templateUrl: 'views/home/base'
            }).state('app.index', {
                url: '/index',
                templateUrl: 'views/home/index'
            }).state('app.about', {
                url: '/about',
                templateUrl: 'views/home/about'
            }).state('app.contact', {
                url: '/contact',
                templateUrl: 'views/home/contact'
            }).state('app.login', {
                url: '/login',
                templateUrl: 'views/account/login'
            }).state('app.register', {
                url: '/register',
                templateUrl: 'views/account/register'
            });
    };

    var appModule = angular.module('app', ['ui.router', 'ngResource']);
    appModule.config(['$stateProvider', '$urlRouterProvider', appConfig]);

})(angular);
