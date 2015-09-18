'use strict';

angular.module("app", ['ui.router', 'app.calendars', 'app.otherstuff'])
.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider.state('app', {
        templateUrl: 'app/app.html',
        abstract: true,
        controller: 'AppCtrl'
    });
}])
.controller('AppCtrl', ['$scope', function($scope) {
}]);