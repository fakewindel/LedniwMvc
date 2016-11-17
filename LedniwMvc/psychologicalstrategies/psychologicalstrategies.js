'use strict';

angular.module('myApp.psychologicalstrategies', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/psychologicalstrategies', {
    templateUrl: 'psychologicalstrategies/psychologicalstrategies.html',
    controller: 'PsychologicalstrategiesCtrl'
  });
}])

.controller('PsychologicalstrategiesCtrl', [function() {

}]);