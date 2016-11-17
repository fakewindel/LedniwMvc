'use strict';

angular.module('myApp.confidentiality', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/confidentiality', {
    templateUrl: 'confidentiality/confidentiality.html',
    controller: 'ConfidentialityCtrl'
  });
}])

.controller('ConfidentialityCtrl', [function() {

}]);