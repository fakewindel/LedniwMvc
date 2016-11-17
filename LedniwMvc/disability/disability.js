'use strict';

angular.module('myApp.disability', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/disability', {
    templateUrl: 'disability/disability.html',
    controller: 'DisabilityCtrl'
  });
}])

.controller('DisabilityCtrl', [function() {

}]);