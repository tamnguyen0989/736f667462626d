﻿(function (app) {
    app.controller('returnSupplierAddController', returnSupplierAddController);

    returnSupplierAddController.$inject = ['apiService', '$window', '$scope', 'notificationService', '$state'];

    function returnSupplierAddController(apiService, $window, $scope, notificationService, $state) {
        $scope.returnSupplier = {
            CreatedDate: new Date(),
            Status: true
        }
        $scope.stringSearch = '';
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.pageSizeNumber = '5'
        $scope.searchedProducts = [];
        $scope.suppliers = [];
        $scope.productStatus = [];
        $scope.filters = [];
        $scope.bookDetails = [];
        $scope.loading = true;
        $scope.selectedSupplier = null;

        $scope.loadSuppliers = loadSuppliers;
        $scope.loadProductStatus = loadProductStatus;
        $scope.search = search;
        $scope.addBookDetails = addBookDetails;
        $scope.addFilter = addFilter;
        $scope.removeFilter = removeFilter;
        $scope.removeBookDetail = removeBookDetail
        $scope.init = init;
        $scope.addReturnSupplier = addReturnSupplier;
        $scope.sumQuantity = sumQuantity;
        function loadSuppliers() {
            $scope.loading = true;
            var config = {
                params: {
                    order: "Name"
                }

            }
            apiService.get('/api/supplier/getall', config, function (result) {
                $scope.suppliers = result.data;
                $scope.loading = false;
            }, function (error) {
                notificationService.displayError(error);
            });
        }
        function loadProductStatus() {
            $scope.loading = true;
            apiService.get('/api/product/getallproductstatus', null, function (result) {
                $scope.productStatus = result.data;
                $scope.loading = false;
            }, function (error) {
                notificationService.displayError(error);
            });
        }
        function search(page) {
            page = page || 0;

            $scope.loading = true;
            var config = {
                branchId: $scope.branchSelectedRoot.Id,
                stringSearch: $scope.stringSearch,
                page: page,
                pageSize: parseInt($scope.pageSizeNumber),
                FilterBookDetail: $scope.filters
            };
            apiService.post('/api/product/getallpaging/', config, function (result) {
                $scope.searchedProducts = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
                $scope.loading = false;
                if ($scope.filteradjustmentStocks && $scope.filteradjustmentStocks.length && $scope.page == 0) {
                    //notificationService.displayInfo($scope.totalCount + ' đơn tìm được');
                }
            }, function (response) {
                notificationService.displayError(response.data);
            });
        }
        function addBookDetails(val) {
            var exist = 0;
            if ($scope.bookDetails.length > 0) {
                $.each($scope.bookDetails, function (index, value) {
                    if (value.id == val.id) {
                        exist = 1;
                        value.Quantity += 1;
                        return false;
                    }
                });
                if (exist == 0) {
                    val.Quantity = 1;
                    $scope.bookDetails.push(val);
                }
            }
            else {
                val.Quantity = 1;
                $scope.bookDetails.push(val);
            }
        }
        function addFilter(val, key) {
            var newFilter = {
                key: key,
                value: val.Id,
                name: val.Name
            }
            switch (key) {
                case 0:
                    newFilter.alias = 'Nhà cung cấp';
                    break;
                case 1:
                    newFilter.alias = 'Trạng thái';
                    break;
            }
            if ($scope.filters.length > 0) {
                var exist = 0;
                $.each($scope.filters, function (index, data) {
                    if (newFilter.alias == data.alias && newFilter.key == data.key && newFilter.value == data.value) {
                        exist = 1;
                        return false;
                    }
                });
                if (exist == 0)
                    $scope.filters.push(newFilter);
            }
            else
                $scope.filters.push(newFilter);
            search();
        }
        function removeFilter(val) {
            $scope.filters.splice(val, 1);
            search();
        }
        function removeBookDetail(index) {
            $scope.bookDetails.splice(index, 1);
        }
        function addReturnSupplier() {
            if ($scope.bookDetails.length > 0) {
                $scope.returnSupplier.BranchId = $scope.branchSelectedRoot.Id;
                if ($scope.selectedSupplier)
                    $scope.returnSupplier.SupplierId = $scope.selectedSupplier.Id;
                $scope.returnSupplier.SoftReturnSupplierDetails = $scope.bookDetails;
                $scope.returnSupplier.Description = $scope.description;
                $scope.returnSupplier.TotalQuantity = sumQuantity();
                apiService.post('api/returnSupplier/add', $scope.returnSupplier,
                    function (result) {
                        if (result.data == true) {
                            notificationService.displaySuccess('Thêm mới phiếu thành công.');
                            $state.go('return_suppliers');
                        }

                    }, function (error) {
                        notificationService.displayError(error.data);
                    });
            }
        }
        function init() {
            if (localStorage.getItem("userId")) {
                $scope.returnSupplier.CreatedBy = JSON.parse(localStorage.getItem("userId"));
            }
        }
        function authen() {
            apiService.get('api/returnsupplier/authenadd', null, function (result) {

            }, function (error) {
                notificationService.displayError(error.data);
            });
        }
        function sumQuantity() {
            var total = 0;
            $.each($scope.bookDetails, function (index, item) {
                total += item.Quantity;
            });
            return total;
        }

        //if (((Object.keys($scope.branchSelectedRoot).length === 0 && $scope.branchSelectedRoot.constructor === Object) || $scope.branchSelectedRoot == undefined) && localStorage.getItem("userId") != null) {
        //    notificationService.displayError("Hãy chọn kho");
        //    $state.go('home');
        //}

        authen();
        loadSuppliers();
        //loadProductStatus();
        init();
        $window.document.title = "Thêm mới phiếu trả hàng";
    }


})(angular.module('softbbm.return_suppliers'));