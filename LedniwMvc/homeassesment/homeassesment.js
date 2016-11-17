'use strict';

angular.module('myApp.homeassesment', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/homeassesment', {
    templateUrl: 'homeassesment/homeassesment.html',
    controller: 'HomeassesmentCtrl'
  });
}])

.controller('HomeassesmentCtrl', [function() {

}]);