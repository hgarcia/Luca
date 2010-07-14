if (!Object.prototype.__defineGetter__ && Object.defineProperty) {
    // the second silly WebReflection idea!
    Object.defineProperty(Object.prototype, "__defineGetter__", {
        value: function(that, prop, get) {
            if (!get) {
                get = prop;
                prop = that;
                that = this;
            }
            Object.defineProperty(that, prop, { get: get });
        },
        enumerable: false
    });
    Object.defineProperty(Object.prototype, "__defineSetter__", {
        value: function(that, prop, set) {
            if (!set) {
                set = prop;
                prop = that;
                that = this;
            }
            Object.defineProperty(that, prop, { set: set });
        },
        enumerable: false
    });
};
/*
* Envjs env-js.1.1.rc2 
* Pure JavaScript Browser Environment
*   By John Resig <http://ejohn.org/>
* Copyright 2008-2009 John Resig, under the MIT License
*/
/**
* @author thatcher
*/
Envjs = function() {
    if (arguments.length === 2) {
        for (var i in arguments[1]) {
            var g = arguments[1].__lookupGetter__(i),
                s = arguments[1].__lookupSetter__(i);
            if (g || s) {
                if (g) Envjs.__defineGetter__(i, g);
                if (s) Envjs.__defineSetter__(i, s);
            } else
                Envjs[i] = arguments[1][i];
        }
    }

    if (arguments[0] != null && arguments[0] != "")
        window.location.href = arguments[0];
};

