app.Get("movie/\d*", function (req) {
    return "hello cruel world" + req.query.id;
});