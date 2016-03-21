angular.module('hrapp.controllers.employees', [
    'hrapp.services.employeeServices'
])
    .controller('employees-controller', function ($scope, employeeServices) {
    $scope.emp = {};
    $scope.emps = employeeServices.query();
    $scope.add = function () {
        employeeServices.create($scope.emp, function (data) {
            $scope.emps = employeeServices.query();
        });
    };
    $scope.edit = function (employeeID) {
        employeeServices.queryByID({ id: employeeID }, function (data) {
            $scope.emp = data;
        });
    };
    $scope.update = function () {
        employeeServices.update({ id: $scope.emp.employeeID }, $scope.emp, function (data) {
            $scope.emps = employeeServices.query();
        });
    };
    $scope.del = function (employeeID) {
        employeeServices.del({ id: employeeID }, function (data) {
            $scope.emps = employeeServices.query();
        });
    };
});
//# sourceMappingURL=hr-controller.js.map