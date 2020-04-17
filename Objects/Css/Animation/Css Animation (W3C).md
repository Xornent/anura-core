<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Animations Level 1</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="refining" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="This CSS module describes a way for authors to animate the values of CSS properties over time, using keyframes. The behavior of these keyframe animations can be controlled by specifying their duration, number of repeats, and repeating behavior.  " name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/css-animations-1/" rel="canonical">
<script defer src="https://test.csswg.org/harness/annotate.js#!css-animations-1_dev/css-animations-1" type="text/javascript"></script>
<style type="text/css">
  table.event-handlers {
    border-collapse: collapse;
  }
  table.event-handlers th,
  table.event-handlers td {
    padding: 0.2em 1em;
  }
  table.event-handlers td {
    border: 1px solid black;
  }
</style>
<style>/* style-autolinks */

.css.css, .property.property, .descriptor.descriptor {
    color: #005a9c;
    font-size: inherit;
    font-family: inherit;
}
.css::before, .property::before, .descriptor::before {
    content: "‘";
}
.css::after, .property::after, .descriptor::after {
    content: "’";
}
.property, .descriptor {
    /* Don't wrap property and descriptor names */
    white-space: nowrap;
}
.type { /* CSS value <type> */
    font-style: italic;
}
pre .property::before, pre .property::after {
    content: "";
}
[data-link-type="property"]::before,
[data-link-type="propdesc"]::before,
[data-link-type="descriptor"]::before,
[data-link-type="value"]::before,
[data-link-type="function"]::before,
[data-link-type="at-rule"]::before,
[data-link-type="selector"]::before,
[data-link-type="maybe"]::before {
    content: "‘";
}
[data-link-type="property"]::after,
[data-link-type="propdesc"]::after,
[data-link-type="descriptor"]::after,
[data-link-type="value"]::after,
[data-link-type="function"]::after,
[data-link-type="at-rule"]::after,
[data-link-type="selector"]::after,
[data-link-type="maybe"]::after {
    content: "’";
}

[data-link-type].production::before,
[data-link-type].production::after,
.prod [data-link-type]::before,
.prod [data-link-type]::after {
    content: "";
}

[data-link-type=element],
[data-link-type=element-attr] {
    font-family: Menlo, Consolas, "DejaVu Sans Mono", monospace;
    font-size: .9em;
}
[data-link-type=element]::before { content: "<" }
[data-link-type=element]::after  { content: ">" }

[data-link-type=biblio] {
    white-space: pre;
}</style>
<style>/* style-counters */

body {
    counter-reset: example figure issue;
}
.issue {
    counter-increment: issue;
}
.issue:not(.no-marker)::before {
    content: "Issue " counter(issue);
}

.example {
    counter-increment: example;
}
.example:not(.no-marker)::before {
    content: "Example " counter(example);
}
.invalid.example:not(.no-marker)::before,
.illegal.example:not(.no-marker)::before {
    content: "Invalid Example" counter(example);
}

figcaption {
    counter-increment: figure;
}
figcaption:not(.no-marker)::before {
    content: "Figure " counter(figure) " ";
}</style>
<style>/* style-dfn-panel */

.dfn-panel {
    position: absolute;
    z-index: 35;
    height: auto;
    width: -webkit-fit-content;
    width: fit-content;
    max-width: 300px;
    max-height: 500px;
    overflow: auto;
    padding: 0.5em 0.75em;
    font: small Helvetica Neue, sans-serif, Droid Sans Fallback;
    background: #DDDDDD;
    color: black;
    border: outset 0.2em;
}
.dfn-panel:not(.on) { display: none; }
.dfn-panel * { margin: 0; padding: 0; text-indent: 0; }
.dfn-panel > b { display: block; }
.dfn-panel a { color: black; }
.dfn-panel a:not(:hover) { text-decoration: none !important; border-bottom: none !important; }
.dfn-panel > b + b { margin-top: 0.25em; }
.dfn-panel ul { padding: 0; }
.dfn-panel li { list-style: inside; }
.dfn-panel.activated {
    display: inline-block;
    position: fixed;
    left: .5em;
    bottom: 2em;
    margin: 0 auto;
    max-width: calc(100vw - 1.5em - .4em - .5em);
    max-height: 30vh;
}

.dfn-paneled { cursor: pointer; }
</style>
<style>/* style-md-lists */

/* This is a weird hack for me not yet following the commonmark spec
   regarding paragraph and lists. */
