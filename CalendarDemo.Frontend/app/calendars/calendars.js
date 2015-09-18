'use strict';

angular.module('app.calendars', ['ui.router', 'ngResource'])
.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider.state('app.calendars', {
        url: '/calendars',
        templateUrl: 'app/calendars/calendars.html',
        controller: 'CalendarsCtrl'
    });
    $urlRouterProvider.otherwise('/calendars');
}])
.controller('CalendarsCtrl', ['$scope', 'CalendarService', function ($scope, CalendarService) {
    $scope.calendars = CalendarService.query();
}])
.factory('CalendarService', ['$resource', function ($resource) {
    return $resource('api/calendars');
}]);