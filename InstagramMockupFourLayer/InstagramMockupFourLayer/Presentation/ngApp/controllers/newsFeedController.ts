namespace InstagramMockupFourLayer.Controllers {

    export class NewsFeedController {

        public posts;

        constructor(private $http: ng.IHttpService) {
            
            $http.get('api/posts') //NewsFeed Posts
                .then((response) => {
                    this.posts = response.data;
                });
        }
    }
}
