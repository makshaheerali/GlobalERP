(function () {
    var controllerId = 'app.views.users.detail';
    angular.module('app').controller(controllerId, [
        '$state', 'abp.services.app.user',
        function ($state, questionService) {
            var vm = this;
            vm.user = null;
            var loadQuestion = function () {
                abp.ui.setBusy(
                    null,
                    questionService.getUser({
                        id: $state.params.id
                    }).success(function (data) {
                        vm.user = data;
                    })
                );
            };

            loadQuestion();
        }
    ]);
})();