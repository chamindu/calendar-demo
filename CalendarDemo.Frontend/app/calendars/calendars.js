'use strict';

angular.module('app.calendars', ['ui.router', 'ngResource', 'ui.bootstrap'])
.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider.state('app.calendars', {
        url: '/calendars',
        templateUrl: 'app/calendars/calendars.html',
        controller: 'CalendarsCtrl'
    });
    $urlRouterProvider.otherwise('/calendars');
}])
.controller('CalendarsCtrl', ['$scope', 'CalendarService', function ($scope, CalendarService) {
    $scope.currentPage = 1;
    $scope.pageChanged = function () {
        CalendarService.query({ offset: ($scope.currentPage - 1) * 5, limit: 5 }, function (data) {
            $scope.calendars = data.Items;
            $scope.total = data.TotalCount;
        });
    };
    $scope.pageChanged();
}])
.factory('CalendarService', ['$resource', function ($resource) {
    return $resource('', {}, {
        query: {
            method: 'GET',
            url: '/api/calendars'
        }
    });
}]);