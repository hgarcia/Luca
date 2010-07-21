app.Get("movie/\d*", function(req, res) {
    res.Append("hello cruel world from the js file: ");
    res.Append(req.query.id); 
});