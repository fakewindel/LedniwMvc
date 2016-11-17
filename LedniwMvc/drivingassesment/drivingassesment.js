'use strict';

angular.module('myApp.drivingassesment', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/drivingassesment', {
    templateUrl: 'drivingassesment/drivingassesment.html',
    controller: 'DrivingassesmentCtrl'
  });
}])

.controller('DrivingassesmentCtrl', [function() {

}]);