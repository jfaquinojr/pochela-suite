
var app = angular.module('appPOS', []);

app.controller('MainController', function ($scope, $http) {

	var me = this;

	this.ProductCode = '';
	$scope.ModelCreateProduct = {};
	this.SalesItems = [];
	this.TotalAmount = 0.00;
	

	this.KeyUp = function (code) {
		
		// get product code
		$http.post('/home/GetProductByCode/?code=' + code)
		.success(function (data, status, headers, config) {
			if (data) {
				alert(data.Name);
			}
			else {
				// prompt to create
				$('#ProductName').focus();
				$('#modalBox').modal('show');
			}
		})
	}

	this.SubmitFormCreateProduct = function (model) {

		// create product
		var postData = {
			"Name": $scope.ModelCreateProduct.ProductName,
			"UnitPrice": $scope.ModelCreateProduct.UnitPrice,
			"ProductCode": me.ProductCode
		}
		$http.post('/home/CreateProduct', postData)
		.success(function (data, status, headers, config) {
			alert('Product Created.');
			$('#modalBox').modal('hide');
			$('#TheProductCode').focus();

			me.AddItem(data.ProductCode, data.Name, 1, data.UnitPrice);
		})
	}


	this.AddItem = function (productCode, productName, quantity, unitPrice) {

	}


	

});