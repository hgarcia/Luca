
var Application = Class.create({
	initialize: function (response, request) {
        this.response = response;
        this.request = request;
    	this.gets = new Hash();
		this.posts = new Hash();
		this.puts = new Hash();
		this.deletes = new Hash();
    },

	getRequestedPath: function(){
		return this.request.path;	
	},

	process: function(routes){
		var that = this;
		var handler = routes.find(function(route)
		{ 
			var path = this.getRequestedPath();
			var re = new RegExp(route.key,'i');
			return re.test(path);
		},that); 
        if (handler) handler.value.call(this.request, this.response);
	},
	Get: function(pattern,handler){
		this.gets.set(pattern, handler);
	},
	Post: function(pattern, handler){
		this.posts.set(pattern, handler);
	},
	Put: function(pattern, handler){
		this.puts.set(pattern, handler);
	},
	Delete: function(pattern, handler){
		this.puts.deletes(pattern, handler);
	},
	Run: function(){
		if (this.request.method === "GET") return this.process(this.gets);
		if (this.request.method === "POST") return this.process(this.posts);
		if (this.request.method === "PUT") return this.process(this.puts);
		if (this.request.method === "DELETE") return this.process(this.deletes);
		return;
	}
});
