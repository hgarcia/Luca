# Luca #
---

JavaScript web development in .NET

### What Luca gives you? 

*	a Sinatra like server side DSL.
*	a javascript Framework to write web applications in the .net platform.
*	a set of generators and tools to jump start your development (inspired by Rails).

### Overview

At the moment, Luca uses a modified version of [Jint](http://jint.codeplex.com) as it's javascript engine.
The modifications in the engine allows to extend JavaScript with native implementation of common libraries like [Prototype](http://www.prototypejs.org/) or [underscore](http://documentcloud.github.com/underscore/).

Luca tries to incorporate different aspects of different frameworks that I like. 

*	Command line generators to do common or repetitive tasks (from Rails).
*	A simple sintax to map requests to handlers based on route and HTTP verb (from Sinatra).
*	Decoupling the resource and presentation (from OpenRasta).
*	A DSL for more expressive code.
*	The ability to use any .net class available.
*	Integrated Test-framework and Test-runner for BDD.
*	A simple templating engine.
*	Default serialization for some common content-types: html, csv, xml, json.

### Roadmap

1.	Command line application generator. v: 0.1
2.	Prototype + underscore included in the engine. v: 0.1
3.	Application object included in the engine. v: 0.1
4.	Jade template engine. v: 0.1
5.	Default JSON serialization. v: 0.1
6.	Default serializations for html, csv, xml.
7.	Scaffold generator.
8.	Resource controller generator.
9.	Integration with Test framework and test runner.
10.	Decoupling of resource and presentation.
11.	Implementation of import('package_name').
12.	Installer.
13.	Integration with WebMatrix.
14.	Validation.
15.	Plug-in engine.
16.	MongoDB integration.
17.	Common db interface.
18.	Active-record implementation.
19. Repository of T implementation.
20.	Integrate with gems.
