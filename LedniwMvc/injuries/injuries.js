'use strict';

angular.module('myApp.injuries', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/injuries', {
    templateUrl: 'injuries/injuries.html',
    controller: 'InjuriesCtrl'
  });
}])

.controller('InjuriesCtrl', [function() {

}]);