
var app = angular.module('appPOS', []);

app.controller('MainController', function ($http) {

	var me = this;

	this.ProductCode = '';


	this.KeyUp = function (code) {
		
		// get product code
		$http.get('/')
	}
	

});