'use strict';

angular.module('myApp.credentials', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/credentials', {
    templateUrl: 'credentials/credentials.html',
    controller: 'CredentialsCtrl'
  });
}])

.controller('CredentialsCtrl', [function() {

}]);