/*
*	env.jint.js
*/
(function($env)
{

    //You can emulate different user agents by overriding these after loading env
    $env.appCodeName = "Jint"; //eg "Mozilla"
//    $env.appCodeName = "IE"; //eg "Mozilla"
    $env.appName = "Jint/1.0"; //eg "Gecko/20070309 Firefox/2.0.0.3"
//    $env.appName = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0)"; //eg "Gecko/20070309 Firefox/2.0.0.3"

    //set this to true and see profile/profile.js to select which methods
    //to profile
    $env.profile = false;

    $env.log = function(msg, level)
    {
        System.Console.WriteLine(msg);
    };

    $env.DEBUG = 4;
    $env.INFO = 3;
    $env.WARN = 2;
    $env.ERROR = 1;
    $env.NONE = 0;

    //set this if you want to get some internal log statements
    $env.logLevel = $env.DEBUG;

    $env.debug = function(msg)
    {
        if ($env.logLevel >= $env.DEBUG)
            $env.log(msg, "DEBUG");
    };
    $env.info = function(msg)
    {
        if ($env.logLevel >= $env.INFO)
            $env.log(msg, "INFO");
    };
    $env.warn = function(msg)
    {
        if ($env.logLevel >= $env.WARN)
            $env.log(msg, "WARNIING");
    };
    $env.error = function(msg, e)
    {
        if ($env.logLevel >= $env.ERROR)
        {
            $env.log(msg + " Line: " + $env.lineSource(e), 'ERROR');
            $env.log(e || "", 'ERROR');
        }
    };

    $env.info("Initializing Core Platform Env");


    // if we're running in an environment without env.js' custom extensions
    // for manipulating the JavaScript scope chain, put in trivial emulations
    $env.debug("performing check for custom Java methods in env-js.jar");
    var countOfMissing = 0, dontCare;
    if (!getFreshScopeObj) { getFreshScopeObj = function() { return {}; }; countOfMissing++; }
    if (!getProxyFor) { getProxyFor = function(obj) { return obj; }; countOfMissing++; }
    if (!getScope) { getScope = function() { }; countOfMissing++; }
    if (!setScope) { setScope = function() { }; countOfMissing++; }
    if (!configureScope) { configureScope = function() { }; countOfMissing++; }
    if (!restoreScope) { restoreScope = function() { }; countOfMissing++; }
    if (!loadIntoFnsScope) { $env.loadIntoFnsScope = load; countOfMissing++; }
    if (countOfMissing != 0 && countOfMissing != 7)
        $env.warn("Some but not all of scope-manipulation functions were " +
                  "not present in environment.  JavaScript execution may " +
                  "not occur correctly.");
    if (canLoadScript) { $env.canLoadScript = canLoadScript; }

    $env.lineSource = function(e) { };

    //resolves location relative to base or window location
    $env.location = function(path, base) { };

    $env.sync = function(fn)
    {
        var self = this;
        return function() { return fn.apply(self, arguments); }
    }

    //    $env.javaEnabled = false;	

    //Used in the XMLHttpRquest implementation to run a
    // request in a seperate thread
    $env.runAsync = function(fn) { };

    //Used to write to a local file
    $env.writeToFile = function(text, url) { };

    //Used to write to a local file
    $env.writeToTempFile = function(text, suffix) { };

    //Used to delete a local file
    $env.deleteFile = function(url) { };

    $env.connection = function(xhr, responseHandler, data) { };

    $env.parseHTML = function(htmlstring) { };
    $env.parseXML = function(xmlstring) { };
    $env.xpath = function(expression, doc) { };

    $env.tmpdir = '';
    $env.os_name = '';
    $env.os_arch = '';
    $env.os_version = '';
    $env.lang = '';
    $env.platform = "Rhino "; //how do we get the version

    if (!$env.canLoadScript)
    {
        $env.canLoadScript = function(script)
        {
            if (script.type == "text/javascript")
                return true;
            if (script.type == "text/envjs")
                return true;
        };
    }

    $env.onScriptLoadError = function() { };
    $env.loadLocalScript = function(script)
    {
        $env.debug("loading script ");
        var types, type, src, i, base,
            docWrites = [],
            write = document.write,
            writeln = document.writeln,
            okay = true;
        // SMP: see also the note in html/document.js about script.type
        var runat = script.getAttribute('runat');
        var script_type = script.type === null ? "text/javascript" : script.type;
        try
        {
            if (script_type)
            {
                if ($env.canLoadScript(script))
                {
                    if (script.src)
                    {
                        $env.info("loading allowed external script :" + script.src);
                        //lets you register a function to execute 
                        //before the script is loaded
                        if ($env.beforeScriptLoad)
                        {
                            for (src in $env.beforeScriptLoad)
                            {
                                if (script.src.match(src))
                                {
                                    $env.beforeScriptLoad[src]();
                                }
                            }
                        }
                        base = "" + window.location;
                        var filename = $env.location(script.src.match(/([^#]*)/)[1], base);
                        try
                        {
                            $env.loadIntoFnsScope(filename);
                        } catch (e)
                        {
                            $env.warn("could not load script " + filename + ": " + e);
                            okay = false;
                        }
                        //lets you register a function to execute 
                        //after the script is loaded
                        if ($env.afterScriptLoad)
                        {
                            for (src in $env.afterScriptLoad)
                            {
                                if (script.src.match(src))
                                {
                                    $env.afterScriptLoad[src]();
                                }
                            }
                        }
                    } else
                    {
                        $env.loadInlineScript(script);
                    }
                }
                else
                {
                    if (runat == 'proxy')
                    {
                        var serverSideScript = script.text;
                        script.setAttribute('runat', 'server');
                        script.text = serverSideScript;
                        script.setAttribute('runat', 'client');
                        script.text = ParseProxyCode(script.text);
                    }
                }
            } else
            {
                // SMP this branch is probably dead ...
                //anonymous type and anonymous src means inline
                if (!script.src)
                {
                    $env.loadInlineScript(script);
                }
            }
        } catch (e)
        {
            okay = false;
            $env.error("Error loading script.", e);
            $env.onScriptLoadError(script);
        } finally
        {
            /*if(parser){
            parser.appendFragment(docWrites.join(''));
            }
            //return document.write to it's non-script loading form
            document.write = write;
            document.writeln = writeln;*/
        }
        return okay;
    };

    $env.timer = __startTimer__;

    $env.loadInlineScript = function(script) { $env.debug("dummy script loader"); };
    $env.loadFrame = function(frameElement, url)
    {
        try
        {
            if (frameElement._content)
            {
                $env.unload(frameElement._content);
                $env.reload(frameElement._content, url);
            }
            else
                frameElement._content = $env.newwindow(this,
                    frameElement.ownerDocument.parentWindow, url);
        } catch (e)
        {
            $env.error("failed to load frame content: from " + url, e);
        }
    };

    $env.reload = function(oldWindowProxy, url)
    {
        var newWindowProxy = $env.newwindow(
                                 oldWindowProxy.opener,
                                 oldWindowProxy.parent,
                                 url);
        var newWindow = newWindowProxy.__proto__;

        oldWindowProxy.__proto__ = newWindow;
        newWindow.$thisWindowsProxyObject = oldWindowProxy;
        newWindow.document._parentWindow = oldWindowProxy;
    };

    $env.newwindow = function(openingWindow, parentArg, url)
    {
        var newWindow = $env.getFreshScopeObj();
        var newProxy = $env.getProxyFor(newWindow);
        newWindow.$thisWindowsProxyObject = newProxy;

        var local__window__ = $env.window,
            local_env = $env,
            local_opener = openingWindow,
            local_parent = parentArg ? parentArg : newWindow;

        var inNewContext = function()
        {
            local__window__(newWindow,        // object to "window-ify"
                            local_env,        // our scope for globals
                            local_parent,     // win's "parent"
                            local_opener,     // win's "opener"
                            local_parent.top, // win's "top"
                            false             // this win isn't the original
                           );
            if (url)
                $env.load(url);
        };

        var scopes = recordScopesOfKeyObjects(inNewContext);
        setScopesOfKeyObjects(inNewContext, newWindow);
        inNewContext(); // invoke local fn to window-ify new scope object
        restoreScopesOfKeyObjects(inNewContext, scopes);
        return newProxy;
    };

    function recordScopesOfKeyObjects(fnToExecInOtherContext)
    {
        return {                //   getScope()/setScope() from Window.java
            frame: getScope(fnToExecInOtherContext),
            window: getScope($env.window),
            global_load: getScope($env.loadIntoFnsScope),
            local_load: getScope($env.loadLocalScript)
        };
    }

    function setScopesOfKeyObjects(fnToExecInOtherContext, windowObj)
    {
        setScope(fnToExecInOtherContext, windowObj);
        setScope($env.window, windowObj);
        setScope($env.loadIntoFnsScope, windowObj);
        setScope($env.loadLocalScript, windowObj);
    }

    function restoreScopesOfKeyObjects(fnToExecInOtherContext, scopes)
    {
        setScope(fnToExecInOtherContext, scopes.frame);
        setScope($env.window, scopes.window);
        setScope($env.loadIntoFnsScope, scopes.global_load);
        setScope($env.loadLocalScript, scopes.local_load);
    }
})(Envjs);

/*
*	env.jint.js
*/
(function($env)
{

    $env.log = function(msg, level)
    {
        print(' ' + (level ? level : 'LOG') + ':\t[' + new Date() + "] {ENVJS} " + msg);
    };

    $env.lineSource = function(e)
    {
        return e && e.jintException ? e.jintException.lineSource() : "(line ?)";
    };

    //    $env.sync = sync;

    $env.location = function(path, base)
    {
        var protocol = new RegExp('(^file\:|^http\:|^https\:)');
        var m = protocol.exec(path);
        if (m && m.length > 1)
        {
            return new System.Uri(path).ToString();
        } else if (base)
        {
            return new System.Uri(new System.Uri(base), path).ToString();
        } else
        {
            //return an absolute url from a url relative to the window location
            base = window.location.substring(0, window.location.href.lastIndexOf('/'));
            if (window.location.length > 0)
            {
                if (path[0] == '/')
                    return base + path;
                return base + '/' + path;
            } else
            {
                return System.Uri.UriFileScheme + path;
            }
        }
    };

    //Since we're running in rhino I guess we can safely assume
    //java is 'enabled'.  I'm sure this requires more thought
    //than I've given it here
    //    $env.javaEnabled = true;	


    //Used in the XMLHttpRquest implementation to run a
    // request in a seperate thread
    $env.onInterrupt = function() { };
    $env.runAsync = function(fn)
    {
        $env.debug("running async");
        var running = true;

        var run = $env.sync(function()
        { //while happening only thing in this timer    
            //$env.debug("running timed function");
            fn();
        });

        try
        {
            run();
        } catch (e)
        {
            $env.error("error while running async", e.message);
            $env.onInterrupt();
        }
    };

    //Used to write to a local file
    $env.writeToFile = function(text, url)
    {
        $env.debug("writing text to url : " + url);
        var out = System.IO.File.Open(url.toString());
        out.write(text, 0, text.length);
        out.flush();
        out.close();
    };

    //Used to write to a local file
    $env.writeToTempFile = function(text, suffix)
    {
        var url = System.Environment.GetFolderPath(System.Environment.SpecialFolder.InternetCache) + "\\envjs-tmp-" + suffix;
        $env.debug("writing text to temp url : " + url);
        // Create temp file.
        //        throw new System.NotImplementedException("writeToTempFile");
        System.IO.File.WriteAllText(url, text);

        // Delete temp file when program exits.
        //temp.deleteOnExit();

        // Write to temp file
        //        var out = new java.io.FileWriter(temp);
        //        temp.Write(text, 0, text.length);
        //        temp.Close();
        return url;
    };

    //Used to delete a local file
    $env.deleteFile = function(url)
    {
        System.IO.File.Delete(url);
    };

    $env.connection = function(xhr, responseHandler, data)
    {
        var url = new System.Uri(xhr.url); //, $w.location);
        var connection;
        var response;
        if (/^file\:/.test(url))
        {
            try
            {
                if (xhr.method == "PUT")
                {
                    var text = data || "";
                    $env.writeToFile(text, url);
                } else if (xhr.method == "DELETE")
                {
                    $env.deleteFile(url);
                } else
                {
                    connection = System.Net.WebRequest.Create(url);
                    for (var cookieName in $cookies.temporary[url.Host][url.LocalPath])
                    {
                        connection.Cookies[cookieName] = $cookies.temporary[url.Host][url.LocalPath];
                    }
                    connection.Headers["User-Agent"] = $env.appName;
                    response = connection.GetResponse();
                    for (var cookieName in response.Cookies.Keys)
                    {
                        $cookies.temporary[url.Host][url.LocalPath][cookieName] = response.Cookies[cookieName];
                    }
                    //                    connection = url.openConnection();
                    //                    connection.connect();
                    //try to add some canned headers that make sense

                    try
                    {
                        if (xhr.url.match(/html$/))
                        {
                            xhr.responseHeaders["Content-Type"] = 'text/html';
                        } else if (xhr.url.match(/.xml$/))
                        {
                            xhr.responseHeaders["Content-Type"] = 'text/xml';
                        } else if (xhr.url.match(/.js$/))
                        {
                            xhr.responseHeaders["Content-Type"] = 'text/javascript';
                        } else if (xhr.url.match(/.json$/))
                        {
                            xhr.responseHeaders["Content-Type"] = 'application/json';
                        } else
                        {
                            xhr.responseHeaders["Content-Type"] = 'text/plain';
                        }
                        //xhr.responseHeaders['Last-Modified'] = connection.getLastModified();
                        //xhr.responseHeaders['Content-Length'] = headerValue+'';
                        //xhr.responseHeaders['Date'] = new Date()+'';*/
                    } catch (e)
                    {
                        $env.error('failed to load response headers', e);
                    }

                }
            } catch (e)
            {
                $env.error('failed to open file ' + url, e);
                connection = null;
                xhr.readyState = 4;
                xhr.statusText = "Local File Protocol Error";
                xhr.responseText = "<html><head/><body><p>" + e + "</p></body></html>";
            }
        } else
        {
            connection = System.Net.WebRequest.Create(url);
            connection.Method = xhr.method;

            // Add headers to Java connection
            for (var header in xhr.headers)
            {
                connection[header + ''] = xhr.headers[header] + '';
            }

            for (var cookieName in $cookies.temporary[url.Host][url.LocalPath])
            {
                connection.CookieContainer.AddCookie(new System.Net.Cookie(cookieName,$cookies.temporary[url.Host][url.LocalPath],url.LocalPath,url.Host));
            }
            connection.UserAgent = $env.appName;

            //write data to output stream if required
            if (data && data.length && data.length > 0)
            {
                if (xhr.method == "PUT" || xhr.method == "POST")
                {
                    //                	connection.setDoOutput(true);
                    var outstream = connection.GetRequestStream(),
						outbuffer = System.Text.Encoding.UTF8.GetBytes(data);

                    outstream.write(outbuffer, 0, outbuffer.length);
                    outstream.close();
                }
            } else
            {
                var response = connection.GetResponse();

            }


        }
        if (response)
        {
            try
            {
                var respheadlength = response.Headers.Count;
                // Stick the response headers into responseHeaders
                for (var i = 0; i < respheadlength; i++)
                {
                    var headerName = response.Headers.Keys[i];
                    var headerValue = response.Headers.Values[i];
                    if (headerName)
                        xhr.responseHeaders[headerName + ''] = headerValue + '';
                }
                var cookieLength = response.Cookies.Count;
                for (var i = 0; i < cookieLength; i++)
                {
                    var cookieName = response.Cookies.AllKeys[i];
                    $cookies.temporary[url.Host][url.LocalPath][cookieName] = response.Cookies[cookieName];
                }
            } catch (e)
            {
                $env.error('failed to load response headers', e);
            }

            xhr.readyState = 4;
            xhr.status = parseInt(response.StatusCode, 10) || undefined;
            xhr.statusText = response.StatusDescription || "";

            var contentEncoding = response.ContentEncoding || System.Text.Encoding.UTF8;
            var reader = new System.IO.StreamReader(response.GetResponseStream(), contentEncoding);

            xhr.responseText = reader.ReadToEnd();

            reader.Close();

        }
        if (responseHandler)
        {
            $env.debug('calling ajax response handler');
            responseHandler();
        }
    };

    var tidy;
    $env.tidyHTML = true;
    $env.tidy = function(htmlString)
    {
        loadAssembly("Jint.Env");
        //$env.debug('Cleaning html :\n' + htmlString);
        var xmlString;
        try
        {
            if (!tidy)
            {
                tidy = new Jint.Env.Tidy();
            }
            $env.debug('tidying');
            xmlString = tidy.Parse(htmlString);
            $env.debug('finished tidying');
        } catch (e)
        {
            $env.error('error in html tidy', e);
        }
        //$env.debug('Cleaned html :\n' + xmlString);
        return xmlString;
    };

    //    xmlDocBuilder.setNamespaceAware(true);
    //    xmlDocBuilder.setValidating(false);

    $env.parseXML = function(xmlstring)
    {
        var xmlDocBuilder = new System.Xml.XmlDocument();
        xmlDocBuilder.LoadXml(xmlstring);
        return xmlDocBuilder;
        //        return xmlDocBuilder.newDocumentBuilder().parse(
        //                  new java.io.ByteArrayInputStream(
        //                        (new java.lang.String(xmlstring)).getBytes("UTF8")));
    };


    $env.xpath = function(expression, doc)
    {
        return Packages.javax.xml.xpath.
          XPathFactory.newInstance().newXPath().
            evaluate(expression, doc, javax.xml.xpath.XPathConstants.NODESET);
    };

    var jsonmlxslt;
    $env.jsonml = function(xmlstring)
    {
        jsonmlxslt = jsonmlxslt || $env.xslt($env.xml2jsonml.toXMLString());
        var jsonml = $env.transform(jsonmlxslt, xmlstring);
        //$env.debug('jsonml :\n'+jsonml);
        return eval(jsonml);
    };
    var transformerFactory;
    $env.xslt = function(xsltstring)
    {
        transformerFactory = transformerFactory ||
            Packages.javax.xml.transform.TransformerFactory.newInstance();
        return transformerFactory.newTransformer(
              new javax.xml.transform.dom.DOMSource(
                  $env.parseXML(xsltstring)
              )
          );
    };
    $env.transform = function(xslt, xmlstring)
    {
        var baos = new java.io.ByteArrayOutputStream();
        xslt.transform(
            new javax.xml.transform.dom.DOMSource($env.parseHTML(xmlstring)),
            new javax.xml.transform.stream.StreamResult(baos)
        );
        return java.nio.charset.Charset.forName("UTF-8").
            decode(java.nio.ByteBuffer.wrap(baos.toByteArray())).toString() + "";
    };

    $env.tmpdir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.InternetCache);
    $env.os_name = "Windows";
    $env.os_arch = "x64";
    $env.os_version = "6.1";
    $env.lang = "fr-FR";
    $env.platform = "Jint "; //how do we get the version

    $env.scriptTypes = {
        "text/javascript": false,
        "text/envjs": true
    };


    $env.loadInlineScript = function(script)
    {
        eval(script.text);
    };

    //injected by org.mozilla.javascript.tools.envjs.
    $env.getFreshScopeObj = getFreshScopeObj;
    $env.getProxyFor = getProxyFor;
    $env.getScope = getScope;
    $env.setScope = setScope;
    $env.configureScope = configureScope;
    $env.restoreScope = restoreScope;
    $env.loadIntoFnsScope = loadIntoFnsScope;

})(Envjs);