namespace InstagramMockupFourLayer.Controllers {

    export class FriendsListController {

        public friends;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/friends')
                .then((response) => {
                    this.friends = response.data;
                });
        }
    }
}