[data-md] > :first-child {
    margin-top: 0;
}
[data-md] > :last-child {
    margin-bottom: 0;
}</style>
<style>/* style-mdn-anno */

            @media (max-width: 767px) { .mdn-anno { opacity: .1 } }
            .mdn-anno { font: 1em sans-serif; padding: 0.3em; position: absolute; z-index: 8; right: 0.3em; background: #EEE; color: black; box-shadow: 0 0 3px #999; overflow: hidden; border-collapse: initial; border-spacing: initial; min-width: 9em; max-width: min-content; white-space: nowrap; word-wrap: normal; hyphens: none}
            .mdn-anno:not(.wrapped) { opacity: 1}
            .mdn-anno:hover { z-index: 9 }
            .mdn-anno.wrapped { min-width: 0 }
            .mdn-anno.wrapped > :not(button) { display: none; }
            .mdn-anno > .mdn-anno-btn { cursor: pointer; border: none; color: #000; background: transparent; margin: -8px; float: right; padding: 10px 8px 8px 8px; outline: none; }
            .mdn-anno > .mdn-anno-btn > .less-than-two-engines-flag { color: red; padding-right: 2px; }
            .mdn-anno > .mdn-anno-btn > .all-engines-flag { color: green; padding-right: 2px; }
            .mdn-anno > .mdn-anno-btn > span { color: #fff; background-color: #000; font-weight: normal; font-family: zillaslab, Palatino, "Palatino Linotype", serif; padding: 2px 3px 0px 3px; line-height: 1.3em; vertical-align: top; }
            .mdn-anno > .feature { margin-top: 20px; }
            .mdn-anno > .feature:not(:first-of-type) { border-top: 1px solid #999; margin-top: 6px; padding-top: 2px; }
            .mdn-anno > .feature > .less-than-two-engines-text { color: red }
            .mdn-anno > .feature > .all-engines-text { color: green }
            .mdn-anno > .feature > p { font-size: .75em; margin-top: 6px; margin-bottom: 0; }
            .mdn-anno > .feature > p + p { margin-top: 3px; }
            .mdn-anno > .feature > .support { display: block; font-size: 0.6em; margin: 0; padding: 0; margin-top: 2px }
            .mdn-anno > .feature > .support + div { padding-top: 0.5em; }
            .mdn-anno > .feature > .support > hr { display: block; border: none; border-top: 1px dotted #999; padding: 3px 0px 0px 0px; margin: 2px 3px 0px 3px; }
            .mdn-anno > .feature > .support > hr::before { content: ""; }
            .mdn-anno > .feature > .support > span { padding: 0.2em 0; display: block; display: table; }
            .mdn-anno > .feature > .support > span.no { color: #CCCCCC; filter: grayscale(100%); }
            .mdn-anno > .feature > .support > span.no::before { opacity: 0.5; }
            .mdn-anno > .feature > .support > span:first-of-type { padding-top: 0.5em; }
            .mdn-anno > .feature > .support > span > span { padding: 0 0.5em; display: table-cell; }
            .mdn-anno > .feature > .support > span > span:first-child { width: 100%; }
            .mdn-anno > .feature > .support > span > span:last-child { width: 100%; white-space: pre; padding: 0; }
            .mdn-anno > .feature > .support > span::before { content: ' '; display: table-cell; min-width: 1.5em; height: 1.5em; background: no-repeat center center; background-size: contain; text-align: right; font-size: 0.75em; font-weight: bold; }
            .mdn-anno > .feature > .support > .chrome_android::before { background-image: url(https://resources.whatwg.org/browser-logos/chrome.svg); }
            .mdn-anno > .feature > .support > .firefox_android::before { background-image: url(https://resources.whatwg.org/browser-logos/firefox.png); }
            .mdn-anno > .feature > .support > .chrome::before { background-image: url(https://resources.whatwg.org/browser-logos/chrome.svg); }
            .mdn-anno > .feature > .support > .edge_blink::before { background-image: url(https://resources.whatwg.org/browser-logos/edge.svg); }
            .mdn-anno > .feature > .support > .edge::before { background-image: url(https://resources.whatwg.org/browser-logos/edge_legacy.svg); }
            .mdn-anno > .feature > .support > .firefox::before { background-image: url(https://resources.whatwg.org/browser-logos/firefox.png); }
            .mdn-anno > .feature > .support > .ie::before { background-image: url(https://resources.whatwg.org/browser-logos/ie.png); }
            .mdn-anno > .feature > .support > .safari_ios::before { background-image: url(https://resources.whatwg.org/browser-logos/safari-ios.svg); }
            .mdn-anno > .feature > .support > .nodejs::before { background-image: url(https://nodejs.org/static/images/favicons/favicon.ico); }
            .mdn-anno > .feature > .support > .opera_android::before { background-image: url(https://resources.whatwg.org/browser-logos/opera.svg); }
            .mdn-anno > .feature > .support > .opera::before { background-image: url(https://resources.whatwg.org/browser-logos/opera.svg); }
            .mdn-anno > .feature > .support > .safari::before { background-image: url(https://resources.whatwg.org/browser-logos/safari.png); }
            .mdn-anno > .feature > .support > .samsunginternet_android::before { background-image: url(https://resources.whatwg.org/browser-logos/samsung.svg); }
            .mdn-anno > .feature > .support > .webview_android::before { background-image: url(https://resources.whatwg.org/browser-logos/android-webview.png); }
            .name-slug-mismatch { color: red }
            </style>
<style>/* style-selflinks */

.heading, .issue, .note, .example, li, dt {
    position: relative;
}
a.self-link {
    position: absolute;
    top: 0;
    left: calc(-1 * (3.5rem - 26px));
    width: calc(3.5rem - 26px);
    height: 2em;
    text-align: center;
    border: none;
    transition: opacity .2s;
    opacity: .5;
}
a.self-link:hover {
    opacity: 1;
}
.heading > a.self-link {
    font-size: 83%;
}
li > a.self-link {
    left: calc(-1 * (3.5rem - 26px) - 2em);
}
dfn > a.self-link {
    top: auto;
    left: auto;
    opacity: 0;
    width: 1.5em;
    height: 1.5em;
    background: gray;
    color: white;
    font-style: normal;
    transition: opacity .2s, background-color .2s, color .2s;
}
dfn:hover > a.self-link {
    opacity: 1;
}
dfn > a.self-link:hover {
    color: black;
}

a.self-link::before            { content: "¶"; }
.heading > a.self-link::before { content: "§"; }
dfn > a.self-link::before      { content: "#"; }</style>
<style>/* style-syntax-highlighting */
pre.idl.highlight { color: #708090; }
.highlight:not(.idl) { background: hsl(24, 20%, 95%); }
code.highlight { padding: .1em; border-radius: .3em; }
pre.highlight, pre > code.highlight { display: block; padding: 1em; margin: .5em 0; overflow: auto; border-radius: 0; }
c-[a] { color: #990055 } /* Keyword.Declaration */
c-[b] { color: #990055 } /* Keyword.Type */
c-[c] { color: #708090 } /* Comment */
c-[d] { color: #708090 } /* Comment.Multiline */
c-[e] { color: #0077aa } /* Name.Attribute */
c-[f] { color: #669900 } /* Name.Tag */
c-[g] { color: #222222 } /* Name.Variable */
c-[k] { color: #990055 } /* Keyword */
c-[l] { color: #000000 } /* Literal */
c-[m] { color: #000000 } /* Literal.Number */
c-[n] { color: #0077aa } /* Name */
c-[o] { color: #999999 } /* Operator */
c-[p] { color: #999999 } /* Punctuation */
c-[s] { color: #a67f59 } /* Literal.String */
c-[t] { color: #a67f59 } /* Literal.String.Single */
c-[u] { color: #a67f59 } /* Literal.String.Double */
c-[cp] { color: #708090 } /* Comment.Preproc */
c-[c1] { color: #708090 } /* Comment.Single */
c-[cs] { color: #708090 } /* Comment.Special */
c-[kc] { color: #990055 } /* Keyword.Constant */
c-[kn] { color: #990055 } /* Keyword.Namespace */
c-[kp] { color: #990055 } /* Keyword.Pseudo */
c-[kr] { color: #990055 } /* Keyword.Reserved */
c-[ld] { color: #000000 } /* Literal.Date */
c-[nc] { color: #0077aa } /* Name.Class */
c-[no] { color: #0077aa } /* Name.Constant */
c-[nd] { color: #0077aa } /* Name.Decorator */
c-[ni] { color: #0077aa } /* Name.Entity */
c-[ne] { color: #0077aa } /* Name.Exception */
c-[nf] { color: #0077aa } /* Name.Function */
c-[nl] { color: #0077aa } /* Name.Label */
c-[nn] { color: #0077aa } /* Name.Namespace */
c-[py] { color: #0077aa } /* Name.Property */
c-[ow] { color: #999999 } /* Operator.Word */
c-[mb] { color: #000000 } /* Literal.Number.Bin */
c-[mf] { color: #000000 } /* Literal.Number.Float */
c-[mh] { color: #000000 } /* Literal.Number.Hex */
c-[mi] { color: #000000 } /* Literal.Number.Integer */
c-[mo] { color: #000000 } /* Literal.Number.Oct */
c-[sb] { color: #a67f59 } /* Literal.String.Backtick */
c-[sc] { color: #a67f59 } /* Literal.String.Char */
c-[sd] { color: #a67f59 } /* Literal.String.Doc */
c-[se] { color: #a67f59 } /* Literal.String.Escape */
c-[sh] { color: #a67f59 } /* Literal.String.Heredoc */
c-[si] { color: #a67f59 } /* Literal.String.Interpol */
c-[sx] { color: #a67f59 } /* Literal.String.Other */
c-[sr] { color: #a67f59 } /* Literal.String.Regex */
c-[ss] { color: #a67f59 } /* Literal.String.Symbol */
c-[vc] { color: #0077aa } /* Name.Variable.Class */
c-[vg] { color: #0077aa } /* Name.Variable.Global */
c-[vi] { color: #0077aa } /* Name.Variable.Instance */
c-[il] { color: #000000 } /* Literal.Number.Integer.Long */
</style>
 <script nonce='2xXi4Sl8bBaZZiwhrtp1z466KFBlj6h9dBCL33N2eRA=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='2xXi4Sl8bBaZZiwhrtp1z466KFBlj6h9dBCL33N2eRA=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="css-animations-1\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
// --></script><style type='text/css'><!-- a#generator { width: 32px; height: 32px; display: block; position: fixed; right: 0; top: 0;
 border-bottom-left-radius: 5px; background: #f4f4f4; box-shadow: 2px 0px 3px #444;
 background-image: linear-gradient(to bottom, #eee, #fff 15%, #ededed 80%, #e0e0e0);
}
a#generator:focus { outline: none;}
a#generator svg { position: absolute; right: 3px; top: 3px; }
@keyframes fill {
0%, 100% { fill: blue; }
16% { fill: purple; }
33% { fill: hsl(0, 100%, 60%); }
50% { fill: orange; }
67% { fill: gold; }
83% { fill: hsl(120, 100%, 25%); }
}
@keyframes stroke {
0%, 100% { stroke: blue; }
16% { stroke: purple; }
33% { stroke: hsl(0, 100%, 60%); }
50% { stroke: orange; }
67% { stroke: gold; }
83% { stroke: hsl(120, 100%, 25%); }
}
a#generator.fatal [fill=blue], a#generator.error [fill=blue], .previous [fill=blue] { fill: #d00; }
a#generator.fatal [stroke=blue], a#generator.error [stroke=blue], .previous [stroke=blue] { stroke: #d00; }
a#generator.warning [fill=blue] { fill: #0df; }
a#generator.warning [stroke=blue] { stroke: #0df; }
a#generator.link-error [fill=blue] { fill: #cc0; }
a#generator.link-error [stroke=blue] { stroke: #cc0; }
a#generator.success [fill=blue] { fill: #0b0; }
a#generator.success [stroke=blue] { stroke: #0b0; }
a#generator [fill=blue], [stroke=blue] { animation: n 5s infinite linear; transition: fill 1s, stroke 1s; }
a#generator.pending [stroke=blue] { animation-name: stroke; }
a#generator.pending [fill=blue] { animation-name: fill; }
a#generator.generating [stroke=blue] { animation-name: stroke; }
a#generator.generating [fill=blue] { animation-name: fill; } --></style><body class="h-entry">
  <div class="head">
   <p data-fill-with="logo"><a class="logo" href="https://www.w3.org/"> <img alt="W3C" height="48" src="https://www.w3.org/StyleSheets/TR/2016/logos/W3C" width="72"> </a> </p>
   <h1 class="p-name no-ref" id="title">CSS Animations Level 1</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-01-16">16 January 2020</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/css-animations/">https://drafts.csswg.org/css-animations/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/css-animations-1/">https://www.w3.org/TR/css-animations-1/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2018/WD-css-animations-1-20181011/" rel="prev">https://www.w3.org/TR/2018/WD-css-animations-1-20181011/</a>
      <dd><a href="https://www.w3.org/TR/2017/WD-css-animations-1-20171130/" rel="prev">https://www.w3.org/TR/2017/WD-css-animations-1-20171130/</a>
      <dd><a href="https://www.w3.org/TR/2013/WD-css3-animations-20130219/" rel="prev">https://www.w3.org/TR/2013/WD-css3-animations-20130219/</a>
      <dd><a href="https://www.w3.org/TR/2012/WD-css3-animations-20120403/" rel="prev">https://www.w3.org/TR/2012/WD-css3-animations-20120403/</a>
      <dt>Test Suite:
      <dd><a href="http://test.csswg.org/suites/css-animations-1_dev/nightly-unstable/">http://test.csswg.org/suites/css-animations-1_dev/nightly-unstable/</a>
      <dt>Issue Tracking:
      <dd><a href="#issues-index">Inline In Spec</a>
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/css-animations-1">GitHub Issues</a>
      <dt class="editor">Editors:
      <dd class="editor p-author h-card vcard" data-editor-id="42080"><a class="p-name fn u-email email" href="mailto:dino@apple.com">Dean Jackson</a> (<span class="p-org org">Apple Inc.</span>)
      <dd class="editor p-author h-card vcard" data-editor-id="15393"><a class="p-name fn u-url url" href="https://dbaron.org/">L. David Baron</a> (<a class="p-org org" href="https://www.mozilla.org/">Mozilla</a>)
      <dd class="editor p-author h-card vcard" data-editor-id="42199"><a class="p-name fn u-url url" href="http://xanthir.com/contact/">Tab Atkins Jr.</a> (<span class="p-org org">Google</span>)
      <dd class="editor p-author h-card vcard" data-editor-id="43194"><a class="p-name fn u-email email" href="mailto:brian@birchill.co.jp">Brian Birtles</a> (<span class="p-org org">Invited Expert</span>)
      <dt class="editor">Former Editors:
      <dd class="editor p-author h-card vcard"><span class="p-name fn">David Hyatt</span> (<span class="p-org org">Apple Inc.</span>)
      <dd class="editor p-author h-card vcard"><span class="p-name fn">Chris Marrin</span> (<span class="p-org org">Apple Inc.</span>)
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:galineau@adobe.com">Sylvain Galineau</a> (<span class="p-org org">Adobe</span>)
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/css-animations-1/Overview.bs">GitHub Editor</a>
      <dt>Issues List:
      <dd><a href="https://www.w3.org/Bugs/Public/buglist.cgi?component=Animations&amp;list_id=36653&amp;product=CSS&amp;query_format=advanced&amp;resolution=---">In Bugzilla</a>
      <dd>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This CSS module describes a way for authors to animate the values of CSS properties over time, using keyframes. The behavior of these keyframe animations can be controlled by specifying their duration, number of repeats, and repeating behavior.</p>
    <a href="https://www.w3.org/TR/CSS/">CSS</a> is a language for describing the rendering of structured documents
(such as HTML and XML)
on screen, on paper, etc. 
  </div>
  <h2 class="no-num no-toc no-ref heading settled" id="status"><span class="content">Status of this document</span></h2>
  <div data-fill-with="status">
   <p> This is a public copy of the editors’ draft.
	It is provided for discussion only and may change at any moment.
	Its publication here does not imply endorsement of its contents by W3C.
	Don’t cite this document other than as work in progress. </p>
   <p> <a href="https://github.com/w3c/csswg-drafts/issues">GitHub Issues</a> are preferred for discussion of this specification.
	When filing an issue, please put the text “css-animations” in the title,
	preferably like this:
	“[css-animations] <i data-lt>…summary of comment…</i>”.
	All issues and comments are <a href="https://lists.w3.org/Archives/Public/public-css-archive/">archived</a>,
	and there is also a <a href="https://lists.w3.org/Archives/Public/www-style/">historical archive</a>. </p>
   <p> This document was produced by the <a href="https://www.w3.org/Style/CSS/">CSS Working Group</a>. </p>
   <p> This document was produced by a group operating under
	the <a href="https://www.w3.org/Consortium/Patent-Policy/">W3C Patent Policy</a>.
	W3C maintains a <a href="https://www.w3.org/2004/01/pp-impl/32061/status" rel="disclosure">public list of any patent disclosures</a> made in connection with the deliverables of the group;
	that page also includes instructions for disclosing a patent.
	An individual who has actual knowledge of a patent which the individual believes contains <a href="https://www.w3.org/Consortium/Patent-Policy/#def-essential">Essential Claim(s)</a> must disclose the information in accordance with <a href="https://www.w3.org/Consortium/Patent-Policy/#sec-Disclosure">section 6 of the W3C Patent Policy</a>. </p>
   <p> This document is governed by the <a href="https://www.w3.org/2019/Process-20190301/" id="w3c_process_revision">1 March 2019 W3C Process Document</a>. </p>
   <p></p>
  </div>
  <div data-fill-with="at-risk"></div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li>
     <a href="#intro"><span class="secno">1</span> <span class="content"> Introduction</span></a>
     <ol class="toc">
      <li><a href="#values"><span class="secno">1.1</span> <span class="content"> Value Definitions</span></a>
     </ol>
    <li><a href="#animations"><span class="secno">2</span> <span class="content"> Animations</span></a>
    <li>
     <a href="#keyframes"><span class="secno">3</span> <span class="content"> Keyframes</span></a>
     <ol class="toc">
      <li><a href="#timing-functions"><span class="secno">3.1</span> <span class="content"> Timing functions for keyframes</span></a>
      <li><a href="#animation-name"><span class="secno">3.2</span> <span class="content"> The <span class="property">animation-name</span> property</span></a>
      <li><a href="#animation-duration"><span class="secno">3.3</span> <span class="content"> The <span class="property">animation-duration</span> property</span></a>
      <li><a href="#animation-timing-function"><span class="secno">3.4</span> <span class="content"> The <span class="property">animation-timing-function</span> property</span></a>
      <li><a href="#animation-iteration-count"><span class="secno">3.5</span> <span class="content"> The <span class="property">animation-iteration-count</span> property</span></a>
      <li><a href="#animation-direction"><span class="secno">3.6</span> <span class="content"> The <span class="property">animation-direction</span> property</span></a>
      <li><a href="#animation-play-state"><span class="secno">3.7</span> <span class="content"> The <span class="property">animation-play-state</span> property</span></a>
      <li><a href="#animation-delay"><span class="secno">3.8</span> <span class="content"> The <span class="property">animation-delay</span> property</span></a>
      <li><a href="#animation-fill-mode"><span class="secno">3.9</span> <span class="content"> The <span class="property">animation-fill-mode</span> property</span></a>
      <li><a href="#animation"><span class="secno">3.10</span> <span class="content"> The <span class="property">animation</span> shorthand property</span></a>
     </ol>
    <li>
     <a href="#events"><span class="secno">4</span> <span class="content"> Animation Events</span></a>
     <ol class="toc">
      <li>
       <a href="#interface-animationevent"><span class="secno">4.1</span> <span class="content"> The <code>AnimationEvent</code> Interface</span></a>
       <ol class="toc">
        <li><a href="#interface-animationevent-idl"><span class="secno">4.1.1</span> <span class="content"> IDL Definition</span></a>
        <li><a href="#interface-animationevent-attributes"><span class="secno">4.1.2</span> <span class="content"> Attributes</span></a>
       </ol>
      <li><a href="#event-animationevent"><span class="secno">4.2</span> <span class="content"> Types of <code>AnimationEvent</code></span></a>
      <li><a href="#event-handlers-on-elements-document-objects-and-window-objects"><span class="secno">4.3</span> <span class="content">Event
handlers on elements, <code>Document</code> objects, and <code>Window</code> objects</span></a>
     </ol>
    <li>
     <a href="#interface-dom"><span class="secno">5</span> <span class="content"> DOM Interfaces</span></a>
     <ol class="toc">
      <li>
       <a href="#interface-cssrule"><span class="secno">5.1</span> <span class="content"> The <code>CSSRule</code> Interface</span></a>
       <ol class="toc">
        <li><a href="#interface-cssrule-idl"><span class="secno">5.1.1</span> <span class="content"> IDL Definition</span></a>
       </ol>
      <li>
       <a href="#interface-csskeyframerule"><span class="secno">5.2</span> <span class="content"> The <code>CSSKeyframeRule</code> Interface</span></a>
       <ol class="toc">
        <li><a href="#interface-csskeyframerule-idl"><span class="secno">5.2.1</span> <span class="content"> IDL Definition</span></a>
        <li><a href="#interface-csskeyframerule-attributes"><span class="secno">5.2.2</span> <span class="content"> Attributes</span></a>
       </ol>
      <li>
       <a href="#interface-csskeyframesrule"><span class="secno">5.3</span> <span class="content"> The <code>CSSKeyframesRule</code> Interface</span></a>
       <ol class="toc">
        <li><a href="#interface-csskeyframesrule-idl"><span class="secno">5.3.1</span> <span class="content"> IDL Definition</span></a>
        <li><a href="#interface-csskeyframesrule-attributes"><span class="secno">5.3.2</span> <span class="content"> Attributes</span></a>
        <li><a href="#interface-csskeyframesrule-appendrule"><span class="secno">5.3.3</span> <span class="content"> The <code>appendRule</code> method</span></a>
        <li><a href="#interface-csskeyframesrule-deleterule"><span class="secno">5.3.4</span> <span class="content"> The <code>deleteRule</code> method</span></a>
        <li><a href="#interface-csskeyframesrule-findrule"><span class="secno">5.3.5</span> <span class="content"> The <code>findRule</code> method</span></a>
       </ol>
      <li>
       <a href="#interface-globaleventhandlers"><span class="secno">5.4</span> <span class="content"> Extensions to the <code>GlobalEventHandlers</code> Interface Mixin</span></a>
       <ol class="toc">
        <li><a href="#interface-globaleventhandlers-idl"><span class="secno">5.4.1</span> <span class="content"> IDL Definition</span></a>
       </ol>
     </ol>
    <li><a href="#priv-sec"><span class="secno">6</span> <span class="content"> Privacy and Security Considerations</span></a>
    <li><a href="#acknowledgements"><span class="secno">7</span> <span class="content"> Acknowledgements</span></a>
    <li><a href="#other-open-issues"><span class="secno">8</span> <span class="content">Other open issues</span></a>
    <li><a href="#wg-resolutions-pending"><span class="secno">9</span> <span class="content"> Working Group Resolutions that are pending editing</span></a>
    <li>
     <a href="#conformance"><span class="secno"></span> <span class="content"> Conformance</span></a>
     <ol class="toc">
      <li><a href="#document-conventions"><span class="secno"></span> <span class="content"> Document conventions</span></a>
      <li><a href="#conform-classes"><span class="secno"></span> <span class="content"> Conformance classes</span></a>
      <li>
       <a href="#conform-responsible"><span class="secno"></span> <span class="content"> Requirements for Responsible Implementation of CSS</span></a>
       <ol class="toc">
        <li><a href="#conform-partial"><span class="secno"></span> <span class="content"> Partial Implementations</span></a>
        <li><a href="#conform-future-proofing"><span class="secno"></span> <span class="content"> Implementations of Unstable and Proprietary Features</span></a>
        <li><a href="#conform-testing"><span class="secno"></span> <span class="content"> Implementations of CR-level Features</span></a>
       </ol>
     </ol>
    <li>
     <a href="#index"><span class="secno"></span> <span class="content">Index</span></a>
     <ol class="toc">
      <li><a href="#index-defined-here"><span class="secno"></span> <span class="content">Terms defined by this specification</span></a>
      <li><a href="#index-defined-elsewhere"><span class="secno"></span> <span class="content">Terms defined by reference</span></a>
     </ol>
    <li>
     <a href="#references"><span class="secno"></span> <span class="content">References</span></a>
     <ol class="toc">
      <li><a href="#normative"><span class="secno"></span> <span class="content">Normative References</span></a>
      <li><a href="#informative"><span class="secno"></span> <span class="content">Informative References</span></a>
     </ol>
    <li><a href="#property-index"><span class="secno"></span> <span class="content">Property Index</span></a>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
    <li><a href="#issues-index"><span class="secno"></span> <span class="content">Issues Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="intro"><span class="secno">1. </span><span class="content"> Introduction</span><a class="self-link" href="#intro"></a></h2>
   <p><em>This section is not normative</em></p>
   <p>CSS Transitions <a data-link-type="biblio" href="#biblio-css3-transitions">[CSS3-TRANSITIONS]</a> provide a way to interpolate
	CSS property values when they change as a result of underlying
	property changes. This provides an easy way to do simple animation,
	but the start and end states of the animation are controlled by the
	existing property values, and transitions provide little control to
	the author on how the animation progresses.</p>
   <p>This proposal introduces defined animations, in which the author can
	specify the changes in CSS properties over time as a set of keyframes.
	Animations are similar to transitions in that they change the
	presentational value of CSS properties over time. The principal difference
	is that while transitions trigger implicitly when property values change,
	animations are explicitly executed when the animation properties are applied.
	Because of this, animations require explicit values for the properties
	being animated. These values are specified using animation keyframes,
	described below.</p>
   <p>Many aspects of the animation can be controlled, including how many times
	the animation iterates, whether or not it alternates between the begin and
	end values, and whether or not the animation should be running or paused.
	An animation can also delay its start time.</p>
   <h3 class="heading settled" data-level="1.1" id="values"><span class="secno">1.1. </span><span class="content"> Value Definitions</span><a class="self-link" href="#values"></a></h3>
   <p>This specification follows the <a href="https://www.w3.org/TR/CSS2/about.html#property-defs">CSS property definition conventions</a> from <a data-link-type="biblio" href="#biblio-css2">[CSS2]</a> using the <a href="https://www.w3.org/TR/css-values-3/#value-defs">value definition syntax</a> from <a data-link-type="biblio" href="#biblio-css-values-3">[CSS-VALUES-3]</a>.
	Value types not defined in this specification are defined in CSS Values &amp; Units <span>[CSS-VALUES-3]</span>.
	Combination with other CSS modules may expand the definitions of these value types.</p>
   <p>In addition to the property-specific values listed in their definitions,
	all properties defined in this specification
	also accept the <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#css-wide-keywords" id="ref-for-css-wide-keywords">CSS-wide keywords</a> keywords as their property value.
	For readability they have not been repeated explicitly.</p>
   <h2 class="heading settled" data-level="2" id="animations"><span class="secno">2. </span><span class="content"> Animations</span><a class="self-link" href="#animations"></a></h2>
   <p>CSS Animations affect computed property values. This effect happens by
	adding a specified value to the CSS cascade (<a data-link-type="biblio" href="#biblio-css3cascade">[CSS3CASCADE]</a>) (at the
	level for CSS Animations) that will produce the correct computed value
	for the current state of the animation. As defined in <span>[CSS3CASCADE]</span>,
	animations override all normal rules, but are overridden by !important
	rules.</p>
   <p>If at some point in time there are multiple animations specifying behavior
	for the same property, the animation which occurs last in the value
	of <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name">animation-name</a> will override the other animations at that point.</p>
   <p>An animation does not affect the computed value before the application of the
	animation (that is, when the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①">animation-name</a> property is set on an element)
	or after it is removed. Furthermore, typically an animation does not affect
	the computed value before the animation delay has expired or after the end of
	the animation, but may do so depending on the <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode">animation-fill-mode</a> property.</p>
   <p>While running, the animation computes the value of those properties
	it animates. Other values may take precedence over the animated value
	according to the CSS cascade (<a data-link-type="biblio" href="#biblio-css3cascade">[CSS3CASCADE]</a>).</p>
   <p>While an animation is applied but has not finished, or has finished but has
	an <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode①">animation-fill-mode</a> of <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-forwards" id="ref-for-valdef-animation-fill-mode-forwards">forwards</a> or <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-both" id="ref-for-valdef-animation-fill-mode-both">both</a>, the user agent must act
	as if the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-will-change-1/#propdef-will-change" id="ref-for-propdef-will-change">will-change</a> property (<a data-link-type="biblio" href="#biblio-css-will-change-1">[css-will-change-1]</a>) on the element
	additionally includes all the properties animated by the animation.</p>
   <p>The start time of an animation is the time at which the style applying
	the animation and the corresponding @keyframes rule are both resolved.
	If an animation is specified for an element but the corresponding
	@keyframes rule does not yet exist, the animation cannot start; the
	animation will start from the beginning as soon as a matching @keyframes
	rule can be resolved. An animation specified by dynamically modifying the
	element’s style will start when this style is resolved; that may be
	immediately in the case of a pseudo style rule such as hover, or may be
	when the scripting engine returns control to the browser (in the case of
	style applied by script). Note that dynamically updating keyframe style
	rules does not start or re-start an animation.</p>
   <p>An animation applies to an element if its name appears as one of the
	identifiers in the computed value of the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name②">animation-name</a> property and the
	animation uses a valid @keyframes rule. Once an
	animation has started it continues until it ends or the <span class="property" id="ref-for-propdef-animation-name③">animation-name</span> is
	removed. Changes to the values of animation properties while the animation
	is running apply as if the animation had those values from when it
	began. For example, shortening the <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay">animation-delay</a> may cause the animation
	to jump forwards or even finish immediately and dispatch an <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationend" id="ref-for-eventdef-animationevent-animationend">animationend</a></code> event.
	Conversely, extending the <span class="property" id="ref-for-propdef-animation-delay①">animation-delay</span> may cause an animation to
	re-start and dispatch an <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationstart" id="ref-for-eventdef-animationevent-animationstart">animationstart</a></code> event.</p>
   <p>The same @keyframes rule name may be repeated within an <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name④">animation-name</a>.
	Changes to the <span class="property" id="ref-for-propdef-animation-name⑤">animation-name</span> update existing animations by iterating over
	the new list of animations from last to first, and, for each animation,
	finding the <em>last</em> matching animation in the list of existing
	animations.
	If a match is found, the existing animation is updated using the animation
	properties corresponding to its position in the new list of animations,
	whilst maintaining its current playback time as described above.
	The matching animation is removed from the existing list of animations such
	that it will not match twice.
	If a match is not found, a new animation is created.
	As a result, updating <span class="property" id="ref-for-propdef-animation-name⑥">animation-name</span> from ‘a’ to
	‘a, a’ will cause the existing animation for ‘a’ to
	become the <em>second</em> animation in the list and a new animation will be
	created for the first item in the list.</p>
   <div class="example" id="example-4e34d7ba">
    <a class="self-link" href="#example-4e34d7ba"></a> 
<pre>div {
  animation-name: diagonal-slide;
  animation-duration: 5s;
  animation-iteration-count: 10;
}

@keyframes diagonal-slide {

  from {
    left: 0;
    top: 0;
  }

  to {
    left: 100px;
    top: 100px;
  }

}
</pre>
    <p>This will produce an animation that moves an element from (0, 0) to
		(100px, 100px) over five seconds and repeats itself nine times
		(for a total of ten iterations).</p>
   </div>
   <p>Setting the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visuren.html#propdef-display" id="ref-for-propdef-display">display</a> property to <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-none" id="ref-for-valdef-display-none">none</a> will terminate any running animation applied
	to the element and its descendants. If an element has a <span class="property" id="ref-for-propdef-display①">display</span> of <span class="css" id="ref-for-valdef-display-none①">none</span>, updating <span class="property" id="ref-for-propdef-display②">display</span> to a value other than <span class="css" id="ref-for-valdef-display-none②">none</span> will start all animations applied to the element
	by the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name⑦">animation-name</a> property, as well as all animations applied to descendants
	with <span class="property" id="ref-for-propdef-display③">display</span> other than <span class="css" id="ref-for-valdef-display-none③">none</span>.</p>
   <p>While authors can use animations to create dynamically changing content, dynamically
	changing content can lead to seizures in some users. For information on how to avoid
	content that can lead to seizures, see Guideline 2.3: Seizures: Do not design content
	in a way that is known to cause seizures (<a data-link-type="biblio" href="#biblio-wcag20">[WCAG20]</a>).</p>
   <p>Implementations may ignore animations when the rendering medium is not interactive e.g. when printed.
	A future version of this specification may define how to render animations for these media.</p>
   <h2 class="heading settled" data-level="3" id="keyframes"><span class="secno">3. </span><span class="content"> Keyframes</span><a class="self-link" href="#keyframes"></a></h2>
   <p>Keyframes are used to specify the values for the animating properties at various points
	during the animation. The keyframes specify the behavior of one cycle of the animation;
	the animation may iterate zero or more times.</p>
   <p>Keyframes are specified using the <dfn class="dfn-paneled css" data-dfn-type="at-rule" data-export id="at-ruledef-keyframes">@keyframes</dfn> at-rule,
	defined as follows:</p>
<pre>@keyframes = @keyframes <a class="production" data-link-type="type" href="#typedef-keyframes-name" id="ref-for-typedef-keyframes-name">&lt;keyframes-name></a> { <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-rule-list" id="ref-for-typedef-rule-list">&lt;rule-list></a> }

<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-keyframes-name">&lt;keyframes-name></dfn> = <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value">&lt;custom-ident></a> | <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value">&lt;string></a>

<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-keyframe-block">&lt;keyframe-block></dfn> = <a class="production" data-link-type="type" href="#typedef-keyframe-selector" id="ref-for-typedef-keyframe-selector">&lt;keyframe-selector></a># { <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list" id="ref-for-typedef-declaration-list">&lt;declaration-list></a> }

<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-keyframe-selector">&lt;keyframe-selector></dfn> = from | to | <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value">&lt;percentage></a>
</pre>
   <p>The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-rule-list" id="ref-for-typedef-rule-list①">&lt;rule-list></a> inside of <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes">@keyframes</a> can only contain <a class="production css" data-link-type="type" href="#typedef-keyframe-block" id="ref-for-typedef-keyframe-block">&lt;keyframe-block></a> rules.</p>
   <p>The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list" id="ref-for-typedef-declaration-list①">&lt;declaration-list></a> inside of <a class="production css" data-link-type="type" href="#typedef-keyframe-block" id="ref-for-typedef-keyframe-block①">&lt;keyframe-block></a> accepts any CSS property
	except those defined in this specification,
	but <em>does</em> accept the <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function">animation-timing-function</a> property
	and interprets it specially.
	None of the properties interact with the cascade
	(so using <span class="css">!important</span> on them is invalid and will cause the property to be ignored).</p>
   <p>A <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes①">@keyframes</a> block has a name given by the <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value①">&lt;custom-ident></a> or <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value①">&lt;string></a> in its prelude.
	The two syntaxes are equivalent in functionality;
	the name is the value of the ident or string.
	As normal for <span class="production" id="ref-for-identifier-value②">&lt;custom-ident></span>s and <span class="production" id="ref-for-string-value②">&lt;string></span>s,
	the names are fully <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive">case-sensitive</a>;
	two names are equal only if they are codepoint-by-codepoint equal.
	The <span class="production" id="ref-for-identifier-value③">&lt;custom-ident></span> additionally excludes the <a class="css" data-link-type="maybe" href="#valdef-animation-name-none" id="ref-for-valdef-animation-name-none">none</a> keyword.</p>
   <div class="example" id="example-d0936079">
    <a class="self-link" href="#example-d0936079"></a> For example, the following two <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes②">@keyframes</a> rules have the same name,
		so the first will be ignored: 
<pre class="lang-css highlight"><c- n>@keyframes</c-> foo { <c- c>/* ... */</c-> <c- p>}</c->
<c- n>@keyframes</c-> <c- s>"foo"</c-> { <c- c>/* ... */</c-> <c- p>}</c->
</pre>
    <p>On the other hand,
		the following <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes③">@keyframes</a> rule’s name is <em>different</em> from the previous two rules:</p>
<pre class="lang-css highlight"><c- n>@keyframes</c-> FOO { <c- c>/* ... */</c-> <c- p>}</c->
</pre>
    <p>The following <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes④">@keyframes</a> rules are invalid
		because they use disallowed <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value④">&lt;custom-ident></a> values:</p>
<pre class="lang-css highlight"><c- n>@keyframes</c-> initial { <c- c>/* ... */</c-> <c- p>}</c->
<c- n>@keyframes</c-> None { <c- c>/* ... */</c-> <c- p>}</c->
</pre>
    <p>However, those names <em>can</em> be specified with a <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value③">&lt;string></a>,
		so the following are both <em>valid</em>:</p>
<pre class="lang-css highlight"><c- n>@keyframes</c-> <c- s>"initial"</c-> { <c- c>/* ... */</c-> <c- p>}</c->
<c- n>@keyframes</c-> <c- s>"None"</c-> { <c- c>/* ... */</c-> <c- p>}</c->
</pre>
   </div>
   <p>The <a class="production css" data-link-type="type" href="#typedef-keyframe-selector" id="ref-for-typedef-keyframe-selector①">&lt;keyframe-selector></a> for a <a class="production css" data-link-type="type" href="#typedef-keyframe-block" id="ref-for-typedef-keyframe-block②">&lt;keyframe-block></a> consists of a comma-separated list of percentage values or the keywords <span class="css">from</span> or <span class="css">to</span>. The selector is used to specify the percentage along the duration of the animation that the keyframe represents. The keyframe itself is specified by the block of property values declared on the selector. The keyword <span class="css">from</span> is equivalent to the value <span class="css">0%</span>. The keyword <span class="css">to</span> is equivalent to the value <span class="css">100%</span>.
	Values less than <span class="css">0%</span> or higher than <span class="css">100%</span> are invalid
	and cause their <span class="production" id="ref-for-typedef-keyframe-block③">&lt;keyframe-block></span> to be ignored.</p>
   <p><span class="note">Note that the percentage unit specifier must be used on percentage values. Therefore, <span class="css">0</span> is an invalid keyframe selector.</span></p>
   <p>If a <span class="css">0%</span> or <span class="css">from</span> keyframe is not specified, then the user agent constructs a <span class="css">0%</span> keyframe
	using the computed values of the properties being animated. If a <span class="css">100%</span> or <span class="css">to</span> keyframe is not
	specified, then the user agent constructs a <span class="css">100%</span> keyframe using the computed values of the
	properties being animated.</p>
   <p>The <a class="production css" data-link-type="type" href="#typedef-keyframe-block" id="ref-for-typedef-keyframe-block④">&lt;keyframe-block></a> contains properties and values. The properties
	defined by this specification are ignored in these rules, with the exception of <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function①">animation-timing-function</a>, the behavior of which is described below. In addition, properties qualified with !important are invalid and ignored.</p>
   <p>If multiple <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes⑤">@keyframes</a> rules are defined with the same name,
	the last one in document order wins,
	and all preceding ones are ignored.</p>
   <div class="example" id="example-b784185b">
    <a class="self-link" href="#example-b784185b"></a> 
<pre>div {
  animation-name: slide-right;
  animation-duration: 2s;
}

@keyframes slide-right {

  from {
    margin-left: 0px;
  }

  50% {
    margin-left: 110px;
    opacity: 1;
  }

  50% {
    opacity: 0.9;
  }

  to {
    margin-left: 200px;
  }

}
</pre>
    <p>The two 50% rules from above can also be combined into an equivalent single rule
as illustrated below:</p>
<pre>@keyframes slide-right {

  from {
    margin-left: 0px;
  }

  50% {
    margin-left: 110px;
    opacity: 0.9;
  }

  to {
    margin-left: 200px;
  }

}
</pre>
   </div>
   <p>To determine the set of keyframes, all of the values in the selectors are sorted in increasing order
	by time. The rules within the <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes⑥">@keyframes</a> rule then cascade; the properties of a keyframe may thus derive
	from more than one <span class="css" id="ref-for-at-ruledef-keyframes⑦">@keyframes</span> rule with the same selector value.</p>
   <p>If a property is not specified for a keyframe, or is specified but invalid, the animation of that
	property proceeds as if that keyframe did not exist. Conceptually, it is as if a set of keyframes is
	constructed for each property that is present in any of the keyframes, and an animation is run
	independently for each property.</p>
   <div class="example" id="example-10d90bd9">
    <a class="self-link" href="#example-10d90bd9"></a> 
<pre>@keyframes wobble {
  0% {
    left: 100px;
  }

  40% {
    left: 150px;
  }

  60% {
    left: 75px;
  }

  100% {
    left: 100px;
  }
}
</pre>
    <p>Four keyframes are specified for the animation named "wobble". In the first keyframe,
		shown at the beginning of the animation cycle, the value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-left" id="ref-for-propdef-left">left</a> property being
		animated is <span class="css">100px</span>. By 40% of the animation duration, <span class="property" id="ref-for-propdef-left①">left</span> has animated to <span class="css">150px</span>.
		At 60% of the animation duration, <span class="property" id="ref-for-propdef-left②">left</span> has animated back to <span class="css">75px</span>. At the end of the
		animation cycle, the value of <span class="property" id="ref-for-propdef-left③">left</span> has returned to <span class="css">100px</span>. The diagram below shows
		the state of the animation if it were given a duration of <span class="css">10s</span>.</p>
    <figure>
      <img alt src="./animation1.png"> 
     <figcaption>Animation states specified by keyframes</figcaption>
    </figure>
   </div>
   <p class="issue" id="issue-73aacf21"><a class="self-link" href="#issue-73aacf21"></a> This specification needs to define
		how the value is determined from the keyframes,
		like the section on <a href="https://drafts.csswg.org/css-transitions/#application">Application of transitions</a> does for CSS Transitions. </p>
   <h3 class="heading settled" data-level="3.1" id="timing-functions"><span class="secno">3.1. </span><span class="content"> Timing functions for keyframes</span><a class="self-link" href="#timing-functions"></a></h3>
   <p>A keyframe style rule may also declare the timing function that is to be used as the animation
	moves to the next keyframe.</p>
   <div class="example" id="example-a9d2ebec">
    <a class="self-link" href="#example-a9d2ebec"></a> 
<pre>@keyframes bounce {

  from {
    top: 100px;
    animation-timing-function: ease-out;
  }

  25% {
    top: 50px;
    animation-timing-function: ease-in;
  }

  50% {
    top: 100px;
    animation-timing-function: ease-out;
  }

  75% {
    top: 75px;
    animation-timing-function: ease-in;
  }

  to {
    top: 100px;
  }

}
</pre>
    <p>Five keyframes are specified for the animation named "bounce". Between the first and second
		keyframe (i.e., between 0% and 25%) an ease-out timing function is used. Between the second
		and third keyframe (i.e., between 25% and 50%) an ease-in timing function is used. And so on.
		The effect will appear as an element that moves up the page 50px, slowing down as it reaches
		its highest point then speeding up as it falls back to 100px. The second half of the animation
		behaves in a similar manner, but only moves the element 25px up the page.</p>
   </div>
   <p>A timing function specified on the <span class="css">to</span> or <span class="css">100%</span> keyframe is ignored.</p>
   <p>See the <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function②">animation-timing-function</a> property for more information.</p>
   <h3 class="heading settled" data-level="3.2" id="animation-name"><span class="secno">3.2. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name⑧">animation-name</a> property</span><a class="self-link" href="#animation-name"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name⑨">animation-name</a> property defines a list of animations that apply. Each name is used to select
	 the keyframe at-rule that provides the property values for the animation. If the name does not match
	 any keyframe at-rule, there are no properties to be animated and the animation will not execute.
	 Furthermore, if the animation name is <code>none</code> then there will be no animation. This can be
	 used to override any animations coming from the cascade. If multiple animations are attempting to
	 modify the same property, then the animation closest to the end of the list of names wins.</p>
   <p>Each animation listed by name should have a corresponding value for the other animation properties
	listed below. If the lists of values for the other animation properties do not have the same length,
	the length of the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①⓪">animation-name</a> list determines the number of items in each list examined when
	starting animations. The lists are matched up from the first value: excess values at the end are not
	used. If one of the other properties doesn’t have enough comma-separated values to match the number of
	values of <span class="property" id="ref-for-propdef-animation-name①①">animation-name</span>, the UA must calculate its used value by repeating the list of values until
	there are enough. This truncation or repetition does not affect the computed value.</p>
   <p class="note" role="note"><span>Note:</span> This is analogous to the behavior of the <a class="property" data-link-type="propdesc">background-*</a> properties, with <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-background-image" id="ref-for-propdef-background-image">background-image</a> analogous to <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①②">animation-name</a>.</p>
   <table class="def propdef" data-link-for-hint="animation-name">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-name">animation-name</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod">[ none <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one">|</a> <a class="production css" data-link-type="type" href="#typedef-keyframes-name" id="ref-for-typedef-keyframes-name①">&lt;keyframes-name></a> ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>none 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item either a case-sensitive <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#css-identifier" id="ref-for-css-identifier">css identifier</a> or the keyword <a class="css" data-link-type="maybe" href="#valdef-animation-name-none" id="ref-for-valdef-animation-name-none①">none</a> 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p>The values of <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①③">animation-name</a> have the following meanings:</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-name" data-dfn-type="value" data-export id="valdef-animation-name-none">none</dfn> 
    <dd> No keyframes are specified at all, so there will be no animation.
			Any other animations properties specified for this animation have no effect. 
    <dt><dfn class="css" data-dfn-for="animation-name" data-dfn-type="value" data-export id="valdef-animation-name-keyframes-name"><a class="production css" data-link-type="type" href="#typedef-keyframes-name" id="ref-for-typedef-keyframes-name②">&lt;keyframes-name></a><a class="self-link" href="#valdef-animation-name-keyframes-name"></a></dfn> 
    <dd> The animation will use the keyframes with the name specified by the <a class="production css" data-link-type="type" href="#typedef-keyframes-name" id="ref-for-typedef-keyframes-name③">&lt;keyframes-name></a>,
			if they exist.
			If no <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes⑧">@keyframes</a> rule with that name exists, there is no animation. 
   </dl>
   <h3 class="heading settled" data-level="3.3" id="animation-duration"><span class="secno">3.3. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration">animation-duration</a> property</span><a class="self-link" href="#animation-duration"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration①">animation-duration</a> property defines duration of a single animation cycle.</p>
   <table class="def propdef" data-link-for-hint="animation-duration">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-duration">animation-duration</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value" title="Expands to: ms | s">&lt;time></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma①">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>0s 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a duration 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <dl>
    <dt><dfn class="css" data-dfn-for="animation-duration" data-dfn-type="value" data-export id="valdef-animation-duration-time"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value①" title="Expands to: ms | s">&lt;time></a><a class="self-link" href="#valdef-animation-duration-time"></a></dfn> 
    <dd>
      The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value②" title="Expands to: ms | s">&lt;time></a> specifies the length of time that an animation takes to complete one cycle.
A negative <span class="production" id="ref-for-time-value③" title="Expands to: ms | s">&lt;time></span> is invalid. 
     <p>If the <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value④" title="Expands to: ms | s">&lt;time></a> is <span class="css">0s</span>, like the initial value,
the keyframes of the animation have no effect,
but the animation itself still occurs instantaneously.
Specifically, start and end events are fired;
if <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode②">animation-fill-mode</a> is set to <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-backwards" id="ref-for-valdef-animation-fill-mode-backwards">backwards</a> or <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-both" id="ref-for-valdef-animation-fill-mode-both①">both</a>,
the first frame of the animation,
as defined by <a class="property" data-link-type="propdesc" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction">animation-direction</a>,
will be displayed during the <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay②">animation-delay</a>.
After the <span class="property" id="ref-for-propdef-animation-delay③">animation-delay</span> the last frame of the animation,
as defined by <span class="property" id="ref-for-propdef-animation-direction①">animation-direction</span>,
will be displayed if <span class="property" id="ref-for-propdef-animation-fill-mode③">animation-fill-mode</span> is set to <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-forwards" id="ref-for-valdef-animation-fill-mode-forwards①">forwards</a> or <span class="css" id="ref-for-valdef-animation-fill-mode-both②">both</span>.
If <span class="property" id="ref-for-propdef-animation-fill-mode④">animation-fill-mode</span> is set to <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-none" id="ref-for-valdef-animation-fill-mode-none">none</a> the animation will have no visible effect.</p>
   </dl>
   <h3 class="heading settled" data-level="3.4" id="animation-timing-function"><span class="secno">3.4. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function③">animation-timing-function</a> property</span><a class="self-link" href="#animation-timing-function"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function④">animation-timing-function</a> property describes how the animation will
	progress between each pair of keyframes.
	Timing functions are defined in the separate CSS Easing Functions module <a data-link-type="biblio" href="#biblio-css-easing-1">[css-easing-1]</a>.</p>
   <p>The <a data-link-type="dfn" href="https://drafts.csswg.org/css-easing-1/#input-progress-value" id="ref-for-input-progress-value">input progress value</a> used is the percentage
	of the time elapsed between the current keyframe and the next keyframe <em>after</em> incorporating the effect of the <a class="property" data-link-type="propdesc" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction②">animation-direction</a> property.</p>
   <p>During the <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay④">animation-delay</a>, the <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function⑤">animation-timing-function</a> is not applied.</p>
   <p class="note" role="note"><span>Note:</span> This definition is necessary because otherwise a <a data-link-type="dfn" href="https://drafts.csswg.org/css-easing-1/#step-easing-function" id="ref-for-step-easing-function">step
	easing function</a> with a <a data-link-type="dfn" href="https://drafts.csswg.org/css-easing-1/#step-position" id="ref-for-step-position">step position</a> of <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-easing-1/#valdef-steps-start" id="ref-for-valdef-steps-start">start</a> would produce a backwards fill equal
	to the top of the first step in the function.</p>
   <p>The <a data-link-type="dfn" href="https://drafts.csswg.org/css-easing-1/#output-progress-value" id="ref-for-output-progress-value">output progress value</a> is used as the <var>p</var> value when interpolating the property values between the
	current and next keyframe.</p>
   <table class="def propdef" data-link-for-hint="animation-timing-function">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-timing-function">animation-timing-function</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function" id="ref-for-typedef-easing-function">&lt;easing-function></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma②">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>ease 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a computed <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function" id="ref-for-typedef-easing-function①">&lt;easing-function></a> 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p>When specified in a keyframe, <a class="property" data-link-type="propdesc" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function⑥">animation-timing-function</a> defines
	the progression of the animation
	between the current keyframe
	and the next keyframe for the animating property
	in sorted keyframe selector order
	(which may be an implicit 100% keyframe).</p>
   <h3 class="heading settled" data-level="3.5" id="animation-iteration-count"><span class="secno">3.5. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-iteration-count" id="ref-for-propdef-animation-iteration-count">animation-iteration-count</a> property</span><a class="self-link" href="#animation-iteration-count"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-iteration-count" id="ref-for-propdef-animation-iteration-count①">animation-iteration-count</a> property specifies the number of times an animation cycle
	is played. The initial value is <span class="css">1</span>, meaning the animation will play from beginning to end
	once. This property is often used in conjunction with an <a class="property" data-link-type="propdesc" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction③">animation-direction</a> value of <a class="css" data-link-type="maybe" href="#valdef-animation-direction-alternate" id="ref-for-valdef-animation-direction-alternate">alternate</a>, which will cause the animation to play in
	reverse on alternate cycles.</p>
   <p>The time window during which the animation is active
	(<code>duration</code> x <code>iteration-count</code>)
	is known as the <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="active-duration">active duration</dfn>.</p>
   <table class="def propdef" data-link-for-hint="animation-iteration-count">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-iteration-count">animation-iteration-count</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-single-animation-iteration-count" id="ref-for-typedef-single-animation-iteration-count">&lt;single-animation-iteration-count></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma③">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>1 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item either a number or the keyword <a class="css" data-link-type="maybe" href="#valdef-animation-iteration-count-infinite" id="ref-for-valdef-animation-iteration-count-infinite">infinite</a> 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p><dfn class="dfn-paneled css" data-dfn-type="type" data-export id="typedef-single-animation-iteration-count">&lt;single-animation-iteration-count></dfn> = infinite | <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value">&lt;number></a></p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-iteration-count" data-dfn-type="value" data-export id="valdef-animation-iteration-count-infinite">infinite</dfn> 
    <dd> The animation will repeat forever. 
    <dt><dfn class="css" data-dfn-for="animation-iteration-count" data-dfn-type="value" data-export id="valdef-animation-iteration-count-number"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value①">&lt;number></a><a class="self-link" href="#valdef-animation-iteration-count-number"></a></dfn> 
    <dd>
     <p>The animation will repeat the specified number of times.
			If the number is not an integer,
			the animation will end partway through its last cycle.
			Negative numbers are invalid. </p>
     <p>A value of <span class="css">0</span> is valid and, similar to an <a class="property" data-link-type="propdesc" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration②">animation-duration</a> of <span class="css">0s</span>, causes the animation to occur instantaneously. </p>
   </dl>
   <p>If the animation has a duration of <span class="css">0s</span>, it will occur instantaneously for any
	valid value of <a class="property" data-link-type="propdesc" href="#propdef-animation-iteration-count" id="ref-for-propdef-animation-iteration-count②">animation-iteration-count</a>, including <a class="css" data-link-type="maybe" href="#valdef-animation-iteration-count-infinite" id="ref-for-valdef-animation-iteration-count-infinite①">infinite</a>.</p>
   <h3 class="heading settled" data-level="3.6" id="animation-direction"><span class="secno">3.6. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction④">animation-direction</a> property</span><a class="self-link" href="#animation-direction"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction⑤">animation-direction</a> property defines whether or not the animation should play in reverse
	on some or all cycles. When an animation is played in reverse the timing functions are also
	reversed. For example, when played in reverse an <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-easing-1/#valdef-cubic-bezier-easing-function-ease-in" id="ref-for-valdef-cubic-bezier-easing-function-ease-in">ease-in</a> animation would appear to be an <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-easing-1/#valdef-cubic-bezier-easing-function-ease-out" id="ref-for-valdef-cubic-bezier-easing-function-ease-out">ease-out</a> animation.</p>
   <table class="def propdef" data-link-for-hint="animation-direction">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-direction">animation-direction</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-single-animation-direction" id="ref-for-typedef-single-animation-direction">&lt;single-animation-direction></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma④">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>normal 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a keyword as specified 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p><dfn class="dfn-paneled css" data-dfn-type="type" data-export id="typedef-single-animation-direction">&lt;single-animation-direction></dfn> = normal | reverse | alternate | alternate-reverse</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-direction" data-dfn-type="value" data-export id="valdef-animation-direction-normal">normal</dfn> 
    <dd> All iterations of the animation are played as specified. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-direction" data-dfn-type="value" data-export id="valdef-animation-direction-reverse">reverse</dfn> 
    <dd> All iterations of the animation are played in the reverse direction
			from the way they were specified. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-direction" data-dfn-type="value" data-export id="valdef-animation-direction-alternate">alternate</dfn> 
    <dd> The animation cycle iterations that are odd counts are played in the
			normal direction, and the animation cycle iterations that are even
			counts are played in a reverse direction. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-direction" data-dfn-type="value" data-export id="valdef-animation-direction-alternate-reverse">alternate-reverse</dfn> 
    <dd> The animation cycle iterations that are odd counts are played in the
			reverse direction, and the animation cycle iterations that are even
			counts are played in a normal direction. 
   </dl>
   <p class="note" role="note"><span>Note:</span> For the purpose of determining whether an iteration is even or odd,
	iterations start counting from 1.</p>
   <h3 class="heading settled" data-level="3.7" id="animation-play-state"><span class="secno">3.7. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-play-state" id="ref-for-propdef-animation-play-state">animation-play-state</a> property</span><a class="self-link" href="#animation-play-state"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-play-state" id="ref-for-propdef-animation-play-state①">animation-play-state</a> property defines whether the animation is running or paused.</p>
   <table class="def propdef" data-link-for-hint="animation-play-state">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-play-state">animation-play-state</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-single-animation-play-state" id="ref-for-typedef-single-animation-play-state">&lt;single-animation-play-state></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma⑤">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>running 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a keyword as specified 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p><dfn class="dfn-paneled css" data-dfn-type="type" data-export id="typedef-single-animation-play-state">&lt;single-animation-play-state></dfn> = running | paused</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-play-state" data-dfn-type="value" data-export id="valdef-animation-play-state-running">running</dfn> 
    <dd> While this property is set to <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-running" id="ref-for-valdef-animation-play-state-running">running</a>,
			the animation proceeds as normal. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-play-state" data-dfn-type="value" data-export id="valdef-animation-play-state-paused">paused</dfn> 
    <dd>
      While this property is set to <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-paused" id="ref-for-valdef-animation-play-state-paused">paused</a>,
			the animation is paused.
			The animation continues to apply to the element with the progress it had made before being paused.
			When unpaused (set back to <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-running" id="ref-for-valdef-animation-play-state-running①">running</a>), it restarts from where it left off,
			as if the "clock" that controls the animation had stopped and started again. 
     <p>If the property is set to <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-paused" id="ref-for-valdef-animation-play-state-paused①">paused</a> during the delay phase of the animation,
			the delay clock is also paused and resumes as soon as <a class="property" data-link-type="propdesc" href="#propdef-animation-play-state" id="ref-for-propdef-animation-play-state②">animation-play-state</a> is set back to <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-running" id="ref-for-valdef-animation-play-state-running②">running</a>.</p>
   </dl>
   <h3 class="heading settled" data-level="3.8" id="animation-delay"><span class="secno">3.8. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay⑤">animation-delay</a> property</span><a class="self-link" href="#animation-delay"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay⑥">animation-delay</a> property defines when the animation will start. It allows an animation
	to begin execution some time after it is applied,
	or to appear to have begun execution some time <em>before</em> it is applied.</p>
   <table class="def propdef" data-link-for-hint="animation-delay">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-delay">animation-delay</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value⑤" title="Expands to: ms | s">&lt;time></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma⑥">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>0s 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a duration 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <dl>
    <dt><dfn class="css" data-dfn-for="animation-delay" data-dfn-type="value" data-export id="valdef-animation-delay-time"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value⑥" title="Expands to: ms | s">&lt;time></a><a class="self-link" href="#valdef-animation-delay-time"></a></dfn> 
    <dd>
      The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value⑦" title="Expands to: ms | s">&lt;time></a> defines how long of a delay there is between the start of the animation
			(when the animation is applied to the element via these properties)
			and when it begins executing.
			A delay of <span class="css">0s</span> (the initial value) means that the animation will execute as soon as it is applied. 
     <p>A negative delay is <strong>valid</strong>.
			Similar to a delay of <span class="css">0s</span>, it means that the animation executes immediately,
			but is automatically progressed by the absolute value of the delay,
			as if the animation had started the specified time in the past,
			and so it appears to start partway through its <a href="#animation-iteration-count">active duration</a>.
			If an animation’s keyframes have an implied starting value,
			the values are taken from the time the animation starts,
			not some time in the past.</p>
   </dl>
   <h3 class="heading settled" data-level="3.9" id="animation-fill-mode"><span class="secno">3.9. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode⑤">animation-fill-mode</a> property</span><a class="self-link" href="#animation-fill-mode"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode⑥">animation-fill-mode</a> property defines what values are applied by the animation
	outside the  time it is executing. By default, an animation will not affect property
	values between the time it is applied (the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①④">animation-name</a> property is set on an
	element) and the time it begins execution (which is determined by the <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay⑦">animation-delay</a> property). Also, by default an animation does not affect property values after the
	animation ends (determined by the <a class="property" data-link-type="propdesc" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration③">animation-duration</a> and <a class="property" data-link-type="propdesc" href="#propdef-animation-iteration-count" id="ref-for-propdef-animation-iteration-count③">animation-iteration-count</a> properties).
	The <span class="property" id="ref-for-propdef-animation-fill-mode⑦">animation-fill-mode</span> property can override this behavior. Dynamic updates to the property will
	be reflected by property values as needed, whether during the animation delay or after the animation ends.</p>
   <table class="def propdef" data-link-for-hint="animation-fill-mode">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation-fill-mode">animation-fill-mode</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-single-animation-fill-mode" id="ref-for-typedef-single-animation-fill-mode">&lt;single-animation-fill-mode></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma⑦">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>none 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a keyword as specified 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p><dfn class="dfn-paneled css" data-dfn-type="type" data-export id="typedef-single-animation-fill-mode">&lt;single-animation-fill-mode></dfn> = none | forwards | backwards | both</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-fill-mode" data-dfn-type="value" data-export id="valdef-animation-fill-mode-none">none</dfn> 
    <dd> The animation has no effect when it is applied but not executing. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-fill-mode" data-dfn-type="value" data-export id="valdef-animation-fill-mode-forwards">forwards</dfn> 
    <dd> After the animation ends (as determined by its <a class="property" data-link-type="propdesc" href="#propdef-animation-iteration-count" id="ref-for-propdef-animation-iteration-count④">animation-iteration-count</a>), the animation
			will apply the property values for the time the animation ended. When <span class="property" id="ref-for-propdef-animation-iteration-count⑤">animation-iteration-count</span> is an integer greater than zero, the values applied will be those for the end of the last
			completed iteration of the animation (rather than the values for the start of the iteration
			that would be next). When <span class="property" id="ref-for-propdef-animation-iteration-count⑥">animation-iteration-count</span> is zero, the values applied will be
			those that would start the first iteration (just as when <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode⑧">animation-fill-mode</a> is <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-backwards" id="ref-for-valdef-animation-fill-mode-backwards①">backwards</a>). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-fill-mode" data-dfn-type="value" data-export id="valdef-animation-fill-mode-backwards">backwards</dfn> 
    <dd> During the period defined by <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay⑧">animation-delay</a>, the animation will apply the property values
			defined in the keyframe that will start the first iteration of the animation.
			These are either the values of the <span class="css">from</span> keyframe (when <a class="property" data-link-type="propdesc" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction⑥">animation-direction</a> is <a class="css" data-link-type="maybe" href="#valdef-animation-direction-normal" id="ref-for-valdef-animation-direction-normal">normal</a> or <a class="css" data-link-type="maybe" href="#valdef-animation-direction-alternate" id="ref-for-valdef-animation-direction-alternate①">alternate</a>) or those of the <span class="css">to</span> keyframe (when <span class="property" id="ref-for-propdef-animation-direction⑦">animation-direction</span> is <a class="css" data-link-type="maybe" href="#valdef-animation-direction-reverse" id="ref-for-valdef-animation-direction-reverse">reverse</a> or <a class="css" data-link-type="maybe" href="#valdef-animation-direction-alternate-reverse" id="ref-for-valdef-animation-direction-alternate-reverse">alternate-reverse</a>). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="animation-fill-mode" data-dfn-type="value" data-export id="valdef-animation-fill-mode-both">both</dfn> 
    <dd> The effects of both <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-forwards" id="ref-for-valdef-animation-fill-mode-forwards②">forwards</a> and <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-backwards" id="ref-for-valdef-animation-fill-mode-backwards②">backwards</a> fill apply. 
   </dl>
   <h3 class="heading settled" data-level="3.10" id="animation"><span class="secno">3.10. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#propdef-animation" id="ref-for-propdef-animation">animation</a> shorthand property</span><a class="self-link" href="#animation"></a></h3>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-animation" id="ref-for-propdef-animation①">animation</a> shorthand property is a comma-separated list of animation definitions. Each item in
	the list gives one item of the value for all of the subproperties of the shorthand, which are known
	as the animation properties. (See the definition of <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①⑤">animation-name</a> for what happens when these
	properties have lists of different lengths, a problem that cannot occur when they are defined using
	only the <span class="property" id="ref-for-propdef-animation②">animation</span> shorthand.)</p>
   <table class="def propdef" data-link-for-hint="animation">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-animation">animation</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-single-animation" id="ref-for-typedef-single-animation">&lt;single-animation></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma⑧">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>see individual properties 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>see individual properties 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p><dfn class="dfn-paneled css" data-dfn-type="type" data-export id="typedef-single-animation">&lt;single-animation></dfn> = <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value⑧" title="Expands to: ms | s">&lt;time></a> || <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function" id="ref-for-typedef-easing-function②">&lt;easing-function></a> || <span class="production" id="ref-for-time-value⑨" title="Expands to: ms | s">&lt;time></span> || <a class="production css" data-link-type="type" href="#typedef-single-animation-iteration-count" id="ref-for-typedef-single-animation-iteration-count①">&lt;single-animation-iteration-count></a> || <a class="production css" data-link-type="type" href="#typedef-single-animation-direction" id="ref-for-typedef-single-animation-direction①">&lt;single-animation-direction></a> || <a class="production css" data-link-type="type" href="#typedef-single-animation-fill-mode" id="ref-for-typedef-single-animation-fill-mode①">&lt;single-animation-fill-mode></a> || <a class="production css" data-link-type="type" href="#typedef-single-animation-play-state" id="ref-for-typedef-single-animation-play-state①">&lt;single-animation-play-state></a> || [ none | <a class="production css" data-link-type="type" href="#typedef-keyframes-name" id="ref-for-typedef-keyframes-name④">&lt;keyframes-name></a> ]</p>
   <p>Note that order is important within each animation definition: the first value in each <a class="production css" data-link-type="type" href="#typedef-single-animation" id="ref-for-typedef-single-animation①">&lt;single-animation></a> that can be parsed as a <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value①⓪" title="Expands to: ms | s">&lt;time></a> is assigned to the <a class="property" data-link-type="propdesc" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration④">animation-duration</a>,
	and the second value in each <span class="production" id="ref-for-typedef-single-animation②">&lt;single-animation></span> that can be parsed as a <span class="production" id="ref-for-time-value①①" title="Expands to: ms | s">&lt;time></span> is assigned to <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay⑨">animation-delay</a>.</p>
   <p>Note that order is also important within each animation definition for distinguishing <a class="production css" data-link-type="type" href="#typedef-keyframes-name" id="ref-for-typedef-keyframes-name⑤">&lt;keyframes-name></a> values from other keywords. When parsing, keywords that are valid for
	properties other than <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①⑥">animation-name</a> whose values were not found earlier in the shorthand
	must be accepted for those properties rather than for <span class="property" id="ref-for-propdef-animation-name①⑦">animation-name</span>. Furthermore, when serializing, default values of other properties must be
	output in at least the cases necessary to distinguish an <span class="property" id="ref-for-propdef-animation-name①⑧">animation-name</span> that could
	be a value of another property, and may be output in additional cases.</p>
   <div class="example" id="example-f4782312"><a class="self-link" href="#example-f4782312"></a> For example, a value parsed from <a class="css" data-link-type="propdesc" href="#propdef-animation" id="ref-for-propdef-animation③">animation: 3s none backwards</a> (where <a class="property" data-link-type="propdesc" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode⑨">animation-fill-mode</a> is <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-none" id="ref-for-valdef-animation-fill-mode-none①">none</a> and <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name①⑨">animation-name</a> is <span class="css">backwards</span>)
		must not be serialized as <span class="css" id="ref-for-propdef-animation④">animation: 3s backwards</span> (where <span class="property" id="ref-for-propdef-animation-fill-mode①⓪">animation-fill-mode</span> is <a class="css" data-link-type="maybe" href="#valdef-animation-fill-mode-backwards" id="ref-for-valdef-animation-fill-mode-backwards③">backwards</a> and <span class="property" id="ref-for-propdef-animation-name②⓪">animation-name</span> is <a class="css" data-link-type="maybe" href="#valdef-animation-name-none" id="ref-for-valdef-animation-name-none②">none</a>). </div>
   <h2 class="heading settled" data-level="4" id="events"><span class="secno">4. </span><span class="content"> Animation Events</span><a class="self-link" href="#events"></a></h2>
   <p>Several animation-related events are available through the DOM Event system. The start and
	end of an animation, and the end of each iteration of an animation, all generate DOM events.
	An element can have multiple properties being animated simultaneously. This can occur either
	with a single <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name②①">animation-name</a> value with keyframes containing multiple properties, or with
	multiple <span class="property" id="ref-for-propdef-animation-name②②">animation-name</span> values. For the purposes of events, each <span class="property" id="ref-for-propdef-animation-name②③">animation-name</span> specifies
	a single animation. Therefore an event will be generated for each <span class="property" id="ref-for-propdef-animation-name②④">animation-name</span> value and
	not necessarily for each property being animated.</p>
   <p>Any animation for which a valid keyframe rule is defined will run
	and generate events; this includes animations with empty keyframe rules.</p>
   <p>The time the animation has been running is sent with each event generated. This allows the event
	handler to determine the current iteration of a looping animation or the current position of an
	alternating animation. This time does not include any time the animation was in the <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-paused" id="ref-for-valdef-animation-play-state-paused②">paused</a> play state.</p>
   <h3 class="heading settled" data-level="4.1" id="interface-animationevent"><span class="secno">4.1. </span><span class="content"> The <code>AnimationEvent</code> Interface</span><a class="self-link" href="#interface-animationevent"></a></h3>
   <p>The <code>AnimationEvent</code> interface provides specific contextual information associated with
	Animation events.</p>
   <h4 class="heading settled" data-level="4.1.1" id="interface-animationevent-idl"><span class="secno">4.1.1. </span><span class="content"> IDL Definition</span><a class="self-link" href="#interface-animationevent-idl"></a></h4>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="idl-code" data-dfn-type="interface" data-export id="animationevent"><code><c- g>AnimationEvent</c-></code><a class="self-link" href="#animationevent"></a></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event" id="ref-for-event"><c- n>Event</c-></a> {
  <dfn class="idl-code" data-dfn-for="AnimationEvent" data-dfn-type="constructor" data-export data-lt="AnimationEvent(type, animationEventInitDict)|constructor(type, animationEventInitDict)|AnimationEvent(type)|constructor(type)" id="dom-animationevent-animationevent"><code><c- g>constructor</c-></code><a class="self-link" href="#dom-animationevent-animationevent"></a></dfn>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="AnimationEvent/AnimationEvent(type, animationEventInitDict), AnimationEvent/constructor(type, animationEventInitDict), AnimationEvent/AnimationEvent(type), AnimationEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-animationevent-animationevent-type-animationeventinitdict-type"><code><c- g>type</c-></code><a class="self-link" href="#dom-animationevent-animationevent-type-animationeventinitdict-type"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-animationeventinit" id="ref-for-dictdef-animationeventinit"><c- n>AnimationEventInit</c-></a> <dfn class="idl-code" data-dfn-for="AnimationEvent/AnimationEvent(type, animationEventInitDict), AnimationEvent/constructor(type, animationEventInitDict), AnimationEvent/AnimationEvent(type), AnimationEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-animationevent-animationevent-type-animationeventinitdict-animationeventinitdict"><code><c- g>animationEventInitDict</c-></code><a class="self-link" href="#dom-animationevent-animationevent-type-animationeventinitdict-animationeventinitdict"></a></dfn> = {});
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-animationevent-animationname" id="ref-for-dom-animationevent-animationname"><c- g>animationName</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime"><c- g>elapsedTime</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-animationevent-pseudoelement" id="ref-for-dom-animationevent-pseudoelement"><c- g>pseudoElement</c-></a>;
};
<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-animationeventinit"><code><c- g>AnimationEventInit</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit" id="ref-for-dictdef-eventinit"><c- n>EventInit</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;&quot;" data-dfn-for="AnimationEventInit" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-animationeventinit-animationname"><code><c- g>animationName</c-></code><a class="self-link" href="#dom-animationeventinit-animationname"></a></dfn> = "";
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①"><c- b>double</c-></a> <dfn class="idl-code" data-default="0.0" data-dfn-for="AnimationEventInit" data-dfn-type="dict-member" data-export data-type="double " id="dom-animationeventinit-elapsedtime"><code><c- g>elapsedTime</c-></code><a class="self-link" href="#dom-animationeventinit-elapsedtime"></a></dfn> = 0.0;
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring④"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;&quot;" data-dfn-for="AnimationEventInit" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-animationeventinit-pseudoelement"><code><c- g>pseudoElement</c-></code><a class="self-link" href="#dom-animationeventinit-pseudoelement"></a></dfn> = "";
};
</pre>
   <h4 class="heading settled" data-level="4.1.2" id="interface-animationevent-attributes"><span class="secno">4.1.2. </span><span class="content"> Attributes</span><a class="self-link" href="#interface-animationevent-attributes"></a></h4>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="AnimationEvent" data-dfn-type="attribute" data-export id="dom-animationevent-animationname"><code>animationName</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑤">CSSOMString</a>, readonly</span>
    <dd> The value of the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name②⑤">animation-name</a> property of the animation that fired the event. 
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="AnimationEvent" data-dfn-type="attribute" data-export id="dom-animationevent-elapsedtime"><code>elapsedTime</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②">double</a>, readonly</span>
    <dd> The amount of time the animation has been running, in seconds, when this event fired,
			excluding any time the animation was paused. The precise calculation for
			of this member is defined along with each event type. 
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="AnimationEvent" data-dfn-type="attribute" data-export id="dom-animationevent-pseudoelement"><code>pseudoElement</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑥">CSSOMString</a>, readonly</span>
    <dd> The name (beginning with two colons) of the CSS pseudo-element on which the animation
			runs (in which case the target of the event is that pseudo-element’s corresponding
			element), or the empty string if the animation runs on an element (which means the
			target of the event is that element). 
   </dl>
   <p><dfn class="css" data-dfn-type="function" data-export data-lt="AnimationEvent()" id="funcdef-animationevent">AnimationEvent(type, animationEventInitDict)<a class="self-link" href="#funcdef-animationevent"></a></dfn> is an <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#constructing-events" id="ref-for-constructing-events">event constructor</a>.</p>
   <h3 class="heading settled" data-level="4.2" id="event-animationevent"><span class="secno">4.2. </span><span class="content"> Types of <code>AnimationEvent</code></span><a class="self-link" href="#event-animationevent"></a></h3>
   <p>The different types of animation events that can occur are:</p>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="animationevent" data-dfn-type="event" data-export id="eventdef-animationevent-animationstart"><code>animationstart</code></dfn> 
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationstart" id="ref-for-eventdef-animationevent-animationstart①">animationstart</a></code> event occurs at the start of the animation.
			If there is an <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay①⓪">animation-delay</a> then this event will fire once the delay
			period has expired. 
     <p> A negative delay will cause the event to fire with
			an <code class="idl"><a data-link-type="idl" href="#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime①">elapsedTime</a></code> equal to the absolute value of the delay
			capped to the <a data-link-type="dfn" href="#active-duration" id="ref-for-active-duration">active duration</a> of the animation, that is, <code>min(max(-<a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay①①">animation-delay</a>, 0), <a data-link-type="dfn" href="#active-duration" id="ref-for-active-duration①">active duration</a>)</code>; in
			this case the event will fire whether <a class="property" data-link-type="propdesc" href="#propdef-animation-play-state" id="ref-for-propdef-animation-play-state③">animation-play-state</a> is set to <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-running" id="ref-for-valdef-animation-play-state-running③">running</a> or <a class="css" data-link-type="maybe" href="#valdef-animation-play-state-paused" id="ref-for-valdef-animation-play-state-paused③">paused</a>. </p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: animationName, elapsedTime, pseudoElement
     </ul>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="animationevent" data-dfn-type="event" data-export id="eventdef-animationevent-animationend"><code>animationend</code></dfn> 
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationend" id="ref-for-eventdef-animationevent-animationend①">animationend</a></code> event occurs when the animation finishes.
			In this case the value of the <code class="idl"><a data-link-type="idl" href="#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime②">elapsedTime</a></code> member of
			the event is equal to the <a data-link-type="dfn" href="#active-duration" id="ref-for-active-duration②">active duration</a>. 
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: animationName, elapsedTime, pseudoElement
     </ul>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="animationevent" data-dfn-type="event" data-export id="eventdef-animationevent-animationiteration"><code>animationiteration</code></dfn> 
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationiteration" id="ref-for-eventdef-animationevent-animationiteration">animationiteration</a></code> event occurs at the end of each iteration of an
			animation, except when an animationend event would fire at the same time.
			This means that this event does not occur for animations with an iteration
			count of one or less. 
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime③">elapsedTime</a></code> member in this case is equal to the
			product of the <var>current iteration</var> and <a class="property" data-link-type="propdesc" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration⑤">animation-duration</a> where
			the <var>current iteration</var> is the zero-based index of the new
			iteration. For example, assuming no negative <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay①②">animation-delay</a>, after one
			iteration completes the <var>current iteration</var> would be one.</p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: animationName, elapsedTime, pseudoElement
     </ul>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="animationevent" data-dfn-type="event" data-export id="eventdef-animationevent-animationcancel"><code>animationcancel</code></dfn> 
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationcancel" id="ref-for-eventdef-animationevent-animationcancel">animationcancel</a></code> event occurs when the animation stops
			running in a way that does not fire an <code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationend" id="ref-for-eventdef-animationevent-animationend②">animationend</a></code> event, such
			as a change in the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name②⑥">animation-name</a> that removes the animation, or the
			animating element or one of its ancestors becoming <span class="css">display:none</span>. 
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime④">elapsedTime</a></code> member for this event indicates
			the number of seconds that had elapsed since the beginning of the
			animation at the moment when the animation was canceled.
			This excludes any time where the animation was paused. If the animation
			had a negative <a class="property" data-link-type="propdesc" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay①③">animation-delay</a>, the beginning of the animation is the
			moment equal to the absolute value of <span class="property" id="ref-for-propdef-animation-delay①④">animation-delay</span> seconds <em>prior</em> to when the animation was actually triggered.
			Alternatively, if the animation had a positive <span class="property" id="ref-for-propdef-animation-delay①⑤">animation-delay</span> and the
			event is fired before the animation’s delay has expired, the <code class="idl"><a data-link-type="idl" href="#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime⑤">elapsedTime</a></code> will be zero.</p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: animationName, elapsedTime, pseudoElement
     </ul>
   </dl>
   <h3 class="heading settled" data-level="4.3" id="event-handlers-on-elements-document-objects-and-window-objects"><span class="secno">4.3. </span><span class="content">Event
handlers on elements, <code>Document</code> objects, and <code>Window</code> objects</span><a class="self-link" href="#event-handlers-on-elements-document-objects-and-window-objects"></a></h3>
   <p>The following are the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers">event handlers</a> (and their corresponding <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type">event
handler event types</a>) that must be supported by all <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements" id="ref-for-html-elements">HTML elements</a>, as
both <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes" id="ref-for-event-handler-content-attributes">event handler content attributes</a> and <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes" id="ref-for-event-handler-idl-attributes">event handler IDL
attributes</a>; and that must be supported by all <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document">Document</a></code> and <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window">Window</a></code> objects, as <span id="ref-for-event-handler-idl-attributes①">event handler IDL attributes</span>:</p>
   <table class="event-handlers">
    <tbody>
     <tr>
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers①">Event handler</a>
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type①">Event handler event type</a>
     <tr>
      <td><dfn class="idl-code" data-dfn-for="Document, Window" data-dfn-type="attribute" data-export id="dom-document-onanimationstart"><code>onanimationstart</code><a class="self-link" href="#dom-document-onanimationstart"></a></dfn>
      <td><code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationstart" id="ref-for-eventdef-animationevent-animationstart②">animationstart</a></code>
     <tr>
      <td><dfn class="idl-code" data-dfn-for="Document, Window" data-dfn-type="attribute" data-export id="dom-document-onanimationiteration"><code>onanimationiteration</code><a class="self-link" href="#dom-document-onanimationiteration"></a></dfn>
      <td><code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationiteration" id="ref-for-eventdef-animationevent-animationiteration①">animationiteration</a></code>
     <tr>
      <td><dfn class="idl-code" data-dfn-for="Document, Window" data-dfn-type="attribute" data-export id="dom-document-onanimationend"><code>onanimationend</code><a class="self-link" href="#dom-document-onanimationend"></a></dfn>
      <td><code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationend" id="ref-for-eventdef-animationevent-animationend③">animationend</a></code>
     <tr>
      <td><dfn class="idl-code" data-dfn-for="Document, Window" data-dfn-type="attribute" data-export id="dom-document-onanimationcancel"><code>onanimationcancel</code><a class="self-link" href="#dom-document-onanimationcancel"></a></dfn>
      <td><code class="idl"><a data-link-type="idl" href="#eventdef-animationevent-animationcancel" id="ref-for-eventdef-animationevent-animationcancel①">animationcancel</a></code>
   </table>
   <h2 class="heading settled" data-level="5" id="interface-dom"><span class="secno">5. </span><span class="content"> DOM Interfaces</span><a class="self-link" href="#interface-dom"></a></h2>
   <p>CSS animations are exposed to the CSSOM through a pair of new interfaces describing the keyframes.</p>
   <p class="note" role="note"><span>Note:</span> the interfaces defined below reflect the interoperable API available as of this level of the specification. Future levels may deprecate parts of this API and extend others.</p>
   <h3 class="heading settled" data-level="5.1" id="interface-cssrule"><span class="secno">5.1. </span><span class="content"> The <code>CSSRule</code> Interface</span><a class="self-link" href="#interface-cssrule"></a></h3>
   <p>The following two rule types are added to the <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule">CSSRule</a></code> interface. They provide
	identification for the new keyframe and keyframes rules.</p>
   <h4 class="heading settled" data-level="5.1.1" id="interface-cssrule-idl"><span class="secno">5.1.1. </span><span class="content"> IDL Definition</span><a class="self-link" href="#interface-cssrule-idl"></a></h4>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule①"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-keyframes_rule"><code><c- g>KEYFRAMES_RULE</c-></code><a class="self-link" href="#dom-cssrule-keyframes_rule"></a></dfn> = 7;
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short①"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-keyframe_rule"><code><c- g>KEYFRAME_RULE</c-></code><a class="self-link" href="#dom-cssrule-keyframe_rule"></a></dfn> = 8;
};
</pre>
   <h3 class="heading settled" data-level="5.2" id="interface-csskeyframerule"><span class="secno">5.2. </span><span class="content"> The <code>CSSKeyframeRule</code> Interface</span><a class="self-link" href="#interface-csskeyframerule"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#csskeyframerule" id="ref-for-csskeyframerule">CSSKeyframeRule</a></code> interface represents the style rule for a single key.</p>
   <h4 class="heading settled" data-level="5.2.1" id="interface-csskeyframerule-idl"><span class="secno">5.2.1. </span><span class="content"> IDL Definition</span><a class="self-link" href="#interface-csskeyframerule-idl"></a></h4>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="csskeyframerule"><code><c- g>CSSKeyframeRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule②"><c- n>CSSRule</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑦"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csskeyframerule-keytext" id="ref-for-dom-csskeyframerule-keytext"><c- g>keyText</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="https://drafts.csswg.org/cssom-1/#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration" id="ref-for-cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-csskeyframerule-style" id="ref-for-dom-csskeyframerule-style"><c- g>style</c-></a>;
};
</pre>
   <h4 class="heading settled" data-level="5.2.2" id="interface-csskeyframerule-attributes"><span class="secno">5.2.2. </span><span class="content"> Attributes</span><a class="self-link" href="#interface-csskeyframerule-attributes"></a></h4>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframeRule" data-dfn-type="attribute" data-export id="dom-csskeyframerule-keytext"><code>keyText</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑧">CSSOMString</a></span>
    <dd>
      This attribute represents the keyframe selector as a comma-separated list
      of percentage values. The <span class="css">from</span> and <span class="css">to</span> keywords map to 0% and 100%,
      respectively. 
     <p>If <a class="idl-code" data-link-type="attribute" href="#dom-csskeyframerule-keytext" id="ref-for-dom-csskeyframerule-keytext①">keyText</a> is updated with an
      invalid keyframe selector, a <a class="idl-code" data-link-type="exception" href="https://heycam.github.io/webidl/#syntaxerror" id="ref-for-syntaxerror">SyntaxError</a> exception must be thrown and the value of <span id="ref-for-dom-csskeyframerule-keytext②">keyText</span> must remain unchanged.</p>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframeRule" data-dfn-type="attribute" data-export id="dom-csskeyframerule-style"><code>style</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration" id="ref-for-cssstyledeclaration①">CSSStyleDeclaration</a>, readonly</span>
    <dd>
      Must return a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration" id="ref-for-cssstyledeclaration②">CSSStyleDeclaration</a></code> object for the
      keyframe rule, with the following properties: 
     <dl>
      <dt><a data-link-type="dfn" href="https://www.w3.org/TR/cssom-1/#cssstyledeclaration-readonly-flag" id="ref-for-cssstyledeclaration-readonly-flag">readonly flag</a>
      <dd>Unset.
      <dt><a data-link-type="dfn" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations">declarations</a>
      <dd>The declared declarations in the rule, in <a data-link-type="dfn" href="https://drafts.csswg.org/cssom-1/#concept-declarations-specified-order" id="ref-for-concept-declarations-specified-order">specified
            order</a>.
      <dt><a data-link-type="dfn" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule">parent CSS rule</a>
      <dd>The <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object">context object</a> (i.e. this <code class="idl"><a data-link-type="idl" href="#csskeyframerule" id="ref-for-csskeyframerule①">CSSKeyframeRule</a></code>).
      <dt><a data-link-type="dfn" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node">owner node</a>
      <dd>Null.
     </dl>
   </dl>
   <h3 class="heading settled" data-level="5.3" id="interface-csskeyframesrule"><span class="secno">5.3. </span><span class="content"> The <code>CSSKeyframesRule</code> Interface</span><a class="self-link" href="#interface-csskeyframesrule"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#csskeyframesrule" id="ref-for-csskeyframesrule">CSSKeyframesRule</a></code> interface represents a complete set of keyframes for
	a single animation.</p>
   <h4 class="heading settled" data-level="5.3.1" id="interface-csskeyframesrule-idl"><span class="secno">5.3.1. </span><span class="content"> IDL Definition</span><a class="self-link" href="#interface-csskeyframesrule-idl"></a></h4>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="csskeyframesrule"><code><c- g>CSSKeyframesRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule③"><c- n>CSSRule</c-></a> {
           <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑨"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csskeyframesrule-name" id="ref-for-dom-csskeyframesrule-name"><c- g>name</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrulelist" id="ref-for-cssrulelist"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-csskeyframesrule-cssrules" id="ref-for-dom-csskeyframesrule-cssrules"><c- g>cssRules</c-></a>;

  <c- b>void</c->             <a class="idl-code" data-link-type="method" href="#dom-csskeyframesrule-appendrule" id="ref-for-dom-csskeyframesrule-appendrule"><c- g>appendRule</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⓪"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-csskeyframesrule-appendrule-rule-rule" id="ref-for-dom-csskeyframesrule-appendrule-rule-rule"><c- g>rule</c-></a>);
  <c- b>void</c->             <a class="idl-code" data-link-type="method" href="#dom-csskeyframesrule-deleterule" id="ref-for-dom-csskeyframesrule-deleterule"><c- g>deleteRule</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-csskeyframesrule-deleterule-select-select" id="ref-for-dom-csskeyframesrule-deleterule-select-select"><c- g>select</c-></a>);
  <a class="n" data-link-type="idl-name" href="#csskeyframerule" id="ref-for-csskeyframerule②"><c- n>CSSKeyframeRule</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-csskeyframesrule-findrule" id="ref-for-dom-csskeyframesrule-findrule"><c- g>findRule</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-csskeyframesrule-findrule-select-select" id="ref-for-dom-csskeyframesrule-findrule-select-select"><c- g>select</c-></a>);
};
</pre>
   <h4 class="heading settled" data-level="5.3.2" id="interface-csskeyframesrule-attributes"><span class="secno">5.3.2. </span><span class="content"> Attributes</span><a class="self-link" href="#interface-csskeyframesrule-attributes"></a></h4>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule" data-dfn-type="attribute" data-export id="dom-csskeyframesrule-name"><code>name</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①③">CSSOMString</a></span>
    <dd> This attribute is the name of the keyframes, used by the <a class="property" data-link-type="propdesc" href="#propdef-animation-name" id="ref-for-propdef-animation-name②⑦">animation-name</a> property. 
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule" data-dfn-type="attribute" data-export id="dom-csskeyframesrule-cssrules"><code>cssRules</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrulelist" id="ref-for-cssrulelist①">CSSRuleList</a>, readonly</span>
    <dd> This attribute gives access to the keyframes in the list. 
   </dl>
   <h4 class="heading settled" data-level="5.3.3" id="interface-csskeyframesrule-appendrule"><span class="secno">5.3.3. </span><span class="content"> The <code>appendRule</code> method</span><a class="self-link" href="#interface-csskeyframesrule-appendrule"></a></h4>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule" data-dfn-type="method" data-export data-lt="appendRule(rule)" id="dom-csskeyframesrule-appendrule"><code>appendRule</code></dfn> method appends the passed <code class="idl"><a data-link-type="idl" href="#csskeyframerule" id="ref-for-csskeyframerule③">CSSKeyframeRule</a></code> at the end of the keyframes rule.</p>
   <p>Parameters:</p>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule/appendRule(rule)" data-dfn-type="argument" data-export id="dom-csskeyframesrule-appendrule-rule-rule"><code>rule</code></dfn> of type <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①④">CSSOMString</a></code> 
    <dd> The rule to be appended, expressed in the same syntax as one entry in the <a class="css" data-link-type="maybe" href="#at-ruledef-keyframes" id="ref-for-at-ruledef-keyframes⑨">@keyframes</a> rule. A valid rule is always appended e.g. even if its key(s) already
			exists. 
   </dl>
   <p>No Return Value</p>
   <p>No Exceptions</p>
   <h4 class="heading settled" data-level="5.3.4" id="interface-csskeyframesrule-deleterule"><span class="secno">5.3.4. </span><span class="content"> The <code>deleteRule</code> method</span><a class="self-link" href="#interface-csskeyframesrule-deleterule"></a></h4>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule" data-dfn-type="method" data-export data-lt="deleteRule(select)" id="dom-csskeyframesrule-deleterule"><code>deleteRule</code></dfn> method
deletes the last declared <code class="idl"><a data-link-type="idl" href="#csskeyframerule" id="ref-for-csskeyframerule④">CSSKeyframeRule</a></code> matching the specified keyframe selector.
If no matching rule exists, the method does nothing.</p>
   <p>Parameters:</p>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule/deleteRule(select)" data-dfn-type="argument" data-export id="dom-csskeyframesrule-deleterule-select-select"><code>select</code></dfn> of type <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑤">CSSOMString</a></code> 
    <dd>
      The keyframe selector of the rule to be deleted: a comma-separated list of percentage values between 0% and 100% or the keywords <span class="css">from</span> or <span class="css">to</span> which resolve to 0% and 100%, respectively. 
     <p>The number and order of the values in the specified keyframe selector must match those of the targeted keyframe rule(s).  The match is not sensitive to white space around the values in the list.</p>
   </dl>
   <p>No Return Value</p>
   <p>No Exceptions</p>
   <h4 class="heading settled" data-level="5.3.5" id="interface-csskeyframesrule-findrule"><span class="secno">5.3.5. </span><span class="content"> The <code>findRule</code> method</span><a class="self-link" href="#interface-csskeyframesrule-findrule"></a></h4>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule" data-dfn-type="method" data-export data-lt="findRule(select)" id="dom-csskeyframesrule-findrule"><code>findRule</code></dfn> returns the
    last declared <code class="idl"><a data-link-type="idl" href="#csskeyframerule" id="ref-for-csskeyframerule⑤">CSSKeyframeRule</a></code> matching the specified keyframe selector.
    If no matching rule exists, the method does nothing.</p>
   <p>Parameters:</p>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSKeyframesRule/findRule(select)" data-dfn-type="argument" data-export id="dom-csskeyframesrule-findrule-select-select"><code>select</code></dfn> of type <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑥">CSSOMString</a></code> 
    <dd>
      The keyframe selector of the rule to be deleted: a comma-separated list of percentage values between 0% and 100% or the keywords <span class="css">from</span> or <span class="css">to</span> which resolve to 0% and 100%, respectively. 
     <p>The number and order of the values in the specified keyframe selector must match those of the targeted keyframe rule(s). The match is not sensitive to white space around the values in the list.</p>
   </dl>
   <p>Return Value:</p>
   <dl>
    <dt><code class="idl"><a data-link-type="idl" href="#csskeyframerule" id="ref-for-csskeyframerule⑥">CSSKeyframeRule</a></code> 
    <dd> The found rule. 
   </dl>
   <p>No Exceptions</p>
   <div class="example" id="example-d1f87811">
    <a class="self-link" href="#example-d1f87811"></a> For example, given the following animation: 
<pre>@keyframes colorful-diagonal-slide {

  from {
    left: 0;
    top: 0;
  }

  10% {
    background-color: blue;
  }

  10% {
    background-color: green;
  }

  25%, 75% {
    background-color: red;
  }

  100% {
    left: 100px;
    top: 100px;
  }

}
</pre>
    <p>Assuming the variable <code>anim</code> holds a reference to a CSSKeyframesRule object for this animation, then:</p>
<pre>anim.deleteRule('10%');
var tenPercent = anim.findRule('10%');
</pre>
    <p>will start by deleting the last 10% rule i.e. the green background color rule; then find the remaining blue background rule and return it into <code>tenPercent</code>.</p>
    <p>The following:</p>
<pre>var red = anim.findRule('75%');
</pre>
    <p>will set <code>red</code> to <code>null</code>. The full selector for the red background color rule must be used instead:</p>
<pre>var red = anim.findRule('25%,75%');
</pre>
    <p>Since <span class="css">from</span> maps to 0% and <span class="css">to</span> maps to 100%, we can find these rules using either value:</p>
<pre>var from = anim.findRule('0%'); // Returns from { left: 0; top: 0; } rule
var to = anim.findRule('to');   // Returns 100% { left: 100px; top: 100px; } rule
</pre>
   </div>
   <h3 class="heading settled" data-level="5.4" id="interface-globaleventhandlers"><span class="secno">5.4. </span><span class="content"> Extensions to the <code>GlobalEventHandlers</code> Interface Mixin</span><a class="self-link" href="#interface-globaleventhandlers"></a></h3>
   <p>This specification extends the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers" id="ref-for-globaleventhandlers">GlobalEventHandlers</a></code> interface mixin from HTML to
add <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes" id="ref-for-event-handler-idl-attributes②">event handler IDL attributes</a> for <a href="#events">animation
events</a> as defined in <a href="#event-handlers-on-elements-document-objects-and-window-objects">§ 4.3 Event
handlers on elements, Document objects, and Window
objects</a>.</p>
   <h4 class="heading settled" data-level="5.4.1" id="interface-globaleventhandlers-idl"><span class="secno">5.4.1. </span><span class="content"> IDL Definition</span><a class="self-link" href="#interface-globaleventhandlers-idl"></a></h4>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers" id="ref-for-globaleventhandlers①"><c- g>GlobalEventHandlers</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler"><c- n>EventHandler</c-></a> <dfn class="idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-onanimationstart"><code><c- g>onanimationstart</c-></code><a class="self-link" href="#dom-globaleventhandlers-onanimationstart"></a></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler①"><c- n>EventHandler</c-></a> <dfn class="idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-onanimationiteration"><code><c- g>onanimationiteration</c-></code><a class="self-link" href="#dom-globaleventhandlers-onanimationiteration"></a></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler②"><c- n>EventHandler</c-></a> <dfn class="idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-onanimationend"><code><c- g>onanimationend</c-></code><a class="self-link" href="#dom-globaleventhandlers-onanimationend"></a></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler③"><c- n>EventHandler</c-></a> <dfn class="idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-onanimationcancel"><code><c- g>onanimationcancel</c-></code><a class="self-link" href="#dom-globaleventhandlers-onanimationcancel"></a></dfn>;
};
</pre>
   <h2 class="heading settled" data-level="6" id="priv-sec"><span class="secno">6. </span><span class="content"> Privacy and Security Considerations</span><a class="self-link" href="#priv-sec"></a></h2>
   <p>This specification introduces no new privacy or security considerations.</p>
   <h2 class="heading settled" data-level="7" id="acknowledgements"><span class="secno">7. </span><span class="content"> Acknowledgements</span><a class="self-link" href="#acknowledgements"></a></h2>
   <p>Thanks especially to the feedback from
	Tab Atkins,
	Brian Birtles,
	Shane Stephens,
	Carine Bournez,
	Christian Budde,
	Anne van Kesteren,
	Øyvind Stenhaug,
	Estelle Weyl,
	and all the rest of the www-style community.</p>
   <h2 class="heading settled" data-level="8" id="other-open-issues"><span class="secno">8. </span><span class="content">Other open issues</span><a class="self-link" href="#other-open-issues"></a></h2>
   <p class="issue" id="issue-c01277bc"><a class="self-link" href="#issue-c01277bc"></a>Need to <a href="https://lists.w3.org/Archives/Public/www-style/2015Jul/0391.html">specify how keyframes interact</a>.</p>
   <h2 class="heading settled" data-level="9" id="wg-resolutions-pending"><span class="secno">9. </span><span class="content"> Working Group Resolutions that are pending editing</span><a class="self-link" href="#wg-resolutions-pending"></a></h2>
   <p><em>This section is informative and temporary.</em></p>
   <p>The editors are currently behind on editing this spec. The following working group resolutions still
	need to be edited in:</p>
   <ul>
    <li>
     2014-09-09 minutes (Antibes f2f) 
     <ul>
      <li>Detail how/when keyframe values are computed; using <a href="http://lists.w3.org/Archives/Public/www-style/2014Aug/0132.html">G.beta in dbaron’s mail</a> 
      <li>
       <del>Agreed that both transitions and animations animate all properties. css-transitions to define animation of non-interoperable/discrete values. They take their starting values below 50% timing function progress, and end values above</del>
      <li>
       <del>Dynamic changes to animation properties/keyframes. Tab to propose resolution. (<a href="https://www.w3.org/Bugs/Public/show_bug.cgi?id=14713">Bug 14713</a>) </del>
      <li>
       <del>Negative animation-delay values apply against the active duration of the animation i.e. (animation-duration*animation-iteration-count). The delay can thus swallow iterations for which no iteration event will be fired. The start/end events are still fired. Even when delay == (-1*active_duration) </del>
      <li>
       <del>Fire animation start/end events when animation-duration is zero, with 0 elapsedTime </del>
      <li>
       <del>If animation-iteration-count is infinite and duration is 0, treat the iteration-count as if it was finite and run a 0s second (option A in <a href="http://lists.w3.org/Archives/Public/www-style/2014Sep/0056.html">Brian’s mail</a>) </del>
      <li>
       <del>If an animation with a negative animation delay is initially paused, the start event still fires </del>
     </ul>
    <li>
     2012-10-29 minutes 
     <ul>
      <li>
       <del>Change the animation properties to be dynamically changeable </del>
      <li>
       <del>@keyframes can be dynamically changed </del>
      <li>
       <del>When you encounter duplicate animations names, last one wins.</del>
      <li>
       <del>Make *animations* transition *all* properties. Unless otherwise specified, discrete properties take their starting values below 50% timing function progress, and end values above 50% timing function progress.</del>
     </ul>
    <li>
     2012-12-12 minutes and intermediate comments 
     <del>and 2012-12-19 minutes</del>
     <ul>
      <li>
       <del>Animations only run if they contain at least one valid keyframe rule (<a href="https://www.w3.org/Bugs/Public/show_bug.cgi?id=15251">Bug</a>) </del>
      <li>
       <del>When an element changes from display:none to display: non-none, animations start immediately (<a href="https://www.w3.org/Bugs/Public/show_bug.cgi?id=14785">Bug</a>)</del>
      <li>
       <del>An initially-paused animation is still started (fires start events etc.) (<a href="https://www.w3.org/Bugs/Public/show_bug.cgi?id=14774">Bug</a>) </del>
      <li>
       <del>Animations can be paused during their delay phase, which freezes the remaining delay to be applied after it unpauses (<a href="https://www.w3.org/Bugs/Public/show_bug.cgi?id=14774">Bug</a>)</del>
      <li>
       <del>animation-play-state has the same list behavior as the other animation properties, matching the length of animation-name (<a href="https://www.w3.org/Bugs/Public/show_bug.cgi?id=14786">Bug</a>)</del>
     </ul>
    <li>
     2013-02-20 minutes 
     <ul>
      <li>
       <del>Øyvind’s clarification accepted</del>
      <li>
       <del>keyframe rules cascade</del>
      <li>
       <del>mark pseudoElement at-risk</del>
     </ul>
    <li>
     2013-05-30 minutes 
     <ul>
      <li>
       <del>expectations on animations in non-interactive media</del>
     </ul>
    <li>
     2014-01-27 minutes 
     <ul>
      <li>
       <del>remove text about waiting for document load</del>
     </ul>
   </ul>
  </main>
  <h2 class="no-ref no-num heading settled" id="conformance"><span class="content"> Conformance</span><a class="self-link" href="#conformance"></a></h2>
  <h3 class="heading settled" id="document-conventions"><span class="content"> Document conventions</span><a class="self-link" href="#document-conventions"></a></h3>
  <p>Conformance requirements are expressed with a combination of
	descriptive assertions and RFC 2119 terminology. The key words “MUST”,
	“MUST NOT”, “REQUIRED”, “SHALL”, “SHALL NOT”, “SHOULD”, “SHOULD NOT”,
	“RECOMMENDED”, “MAY”, and “OPTIONAL” in the normative parts of this
	document are to be interpreted as described in RFC 2119.
	However, for readability, these words do not appear in all uppercase
	letters in this specification. </p>
  <p>All of the text of this specification is normative except sections
	explicitly marked as non-normative, examples, and notes. <a data-link-type="biblio" href="#biblio-rfc2119">[RFC2119]</a> </p>
  <p>Examples in this specification are introduced with the words “for example”
	or are set apart from the normative text with <code>class="example"</code>,
	like this: </p>
  <div class="example" id="example-ae2b6bc0">
   <a class="self-link" href="#example-ae2b6bc0"></a> 
   <p>This is an example of an informative example. </p>
  </div>
  <p>Informative notes begin with the word “Note” and are set apart from the
	normative text with <code>class="note"</code>, like this: </p>
  <p class="note" role="note">Note, this is an informative note. </p>
  <p>Advisements are normative sections styled to evoke special attention and are
	set apart from other normative text with <code>&lt;strong class="advisement"></code>, like
	this: <strong class="advisement"> UAs MUST provide an accessible alternative. </strong> </p>
  <h3 class="heading settled" id="conform-classes"><span class="content"> Conformance classes</span><a class="self-link" href="#conform-classes"></a></h3>
  <p>Conformance to this specification
	is defined for three conformance classes: </p>
  <dl>
   <dt>style sheet 
   <dd>A <a href="http://www.w3.org/TR/CSS2/conform.html#style-sheet">CSS
			style sheet</a>. 
   <dt>renderer 
   <dd>A <a href="http://www.w3.org/TR/CSS2/conform.html#user-agent">UA</a> that interprets the semantics of a style sheet and renders
			documents that use them. 
   <dt>authoring tool 
   <dd>A <a href="http://www.w3.org/TR/CSS2/conform.html#user-agent">UA</a> that writes a style sheet. 
  </dl>
  <p>A style sheet is conformant to this specification
	if all of its statements that use syntax defined in this module are valid
	according to the generic CSS grammar and the individual grammars of each
	feature defined in this module. </p>
  <p>A renderer is conformant to this specification
	if, in addition to interpreting the style sheet as defined by the
	appropriate specifications, it supports all the features defined
	by this specification by parsing them correctly
	and rendering the document accordingly. However, the inability of a
	UA to correctly render a document due to limitations of the device
	does not make the UA non-conformant. (For example, a UA is not
	required to render color on a monochrome monitor.) </p>
  <p>An authoring tool is conformant to this specification
	if it writes style sheets that are syntactically correct according to the
	generic CSS grammar and the individual grammars of each feature in
	this module, and meet all other conformance requirements of style sheets
	as described in this module. </p>
  <h3 class="heading settled" id="conform-responsible"><span class="content"> Requirements for Responsible Implementation of CSS</span><a class="self-link" href="#conform-responsible"></a></h3>
  <p>The following sections define several conformance requirements
		for implementing CSS responsibly,
		in a way that promotes interoperability in the present and future. </p>
  <h4 class="heading settled" id="conform-partial"><span class="content"> Partial Implementations</span><a class="self-link" href="#conform-partial"></a></h4>
  <p>So that authors can exploit the forward-compatible parsing rules to assign fallback values, <strong>CSS renderers <em>must</em> treat as invalid
		(and <a href="http://www.w3.org/TR/CSS2/conform.html#ignore">ignore as appropriate</a>)
		any at-rules, properties, property values, keywords, and other syntactic constructs
		for which they have no usable level of support</strong>.
		In particular, user agents <em>must not</em> selectively ignore
		unsupported property values and honor supported values in a single multi-value property declaration:
		if any value is considered invalid (as unsupported values must be),
		CSS requires that the entire declaration be ignored. </p>
  <h4 class="heading settled" id="conform-future-proofing"><span class="content"> Implementations of Unstable and Proprietary Features</span><a class="self-link" href="#conform-future-proofing"></a></h4>
  <p>To avoid clashes with future stable CSS features,
		the CSSWG recommends <a href="http://www.w3.org/TR/CSS/#future-proofing">following best practices</a> for the implementation of <a href="http://www.w3.org/TR/CSS/#unstable">unstable</a> features and <a href="http://www.w3.org/TR/CSS/#proprietary-extension">proprietary extensions</a> to CSS. </p>
  <h4 class="heading settled" id="conform-testing"><span class="content"> Implementations of CR-level Features</span><a class="self-link" href="#conform-testing"></a></h4>
  <p>Once a specification reaches the Candidate Recommendation stage,
		implementers should release an <a data-link-type="dfn" href="http://www.w3.org/TR/CSS/#vendor-prefix">unprefixed</a> implementation
		of any CR-level feature they can demonstrate
		to be correctly implemented according to spec,
		and should avoid exposing a prefixed variant of that feature. </p>
  <p>To establish and maintain the interoperability of CSS across
		implementations, the CSS Working Group requests that non-experimental
		CSS renderers submit an implementation report (and, if necessary, the
		testcases used for that implementation report) to the W3C before
		releasing an unprefixed implementation of any CSS features. Testcases
		submitted to W3C are subject to review and correction by the CSS
		Working Group. </p>
  <p>
   Further information on submitting testcases and implementation reports
		can be found from on the CSS Working Group’s website at <a href="http://www.w3.org/Style/CSS/Test/">http://www.w3.org/Style/CSS/Test/</a>.
		Questions should be directed to the <a href="http://lists.w3.org/Archives/Public/public-css-testsuite">public-css-testsuite@w3.org</a> mailing list. 
<script src="https://www.w3.org/scripts/TR/2016/fixup.js"></script>
  </p>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-animationevent-animationevent">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/AnimationEvent/AnimationEvent" title="The AnimationEvent() constructor returns a newly created AnimationEvent, representing an event in relation with an animation.">AnimationEvent/AnimationEvent</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>23+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>23+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-animationevent-animationname">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/AnimationEvent/animationName" title="The AnimationEvent.animationName read-only property is a DOMString containing the value of the animation-name CSS property associated with the transition.">AnimationEvent/animationName</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-animationevent-elapsedtime">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/AnimationEvent/elapsedTime" title="The AnimationEvent.elapsedTime read-only property is a float giving the amount of time the animation has been running, in seconds, when this event fired, excluding any time the animation was paused. For an animationstart event, elapsedTime is 0.0 unless there was a negative value for animation-delay, in which case the event will be fired with elapsedTime containing (-1 * delay).">AnimationEvent/elapsedTime</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>6+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-animationevent-pseudoelement">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/AnimationEvent/pseudoElement" title="The AnimationEvent.pseudoElement read-only property is a DOMString, starting with &apos;::&apos;, containing the name of the pseudo-element the animation runs on. If the animation doesn&apos;t run on a pseudo-element but on the element, an empty string: &apos;&apos;.">AnimationEvent/pseudoElement</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>23+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>68+</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>23+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>68+</span></span><span class="webview_android yes"><span>Android WebView</span><span>68+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="interface-animationevent">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/AnimationEvent" title="The AnimationEvent interface represents events providing information related to animations.">AnimationEvent</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>9.1+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>6+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9.3+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="interface-csskeyframerule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSKeyframeRule" title="The CSSKeyframeRule interface describes an object representing a set of style for a given keyframe. It corresponds to the contains of a single keyframe of a @keyframes at-rule. It implements the CSSRule interface with a type value of 8 (CSSRule.KEYFRAME_RULE).">CSSKeyframeRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>48+</span></span><span class="safari yes"><span>Safari</span><span>4+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>48+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="interface-csskeyframesrule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSKeyframesRule" title="The CSSKeyframesRule interface describes an object representing a complete set of keyframes for a CSS animation. It corresponds to the contents of a whole @keyframes at-rule. It implements the CSSRule interface with a type value of 7 (CSSRule.KEYFRAMES_RULE).">CSSKeyframesRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>48+</span></span><span class="safari yes"><span>Safari</span><span>4+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>48+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="interface-cssrule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSRule" title="The CSSRule interface represents a single CSS rule. There are several types of rules, listed in the Type constants section below.">CSSRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="eventdef-animationevent-animationcancel">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/animationcancel_event" title="The animationcancel event is fired when a CSS Animation unexpectedly aborts. In other words, any time it stops running without sending an animationend event. This might happen when the animation-name is changed such that the animation is removed, or when the animating node is hidden using CSS. Therefore, either directly or because any of its containing nodes are hidden.">Document/animationcancel_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>54+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>54+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onanimationcancel" title="The onanimationcancel property of the GlobalEventHandlers mixin is the EventHandler for processing animationcancel events.">GlobalEventHandlers/onanimationcancel</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>54+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>54+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/animationcancel_event" title="The animationcancel event is fired when a CSS Animation unexpectedly aborts. In other words, any time it stops running without sending an animationend event. This might happen when the animation-name is changed such that the animation is removed, or when the animating node is hidden using CSS. Therefore, either directly or because any of its containing nodes are hidden.">HTMLElement/animationcancel_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>54+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>54+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/animationcancel_event" title="The animationcancel event is fired when a CSS Animation unexpectedly aborts. In other words, any time it stops running without sending an animationend event. This might happen when the animation-name is changed such that the animation is removed, or when the animating node is hidden using CSS. Therefore, either directly or because any of its containing nodes are hidden.">Window/animationcancel_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>54+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>54+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="eventdef-animationevent-animationend">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/animationend_event" title="The animationend event is fired when a CSS Animation has completed. If the animation aborts before reaching completion, such as if the element is removed from the DOM or the animation is removed from the element, the animationend event is not fired.">Document/animationend_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onanimationend" title="The onanimationend property of the GlobalEventHandlers mixin is the EventHandler for processing animationend events.">GlobalEventHandlers/onanimationend</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/animationend_event" title="The animationend event is fired when a CSS Animation has completed. If the animation aborts before reaching completion, such as if the element is removed from the DOM or the animation is removed from the element, the animationend event is not fired.">HTMLElement/animationend_event</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/animationend_event" title="The animationend event is fired when a CSS Animation has completed. If the animation aborts before reaching completion, such as if the element is removed from the DOM or the animation is removed from the element, the animationend event is not fired.">Window/animationend_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="eventdef-animationevent-animationiteration">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/animationiteration_event" title="The animationiteration event is fired when an iteration of a CSS Animation ends, and another one begins. This event does not occur at the same time as the animationend event, and therefore does not occur for animations with an animation-iteration-count of one.">Document/animationiteration_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onanimationiteration" title="The onanimationiteration property of the GlobalEventHandlers mixin is the EventHandler for processing animationiteration events.">GlobalEventHandlers/onanimationiteration</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/animationiteration_event" title="The animationiteration event is fired when an iteration of a CSS Animation ends, and another one begins. This event does not occur at the same time as the animationend event, and therefore does not occur for animations with an animation-iteration-count of one.">HTMLElement/animationiteration_event</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/animationiteration_event" title="The animationiteration event is fired when an iteration of a CSS Animation ends, and another one begins. This event does not occur at the same time as the animationend event, and therefore does not occur for animations with an animation-iteration-count of one.">Window/animationiteration_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="eventdef-animationevent-animationstart">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/animationstart_event" title="The animationstart event is fired when a CSS Animation has started. If there is an animation-delay, this event will fire once the delay period has expired. A negative delay will cause the event to fire with an elapsedTime equal to the absolute value of the delay (and, correspondingly, the animation will begin playing at that time index into the sequence).">Document/animationstart_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onanimationstart" title="An event handler for the animationstart event. This event is sent when a CSS Animation starts to play.">GlobalEventHandlers/onanimationstart</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/animationstart_event" title="The animationstart event is fired when a CSS Animation has started. If there is an animation-delay, this event will fire once the delay period has expired. A negative delay will cause the event to fire with an elapsedTime equal to the absolute value of the delay (and, correspondingly, the animation will begin playing at that time index into the sequence).">HTMLElement/animationstart_event</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/animationstart_event" title="The animationstart event is fired when a CSS Animation has started. If there is an animation-delay, this event will fire once the delay period has expired. A negative delay will cause the event to fire with an elapsedTime equal to the absolute value of the delay (and, correspondingly, the animation will begin playing at that time index into the sequence).">Window/animationstart_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="keyframes">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@keyframes" title="The @keyframes CSS at-rule controls the intermediate steps in a CSS animation sequence by defining styles for keyframes (or waypoints) along the animation sequence.">@keyframes</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-delay">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-delay" title="The animation-delay CSS property sets when an animation starts. The animation can start later, immediately from its beginning, or immediately and partway through the animation.">animation-delay</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-direction">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction" title="The animation-direction CSS property sets whether an animation should play forwards, backwards, or alternating back and forth.">animation-direction</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-duration">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-duration" title="The animation-duration CSS property sets the length of time that an animation takes to complete one cycle.">animation-duration</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-fill-mode">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-fill-mode" title="The animation-fill-mode CSS property sets how a CSS animation applies styles to its target before and after its execution.">animation-fill-mode</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-iteration-count">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-iteration-count" title="The animation-iteration-count CSS property sets the number of times an animation cycle should be played before stopping.">animation-iteration-count</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-name">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-name" title="The animation-name CSS property sets one or more animations to apply to an element. Each name is an @keyframes at-rule that sets the property values for the animation sequence.">animation-name</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-play-state">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-play-state" title="The animation-play-state CSS property sets whether an animation is running or paused.">animation-play-state</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation-timing-function">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation-timing-function" title="The animation-timing-function CSS property sets how an animation progresses through the duration of each cycle.">animation-timing-function</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/easing-function" title="The <easing-function> CSS data type denotes a mathematical function that describes how fast one-dimensional values change during animations. This lets you vary the animation&apos;s speed over the course of its duration.">easing-function</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>10.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>2+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>11+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="animation">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/animation" title="The animation shorthand CSS property applies an animation between styles.">animation</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>30+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>30+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#active-duration">active duration</a><span>, in §3.5</span>
   <li><a href="#valdef-animation-direction-alternate">alternate</a><span>, in §3.6</span>
   <li><a href="#valdef-animation-direction-alternate-reverse">alternate-reverse</a><span>, in §3.6</span>
   <li><a href="#propdef-animation">animation</a><span>, in §3.10</span>
   <li><a href="#eventdef-animationevent-animationcancel">animationcancel</a><span>, in §4.2</span>
   <li><a href="#propdef-animation-delay">animation-delay</a><span>, in §3.8</span>
   <li><a href="#propdef-animation-direction">animation-direction</a><span>, in §3.6</span>
   <li><a href="#propdef-animation-duration">animation-duration</a><span>, in §3.3</span>
   <li><a href="#eventdef-animationevent-animationend">animationend</a><span>, in §4.2</span>
   <li><a href="#animationevent">AnimationEvent</a><span>, in §4.1.1</span>
   <li><a href="#funcdef-animationevent">AnimationEvent()</a><span>, in §4.1.2</span>
   <li><a href="#dictdef-animationeventinit">AnimationEventInit</a><span>, in §4.1.1</span>
   <li><a href="#dom-animationevent-animationevent">AnimationEvent(type)</a><span>, in §4.1.1</span>
   <li><a href="#dom-animationevent-animationevent">AnimationEvent(type, animationEventInitDict)</a><span>, in §4.1.1</span>
   <li><a href="#propdef-animation-fill-mode">animation-fill-mode</a><span>, in §3.9</span>
   <li><a href="#eventdef-animationevent-animationiteration">animationiteration</a><span>, in §4.2</span>
   <li><a href="#propdef-animation-iteration-count">animation-iteration-count</a><span>, in §3.5</span>
   <li><a href="#propdef-animation-name">animation-name</a><span>, in §3.2</span>
   <li>
    animationName
    <ul>
     <li><a href="#dom-animationevent-animationname">attribute for AnimationEvent</a><span>, in §4.1.2</span>
     <li><a href="#dom-animationeventinit-animationname">dict-member for AnimationEventInit</a><span>, in §4.1.1</span>
    </ul>
   <li><a href="#propdef-animation-play-state">animation-play-state</a><span>, in §3.7</span>
   <li><a href="#eventdef-animationevent-animationstart">animationstart</a><span>, in §4.2</span>
   <li><a href="#propdef-animation-timing-function">animation-timing-function</a><span>, in §3.4</span>
   <li><a href="#dom-csskeyframesrule-appendrule">appendRule(rule)</a><span>, in §5.3.3</span>
   <li><a href="#valdef-animation-fill-mode-backwards">backwards</a><span>, in §3.9</span>
   <li><a href="#valdef-animation-fill-mode-both">both</a><span>, in §3.9</span>
   <li><a href="#dom-animationevent-animationevent">constructor(type)</a><span>, in §4.1.1</span>
   <li><a href="#dom-animationevent-animationevent">constructor(type, animationEventInitDict)</a><span>, in §4.1.1</span>
   <li><a href="#csskeyframerule">CSSKeyframeRule</a><span>, in §5.2.1</span>
   <li><a href="#csskeyframesrule">CSSKeyframesRule</a><span>, in §5.3.1</span>
   <li><a href="#dom-csskeyframesrule-cssrules">cssRules</a><span>, in §5.3.2</span>
   <li><a href="#dom-csskeyframesrule-deleterule">deleteRule(select)</a><span>, in §5.3.4</span>
   <li>
    elapsedTime
    <ul>
     <li><a href="#dom-animationevent-elapsedtime">attribute for AnimationEvent</a><span>, in §4.1.2</span>
     <li><a href="#dom-animationeventinit-elapsedtime">dict-member for AnimationEventInit</a><span>, in §4.1.1</span>
    </ul>
   <li><a href="#dom-csskeyframesrule-findrule">findRule(select)</a><span>, in §5.3.5</span>
   <li><a href="#valdef-animation-fill-mode-forwards">forwards</a><span>, in §3.9</span>
   <li><a href="#valdef-animation-iteration-count-infinite">infinite</a><span>, in §3.5</span>
   <li><a href="#typedef-keyframe-block">&lt;keyframe-block></a><span>, in §3</span>
   <li><a href="#dom-cssrule-keyframe_rule">KEYFRAME_RULE</a><span>, in §5.1.1</span>
   <li><a href="#at-ruledef-keyframes">@keyframes</a><span>, in §3</span>
   <li><a href="#typedef-keyframe-selector">&lt;keyframe-selector></a><span>, in §3</span>
   <li>
    &lt;keyframes-name>
    <ul>
     <li><a href="#typedef-keyframes-name">(type)</a><span>, in §3</span>
     <li><a href="#valdef-animation-name-keyframes-name">value for animation-name</a><span>, in §3.2</span>
    </ul>
   <li><a href="#dom-cssrule-keyframes_rule">KEYFRAMES_RULE</a><span>, in §5.1.1</span>
   <li><a href="#dom-csskeyframerule-keytext">keyText</a><span>, in §5.2.2</span>
   <li><a href="#dom-csskeyframesrule-name">name</a><span>, in §5.3.2</span>
   <li>
    none
    <ul>
     <li><a href="#valdef-animation-fill-mode-none">value for animation-fill-mode</a><span>, in §3.9</span>
     <li><a href="#valdef-animation-name-none">value for animation-name</a><span>, in §3.2</span>
    </ul>
   <li><a href="#valdef-animation-direction-normal">normal</a><span>, in §3.6</span>
   <li><a href="#valdef-animation-iteration-count-number">&lt;number></a><span>, in §3.5</span>
   <li>
    onanimationcancel
    <ul>
     <li><a href="#dom-document-onanimationcancel">attribute for Document, Window</a><span>, in §4.3</span>
     <li><a href="#dom-globaleventhandlers-onanimationcancel">attribute for GlobalEventHandlers</a><span>, in §5.4.1</span>
    </ul>
   <li>
    onanimationend
    <ul>
     <li><a href="#dom-document-onanimationend">attribute for Document, Window</a><span>, in §4.3</span>
     <li><a href="#dom-globaleventhandlers-onanimationend">attribute for GlobalEventHandlers</a><span>, in §5.4.1</span>
    </ul>
   <li>
    onanimationiteration
    <ul>
     <li><a href="#dom-document-onanimationiteration">attribute for Document, Window</a><span>, in §4.3</span>
     <li><a href="#dom-globaleventhandlers-onanimationiteration">attribute for GlobalEventHandlers</a><span>, in §5.4.1</span>
    </ul>
   <li>
    onanimationstart
    <ul>
     <li><a href="#dom-document-onanimationstart">attribute for Document, Window</a><span>, in §4.3</span>
     <li><a href="#dom-globaleventhandlers-onanimationstart">attribute for GlobalEventHandlers</a><span>, in §5.4.1</span>
    </ul>
   <li><a href="#valdef-animation-play-state-paused">paused</a><span>, in §3.7</span>
   <li>
    pseudoElement
    <ul>
     <li><a href="#dom-animationevent-pseudoelement">attribute for AnimationEvent</a><span>, in §4.1.2</span>
     <li><a href="#dom-animationeventinit-pseudoelement">dict-member for AnimationEventInit</a><span>, in §4.1.1</span>
    </ul>
   <li><a href="#valdef-animation-direction-reverse">reverse</a><span>, in §3.6</span>
   <li><a href="#valdef-animation-play-state-running">running</a><span>, in §3.7</span>
   <li><a href="#typedef-single-animation">&lt;single-animation></a><span>, in §3.10</span>
   <li><a href="#typedef-single-animation-direction">&lt;single-animation-direction></a><span>, in §3.6</span>
   <li><a href="#typedef-single-animation-fill-mode">&lt;single-animation-fill-mode></a><span>, in §3.9</span>
   <li><a href="#typedef-single-animation-iteration-count">&lt;single-animation-iteration-count></a><span>, in §3.5</span>
   <li><a href="#typedef-single-animation-play-state">&lt;single-animation-play-state></a><span>, in §3.7</span>
   <li><a href="#dom-csskeyframerule-style">style</a><span>, in §5.2.2</span>
   <li>
    &lt;time>
    <ul>
     <li><a href="#valdef-animation-delay-time">value for animation-delay</a><span>, in §3.8</span>
     <li><a href="#valdef-animation-duration-time">value for animation-duration</a><span>, in §3.3</span>
    </ul>
  </ul>
  <aside class="dfn-panel" data-for="term-for-propdef-background-image">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-background-image">https://drafts.csswg.org/css-backgrounds-3/#propdef-background-image</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-background-image">3.2. 
The animation-name property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-none">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-none">https://drafts.csswg.org/css-display-3/#valdef-display-none</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-none">2. 
Animations</a> <a href="#ref-for-valdef-display-none①">(2)</a> <a href="#ref-for-valdef-display-none②">(3)</a> <a href="#ref-for-valdef-display-none③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-easing-function">
   <a href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function">https://drafts.csswg.org/css-easing-1/#typedef-easing-function</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-easing-function">3.4. 
The animation-timing-function property</a> <a href="#ref-for-typedef-easing-function①">(2)</a>
    <li><a href="#ref-for-typedef-easing-function②">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-cubic-bezier-easing-function-ease-in">
   <a href="https://drafts.csswg.org/css-easing-1/#valdef-cubic-bezier-easing-function-ease-in">https://drafts.csswg.org/css-easing-1/#valdef-cubic-bezier-easing-function-ease-in</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-cubic-bezier-easing-function-ease-in">3.6. 
The animation-direction property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-cubic-bezier-easing-function-ease-out">
   <a href="https://drafts.csswg.org/css-easing-1/#valdef-cubic-bezier-easing-function-ease-out">https://drafts.csswg.org/css-easing-1/#valdef-cubic-bezier-easing-function-ease-out</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-cubic-bezier-easing-function-ease-out">3.6. 
The animation-direction property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-input-progress-value">
   <a href="https://drafts.csswg.org/css-easing-1/#input-progress-value">https://drafts.csswg.org/css-easing-1/#input-progress-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-input-progress-value">3.4. 
The animation-timing-function property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-output-progress-value">
   <a href="https://drafts.csswg.org/css-easing-1/#output-progress-value">https://drafts.csswg.org/css-easing-1/#output-progress-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-output-progress-value">3.4. 
The animation-timing-function property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-steps-start">
   <a href="https://drafts.csswg.org/css-easing-1/#valdef-steps-start">https://drafts.csswg.org/css-easing-1/#valdef-steps-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-steps-start">3.4. 
The animation-timing-function property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-step-easing-function">
   <a href="https://drafts.csswg.org/css-easing-1/#step-easing-function">https://drafts.csswg.org/css-easing-1/#step-easing-function</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-step-easing-function">3.4. 
The animation-timing-function property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-step-position">
   <a href="https://drafts.csswg.org/css-easing-1/#step-position">https://drafts.csswg.org/css-easing-1/#step-position</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-step-position">3.4. 
The animation-timing-function property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-left">
   <a href="https://drafts.csswg.org/css-position-3/#propdef-left">https://drafts.csswg.org/css-position-3/#propdef-left</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-left">3. 
Keyframes</a> <a href="#ref-for-propdef-left①">(2)</a> <a href="#ref-for-propdef-left②">(3)</a> <a href="#ref-for-propdef-left③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-declaration-list">
   <a href="https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list">https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-declaration-list">3. 
Keyframes</a> <a href="#ref-for-typedef-declaration-list①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-rule-list">
   <a href="https://drafts.csswg.org/css-syntax-3/#typedef-rule-list">https://drafts.csswg.org/css-syntax-3/#typedef-rule-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-rule-list">3. 
Keyframes</a> <a href="#ref-for-typedef-rule-list①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-number-value">
   <a href="https://drafts.csswg.org/css-values-3/#number-value">https://drafts.csswg.org/css-values-3/#number-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-number-value">3.5. 
The animation-iteration-count property</a> <a href="#ref-for-number-value①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-percentage-value">
   <a href="https://drafts.csswg.org/css-values-3/#percentage-value">https://drafts.csswg.org/css-values-3/#percentage-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-percentage-value">3. 
Keyframes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string-value">
   <a href="https://drafts.csswg.org/css-values-3/#string-value">https://drafts.csswg.org/css-values-3/#string-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string-value">3. 
Keyframes</a> <a href="#ref-for-string-value①">(2)</a> <a href="#ref-for-string-value②">(3)</a> <a href="#ref-for-string-value③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-time-value">
   <a href="https://drafts.csswg.org/css-values-3/#time-value">https://drafts.csswg.org/css-values-3/#time-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-time-value">3.3. 
The animation-duration property</a> <a href="#ref-for-time-value①">(2)</a> <a href="#ref-for-time-value②">(3)</a> <a href="#ref-for-time-value③">(4)</a> <a href="#ref-for-time-value④">(5)</a>
    <li><a href="#ref-for-time-value⑤">3.8. 
The animation-delay property</a> <a href="#ref-for-time-value⑥">(2)</a> <a href="#ref-for-time-value⑦">(3)</a>
    <li><a href="#ref-for-time-value⑧">3.10. 
The animation shorthand property</a> <a href="#ref-for-time-value⑨">(2)</a> <a href="#ref-for-time-value①⓪">(3)</a> <a href="#ref-for-time-value①①">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-comma">
   <a href="https://drafts.csswg.org/css-values-4/#mult-comma">https://drafts.csswg.org/css-values-4/#mult-comma</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-comma">3.2. 
The animation-name property</a>
    <li><a href="#ref-for-mult-comma①">3.3. 
The animation-duration property</a>
    <li><a href="#ref-for-mult-comma②">3.4. 
The animation-timing-function property</a>
    <li><a href="#ref-for-mult-comma③">3.5. 
The animation-iteration-count property</a>
    <li><a href="#ref-for-mult-comma④">3.6. 
The animation-direction property</a>
    <li><a href="#ref-for-mult-comma⑤">3.7. 
The animation-play-state property</a>
    <li><a href="#ref-for-mult-comma⑥">3.8. 
The animation-delay property</a>
    <li><a href="#ref-for-mult-comma⑦">3.9. 
The animation-fill-mode property</a>
    <li><a href="#ref-for-mult-comma⑧">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-identifier-value">
   <a href="https://drafts.csswg.org/css-values-4/#identifier-value">https://drafts.csswg.org/css-values-4/#identifier-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-identifier-value">3. 
Keyframes</a> <a href="#ref-for-identifier-value①">(2)</a> <a href="#ref-for-identifier-value②">(3)</a> <a href="#ref-for-identifier-value③">(4)</a> <a href="#ref-for-identifier-value④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-identifier">
   <a href="https://drafts.csswg.org/css-values-4/#css-identifier">https://drafts.csswg.org/css-values-4/#css-identifier</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-identifier">3.2. 
The animation-name property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-wide-keywords">
   <a href="https://drafts.csswg.org/css-values-4/#css-wide-keywords">https://drafts.csswg.org/css-values-4/#css-wide-keywords</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-wide-keywords">1.1. 
Value Definitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-one">
   <a href="https://drafts.csswg.org/css-values-4/#comb-one">https://drafts.csswg.org/css-values-4/#comb-one</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-one">3.2. 
The animation-name property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-will-change">
   <a href="https://drafts.csswg.org/css-will-change-1/#propdef-will-change">https://drafts.csswg.org/css-will-change-1/#propdef-will-change</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-will-change">2. 
Animations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-display">
   <a href="https://drafts.csswg.org/css2/visuren.html#propdef-display">https://drafts.csswg.org/css2/visuren.html#propdef-display</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-display">2. 
Animations</a> <a href="#ref-for-propdef-display①">(2)</a> <a href="#ref-for-propdef-display②">(3)</a> <a href="#ref-for-propdef-display③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssomstring">
   <a href="https://drafts.csswg.org/cssom-1/#cssomstring">https://drafts.csswg.org/cssom-1/#cssomstring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">4.1.1. 
IDL Definition</a> <a href="#ref-for-cssomstring①">(2)</a> <a href="#ref-for-cssomstring②">(3)</a> <a href="#ref-for-cssomstring③">(4)</a> <a href="#ref-for-cssomstring④">(5)</a>
    <li><a href="#ref-for-cssomstring⑤">4.1.2. 
Attributes</a> <a href="#ref-for-cssomstring⑥">(2)</a>
    <li><a href="#ref-for-cssomstring⑦">5.2.1. 
IDL Definition</a>
    <li><a href="#ref-for-cssomstring⑧">5.2.2. 
Attributes</a>
    <li><a href="#ref-for-cssomstring⑨">5.3.1. 
IDL Definition</a> <a href="#ref-for-cssomstring①⓪">(2)</a> <a href="#ref-for-cssomstring①①">(3)</a> <a href="#ref-for-cssomstring①②">(4)</a>
    <li><a href="#ref-for-cssomstring①③">5.3.2. 
Attributes</a>
    <li><a href="#ref-for-cssomstring①④">5.3.3. 
The appendRule method</a>
    <li><a href="#ref-for-cssomstring①⑤">5.3.4. 
The deleteRule method</a>
    <li><a href="#ref-for-cssomstring①⑥">5.3.5. 
The findRule method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssrule">
   <a href="https://drafts.csswg.org/cssom-1/#cssrule">https://drafts.csswg.org/cssom-1/#cssrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrule">5.1. 
The CSSRule Interface</a>
    <li><a href="#ref-for-cssrule①">5.1.1. 
IDL Definition</a>
    <li><a href="#ref-for-cssrule②">5.2.1. 
IDL Definition</a>
    <li><a href="#ref-for-cssrule③">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssrulelist">
   <a href="https://drafts.csswg.org/cssom-1/#cssrulelist">https://drafts.csswg.org/cssom-1/#cssrulelist</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrulelist">5.3.1. 
IDL Definition</a>
    <li><a href="#ref-for-cssrulelist①">5.3.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssstyledeclaration">
   <a href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration">https://drafts.csswg.org/cssom-1/#cssstyledeclaration</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration">5.2.1. 
IDL Definition</a>
    <li><a href="#ref-for-cssstyledeclaration①">5.2.2. 
Attributes</a> <a href="#ref-for-cssstyledeclaration②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-cssstyledeclaration-csstext">
   <a href="https://drafts.csswg.org/cssom-1/#dom-cssstyledeclaration-csstext">https://drafts.csswg.org/cssom-1/#dom-cssstyledeclaration-csstext</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-csstext">5.2.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssstyledeclaration-declarations">
   <a href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration-declarations">https://drafts.csswg.org/cssom-1/#cssstyledeclaration-declarations</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-declarations">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssstyledeclaration-owner-node">
   <a href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration-owner-node">https://drafts.csswg.org/cssom-1/#cssstyledeclaration-owner-node</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-owner-node">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssstyledeclaration-parent-css-rule">
   <a href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration-parent-css-rule">https://drafts.csswg.org/cssom-1/#cssstyledeclaration-parent-css-rule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssstyledeclaration-readonly-flag">
   <a href="https://www.w3.org/TR/cssom-1/#cssstyledeclaration-readonly-flag">https://www.w3.org/TR/cssom-1/#cssstyledeclaration-readonly-flag</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-readonly-flag">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-declarations-specified-order">
   <a href="https://drafts.csswg.org/cssom-1/#concept-declarations-specified-order">https://drafts.csswg.org/cssom-1/#concept-declarations-specified-order</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-declarations-specified-order">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-document">
   <a href="https://dom.spec.whatwg.org/#document">https://dom.spec.whatwg.org/#document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-document">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event">
   <a href="https://dom.spec.whatwg.org/#event">https://dom.spec.whatwg.org/#event</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event">4.1.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-eventinit">
   <a href="https://dom.spec.whatwg.org/#dictdef-eventinit">https://dom.spec.whatwg.org/#dictdef-eventinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-eventinit">4.1.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-context-object">
   <a href="https://dom.spec.whatwg.org/#context-object">https://dom.spec.whatwg.org/#context-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-context-object">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventhandler">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler">https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventhandler">5.4.1. 
IDL Definition</a> <a href="#ref-for-eventhandler①">(2)</a> <a href="#ref-for-eventhandler②">(3)</a> <a href="#ref-for-eventhandler③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-globaleventhandlers">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers">https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-globaleventhandlers">5.4. 
Extensions to the GlobalEventHandlers Interface Mixin</a>
    <li><a href="#ref-for-globaleventhandlers①">5.4.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#window">https://html.spec.whatwg.org/multipage/window-object.html#window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-window">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-case-sensitive">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive">https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-case-sensitive">3. 
Keyframes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-content-attributes">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-content-attributes">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-event-type">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-event-type">4.3. Event
handlers on elements, Document objects, and Window
objects</a> <a href="#ref-for-event-handler-event-type①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-idl-attributes">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-idl-attributes">4.3. Event
handlers on elements, Document objects, and Window
objects</a> <a href="#ref-for-event-handler-idl-attributes①">(2)</a>
    <li><a href="#ref-for-event-handler-idl-attributes②">5.4. 
Extensions to the GlobalEventHandlers Interface Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handlers">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers">https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handlers">4.3. Event
handlers on elements, Document objects, and Window
objects</a> <a href="#ref-for-event-handlers①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-html-elements">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements">https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-html-elements">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">4.1.1. 
IDL Definition</a>
    <li><a href="#ref-for-Exposed①">5.2.1. 
IDL Definition</a>
    <li><a href="#ref-for-Exposed②">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-PutForwards">
   <a href="https://heycam.github.io/webidl/#PutForwards">https://heycam.github.io/webidl/#PutForwards</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-PutForwards">5.2.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">5.2.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-syntaxerror">
   <a href="https://heycam.github.io/webidl/#syntaxerror">https://heycam.github.io/webidl/#syntaxerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-syntaxerror">5.2.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-double">
   <a href="https://heycam.github.io/webidl/#idl-double">https://heycam.github.io/webidl/#idl-double</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-double">4.1.1. 
IDL Definition</a> <a href="#ref-for-idl-double①">(2)</a>
    <li><a href="#ref-for-idl-double②">4.1.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-short">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-short">https://heycam.github.io/webidl/#idl-unsigned-short</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-short">5.1.1. 
IDL Definition</a> <a href="#ref-for-idl-unsigned-short①">(2)</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-backgrounds-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-background-image" style="color:initial">background-image</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-display-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valdef-display-none" style="color:initial">none</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-easing-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-easing-function" style="color:initial">&lt;easing-function></span>
     <li><span class="dfn-paneled" id="term-for-valdef-cubic-bezier-easing-function-ease-in" style="color:initial">ease-in</span>
     <li><span class="dfn-paneled" id="term-for-valdef-cubic-bezier-easing-function-ease-out" style="color:initial">ease-out</span>
     <li><span class="dfn-paneled" id="term-for-input-progress-value" style="color:initial">input progress value</span>
     <li><span class="dfn-paneled" id="term-for-output-progress-value" style="color:initial">output progress value</span>
     <li><span class="dfn-paneled" id="term-for-valdef-steps-start" style="color:initial">start</span>
     <li><span class="dfn-paneled" id="term-for-step-easing-function" style="color:initial">step easing function</span>
     <li><span class="dfn-paneled" id="term-for-step-position" style="color:initial">step position</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-position-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-left" style="color:initial">left</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-syntax-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-declaration-list" style="color:initial">&lt;declaration-list></span>
     <li><span class="dfn-paneled" id="term-for-typedef-rule-list" style="color:initial">&lt;rule-list></span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS-VALUES-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-number-value" style="color:initial">&lt;number></span>
     <li><span class="dfn-paneled" id="term-for-percentage-value" style="color:initial">&lt;percentage></span>
     <li><span class="dfn-paneled" id="term-for-string-value" style="color:initial">&lt;string></span>
     <li><span class="dfn-paneled" id="term-for-time-value" style="color:initial">&lt;time></span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mult-comma" style="color:initial">#</span>
     <li><span class="dfn-paneled" id="term-for-identifier-value" style="color:initial">&lt;custom-ident></span>
     <li><span class="dfn-paneled" id="term-for-css-identifier" style="color:initial">css identifier</span>
     <li><span class="dfn-paneled" id="term-for-css-wide-keywords" style="color:initial">css-wide keywords</span>
     <li><span class="dfn-paneled" id="term-for-comb-one" style="color:initial">|</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-will-change-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-will-change" style="color:initial">will-change</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS2]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-display" style="color:initial">display</span>
    </ul>
   <li>
    <a data-link-type="biblio">[cssom-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssomstring" style="color:initial">CSSOMString</span>
     <li><span class="dfn-paneled" id="term-for-cssrule" style="color:initial">CSSRule</span>
     <li><span class="dfn-paneled" id="term-for-cssrulelist" style="color:initial">CSSRuleList</span>
     <li><span class="dfn-paneled" id="term-for-cssstyledeclaration" style="color:initial">CSSStyleDeclaration</span>
     <li><span class="dfn-paneled" id="term-for-dom-cssstyledeclaration-csstext" style="color:initial">cssText</span>
     <li><span class="dfn-paneled" id="term-for-cssstyledeclaration-declarations" style="color:initial">declarations</span>
     <li><span class="dfn-paneled" id="term-for-cssstyledeclaration-owner-node" style="color:initial">owner node</span>
     <li><span class="dfn-paneled" id="term-for-cssstyledeclaration-parent-css-rule" style="color:initial">parent css rule</span>
     <li><span class="dfn-paneled" id="term-for-cssstyledeclaration-readonly-flag" style="color:initial">readonly flag</span>
     <li><span class="dfn-paneled" id="term-for-concept-declarations-specified-order" style="color:initial">specified order</span>
    </ul>
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-document" style="color:initial">Document</span>
     <li><span class="dfn-paneled" id="term-for-event" style="color:initial">Event</span>
     <li><span class="dfn-paneled" id="term-for-dictdef-eventinit" style="color:initial">EventInit</span>
     <li><span class="dfn-paneled" id="term-for-context-object" style="color:initial">context object</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-eventhandler" style="color:initial">EventHandler</span>
     <li><span class="dfn-paneled" id="term-for-globaleventhandlers" style="color:initial">GlobalEventHandlers</span>
     <li><span class="dfn-paneled" id="term-for-window" style="color:initial">Window</span>
     <li><span class="dfn-paneled" id="term-for-case-sensitive" style="color:initial">case-sensitive</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-content-attributes" style="color:initial">event handler content attributes</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-event-type" style="color:initial">event handler event type</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-idl-attributes" style="color:initial">event handler idl attributes</span>
     <li><span class="dfn-paneled" id="term-for-event-handlers" style="color:initial">event handlers</span>
     <li><span class="dfn-paneled" id="term-for-html-elements" style="color:initial">html elements</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-PutForwards" style="color:initial">PutForwards</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-syntaxerror" style="color:initial">SyntaxError</span>
     <li><span class="dfn-paneled" id="term-for-idl-double" style="color:initial">double</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-short" style="color:initial">unsigned short</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-display-3">[CSS-DISPLAY-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-display-3/">CSS Display Module Level 3</a>. 11 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-display-3/">https://www.w3.org/TR/css-display-3/</a>
   <dt id="biblio-css-easing-1">[CSS-EASING-1]
   <dd>Brian Birtles; Dean Jackson; Matt Rakow. <a href="https://www.w3.org/TR/css-easing-1/">CSS Easing Functions Level 1</a>. 30 April 2019. CR. URL: <a href="https://www.w3.org/TR/css-easing-1/">https://www.w3.org/TR/css-easing-1/</a>
   <dt id="biblio-css-syntax-3">[CSS-SYNTAX-3]
   <dd>Tab Atkins Jr.; Simon Sapin. <a href="https://www.w3.org/TR/css-syntax-3/">CSS Syntax Module Level 3</a>. 16 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-syntax-3/">https://www.w3.org/TR/css-syntax-3/</a>
   <dt id="biblio-css-values-3">[CSS-VALUES-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-3/">CSS Values and Units Module Level 3</a>. 6 June 2019. CR. URL: <a href="https://www.w3.org/TR/css-values-3/">https://www.w3.org/TR/css-values-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css-will-change-1">[CSS-WILL-CHANGE-1]
   <dd>Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-will-change-1/">CSS Will Change Module Level 1</a>. 3 December 2015. CR. URL: <a href="https://www.w3.org/TR/css-will-change-1/">https://www.w3.org/TR/css-will-change-1/</a>
   <dt id="biblio-css2">[CSS2]
   <dd>Bert Bos; et al. <a href="https://www.w3.org/TR/CSS2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. 7 June 2011. REC. URL: <a href="https://www.w3.org/TR/CSS2/">https://www.w3.org/TR/CSS2/</a>
   <dt id="biblio-css3cascade">[CSS3CASCADE]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-3/">CSS Cascading and Inheritance Level 3</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-3/">https://www.w3.org/TR/css-cascade-3/</a>
   <dt id="biblio-cssom-1">[CSSOM-1]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-wcag20">[WCAG20]
   <dd>Ben Caldwell; et al. <a href="https://www.w3.org/TR/WCAG20/">Web Content Accessibility Guidelines (WCAG) 2.0</a>. 11 December 2008. REC. URL: <a href="https://www.w3.org/TR/WCAG20/">https://www.w3.org/TR/WCAG20/</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-css-backgrounds-3">[CSS-BACKGROUNDS-3]
   <dd>Bert Bos; Elika Etemad; Brad Kemper. <a href="https://www.w3.org/TR/css-backgrounds-3/">CSS Backgrounds and Borders Module Level 3</a>. 17 October 2017. CR. URL: <a href="https://www.w3.org/TR/css-backgrounds-3/">https://www.w3.org/TR/css-backgrounds-3/</a>
   <dt id="biblio-css-position-3">[CSS-POSITION-3]
   <dd>Rossen Atanassov; Arron Eicholz. <a href="https://www.w3.org/TR/css-position-3/">CSS Positioned Layout Module Level 3</a>. 17 May 2016. WD. URL: <a href="https://www.w3.org/TR/css-position-3/">https://www.w3.org/TR/css-position-3/</a>
   <dt id="biblio-css3-transitions">[CSS3-TRANSITIONS]
   <dd>David Baron; et al. <a href="https://www.w3.org/TR/css-transitions-1/">CSS Transitions</a>. 11 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-transitions-1/">https://www.w3.org/TR/css-transitions-1/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="property-index"><span class="content">Property Index</span><a class="self-link" href="#property-index"></a></h2>
  <div class="big-element-wrapper">
   <table class="index">
    <thead>
     <tr>
      <th scope="col">Name
      <th scope="col">Value
      <th scope="col">Initial
      <th scope="col">Applies to
      <th scope="col">Inh.
      <th scope="col">%ages
      <th scope="col">Anim­ation type
      <th scope="col">Canonical order
      <th scope="col">Com­puted value
    <tbody>
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation" id="ref-for-propdef-animation⑤">animation</a>
      <td>&lt;single-animation>#
      <td>see individual properties
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>see individual properties
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-delay" id="ref-for-propdef-animation-delay①⑥">animation-delay</a>
      <td>&lt;time>#
      <td>0s
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item a duration
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-direction" id="ref-for-propdef-animation-direction⑧">animation-direction</a>
      <td>&lt;single-animation-direction>#
      <td>normal
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item a keyword as specified
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-duration" id="ref-for-propdef-animation-duration⑥">animation-duration</a>
      <td>&lt;time>#
      <td>0s
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item a duration
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-fill-mode" id="ref-for-propdef-animation-fill-mode①①">animation-fill-mode</a>
      <td>&lt;single-animation-fill-mode>#
      <td>none
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item a keyword as specified
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-iteration-count" id="ref-for-propdef-animation-iteration-count⑦">animation-iteration-count</a>
      <td>&lt;single-animation-iteration-count>#
      <td>1
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item either a number or the keyword infinite
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-name" id="ref-for-propdef-animation-name②⑧">animation-name</a>
      <td>[ none | &lt;keyframes-name> ]#
      <td>none
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item either a case-sensitive css identifier or the keyword none
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-play-state" id="ref-for-propdef-animation-play-state④">animation-play-state</a>
      <td>&lt;single-animation-play-state>#
      <td>running
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item a keyword as specified
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-animation-timing-function" id="ref-for-propdef-animation-timing-function⑦">animation-timing-function</a>
      <td>&lt;easing-function>#
      <td>ease
      <td>all elements
      <td>no
      <td>N/A
      <td>not animatable
      <td>per grammar
      <td>list, each item a computed &lt;easing-function>
   </table>
  </div>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#animationevent"><code><c- g>AnimationEvent</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event"><c- n>Event</c-></a> {
  <a href="#dom-animationevent-animationevent"><code><c- g>constructor</c-></code></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-animationevent-animationevent-type-animationeventinitdict-type"><code><c- g>type</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-animationeventinit"><c- n>AnimationEventInit</c-></a> <a href="#dom-animationevent-animationevent-type-animationeventinitdict-animationeventinitdict"><code><c- g>animationEventInitDict</c-></code></a> = {});
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-animationevent-animationname"><c- g>animationName</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-animationevent-elapsedtime"><c- g>elapsedTime</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-animationevent-pseudoelement"><c- g>pseudoElement</c-></a>;
};
<c- b>dictionary</c-> <a href="#dictdef-animationeventinit"><code><c- g>AnimationEventInit</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit"><c- n>EventInit</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;&quot;" data-type="CSSOMString " href="#dom-animationeventinit-animationname"><code><c- g>animationName</c-></code></a> = "";
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a data-default="0.0" data-type="double " href="#dom-animationeventinit-elapsedtime"><code><c- g>elapsedTime</c-></code></a> = 0.0;
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;&quot;" data-type="CSSOMString " href="#dom-animationeventinit-pseudoelement"><code><c- g>pseudoElement</c-></code></a> = "";
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-keyframes_rule"><code><c- g>KEYFRAMES_RULE</c-></code></a> = 7;
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-keyframe_rule"><code><c- g>KEYFRAME_RULE</c-></code></a> = 8;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#csskeyframerule"><code><c- g>CSSKeyframeRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- n>CSSRule</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csskeyframerule-keytext"><c- g>keyText</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="https://drafts.csswg.org/cssom-1/#dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-csskeyframerule-style"><c- g>style</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#csskeyframesrule"><code><c- g>CSSKeyframesRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- n>CSSRule</c-></a> {
           <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csskeyframesrule-name"><c- g>name</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrulelist"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-csskeyframesrule-cssrules"><c- g>cssRules</c-></a>;

  <c- b>void</c->             <a class="idl-code" data-link-type="method" href="#dom-csskeyframesrule-appendrule"><c- g>appendRule</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-csskeyframesrule-appendrule-rule-rule"><c- g>rule</c-></a>);
  <c- b>void</c->             <a class="idl-code" data-link-type="method" href="#dom-csskeyframesrule-deleterule"><c- g>deleteRule</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-csskeyframesrule-deleterule-select-select"><c- g>select</c-></a>);
  <a class="n" data-link-type="idl-name" href="#csskeyframerule"><c- n>CSSKeyframeRule</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-csskeyframesrule-findrule"><c- g>findRule</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-csskeyframesrule-findrule-select-select"><c- g>select</c-></a>);
};

<c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers"><c- g>GlobalEventHandlers</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-onanimationstart"><code><c- g>onanimationstart</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-onanimationiteration"><code><c- g>onanimationiteration</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-onanimationend"><code><c- g>onanimationend</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-onanimationcancel"><code><c- g>onanimationcancel</c-></code></a>;
};

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue"> This specification needs to define
		how the value is determined from the keyframes,
		like the section on <a href="https://drafts.csswg.org/css-transitions/#application">Application of transitions</a> does for CSS Transitions. <a href="#issue-73aacf21"> ↵ </a></div>
   <div class="issue">Need to <a href="https://lists.w3.org/Archives/Public/www-style/2015Jul/0391.html">specify how keyframes interact</a>.<a href="#issue-c01277bc"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="at-ruledef-keyframes">
   <b><a href="#at-ruledef-keyframes">#at-ruledef-keyframes</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-keyframes">3. 
Keyframes</a> <a href="#ref-for-at-ruledef-keyframes①">(2)</a> <a href="#ref-for-at-ruledef-keyframes②">(3)</a> <a href="#ref-for-at-ruledef-keyframes③">(4)</a> <a href="#ref-for-at-ruledef-keyframes④">(5)</a> <a href="#ref-for-at-ruledef-keyframes⑤">(6)</a> <a href="#ref-for-at-ruledef-keyframes⑥">(7)</a> <a href="#ref-for-at-ruledef-keyframes⑦">(8)</a>
    <li><a href="#ref-for-at-ruledef-keyframes⑧">3.2. 
The animation-name property</a>
    <li><a href="#ref-for-at-ruledef-keyframes⑨">5.3.3. 
The appendRule method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-keyframes-name">
   <b><a href="#typedef-keyframes-name">#typedef-keyframes-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-keyframes-name">3. 
Keyframes</a>
    <li><a href="#ref-for-typedef-keyframes-name①">3.2. 
The animation-name property</a> <a href="#ref-for-typedef-keyframes-name②">(2)</a> <a href="#ref-for-typedef-keyframes-name③">(3)</a>
    <li><a href="#ref-for-typedef-keyframes-name④">3.10. 
The animation shorthand property</a> <a href="#ref-for-typedef-keyframes-name⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-keyframe-block">
   <b><a href="#typedef-keyframe-block">#typedef-keyframe-block</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-keyframe-block">3. 
Keyframes</a> <a href="#ref-for-typedef-keyframe-block①">(2)</a> <a href="#ref-for-typedef-keyframe-block②">(3)</a> <a href="#ref-for-typedef-keyframe-block③">(4)</a> <a href="#ref-for-typedef-keyframe-block④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-keyframe-selector">
   <b><a href="#typedef-keyframe-selector">#typedef-keyframe-selector</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-keyframe-selector">3. 
Keyframes</a> <a href="#ref-for-typedef-keyframe-selector①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-name">
   <b><a href="#propdef-animation-name">#propdef-animation-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-name">2. 
Animations</a> <a href="#ref-for-propdef-animation-name①">(2)</a> <a href="#ref-for-propdef-animation-name②">(3)</a> <a href="#ref-for-propdef-animation-name③">(4)</a> <a href="#ref-for-propdef-animation-name④">(5)</a> <a href="#ref-for-propdef-animation-name⑤">(6)</a> <a href="#ref-for-propdef-animation-name⑥">(7)</a> <a href="#ref-for-propdef-animation-name⑦">(8)</a>
    <li><a href="#ref-for-propdef-animation-name⑧">3.2. 
The animation-name property</a> <a href="#ref-for-propdef-animation-name⑨">(2)</a> <a href="#ref-for-propdef-animation-name①⓪">(3)</a> <a href="#ref-for-propdef-animation-name①①">(4)</a> <a href="#ref-for-propdef-animation-name①②">(5)</a> <a href="#ref-for-propdef-animation-name①③">(6)</a>
    <li><a href="#ref-for-propdef-animation-name①④">3.9. 
The animation-fill-mode property</a>
    <li><a href="#ref-for-propdef-animation-name①⑤">3.10. 
The animation shorthand property</a> <a href="#ref-for-propdef-animation-name①⑥">(2)</a> <a href="#ref-for-propdef-animation-name①⑦">(3)</a> <a href="#ref-for-propdef-animation-name①⑧">(4)</a> <a href="#ref-for-propdef-animation-name①⑨">(5)</a> <a href="#ref-for-propdef-animation-name②⓪">(6)</a>
    <li><a href="#ref-for-propdef-animation-name②①">4. 
Animation Events</a> <a href="#ref-for-propdef-animation-name②②">(2)</a> <a href="#ref-for-propdef-animation-name②③">(3)</a> <a href="#ref-for-propdef-animation-name②④">(4)</a>
    <li><a href="#ref-for-propdef-animation-name②⑤">4.1.2. 
Attributes</a>
    <li><a href="#ref-for-propdef-animation-name②⑥">4.2. 
Types of AnimationEvent</a>
    <li><a href="#ref-for-propdef-animation-name②⑦">5.3.2. 
Attributes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-name-none">
   <b><a href="#valdef-animation-name-none">#valdef-animation-name-none</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-name-none">3. 
Keyframes</a>
    <li><a href="#ref-for-valdef-animation-name-none①">3.2. 
The animation-name property</a>
    <li><a href="#ref-for-valdef-animation-name-none②">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-duration">
   <b><a href="#propdef-animation-duration">#propdef-animation-duration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-duration">3.3. 
The animation-duration property</a> <a href="#ref-for-propdef-animation-duration①">(2)</a>
    <li><a href="#ref-for-propdef-animation-duration②">3.5. 
The animation-iteration-count property</a>
    <li><a href="#ref-for-propdef-animation-duration③">3.9. 
The animation-fill-mode property</a>
    <li><a href="#ref-for-propdef-animation-duration④">3.10. 
The animation shorthand property</a>
    <li><a href="#ref-for-propdef-animation-duration⑤">4.2. 
Types of AnimationEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-timing-function">
   <b><a href="#propdef-animation-timing-function">#propdef-animation-timing-function</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-timing-function">3. 
Keyframes</a> <a href="#ref-for-propdef-animation-timing-function①">(2)</a>
    <li><a href="#ref-for-propdef-animation-timing-function②">3.1. 
Timing functions for keyframes</a>
    <li><a href="#ref-for-propdef-animation-timing-function③">3.4. 
The animation-timing-function property</a> <a href="#ref-for-propdef-animation-timing-function④">(2)</a> <a href="#ref-for-propdef-animation-timing-function⑤">(3)</a> <a href="#ref-for-propdef-animation-timing-function⑥">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="active-duration">
   <b><a href="#active-duration">#active-duration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-active-duration">4.2. 
Types of AnimationEvent</a> <a href="#ref-for-active-duration①">(2)</a> <a href="#ref-for-active-duration②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-iteration-count">
   <b><a href="#propdef-animation-iteration-count">#propdef-animation-iteration-count</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-iteration-count">3.5. 
The animation-iteration-count property</a> <a href="#ref-for-propdef-animation-iteration-count①">(2)</a> <a href="#ref-for-propdef-animation-iteration-count②">(3)</a>
    <li><a href="#ref-for-propdef-animation-iteration-count③">3.9. 
The animation-fill-mode property</a> <a href="#ref-for-propdef-animation-iteration-count④">(2)</a> <a href="#ref-for-propdef-animation-iteration-count⑤">(3)</a> <a href="#ref-for-propdef-animation-iteration-count⑥">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-single-animation-iteration-count">
   <b><a href="#typedef-single-animation-iteration-count">#typedef-single-animation-iteration-count</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-single-animation-iteration-count">3.5. 
The animation-iteration-count property</a>
    <li><a href="#ref-for-typedef-single-animation-iteration-count①">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-iteration-count-infinite">
   <b><a href="#valdef-animation-iteration-count-infinite">#valdef-animation-iteration-count-infinite</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-iteration-count-infinite">3.5. 
The animation-iteration-count property</a> <a href="#ref-for-valdef-animation-iteration-count-infinite①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-direction">
   <b><a href="#propdef-animation-direction">#propdef-animation-direction</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-direction">3.3. 
The animation-duration property</a> <a href="#ref-for-propdef-animation-direction①">(2)</a>
    <li><a href="#ref-for-propdef-animation-direction②">3.4. 
The animation-timing-function property</a>
    <li><a href="#ref-for-propdef-animation-direction③">3.5. 
The animation-iteration-count property</a>
    <li><a href="#ref-for-propdef-animation-direction④">3.6. 
The animation-direction property</a> <a href="#ref-for-propdef-animation-direction⑤">(2)</a>
    <li><a href="#ref-for-propdef-animation-direction⑥">3.9. 
The animation-fill-mode property</a> <a href="#ref-for-propdef-animation-direction⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-single-animation-direction">
   <b><a href="#typedef-single-animation-direction">#typedef-single-animation-direction</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-single-animation-direction">3.6. 
The animation-direction property</a>
    <li><a href="#ref-for-typedef-single-animation-direction①">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-direction-normal">
   <b><a href="#valdef-animation-direction-normal">#valdef-animation-direction-normal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-direction-normal">3.9. 
The animation-fill-mode property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-direction-reverse">
   <b><a href="#valdef-animation-direction-reverse">#valdef-animation-direction-reverse</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-direction-reverse">3.9. 
The animation-fill-mode property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-direction-alternate">
   <b><a href="#valdef-animation-direction-alternate">#valdef-animation-direction-alternate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-direction-alternate">3.5. 
The animation-iteration-count property</a>
    <li><a href="#ref-for-valdef-animation-direction-alternate①">3.9. 
The animation-fill-mode property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-direction-alternate-reverse">
   <b><a href="#valdef-animation-direction-alternate-reverse">#valdef-animation-direction-alternate-reverse</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-direction-alternate-reverse">3.9. 
The animation-fill-mode property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-play-state">
   <b><a href="#propdef-animation-play-state">#propdef-animation-play-state</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-play-state">3.7. 
The animation-play-state property</a> <a href="#ref-for-propdef-animation-play-state①">(2)</a> <a href="#ref-for-propdef-animation-play-state②">(3)</a>
    <li><a href="#ref-for-propdef-animation-play-state③">4.2. 
Types of AnimationEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-single-animation-play-state">
   <b><a href="#typedef-single-animation-play-state">#typedef-single-animation-play-state</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-single-animation-play-state">3.7. 
The animation-play-state property</a>
    <li><a href="#ref-for-typedef-single-animation-play-state①">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-play-state-running">
   <b><a href="#valdef-animation-play-state-running">#valdef-animation-play-state-running</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-play-state-running">3.7. 
The animation-play-state property</a> <a href="#ref-for-valdef-animation-play-state-running①">(2)</a> <a href="#ref-for-valdef-animation-play-state-running②">(3)</a>
    <li><a href="#ref-for-valdef-animation-play-state-running③">4.2. 
Types of AnimationEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-play-state-paused">
   <b><a href="#valdef-animation-play-state-paused">#valdef-animation-play-state-paused</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-play-state-paused">3.7. 
The animation-play-state property</a> <a href="#ref-for-valdef-animation-play-state-paused①">(2)</a>
    <li><a href="#ref-for-valdef-animation-play-state-paused②">4. 
Animation Events</a>
    <li><a href="#ref-for-valdef-animation-play-state-paused③">4.2. 
Types of AnimationEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-delay">
   <b><a href="#propdef-animation-delay">#propdef-animation-delay</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-delay">2. 
Animations</a> <a href="#ref-for-propdef-animation-delay①">(2)</a>
    <li><a href="#ref-for-propdef-animation-delay②">3.3. 
The animation-duration property</a> <a href="#ref-for-propdef-animation-delay③">(2)</a>
    <li><a href="#ref-for-propdef-animation-delay④">3.4. 
The animation-timing-function property</a>
    <li><a href="#ref-for-propdef-animation-delay⑤">3.8. 
The animation-delay property</a> <a href="#ref-for-propdef-animation-delay⑥">(2)</a>
    <li><a href="#ref-for-propdef-animation-delay⑦">3.9. 
The animation-fill-mode property</a> <a href="#ref-for-propdef-animation-delay⑧">(2)</a>
    <li><a href="#ref-for-propdef-animation-delay⑨">3.10. 
The animation shorthand property</a>
    <li><a href="#ref-for-propdef-animation-delay①⓪">4.2. 
Types of AnimationEvent</a> <a href="#ref-for-propdef-animation-delay①①">(2)</a> <a href="#ref-for-propdef-animation-delay①②">(3)</a> <a href="#ref-for-propdef-animation-delay①③">(4)</a> <a href="#ref-for-propdef-animation-delay①④">(5)</a> <a href="#ref-for-propdef-animation-delay①⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation-fill-mode">
   <b><a href="#propdef-animation-fill-mode">#propdef-animation-fill-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation-fill-mode">2. 
Animations</a> <a href="#ref-for-propdef-animation-fill-mode①">(2)</a>
    <li><a href="#ref-for-propdef-animation-fill-mode②">3.3. 
The animation-duration property</a> <a href="#ref-for-propdef-animation-fill-mode③">(2)</a> <a href="#ref-for-propdef-animation-fill-mode④">(3)</a>
    <li><a href="#ref-for-propdef-animation-fill-mode⑤">3.9. 
The animation-fill-mode property</a> <a href="#ref-for-propdef-animation-fill-mode⑥">(2)</a> <a href="#ref-for-propdef-animation-fill-mode⑦">(3)</a> <a href="#ref-for-propdef-animation-fill-mode⑧">(4)</a>
    <li><a href="#ref-for-propdef-animation-fill-mode⑨">3.10. 
The animation shorthand property</a> <a href="#ref-for-propdef-animation-fill-mode①⓪">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-single-animation-fill-mode">
   <b><a href="#typedef-single-animation-fill-mode">#typedef-single-animation-fill-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-single-animation-fill-mode">3.9. 
The animation-fill-mode property</a>
    <li><a href="#ref-for-typedef-single-animation-fill-mode①">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-fill-mode-none">
   <b><a href="#valdef-animation-fill-mode-none">#valdef-animation-fill-mode-none</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-fill-mode-none">3.3. 
The animation-duration property</a>
    <li><a href="#ref-for-valdef-animation-fill-mode-none①">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-fill-mode-forwards">
   <b><a href="#valdef-animation-fill-mode-forwards">#valdef-animation-fill-mode-forwards</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-fill-mode-forwards">2. 
Animations</a>
    <li><a href="#ref-for-valdef-animation-fill-mode-forwards①">3.3. 
The animation-duration property</a>
    <li><a href="#ref-for-valdef-animation-fill-mode-forwards②">3.9. 
The animation-fill-mode property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-fill-mode-backwards">
   <b><a href="#valdef-animation-fill-mode-backwards">#valdef-animation-fill-mode-backwards</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-fill-mode-backwards">3.3. 
The animation-duration property</a>
    <li><a href="#ref-for-valdef-animation-fill-mode-backwards①">3.9. 
The animation-fill-mode property</a> <a href="#ref-for-valdef-animation-fill-mode-backwards②">(2)</a>
    <li><a href="#ref-for-valdef-animation-fill-mode-backwards③">3.10. 
The animation shorthand property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-animation-fill-mode-both">
   <b><a href="#valdef-animation-fill-mode-both">#valdef-animation-fill-mode-both</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-animation-fill-mode-both">2. 
Animations</a>
    <li><a href="#ref-for-valdef-animation-fill-mode-both①">3.3. 
The animation-duration property</a> <a href="#ref-for-valdef-animation-fill-mode-both②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-animation">
   <b><a href="#propdef-animation">#propdef-animation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-animation">3.10. 
The animation shorthand property</a> <a href="#ref-for-propdef-animation①">(2)</a> <a href="#ref-for-propdef-animation②">(3)</a> <a href="#ref-for-propdef-animation③">(4)</a> <a href="#ref-for-propdef-animation④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-single-animation">
   <b><a href="#typedef-single-animation">#typedef-single-animation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-single-animation">3.10. 
The animation shorthand property</a> <a href="#ref-for-typedef-single-animation①">(2)</a> <a href="#ref-for-typedef-single-animation②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-animationeventinit">
   <b><a href="#dictdef-animationeventinit">#dictdef-animationeventinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-animationeventinit">4.1.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-animationevent-animationname">
   <b><a href="#dom-animationevent-animationname">#dom-animationevent-animationname</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-animationevent-animationname">4.1.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-animationevent-elapsedtime">
   <b><a href="#dom-animationevent-elapsedtime">#dom-animationevent-elapsedtime</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-animationevent-elapsedtime">4.1.1. 
IDL Definition</a>
    <li><a href="#ref-for-dom-animationevent-elapsedtime①">4.2. 
Types of AnimationEvent</a> <a href="#ref-for-dom-animationevent-elapsedtime②">(2)</a> <a href="#ref-for-dom-animationevent-elapsedtime③">(3)</a> <a href="#ref-for-dom-animationevent-elapsedtime④">(4)</a> <a href="#ref-for-dom-animationevent-elapsedtime⑤">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-animationevent-pseudoelement">
   <b><a href="#dom-animationevent-pseudoelement">#dom-animationevent-pseudoelement</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-animationevent-pseudoelement">4.1.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-animationevent-animationstart">
   <b><a href="#eventdef-animationevent-animationstart">#eventdef-animationevent-animationstart</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-animationevent-animationstart">2. 
Animations</a>
    <li><a href="#ref-for-eventdef-animationevent-animationstart①">4.2. 
Types of AnimationEvent</a>
    <li><a href="#ref-for-eventdef-animationevent-animationstart②">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-animationevent-animationend">
   <b><a href="#eventdef-animationevent-animationend">#eventdef-animationevent-animationend</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-animationevent-animationend">2. 
Animations</a>
    <li><a href="#ref-for-eventdef-animationevent-animationend①">4.2. 
Types of AnimationEvent</a> <a href="#ref-for-eventdef-animationevent-animationend②">(2)</a>
    <li><a href="#ref-for-eventdef-animationevent-animationend③">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-animationevent-animationiteration">
   <b><a href="#eventdef-animationevent-animationiteration">#eventdef-animationevent-animationiteration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-animationevent-animationiteration">4.2. 
Types of AnimationEvent</a>
    <li><a href="#ref-for-eventdef-animationevent-animationiteration①">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-animationevent-animationcancel">
   <b><a href="#eventdef-animationevent-animationcancel">#eventdef-animationevent-animationcancel</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-animationevent-animationcancel">4.2. 
Types of AnimationEvent</a>
    <li><a href="#ref-for-eventdef-animationevent-animationcancel①">4.3. Event
handlers on elements, Document objects, and Window
objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="csskeyframerule">
   <b><a href="#csskeyframerule">#csskeyframerule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csskeyframerule">5.2. 
The CSSKeyframeRule Interface</a>
    <li><a href="#ref-for-csskeyframerule①">5.2.2. 
Attributes</a>
    <li><a href="#ref-for-csskeyframerule②">5.3.1. 
IDL Definition</a>
    <li><a href="#ref-for-csskeyframerule③">5.3.3. 
The appendRule method</a>
    <li><a href="#ref-for-csskeyframerule④">5.3.4. 
The deleteRule method</a>
    <li><a href="#ref-for-csskeyframerule⑤">5.3.5. 
The findRule method</a> <a href="#ref-for-csskeyframerule⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframerule-keytext">
   <b><a href="#dom-csskeyframerule-keytext">#dom-csskeyframerule-keytext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframerule-keytext">5.2.1. 
IDL Definition</a>
    <li><a href="#ref-for-dom-csskeyframerule-keytext①">5.2.2. 
Attributes</a> <a href="#ref-for-dom-csskeyframerule-keytext②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframerule-style">
   <b><a href="#dom-csskeyframerule-style">#dom-csskeyframerule-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframerule-style">5.2.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="csskeyframesrule">
   <b><a href="#csskeyframesrule">#csskeyframesrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csskeyframesrule">5.3. 
The CSSKeyframesRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-name">
   <b><a href="#dom-csskeyframesrule-name">#dom-csskeyframesrule-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-name">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-cssrules">
   <b><a href="#dom-csskeyframesrule-cssrules">#dom-csskeyframesrule-cssrules</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-cssrules">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-appendrule">
   <b><a href="#dom-csskeyframesrule-appendrule">#dom-csskeyframesrule-appendrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-appendrule">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-appendrule-rule-rule">
   <b><a href="#dom-csskeyframesrule-appendrule-rule-rule">#dom-csskeyframesrule-appendrule-rule-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-appendrule-rule-rule">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-deleterule">
   <b><a href="#dom-csskeyframesrule-deleterule">#dom-csskeyframesrule-deleterule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-deleterule">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-deleterule-select-select">
   <b><a href="#dom-csskeyframesrule-deleterule-select-select">#dom-csskeyframesrule-deleterule-select-select</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-deleterule-select-select">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-findrule">
   <b><a href="#dom-csskeyframesrule-findrule">#dom-csskeyframesrule-findrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-findrule">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csskeyframesrule-findrule-select-select">
   <b><a href="#dom-csskeyframesrule-findrule-select-select">#dom-csskeyframesrule-findrule-select-select</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csskeyframesrule-findrule-select-select">5.3.1. 
IDL Definition</a>
   </ul>
  </aside>
<script>/* script-dfn-panel */

document.body.addEventListener("click", function(e) {
    var queryAll = function(sel) { return [].slice.call(document.querySelectorAll(sel)); }
    // Find the dfn element or panel, if any, that was clicked on.
    var el = e.target;
    var target;
    var hitALink = false;
    while(el.parentElement) {
        if(el.tagName == "A") {
            // Clicking on a link in a <dfn> shouldn't summon the panel
            hitALink = true;
        }
        if(el.classList.contains("dfn-paneled")) {
            target = "dfn";
            break;
        }
        if(el.classList.contains("dfn-panel")) {
            target = "dfn-panel";
            break;
        }
        el = el.parentElement;
    }
    if(target != "dfn-panel") {
        // Turn off any currently "on" or "activated" panels.
        queryAll(".dfn-panel.on, .dfn-panel.activated").forEach(function(el){
            el.classList.remove("on");
            el.classList.remove("activated");
        });
    }
    if(target == "dfn" && !hitALink) {
        // open the panel
        var dfnPanel = document.querySelector(".dfn-panel[data-for='" + el.id + "']");
        if(dfnPanel) {
            dfnPanel.classList.add("on");
            var rect = el.getBoundingClientRect();
            dfnPanel.style.left = window.scrollX + rect.right + 5 + "px";
            dfnPanel.style.top = window.scrollY + rect.top + "px";
            var panelRect = dfnPanel.getBoundingClientRect();
            var panelWidth = panelRect.right - panelRect.left;
            if(panelRect.right > document.body.scrollWidth && (rect.left - (panelWidth + 5)) > 0) {
                // Reposition, because the panel is overflowing
                dfnPanel.style.left = window.scrollX + rect.left - (panelWidth + 5) + "px";
            }
        } else {
            console.log("Couldn't find .dfn-panel[data-for='" + el.id + "']");
        }
    } else if(target == "dfn-panel") {
        // Switch it to "activated" state, which pins it.
        el.classList.add("activated");
        el.style.left = null;
        el.style.top = null;
    }

});
</script>
<script>/* script-mdn-anno */

            function positionAnnos() {
                var annos = [].slice.call(document.querySelectorAll(".mdn-anno"));
                for(var i = 0; i < annos.length; i++) {
                    var anno = annos[i];
                    id = anno.getAttribute("data-mdn-for");
                    var dfn = document.querySelector("[id='" + id +"']");
                    if (dfn !== null) {
                        var rect = dfn.getBoundingClientRect(id);
                        anno.style.top = (window.scrollY + rect.top) + "px";
                        /* See https://domspec.herokuapp.com/#dom-event-cancelable
                         * for an example of a spec that defines multiple terms in
                         * the same sentence on the same line. In such cases, we
                         * need to offset the vertical positioning of each Nth anno
                         * for that term, to prevent the annos from being placed
                         * exactly on top of the previous ones at that position. */
                        var top = anno.style.top;
                        var offset = 10 * (document.querySelectorAll("[style='top: " + top + ";']").length - 1)
                        anno.style.top = (Number(top.slice(0, -2)) + offset) + "px";
                    } else {
                        console.error('MDN anno references non-existent element ID "%s".%o', id, anno);
                    }
                }
            }
            window.addEventListener("load", positionAnnos())
            document.body.addEventListener("click", (e) => {
                if(e.target.closest(".mdn-anno-btn")) {
                    e.target.closest(".mdn-anno").classList.toggle("wrapped");
                }
            });
            /* If this is a document styled for W3C publication with a ToC
             * sidebar, and the ToC "Collapse Sidebar" button is pushed, some
             * MDN annos seem to end up getting wildly out of place unless we
             * reposition them where they belong. */
            const tocToggle = document.querySelector("#toc-toggle");
            if (tocToggle) {
                tocToggle.addEventListener("click", () => positionAnnos());
            }
            </script><a class='success' href='/bikeshed/css-animations/' id='generator' title='Bikeshed Succeeded'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>