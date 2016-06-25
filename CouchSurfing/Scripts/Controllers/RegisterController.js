var RegisterController = function ($scope) {
    $scope.registerForm = {
        firstName: '',
        lastName: '',
        email: '',
        password: '',
        confirmPassword: '',
        personalInfo: ''
};

    $scope.register = function () {
        //todo
    }
}

RegisterController.$inject = ['$scope'];