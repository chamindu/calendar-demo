'use strict';

angular.module('app.otherstuff', ['ui.router', 'ngResource'])
.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider.state('app.buttons', {
        url: '/buttons',
        templateUrl: 'app/otherstuff/otherstuff.html',
        controller: 'OtherstuffCtrl',
        data: {
            name: "Buttons",
        }
    })
    .state('app.promotions', {
        url: '/promotions',
        templateUrl: 'app/otherstuff/otherstuff.html',
        controller: 'OtherstuffCtrl',
        data: {
            name: "Promotions",
        }
    })
    .state('app.subscribe', {
        url: '/subscribe',
        templateUrl: 'app/otherstuff/otherstuff.html',
        controller: 'OtherstuffCtrl',
        data: {
            name: "Subscribe",
        }
    })
    .state('app.schedule', {
        url: '/schedule',
        templateUrl: 'app/otherstuff/otherstuff.html',
        controller: 'OtherstuffCtrl',
        data: {
            name: "Schedule",
        }
    })
    .state('app.twitter', {
        url: '/twitter',
        templateUrl: 'app/otherstuff/otherstuff.html',
        controller: 'OtherstuffCtrl',
        data: {
            name: "Twitter",
        }
    })
    .state('app.facebook', {
        url: '/facebook',
        templateUrl: 'app/otherstuff/otherstuff.html',
        controller: 'OtherstuffCtrl',
        data: {
            name: "Facebook",
        }
    });
}])
.controller('OtherstuffCtrl', ['$scope', '$state', function ($scope, $state) {
    $scope.heading = $state.current.data.name;
    $scope.content = $state.current.data.name  + " stuff goes here";

}]);