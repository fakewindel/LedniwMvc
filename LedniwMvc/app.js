'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
  'ngRoute',
  'myApp.home',
  'myApp.view2',
  'myApp.homeassesment',
  'myApp.drivingassesment',
  'myApp.psychologicalstrategies',
  'myApp.injuries',
  'myApp.disability',

  'myApp.credentials',
  'myApp.confidentiality',
  'myApp.contacts',


  'myApp.version'
]).
config(['$routeProvider', function($routeProvider) {
  $routeProvider.otherwise({redirectTo: '/home'});
}]);
