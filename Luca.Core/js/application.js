function GetApplication(request,response) {
    return {
        response: response,
        request: request,
        gets: [],
        posts: [],
        puts: [],
        deletes: [],
        getRequestedPath: function () {
          return this.request.path;    
        },
        process: function (routes) {
            var path = this.getRequestedPath();
            for (var i = 0; i < routes.length; i++) {
                var re = new RegExp(routes[i][0], 'i');
                if (re.test(path)) {
                    handler = routes[i][1];
                    break;
                }
            }
            if (handler) handler(this.request, this.response);
        },
        Get: function (pattern, handler) {
            this.gets[this.gets.length] = [pattern, handler];
        },
        Post: function (pattern, handler) {
            this.posts[this.gets.length] = [pattern, handler];
        },
        Put: function (pattern, handler) {
            this.puts[this.gets.length] = [pattern, handler];
        },
        Delete: function (pattern, handler) {
            this.puts[this.gets.length] = [pattern, handler];
        },
        Run: function () {
            if (this.request.method === "GET") return this.process(this.gets);
            if (this.request.method === "POST") return this.process(this.posts);
            if (this.request.method === "PUT") return this.process(this.puts);
            if (this.request.method === "DELETE") return this.process(this.deletes);
            return;
        }
    };
}
