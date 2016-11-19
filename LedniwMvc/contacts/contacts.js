'use strict';
angular.module('myApp.contacts', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/contacts', {
    templateUrl: 'contacts/contacts.html',
    controller: 'ContactsCtrl',
    activetab: 'contacts'
  });
}])

.controller('ContactsCtrl', ['$scope','$route','$http','$location',function($scope, $route, $http, $location) {
/*	$scope.fullname = '';
	$scope.email = '';
	$scope.phone = '';
	$scope.message = '';*/
	$scope.pageTitle = 'contacts';
	$scope.contact = {};

	$scope.captcha1 = randomNumber(10, 15); // 15
	$scope.captcha2 = randomNumber(1, 5); //2

    function randomNumber(min, max) {
        return Math.floor(Math.random() * (max - min + 1) + min);
    }

	//... TODO: try not to pass the scope
	$scope.submitForm = function() {
	    if ($scope.captcha1 + $scope.captcha2 == $scope.captcha) {
	        $http.post("api/SendMail", $scope.contact)
            .success(function (data, status, headers, config) {
                alert("Message submitted. Thank you!");
                $location.path('/home');
            }).error(function (data, status, headers, config) {
                if (status == 417) {
                    console.log(data.Message)
                    alert(data.Message);
                    $location.path('/home');
                }
                console.log(data);
            });
		}
	};

}]);
