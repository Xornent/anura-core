<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Counter Styles Level 3</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="testing" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="This module introduces the &apos;&apos;@counter-style&apos;&apos; rule, which allows authors to define their own custom counter styles for use with CSS list-marker and generated-content counters [[CSS-LISTS-3]]. It also predefines a set of common counter styles, including the ones present in CSS2 and CSS2.1." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/css-counter-styles-3/" rel="canonical">
<script defer src="https://test.csswg.org/harness/annotate.js#!css-counter-styles-3_dev/css-counter-styles-3" type="text/javascript"></script>
<style>
pre.stylesheet { white-space: pre-wrap; }
code.inline { display: inline-block; }
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
 <script nonce='08DUQUsQR7LV8Aw9o8FHetoqvmVYitVSRmzC5tiKcGw=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='08DUQUsQR7LV8Aw9o8FHetoqvmVYitVSRmzC5tiKcGw=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="css-counter-styles-3\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
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
   <h1 class="p-name no-ref" id="title">CSS Counter Styles Level 3</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-03-10">10 March 2020</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/css-counter-styles/">https://drafts.csswg.org/css-counter-styles/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/css-counter-styles-3/">https://www.w3.org/TR/css-counter-styles-3/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2015/CR-css-counter-styles-3-20150611/" rel="prev">https://www.w3.org/TR/2015/CR-css-counter-styles-3-20150611/</a>
      <dd><a href="https://www.w3.org/TR/2014/WD-css-counter-styles-3-20140826/" rel="prev">https://www.w3.org/TR/2014/WD-css-counter-styles-3-20140826/</a>
      <dd><a href="https://www.w3.org/TR/2013/WD-css-counter-styles-3-20130718/" rel="prev">https://www.w3.org/TR/2013/WD-css-counter-styles-3-20130718/</a>
      <dd><a href="https://www.w3.org/TR/2013/WD-css-counter-styles-3-20130221/" rel="prev">https://www.w3.org/TR/2013/WD-css-counter-styles-3-20130221/</a>
      <dd><a href="https://www.w3.org/TR/2012/WD-css-counter-styles-3-20121009/" rel="prev">https://www.w3.org/TR/2012/WD-css-counter-styles-3-20121009/</a>
      <dt>Test Suite:
      <dd><a href="http://test.csswg.org/suites/css-counter-styles-3_dev/nightly-unstable">http://test.csswg.org/suites/css-counter-styles-3_dev/nightly-unstable</a>
      <dt class="editor">Editor:
      <dd class="editor p-author h-card vcard" data-editor-id="42199"><a class="p-name fn u-url url" href="http://xanthir.com/contact/">Tab Atkins Jr.</a> (<span class="p-org org">Google</span>)
      <dt>Issue Tracking:
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/css-counter-styles-3">GitHub Issues</a>
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/css-counter-styles-3/Overview.bs">GitHub Editor</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This module introduces the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style">@counter-style</a> rule, which allows authors to define their own custom counter styles for use with CSS list-marker and generated-content counters <a data-link-type="biblio" href="#biblio-css-lists-3">[CSS-LISTS-3]</a>. It also predefines a set of common counter styles, including the ones present in CSS2 and CSS2.1.</p>
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
	When filing an issue, please put the text “css-counter-styles” in the title,
	preferably like this:
	“[css-counter-styles] <i data-lt>…summary of comment…</i>”.
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
  <div data-fill-with="at-risk">
   <p>The following features are at-risk, and may be dropped during the CR period: </p>
   <ul>
    <li>the <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-images-3/#typedef-image" id="ref-for-typedef-image">&lt;image></a> value in <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol">&lt;symbol></a>
   </ul>
   <p>“At-risk” is a W3C Process term-of-art, and does not necessarily imply that the feature is in danger of being dropped or delayed. It means that the WG believes the feature may have difficulty being interoperably implemented in a timely manner, and marking it as such allows the WG to drop the feature if necessary when transitioning to the Proposed Rec stage, without having to publish a new Candidate Rec without the feature first.</p>
  </div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li><a href="#intro"><span class="secno">1</span> <span class="content"> Introduction</span></a>
    <li><a href="#counter-styles"><span class="secno">2</span> <span class="content"> Counter Styles</span></a>
    <li>
     <a href="#the-counter-style-rule"><span class="secno">3</span> <span class="content"> Defining Custom Counter Styles: the <span class="css">@counter-style</span> rule</span></a>
     <ol class="toc">
      <li>
       <a href="#counter-style-system"><span class="secno">3.1</span> <span class="content"> Counter algorithms: the <span class="property">system</span> descriptor</span></a>
       <ol class="toc">
        <li><a href="#cyclic-system"><span class="secno">3.1.1</span> <span class="content"> Cycling Symbols: the <span class="css">cyclic</span> system</span></a>
        <li><a href="#fixed-system"><span class="secno">3.1.2</span> <span class="content"> Exhaustible Symbols: the <span class="css">fixed</span> system</span></a>
        <li><a href="#symbolic-system"><span class="secno">3.1.3</span> <span class="content"> Repeating Symbols: the <span class="css">symbolic</span> system</span></a>
        <li><a href="#alphabetic-system"><span class="secno">3.1.4</span> <span class="content"> Bijective Numerals: the <span class="css">alphabetic</span> system</span></a>
        <li><a href="#numeric-system"><span class="secno">3.1.5</span> <span class="content"> Positional Numerals: the <span class="css">numeric</span> system</span></a>
        <li><a href="#additive-system"><span class="secno">3.1.6</span> <span class="content"> Accumulating Numerals: the <span class="css">additive</span> system</span></a>
        <li><a href="#extends-system"><span class="secno">3.1.7</span> <span class="content"> Building from Existing Counter Styles: the <span class="css">extends</span> system <span></span></span></a>
       </ol>
      <li><a href="#counter-style-negative"><span class="secno">3.2</span> <span class="content"> Formatting negative values: the <span class="property">negative</span> descriptor</span></a>
      <li><a href="#counter-style-prefix"><span class="secno">3.3</span> <span class="content"> Symbols before the marker: the <span class="property">prefix</span> descriptor</span></a>
      <li><a href="#counter-style-suffix"><span class="secno">3.4</span> <span class="content"> Symbols after the marker: the <span class="property">suffix</span> descriptor</span></a>
      <li><a href="#counter-style-range"><span class="secno">3.5</span> <span class="content"> Limiting the counter scope: the <span class="property">range</span> descriptor</span></a>
      <li><a href="#counter-style-pad"><span class="secno">3.6</span> <span class="content"> Zero-Padding and Constant-Width Representations: the <span class="property">pad</span> descriptor</span></a>
      <li><a href="#counter-style-fallback"><span class="secno">3.7</span> <span class="content"> Defining fallback: the <span class="property">fallback</span> descriptor</span></a>
      <li><a href="#counter-style-symbols"><span class="secno">3.8</span> <span class="content"> Marker characters: the <span class="property">symbols</span> and <span class="property">additive-symbols</span> descriptors</span></a>
      <li><a href="#counter-style-speak-as"><span class="secno">3.9</span> <span class="content"> Speech Synthesis: the <span class="property">speak-as</span> descriptor</span></a>
     </ol>
    <li><a href="#symbols-function"><span class="secno">4</span> <span class="content"> Defining Anonymous Counter Styles: the <span class="css">symbols()</span> function</span></a>
    <li><a href="#extending-css2"><span class="secno">5</span> <span class="content"> Extending <span class="property">list-style-type</span>, <span class="css">counter()</span>, and <span class="css">counters()</span></span></a>
    <li>
     <a href="#predefined-counters"><span class="secno">6</span> <span class="content"> Simple Predefined Counter Styles</span></a>
     <ol class="toc">
      <li><a href="#simple-numeric"><span class="secno">6.1</span> <span class="content"> Numeric: <span class="css">decimal</span>, <span class="css">decimal-leading-zero</span>, <span class="css">arabic-indic</span>, <span class="css">armenian</span>, <span class="css">upper-armenian</span>, <span class="css">lower-armenian</span>, <span class="css">bengali</span>, <span class="css">cambodian</span>, <span class="css">khmer</span>, <span class="css">cjk-decimal</span>, <span class="css">devanagari</span>, <span class="css">georgian</span>, <span class="css">gujarati</span>, <span class="css">gurmukhi</span>, <span class="css">hebrew</span>, <span class="css">kannada</span>, <span class="css">lao</span>, <span class="css">malayalam</span>, <span class="css">mongolian</span>, <span class="css">myanmar</span>, <span class="css">oriya</span>, <span class="css">persian</span>, <span class="css">lower-roman</span>, <span class="css">upper-roman</span>, <span class="css">tamil</span>, <span class="css">telugu</span>, <span class="css">thai</span>, <span class="css">tibetan</span></span></a>
      <li><a href="#simple-alphabetic"><span class="secno">6.2</span> <span class="content"> Alphabetic: <span class="css">lower-alpha</span>, <span class="css">lower-latin</span>, <span class="css">upper-alpha</span>, <span class="css">upper-latin</span>, <span class="css">lower-greek</span>, <span class="css">hiragana</span>, <span class="css">hiragana-iroha</span>, <span class="css">katakana</span>, <span class="css">katakana-iroha</span></span></a>
      <li><a href="#simple-symbolic"><span class="secno">6.3</span> <span class="content"> Symbolic: <span class="css">disc</span>, <span class="css">circle</span>, <span class="css">square</span>, <span class="css">disclosure-open</span>, <span class="css">disclosure-closed</span></span></a>
      <li><a href="#simple-fixed"><span class="secno">6.4</span> <span class="content"> Fixed: <span class="css">cjk-earthly-branch</span>, <span class="css">cjk-heavenly-stem</span></span></a>
     </ol>
    <li>
     <a href="#complex-predefined-counters"><span class="secno">7</span> <span class="content"> Complex Predefined Counter Styles</span></a>
     <ol class="toc">
      <li>
       <a href="#complex-cjk"><span class="secno">7.1</span> <span class="content"> Longhand East Asian Counter Styles</span></a>
       <ol class="toc">
        <li><a href="#limited-japanese"><span class="secno">7.1.1</span> <span class="content"> Japanese: <span class="css">japanese-informal</span> and <span class="css">japanese-formal</span></span></a>
        <li><a href="#limited-korean"><span class="secno">7.1.2</span> <span class="content"> Korean: <span class="css">korean-hangul-formal</span>, <span class="css">korean-hanja-informal</span>, and <span class="css">korean-hanja-formal</span></span></a>
        <li><a href="#limited-chinese"><span class="secno">7.1.3</span> <span class="content"> Chinese: <span class="css">simp-chinese-informal</span>, <span class="css">simp-chinese-formal</span>, <span class="css">trad-chinese-informal</span>, and <span class="css">trad-chinese-formal</span></span></a>
       </ol>
      <li><a href="#ethiopic-numeric-counter-style"><span class="secno">7.2</span> <span class="content"> Ethiopic Numeric Counter Style: <span class="css">ethiopic-numeric</span></span></a>
     </ol>
    <li><a href="#additional-predefined"><span class="secno">8</span> <span class="content"> Additional Predefined Counter Styles</span></a>
    <li>
     <a href="#apis"><span class="secno">9</span> <span class="content">APIs</span></a>
     <ol class="toc">
      <li><a href="#extentions-to-cssrule-interface"><span class="secno">9.1</span> <span class="content"> Extensions to the <code>CSSRule</code> interface</span></a>
      <li><a href="#the-csscounterstylerule-interface"><span class="secno">9.2</span> <span class="content"> The <code>CSSCounterStyleRule</code> interface</span></a>
     </ol>
    <li><a href="#ua-stylesheet"><span class="secno">10</span> <span class="content"> Sample style sheet for HTML</span></a>
    <li>
     <a href="#changes"><span class="secno"></span> <span class="content"> Changes</span></a>
     <ol class="toc">
      <li><a href="#changes-jun-2015"><span class="secno"></span> <span class="content"> Changes since the Jun 2015 Candidate Recommendation</span></a>
      <li><a href="#changes-feb-2015"><span class="secno"></span> <span class="content"> Changes since the Feb 2015 Candidate Recommendation</span></a>
     </ol>
    <li><a href="#acknowledgments"><span class="secno"></span> <span class="content"> Acknowledgments</span></a>
    <li><a href="#priv-sec"><span class="secno"></span> <span class="content"> Privacy and Security Considerations</span></a>
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
    <li>
     <a href="#property-index"><span class="secno"></span> <span class="content">Property Index</span></a>
     <ol class="toc">
      <li><a href="#counter-style-descriptor-table"><span class="secno"></span> <span class="content"><span>@counter-style</span> Descriptors</span></a>
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="intro"><span class="secno">1. </span><span class="content"> Introduction</span><a class="self-link" href="#intro"></a></h2>
   <p>CSS 1 defined a handful of useful counter styles based on the styles that HTML traditionally allowed on ordered and unordered lists.
	While this was expanded slightly by CSS2.1,
	it doesn’t address the needs of worldwide typography.</p>
   <p>This module introduces the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①">@counter-style</a> rule which allows CSS to address this in an open-ended manner,
	by allowing the author to define their own counter styles.
	These styles can then be used in the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-lists-3/#propdef-list-style-type" id="ref-for-propdef-list-style-type">list-style-type</a> property
	or in the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counter" id="ref-for-funcdef-counter">counter()</a> and <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counters" id="ref-for-funcdef-counters">counters()</a> functions.
	It also defines some additional predefined counter styles,
	particularly ones which are common but complicated to represent with <span class="css" id="ref-for-at-ruledef-counter-style②">@counter-style</span>.</p>
   <h2 class="heading settled" data-level="2" id="counter-styles"><span class="secno">2. </span><span class="content"> Counter Styles</span><a class="self-link" href="#counter-styles"></a></h2>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="counter-style">counter style</dfn> defines how to convert a counter value into a string.
	Counter styles are composed of:</p>
   <ul>
    <li> a name,
			to identify the style 
    <li> an algorithm,
			which transforms integer counter values into a basic string representation 
    <li> a negative sign,
			which is prepended or appended to the representation of a negative counter value. 
    <li> a prefix,
			to prepend to the representation 
    <li> a suffix
			to append to the representation 
    <li> a range,
			which limits the values that a counter style handles 
    <li> a spoken form,
			which describes how to read out the counter style in a speech synthesizer 
    <li> and a fallback style,
			to render the representation with when the counter value is outside the counter style’s range
			or the counter style otherwise can’t render the counter value 
   </ul>
   <p>When asked to <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="generate a counter|generate a counter representation" id="generate-a-counter">generate a counter representation</dfn> using a particular counter style for a particular counter value,
	follow these steps:</p>
   <ol>
    <li> If the counter style is unknown,
			exit this algorithm and instead <a data-link-type="dfn" href="#generate-a-counter" id="ref-for-generate-a-counter">generate a counter representation</a> using the <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal">decimal</a> style and the same counter value. 
    <li> If the counter value is outside the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range">range</a> of the counter style,
			exit this algorithm and instead <a data-link-type="dfn" href="#generate-a-counter" id="ref-for-generate-a-counter①">generate a counter representation</a> using the counter style’s fallback style and the same counter value. 
    <li> Using the counter value and the counter algorithm for the counter style,
			generate an <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="initial-representation-for-the-counter-value">initial representation for the counter value</dfn>.
			If the counter value is negative
			and the counter style <a data-link-type="dfn" href="#use-a-negative-sign" id="ref-for-use-a-negative-sign">uses a negative sign</a>,
			instead generate an initial representation using the absolute value of the counter value. 
    <li> Prepend symbols to the representation as specified in the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad">pad</a> descriptor. 
    <li> If the counter value is negative
			and the counter style <a data-link-type="dfn" href="#use-a-negative-sign" id="ref-for-use-a-negative-sign①">uses a negative sign</a>,
			wrap the representation in the counter style’s negative sign
			as specified in the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative">negative</a> descriptor. 
    <li> Return the representation. 
   </ol>
   <p class="note" role="note"><span>Note:</span> <a class="property" data-link-type="propdesc" href="#descdef-counter-style-prefix" id="ref-for-descdef-counter-style-prefix">prefix</a> and <a class="property" data-link-type="propdesc" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix">suffix</a> don’t play a part in this algorithm.
	This is intentional;
	the prefix and suffix aren’t part of the string returned by the counter() or counters() functions.
	Instead, the prefix and suffix are added by the algorithm that constructs the value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-content-3/#propdef-content" id="ref-for-propdef-content">content</a> property
	for the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-pseudo-4/#selectordef-marker" id="ref-for-selectordef-marker">::marker</a> pseudo-element.
	This also implies that the prefix and suffix always come from the specified counter-style,
	even if the actual representation is constructed by a fallback style.</p>
   <p>Some values of <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system">system</a> (<a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic">symbolic</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-additive" id="ref-for-valdef-counter-style-system-additive">additive</a>)
	and some descriptors (<a class="property" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad①">pad</a>)
	can generate representations with size linear to an author-supplied number.
	This can potentially be abused to generate excessively large representations
	and consume undue amounts of the user’s memory or even hang their browser.
	User agents must support representations at least 60 Unicode codepoints long,
	but they may choose to instead use the fallback style for representations that would be longer than 60 codepoints.</p>
   <h2 class="heading settled" data-level="3" id="the-counter-style-rule"><span class="secno">3. </span><span class="content"> Defining Custom Counter Styles: the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③">@counter-style</a> rule</span><a class="self-link" href="#the-counter-style-rule"></a></h2>
   <p>The <dfn class="dfn-paneled css" data-dfn-type="at-rule" data-export id="at-ruledef-counter-style">@counter-style</dfn> rule allows authors to define a custom <a data-link-type="dfn" href="#counter-style" id="ref-for-counter-style">counter style</a>.
	The components of a <span id="ref-for-counter-style①">counter style</span> are specified by descriptors in the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④">@counter-style</a> rule.
	The algorithm is specified implicitly by a combination of the <span class="css">system</span>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-text-decor-4/#valdef-text-emphasis-skip-symbols" id="ref-for-valdef-text-emphasis-skip-symbols">symbols</a>, and <span class="css">additive-symbols</span> properties.</p>
   <p>The general form of an <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑤">@counter-style</a> rule is:</p>
<pre>@counter-style <a class="production" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> { <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list" id="ref-for-typedef-declaration-list">&lt;declaration-list></a> }</pre>
   <p><dfn class="dfn-paneled css" data-dfn-type="type" data-export id="typedef-counter-style-name">&lt;counter-style-name></dfn> is a <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value">&lt;custom-ident></a> that is not an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive">ASCII case-insensitive</a> match for "none".</p>
   <p>Additionally, in the context of the prelude of an <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑥">@counter-style</a> rule,
	an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive①">ASCII case-insensitive</a> match for "decimal" or "disc" is also an invalid <a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name①" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> and makes the <span class="css" id="ref-for-at-ruledef-counter-style⑦">@counter-style</span> rule invalid.</p>
   <p class="note" role="note"><span>Note:</span> Note that <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value①">&lt;custom-ident></a> also automatically excludes the <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#css-wide-keywords" id="ref-for-css-wide-keywords">CSS-wide keywords</a>.
	In addition, some names, like <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#valdef-list-style-position-inside" id="ref-for-valdef-list-style-position-inside">inside</a>,
	are valid as counter style names,
	but conflict with the existing values of properties like <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-lists-3/#propdef-list-style" id="ref-for-propdef-list-style">list-style</a>,
	and so won’t be usable there.</p>
   <p>Counter style names are case-sensitive.
	However, the names defined in this specification are ASCII lower-cased on parse
	wherever they are used as counter styles, e.g.
	in the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-lists-3/#propdef-list-style" id="ref-for-propdef-list-style①">list-style</a> set of properties,
	in the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑧">@counter-style</a> rule,
	and in the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counter" id="ref-for-funcdef-counter①">counter()</a> functions.</p>
   <p>Each <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑨">@counter-style</a> rule specifies a value for every counter-style descriptor,
	either implicitly or explicitly.
	Those not given explicit value in the rule take the initial value listed with each descriptor in this specification.
	These descriptors apply solely within the context of the <span class="css" id="ref-for-at-ruledef-counter-style①⓪">@counter-style</span> rule in which they are defined,
	and do not apply to document language elements.
	There is no notion of which elements the descriptors apply to or whether the values are inherited by child elements.
	When a given descriptor occurs multiple times in a given <span class="css" id="ref-for-at-ruledef-counter-style①①">@counter-style</span> rule,
	only the last-specified valid value is used;
	all prior values for that descriptor must be ignored.</p>
   <p>Defining a <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①②">@counter-style</a> makes it available to the entire document in which it is included.
	If multiple <span class="css" id="ref-for-at-ruledef-counter-style①③">@counter-style</span> rules are defined with the same name,
	only one wins,
	according to standard cascade rules. <span class="css" id="ref-for-at-ruledef-counter-style①④">@counter-style</span> rules cascade "atomically":
	if one replaces another of the same name,
	it replaces it <em>entirely</em>,
	rather than just replacing the specific descriptors it specifies.</p>
   <p class="note" role="note"><span>Note:</span> Note that even the predefined counter styles can be overridden;
	the UA stylesheet occurs before any other stylesheets,
	so the predefined ones always lose in the cascade.</p>
   <p>This at-rule conforms with the forward-compatible parsing requirement of CSS;
	conformant parsers that don’t understand these rules will ignore them without error.
	Any descriptors that are not recognized or implemented by a given user agent,
	or whose value does not match the grammars given here or in a future version of this specification,
	must be ignored in their entirety;
	they do not make the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①⑤">@counter-style</a> rule invalid.</p>
   <h3 class="heading settled" data-level="3.1" id="counter-style-system"><span class="secno">3.1. </span><span class="content"> Counter algorithms: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system①">system</a> descriptor</span><a class="self-link" href="#counter-style-system"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-system">system</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①⑥">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod">cyclic <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one">|</a> numeric <span id="ref-for-comb-one①">|</span> alphabetic <span id="ref-for-comb-one②">|</span> symbolic <span id="ref-for-comb-one③">|</span> additive <span id="ref-for-comb-one④">|</span> <span class="nobr">[fixed <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value">&lt;integer></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-opt" id="ref-for-mult-opt">?</a>]</span> <span id="ref-for-comb-one⑤">|</span> <span class="nobr">[ extends <a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name②" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> ]</span> 
     <tr>
      <th>Initial:
      <td>symbolic 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system②">system</a> descriptor specifies which algorithm will be used to construct
	the counter’s representation based on the counter value.  For example, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-cyclic" id="ref-for-valdef-counter-style-system-cyclic">cyclic</a> counter styles just cycle through their symbols repeatedly,
	while <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric">numeric</a> counter styles interpret their symbols as digits and
	build their representation accordingly.
	The systems are defined in the following subsections.</p>
   <h4 class="heading settled" data-level="3.1.1" id="cyclic-system"><span class="secno">3.1.1. </span><span class="content"> Cycling Symbols: the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-cyclic" id="ref-for-valdef-counter-style-system-cyclic①">cyclic</a> system</span><a class="self-link" href="#cyclic-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="@counter-style/system" data-dfn-type="value" data-export id="valdef-counter-style-system-cyclic">cyclic</dfn> counter system cycles repeatedly through its provided symbols,
	looping back to the beginning when it reaches the end of the list.
	It can be used for simple bullets
	(just provide a single <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol">counter symbol</a>),
	or for cycling through multiple symbols.
	The first <span id="ref-for-counter-symbol①">counter symbol</span> is used as the representation of the value 1,
	the second <span id="ref-for-counter-symbol②">counter symbol</span> (if it exists) is used as the representation of the value 2, etc.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-cyclic" id="ref-for-valdef-counter-style-system-cyclic②">cyclic</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols">symbols</a> descriptor must contain at least one <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol③">counter symbol</a>,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①⑦">@counter-style</a> rule is invalid.
	This system is defined over all counter values.</p>
   <div class="example" id="example-bb402b2d">
    <a class="self-link" href="#example-bb402b2d"></a> A "triangle bullet" counter style can be defined as: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="triangle">triangle<a class="self-link" href="#triangle"></a></dfn> {
  system: cyclic;
  symbols: ‣;
  suffix: " ";
}
</pre>
    <p>It will then produce lists that look like:</p>
<pre>‣  One
‣  Two
‣  Three
</pre>
   </div>
   <p>If there are <var>N</var> <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol④">counter symbols</a> and a representation is being constructed for the integer <var>value</var>,
	the representation is the <span id="ref-for-counter-symbol⑤">counter symbol</span> at index ( (<var>value</var>-1) mod <var>N</var>)
	of the list of <span id="ref-for-counter-symbol⑥">counter symbols</span> (0-indexed).</p>
   <h4 class="heading settled" data-level="3.1.2" id="fixed-system"><span class="secno">3.1.2. </span><span class="content"> Exhaustible Symbols: the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-fixed" id="ref-for-valdef-counter-style-system-fixed">fixed</a> system</span><a class="self-link" href="#fixed-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="@counter-style/system" data-dfn-type="value" data-export id="valdef-counter-style-system-fixed">fixed</dfn> counter system runs through its list of counter symbols once,
	then falls back.
	It is useful for representing counter styles that only have a finite number of representations.
	For example, Unicode defines several limited-length runs of special characters meant for lists,
	such as circled digits.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-fixed" id="ref-for-valdef-counter-style-system-fixed①">fixed</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①">symbols</a> descriptor must contain at least one <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol⑦">counter symbol</a>,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①⑧">@counter-style</a> rule is invalid.
	This system is defined over counter values in a finite range,
	starting with the <a data-link-type="dfn" href="#first-symbol-value" id="ref-for-first-symbol-value">first symbol value</a> and having a length equal to the length of the list of <span id="ref-for-counter-symbol⑧">counter symbols</span>.</p>
   <p>When this system is specified,
	it may optionally have an integer provided after it,
	which sets the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="first-symbol-value">first symbol value</dfn>.
	If it is omitted, the <a data-link-type="dfn" href="#first-symbol-value" id="ref-for-first-symbol-value①">first symbol value</a> is 1.</p>
   <div class="example" id="example-24b2a03a">
    <a class="self-link" href="#example-24b2a03a"></a> A "box-corner" counter style can be defined as: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="box-corner">box-corner<a class="self-link" href="#box-corner"></a></dfn> {
  system: fixed;
  symbols: ◰ ◳ ◲ ◱;
  suffix: ': ';
}
</pre>
    <p>It will then produce lists that look like:</p>
<pre>◰:  One
◳:  Two
◲:  Three
◱:  Four
5:  Five
6:  Six
</pre>
   </div>
   <p>The first <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol⑨">counter symbol</a> is the representation for the <a data-link-type="dfn" href="#first-symbol-value" id="ref-for-first-symbol-value②">first symbol value</a>,
	and subsequent counter values are represented by subsequent <span id="ref-for-counter-symbol①⓪">counter symbols</span>.
	Once the list of <span id="ref-for-counter-symbol①①">counter symbols</span> is exhausted,
	further values cannot be represented by this counter style,
	and must instead be represented by the fallback counter style.</p>
   <h4 class="heading settled" data-level="3.1.3" id="symbolic-system"><span class="secno">3.1.3. </span><span class="content"> Repeating Symbols: the <a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic①">symbolic</a> system</span><a class="self-link" href="#symbolic-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="system" data-dfn-type="value" data-export id="valdef-system-symbolic">symbolic</dfn> counter system cycles repeatedly through its provided symbols,
	doubling, tripling, etc. the symbols on each successive pass through the list.
	For example, if the original symbols were "*" and "†",
	then on the second pass they would instead be "**" and "††",
	while on the third they would be "***"and "†††", etc.
	It can be used for footnote-style markers,
	and is also sometimes used for alphabetic-style lists for a slightly different presentation than what the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic">alphabetic</a> system presents.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic②">symbolic</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols②">symbols</a> descriptor must contain at least one <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol①②">counter symbol</a>,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style①⑨">@counter-style</a> rule is invalid.
	This system is defined only over strictly positive counter values.</p>
   <div class="example" id="example-a76d671e">
    <a class="self-link" href="#example-a76d671e"></a> An "footnote" counter style can be defined as: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="footnote">footnote<a class="self-link" href="#footnote"></a></dfn> {
  system: symbolic;
  symbols: '*' ⁑ † ‡;
  suffix: " ";
}
</pre>
    <p>It will then produce lists that look like:</p>
<pre>*   One
⁑   Two
†   Three
‡   Four
**  Five
⁑⁑  Six
</pre>
   </div>
   <div class="example" id="example-5b0bbd83">
    <a class="self-link" href="#example-5b0bbd83"></a> Some style guides mandate a list numbering that looks similar to <a class="css" data-link-type="maybe" href="#upper-alpha" id="ref-for-upper-alpha">upper-alpha</a>,
		but repeats differently after the first 26 values,
		instead going "AA", "BB", "CC", etc.
		This can be achieved with the symbolic system: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="upper-alpha-legal">upper-alpha-legal<a class="self-link" href="#upper-alpha-legal"></a></dfn> {
  system: symbolic;
  symbols: A B C D E F G H I J K L M
           N O P Q R S T U V W X Y Z;
}
</pre>
    <p>This style is identical to <a class="css" data-link-type="maybe" href="#upper-alpha" id="ref-for-upper-alpha①">upper-alpha</a> through the first 27 values,
		but they diverge after that, with <span class="css" id="ref-for-upper-alpha②">upper-alpha</span> going "AB", "AC", "AD", etc.
		Starting at the 53rd value, <span class="css" id="ref-for-upper-alpha③">upper-alpha</span> goes "BA", "BB", "BC", etc.,
		while this style jumps into triple digits with "AAA", "BBB", "CCC", etc.</p>
   </div>
   <p>To construct the representation, run the following algorithm:</p>
   <p>Let <var>N</var> be the length of the list of <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol①③">counter symbols</a>, <var>value</var> initially be the counter value, <var>S</var> initially be the empty string,
	and <var>symbol(n)</var> be the nth <span id="ref-for-counter-symbol①④">counter symbol</span> in the list of <span id="ref-for-counter-symbol①⑤">counter symbols</span> (0-indexed).</p>
   <ol>
    <li>Let the <var>chosen symbol</var> be <code class="inline">symbol( (<var>value</var> - 1) mod <var>N</var>)</code>. 
    <li>Let the <var>representation length</var> be <code class="inline">ceil( <var>value</var> / <var>N</var> )</code>. 
    <li>Append the <var>chosen symbol</var> to <var>S</var> a number of times equal to the <var>representation length</var>. 
   </ol>
   <p>Finally, return <var>S</var>.</p>
   <h4 class="heading settled" data-level="3.1.4" id="alphabetic-system"><span class="secno">3.1.4. </span><span class="content"> Bijective Numerals: the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic①">alphabetic</a> system</span><a class="self-link" href="#alphabetic-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="@counter-style/system" data-dfn-type="value" data-export id="valdef-counter-style-system-alphabetic">alphabetic</dfn> counter system interprets the list of <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol①⑥">counter symbols</a> as digits to an <em>alphabetic</em> numbering system,
	similar to the default <a class="css" data-link-type="maybe" href="#lower-alpha" id="ref-for-lower-alpha">lower-alpha</a> counter style,
	which wraps from "a", "b", "c", to "aa", "ab", "ac".
	Alphabetic numbering systems do not contain a digit representing 0;
	so the first value when a new digit is added is composed solely of the first digit.
	Alphabetic numbering systems are commonly used for lists,
	and also appear in many spreadsheet programs to number columns.
	The first <span id="ref-for-counter-symbol①⑦">counter symbol</span> in the list is interpreted as the digit 1,
	the second as the digit 2,
	and so on.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic②">alphabetic</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols③">symbols</a> descriptor must contain at least two <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol①⑧">counter symbols</a>,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②⓪">@counter-style</a> rule is invalid.
	This system is defined only over strictly positive counter values.</p>
   <div class="example" id="example-8007bc6e">
    <a class="self-link" href="#example-8007bc6e"></a> A counter style using go stones can be defined as: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="go">go<a class="self-link" href="#go"></a></dfn> {
  system: alphabetic;
  symbols: url(white.svg) url(black.svg);
  suffix: " ";
}
</pre>
    <p>It will then produce lists that look like:</p>
    <div class="alphabetic-example"> <span><img alt src="images/white.svg"></span> One<br> <span><img alt src="images/black.svg"></span> Two<br> <span><img alt src="images/white.svg"><img alt src="images/white.svg"></span> Three<br> <span><img alt src="images/white.svg"><img alt src="images/black.svg"></span> Four<br> <span><img alt src="images/black.svg"><img alt src="images/white.svg"></span> Five<br> <span><img alt src="images/black.svg"><img alt src="images/black.svg"></span> Six<br> <span><img alt src="images/white.svg"><img alt src="images/white.svg"><img alt src="images/white.svg"></span> Seven </div>
    <p class="note" role="note"><span>Note:</span> This example requires support for SVG images to display correctly.</p>
   </div>
   <p>If there are <var>N</var> <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol①⑨">counter symbols</a>,
	the representation is a base <var>N</var> alphabetic number using the <span id="ref-for-counter-symbol②⓪">counter symbols</span> as digits.
	To construct the representation, run the following algorithm:</p>
   <p>Let <var>N</var> be the length of the list of <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol②①">counter symbols</a>, <var>value</var> initially be the counter value, <var>S</var> initially be the empty string,
	and <var>symbol(n)</var> be the nth <span id="ref-for-counter-symbol②②">counter symbol</span> in the list of <span id="ref-for-counter-symbol②③">counter symbols</span> (0-indexed).</p>
   <p>While <var>value</var> is not equal to 0:</p>
   <ol>
    <li>Set <var>value</var> to <code><var>value</var> - 1</code>. 
    <li>Prepend <var>symbol( <var>value</var> mod <var>N</var> )</var> to <var>S</var>. 
    <li>Set <var>value</var> to <code>floor( <var>value</var> / <var>N</var> )</code>. 
   </ol>
   <p>Finally, return <var>S</var>.</p>
   <h4 class="heading settled" data-level="3.1.5" id="numeric-system"><span class="secno">3.1.5. </span><span class="content"> Positional Numerals: the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric①">numeric</a> system</span><a class="self-link" href="#numeric-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="@counter-style/system" data-dfn-type="value" data-export id="valdef-counter-style-system-numeric">numeric</dfn> counter system interprets the list of <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol②④">counter symbols</a> as digits to a "place-value" numbering system,
	similar to the default <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal①">decimal</a> counter style.
	The first <span id="ref-for-counter-symbol②⑤">counter symbol</span> in the list is interpreted as the digit 0,
	the second as the digit 1,
	and so on.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric②">numeric</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols④">symbols</a> descriptor must contain at least two <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol②⑥">counter symbols</a>,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②①">@counter-style</a> rule is invalid.
	This system is defined over all counter values.</p>
   <div class="example" id="example-95bf6e12">
    <a class="self-link" href="#example-95bf6e12"></a> A "trinary" counter style can be defined as: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="trinary">trinary<a class="self-link" href="#trinary"></a></dfn> {
  system: numeric;
  symbols: '0' '1' '2';
}
</pre>
    <p>It will then produce lists that look like:</p>
<pre>1.   One
2.   Two
10.  Three
11.  Four
12.  Five
20.  Six
</pre>
   </div>
   <p>If there are <var>N</var> <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol②⑦">counter symbols</a>,
	the representation is a base <var>N</var> number using the <span id="ref-for-counter-symbol②⑧">counter symbols</span> as digits.
	To construct the representation, run the following algorithm:</p>
   <p>Let <var>N</var> be the length of the list of <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol②⑨">counter symbols</a>, <var>value</var> initially be the counter value, <var>S</var> initially be the empty string,
	and <var>symbol(n)</var> be the nth <span id="ref-for-counter-symbol③⓪">counter symbol</span> in the list of <span id="ref-for-counter-symbol③①">counter symbols</span> (0-indexed).</p>
   <ol>
    <li>If <var>value</var> is 0, append <code>symbol(0)</code> to <var>S</var> and return <var>S</var>. 
    <li>
     While <var>value</var> is not equal to 0: 
     <ol>
      <li>Prepend <var>symbol( <var>value</var> mod <var>N</var> )</var> to <var>S</var>. 
      <li>Set <var>value</var> to <code>floor( <var>value</var> / <var>N</var> )</code>. 
     </ol>
    <li>Return <var>S</var>. 
   </ol>
   <h4 class="heading settled" data-level="3.1.6" id="additive-system"><span class="secno">3.1.6. </span><span class="content"> Accumulating Numerals: the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-additive" id="ref-for-valdef-counter-style-system-additive①">additive</a> system</span><a class="self-link" href="#additive-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="@counter-style/system" data-dfn-type="value" data-export id="valdef-counter-style-system-additive">additive</dfn> counter system is used to represent "sign-value" numbering systems,
	which, rather than reusing digits in different positions to change their value,
	define additional digits with much larger values,
	so that the value of the number can be obtained by adding all the digits together.
	This is used in Roman numerals
	and other numbering systems around the world.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-additive" id="ref-for-valdef-counter-style-system-additive②">additive</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols">additive-symbols</a> descriptor must contain at least one <a data-link-type="dfn" href="#additive-tuple" id="ref-for-additive-tuple">additive tuple</a>,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②②">@counter-style</a> rule is invalid.
	This system is nominally defined over all counter values
	(see algorithm, below, for exact details).</p>
   <div class="example" id="example-ffca8577">
    <a class="self-link" href="#example-ffca8577"></a> A "dice" counter style can be defined as: 
<pre>@counter-style <dfn data-dfn-type="dfn" data-noexport id="dice">dice<a class="self-link" href="#dice"></a></dfn> {
  system: additive;
  additive-symbols: 6 ⚅, 5 ⚄, 4 ⚃, 3 ⚂, 2 ⚁, 1 ⚀;
  suffix: " ";
}
</pre>
    <p>It will then produce lists that look like:</p>
<pre>  ⚀  One
  ⚁  Two
  ⚂  Three
...
 ⚅⚄  Eleven
 ⚅⚅  Twelve
⚅⚅⚀  Thirteen
</pre>
   </div>
   <p>To construct the representation, run this algorithm:</p>
   <p>Let <var>value</var> initially be the counter value, <var>S</var> initially be the empty string,
	and <var>symbol list</var> initially be the list of <a data-link-type="dfn" href="#additive-tuple" id="ref-for-additive-tuple①">additive tuples</a>.</p>
   <ol>
    <li>If <var>value</var> is initially 0, and there is an <a data-link-type="dfn" href="#additive-tuple" id="ref-for-additive-tuple②">additive tuple</a> with a weight of 0, append that tuple’s <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol③②">counter symbol</a> to S and return S. 
    <li>
     While <var>value</var> is greater than 0 and there are elements left in the <var>symbol list</var>: 
     <ol>
      <li>Pop the first <a data-link-type="dfn" href="#additive-tuple" id="ref-for-additive-tuple③">additive tuple</a> from the <var>symbol list</var>.
				This is the <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="current-tuple">current tuple</dfn>. 
      <li>Append the <a data-link-type="dfn" href="#current-tuple" id="ref-for-current-tuple">current tuple</a>’s <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol③③">counter symbol</a> to <var>S</var> <code>floor( <var>value</var> / <var><a data-link-type="dfn" href="#current-tuple" id="ref-for-current-tuple①">current tuple</a>’s weight</var> )</code> times (this may be 0). 
      <li>Decrement <var>value</var> by the <var><a data-link-type="dfn" href="#current-tuple" id="ref-for-current-tuple②">current tuple</a>’s weight</var> multiplied
				by the number of times the <a data-link-type="dfn" href="#current-tuple" id="ref-for-current-tuple③">current tuple</a> was appended to <var>S</var> in the previous step. 
     </ol>
    <li>If the loop ended because <var>value</var> is 0, return S.  Otherwise, the given counter value cannot be represented by this counter style, and must instead be represented by the fallback counter style. 
   </ol>
   <p class="note" role="note"><span>Note:</span> All of the predefined additive <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②③">@counter-style</a> rules in this specification
	produce representations for every value in their range,
	but it’s possible to produce values for <span class="css">additive-symbols</span> that will fail to find a representation
	with the algorithm defined above,
	even though theoretically a representation could be found.
	For example, if a <span class="css" id="ref-for-at-ruledef-counter-style②④">@counter-style</span> was defined with <a class="css" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols①">additive-symbols: 3 "a", 2 "b";</a>,
	the algorithm defined above will fail to find a representation for a counter value of 4,
	even though theoretically a "bb" representation would work.
	While unfortunate, this is required to maintain the property that the algorithm runs in linear time
	relative to the size of the counter value.</p>
   <h4 class="heading settled" data-level="3.1.7" id="extends-system"><span class="secno">3.1.7. </span><span class="content"> Building from Existing Counter Styles: the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends">extends</a> system <span id="override-system"></span></span><a class="self-link" href="#extends-system"></a></h4>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="@counter-style/system" data-dfn-type="value" data-export id="valdef-counter-style-system-extends">extends</dfn> system allows an author to use the algorithm of another counter style,
	but alter other aspects,
	such as the negative sign or the suffix.
	If a counter style uses the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends①">extends</a> system,
	any unspecified descriptors must be taken from the extended counter style specified,
	rather than taking their initial values.</p>
   <p>If a @counter-style uses the <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends②">extends</a> system,
	it must not contain a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols⑤">symbols</a> or <a class="property" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols②">additive-symbols</a> descriptor,
	or else the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②⑤">@counter-style</a> rule is invalid.</p>
   <p>If the specified counter style name isn’t the name of any currently-defined counter style,
	it must be treated as if it was extending the <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal②">decimal</a> counter style.
	If one or more <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②⑥">@counter-style</a> rules form a cycle with their <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends③">extends</a> values,
	all of the counter styles participating in the cycle
	must be treated as if they were extending the <span class="css" id="ref-for-decimal③">decimal</span> counter style instead.</p>
   <div class="example" id="example-4eacf761">
    <a class="self-link" href="#example-4eacf761"></a> For example, if you wanted a counter style that was identical to decimal,
		but used a parenthesis rather than a period after it, like: 
<pre>1) first item
2) second item
3) third item
</pre>
    <p>Rather than writing up an entirely new counter style,
		this can be done by just extending <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal④">decimal</a>:</p>
<pre>@counter-style decimal-paren {
  system: extends decimal;
  suffix: ") ";
}
</pre>
   </div>
   <h3 class="heading settled" data-level="3.2" id="counter-style-negative"><span class="secno">3.2. </span><span class="content"> Formatting negative values: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative①">negative</a> descriptor</span><a class="self-link" href="#counter-style-negative"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-negative">negative</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②⑦">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①">&lt;symbol></a> <span class="production" id="ref-for-typedef-symbol②">&lt;symbol></span><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-opt" id="ref-for-mult-opt①">?</a> 
     <tr>
      <th>Initial:
      <td>"\2D" ("-" hyphen-minus) 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative②">negative</a> descriptor defines how to alter the representation when
	the counter value is negative.</p>
   <p>The first <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol③">&lt;symbol></a> in the value is prepended to the representation when the
	counter value is negative.  The second <span class="production" id="ref-for-typedef-symbol④">&lt;symbol></span>, if specified, is appended
	to the representation when the counter value is negative.</p>
   <div class="example" id="example-cea7bd84"><a class="self-link" href="#example-cea7bd84"></a> For example, specifying <a class="css" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative③">negative: "(" ")";</a> will make negative
		values be wrapped in parentheses, which is sometimes used in financial
		contexts, like "(2) (1) 0 1 2 3...". </div>
   <p>Not all <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system③">system</a> values use a negative sign.
	In particular, a counter style <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="use a negative sign|uses a negative sign" id="use-a-negative-sign">uses a negative sign</dfn> if its <span class="property" id="ref-for-descdef-counter-style-system④">system</span> value is <a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic③">symbolic</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic③">alphabetic</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric③">numeric</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-additive" id="ref-for-valdef-counter-style-system-additive③">additive</a>,
	or <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends④">extends</a> if the extended counter style itself <a data-link-type="dfn" href="#use-a-negative-sign" id="ref-for-use-a-negative-sign②">uses a negative sign</a>.
	If a counter style does not <span id="ref-for-use-a-negative-sign③">use a negative sign</span>,
	it ignores the negative sign when <a data-link-type="dfn" href="#generate-a-counter" id="ref-for-generate-a-counter②">generating a counter representation</a>.</p>
   <h3 class="heading settled" data-level="3.3" id="counter-style-prefix"><span class="secno">3.3. </span><span class="content"> Symbols before the marker: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-prefix" id="ref-for-descdef-counter-style-prefix①">prefix</a> descriptor</span><a class="self-link" href="#counter-style-prefix"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-prefix">prefix</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②⑧">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol⑤">&lt;symbol></a> 
     <tr>
      <th>Initial:
      <td>"" (the empty string) 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-prefix" id="ref-for-descdef-counter-style-prefix②">prefix</a> descriptor specifies a <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol⑥">&lt;symbol></a> that is prepended to the marker representation.
	Prefixes come before any negative sign.</p>
   <p class="note" role="note"><span>Note:</span> Prefixes are only added by the algorithm for constructing
	the default contents of the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-pseudo-4/#selectordef-marker" id="ref-for-selectordef-marker①">::marker</a> pseudo-element; the prefix is not
	added automatically when the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counter" id="ref-for-funcdef-counter②">counter()</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counters" id="ref-for-funcdef-counters①">counters()</a> functions are used.</p>
   <h3 class="heading settled" data-level="3.4" id="counter-style-suffix"><span class="secno">3.4. </span><span class="content"> Symbols after the marker: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix①">suffix</a> descriptor</span><a class="self-link" href="#counter-style-suffix"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-suffix">suffix</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style②⑨">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol⑦">&lt;symbol></a> 
     <tr>
      <th>Initial:
      <td>"\2E\20" ("." full stop followed by a space) 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix②">suffix</a> descriptor specifies a <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol⑧">&lt;symbol></a> that is appended to the marker representation.
	Suffixes are added to the representation after negative signs.</p>
   <p class="note" role="note"><span>Note:</span> Suffixes are only added by the algorithm for constructing
	the default contents of the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-pseudo-4/#selectordef-marker" id="ref-for-selectordef-marker②">::marker</a> pseudo-element; the suffix is not
	added automatically when the counter() or counters() functions are used.</p>
   <h3 class="heading settled" data-level="3.5" id="counter-style-range"><span class="secno">3.5. </span><span class="content"> Limiting the counter scope: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range①">range</a> descriptor</span><a class="self-link" href="#counter-style-range"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-range">range</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③⓪">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod">[ [ <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value①">&lt;integer></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one⑥">|</a> infinite ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-num" id="ref-for-mult-num">{2}</a> ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma">#</a> <span id="ref-for-comb-one⑦">|</span> auto 
     <tr>
      <th>Initial:
      <td>auto 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range②">range</a> descriptor defines the ranges over which the counter style is defined.
	If a counter style is used to represent a counter value outside of its ranges,
	the counter style instead drops down to its fallback counter style.</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="@counter-style/range" data-dfn-type="value" data-export id="valdef-counter-style-range-auto">auto</dfn> 
    <dd>
      The range depends on the counter system: 
     <ul>
      <li> For <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-cyclic" id="ref-for-valdef-counter-style-system-cyclic③">cyclic</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric④">numeric</a>, and <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-fixed" id="ref-for-valdef-counter-style-system-fixed②">fixed</a> systems,
					the range is negative infinity to positive infinity. 
      <li> For <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic④">alphabetic</a> and <a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic④">symbolic</a> systems,
					the range is 1 to positive infinity. 
      <li> For <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-additive" id="ref-for-valdef-counter-style-system-additive④">additive</a> systems,
					the range is 0 to positive infinity. 
      <li> For <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends⑤">extends</a> systems,
					the range is whatever <a class="css" data-link-type="maybe" href="#valdef-counter-style-range-auto" id="ref-for-valdef-counter-style-range-auto">auto</a> would produce for the extended system;
					if extending a complex predefined style (<a href="#complex-predefined-counters">§ 7 Complex Predefined Counter Styles</a>),
					the range is the style’s defined range. 
     </ul>
    <dt>[ [ <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value②">&lt;integer></a> | infinite ]{2} ]# 
    <dd>
      This defines a comma-separated list of ranges.
			For each individual range,
			the first value is the lower bound
			and the second value is the upper bound.
			This range is inclusive - it contains both the lower and upper bound numbers.
			If <span class="css">infinite</span> is used as the first value in a range,
			it represents negative infinity;
			if used as the second value,
			it represents positive infinity.
			The range of the counter style is the union of all the ranges defined in the list. 
     <p>If the lower bound of any range is higher than the upper bound,
			the entire descriptor is invalid and must be ignored.</p>
   </dl>
   <p>Implementations must support ranges with a lower bound of at least -2<sup>15</sup> and an upper bound of at least 2<sup>15</sup>-1
	(the range of a signed 2-byte int).
	They may support higher ranges.
	If any specified bound is outside of the implementation’s supported bounds,
	it must be treated as the closest bound that the implementation does support.</p>
   <h3 class="heading settled" data-level="3.6" id="counter-style-pad"><span class="secno">3.6. </span><span class="content"> Zero-Padding and Constant-Width Representations: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad②">pad</a> descriptor</span><a class="self-link" href="#counter-style-pad"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-pad">pad</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③①">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value③">&lt;integer [0,∞]></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-all" id="ref-for-comb-all">&amp;&amp;</a> <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol⑨">&lt;symbol></a> 
     <tr>
      <th>Initial:
      <td>0 "" 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad③">pad</a> descriptor allows an author to specify a "fixed-width" counter style,
	where representations shorter than the pad value are padded with a particular <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①⓪">&lt;symbol></a>.
	Representations larger than the specified pad value are constructed as normal.</p>
   <dl>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value④">&lt;integer [0,∞]></a> &amp;&amp; <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①①">&lt;symbol></a> 
    <dd>
      The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value⑤">&lt;integer></a> specifies a minimum length that all counter representations must reach. 
     <p>Let <var>difference</var> be the provided <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value⑥">&lt;integer></a> minus the number of <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#grapheme-cluster" id="ref-for-grapheme-cluster">grapheme clusters</a> in the <a data-link-type="dfn" href="#initial-representation-for-the-counter-value" id="ref-for-initial-representation-for-the-counter-value">initial representation for the counter value</a>. <span class="note">(Note that, per the algorithm to <a data-link-type="dfn" href="#generate-a-counter" id="ref-for-generate-a-counter③">generate a counter representation</a>,
			this occurs before adding prefixes/suffixes/negatives.)</span> If the counter value is negative
			and the counter style <a data-link-type="dfn" href="#use-a-negative-sign" id="ref-for-use-a-negative-sign④">uses a negative sign</a>,
			further reduce <var>difference</var> by the number of <span id="ref-for-grapheme-cluster①">grapheme clusters</span> in the counter style’s <a class="property" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative④">negative</a> descriptor’s <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①②">&lt;symbol></a>(s).</p>
     <p>If <var>difference</var> is greater than zero,
			prepend <var>difference</var> copies of the specified <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①③">&lt;symbol></a> to the representation.</p>
     <p>Negative <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value⑦">&lt;integer></a> values are not allowed.</p>
   </dl>
   <div class="example" id="example-9431be5f">
    <a class="self-link" href="#example-9431be5f"></a> The most common example of "fixed-width" numbering is zero-padded decimal numbering.
		If an author knows that the numbers used will be less than a thousand, for example,
		it can be zero-padded with a simple <a class="css" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad④">pad: 3 "0";</a> descriptor,
		ensuring that all of the representations are 3 digits wide. 
    <p>This will cause, for example,
			1 to be represented as "001",
			20 to be represented as "020",
			300 to be represented as "300",
			4000 to be represented as "4000",
			and -5 to be represented as "-05".</p>
   </div>
   <p class="note" role="note"><span>Note:</span> The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad⑤">pad</a> descriptor counts the number of <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#grapheme-cluster" id="ref-for-grapheme-cluster②">grapheme clusters</a> in the representation,
	but pads it with <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①④">&lt;symbol></a>s.
	If the specified <span class="property" id="ref-for-descdef-counter-style-pad⑥">pad</span> <span class="production" id="ref-for-typedef-symbol①⑤">&lt;symbol></span> is multi-character,
	this will likely not have the desired effect.
	Unfortunately, there’s no way to use the number of <span id="ref-for-grapheme-cluster③">grapheme clusters</span> in the <span class="property" id="ref-for-descdef-counter-style-pad⑦">pad</span> <span class="production" id="ref-for-typedef-symbol①⑥">&lt;symbol></span> without violating useful constraints.
	It is recommended that authors only specify <span class="production" id="ref-for-typedef-symbol①⑦">&lt;symbol></span>s of a single <span id="ref-for-grapheme-cluster④">grapheme cluster</span> in the <span class="property" id="ref-for-descdef-counter-style-pad⑧">pad</span> descriptor.</p>
   <h3 class="heading settled" data-level="3.7" id="counter-style-fallback"><span class="secno">3.7. </span><span class="content"> Defining fallback: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback">fallback</a> descriptor</span><a class="self-link" href="#counter-style-fallback"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-fallback">fallback</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③②">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name③" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> 
     <tr>
      <th>Initial:
      <td>decimal 
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback①">fallback</a> descriptor specifies a fallback counter style to be used
	when the current counter style can’t create a representation for a given
	counter value.  For example, if a counter style defined with a range of 1-10
	is asked to represent a counter value of 11, the counter value’s representation
	is instead constructed with the fallback counter style (or possibly the
	fallback style’s fallback style, if the fallback style can’t represent that
	value, etc.).</p>
   <p>If the value of the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback②">fallback</a> descriptor isn’t the name of any
	currently-defined counter style, the used value of the <span class="property" id="ref-for-descdef-counter-style-fallback③">fallback</span> descriptor
	is <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal⑤">decimal</a> instead.  Similarly, while following fallbacks to find
	a counter style that can render the given counter value, if a loop in the
	specified fallbacks is detected, the <span class="css" id="ref-for-decimal⑥">decimal</span> style must be used instead.</p>
   <p class="note" role="note">Note that it is not necessarily an error to specify fallback
	loops.  For example, if an author desires a counter style with significantly
	different representations for even and odd counter values, they may find it
	easiest to define one style that can only represent odd values and one that
	can only represent even values, and specify each as the fallback for the
	other one.  Though the fallback graph is circular, at no point do you encounter
	a loop while following these fallbacks - every counter value is represented
	by one or the other counter style. </p>
   <h3 class="heading settled" data-level="3.8" id="counter-style-symbols"><span class="secno">3.8. </span><span class="content"> Marker characters: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols⑥">symbols</a> and <a class="property" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols③">additive-symbols</a> descriptors</span><a class="self-link" href="#counter-style-symbols"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-symbols">symbols</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③③">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①⑧">&lt;symbol></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-one-plus" id="ref-for-mult-one-plus">+</a> 
     <tr>
      <th>Initial:
      <td>n/a 
   </table>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-additive-symbols">additive-symbols</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③④">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod">[ <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value⑧">&lt;integer [0,∞]></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-all" id="ref-for-comb-all①">&amp;&amp;</a> <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol①⑨">&lt;symbol></a> ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma①">#</a> 
     <tr>
      <th>Initial:
      <td>n/a 
   </table>
<pre class="prod"><dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-symbol">&lt;symbol></dfn> = <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value">&lt;string></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one⑧">|</a> <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-images-3/#typedef-image" id="ref-for-typedef-image①">&lt;image></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one⑨">|</a> <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value②">&lt;custom-ident></a></pre>
   <p>The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols⑦">symbols</a> and <a class="property" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols④">additive-symbols</a> descriptors specify the symbols
	used by the marker-construction algorithm specified by the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system⑤">system</a> descriptor.
	The <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③⑤">@counter-style</a> rule must have a valid <span class="property" id="ref-for-descdef-counter-style-symbols⑧">symbols</span> descriptor
	if the counter system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-cyclic" id="ref-for-valdef-counter-style-system-cyclic④">cyclic</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric⑤">numeric</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic⑤">alphabetic</a>, <a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic⑤">symbolic</a>, or <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-fixed" id="ref-for-valdef-counter-style-system-fixed③">fixed</a>,
	or a valid <span class="property" id="ref-for-descdef-counter-style-additive-symbols⑤">additive-symbols</span> descriptor
	if the counter system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-additive" id="ref-for-valdef-counter-style-system-additive⑤">additive</a>;
	otherwise, the <span class="css" id="ref-for-at-ruledef-counter-style③⑥">@counter-style</span> does not define a <a data-link-type="dfn" href="#counter-style" id="ref-for-counter-style②">counter style</a> (but is still a valid <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#at-rule" id="ref-for-at-rule">at-rule</a>).</p>
   <p>Some counter systems specify that the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols⑨">symbols</a> descriptor must have at least two entries.
	If the counter style’s system is such,
	and the <span class="property" id="ref-for-descdef-counter-style-symbols①⓪">symbols</span> descriptor has only a single entry,
	the descriptor is invalid and must be ignored.</p>
   <p>Each entry in the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①①">symbols</a> descriptor’s value defines a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="counter-symbol">counter symbol</dfn>,
	which is interpreted differently based on the counter style’s system.
	Each entry in the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols⑥">additive-symbols</a> descriptor’s value defines an <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="additive-tuple">additive tuple</dfn>,
	which consists of a <a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol③④">counter symbol</a> and an integer weight.
	Each weight must be a non-negative integer,
	and the <a data-link-type="dfn" href="#additive-tuple" id="ref-for-additive-tuple④">additive tuples</a> must be specified in order of strictly descending weight;
	otherwise, the declaration is invalid and must be ignored.</p>
   <p><a data-link-type="dfn" href="#counter-symbol" id="ref-for-counter-symbol③⑤">Counter symbols</a> may be strings, images, or identifiers,
	and the three types can be mixed in a single descriptor.
	Counter representations are constructed by concatenating counter symbols together.
	Identifiers are rendered as strings containing the same characters.
	Images are rendered as inline replaced elements.
	The <a data-link-type="dfn" href="https://drafts.csswg.org/css-images-3/#default-object-size" id="ref-for-default-object-size">default object size</a> of an image <span id="ref-for-counter-symbol③⑥">counter symbol</span> is a 1em by 1em square.</p>
   <p class="note" role="note"><span>Note:</span> The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-images-3/#typedef-image" id="ref-for-typedef-image②">&lt;image></a> syntax in <a class="production css" data-link-type="type" href="#typedef-symbol" id="ref-for-typedef-symbol②⓪">&lt;symbol></a> is currently at-risk.
	No implementations have plans to implement it currently,
	and it complicates some usages of <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counter" id="ref-for-funcdef-counter③">counter()</a> in ways that haven’t been fully handled.</p>
   <p class="note" role="note"><span>Note:</span> If using identifiers rather than strings to define the symbols,
	be aware of the syntax of identifiers.
	In particular, ascii non-letters like "*" are not identifiers,
	and so must be quoted in a string.
	Hex escapes,
	used in several of the counter styles defined in this specification,
	"eat" the following space
	(to allow a digit to follow a hex escape without ambiguity),
	so two spaces must be put after a hex escape
	to separate it from the following one,
	or else they’ll be considered adjacent,
	and part of the same identifier.
	For example, <a class="css" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①②">symbols: \660 \661;</a> only defines a single symbol,
	consisting of the U+0660 and U+0661 characters,
	rather than the two that were intended;
	either quote the escapes in strings,
	like <span class="css" id="ref-for-descdef-counter-style-symbols①③">symbols: "\660" "\661"</span>,
	or put two spaces between the escapes.</p>
   <h3 class="heading settled" data-level="3.9" id="counter-style-speak-as"><span class="secno">3.9. </span><span class="content"> Speech Synthesis: the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as">speak-as</a> descriptor</span><a class="self-link" href="#counter-style-speak-as"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@counter-style" data-dfn-type="descriptor" data-export id="descdef-counter-style-speak-as">speak-as</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③⑦">@counter-style</a> 
     <tr>
      <th>Value:
      <td class="prod">auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①⓪">|</a> bullets <span id="ref-for-comb-one①①">|</span> numbers <span id="ref-for-comb-one①②">|</span> words <span id="ref-for-comb-one①③">|</span> spell-out <span id="ref-for-comb-one①④">|</span> <a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name④" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> 
     <tr>
      <th>Initial:
      <td>auto 
   </table>
   <p>A counter style can be constructed with a meaning that is obvious visually,
	but impossible to meaningfully represent via a speech synthesizer,
	or possible but nonsensical when naively read out.
	The <a class="property" data-link-type="propdesc" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as①">speak-as</a> descriptor describes how to synthesize the spoken form of a counter formatted with the given counter style.
	Values have the following meanings:</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="@counter-style/speak-as" data-dfn-type="value" data-export id="valdef-counter-style-speak-as-auto">auto</dfn> 
    <dd> If the counter style’s <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system⑥">system</a> is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic⑥">alphabetic</a>,
			this value has the same effect as <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-spell-out" id="ref-for-valdef-counter-style-speak-as-spell-out">spell-out</a>.
			If the <span class="property" id="ref-for-descdef-counter-style-system⑦">system</span> is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-cyclic" id="ref-for-valdef-counter-style-system-cyclic⑤">cyclic</a>,
			this value has the same effect as <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-bullets" id="ref-for-valdef-counter-style-speak-as-bullets">bullets</a>.
			If the <span class="property" id="ref-for-descdef-counter-style-system⑧">system</span> is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends⑥">extends</a>,
			this value has the same effect as <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-auto" id="ref-for-valdef-counter-style-speak-as-auto">auto</a> would have for the extended style.
			Otherwise, this value has the same effect as <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-numbers" id="ref-for-valdef-counter-style-speak-as-numbers">numbers</a>. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="@counter-style/speak-as" data-dfn-type="value" data-export id="valdef-counter-style-speak-as-bullets">bullets</dfn> 
    <dd> The UA speaks a UA-defined phrase or audio cue that represents an unordered list item being read out. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="@counter-style/speak-as" data-dfn-type="value" data-export id="valdef-counter-style-speak-as-numbers">numbers</dfn> 
    <dd> The counter’s value is spoken as a number in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#content-language" id="ref-for-content-language">content language</a>. 
    <dt><dfn class="css" data-dfn-for="@counter-style/speak-as" data-dfn-type="value" data-export id="valdef-counter-style-speak-as-words">words<a class="self-link" href="#valdef-counter-style-speak-as-words"></a></dfn> 
    <dd> <a data-link-type="dfn" href="#generate-a-counter" id="ref-for-generate-a-counter④">Generate a counter representation</a> for the value as normal,
			then speak it as normal text in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#content-language" id="ref-for-content-language①">content language</a>. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="@counter-style/speak-as" data-dfn-type="value" data-export id="valdef-counter-style-speak-as-spell-out">spell-out</dfn> 
    <dd>
      <a data-link-type="dfn" href="#generate-a-counter" id="ref-for-generate-a-counter⑤">Generate a counter representation</a> for the value as normal,
			then spell it out letter-by-letter in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#content-language" id="ref-for-content-language②">content language</a>.
			If the UA does not know how to pronounce the symbols,
			it may handle it as <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-numbers" id="ref-for-valdef-counter-style-speak-as-numbers①">numbers</a>. 
     <p>For example, <a class="css" data-link-type="maybe" href="#lower-greek" id="ref-for-lower-greek">lower-greek</a> in English would be read out as "alpha", "beta", "gamma", etc.
			Conversely, <a class="css" data-link-type="maybe" href="#upper-latin" id="ref-for-upper-latin">upper-latin</a> in French would be read out as (in phonetic notation) /a/, /be/, /se/, etc.</p>
    <dt><dfn class="css" data-dfn-for="@counter-style/speak-as" data-dfn-type="value" data-export id="valdef-counter-style-speak-as-counter-style-name"><a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name⑤" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a><a class="self-link" href="#valdef-counter-style-speak-as-counter-style-name"></a></dfn> 
    <dd> The counter’s value is instead spoken out in the specified style
			(similar to the behavior of the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback④">fallback</a> descriptor when generating representations for a counter value).
			If the specified style does not exist,
			this value is treated as <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-auto" id="ref-for-valdef-counter-style-speak-as-auto①">auto</a>.
			If a loop is detected when following <a class="property" data-link-type="propdesc" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as②">speak-as</a> references,
			this value is treated as <span class="css" id="ref-for-valdef-counter-style-speak-as-auto②">auto</span> for the counter styles participating in the loop. 
   </dl>
   <div class="example" id="example-cce4b0db">
    <a class="self-link" href="#example-cce4b0db"></a> The ability to defer pronunciation to another counter style can help when the symbols being used aren’t actually letters.
		For example, here’s a possible definition of a <span class="css">circled-lower-latin</span> counter-style, using some special Unicode characters: 
<pre class="stylesheet">@counter-style <dfn data-dfn-type="dfn" data-noexport id="circled-lower-latin">circled-lower-latin<a class="self-link" href="#circled-lower-latin"></a></dfn> {
  system: alphabetic;
  speak-as: lower-latin;
  symbols: ⓐ ⓑ ⓒ ⓓ ⓔ ⓕ ⓖ ⓗ ⓘ ⓙ ⓚ ⓛ ⓜ ⓝ ⓞ ⓟ ⓠ ⓡ ⓢ ⓣ ⓤ ⓥ ⓦ ⓧ ⓨ ⓩ;
  suffix: " ";
}
</pre>
    <p>Setting its <a class="property" data-link-type="propdesc" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system⑨">system</a> to <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic⑦">alphabetic</a> would normally make the UA try to read out the names of the characters,
		but in this case that might be something like "Circled Letter A",
		which is unlikely to make sense.
		Instead, explicitly setting <a class="property" data-link-type="propdesc" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as③">speak-as</a> to <a class="css" data-link-type="maybe" href="#lower-latin" id="ref-for-lower-latin">lower-latin</a> ensures that they get read out as their corresponding latin letters, as intended.</p>
   </div>
   <h2 class="heading settled" data-level="4" id="symbols-function"><span class="secno">4. </span><span class="content"> Defining Anonymous Counter Styles: the <a class="css" data-link-type="maybe" href="#funcdef-symbols" id="ref-for-funcdef-symbols">symbols()</a> function</span><a class="self-link" href="#symbols-function"></a></h2>
   <p>The <a class="css" data-link-type="maybe" href="#funcdef-symbols" id="ref-for-funcdef-symbols①">symbols()</a> function allows a <a data-link-type="dfn" href="#counter-style" id="ref-for-counter-style③">counter style</a> to be defined inline in a property value,
	for when a style is used only once in a stylesheet and defining a full <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style③⑧">@counter-style</a> rule would be overkill.
	It does not provide the full feature-set of the <span class="css" id="ref-for-at-ruledef-counter-style③⑨">@counter-style</span> rule,
	but provides a sufficient subset to still be useful.
	The syntax of the <span class="css" id="ref-for-funcdef-symbols②">symbols()</span> rule is:</p>
<pre class="prod"><dfn class="dfn-paneled" data-dfn-type="function" data-export id="funcdef-symbols">symbols()</dfn> = symbols( <a class="production" data-link-type="type" href="#typedef-symbols-type" id="ref-for-typedef-symbols-type">&lt;symbols-type></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-opt" id="ref-for-mult-opt②">?</a> [ <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value①">&lt;string></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①⑤">|</a> <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-images-3/#typedef-image" id="ref-for-typedef-image③">&lt;image></a> ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-one-plus" id="ref-for-mult-one-plus①">+</a> );
<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-symbols-type">&lt;symbols-type></dfn> = cyclic <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①⑥">|</a> numeric <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①⑦">|</a> alphabetic <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①⑧">|</a> symbolic <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①⑨">|</a> fixed;
</pre>
   <p>The <a class="css" data-link-type="maybe" href="#funcdef-symbols" id="ref-for-funcdef-symbols③">symbols()</a> function defines an anonymous counter style
	with no name,
	a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-prefix" id="ref-for-descdef-counter-style-prefix③">prefix</a> of <span class="css">""</span> (empty string)
	and <a class="property" data-link-type="propdesc" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix③">suffix</a> of <span class="css">" "</span> (U+0020 SPACE),
	a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range③">range</a> of <a class="css" data-link-type="maybe" href="#valdef-counter-style-range-auto" id="ref-for-valdef-counter-style-range-auto①">auto</a>,
	a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback⑤">fallback</a> of <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal⑦">decimal</a>,
	a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative⑤">negative</a> of <span class="css">"\2D"</span> ("-" hyphen-minus),
	a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad⑨">pad</a> of <span class="css">0 ""</span>,
	and a <a class="property" data-link-type="propdesc" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as④">speak-as</a> of <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-auto" id="ref-for-valdef-counter-style-speak-as-auto③">auto</a>.
	The counter style’s algorithm is constructed
	by consulting the previous chapter using the provided system —
	or <a class="css" data-link-type="maybe" href="#valdef-system-symbolic" id="ref-for-valdef-system-symbolic⑥">symbolic</a> if the system was omitted —
	and the provided <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value②">&lt;string></a>s and <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-images-3/#typedef-image" id="ref-for-typedef-image④">&lt;image></a>s as the value of the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①④">symbols</a> property.
	If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-fixed" id="ref-for-valdef-counter-style-system-fixed④">fixed</a>, the <a data-link-type="dfn" href="#first-symbol-value" id="ref-for-first-symbol-value③">first symbol value</a> is <span class="css">1</span>.</p>
   <p>If the system is <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-alphabetic" id="ref-for-valdef-counter-style-system-alphabetic⑧">alphabetic</a> or <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-numeric" id="ref-for-valdef-counter-style-system-numeric⑥">numeric</a>,
	there must be at least two <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value③">&lt;string></a>s or <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-images-3/#typedef-image" id="ref-for-typedef-image⑤">&lt;image></a>s,
	or else the function is invalid.</p>
   <div class="example" id="example-62664520">
    <a class="self-link" href="#example-62664520"></a> This code: 
<pre>ol { list-style: symbols("*" "\2020" "\2021" "\A7"); }</pre>
    <p>will produce lists that look like:</p>
<pre>*   One
†   Two
‡   Three
§   Four
**  Five
††  Six
‡‡  Seven
</pre>
    <p>On the other hand, specifying the system of counter, like so:</p>
<pre>ol { list-style: symbols(cyclic "*" "\2020" "\2021" "\A7"); }</pre>
    <p>will produce lists that look like:</p>
<pre>*   One
†   Two
‡   Three
§   Four
*   Five
†   Six
‡   Seven
</pre>
   </div>
   <p class="note" role="note"><span>Note:</span> the <a class="css" data-link-type="maybe" href="#funcdef-symbols" id="ref-for-funcdef-symbols④">symbols()</a> function only allows strings and images,
	while the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①⑤">symbols</a> descriptor of a <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④⓪">@counter-style</a> rule also allows identifiers.</p>
   <h2 class="heading settled" data-level="5" id="extending-css2"><span class="secno">5. </span><span class="content"> Extending <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-lists-3/#propdef-list-style-type" id="ref-for-propdef-list-style-type①">list-style-type</a>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counter" id="ref-for-funcdef-counter④">counter()</a>, and <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counters" id="ref-for-funcdef-counters②">counters()</a></span><a class="self-link" href="#extending-css2"></a></h2>
   <p>In CSS Level 2 <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a> the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-lists-3/#propdef-list-style-type" id="ref-for-propdef-list-style-type②">list-style-type</a> property and the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counter" id="ref-for-funcdef-counter⑤">counter()</a> and <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-lists-3/#funcdef-counters" id="ref-for-funcdef-counters③">counters()</a> notations
	accept various pre-defined keywords, each identifying a counter style.
	This module extends these features to take instead the <a class="production css" data-link-type="type" href="#typedef-counter-style" id="ref-for-typedef-counter-style" title="Expands to: cjk-ideographic | japanese-formal | japanese-informal | simp-chinese-formal | simp-chinese-informal | trad-chinese-formal | trad-chinese-informal">&lt;counter-style></a> type, defined below:</p>
<pre class="prod"><dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-counter-style">&lt;counter-style></dfn> = <a class="production" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name⑥" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one②⓪">|</a> <a class="production" data-link-type="function" href="#funcdef-symbols" id="ref-for-funcdef-symbols⑤">&lt;symbols()></a>;
</pre>
   <p>If a <a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name⑦" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> is used that does not refer to any existing counter style,
	it must act identically to the <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal⑧">decimal</a> counter style
	(but does not <em><a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value">compute</a></em> to <span class="css" id="ref-for-decimal⑨">decimal</span>).</p>
   <h2 class="heading settled" data-level="6" id="predefined-counters"><span class="secno">6. </span><span class="content"> Simple Predefined Counter Styles</span><a class="self-link" href="#predefined-counters"></a></h2>
   <p>The following stylesheet uses the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④①">@counter-style</a> rule
	to redefine all of the counter styles defined in CSS 2 and CSS 2.1.
	This stylesheet is normative—<wbr>UAs must include it in their UA stylesheet
	(or at least act as if these rules were defined at that level).</p>
   <h3 class="heading settled" data-level="6.1" id="simple-numeric"><span class="secno">6.1. </span><span class="content"> Numeric: <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal①⓪">decimal</a>, <a class="css" data-link-type="maybe" href="#decimal-leading-zero" id="ref-for-decimal-leading-zero">decimal-leading-zero</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-arabic-indic" id="ref-for-valdef-counter-style-name-arabic-indic">arabic-indic</a>, <a class="css" data-link-type="maybe" href="#armenian" id="ref-for-armenian">armenian</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-upper-armenian" id="ref-for-valdef-counter-style-name-upper-armenian">upper-armenian</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-lower-armenian" id="ref-for-valdef-counter-style-name-lower-armenian">lower-armenian</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-bengali" id="ref-for-valdef-counter-style-name-bengali">bengali</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-cambodian" id="ref-for-valdef-counter-style-name-cambodian">cambodian</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-khmer" id="ref-for-valdef-counter-style-name-khmer">khmer</a>, <a class="css" data-link-type="maybe" href="#cjk-decimal" id="ref-for-cjk-decimal">cjk-decimal</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-devanagari" id="ref-for-valdef-counter-style-name-devanagari">devanagari</a>, <a class="css" data-link-type="maybe" href="#georgian" id="ref-for-georgian">georgian</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-gujarati" id="ref-for-valdef-counter-style-name-gujarati">gujarati</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-gurmukhi" id="ref-for-valdef-counter-style-name-gurmukhi">gurmukhi</a>, <a class="css" data-link-type="maybe" href="#hebrew" id="ref-for-hebrew">hebrew</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-kannada" id="ref-for-valdef-counter-style-name-kannada">kannada</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-lao" id="ref-for-valdef-counter-style-name-lao">lao</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-malayalam" id="ref-for-valdef-counter-style-name-malayalam">malayalam</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-mongolian" id="ref-for-valdef-counter-style-name-mongolian">mongolian</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-myanmar" id="ref-for-valdef-counter-style-name-myanmar">myanmar</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-oriya" id="ref-for-valdef-counter-style-name-oriya">oriya</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-persian" id="ref-for-valdef-counter-style-name-persian">persian</a>, <a class="css" data-link-type="maybe" href="#lower-roman" id="ref-for-lower-roman">lower-roman</a>, <a class="css" data-link-type="maybe" href="#upper-roman" id="ref-for-upper-roman">upper-roman</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-tamil" id="ref-for-valdef-counter-style-name-tamil">tamil</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-telugu" id="ref-for-valdef-counter-style-name-telugu">telugu</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-thai" id="ref-for-valdef-counter-style-name-thai">thai</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-tibetan" id="ref-for-valdef-counter-style-name-tibetan">tibetan</a></span><a class="self-link" href="#simple-numeric"></a></h3>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="decimal">decimal</dfn> 
    <dd> Western decimal numbers
			(e.g., 1, 2, 3, ..., 98, 99, 100). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="decimal-leading-zero">decimal-leading-zero</dfn> 
    <dd> Decimal numbers padded by initial zeros
			(e.g., 01, 02, 03, ..., 98, 99, 100). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-arabic-indic">arabic-indic</dfn> 
    <dd> Arabic-indic numbering
			(e.g., ١‎, ٢‎, ٣‎, ٤‎, ..., ٩٨‎, ٩٩‎, ١٠٠‎). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="armenian">armenian</dfn> 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-upper-armenian">upper-armenian</dfn> 
    <dd> Traditional uppercase Armenian numbering
			(e.g., Ա, Բ, Գ, ..., ՂԸ, ՂԹ, Ճ). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-lower-armenian">lower-armenian</dfn> 
    <dd> Lowercase Armenian numbering
			(e.g., ա, բ, գ, ..., ղը, ղթ, ճ). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-bengali">bengali</dfn> 
    <dd> Bengali numbering
			(e.g., ১, ২, ৩, ..., ৯৮, ৯৯, ১০০). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-cambodian">cambodian</dfn> 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-khmer">khmer</dfn> 
    <dd> Cambodian/Khmer numbering
			(e.g., ១, ២, ៣, ..., ៩៨, ៩៩, ១០០). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="cjk-decimal">cjk-decimal</dfn> 
    <dd> Han decimal numbers
			(e.g., 一, 二, 三, ..., 九八, 九九, 一〇〇). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-devanagari">devanagari</dfn> 
    <dd> devanagari numbering
			(e.g., १, २, ३, ..., ९८, ९९, १००). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="georgian">georgian</dfn> 
    <dd> Traditional Georgian numbering
			(e.g., ა, ბ, გ, ..., ჟჱ, ჟთ, რ). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-gujarati">gujarati</dfn> 
    <dd> Gujarati numbering
			(e.g., ૧, ૨, ૩, ..., ૯૮, ૯૯, ૧૦૦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-gurmukhi">gurmukhi</dfn> 
    <dd> Gurmukhi numbering
			(e.g., ੧, ੨, ੩, ..., ੯੮, ੯੯, ੧੦੦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="hebrew">hebrew</dfn> 
    <dd> Traditional Hebrew numbering
			(e.g., א‎, ב‎, ג‎, ..., צח‎, צט‎, ק‎). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-kannada">kannada</dfn> 
    <dd> Kannada numbering
			(e.g., ೧, ೨, ೩, ..., ೯೮, ೯೯, ೧೦೦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-lao">lao</dfn> 
    <dd> Laotian numbering
			(e.g., ໑, ໒, ໓, ..., ໙໘, ໙໙, ໑໐໐). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-malayalam">malayalam</dfn> 
    <dd> Malayalam numbering
			(e.g., ൧, ൨, ൩, ..., ൯൮, ൯൯, ൧൦൦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-mongolian">mongolian</dfn> 
    <dd> Mongolian numbering
			(e.g., ᠑, ᠒, ᠓, ..., ᠙᠘, ᠙᠙, ᠑᠐᠐). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-myanmar">myanmar</dfn> 
    <dd> Myanmar (Burmese) numbering
			(e.g., ၁, ၂, ၃, ..., ၉၈, ၉၉, ၁၀၀). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-oriya">oriya</dfn> 
    <dd> Oriya numbering
			(e.g., ୧, ୨, ୩, ..., ୯୮, ୯୯, ୧୦୦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-persian">persian</dfn> 
    <dd> Persian numbering
			(e.g., ۱, ۲, ۳, ۴, ..., ۹۸, ۹۹, ۱۰۰). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="lower-roman">lower-roman</dfn> 
    <dd> Lowercase ASCII Roman numerals
			(e.g., i, ii, iii, ..., xcviii, xcix, c). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="upper-roman">upper-roman</dfn> 
    <dd> Uppercase ASCII Roman numerals
			(e.g., I, II, III, ..., XCVIII, XCIX, C). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-tamil">tamil</dfn> 
    <dd> Tamil numbering
			(e.g., ௧, ௨, ௩, ..., ௯௮, ௯௯, ௧௦௦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-telugu">telugu</dfn> 
    <dd> Telugu numbering
			(e.g., ౧, ౨, ౩, ..., ౯౮, ౯౯, ౧౦౦). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-thai">thai</dfn> 
    <dd> Thai (Siamese) numbering
			(e.g., ๑, ๒, ๓, ..., ๙๘, ๙๙, ๑๐๐). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-tibetan">tibetan</dfn> 
    <dd> Tibetan numbering
			(e.g., ༡, ༢, ༣, ..., ༩༨, ༩༩, ༡༠༠). 
   </dl>
   <p>The <a class="css" data-link-type="maybe" href="#decimal" id="ref-for-decimal①①">decimal</a> counter-style must not be overridable with a <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④②">@counter-style</a> rule,
	so that it is always available as the ultimate fallback style.</p>
   <p>The following stylesheet fragment provides the normative definition of these predefined counter styles:</p>
<pre class="stylesheet"><bdo dir="ltr">@counter-style decimal {
  system: numeric;
  symbols: '0' '1' '2' '3' '4' '5' '6' '7' '8' '9';
}

@counter-style decimal-leading-zero {
  system: extends decimal;
  pad: 2 '0';
}

@counter-style arabic-indic {
  system: numeric;
  symbols: "\660" "\661" "\662" "\663" "\664" "\665" "\666" "\667" "\668" "\669";
  /* ٠ ١ ٢ ٣ ٤ ٥ ٦ ٧ ٨ ٩ */
}

@counter-style armenian {
  system: additive;
  range: 1 9999;
  additive-symbols: 9000 \554, 8000 \553, 7000 \552, 6000 \551, 5000 \550, 4000 \54F, 3000 \54E, 2000 \54D, 1000 \54C, 900 \54B, 800 \54A, 700 \549, 600 \548, 500 \547, 400 \546, 300 \545, 200 \544, 100 \543, 90 \542, 80 \541, 70 \540, 60 \53F, 50 \53E, 40 \53D, 30 \53C, 20 \53B, 10 \53A, 9 \539, 8 \538, 7 \537, 6 \536, 5 \535, 4 \534, 3 \533, 2 \532, 1 \531;
  /* 9000 Ք, 8000 Փ, 7000 Ւ, 6000 Ց, 5000 Ր, 4000 Տ, 3000 Վ, 2000 Ս, 1000 Ռ, 900 Ջ, 800 Պ, 700 Չ, 600 Ո, 500 Շ, 400 Ն, 300 Յ, 200 Մ, 100 Ճ, 90 Ղ, 80 Ձ, 70 Հ, 60 Կ, 50 Ծ, 40 Խ, 30 Լ, 20 Ի, 10 Ժ, 9 Թ, 8 Ը, 7 Է, 6 Զ, 5 Ե, 4 Դ, 3 Գ, 2 Բ, 1 Ա */
}

@counter-style upper-armenian {
  system: extends armenian;
}

@counter-style lower-armenian {
  system: additive;
  range: 1 9999;
  additive-symbols: 9000 "\584", 8000 "\583", 7000 "\582", 6000 "\581", 5000 "\580", 4000 "\57F", 3000 "\57E", 2000 "\57D", 1000 "\57C", 900 "\57B", 800 "\57A", 700 "\579", 600 "\578", 500 "\577", 400 "\576", 300 "\575", 200 "\574", 100 "\573", 90 "\572", 80 "\571", 70 "\570", 60 "\56F", 50 "\56E", 40 "\56D", 30 "\56C", 20 "\56B", 10 "\56A", 9 "\569", 8 "\568", 7 "\567", 6 "\566", 5 "\565", 4 "\564", 3 "\563", 2 "\562", 1 "\561";
  /* 9000 ք, 8000 փ, 7000 ւ, 6000 ց, 5000 ր, 4000 տ, 3000 վ, 2000 ս, 1000 ռ, 900 ջ, 800 պ, 700 չ, 600 ո, 500 շ, 400 ն, 300 յ, 200 մ, 100 ճ, 90 ղ, 80 ձ, 70 հ, 60 կ, 50 ծ, 40 խ, 30 լ, 20 ի, 10 ժ, 9 թ, 8 ը, 7 է, 6 զ, 5 ե, 4 դ, 3 գ, 2 բ, 1 ա */
}

@counter-style bengali {
  system: numeric;
  symbols: "\9E6" "\9E7" "\9E8" "\9E9" "\9EA" "\9EB" "\9EC" "\9ED" "\9EE" "\9EF";
  /* ০ ১ ২ ৩ ৪ ৫ ৬ ৭ ৮ ৯ */
}

@counter-style cambodian {
  system: numeric;
  symbols: "\17E0" "\17E1" "\17E2" "\17E3" "\17E4" "\17E5" "\17E6" "\17E7" "\17E8" "\17E9";
  /* ០ ១ ២ ៣ ៤ ៥ ៦ ៧ ៨ ៩ */
}

@counter-style khmer {
  system: extends cambodian;
}

@counter-style cjk-decimal {
  system: numeric;
  range: 0 infinite;
  symbols: \3007  \4E00  \4E8C  \4E09  \56DB  \4E94  \516D  \4E03  \516B  \4E5D;
  /* 〇 一 二 三 四 五 六 七 八 九 */
  suffix: "\3001";
  /* "、" */
}

@counter-style devanagari {
  system: numeric;
  symbols: "\966" "\967" "\968" "\969" "\96A" "\96B" "\96C" "\96D" "\96E" "\96F";
  /* ० १ २ ३ ४ ५ ६ ७ ८ ९ */
}

@counter-style georgian {
  system: additive;
  range: 1 19999;
  additive-symbols: 10000 \10F5, 9000 \10F0, 8000 \10EF, 7000 \10F4, 6000 \10EE, 5000 \10ED, 4000 \10EC, 3000 \10EB, 2000 \10EA, 1000 \10E9, 900 \10E8, 800 \10E7, 700 \10E6, 600 \10E5, 500 \10E4, 400 \10F3, 300 \10E2, 200 \10E1, 100 \10E0, 90 \10DF, 80 \10DE, 70 \10DD, 60 \10F2, 50 \10DC, 40 \10DB, 30 \10DA, 20 \10D9, 10 \10D8, 9 \10D7, 8 \10F1, 7 \10D6, 6 \10D5, 5 \10D4, 4 \10D3, 3 \10D2, 2 \10D1, 1 \10D0;
  /* 10000 ჵ, 9000 ჰ, 8000 ჯ, 7000 ჴ, 6000 ხ, 5000 ჭ, 4000 წ, 3000 ძ, 2000 ც, 1000 ჩ, 900 შ, 800 ყ, 700 ღ, 600 ქ, 500 ფ, 400 ჳ, 300 ტ, 200 ს, 100 რ, 90 ჟ, 80 პ, 70 ო, 60 ჲ, 50 ნ, 40 მ, 30 ლ, 20 კ, 10 ი, 9 თ, 8 ჱ, 7 ზ, 6 ვ, 5 ე, 4 დ, 3 გ, 2 ბ, 1 ა */
}

@counter-style gujarati {
  system: numeric;
  symbols: "\AE6" "\AE7" "\AE8" "\AE9" "\AEA" "\AEB" "\AEC" "\AED" "\AEE" "\AEF";
  /* ૦ ૧ ૨ ૩ ૪ ૫ ૬ ૭ ૮ ૯ */
}

@counter-style gurmukhi {
  system: numeric;
  symbols: "\A66" "\A67" "\A68" "\A69" "\A6A" "\A6B" "\A6C" "\A6D" "\A6E" "\A6F";
  /* ੦ ੧ ੨ ੩ ੪ ੫ ੬ ੭ ੮ ੯ */
}

@counter-style hebrew {
  system: additive;
  range: 1 10999;
  additive-symbols: 10000 \5D9\5F3, 9000 \5D8\5F3, 8000 \5D7\5F3, 7000 \5D6\5F3, 6000 \5D5\5F3, 5000 \5D4\5F3, 4000 \5D3\5F3, 3000 \5D2\5F3, 2000 \5D1\5F3, 1000 \5D0\5F3, 400 \5EA, 300 \5E9, 200 \5E8, 100 \5E7, 90 \5E6, 80 \5E4, 70 \5E2, 60 \5E1, 50 \5E0, 40 \5DE, 30 \5DC, 20 \5DB, 19 \5D9\5D8, 18 \5D9\5D7, 17 \5D9\5D6, 16 \5D8\5D6, 15 \5D8\5D5, 10 \5D9, 9 \5D8, 8 \5D7, 7 \5D6, 6 \5D5, 5 \5D4, 4 \5D3, 3 \5D2, 2 \5D1, 1 \5D0;
  /* 10000 י׳, 9000 ט׳, 8000 ח׳, 7000 ז׳, 6000 ו׳, 5000 ה׳, 4000 ד׳, 3000 ג׳, 2000 ב׳, 1000 א׳, 400 ת, 300 ש, 200 ר, 100 ק, 90 צ, 80 פ, 70 ע, 60 ס, 50 נ, 40 מ, 30 ל, 20 כ, 19 יט, 18 יח, 17 יז, 16 טז, 15 טו, 10 י, 9 ט, 8 ח, 7 ז, 6 ו, 5 ה, 4 ד, 3 ג, 2 ב, 1 א */
  /* This system manually specifies the values for 19-15 to force the correct display of 15 and 16, which are commonly rewritten to avoid a close resemblance to the Tetragrammaton. */
  /* Implementations MAY choose to implement this manually to a higher range; see note below. */
}

@counter-style kannada {
  system: numeric;
  symbols: "\CE6" "\CE7" "\CE8" "\CE9" "\CEA" "\CEB" "\CEC" "\CED" "\CEE" "\CEF";
  /* ೦ ೧ ೨ ೩ ೪ ೫ ೬ ೭ ೮ ೯ */
}

@counter-style lao {
  system: numeric;
  symbols: "\ED0" "\ED1" "\ED2" "\ED3" "\ED4" "\ED5" "\ED6" "\ED7" "\ED8" "\ED9";
  /* ໐ ໑ ໒ ໓ ໔ ໕ ໖ ໗ ໘ ໙ */
}

@counter-style malayalam {
  system: numeric;
  symbols: "\D66" "\D67" "\D68" "\D69" "\D6A" "\D6B" "\D6C" "\D6D" "\D6E" "\D6F";
  /* ൦ ൧ ൨ ൩ ൪ ൫ ൬ ൭ ൮ ൯ */
}

@counter-style mongolian {
  system: numeric;
  symbols: "\1810" "\1811" "\1812" "\1813" "\1814" "\1815" "\1816" "\1817" "\1818" "\1819";
  /* ᠐ ᠑ ᠒ ᠓ ᠔ ᠕ ᠖ ᠗ ᠘ ᠙ */
}

@counter-style myanmar {
  system: numeric;
  symbols: "\1040" "\1041" "\1042" "\1043" "\1044" "\1045" "\1046" "\1047" "\1048" "\1049";
  /* ၀ ၁ ၂ ၃ ၄ ၅ ၆ ၇ ၈ ၉ */
}

@counter-style oriya {
  system: numeric;
  symbols: "\B66" "\B67" "\B68" "\B69" "\B6A" "\B6B" "\B6C" "\B6D" "\B6E" "\B6F";
  /* ୦ ୧ ୨ ୩ ୪ ୫ ୬ ୭ ୮ ୯ */
}

@counter-style persian {
  system: numeric;
  symbols: "\6F0" "\6F1" "\6F2" "\6F3" "\6F4" "\6F5" "\6F6" "\6F7" "\6F8" "\6F9";
  /* ۰ ۱ ۲ ۳ ۴ ۵ ۶ ۷ ۸ ۹ */
}

@counter-style lower-roman {
  system: additive;
  range: 1 3999;
  additive-symbols: 1000 m, 900 cm, 500 d, 400 cd, 100 c, 90 xc, 50 l, 40 xl, 10 x, 9 ix, 5 v, 4 iv, 1 i;
}

@counter-style upper-roman {
  system: additive;
  range: 1 3999;
  additive-symbols: 1000 M, 900 CM, 500 D, 400 CD, 100 C, 90 XC, 50 L, 40 XL, 10 X, 9 IX, 5 V, 4 IV, 1 I;
}

@counter-style tamil {
  system: numeric;
  symbols: "\BE6" "\BE7" "\BE8" "\BE9" "\BEA" "\BEB" "\BEC" "\BED" "\BEE" "\BEF";
  /* ௦ ௧ ௨ ௩ ௪ ௫ ௬ ௭ ௮ ௯ */
}

@counter-style telugu {
  system: numeric;
  symbols: "\C66" "\C67" "\C68" "\C69" "\C6A" "\C6B" "\C6C" "\C6D" "\C6E" "\C6F";
  /* ౦ ౧ ౨ ౩ ౪ ౫ ౬ ౭ ౮ ౯ */
}

@counter-style thai {
  system: numeric;
  symbols: "\E50" "\E51" "\E52" "\E53" "\E54" "\E55" "\E56" "\E57" "\E58" "\E59";
  /* ๐ ๑ ๒ ๓ ๔ ๕ ๖ ๗ ๘ ๙ */
}

@counter-style tibetan {
  system: numeric;
  symbols: "\F20" "\F21" "\F22" "\F23" "\F24" "\F25" "\F26" "\F27" "\F28" "\F29";
  /* ༠ ༡ ༢ ༣ ༤ ༥ ༦ ༧ ༨ ༩ */
}
</bdo></pre>
   <p>Implementations must implement <a class="css" data-link-type="maybe" href="#hebrew" id="ref-for-hebrew①">hebrew</a> at least to the range specified in the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④③">@counter-style</a> rule above,
	but may implement it to a higher range.
	If they do so,
	the corresponding <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range④">range</a> descriptor must reflect the implemented range.</p>
   <h3 class="heading settled" data-level="6.2" id="simple-alphabetic"><span class="secno">6.2. </span><span class="content"> Alphabetic: <a class="css" data-link-type="maybe" href="#lower-alpha" id="ref-for-lower-alpha①">lower-alpha</a>, <a class="css" data-link-type="maybe" href="#lower-latin" id="ref-for-lower-latin①">lower-latin</a>, <a class="css" data-link-type="maybe" href="#upper-alpha" id="ref-for-upper-alpha④">upper-alpha</a>, <a class="css" data-link-type="maybe" href="#upper-latin" id="ref-for-upper-latin①">upper-latin</a>, <a class="css" data-link-type="maybe" href="#lower-greek" id="ref-for-lower-greek①">lower-greek</a>, <a class="css" data-link-type="maybe" href="#hiragana" id="ref-for-hiragana">hiragana</a>, <a class="css" data-link-type="maybe" href="#hiragana-iroha" id="ref-for-hiragana-iroha">hiragana-iroha</a>, <a class="css" data-link-type="maybe" href="#katakana" id="ref-for-katakana">katakana</a>, <a class="css" data-link-type="maybe" href="#katakana-iroha" id="ref-for-katakana-iroha">katakana-iroha</a></span><a class="self-link" href="#simple-alphabetic"></a></h3>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="lower-alpha">lower-alpha</dfn> 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="lower-latin">lower-latin</dfn> 
    <dd> Lowercase ASCII letters
			(e.g., a, b, c, ..., z, aa, ab). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="upper-alpha">upper-alpha</dfn> 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="upper-latin">upper-latin</dfn> 
    <dd> Uppercase ASCII letters
			(e.g., A, B, C, ..., Z, AA, AB). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="lower-greek">lower-greek</dfn> 
    <dd> Lowercase classical Greek
			(e.g., α, β, γ, ..., ω, αα, αβ). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="hiragana">hiragana</dfn> 
    <dd> Dictionary-order hiragana lettering
			(e.g., あ, い, う, ..., ん, ああ, あい). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="hiragana-iroha">hiragana-iroha</dfn> 
    <dd> Iroha-order hiragana lettering
			(e.g., い, ろ, は, ..., す, いい, いろ). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="katakana">katakana</dfn> 
    <dd> Dictionary-order katakana lettering
			(e.g., ア, イ, ウ, ..., ン, アア, アイ). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="katakana-iroha">katakana-iroha</dfn> 
    <dd> Iroha-order katakana lettering
			(e.g., イ, ロ, ハ, ..., ス, イイ, イロ) 
   </dl>
   <p>The following stylesheet fragment provides the normative definition of these predefined counter styles:</p>
<pre class="stylesheet"><bdo dir="ltr">@counter-style lower-alpha {
  system: alphabetic;
  symbols: a b c d e f g h i j k l m n o p q r s t u v w x y z;
}

@counter-style lower-latin {
  system: extends lower-alpha;
}

@counter-style upper-alpha {
  system: alphabetic;
  symbols: A B C D E F G H I J K L M N O P Q R S T U V W X Y Z;
}

@counter-style upper-latin {
  system: extends upper-alpha;
}

@counter-style lower-greek {
  system: alphabetic;
  symbols: "\3B1" "\3B2" "\3B3" "\3B4" "\3B5" "\3B6" "\3B7" "\3B8" "\3B9" "\3BA" "\3BB" "\3BC" "\3BD" "\3BE" "\3BF" "\3C0" "\3C1" "\3C3" "\3C4" "\3C5" "\3C6" "\3C7" "\3C8" "\3C9";
  /* α β γ δ ε ζ η θ ι κ λ μ ν ξ ο π ρ σ τ υ φ χ ψ ω */
}

@counter-style hiragana {
  system: alphabetic;
  symbols: "\3042" "\3044" "\3046" "\3048" "\304A" "\304B" "\304D" "\304F" "\3051" "\3053" "\3055" "\3057" "\3059" "\305B" "\305D" "\305F" "\3061" "\3064" "\3066" "\3068" "\306A" "\306B" "\306C" "\306D" "\306E" "\306F" "\3072" "\3075" "\3078" "\307B" "\307E" "\307F" "\3080" "\3081" "\3082" "\3084" "\3086" "\3088" "\3089" "\308A" "\308B" "\308C" "\308D" "\308F" "\3090" "\3091" "\3092" "\3093";
  /* あ い う え お か き く け こ さ し す せ そ た ち つ て と な に ぬ ね の は ひ ふ へ ほ ま み む め も や ゆ よ ら り る れ ろ わ ゐ ゑ を ん */
  suffix: "、";
}

@counter-style hiragana-iroha {
  system: alphabetic;
  symbols: "\3044" "\308D" "\306F" "\306B" "\307B" "\3078" "\3068" "\3061" "\308A" "\306C" "\308B" "\3092" "\308F" "\304B" "\3088" "\305F" "\308C" "\305D" "\3064" "\306D" "\306A" "\3089" "\3080" "\3046" "\3090" "\306E" "\304A" "\304F" "\3084" "\307E" "\3051" "\3075" "\3053" "\3048" "\3066" "\3042" "\3055" "\304D" "\3086" "\3081" "\307F" "\3057" "\3091" "\3072" "\3082" "\305B" "\3059";
  /* い ろ は に ほ へ と ち り ぬ る を わ か よ た れ そ つ ね な ら む う ゐ の お く や ま け ふ こ え て あ さ き ゆ め み し ゑ ひ も せ す */
  suffix: "、";
}

@counter-style katakana {
  system: alphabetic;
  symbols: "\30A2" "\30A4" "\30A6" "\30A8" "\30AA" "\30AB" "\30AD" "\30AF" "\30B1" "\30B3" "\30B5" "\30B7" "\30B9" "\30BB" "\30BD" "\30BF" "\30C1" "\30C4" "\30C6" "\30C8" "\30CA" "\30CB" "\30CC" "\30CD" "\30CE" "\30CF" "\30D2" "\30D5" "\30D8" "\30DB" "\30DE" "\30DF" "\30E0" "\30E1" "\30E2" "\30E4" "\30E6" "\30E8" "\30E9" "\30EA" "\30EB" "\30EC" "\30ED" "\30EF" "\30F0" "\30F1" "\30F2" "\30F3";
  /* ア イ ウ エ オ カ キ ク ケ コ サ シ ス セ ソ タ チ ツ テ ト ナ ニ ヌ ネ ノ ハ ヒ フ ヘ ホ マ ミ ム メ モ ヤ ユ ヨ ラ リ ル レ ロ ワ ヰ ヱ ヲ ン */
  suffix: "、";
}

@counter-style katakana-iroha {
  system: alphabetic;
  symbols: "\30A4" "\30ED" "\30CF" "\30CB" "\30DB" "\30D8" "\30C8" "\30C1" "\30EA" "\30CC" "\30EB" "\30F2" "\30EF" "\30AB" "\30E8" "\30BF" "\30EC" "\30BD" "\30C4" "\30CD" "\30CA" "\30E9" "\30E0" "\30A6" "\30F0" "\30CE" "\30AA" "\30AF" "\30E4" "\30DE" "\30B1" "\30D5" "\30B3" "\30A8" "\30C6" "\30A2" "\30B5" "\30AD" "\30E6" "\30E1" "\30DF" "\30B7" "\30F1" "\30D2" "\30E2" "\30BB" "\30B9";
  /* イ ロ ハ ニ ホ ヘ ト チ リ ヌ ル ヲ ワ カ ヨ タ レ ソ ツ ネ ナ ラ ム ウ ヰ ノ オ ク ヤ マ ケ フ コ エ テ ア サ キ ユ メ ミ シ ヱ ヒ モ セ ス */
  suffix: "、";
}
</bdo></pre>
   <h3 class="heading settled" data-level="6.3" id="simple-symbolic"><span class="secno">6.3. </span><span class="content"> Symbolic: <a class="css" data-link-type="maybe" href="#disc" id="ref-for-disc">disc</a>, <a class="css" data-link-type="maybe" href="#circle" id="ref-for-circle">circle</a>, <a class="css" data-link-type="maybe" href="#square" id="ref-for-square">square</a>, <a class="css" data-link-type="maybe" href="#disclosure-open" id="ref-for-disclosure-open">disclosure-open</a>, <a class="css" data-link-type="maybe" href="#disclosure-closed" id="ref-for-disclosure-closed">disclosure-closed</a></span><a class="self-link" href="#simple-symbolic"></a></h3>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="disc">disc</dfn> 
    <dd>A filled circle, similar to • U+2022 BULLET. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="circle">circle</dfn> 
    <dd>A hollow circle, similar to ◦ U+25E6 WHITE BULLET. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="square">square</dfn> 
    <dd>A filled square, similar to ◾ U+25FE BLACK MEDIUM SMALL SQUARE. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="disclosure-open">disclosure-open</dfn> 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="disclosure-closed">disclosure-closed</dfn> 
    <dd> Symbols appropriate for indicating an open or closed disclosure widget,
			such as the HTML <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-details-element" id="ref-for-the-details-element">details</a></code> element. 
   </dl>
   <p>The <a class="css" data-link-type="maybe" href="#disc" id="ref-for-disc①">disc</a> counter-style must not be overridable with a <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④④">@counter-style</a> rule,
	so that the initial value of <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-lists-3/#propdef-list-style-type" id="ref-for-propdef-list-style-type③">list-style-type</a> is well-known to the User Agent.</p>
   <p>The following stylesheet fragment provides the normative definition of these predefined counter styles:</p>
<pre class="stylesheet">@counter-style disc {
  system: cyclic;
  symbols: \2022;
  /* • */
  suffix: " ";
}

@counter-style circle {
  system: cyclic;
  symbols: \25E6;
  /* ◦ */
  suffix: " ";
}

@counter-style square {
  system: cyclic;
  symbols: \25FE;
  /* ◾ */
  suffix: " ";
}

@counter-style disclosure-open {
  system: cyclic;
  suffix: " ";
  /* for symbols, see normative text below */
}

@counter-style disclosure-closed {
  system: cyclic;
  suffix: " ";
  /* for symbols, see normative text below */
}
</pre>
   <p>Alternately, a browser may render these styles using a browser-generated image instead of the defined character.
	If so, the image must look similar to the character,
	and must be sized to attractively fill a 1em by 1em square.</p>
   <p>For the <a class="css" data-link-type="maybe" href="#disclosure-open" id="ref-for-disclosure-open①">disclosure-open</a> and <a class="css" data-link-type="maybe" href="#disclosure-closed" id="ref-for-disclosure-closed①">disclosure-closed</a> counter styles,
	the marker must be an image or character suitable for indicating
	the open and closed states of a disclosure widget,
	such as HTML’s <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-details-element" id="ref-for-the-details-element①">details</a></code> element.
	If the image is directional,
	it must respond to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#writing-mode" id="ref-for-writing-mode">writing mode</a> of the element,
	similar to the <a href="https://drafts.csswg.org/css4-images/#bidi-images">bidi-sensitive images</a> feature of the Images 4 module.
	For example, the <span class="css" id="ref-for-disclosure-closed②">disclosure-closed</span> style might use the characters
	U+25B8 BLACK RIGHT-POINTING SMALL TRIANGLE (▸)
	and U+25C2 BLACK LEFT-POINTING SMALL TRIANGLE (◂),
	while the <span class="css" id="ref-for-disclosure-open②">disclosure-open</span> style might use the character
	U+25BE BLACK DOWN-POINTING SMALL TRIANGLE (▾).</p>
   <h3 class="heading settled" data-level="6.4" id="simple-fixed"><span class="secno">6.4. </span><span class="content"> Fixed: <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-cjk-earthly-branch" id="ref-for-valdef-counter-style-name-cjk-earthly-branch">cjk-earthly-branch</a>, <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-cjk-heavenly-stem" id="ref-for-valdef-counter-style-name-cjk-heavenly-stem">cjk-heavenly-stem</a></span><a class="self-link" href="#simple-fixed"></a></h3>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-cjk-earthly-branch">cjk-earthly-branch</dfn> 
    <dd> Han "Earthly Branch" ordinals
			(e.g., 子, 丑, 寅, ..., 亥). 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-cjk-heavenly-stem">cjk-heavenly-stem</dfn> 
    <dd> Han "Heavenly Stem" ordinals
			(e.g., 甲, 乙, 丙, ..., 癸) 
   </dl>
   <p>The following stylesheet fragment provides the normative definition of these predefined counter styles:</p>
<pre class="stylesheet"><bdo dir="ltr">@counter-style cjk-earthly-branch {
  system: fixed;
  symbols: "\5B50" "\4E11" "\5BC5" "\536F" "\8FB0" "\5DF3" "\5348" "\672A" "\7533" "\9149" "\620C" "\4EA5";
  /* 子 丑 寅 卯 辰 巳 午 未 申 酉 戌 亥 */
  suffix: "、";
}

@counter-style cjk-heavenly-stem {
  system: fixed;
  symbols: "\7532" "\4E59" "\4E19" "\4E01" "\620A" "\5DF1" "\5E9A" "\8F9B" "\58EC" "\7678";
  /* 甲 乙 丙 丁 戊 己 庚 辛 壬 癸 */
  suffix: "、";
}
</bdo></pre>
   <h2 class="heading settled" data-level="7" id="complex-predefined-counters"><span class="secno">7. </span><span class="content"> Complex Predefined Counter Styles</span><a class="self-link" href="#complex-predefined-counters"></a></h2>
   <p>While authors may define their own counter styles using the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④⑤">@counter-style</a> rule
	or rely on the set of predefined counter styles,
	a few counter styles are described by rules that are too complex to be captured by the predefined algorithms.
	These counter styles are described in this section.</p>
   <p>Some of the counter styles specified in this section
	have custom algorithms for generating counter values,
	but are otherwise identical to a counter style defined via the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④⑥">@counter-style</a> rule.
	For example, an author can reference one of these styles in an <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-extends" id="ref-for-valdef-counter-style-system-extends⑦">extends</a> system,
	reusing the algorithm but swapping out some of the other descriptors.</p>
   <p>All of the counter styles defined in this section have a <a class="css" data-link-type="descriptor" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as⑤">spoken form</a> of <a class="css" data-link-type="maybe" href="#valdef-counter-style-speak-as-numbers" id="ref-for-valdef-counter-style-speak-as-numbers②">numbers</a>,
	and <a data-link-type="dfn" href="#use-a-negative-sign" id="ref-for-use-a-negative-sign⑤">use a negative sign</a>.</p>
   <h3 class="heading settled" data-level="7.1" id="complex-cjk"><span class="secno">7.1. </span><span class="content"> Longhand East Asian Counter Styles</span><a class="self-link" href="#complex-cjk"></a></h3>
   <p>Chinese, Japanese, and Korean have counter styles
	which have a “longhand” nature,
	similar to “thirteen thousand one hundred and twenty-three” in English.
	Each has both formal and informal variants.
	The formal styles are typically used in financial and legal documents,
	as their characters are more difficult to alter into each other.</p>
   <div class="example" id="example-c1039050">
    <a class="self-link" href="#example-c1039050"></a> The following table shows examples of these styles, particularly some ways in which they differ. 
    <table class="data">
     <thead>
      <tr>
       <th>Counter Style 
       <th>0 
       <th>1 
       <th>2 
       <th>3 
       <th>10 
       <th>11 
       <th>99 
       <th>100 
       <th>101 
       <th>6001 
     <tbody>
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#japanese-informal" id="ref-for-japanese-informal">japanese-informal</a> 
       <td>〇 
       <td>一 
       <td>二 
       <td>三 
       <td>十 
       <td>十一 
       <td>九十九 
       <td>百 
       <td>百一 
       <td>六千一 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#japanese-formal" id="ref-for-japanese-formal">japanese-formal</a> 
       <td>零 
       <td>壱 
       <td>弐 
       <td>参 
       <td>壱拾 
       <td>壱拾壱 
       <td>九拾九 
       <td>壱百 
       <td>壱百壱 
       <td>六阡壱 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#korean-hangul-formal" id="ref-for-korean-hangul-formal">korean-hangul-formal</a> 
       <td>영 
       <td>일 
       <td>이 
       <td>삼 
       <td>일십 
       <td>일십일 
       <td>구십구 
       <td>일백 
       <td>일백일 
       <td>육천일 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#korean-hanja-informal" id="ref-for-korean-hanja-informal">korean-hanja-informal</a> 
       <td>零 
       <td>一 
       <td>二 
       <td>三 
       <td>十 
       <td>十一 
       <td>九十九 
       <td>百 
       <td>百一 
       <td>六千一 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#korean-hanja-formal" id="ref-for-korean-hanja-formal">korean-hanja-formal</a> 
       <td>零 
       <td>壹 
       <td>貳 
       <td>參 
       <td>壹拾 
       <td>壹拾壹 
       <td>九拾九 
       <td>壹百 
       <td>壹百壹 
       <td>六仟壹 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#simp-chinese-informal" id="ref-for-simp-chinese-informal">simp-chinese-informal</a> 
       <td>零 
       <td>一 
       <td>二 
       <td>三 
       <td>十 
       <td>十一 
       <td>九十九 
       <td>一百 
       <td>一百零一 
       <td>六千零一 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#simp-chinese-formal" id="ref-for-simp-chinese-formal">simp-chinese-formal</a> 
       <td>零 
       <td>壹 
       <td>贰 
       <td>叁 
       <td>壹拾 
       <td>壹拾壹 
       <td>玖拾玖 
       <td>壹佰 
       <td>壹佰零壹 
       <td>陆仟零壹 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#trad-chinese-informal" id="ref-for-trad-chinese-informal">trad-chinese-informal</a> 
       <td>零 
       <td>一 
       <td>二 
       <td>三 
       <td>十 
       <td>十一 
       <td>九十九 
       <td>一百 
       <td>一百零一 
       <td>六千零一 
      <tr>
       <th scope="row"><a class="css" data-link-type="maybe" href="#trad-chinese-formal" id="ref-for-trad-chinese-formal">trad-chinese-formal</a> 
       <td>零 
       <td>壹 
       <td>貳 
       <td>參 
       <td>壹拾 
       <td>壹拾壹 
       <td>玖拾玖 
       <td>壹佰 
       <td>壹佰零壹 
       <td>陸仟零壹 
    </table>
   </div>
   <p>Because opinions differ on how best to represent numbers 10k or greater
	using the longhand CJK styles,
	all of the counter styles defined in this section are defined to have a range of -9999 to 9999,
	but implementations may support a larger range.
	Outside the implementation-supported range,
	the fallback is <a class="css" data-link-type="maybe" href="#cjk-decimal" id="ref-for-cjk-decimal①">cjk-decimal</a>.</p>
   <p class="note" role="note"><span>Note:</span> Implementations are encouraged to research and implement counter representations beyond 10k
	and report back to the CSS Working Group with data
	when a generally-accepted answer is discovered.
	Some previous research on this topic is contained in an <a href="https://www.w3.org/TR/2013/WD-css-counter-styles-3-20130718/#extended-cjk">earlier draft</a>.</p>
   <h4 class="heading settled" data-level="7.1.1" id="limited-japanese"><span class="secno">7.1.1. </span><span class="content"> Japanese: <a class="css" data-link-type="maybe" href="#japanese-informal" id="ref-for-japanese-informal①">japanese-informal</a> and <a class="css" data-link-type="maybe" href="#japanese-formal" id="ref-for-japanese-formal①">japanese-formal</a></span><a class="self-link" href="#limited-japanese"></a></h4>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="japanese-informal">japanese-informal</dfn> 
    <dd> Informal Japanese Kanji numbering
			(e.g., 千百十一) 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="japanese-formal">japanese-formal</dfn> 
    <dd> Formal Japanese Kanji numbering
			(e.g. 壱阡壱百壱拾壱) 
   </dl>
<pre class="stylesheet">@counter-style japanese-informal {
  system: additive;
  range: -9999 9999;
  additive-symbols: 9000 \4E5D\5343, 8000 \516B\5343, 7000 \4E03\5343, 6000 \516D\5343, 5000 \4E94\5343, 4000 \56DB\5343, 3000 \4E09\5343, 2000 \4E8C\5343, 1000 \5343, 900 \4E5D\767E, 800 \516B\767E, 700 \4E03\767E, 600 \516D\767E, 500 \4E94\767E, 400 \56DB\767E, 300 \4E09\767E, 200 \4E8C\767E, 100 \767E, 90 \4E5D\5341, 80 \516B\5341, 70 \4E03\5341, 60 \516D\5341, 50 \4E94\5341, 40 \56DB\5341, 30 \4E09\5341, 20 \4E8C\5341, 10 \5341, 9 \4E5D, 8 \516B, 7 \4E03, 6 \516D, 5 \4E94, 4 \56DB, 3 \4E09, 2 \4E8C, 1 \4E00, 0 \3007;
  /* 9000 九千, 8000 八千, 7000 七千, 6000 六千, 5000 五千, 4000 四千, 3000 三千, 2000 二千, 1000 千, 900 九百, 800 八百, 700 七百, 600 六百, 500 五百, 400 四百, 300 三百, 200 二百, 100 百, 90 九十, 80 八十, 70 七十, 60 六十, 50 五十, 40 四十, 30 三十, 20 二十, 10 十, 9 九, 8 八, 7 七, 6 六, 5 五, 4 四, 3 三, 2 二, 1 一, 0 〇 */
  suffix: '\3001';
  /* 、 */
  negative: "\30DE\30A4\30CA\30B9";
  /* マイナス */
  fallback: cjk-decimal;
}

@counter-style japanese-formal {
  system: additive;
  range: -9999 9999;
  additive-symbols: 9000 \4E5D\9621, 8000 \516B\9621, 7000 \4E03\9621, 6000 \516D\9621, 5000 \4F0D\9621, 4000 \56DB\9621, 3000 \53C2\9621, 2000 \5F10\9621, 1000 \58F1\9621, 900 \4E5D\767E, 800 \516B\767E, 700 \4E03\767E, 600 \516D\767E, 500 \4F0D\767E, 400 \56DB\767E, 300 \53C2\767E, 200 \5F10\767E, 100 \58F1\767E, 90 \4E5D\62FE, 80 \516B\62FE, 70 \4E03\62FE, 60 \516D\62FE, 50 \4F0D\62FE, 40 \56DB\62FE, 30 \53C2\62FE, 20 \5F10\62FE, 10 \58F1\62FE, 9 \4E5D, 8 \516B, 7 \4E03, 6 \516D, 5 \4F0D, 4 \56DB, 3 \53C2, 2 \5F10, 1 \58F1, 0 \96F6;
  /* 9000 九阡, 8000 八阡, 7000 七阡, 6000 六阡, 5000 伍阡, 4000 四阡, 3000 参阡, 2000 弐阡, 1000 壱阡, 900 九百, 800 八百, 700 七百, 600 六百, 500 伍百, 400 四百, 300 参百, 200 弐百, 100 壱百, 90 九拾, 80 八拾, 70 七拾, 60 六拾, 50 伍拾, 40 四拾, 30 参拾, 20 弐拾, 10 壱拾, 9 九, 8 八, 7 七, 6 六, 5 伍, 4 四, 3 参, 2 弐, 1 壱, 0 零 */
  suffix: '\3001';
  /* 、 */
  negative: "\30DE\30A4\30CA\30B9";
  /* マイナス */
  fallback: cjk-decimal;
}
</pre>
   <h4 class="heading settled" data-level="7.1.2" id="limited-korean"><span class="secno">7.1.2. </span><span class="content"> Korean: <a class="css" data-link-type="maybe" href="#korean-hangul-formal" id="ref-for-korean-hangul-formal①">korean-hangul-formal</a>, <a class="css" data-link-type="maybe" href="#korean-hanja-informal" id="ref-for-korean-hanja-informal①">korean-hanja-informal</a>, and <a class="css" data-link-type="maybe" href="#korean-hanja-formal" id="ref-for-korean-hanja-formal①">korean-hanja-formal</a></span><a class="self-link" href="#limited-korean"></a></h4>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="korean-hangul-formal">korean-hangul-formal</dfn> 
    <dd> Korean Hangul numbering
			(e.g., 일천일백일십일) 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="korean-hanja-informal">korean-hanja-informal</dfn> 
    <dd> Informal Korean Hanja numbering
			(e.g., 千百十一) 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="korean-hanja-formal">korean-hanja-formal</dfn> 
    <dd> Formal Korean Han (Hanja) numbering
			(e.g., 壹仟壹百壹拾壹) 
   </dl>
<pre class="stylesheet">@counter-style korean-hangul-formal {
  system: additive;
  range: -9999 9999;
  additive-symbols: 9000 \AD6C\CC9C, 8000 \D314\CC9C, 7000 \CE60\CC9C, 6000 \C721\CC9C, 5000 \C624\CC9C, 4000 \C0AC\CC9C, 3000 \C0BC\CC9C, 2000 \C774\CC9C, 1000 \C77C\CC9C, 900 \AD6C\BC31, 800 \D314\BC31, 700 \CE60\BC31, 600 \C721\BC31, 500 \C624\BC31, 400 \C0AC\BC31, 300 \C0BC\BC31, 200 \C774\BC31, 100 \C77C\BC31, 90 \AD6C\C2ED, 80 \D314\C2ED, 70 \CE60\C2ED, 60 \C721\C2ED, 50 \C624\C2ED, 40 \C0AC\C2ED, 30 \C0BC\C2ED, 20 \C774\C2ED, 10 \C77C\C2ED, 9 \AD6C, 8 \D314, 7 \CE60, 6 \C721, 5 \C624, 4 \C0AC, 3 \C0BC, 2 \C774, 1 \C77C, 0 \C601;
  /* 9000 구천, 8000 팔천, 7000 칠천, 6000 육천, 5000 오천, 4000 사천, 3000 삼천, 2000 이천, 1000 일천, 900 구백, 800 팔백, 700 칠백, 600 육백, 500 오백, 400 사백, 300 삼백, 200 이백, 100 일백, 90 구십, 80 팔십, 70 칠십, 60 육십, 50 오십, 40 사십, 30 삼십, 20 이십, 10 일십, 9 구, 8 팔, 7 칠, 6 육, 5 오, 4 사, 3 삼, 2 이, 1 일, 0 영 */
  suffix: ', ';
  negative: "\B9C8\C774\B108\C2A4  ";
  /* 마이너스 (followed by a space) */
}

@counter-style korean-hanja-informal {
  system: additive;
  range: -9999 9999;
  additive-symbols: 9000 \4E5D\5343, 8000 \516B\5343, 7000 \4E03\5343, 6000 \516D\5343, 5000 \4E94\5343, 4000 \56DB\5343, 3000 \4E09\5343, 2000 \4E8C\5343, 1000 \5343, 900 \4E5D\767E, 800 \516B\767E, 700 \4E03\767E, 600 \516D\767E, 500 \4E94\767E, 400 \56DB\767E, 300 \4E09\767E, 200 \4E8C\767E, 100 \767E, 90 \4E5D\5341, 80 \516B\5341, 70 \4E03\5341, 60 \516D\5341, 50 \4E94\5341, 40 \56DB\5341, 30 \4E09\5341, 20 \4E8C\5341, 10 \5341, 9 \4E5D, 8 \516B, 7 \4E03, 6 \516D, 5 \4E94, 4 \56DB, 3 \4E09, 2 \4E8C, 1 \4E00, 0 \96F6;
  /* 9000 九千, 8000 八千, 7000 七千, 6000 六千, 5000 五千, 4000 四千, 3000 三千, 2000 二千, 1000 千, 900 九百, 800 八百, 700 七百, 600 六百, 500 五百, 400 四百, 300 三百, 200 二百, 100 百, 90 九十, 80 八十, 70 七十, 60 六十, 50 五十, 40 四十, 30 三十, 20 二十, 10 十, 9 九, 8 八, 7 七, 6 六, 5 五, 4 四, 3 三, 2 二, 1 一, 0 零 */
  suffix: ', ';
  negative: "\B9C8\C774\B108\C2A4  ";
  /* 마이너스 (followed by a space) */
}

@counter-style korean-hanja-formal {
  system: additive;
  range: -9999 9999;
  additive-symbols: 9000 \4E5D\4EDF, 8000 \516B\4EDF, 7000 \4E03\4EDF, 6000 \516D\4EDF, 5000 \4E94\4EDF, 4000 \56DB\4EDF, 3000 \53C3\4EDF, 2000 \8CB3\4EDF, 1000 \58F9\4EDF, 900 \4E5D\767E, 800 \516B\767E, 700 \4E03\767E, 600 \516D\767E, 500 \4E94\767E, 400 \56DB\767E, 300 \53C3\767E, 200 \8CB3\767E, 100 \58F9\767E, 90 \4E5D\62FE, 80 \516B\62FE, 70 \4E03\62FE, 60 \516D\62FE, 50 \4E94\62FE, 40 \56DB\62FE, 30 \53C3\62FE, 20 \8CB3\62FE, 10 \58F9\62FE, 9 \4E5D, 8 \516B, 7 \4E03, 6 \516D, 5 \4E94, 4 \56DB, 3 \53C3, 2 \8CB3, 1 \58F9, 0 \96F6;
  /* 9000 九仟, 8000 八仟, 7000 七仟, 6000 六仟, 5000 五仟, 4000 四仟, 3000 參仟, 2000 貳仟, 1000 壹仟, 900 九百, 800 八百, 700 七百, 600 六百, 500 五百, 400 四百, 300 參百, 200 貳百, 100 壹百, 90 九拾, 80 八拾, 70 七拾, 60 六拾, 50 五拾, 40 四拾, 30 參拾, 20 貳拾, 10 壹拾, 9 九, 8 八, 7 七, 6 六, 5 五, 4 四, 3 參, 2 貳, 1 壹, 0 零 */
  suffix: ', ';
  negative: "\B9C8\C774\B108\C2A4  ";
  /* 마이너스 (followed by a space) */
}
</pre>
   <h4 class="heading settled" data-level="7.1.3" id="limited-chinese"><span class="secno">7.1.3. </span><span class="content"> Chinese: <a class="css" data-link-type="maybe" href="#simp-chinese-informal" id="ref-for-simp-chinese-informal①">simp-chinese-informal</a>, <a class="css" data-link-type="maybe" href="#simp-chinese-formal" id="ref-for-simp-chinese-formal①">simp-chinese-formal</a>, <a class="css" data-link-type="maybe" href="#trad-chinese-informal" id="ref-for-trad-chinese-informal①">trad-chinese-informal</a>, and <a class="css" data-link-type="maybe" href="#trad-chinese-formal" id="ref-for-trad-chinese-formal①">trad-chinese-formal</a></span><a class="self-link" href="#limited-chinese"></a></h4>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="simp-chinese-informal">simp-chinese-informal</dfn> 
    <dd> Simplified Chinese informal numbering
			(e.g., 一千一百一十一) 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="simp-chinese-formal">simp-chinese-formal</dfn> 
    <dd> Simplified Chinese formal numbering
			(e.g. 壹仟壹佰壹拾壹) 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="trad-chinese-informal">trad-chinese-informal</dfn> 
    <dd> Traditional Chinese informal numbering
			(e.g., 一千一百一十一) 
    <dt><dfn class="dfn-paneled css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="trad-chinese-formal">trad-chinese-formal</dfn> 
    <dd> Traditional Chinese formal numbering
			(e.g., 壹仟壹佰壹拾壹) 
    <dt><dfn class="css" data-dfn-for="<counter-style>" data-dfn-type="value" data-export id="cjk-ideographic">cjk-ideographic<a class="self-link" href="#cjk-ideographic"></a></dfn> 
    <dd> This counter style is identical to <a class="css" data-link-type="maybe" href="#trad-chinese-informal" id="ref-for-trad-chinese-informal②">trad-chinese-informal</a>.
			(It exists for legacy reasons.) 
   </dl>
   <p>The Chinese longhand styles are defined by almost identical algorithms
	(specified as a single algorithm here, with the differences called out when relevant),
	but use different sets of characters,
	as specified by the table following the algorithm.</p>
   <ol>
    <li>If the counter value is 0, the representation is the character for 0
		specified for the given counter style.  Skip the rest of this algorithm. 
    <li>Initially represent the counter value as a decimal number.  For each
		digit that is not 0, append the appropriate digit marker to the digit.
		The ones digit has no marker. 
    <li>For the informal styles, if the counter value is between ten and
		nineteen, remove the tens digit (leave the digit marker). 
    <li>Drop any trailing zeros and collapse any remaining zeros into a single
		zero digit. 
    <li>Replace the digits 0-9 with the appropriate character for the given
		counter style.  Return the resultant string as the representation of the
		counter value. 
   </ol>
   <p>For all of these counter styles, the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix④">suffix</a> is "、" U+3001,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback⑥">fallback</a> is <a class="css" data-link-type="maybe" href="#cjk-decimal" id="ref-for-cjk-decimal②">cjk-decimal</a>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range⑤">range</a> is <span class="css">-9999 9999</span>,
	and the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative⑥">negative</a> value is given in the table of symbols for each style.</p>
   <p>The following tables define the characters used in these styles:</p>
   <table class="data">
    <thead>
     <tr>
      <th rowspan="2" scope="col">Values 
      <th colspan="4" scope="col">Codepoints 
     <tr>
      <th>simp-chinese-informal 
      <th>simp-chinese-formal 
      <th>trad-chinese-informal 
      <th>trad-chinese-formal 
    <tbody>
     <tr>
      <th scope="row">Digit 0 
      <td>零 U+96F6 
      <td>零 U+96F6 
      <td>零 U+96F6 
      <td>零 U+96F6 
     <tr>
      <th scope="row">Digit 1 
      <td>一 U+4E00 
      <td>壹 U+58F9 
      <td>一 U+4E00 
      <td>壹 U+58F9 
     <tr>
      <th scope="row">Digit 2 
      <td>二 U+4E8C 
      <td>贰 U+8D30 
      <td>二 U+4E8C 
      <td>貳 U+8CB3 
     <tr>
      <th scope="row">Digit 3 
      <td>三 U+4E09 
      <td>叁 U+53C1 
      <td>三 U+4E09 
      <td>參 U+53C3 
     <tr>
      <th scope="row">Digit 4 
      <td>四 U+56DB 
      <td>肆 U+8086 
      <td>四 U+56DB 
      <td>肆 U+8086 
     <tr>
      <th scope="row">Digit 5 
      <td>五 U+4E94 
      <td>伍 U+4F0D 
      <td>五 U+4E94 
      <td>伍 U+4F0D 
     <tr>
      <th scope="row">Digit 6 
      <td>六 U+516D 
      <td>陆 U+9646 
      <td>六 U+516D 
      <td>陸 U+9678 
     <tr>
      <th scope="row">Digit 7 
      <td>七 U+4E03 
      <td>柒 U+67D2 
      <td>七 U+4E03 
      <td>柒 U+67D2 
     <tr>
      <th scope="row">Digit 8 
      <td>八 U+516B 
      <td>捌 U+634C 
      <td>八 U+516B 
      <td>捌 U+634C 
     <tr>
      <th scope="row">Digit 9 
      <td>九 U+4E5D 
      <td>玖 U+7396 
      <td>九 U+4E5D 
      <td>玖 U+7396 
     <tr>
      <th scope="row">Tens Digit Marker 
      <td>十 U+5341 
      <td>拾 U+62FE 
      <td>十 U+5341 
      <td>拾 U+62FE 
     <tr>
      <th scope="row">Hundreds Digit Marker 
      <td>百 U+767E 
      <td>佰 U+4F70 
      <td>百 U+767E 
      <td>佰 U+4F70 
     <tr>
      <th scope="row">Thousands Digit Marker 
      <td>千 U+5343 
      <td>仟 U+4EDF 
      <td>千 U+5343 
      <td>仟 U+4EDF 
     <tr>
      <th scope="row">Negative Sign 
      <td>负 U+8D1F 
      <td>负 U+8D1F 
      <td>負 U+8CA0 
      <td>負 U+8CA0 
   </table>
   <div class="note" role="note">
     For reference, here are the first 120 values for the <a class="css" data-link-type="maybe" href="#simp-chinese-informal" id="ref-for-simp-chinese-informal②">simp-chinese-informal</a> style: 
<pre> 1　　　　 一    41　　 四十一    81　　 八十一
 2　　　　 二    42　　 四十二    82　　 八十二
 3　　　　 三    43　　 四十三    83　　 八十三
 4　　　　 四    44　　 四十四    84　　 八十四
 5　　　　 五    45　　 四十五    85　　 八十五
 6　　　　 六    46　　 四十六    86　　 八十六
 7　　　　 七    47　　 四十七    87　　 八十七
 8　　　　 八    48　　 四十八    88　　 八十八
 9　　　　 九    49　　 四十九    89　　 八十九
10　　　　 十    50　　　 五十    90　　　 九十
11　　　 十一    51　　 五十一    91　　 九十一
12　　　 十二    52　　 五十二    92　　 九十二
13　　　 十三    53　　 五十三    93　　 九十三
14　　　 十四    54　　 五十四    94　　 九十四
15　　　 十五    55　　 五十五    95　　 九十五
16　　　 十六    56　　 五十六    96　　 九十六
17　　　 十七    57　　 五十七    97　　 九十七
18　　　 十八    58　　 五十八    98　　 九十八
19　　　 十九    59　　 五十九    99　　 九十九
20　　　 二十    60　　　 六十   100　　　 一百
21　　 二十一    61　　 六十一   101　 一百零一
22　　 二十二    62　　 六十二   102　 一百零二
23　　 二十三    63　　 六十三   103　 一百零三
24　　 二十四    64　　 六十四   104　 一百零四
25　　 二十五    65　　 六十五   105　 一百零五
26　　 二十六    66　　 六十六   106　 一百零六
27　　 二十七    67　　 六十七   107　 一百零七
28　　 二十八    68　　 六十八   108　 一百零八
29　　 二十九    69　　 六十九   109　 一百零九
30　　　 三十    70　　　 七十   110　 一百一十
31　　 三十一    71　　 七十一   111 一百一十一
32　　 三十二    72　　 七十二   112 一百一十二
33　　 三十三    73　　 七十三   113 一百一十三
34　　 三十四    74　　 七十四   114 一百一十四
35　　 三十五    75　　 七十五   115 一百一十五
36　　 三十六    76　　 七十六   116 一百一十六
37　　 三十七    77　　 七十七   117 一百一十七
38　　 三十八    78　　 七十八   118 一百一十八
39　　 三十九    79　　 七十九   119 一百一十九
40　　　 四十    80　　　 八十   120　 一百二十</pre>
   </div>
   <h3 class="heading settled" data-level="7.2" id="ethiopic-numeric-counter-style"><span class="secno">7.2. </span><span class="content"> Ethiopic Numeric Counter Style: <a class="css" data-link-type="maybe" href="#valdef-counter-style-name-ethiopic-numeric" id="ref-for-valdef-counter-style-name-ethiopic-numeric">ethiopic-numeric</a></span><a class="self-link" href="#ethiopic-numeric-counter-style"></a></h3>
   <p>The <dfn class="dfn-paneled css" data-dfn-for="<counter-style-name>" data-dfn-type="value" data-export id="valdef-counter-style-name-ethiopic-numeric">ethiopic-numeric</dfn> counter style is defined for all positive non-zero numbers.
	The following algorithm converts decimal digits to ethiopic numbers:</p>
   <ol>
    <li> If the number is 1,
			return "፩" (U+1369). 
    <li> Split the number into groups of two digits,
			starting with the least significant decimal digit. 
    <li> Index each group sequentially,
			starting from the least significant as group number zero. 
    <li> If the group has the value zero,
			or if the group is the most significant one and has the value 1,
			or if the group has an odd index (as given in the previous step) and has the value 1,
			then remove the digits
			(but leave the group, so it still has a separator appended below). 
    <li>
      For each remaining digit,
			substitute the relevant ethiopic character from the list below. 
     <table class="data">
      <thead>
       <tr>
        <th colspan="3">Tens 
        <th colspan="3">Units 
       <tr>
        <th>Values 
        <th colspan="2">Codepoints 
        <th>Values 
        <th colspan="2">Codepoints 
      <tbody>
       <tr>
        <td>10 
        <td>፲ 
        <td>U+1372 
        <td>1 
        <td>፩ 
        <td>U+1369 
       <tr>
        <td>20 
        <td>፳ 
        <td>U+1373 
        <td>2 
        <td>፪ 
        <td>U+136A 
       <tr>
        <td>30 
        <td>፴ 
        <td>U+1374 
        <td>3 
        <td>፫ 
        <td>U+136B 
       <tr>
        <td>40 
        <td>፵ 
        <td>U+1375 
        <td>4 
        <td>፬ 
        <td>U+136C 
       <tr>
        <td>50 
        <td>፶ 
        <td>U+1376 
        <td>5 
        <td>፭ 
        <td>U+136D 
       <tr>
        <td>60 
        <td>፷ 
        <td>U+1377 
        <td>6 
        <td>፮ 
        <td>U+136E 
       <tr>
        <td>70 
        <td>፸ 
        <td>U+1378 
        <td>7 
        <td>፯ 
        <td>U+136F 
       <tr>
        <td>80 
        <td>፹ 
        <td>U+1379 
        <td>8 
        <td>፰ 
        <td>U+1370 
       <tr>
        <td>90 
        <td>፺ 
        <td>U+137A 
        <td>9 
        <td>፱ 
        <td>U+1371 
     </table>
    <li> For each group with an odd index (as given in the second step),
			except groups which originally had a value of zero,
			append ፻ U+137B. 
    <li> For each group with an even index (as given in the second step),
			except the group with index 0,
			append ፼ U+137C. 
    <li> Concatenate the groups into one string,
			and return it. 
   </ol>
   <p>For this system, the name is "ethiopic-numeric",
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range⑥">range</a> is <span class="css">1 infinite</span>,
	the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix⑤">suffix</a> is <code>"/ "</code> (U+002F SOLIDUS followed by a U+0020 SPACE),
	and the rest of the descriptors have their initial value.</p>
   <div class="example" id="example-b515a2a9">
    <a class="self-link" href="#example-b515a2a9"></a> The decimal number 100, in ethiopic, is ፻ U+137B 
    <p>The decimal number 78010092, in ethiopic, is
		፸፰፻፩፼፺፪
		U+1378 U+1370 U+137B  U+1369 U+137C  U+137A U+136A.</p>
    <p>The decimal number 780100000092, in ethiopic, is
		፸፰፻፩፼፼፺፪
		U+1378 U+1370 U+137B  U+1369 U+137C  U+137C  U+137A U+136A.</p>
   </div>
   <h2 class="heading settled" data-level="8" id="additional-predefined"><span class="secno">8. </span><span class="content"> Additional Predefined Counter Styles</span><a class="self-link" href="#additional-predefined"></a></h2>
   <p>The Internationalization Working Group maintains a large list of predefined <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④⑦">@counter-style</a> rules for various world languages
	in their <a href="https://www.w3.org/TR/predefined-counter-styles/">Predefined Counter Styles</a> document. <a data-link-type="biblio" href="#biblio-predefined-counter-styles">[predefined-counter-styles]</a></p>
   <p>These additional counter styles are not intended to be supported by user-agents by default,
	but can be used by users or authors copying them directly into style sheets.</p>
   <h2 class="heading settled" data-level="9" id="apis"><span class="secno">9. </span><span class="content">APIs</span><a class="self-link" href="#apis"></a></h2>
   <h3 class="heading settled" data-level="9.1" id="extentions-to-cssrule-interface"><span class="secno">9.1. </span><span class="content"> Extensions to the <code>CSSRule</code> interface</span><a class="self-link" href="#extentions-to-cssrule-interface"></a></h3>
   <p>The <code>CSSRule</code> interface is extended as follows:</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-counter_style_rule"><code><c- g>COUNTER_STYLE_RULE</c-></code><a class="self-link" href="#dom-cssrule-counter_style_rule"></a></dfn> = 11;
};
</pre>
   <h3 class="heading settled" data-level="9.2" id="the-csscounterstylerule-interface"><span class="secno">9.2. </span><span class="content"> The <code>CSSCounterStyleRule</code> interface</span><a class="self-link" href="#the-csscounterstylerule-interface"></a></h3>
   <p>The <a class="idl-code" data-link-type="interface" href="#csscounterstylerule" id="ref-for-csscounterstylerule">CSSCounterStyleRule</a> interface represents a <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④⑧">@counter-style</a> rule.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="csscounterstylerule"><code><c- g>CSSCounterStyleRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule①"><c- n>CSSRule</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-name" id="ref-for-dom-csscounterstylerule-name"><c- g>name</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-system" id="ref-for-dom-csscounterstylerule-system"><c- g>system</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-symbols" id="ref-for-dom-csscounterstylerule-symbols"><c- g>symbols</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-additivesymbols" id="ref-for-dom-csscounterstylerule-additivesymbols"><c- g>additiveSymbols</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring④"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-negative" id="ref-for-dom-csscounterstylerule-negative"><c- g>negative</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑤"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-prefix" id="ref-for-dom-csscounterstylerule-prefix"><c- g>prefix</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑥"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-suffix" id="ref-for-dom-csscounterstylerule-suffix"><c- g>suffix</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑦"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-range" id="ref-for-dom-csscounterstylerule-range"><c- g>range</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑧"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-pad" id="ref-for-dom-csscounterstylerule-pad"><c- g>pad</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑨"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-speakas" id="ref-for-dom-csscounterstylerule-speakas"><c- g>speakAs</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⓪"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-fallback" id="ref-for-dom-csscounterstylerule-fallback"><c- g>fallback</c-></a>;
};
</pre>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-name"><code>name</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①①">CSSOMString</a></span>
    <dd>
      The <var>name</var> attribute on getting must return a <code>CSSOMString</code> object
			that contains the serialization of the <a class="production css" data-link-type="type" href="#typedef-counter-style-name" id="ref-for-typedef-counter-style-name⑧" title="Expands to: arabic-indic | armenian | bengali | cambodian | circle | cjk-decimal | cjk-earthly-branch | cjk-heavenly-stem | decimal | decimal-leading-zero | devanagari | disc | disclosure-closed | disclosure-open | ethiopic-numeric | georgian | gujarati | gurmukhi | hebrew | hiragana | hiragana-iroha | kannada | katakana | katakana-iroha | khmer | korean-hangul-formal | korean-hanja-formal | korean-hanja-informal | lao | lower-alpha | lower-armenian | lower-greek | lower-latin | lower-roman | malayalam | mongolian | myanmar | oriya | persian | square | tamil | telugu | thai | tibetan | upper-alpha | upper-armenian | upper-latin | upper-roman">&lt;counter-style-name></a> defined for the associated rule. 
     <p>On setting the <var>name</var> attribute, run the following steps:</p>
     <ol>
      <li data-md>
       <p>If the value is an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive②">ASCII case-insensitive</a> match
for any of the predefined <a data-link-type="dfn" href="#counter-style" id="ref-for-counter-style④">counter styles</a>,
lowercase it.</p>
      <li data-md>
       <p>If the value is not "decimal", "disc", or "none",
replace the associated rule’s name with an <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-3/#css-identifier" id="ref-for-css-identifier">identifier</a> equal to the value.</p>
      <li data-md>
       <p>Otherwise, do nothing.</p>
     </ol>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-system"><code>system</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①②">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-symbols"><code>symbols</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①③">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-additivesymbols"><code>additiveSymbols</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①④">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-negative"><code>negative</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑤">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-prefix"><code>prefix</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑥">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-suffix"><code>suffix</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑦">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-range"><code>range</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑧">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-pad"><code>pad</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑨">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-speakas"><code>speakAs</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⓪">CSSOMString</a></span>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSCounterStyleRule" data-dfn-type="attribute" data-export id="dom-csscounterstylerule-fallback"><code>fallback</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②①">CSSOMString</a></span>
    <dd>
      The remaining attributes on getting must return a <code>CSSOMString</code> object
			that contains the serialization of the associated descriptor defined for the associated rule.
			If the descriptor was not specified in the associated rule,
			the attribute must return an empty string. 
     <p>On setting, run the following steps:</p>
     <ol>
      <li data-md>
       <p><a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-component-values" id="ref-for-parse-a-list-of-component-values">Parse a list of component values</a> from the value.</p>
      <li data-md>
       <p>If the returned value is invalid according to the given descriptor’s grammar,
or would cause the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style④⑨">@counter-style</a> rule to become invalid,
do nothing and abort these steps.
(For example, some systems require the <a class="property" data-link-type="propdesc" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①⑥">symbols</a> descriptor to contain two values.)</p>
      <li data-md>
       <p>If the attribute being set is <a data-link-type="idl" href="#dom-csscounterstylerule-system" id="ref-for-dom-csscounterstylerule-system①">system</a>,
and the new value would change the algorithm used,
do nothing and abort these steps. <span class="note">It’s okay to change an aspect of the algorithm,
like the <a data-link-type="dfn" href="#first-symbol-value" id="ref-for-first-symbol-value④">first symbol value</a> of a <a class="css" data-link-type="maybe" href="#valdef-counter-style-system-fixed" id="ref-for-valdef-counter-style-system-fixed⑤">fixed</a> system.</span></p>
      <li data-md>
       <p>Set the descriptor to the value.</p>
     </ol>
   </dl>
   <h2 class="heading settled" data-level="10" id="ua-stylesheet"><span class="secno">10. </span><span class="content"> Sample style sheet for HTML</span><a class="self-link" href="#ua-stylesheet"></a></h2>
   <p>This section is informative, not normative.
	HTML itself defines the styles that apply to its elements,
	and in some cases defers to the user agent’s discretion.</p>
<pre>details > summary {
  display: list-item;
  list-style: disclosure-closed inside;
}

details[open] > summary {
  list-style: disclosure-open inside;
}
</pre>
   <h2 class="no-num heading settled" id="changes"><span class="content"> Changes</span><a class="self-link" href="#changes"></a></h2>
   <h3 class="heading settled" id="changes-jun-2015"><span class="content"> Changes since the Jun 2015 Candidate Recommendation</span><a class="self-link" href="#changes-jun-2015"></a></h3>
   <p>Significant changes since the <a href="https://www.w3.org/TR/2015/CR-css-counter-styles-3-20150611/">June 11 2015 CR</a> draft:</p>
   <ul>
    <li data-md>
     <p>Exclude "none" and "disc" from being the name of a counter style.</p>
    <li data-md>
     <p>When setting CSSCounterStyle.name, take the string directly; don’t <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar">parse</a> it as an ident.</p>
    <li data-md>
     <p>Clarify that counter styles are read out in the element’s <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#content-language" id="ref-for-content-language③">content language</a>.</p>
    <li data-md>
     <p>Clarified that <a class="property" data-link-type="propdesc" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols⑦">additive-symbols</a> tuples must be of <em>strictly</em> decreasing weight.</p>
    <li data-md>
     <p>Specified that invalid values just invalidate the declaration, not the whole rule.</p>
    <li data-md>
     <p><a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑤⓪">@counter-style</a> rules that are invalid due to missing descriptors just fail to create a <a data-link-type="dfn" href="#counter-style" id="ref-for-counter-style⑤">counter style</a>;
they’re otherwise still valid rules.</p>
    <li data-md>
     <p>Changed syntax to use <a data-link-type="dfn">bracketed range notation</a> to reflect
the prose restrictions on negative values.</p>
   </ul>
   <p>A <a href="https://drafts.csswg.org/css-counter-styles-3/issues-cr-20150611">Disposition of Comments</a> is available.</p>
   <h3 class="heading settled" id="changes-feb-2015"><span class="content"> Changes since the Feb 2015 Candidate Recommendation</span><a class="self-link" href="#changes-feb-2015"></a></h3>
   <ul>
    <li data-md>
     <p>Allowed UAs to extend the <a class="css" data-link-type="maybe" href="#hebrew" id="ref-for-hebrew②">hebrew</a> style past the spec-defined limits
(since the current limits are mostly just an artifact of how annoying it is to go higher with the <a class="css" data-link-type="maybe" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑤①">@counter-style</a>-based definition).</p>
   </ul>
   <h2 class="no-num heading settled" id="acknowledgments"><span class="content"> Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>The following people and documentation they wrote were very useful for defining the numbering systems:
	Alexander Savenkov,
	Arron Eicholz,
	Aryeh Gregor,
	Christopher Hoess,
	Daniel Yacob,
	Frank Tang,
	Jonathan Rosenne,
	Karl Ove Hufthammer,
	Musheg Arakelyan,
	Nariné Renard Karapetyan,
	Randall Bart,
	Richard Ishida,
	Simon Montagu (Mozilla, smontagu@smontagu.org)</p>
   <p>Special thanks to Xidorn Quan for <em>extensive</em> reviews of all aspects of the spec,
	and also to Simon Sapin and Håkon Wium Lie for their review comments.</p>
   <h2 class="no-num heading settled" id="priv-sec"><span class="content"> Privacy and Security Considerations</span><a class="self-link" href="#priv-sec"></a></h2>
   <p>This specification introduces no new privacy or security considerations.</p>
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-csscounterstylerule-interface">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSCounterStyleRule" title="The CSSCounterStyleRule interface represents an @counter-style at-rule.">CSSCounterStyleRule</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extentions-to-cssrule-interface">
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="counter-style-symbols">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/additive-symbols" title="The additive-symbols descriptor lets you specify symbols when the value of a counter system descriptor is additive. The additive-symbols descriptor defines additive tuples, each of which is a pair containing a symbol and a non-negative integer weight. The additive system is used to construct sign-value numbering systems such as Roman numerals.">@counter-style/additive-symbols</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/symbols" title="The symbols CSS descriptor is used to specify the symbols that the specified counter system will use to construct counter representations. A symbol can be a string, image, or identifier. It is used within the @counter-style at-rule.">@counter-style/symbols</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="counter-style-fallback">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/fallback" title="The fallback descriptor can be used to specify a counter style to fall back to if the current counter style cannot create a marker representation for a particular counter value.">@counter-style/fallback</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="counter-style-system">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/negative" title="When defining custom counter styles, the negative descriptor lets you alter the representations of negative counter values, by providing a way to specify symbols to be appended or prepended to the counter representation when the value is negative.">@counter-style/negative</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/system" title="The system descriptor specifies the algorithm to be used for converting the integer value of a counter to a string representation. It is used in a @counter-style to define the behavior of the defined style.">@counter-style/system</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-counter-style-pad">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/pad" title="The pad descriptor can be used with custom counter style definitions when you need the marker representations to have a minimum length. If a marker representation is smaller than the specified pad length, then the marker will be padded with the specified pad symbol. Marker representations longer than the pad length are constructed as normal.">@counter-style/pad</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-counter-style-prefix">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/prefix" title="The prefix descriptor of the @counter-style rule specifies content that will be prepended to the marker representation. If not specified, the default value will be &quot;&quot; (an empty string).">@counter-style/prefix</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="counter-style-range">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/range" title="When defining custom counter styles, the range descriptor lets the author specify a range of counter values over which the style is applied. If a counter value is outside the specified range, then the fallback style will be used to construct the representation of that marker.">@counter-style/range</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="counter-style-speak-as">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/speak-as" title="The speak-as descriptor specifies how a counter symbol constructed with a given @counter-style will be represented in the spoken form. For example, an author can specify a counter symbol to be either spoken as its numerical value or just represented with an audio cue.">@counter-style/speak-as</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-counter-style-suffix">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style/suffix" title="The suffix descriptor of the@counter-style rule specifies content that will be appended to the marker representation. If not specified, the default value will be &quot;\2E\20&quot; (&quot;. &quot;, a full stop followed by a space).">@counter-style/suffix</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-counter-style-rule">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@counter-style" title="The @counter-style CSS at-rule lets you define counter styles that are not part of the predefined set of styles. A @counter-style rule defines how to convert a counter value into a string representation.">@counter-style</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>33+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="symbols-function">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/symbols" title="The symbols() CSS function lets you define counter styles inline, directly as the value of a property such as list-style. Unlike @counter-style, symbols() is anonymous (i.e., it can only be used once). Although less powerful, it is shorter and easier to write than @counter-style.">symbols</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>35+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>35+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/symbols" title="The symbols() CSS function lets you define counter styles inline, directly as the value of a property such as list-style. Unlike @counter-style, symbols() is anonymous (i.e., it can only be used once). Although less powerful, it is shorter and easier to write than @counter-style.">symbols</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>35+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>35+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extending-css2">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/list-style-type" title="The list-style-type CSS property sets the marker (such as a disc, character, or custom counter style) of a list item element.">list-style-type</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>3.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#valdef-counter-style-system-additive">additive</a><span>, in §3.1.6</span>
   <li><a href="#descdef-counter-style-additive-symbols">additive-symbols</a><span>, in §3.8</span>
   <li><a href="#dom-csscounterstylerule-additivesymbols">additiveSymbols</a><span>, in §9.2</span>
   <li><a href="#additive-tuple">additive tuple</a><span>, in §3.8</span>
   <li><a href="#valdef-counter-style-system-alphabetic">alphabetic</a><span>, in §3.1.4</span>
   <li><a href="#valdef-counter-style-name-arabic-indic">arabic-indic</a><span>, in §6.1</span>
   <li><a href="#armenian">armenian</a><span>, in §6.1</span>
   <li>
    auto
    <ul>
     <li><a href="#valdef-counter-style-range-auto">value for @counter-style/range</a><span>, in §3.5</span>
     <li><a href="#valdef-counter-style-speak-as-auto">value for @counter-style/speak-as</a><span>, in §3.9</span>
    </ul>
   <li><a href="#valdef-counter-style-name-bengali">bengali</a><span>, in §6.1</span>
   <li><a href="#box-corner">box-corner</a><span>, in §3.1.2</span>
   <li><a href="#valdef-counter-style-speak-as-bullets">bullets</a><span>, in §3.9</span>
   <li><a href="#valdef-counter-style-name-cambodian">cambodian</a><span>, in §6.1</span>
   <li><a href="#circle">circle</a><span>, in §6.3</span>
   <li><a href="#circled-lower-latin">circled-lower-latin</a><span>, in §3.9</span>
   <li><a href="#cjk-decimal">cjk-decimal</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-cjk-earthly-branch">cjk-earthly-branch</a><span>, in §6.4</span>
   <li><a href="#valdef-counter-style-name-cjk-heavenly-stem">cjk-heavenly-stem</a><span>, in §6.4</span>
   <li><a href="#cjk-ideographic">cjk-ideographic</a><span>, in §7.1.3</span>
   <li><a href="#typedef-counter-style">&lt;counter-style></a><span>, in §5</span>
   <li><a href="#at-ruledef-counter-style">@counter-style</a><span>, in §3</span>
   <li><a href="#counter-style">counter style</a><span>, in §2</span>
   <li>
    &lt;counter-style-name>
    <ul>
     <li><a href="#typedef-counter-style-name">(type)</a><span>, in §3</span>
     <li><a href="#valdef-counter-style-speak-as-counter-style-name">value for @counter-style/speak-as</a><span>, in §3.9</span>
    </ul>
   <li><a href="#dom-cssrule-counter_style_rule">COUNTER_STYLE_RULE</a><span>, in §9.1</span>
   <li><a href="#counter-symbol">counter symbol</a><span>, in §3.8</span>
   <li><a href="#csscounterstylerule">CSSCounterStyleRule</a><span>, in §9.2</span>
   <li><a href="#current-tuple">current tuple</a><span>, in §3.1.6</span>
   <li><a href="#valdef-counter-style-system-cyclic">cyclic</a><span>, in §3.1.1</span>
   <li><a href="#decimal">decimal</a><span>, in §6.1</span>
   <li><a href="#decimal-leading-zero">decimal-leading-zero</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-devanagari">devanagari</a><span>, in §6.1</span>
   <li><a href="#dice">dice</a><span>, in §3.1.6</span>
   <li><a href="#disc">disc</a><span>, in §6.3</span>
   <li><a href="#disclosure-closed">disclosure-closed</a><span>, in §6.3</span>
   <li><a href="#disclosure-open">disclosure-open</a><span>, in §6.3</span>
   <li><a href="#valdef-counter-style-name-ethiopic-numeric">ethiopic-numeric</a><span>, in §7.2</span>
   <li><a href="#valdef-counter-style-system-extends">extends</a><span>, in §3.1.7</span>
   <li>
    fallback
    <ul>
     <li><a href="#dom-csscounterstylerule-fallback">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-fallback">descriptor for @counter-style</a><span>, in §3.7</span>
    </ul>
   <li><a href="#first-symbol-value">first symbol value</a><span>, in §3.1.2</span>
   <li><a href="#valdef-counter-style-system-fixed">fixed</a><span>, in §3.1.2</span>
   <li><a href="#footnote">footnote</a><span>, in §3.1.3</span>
   <li><a href="#generate-a-counter">generate a counter</a><span>, in §2</span>
   <li><a href="#generate-a-counter">generate a counter representation</a><span>, in §2</span>
   <li><a href="#georgian">georgian</a><span>, in §6.1</span>
   <li><a href="#go">go</a><span>, in §3.1.4</span>
   <li><a href="#valdef-counter-style-name-gujarati">gujarati</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-gurmukhi">gurmukhi</a><span>, in §6.1</span>
   <li><a href="#hebrew">hebrew</a><span>, in §6.1</span>
   <li><a href="#hiragana">hiragana</a><span>, in §6.2</span>
   <li><a href="#hiragana-iroha">hiragana-iroha</a><span>, in §6.2</span>
   <li><a href="#initial-representation-for-the-counter-value">initial representation for the counter value</a><span>, in §2</span>
   <li><a href="#japanese-formal">japanese-formal</a><span>, in §7.1.1</span>
   <li><a href="#japanese-informal">japanese-informal</a><span>, in §7.1.1</span>
   <li><a href="#valdef-counter-style-name-kannada">kannada</a><span>, in §6.1</span>
   <li><a href="#katakana">katakana</a><span>, in §6.2</span>
   <li><a href="#katakana-iroha">katakana-iroha</a><span>, in §6.2</span>
   <li><a href="#valdef-counter-style-name-khmer">khmer</a><span>, in §6.1</span>
   <li><a href="#korean-hangul-formal">korean-hangul-formal</a><span>, in §7.1.2</span>
   <li><a href="#korean-hanja-formal">korean-hanja-formal</a><span>, in §7.1.2</span>
   <li><a href="#korean-hanja-informal">korean-hanja-informal</a><span>, in §7.1.2</span>
   <li><a href="#valdef-counter-style-name-lao">lao</a><span>, in §6.1</span>
   <li><a href="#lower-alpha">lower-alpha</a><span>, in §6.2</span>
   <li><a href="#valdef-counter-style-name-lower-armenian">lower-armenian</a><span>, in §6.1</span>
   <li><a href="#lower-greek">lower-greek</a><span>, in §6.2</span>
   <li><a href="#lower-latin">lower-latin</a><span>, in §6.2</span>
   <li><a href="#lower-roman">lower-roman</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-malayalam">malayalam</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-mongolian">mongolian</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-myanmar">myanmar</a><span>, in §6.1</span>
   <li><a href="#dom-csscounterstylerule-name">name</a><span>, in §9.2</span>
   <li>
    negative
    <ul>
     <li><a href="#dom-csscounterstylerule-negative">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-negative">descriptor for @counter-style</a><span>, in §3.2</span>
    </ul>
   <li><a href="#valdef-counter-style-speak-as-numbers">numbers</a><span>, in §3.9</span>
   <li><a href="#valdef-counter-style-system-numeric">numeric</a><span>, in §3.1.5</span>
   <li><a href="#valdef-counter-style-name-oriya">oriya</a><span>, in §6.1</span>
   <li>
    pad
    <ul>
     <li><a href="#dom-csscounterstylerule-pad">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-pad">descriptor for @counter-style</a><span>, in §3.6</span>
    </ul>
   <li><a href="#valdef-counter-style-name-persian">persian</a><span>, in §6.1</span>
   <li>
    prefix
    <ul>
     <li><a href="#dom-csscounterstylerule-prefix">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-prefix">descriptor for @counter-style</a><span>, in §3.3</span>
    </ul>
   <li>
    range
    <ul>
     <li><a href="#dom-csscounterstylerule-range">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-range">descriptor for @counter-style</a><span>, in §3.5</span>
    </ul>
   <li><a href="#simp-chinese-formal">simp-chinese-formal</a><span>, in §7.1.3</span>
   <li><a href="#simp-chinese-informal">simp-chinese-informal</a><span>, in §7.1.3</span>
   <li><a href="#descdef-counter-style-speak-as">speak-as</a><span>, in §3.9</span>
   <li><a href="#dom-csscounterstylerule-speakas">speakAs</a><span>, in §9.2</span>
   <li><a href="#valdef-counter-style-speak-as-spell-out">spell-out</a><span>, in §3.9</span>
   <li><a href="#square">square</a><span>, in §6.3</span>
   <li>
    suffix
    <ul>
     <li><a href="#dom-csscounterstylerule-suffix">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-suffix">descriptor for @counter-style</a><span>, in §3.4</span>
    </ul>
   <li><a href="#typedef-symbol">&lt;symbol></a><span>, in §3.8</span>
   <li><a href="#valdef-system-symbolic">symbolic</a><span>, in §3.1.3</span>
   <li>
    symbols
    <ul>
     <li><a href="#dom-csscounterstylerule-symbols">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-symbols">descriptor for @counter-style</a><span>, in §3.8</span>
    </ul>
   <li><a href="#funcdef-symbols">symbols()</a><span>, in §4</span>
   <li><a href="#typedef-symbols-type">&lt;symbols-type></a><span>, in §4</span>
   <li>
    system
    <ul>
     <li><a href="#dom-csscounterstylerule-system">attribute for CSSCounterStyleRule</a><span>, in §9.2</span>
     <li><a href="#descdef-counter-style-system">descriptor for @counter-style</a><span>, in §3.1</span>
    </ul>
   <li><a href="#valdef-counter-style-name-tamil">tamil</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-telugu">telugu</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-thai">thai</a><span>, in §6.1</span>
   <li><a href="#valdef-counter-style-name-tibetan">tibetan</a><span>, in §6.1</span>
   <li><a href="#trad-chinese-formal">trad-chinese-formal</a><span>, in §7.1.3</span>
   <li><a href="#trad-chinese-informal">trad-chinese-informal</a><span>, in §7.1.3</span>
   <li><a href="#triangle">triangle</a><span>, in §3.1.1</span>
   <li><a href="#trinary">trinary</a><span>, in §3.1.5</span>
   <li><a href="#upper-alpha">upper-alpha</a><span>, in §6.2</span>
   <li><a href="#upper-alpha-legal">upper-alpha-legal</a><span>, in §3.1.3</span>
   <li><a href="#valdef-counter-style-name-upper-armenian">upper-armenian</a><span>, in §6.1</span>
   <li><a href="#upper-latin">upper-latin</a><span>, in §6.2</span>
   <li><a href="#upper-roman">upper-roman</a><span>, in §6.1</span>
   <li><a href="#use-a-negative-sign">use a negative sign</a><span>, in §3.2</span>
   <li><a href="#use-a-negative-sign">uses a negative sign</a><span>, in §3.2</span>
   <li><a href="#valdef-counter-style-speak-as-words">words</a><span>, in §3.9</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-computed-value">
   <a href="https://drafts.csswg.org/css-cascade-4/#computed-value">https://drafts.csswg.org/css-cascade-4/#computed-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-computed-value">5. 
Extending list-style-type, counter(), and counters()</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-content">
   <a href="https://drafts.csswg.org/css-content-3/#propdef-content">https://drafts.csswg.org/css-content-3/#propdef-content</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-content">2. 
Counter Styles</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-image">
   <a href="https://drafts.csswg.org/css-images-3/#typedef-image">https://drafts.csswg.org/css-images-3/#typedef-image</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-image">Unnumbered Section</a>
    <li><a href="#ref-for-typedef-image①">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-typedef-image②">(2)</a>
    <li><a href="#ref-for-typedef-image③">4. 
Defining Anonymous Counter Styles: the symbols() function</a> <a href="#ref-for-typedef-image④">(2)</a> <a href="#ref-for-typedef-image⑤">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-default-object-size">
   <a href="https://drafts.csswg.org/css-images-3/#default-object-size">https://drafts.csswg.org/css-images-3/#default-object-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-default-object-size">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-funcdef-counter">
   <a href="https://drafts.csswg.org/css-lists-3/#funcdef-counter">https://drafts.csswg.org/css-lists-3/#funcdef-counter</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-funcdef-counter">1. 
Introduction</a>
    <li><a href="#ref-for-funcdef-counter①">3. 
Defining Custom Counter Styles: the @counter-style rule</a>
    <li><a href="#ref-for-funcdef-counter②">3.3. 
Symbols before the marker: the prefix descriptor</a>
    <li><a href="#ref-for-funcdef-counter③">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-funcdef-counter④">5. 
Extending list-style-type, counter(), and counters()</a> <a href="#ref-for-funcdef-counter⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-funcdef-counters">
   <a href="https://drafts.csswg.org/css-lists-3/#funcdef-counters">https://drafts.csswg.org/css-lists-3/#funcdef-counters</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-funcdef-counters">1. 
Introduction</a>
    <li><a href="#ref-for-funcdef-counters①">3.3. 
Symbols before the marker: the prefix descriptor</a>
    <li><a href="#ref-for-funcdef-counters②">5. 
Extending list-style-type, counter(), and counters()</a> <a href="#ref-for-funcdef-counters③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-list-style-position-inside">
   <a href="https://drafts.csswg.org/css-lists-3/#valdef-list-style-position-inside">https://drafts.csswg.org/css-lists-3/#valdef-list-style-position-inside</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-list-style-position-inside">3. 
Defining Custom Counter Styles: the @counter-style rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-list-style">
   <a href="https://drafts.csswg.org/css-lists-3/#propdef-list-style">https://drafts.csswg.org/css-lists-3/#propdef-list-style</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-list-style">3. 
Defining Custom Counter Styles: the @counter-style rule</a> <a href="#ref-for-propdef-list-style①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-list-style-type">
   <a href="https://drafts.csswg.org/css-lists-3/#propdef-list-style-type">https://drafts.csswg.org/css-lists-3/#propdef-list-style-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-list-style-type">1. 
Introduction</a>
    <li><a href="#ref-for-propdef-list-style-type①">5. 
Extending list-style-type, counter(), and counters()</a> <a href="#ref-for-propdef-list-style-type②">(2)</a>
    <li><a href="#ref-for-propdef-list-style-type③">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-selectordef-marker">
   <a href="https://drafts.csswg.org/css-pseudo-4/#selectordef-marker">https://drafts.csswg.org/css-pseudo-4/#selectordef-marker</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-selectordef-marker">2. 
Counter Styles</a>
    <li><a href="#ref-for-selectordef-marker①">3.3. 
Symbols before the marker: the prefix descriptor</a>
    <li><a href="#ref-for-selectordef-marker②">3.4. 
Symbols after the marker: the suffix descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-declaration-list">
   <a href="https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list">https://drafts.csswg.org/css-syntax-3/#typedef-declaration-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-declaration-list">3. 
Defining Custom Counter Styles: the @counter-style rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-rule">
   <a href="https://drafts.csswg.org/css-syntax-3/#at-rule">https://drafts.csswg.org/css-syntax-3/#at-rule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-rule">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-parse-something-according-to-a-css-grammar">
   <a href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar">https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-parse-something-according-to-a-css-grammar"> Changes since the Jun 2015 Candidate Recommendation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parse-a-list-of-component-values">
   <a href="https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-component-values">https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-component-values</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-list-of-component-values">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-content-language">
   <a href="https://drafts.csswg.org/css-text-3/#content-language">https://drafts.csswg.org/css-text-3/#content-language</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-content-language">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-content-language①">(2)</a> <a href="#ref-for-content-language②">(3)</a>
    <li><a href="#ref-for-content-language③"> Changes since the Jun 2015 Candidate Recommendation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-grapheme-cluster">
   <a href="https://drafts.csswg.org/css-text-3/#grapheme-cluster">https://drafts.csswg.org/css-text-3/#grapheme-cluster</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-grapheme-cluster">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a> <a href="#ref-for-grapheme-cluster①">(2)</a> <a href="#ref-for-grapheme-cluster②">(3)</a> <a href="#ref-for-grapheme-cluster③">(4)</a> <a href="#ref-for-grapheme-cluster④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-text-emphasis-skip-symbols">
   <a href="https://drafts.csswg.org/css-text-decor-4/#valdef-text-emphasis-skip-symbols">https://drafts.csswg.org/css-text-decor-4/#valdef-text-emphasis-skip-symbols</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-text-emphasis-skip-symbols">3. 
Defining Custom Counter Styles: the @counter-style rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-integer-value">
   <a href="https://drafts.csswg.org/css-values-3/#integer-value">https://drafts.csswg.org/css-values-3/#integer-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-integer-value">3.1. 
Counter algorithms: the system descriptor</a>
    <li><a href="#ref-for-integer-value①">3.5. 
Limiting the counter scope: the range descriptor</a> <a href="#ref-for-integer-value②">(2)</a>
    <li><a href="#ref-for-integer-value③">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a> <a href="#ref-for-integer-value④">(2)</a> <a href="#ref-for-integer-value⑤">(3)</a> <a href="#ref-for-integer-value⑥">(4)</a> <a href="#ref-for-integer-value⑦">(5)</a>
    <li><a href="#ref-for-integer-value⑧">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string-value">
   <a href="https://drafts.csswg.org/css-values-3/#string-value">https://drafts.csswg.org/css-values-3/#string-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string-value">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-string-value①">4. 
Defining Anonymous Counter Styles: the symbols() function</a> <a href="#ref-for-string-value②">(2)</a> <a href="#ref-for-string-value③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-identifier">
   <a href="https://drafts.csswg.org/css-values-3/#css-identifier">https://drafts.csswg.org/css-values-3/#css-identifier</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-identifier">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-comma">
   <a href="https://drafts.csswg.org/css-values-4/#mult-comma">https://drafts.csswg.org/css-values-4/#mult-comma</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-comma">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-mult-comma①">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-all">
   <a href="https://drafts.csswg.org/css-values-4/#comb-all">https://drafts.csswg.org/css-values-4/#comb-all</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-all">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a>
    <li><a href="#ref-for-comb-all①">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-one-plus">
   <a href="https://drafts.csswg.org/css-values-4/#mult-one-plus">https://drafts.csswg.org/css-values-4/#mult-one-plus</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-one-plus">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-mult-one-plus①">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-identifier-value">
   <a href="https://drafts.csswg.org/css-values-4/#identifier-value">https://drafts.csswg.org/css-values-4/#identifier-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-identifier-value">3. 
Defining Custom Counter Styles: the @counter-style rule</a> <a href="#ref-for-identifier-value①">(2)</a>
    <li><a href="#ref-for-identifier-value②">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-opt">
   <a href="https://drafts.csswg.org/css-values-4/#mult-opt">https://drafts.csswg.org/css-values-4/#mult-opt</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-opt">3.1. 
Counter algorithms: the system descriptor</a>
    <li><a href="#ref-for-mult-opt①">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-mult-opt②">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-wide-keywords">
   <a href="https://drafts.csswg.org/css-values-4/#css-wide-keywords">https://drafts.csswg.org/css-values-4/#css-wide-keywords</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-wide-keywords">3. 
Defining Custom Counter Styles: the @counter-style rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-num">
   <a href="https://drafts.csswg.org/css-values-4/#mult-num">https://drafts.csswg.org/css-values-4/#mult-num</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-num">3.5. 
Limiting the counter scope: the range descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-one">
   <a href="https://drafts.csswg.org/css-values-4/#comb-one">https://drafts.csswg.org/css-values-4/#comb-one</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-one">3.1. 
Counter algorithms: the system descriptor</a> <a href="#ref-for-comb-one①">(2)</a> <a href="#ref-for-comb-one②">(3)</a> <a href="#ref-for-comb-one③">(4)</a> <a href="#ref-for-comb-one④">(5)</a> <a href="#ref-for-comb-one⑤">(6)</a>
    <li><a href="#ref-for-comb-one⑥">3.5. 
Limiting the counter scope: the range descriptor</a> <a href="#ref-for-comb-one⑦">(2)</a>
    <li><a href="#ref-for-comb-one⑧">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-comb-one⑨">(2)</a>
    <li><a href="#ref-for-comb-one①⓪">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-comb-one①①">(2)</a> <a href="#ref-for-comb-one①②">(3)</a> <a href="#ref-for-comb-one①③">(4)</a> <a href="#ref-for-comb-one①④">(5)</a>
    <li><a href="#ref-for-comb-one①⑤">4. 
Defining Anonymous Counter Styles: the symbols() function</a> <a href="#ref-for-comb-one①⑥">(2)</a> <a href="#ref-for-comb-one①⑦">(3)</a> <a href="#ref-for-comb-one①⑧">(4)</a> <a href="#ref-for-comb-one①⑨">(5)</a>
    <li><a href="#ref-for-comb-one②⓪">5. 
Extending list-style-type, counter(), and counters()</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-writing-mode">
   <a href="https://drafts.csswg.org/css-writing-modes-4/#writing-mode">https://drafts.csswg.org/css-writing-modes-4/#writing-mode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-writing-mode">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssomstring">
   <a href="https://drafts.csswg.org/cssom-1/#cssomstring">https://drafts.csswg.org/cssom-1/#cssomstring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">9.2. 
The CSSCounterStyleRule interface</a> <a href="#ref-for-cssomstring①">(2)</a> <a href="#ref-for-cssomstring②">(3)</a> <a href="#ref-for-cssomstring③">(4)</a> <a href="#ref-for-cssomstring④">(5)</a> <a href="#ref-for-cssomstring⑤">(6)</a> <a href="#ref-for-cssomstring⑥">(7)</a> <a href="#ref-for-cssomstring⑦">(8)</a> <a href="#ref-for-cssomstring⑧">(9)</a> <a href="#ref-for-cssomstring⑨">(10)</a> <a href="#ref-for-cssomstring①⓪">(11)</a> <a href="#ref-for-cssomstring①①">(12)</a> <a href="#ref-for-cssomstring①②">(13)</a> <a href="#ref-for-cssomstring①③">(14)</a> <a href="#ref-for-cssomstring①④">(15)</a> <a href="#ref-for-cssomstring①⑤">(16)</a> <a href="#ref-for-cssomstring①⑥">(17)</a> <a href="#ref-for-cssomstring①⑦">(18)</a> <a href="#ref-for-cssomstring①⑧">(19)</a> <a href="#ref-for-cssomstring①⑨">(20)</a> <a href="#ref-for-cssomstring②⓪">(21)</a> <a href="#ref-for-cssomstring②①">(22)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssrule">
   <a href="https://drafts.csswg.org/cssom-1/#cssrule">https://drafts.csswg.org/cssom-1/#cssrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrule">9.1. 
Extensions to the CSSRule interface</a>
    <li><a href="#ref-for-cssrule①">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-details-element">
   <a href="https://html.spec.whatwg.org/multipage/interactive-elements.html#the-details-element">https://html.spec.whatwg.org/multipage/interactive-elements.html#the-details-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-details-element">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a> <a href="#ref-for-the-details-element①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-case-insensitive">
   <a href="https://infra.spec.whatwg.org/#ascii-case-insensitive">https://infra.spec.whatwg.org/#ascii-case-insensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-case-insensitive">3. 
Defining Custom Counter Styles: the @counter-style rule</a> <a href="#ref-for-ascii-case-insensitive①">(2)</a>
    <li><a href="#ref-for-ascii-case-insensitive②">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-short">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-short">https://heycam.github.io/webidl/#idl-unsigned-short</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-short">9.1. 
Extensions to the CSSRule interface</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-cascade-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-computed-value" style="color:initial">computed value</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-content-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-content" style="color:initial">content</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-images-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-image" style="color:initial">&lt;image></span>
     <li><span class="dfn-paneled" id="term-for-default-object-size" style="color:initial">default object size</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS-LISTS-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-funcdef-counter" style="color:initial">counter()</span>
     <li><span class="dfn-paneled" id="term-for-funcdef-counters" style="color:initial">counters()</span>
     <li><span class="dfn-paneled" id="term-for-valdef-list-style-position-inside" style="color:initial">inside</span>
     <li><span class="dfn-paneled" id="term-for-propdef-list-style" style="color:initial">list-style</span>
     <li><span class="dfn-paneled" id="term-for-propdef-list-style-type" style="color:initial">list-style-type</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-pseudo-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-selectordef-marker" style="color:initial">::marker</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-syntax-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-declaration-list" style="color:initial">&lt;declaration-list></span>
     <li><span class="dfn-paneled" id="term-for-at-rule" style="color:initial">at-rule</span>
     <li><span class="dfn-paneled" id="term-for-css-parse-something-according-to-a-css-grammar" style="color:initial">parse</span>
     <li><span class="dfn-paneled" id="term-for-parse-a-list-of-component-values" style="color:initial">parse a list of component values</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-text-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-content-language" style="color:initial">content language</span>
     <li><span class="dfn-paneled" id="term-for-grapheme-cluster" style="color:initial">grapheme cluster</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-text-decor-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valdef-text-emphasis-skip-symbols" style="color:initial">symbols</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-integer-value" style="color:initial">&lt;integer></span>
     <li><span class="dfn-paneled" id="term-for-string-value" style="color:initial">&lt;string></span>
     <li><span class="dfn-paneled" id="term-for-css-identifier" style="color:initial">identifier</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mult-comma" style="color:initial">#</span>
     <li><span class="dfn-paneled" id="term-for-comb-all" style="color:initial">&amp;&amp;</span>
     <li><span class="dfn-paneled" id="term-for-mult-one-plus" style="color:initial">+</span>
     <li><span class="dfn-paneled" id="term-for-identifier-value" style="color:initial">&lt;custom-ident></span>
     <li><span class="dfn-paneled" id="term-for-mult-opt" style="color:initial">?</span>
     <li><span class="dfn-paneled" id="term-for-css-wide-keywords" style="color:initial">css-wide keywords</span>
     <li><span class="dfn-paneled" id="term-for-mult-num" style="color:initial">{a}</span>
     <li><span class="dfn-paneled" id="term-for-comb-one" style="color:initial">|</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-writing-modes-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-writing-mode" style="color:initial">writing mode</span>
    </ul>
   <li>
    <a data-link-type="biblio">[cssom-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssomstring" style="color:initial">CSSOMString</span>
     <li><span class="dfn-paneled" id="term-for-cssrule" style="color:initial">CSSRule</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-the-details-element" style="color:initial">details</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-ascii-case-insensitive" style="color:initial">ascii case-insensitive</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-short" style="color:initial">unsigned short</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-cascade-4">[CSS-CASCADE-4]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-4/">CSS Cascading and Inheritance Level 4</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-4/">https://www.w3.org/TR/css-cascade-4/</a>
   <dt id="biblio-css-images-3">[CSS-IMAGES-3]
   <dd>Tab Atkins Jr.; Elika Etemad; Lea Verou. <a href="https://www.w3.org/TR/css-images-3/">CSS Images Module Level 3</a>. 10 October 2019. CR. URL: <a href="https://www.w3.org/TR/css-images-3/">https://www.w3.org/TR/css-images-3/</a>
   <dt id="biblio-css-lists-3">[CSS-LISTS-3]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-lists-3/">CSS Lists Module Level 3</a>. 17 August 2019. WD. URL: <a href="https://www.w3.org/TR/css-lists-3/">https://www.w3.org/TR/css-lists-3/</a>
   <dt id="biblio-css-syntax-3">[CSS-SYNTAX-3]
   <dd>Tab Atkins Jr.; Simon Sapin. <a href="https://www.w3.org/TR/css-syntax-3/">CSS Syntax Module Level 3</a>. 16 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-syntax-3/">https://www.w3.org/TR/css-syntax-3/</a>
   <dt id="biblio-css-text-3">[CSS-TEXT-3]
   <dd>Elika Etemad; Koji Ishii; Florian Rivoal. <a href="https://www.w3.org/TR/css-text-3/">CSS Text Module Level 3</a>. 13 November 2019. WD. URL: <a href="https://www.w3.org/TR/css-text-3/">https://www.w3.org/TR/css-text-3/</a>
   <dt id="biblio-css-text-decor-4">[CSS-TEXT-DECOR-4]
   <dd>Elika Etemad; Koji Ishii. <a href="https://www.w3.org/TR/css-text-decor-4/">CSS Text Decoration Module Level 4</a>. 13 March 2018. WD. URL: <a href="https://www.w3.org/TR/css-text-decor-4/">https://www.w3.org/TR/css-text-decor-4/</a>
   <dt id="biblio-css-values-3">[CSS-VALUES-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-3/">CSS Values and Units Module Level 3</a>. 6 June 2019. CR. URL: <a href="https://www.w3.org/TR/css-values-3/">https://www.w3.org/TR/css-values-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css-writing-modes-4">[CSS-WRITING-MODES-4]
   <dd>Elika Etemad; Koji Ishii. <a href="https://www.w3.org/TR/css-writing-modes-4/">CSS Writing Modes Level 4</a>. 30 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-writing-modes-4/">https://www.w3.org/TR/css-writing-modes-4/</a>
   <dt id="biblio-css21">[CSS21]
   <dd>Bert Bos; et al. <a href="https://www.w3.org/TR/CSS2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. 7 June 2011. REC. URL: <a href="https://www.w3.org/TR/CSS2/">https://www.w3.org/TR/CSS2/</a>
   <dt id="biblio-cssom-1">[CSSOM-1]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-css-content-3">[CSS-CONTENT-3]
   <dd>Elika Etemad; Dave Cramer. <a href="https://www.w3.org/TR/css-content-3/">CSS Generated Content Module Level 3</a>. 2 August 2019. WD. URL: <a href="https://www.w3.org/TR/css-content-3/">https://www.w3.org/TR/css-content-3/</a>
   <dt id="biblio-css-pseudo-4">[CSS-PSEUDO-4]
   <dd>Daniel Glazman; Elika Etemad; Alan Stearns. <a href="https://www.w3.org/TR/css-pseudo-4/">CSS Pseudo-Elements Module Level 4</a>. 25 February 2019. WD. URL: <a href="https://www.w3.org/TR/css-pseudo-4/">https://www.w3.org/TR/css-pseudo-4/</a>
   <dt id="biblio-predefined-counter-styles">[PREDEFINED-COUNTER-STYLES]
   <dd>Marcos Caceres. <a href="https://www.w3.org/TR/predefined-counter-styles/">Ready-made Counter Styles</a>. 16 February 2017. NOTE. URL: <a href="https://www.w3.org/TR/predefined-counter-styles/">https://www.w3.org/TR/predefined-counter-styles/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="property-index"><span class="content">Property Index</span><a class="self-link" href="#property-index"></a></h2>
  <p>No properties defined.</p>
  <h3 class="no-num no-ref heading settled" id="counter-style-descriptor-table"><span class="content"><a class="css" data-link-type="at-rule" href="#at-ruledef-counter-style" id="ref-for-at-ruledef-counter-style⑤②">@counter-style</a> Descriptors</span><a class="self-link" href="#counter-style-descriptor-table"></a></h3>
  <div class="big-element-wrapper">
   <table class="index">
    <thead>
     <tr>
      <th scope="col">Name
      <th scope="col">Value
      <th scope="col">Initial
    <tbody>
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-additive-symbols" id="ref-for-descdef-counter-style-additive-symbols⑧">additive-symbols</a>
      <td>[ &lt;integer [0,∞]> &amp;&amp; &lt;symbol> ]#
      <td>n/a
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-fallback" id="ref-for-descdef-counter-style-fallback⑦">fallback</a>
      <td>&lt;counter-style-name>
      <td>decimal
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-negative" id="ref-for-descdef-counter-style-negative⑦">negative</a>
      <td>&lt;symbol> &lt;symbol>?
      <td>"\2D" ("-" hyphen-minus)
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-pad" id="ref-for-descdef-counter-style-pad①⓪">pad</a>
      <td>&lt;integer [0,∞]> &amp;&amp; &lt;symbol>
      <td>0 ""
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-prefix" id="ref-for-descdef-counter-style-prefix④">prefix</a>
      <td>&lt;symbol>
      <td>"" (the empty string)
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-range" id="ref-for-descdef-counter-style-range⑦">range</a>
      <td>[ [ &lt;integer> | infinite ]{2} ]# | auto
      <td>auto
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-speak-as" id="ref-for-descdef-counter-style-speak-as⑥">speak-as</a>
      <td>auto | bullets | numbers | words | spell-out | &lt;counter-style-name>
      <td>auto
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-suffix" id="ref-for-descdef-counter-style-suffix⑥">suffix</a>
      <td>&lt;symbol>
      <td>"\2E\20" ("." full stop followed by a space)
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-symbols" id="ref-for-descdef-counter-style-symbols①⑦">symbols</a>
      <td>&lt;symbol>+
      <td>n/a
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-counter-style-system" id="ref-for-descdef-counter-style-system①⓪">system</a>
      <td>cyclic | numeric | alphabetic | symbolic | additive | [fixed &lt;integer>?] | [ extends &lt;counter-style-name> ]
      <td>symbolic
   </table>
  </div>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-counter_style_rule"><code><c- g>COUNTER_STYLE_RULE</c-></code></a> = 11;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#csscounterstylerule"><code><c- g>CSSCounterStyleRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- n>CSSRule</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-name"><c- g>name</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-system"><c- g>system</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-symbols"><c- g>symbols</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-additivesymbols"><c- g>additiveSymbols</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-negative"><c- g>negative</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-prefix"><c- g>prefix</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-suffix"><c- g>suffix</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-range"><c- g>range</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-pad"><c- g>pad</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-speakas"><c- g>speakAs</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-csscounterstylerule-fallback"><c- g>fallback</c-></a>;
};

</pre>
  <aside class="dfn-panel" data-for="counter-style">
   <b><a href="#counter-style">#counter-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-counter-style">3. 
Defining Custom Counter Styles: the @counter-style rule</a> <a href="#ref-for-counter-style①">(2)</a>
    <li><a href="#ref-for-counter-style②">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-counter-style③">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-counter-style④">9.2. 
The CSSCounterStyleRule interface</a>
    <li><a href="#ref-for-counter-style⑤"> Changes since the Jun 2015 Candidate Recommendation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="generate-a-counter">
   <b><a href="#generate-a-counter">#generate-a-counter</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-generate-a-counter">2. 
Counter Styles</a> <a href="#ref-for-generate-a-counter①">(2)</a>
    <li><a href="#ref-for-generate-a-counter②">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-generate-a-counter③">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a>
    <li><a href="#ref-for-generate-a-counter④">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-generate-a-counter⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="initial-representation-for-the-counter-value">
   <b><a href="#initial-representation-for-the-counter-value">#initial-representation-for-the-counter-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-initial-representation-for-the-counter-value">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="at-ruledef-counter-style">
   <b><a href="#at-ruledef-counter-style">#at-ruledef-counter-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-counter-style①">1. 
Introduction</a> <a href="#ref-for-at-ruledef-counter-style②">(2)</a>
    <li><a href="#ref-for-at-ruledef-counter-style③">3. 
Defining Custom Counter Styles: the @counter-style rule</a> <a href="#ref-for-at-ruledef-counter-style④">(2)</a> <a href="#ref-for-at-ruledef-counter-style⑤">(3)</a> <a href="#ref-for-at-ruledef-counter-style⑥">(4)</a> <a href="#ref-for-at-ruledef-counter-style⑦">(5)</a> <a href="#ref-for-at-ruledef-counter-style⑧">(6)</a> <a href="#ref-for-at-ruledef-counter-style⑨">(7)</a> <a href="#ref-for-at-ruledef-counter-style①⓪">(8)</a> <a href="#ref-for-at-ruledef-counter-style①①">(9)</a> <a href="#ref-for-at-ruledef-counter-style①②">(10)</a> <a href="#ref-for-at-ruledef-counter-style①③">(11)</a> <a href="#ref-for-at-ruledef-counter-style①④">(12)</a> <a href="#ref-for-at-ruledef-counter-style①⑤">(13)</a>
    <li><a href="#ref-for-at-ruledef-counter-style①⑥">3.1. 
Counter algorithms: the system descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style①⑦">3.1.1. 
Cycling Symbols: the cyclic system</a>
    <li><a href="#ref-for-at-ruledef-counter-style①⑧">3.1.2. 
Exhaustible Symbols: the fixed system</a>
    <li><a href="#ref-for-at-ruledef-counter-style①⑨">3.1.3. 
Repeating Symbols: the symbolic system</a>
    <li><a href="#ref-for-at-ruledef-counter-style②⓪">3.1.4. 
Bijective Numerals: the alphabetic system</a>
    <li><a href="#ref-for-at-ruledef-counter-style②①">3.1.5. 
Positional Numerals: the numeric system</a>
    <li><a href="#ref-for-at-ruledef-counter-style②②">3.1.6. 
Accumulating Numerals: the additive system</a> <a href="#ref-for-at-ruledef-counter-style②③">(2)</a> <a href="#ref-for-at-ruledef-counter-style②④">(3)</a>
    <li><a href="#ref-for-at-ruledef-counter-style②⑤">3.1.7. 
Building from Existing Counter Styles: the extends system </a> <a href="#ref-for-at-ruledef-counter-style②⑥">(2)</a>
    <li><a href="#ref-for-at-ruledef-counter-style②⑦">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style②⑧">3.3. 
Symbols before the marker: the prefix descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style②⑨">3.4. 
Symbols after the marker: the suffix descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style③⓪">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style③①">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style③②">3.7. 
Defining fallback: the fallback descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style③③">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-at-ruledef-counter-style③④">(2)</a> <a href="#ref-for-at-ruledef-counter-style③⑤">(3)</a> <a href="#ref-for-at-ruledef-counter-style③⑥">(4)</a>
    <li><a href="#ref-for-at-ruledef-counter-style③⑦">3.9. 
Speech Synthesis: the speak-as descriptor</a>
    <li><a href="#ref-for-at-ruledef-counter-style③⑧">4. 
Defining Anonymous Counter Styles: the symbols() function</a> <a href="#ref-for-at-ruledef-counter-style③⑨">(2)</a> <a href="#ref-for-at-ruledef-counter-style④⓪">(3)</a>
    <li><a href="#ref-for-at-ruledef-counter-style④①">6. 
Simple Predefined Counter Styles</a>
    <li><a href="#ref-for-at-ruledef-counter-style④②">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a> <a href="#ref-for-at-ruledef-counter-style④③">(2)</a>
    <li><a href="#ref-for-at-ruledef-counter-style④④">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a>
    <li><a href="#ref-for-at-ruledef-counter-style④⑤">7. 
Complex Predefined Counter Styles</a> <a href="#ref-for-at-ruledef-counter-style④⑥">(2)</a>
    <li><a href="#ref-for-at-ruledef-counter-style④⑦">8. 
Additional Predefined Counter Styles</a>
    <li><a href="#ref-for-at-ruledef-counter-style④⑧">9.2. 
The CSSCounterStyleRule interface</a> <a href="#ref-for-at-ruledef-counter-style④⑨">(2)</a>
    <li><a href="#ref-for-at-ruledef-counter-style⑤⓪"> Changes since the Jun 2015 Candidate Recommendation</a>
    <li><a href="#ref-for-at-ruledef-counter-style⑤①"> Changes since the Feb 2015 Candidate Recommendation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-counter-style-name">
   <b><a href="#typedef-counter-style-name">#typedef-counter-style-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-counter-style-name">3. 
Defining Custom Counter Styles: the @counter-style rule</a> <a href="#ref-for-typedef-counter-style-name①">(2)</a>
    <li><a href="#ref-for-typedef-counter-style-name②">3.1. 
Counter algorithms: the system descriptor</a>
    <li><a href="#ref-for-typedef-counter-style-name③">3.7. 
Defining fallback: the fallback descriptor</a>
    <li><a href="#ref-for-typedef-counter-style-name④">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-typedef-counter-style-name⑤">(2)</a>
    <li><a href="#ref-for-typedef-counter-style-name⑥">5. 
Extending list-style-type, counter(), and counters()</a> <a href="#ref-for-typedef-counter-style-name⑦">(2)</a>
    <li><a href="#ref-for-typedef-counter-style-name⑧">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-system">
   <b><a href="#descdef-counter-style-system">#descdef-counter-style-system</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-system">2. 
Counter Styles</a>
    <li><a href="#ref-for-descdef-counter-style-system①">3.1. 
Counter algorithms: the system descriptor</a> <a href="#ref-for-descdef-counter-style-system②">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-system③">3.2. 
Formatting negative values: the negative descriptor</a> <a href="#ref-for-descdef-counter-style-system④">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-system⑤">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-descdef-counter-style-system⑥">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-descdef-counter-style-system⑦">(2)</a> <a href="#ref-for-descdef-counter-style-system⑧">(3)</a> <a href="#ref-for-descdef-counter-style-system⑨">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-system-cyclic">
   <b><a href="#valdef-counter-style-system-cyclic">#valdef-counter-style-system-cyclic</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-system-cyclic">3.1. 
Counter algorithms: the system descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-cyclic①">3.1.1. 
Cycling Symbols: the cyclic system</a> <a href="#ref-for-valdef-counter-style-system-cyclic②">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-system-cyclic③">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-cyclic④">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-valdef-counter-style-system-cyclic⑤">3.9. 
Speech Synthesis: the speak-as descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-system-fixed">
   <b><a href="#valdef-counter-style-system-fixed">#valdef-counter-style-system-fixed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-system-fixed">3.1.2. 
Exhaustible Symbols: the fixed system</a> <a href="#ref-for-valdef-counter-style-system-fixed①">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-system-fixed②">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-fixed③">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-valdef-counter-style-system-fixed④">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-valdef-counter-style-system-fixed⑤">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="first-symbol-value">
   <b><a href="#first-symbol-value">#first-symbol-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-first-symbol-value">3.1.2. 
Exhaustible Symbols: the fixed system</a> <a href="#ref-for-first-symbol-value①">(2)</a> <a href="#ref-for-first-symbol-value②">(3)</a>
    <li><a href="#ref-for-first-symbol-value③">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-first-symbol-value④">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-system-symbolic">
   <b><a href="#valdef-system-symbolic">#valdef-system-symbolic</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-system-symbolic">2. 
Counter Styles</a>
    <li><a href="#ref-for-valdef-system-symbolic①">3.1.3. 
Repeating Symbols: the symbolic system</a> <a href="#ref-for-valdef-system-symbolic②">(2)</a>
    <li><a href="#ref-for-valdef-system-symbolic③">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-valdef-system-symbolic④">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-system-symbolic⑤">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-valdef-system-symbolic⑥">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-system-alphabetic">
   <b><a href="#valdef-counter-style-system-alphabetic">#valdef-counter-style-system-alphabetic</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic">3.1.3. 
Repeating Symbols: the symbolic system</a>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic①">3.1.4. 
Bijective Numerals: the alphabetic system</a> <a href="#ref-for-valdef-counter-style-system-alphabetic②">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic③">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic④">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic⑤">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic⑥">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-valdef-counter-style-system-alphabetic⑦">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-system-alphabetic⑧">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-system-numeric">
   <b><a href="#valdef-counter-style-system-numeric">#valdef-counter-style-system-numeric</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-system-numeric">3.1. 
Counter algorithms: the system descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-numeric①">3.1.5. 
Positional Numerals: the numeric system</a> <a href="#ref-for-valdef-counter-style-system-numeric②">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-system-numeric③">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-numeric④">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-numeric⑤">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
    <li><a href="#ref-for-valdef-counter-style-system-numeric⑥">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-system-additive">
   <b><a href="#valdef-counter-style-system-additive">#valdef-counter-style-system-additive</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-system-additive">2. 
Counter Styles</a>
    <li><a href="#ref-for-valdef-counter-style-system-additive①">3.1.6. 
Accumulating Numerals: the additive system</a> <a href="#ref-for-valdef-counter-style-system-additive②">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-system-additive③">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-additive④">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-additive⑤">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="current-tuple">
   <b><a href="#current-tuple">#current-tuple</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-current-tuple">3.1.6. 
Accumulating Numerals: the additive system</a> <a href="#ref-for-current-tuple①">(2)</a> <a href="#ref-for-current-tuple②">(3)</a> <a href="#ref-for-current-tuple③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-system-extends">
   <b><a href="#valdef-counter-style-system-extends">#valdef-counter-style-system-extends</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-system-extends">3.1.7. 
Building from Existing Counter Styles: the extends system </a> <a href="#ref-for-valdef-counter-style-system-extends①">(2)</a> <a href="#ref-for-valdef-counter-style-system-extends②">(3)</a> <a href="#ref-for-valdef-counter-style-system-extends③">(4)</a>
    <li><a href="#ref-for-valdef-counter-style-system-extends④">3.2. 
Formatting negative values: the negative descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-extends⑤">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-extends⑥">3.9. 
Speech Synthesis: the speak-as descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-system-extends⑦">7. 
Complex Predefined Counter Styles</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-negative">
   <b><a href="#descdef-counter-style-negative">#descdef-counter-style-negative</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-negative">2. 
Counter Styles</a>
    <li><a href="#ref-for-descdef-counter-style-negative①">3.2. 
Formatting negative values: the negative descriptor</a> <a href="#ref-for-descdef-counter-style-negative②">(2)</a> <a href="#ref-for-descdef-counter-style-negative③">(3)</a>
    <li><a href="#ref-for-descdef-counter-style-negative④">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a>
    <li><a href="#ref-for-descdef-counter-style-negative⑤">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-descdef-counter-style-negative⑥">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="use-a-negative-sign">
   <b><a href="#use-a-negative-sign">#use-a-negative-sign</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-use-a-negative-sign">2. 
Counter Styles</a> <a href="#ref-for-use-a-negative-sign①">(2)</a>
    <li><a href="#ref-for-use-a-negative-sign②">3.2. 
Formatting negative values: the negative descriptor</a> <a href="#ref-for-use-a-negative-sign③">(2)</a>
    <li><a href="#ref-for-use-a-negative-sign④">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a>
    <li><a href="#ref-for-use-a-negative-sign⑤">7. 
Complex Predefined Counter Styles</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-prefix">
   <b><a href="#descdef-counter-style-prefix">#descdef-counter-style-prefix</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-prefix">2. 
Counter Styles</a>
    <li><a href="#ref-for-descdef-counter-style-prefix①">3.3. 
Symbols before the marker: the prefix descriptor</a> <a href="#ref-for-descdef-counter-style-prefix②">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-prefix③">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-suffix">
   <b><a href="#descdef-counter-style-suffix">#descdef-counter-style-suffix</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-suffix">2. 
Counter Styles</a>
    <li><a href="#ref-for-descdef-counter-style-suffix①">3.4. 
Symbols after the marker: the suffix descriptor</a> <a href="#ref-for-descdef-counter-style-suffix②">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-suffix③">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-descdef-counter-style-suffix④">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
    <li><a href="#ref-for-descdef-counter-style-suffix⑤">7.2. 
Ethiopic Numeric Counter Style: ethiopic-numeric</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-range">
   <b><a href="#descdef-counter-style-range">#descdef-counter-style-range</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-range">2. 
Counter Styles</a>
    <li><a href="#ref-for-descdef-counter-style-range①">3.5. 
Limiting the counter scope: the range descriptor</a> <a href="#ref-for-descdef-counter-style-range②">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-range③">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-descdef-counter-style-range④">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
    <li><a href="#ref-for-descdef-counter-style-range⑤">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
    <li><a href="#ref-for-descdef-counter-style-range⑥">7.2. 
Ethiopic Numeric Counter Style: ethiopic-numeric</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-range-auto">
   <b><a href="#valdef-counter-style-range-auto">#valdef-counter-style-range-auto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-range-auto">3.5. 
Limiting the counter scope: the range descriptor</a>
    <li><a href="#ref-for-valdef-counter-style-range-auto①">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-pad">
   <b><a href="#descdef-counter-style-pad">#descdef-counter-style-pad</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-pad">2. 
Counter Styles</a> <a href="#ref-for-descdef-counter-style-pad①">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-pad②">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a> <a href="#ref-for-descdef-counter-style-pad③">(2)</a> <a href="#ref-for-descdef-counter-style-pad④">(3)</a> <a href="#ref-for-descdef-counter-style-pad⑤">(4)</a> <a href="#ref-for-descdef-counter-style-pad⑥">(5)</a> <a href="#ref-for-descdef-counter-style-pad⑦">(6)</a> <a href="#ref-for-descdef-counter-style-pad⑧">(7)</a>
    <li><a href="#ref-for-descdef-counter-style-pad⑨">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-fallback">
   <b><a href="#descdef-counter-style-fallback">#descdef-counter-style-fallback</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-fallback">3.7. 
Defining fallback: the fallback descriptor</a> <a href="#ref-for-descdef-counter-style-fallback①">(2)</a> <a href="#ref-for-descdef-counter-style-fallback②">(3)</a> <a href="#ref-for-descdef-counter-style-fallback③">(4)</a>
    <li><a href="#ref-for-descdef-counter-style-fallback④">3.9. 
Speech Synthesis: the speak-as descriptor</a>
    <li><a href="#ref-for-descdef-counter-style-fallback⑤">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-descdef-counter-style-fallback⑥">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-symbols">
   <b><a href="#descdef-counter-style-symbols">#descdef-counter-style-symbols</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-symbols">3.1.1. 
Cycling Symbols: the cyclic system</a>
    <li><a href="#ref-for-descdef-counter-style-symbols①">3.1.2. 
Exhaustible Symbols: the fixed system</a>
    <li><a href="#ref-for-descdef-counter-style-symbols②">3.1.3. 
Repeating Symbols: the symbolic system</a>
    <li><a href="#ref-for-descdef-counter-style-symbols③">3.1.4. 
Bijective Numerals: the alphabetic system</a>
    <li><a href="#ref-for-descdef-counter-style-symbols④">3.1.5. 
Positional Numerals: the numeric system</a>
    <li><a href="#ref-for-descdef-counter-style-symbols⑤">3.1.7. 
Building from Existing Counter Styles: the extends system </a>
    <li><a href="#ref-for-descdef-counter-style-symbols⑥">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-descdef-counter-style-symbols⑦">(2)</a> <a href="#ref-for-descdef-counter-style-symbols⑧">(3)</a> <a href="#ref-for-descdef-counter-style-symbols⑨">(4)</a> <a href="#ref-for-descdef-counter-style-symbols①⓪">(5)</a> <a href="#ref-for-descdef-counter-style-symbols①①">(6)</a> <a href="#ref-for-descdef-counter-style-symbols①②">(7)</a> <a href="#ref-for-descdef-counter-style-symbols①③">(8)</a>
    <li><a href="#ref-for-descdef-counter-style-symbols①④">4. 
Defining Anonymous Counter Styles: the symbols() function</a> <a href="#ref-for-descdef-counter-style-symbols①⑤">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-symbols①⑥">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-additive-symbols">
   <b><a href="#descdef-counter-style-additive-symbols">#descdef-counter-style-additive-symbols</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-additive-symbols">3.1.6. 
Accumulating Numerals: the additive system</a> <a href="#ref-for-descdef-counter-style-additive-symbols①">(2)</a>
    <li><a href="#ref-for-descdef-counter-style-additive-symbols②">3.1.7. 
Building from Existing Counter Styles: the extends system </a>
    <li><a href="#ref-for-descdef-counter-style-additive-symbols③">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-descdef-counter-style-additive-symbols④">(2)</a> <a href="#ref-for-descdef-counter-style-additive-symbols⑤">(3)</a> <a href="#ref-for-descdef-counter-style-additive-symbols⑥">(4)</a>
    <li><a href="#ref-for-descdef-counter-style-additive-symbols⑦"> Changes since the Jun 2015 Candidate Recommendation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-symbol">
   <b><a href="#typedef-symbol">#typedef-symbol</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-symbol①">3.2. 
Formatting negative values: the negative descriptor</a> <a href="#ref-for-typedef-symbol②">(2)</a> <a href="#ref-for-typedef-symbol③">(3)</a> <a href="#ref-for-typedef-symbol④">(4)</a>
    <li><a href="#ref-for-typedef-symbol⑤">3.3. 
Symbols before the marker: the prefix descriptor</a> <a href="#ref-for-typedef-symbol⑥">(2)</a>
    <li><a href="#ref-for-typedef-symbol⑦">3.4. 
Symbols after the marker: the suffix descriptor</a> <a href="#ref-for-typedef-symbol⑧">(2)</a>
    <li><a href="#ref-for-typedef-symbol⑨">3.6. 
Zero-Padding and Constant-Width Representations: the pad descriptor</a> <a href="#ref-for-typedef-symbol①⓪">(2)</a> <a href="#ref-for-typedef-symbol①①">(3)</a> <a href="#ref-for-typedef-symbol①②">(4)</a> <a href="#ref-for-typedef-symbol①③">(5)</a> <a href="#ref-for-typedef-symbol①④">(6)</a> <a href="#ref-for-typedef-symbol①⑤">(7)</a> <a href="#ref-for-typedef-symbol①⑥">(8)</a> <a href="#ref-for-typedef-symbol①⑦">(9)</a>
    <li><a href="#ref-for-typedef-symbol①⑧">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-typedef-symbol①⑨">(2)</a> <a href="#ref-for-typedef-symbol②⓪">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="counter-symbol">
   <b><a href="#counter-symbol">#counter-symbol</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-counter-symbol">3.1.1. 
Cycling Symbols: the cyclic system</a> <a href="#ref-for-counter-symbol①">(2)</a> <a href="#ref-for-counter-symbol②">(3)</a> <a href="#ref-for-counter-symbol③">(4)</a> <a href="#ref-for-counter-symbol④">(5)</a> <a href="#ref-for-counter-symbol⑤">(6)</a> <a href="#ref-for-counter-symbol⑥">(7)</a>
    <li><a href="#ref-for-counter-symbol⑦">3.1.2. 
Exhaustible Symbols: the fixed system</a> <a href="#ref-for-counter-symbol⑧">(2)</a> <a href="#ref-for-counter-symbol⑨">(3)</a> <a href="#ref-for-counter-symbol①⓪">(4)</a> <a href="#ref-for-counter-symbol①①">(5)</a>
    <li><a href="#ref-for-counter-symbol①②">3.1.3. 
Repeating Symbols: the symbolic system</a> <a href="#ref-for-counter-symbol①③">(2)</a> <a href="#ref-for-counter-symbol①④">(3)</a> <a href="#ref-for-counter-symbol①⑤">(4)</a>
    <li><a href="#ref-for-counter-symbol①⑥">3.1.4. 
Bijective Numerals: the alphabetic system</a> <a href="#ref-for-counter-symbol①⑦">(2)</a> <a href="#ref-for-counter-symbol①⑧">(3)</a> <a href="#ref-for-counter-symbol①⑨">(4)</a> <a href="#ref-for-counter-symbol②⓪">(5)</a> <a href="#ref-for-counter-symbol②①">(6)</a> <a href="#ref-for-counter-symbol②②">(7)</a> <a href="#ref-for-counter-symbol②③">(8)</a>
    <li><a href="#ref-for-counter-symbol②④">3.1.5. 
Positional Numerals: the numeric system</a> <a href="#ref-for-counter-symbol②⑤">(2)</a> <a href="#ref-for-counter-symbol②⑥">(3)</a> <a href="#ref-for-counter-symbol②⑦">(4)</a> <a href="#ref-for-counter-symbol②⑧">(5)</a> <a href="#ref-for-counter-symbol②⑨">(6)</a> <a href="#ref-for-counter-symbol③⓪">(7)</a> <a href="#ref-for-counter-symbol③①">(8)</a>
    <li><a href="#ref-for-counter-symbol③②">3.1.6. 
Accumulating Numerals: the additive system</a> <a href="#ref-for-counter-symbol③③">(2)</a>
    <li><a href="#ref-for-counter-symbol③④">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a> <a href="#ref-for-counter-symbol③⑤">(2)</a> <a href="#ref-for-counter-symbol③⑥">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="additive-tuple">
   <b><a href="#additive-tuple">#additive-tuple</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-additive-tuple">3.1.6. 
Accumulating Numerals: the additive system</a> <a href="#ref-for-additive-tuple①">(2)</a> <a href="#ref-for-additive-tuple②">(3)</a> <a href="#ref-for-additive-tuple③">(4)</a>
    <li><a href="#ref-for-additive-tuple④">3.8. 
Marker characters: the symbols and additive-symbols descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-counter-style-speak-as">
   <b><a href="#descdef-counter-style-speak-as">#descdef-counter-style-speak-as</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-counter-style-speak-as">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-descdef-counter-style-speak-as①">(2)</a> <a href="#ref-for-descdef-counter-style-speak-as②">(3)</a> <a href="#ref-for-descdef-counter-style-speak-as③">(4)</a>
    <li><a href="#ref-for-descdef-counter-style-speak-as④">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-descdef-counter-style-speak-as⑤">7. 
Complex Predefined Counter Styles</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-speak-as-auto">
   <b><a href="#valdef-counter-style-speak-as-auto">#valdef-counter-style-speak-as-auto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-speak-as-auto">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-valdef-counter-style-speak-as-auto①">(2)</a> <a href="#ref-for-valdef-counter-style-speak-as-auto②">(3)</a>
    <li><a href="#ref-for-valdef-counter-style-speak-as-auto③">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-speak-as-bullets">
   <b><a href="#valdef-counter-style-speak-as-bullets">#valdef-counter-style-speak-as-bullets</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-speak-as-bullets">3.9. 
Speech Synthesis: the speak-as descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-speak-as-numbers">
   <b><a href="#valdef-counter-style-speak-as-numbers">#valdef-counter-style-speak-as-numbers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-speak-as-numbers">3.9. 
Speech Synthesis: the speak-as descriptor</a> <a href="#ref-for-valdef-counter-style-speak-as-numbers①">(2)</a>
    <li><a href="#ref-for-valdef-counter-style-speak-as-numbers②">7. 
Complex Predefined Counter Styles</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-speak-as-spell-out">
   <b><a href="#valdef-counter-style-speak-as-spell-out">#valdef-counter-style-speak-as-spell-out</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-speak-as-spell-out">3.9. 
Speech Synthesis: the speak-as descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="funcdef-symbols">
   <b><a href="#funcdef-symbols">#funcdef-symbols</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-funcdef-symbols">4. 
Defining Anonymous Counter Styles: the symbols() function</a> <a href="#ref-for-funcdef-symbols①">(2)</a> <a href="#ref-for-funcdef-symbols②">(3)</a> <a href="#ref-for-funcdef-symbols③">(4)</a> <a href="#ref-for-funcdef-symbols④">(5)</a>
    <li><a href="#ref-for-funcdef-symbols⑤">5. 
Extending list-style-type, counter(), and counters()</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-symbols-type">
   <b><a href="#typedef-symbols-type">#typedef-symbols-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-symbols-type">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-counter-style">
   <b><a href="#typedef-counter-style">#typedef-counter-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-counter-style">5. 
Extending list-style-type, counter(), and counters()</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="decimal">
   <b><a href="#decimal">#decimal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-decimal">2. 
Counter Styles</a>
    <li><a href="#ref-for-decimal①">3.1.5. 
Positional Numerals: the numeric system</a>
    <li><a href="#ref-for-decimal②">3.1.7. 
Building from Existing Counter Styles: the extends system </a> <a href="#ref-for-decimal③">(2)</a> <a href="#ref-for-decimal④">(3)</a>
    <li><a href="#ref-for-decimal⑤">3.7. 
Defining fallback: the fallback descriptor</a> <a href="#ref-for-decimal⑥">(2)</a>
    <li><a href="#ref-for-decimal⑦">4. 
Defining Anonymous Counter Styles: the symbols() function</a>
    <li><a href="#ref-for-decimal⑧">5. 
Extending list-style-type, counter(), and counters()</a> <a href="#ref-for-decimal⑨">(2)</a>
    <li><a href="#ref-for-decimal①⓪">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a> <a href="#ref-for-decimal①①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="decimal-leading-zero">
   <b><a href="#decimal-leading-zero">#decimal-leading-zero</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-decimal-leading-zero">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-arabic-indic">
   <b><a href="#valdef-counter-style-name-arabic-indic">#valdef-counter-style-name-arabic-indic</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-arabic-indic">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="armenian">
   <b><a href="#armenian">#armenian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-armenian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-upper-armenian">
   <b><a href="#valdef-counter-style-name-upper-armenian">#valdef-counter-style-name-upper-armenian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-upper-armenian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-lower-armenian">
   <b><a href="#valdef-counter-style-name-lower-armenian">#valdef-counter-style-name-lower-armenian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-lower-armenian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-bengali">
   <b><a href="#valdef-counter-style-name-bengali">#valdef-counter-style-name-bengali</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-bengali">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-cambodian">
   <b><a href="#valdef-counter-style-name-cambodian">#valdef-counter-style-name-cambodian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-cambodian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-khmer">
   <b><a href="#valdef-counter-style-name-khmer">#valdef-counter-style-name-khmer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-khmer">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cjk-decimal">
   <b><a href="#cjk-decimal">#cjk-decimal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cjk-decimal">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
    <li><a href="#ref-for-cjk-decimal①">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-cjk-decimal②">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-devanagari">
   <b><a href="#valdef-counter-style-name-devanagari">#valdef-counter-style-name-devanagari</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-devanagari">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="georgian">
   <b><a href="#georgian">#georgian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-georgian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-gujarati">
   <b><a href="#valdef-counter-style-name-gujarati">#valdef-counter-style-name-gujarati</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-gujarati">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-gurmukhi">
   <b><a href="#valdef-counter-style-name-gurmukhi">#valdef-counter-style-name-gurmukhi</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-gurmukhi">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="hebrew">
   <b><a href="#hebrew">#hebrew</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-hebrew">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a> <a href="#ref-for-hebrew①">(2)</a>
    <li><a href="#ref-for-hebrew②"> Changes since the Feb 2015 Candidate Recommendation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-kannada">
   <b><a href="#valdef-counter-style-name-kannada">#valdef-counter-style-name-kannada</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-kannada">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-lao">
   <b><a href="#valdef-counter-style-name-lao">#valdef-counter-style-name-lao</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-lao">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-malayalam">
   <b><a href="#valdef-counter-style-name-malayalam">#valdef-counter-style-name-malayalam</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-malayalam">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-mongolian">
   <b><a href="#valdef-counter-style-name-mongolian">#valdef-counter-style-name-mongolian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-mongolian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-myanmar">
   <b><a href="#valdef-counter-style-name-myanmar">#valdef-counter-style-name-myanmar</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-myanmar">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-oriya">
   <b><a href="#valdef-counter-style-name-oriya">#valdef-counter-style-name-oriya</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-oriya">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-persian">
   <b><a href="#valdef-counter-style-name-persian">#valdef-counter-style-name-persian</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-persian">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="lower-roman">
   <b><a href="#lower-roman">#lower-roman</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-lower-roman">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="upper-roman">
   <b><a href="#upper-roman">#upper-roman</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-upper-roman">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-tamil">
   <b><a href="#valdef-counter-style-name-tamil">#valdef-counter-style-name-tamil</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-tamil">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-telugu">
   <b><a href="#valdef-counter-style-name-telugu">#valdef-counter-style-name-telugu</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-telugu">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-thai">
   <b><a href="#valdef-counter-style-name-thai">#valdef-counter-style-name-thai</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-thai">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-tibetan">
   <b><a href="#valdef-counter-style-name-tibetan">#valdef-counter-style-name-tibetan</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-tibetan">6.1. 
Numeric: decimal, decimal-leading-zero, arabic-indic, armenian, upper-armenian, lower-armenian, bengali, cambodian, khmer, cjk-decimal, devanagari, georgian, gujarati, gurmukhi, hebrew, kannada, lao, malayalam, mongolian, myanmar, oriya, persian, lower-roman, upper-roman, tamil, telugu, thai, tibetan</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="lower-alpha">
   <b><a href="#lower-alpha">#lower-alpha</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-lower-alpha">3.1.4. 
Bijective Numerals: the alphabetic system</a>
    <li><a href="#ref-for-lower-alpha①">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="lower-latin">
   <b><a href="#lower-latin">#lower-latin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-lower-latin">3.9. 
Speech Synthesis: the speak-as descriptor</a>
    <li><a href="#ref-for-lower-latin①">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="upper-alpha">
   <b><a href="#upper-alpha">#upper-alpha</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-upper-alpha">3.1.3. 
Repeating Symbols: the symbolic system</a> <a href="#ref-for-upper-alpha①">(2)</a> <a href="#ref-for-upper-alpha②">(3)</a> <a href="#ref-for-upper-alpha③">(4)</a>
    <li><a href="#ref-for-upper-alpha④">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="upper-latin">
   <b><a href="#upper-latin">#upper-latin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-upper-latin">3.9. 
Speech Synthesis: the speak-as descriptor</a>
    <li><a href="#ref-for-upper-latin①">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="lower-greek">
   <b><a href="#lower-greek">#lower-greek</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-lower-greek">3.9. 
Speech Synthesis: the speak-as descriptor</a>
    <li><a href="#ref-for-lower-greek①">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="hiragana">
   <b><a href="#hiragana">#hiragana</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-hiragana">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="hiragana-iroha">
   <b><a href="#hiragana-iroha">#hiragana-iroha</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-hiragana-iroha">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="katakana">
   <b><a href="#katakana">#katakana</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-katakana">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="katakana-iroha">
   <b><a href="#katakana-iroha">#katakana-iroha</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-katakana-iroha">6.2. 
Alphabetic: lower-alpha, lower-latin, upper-alpha, upper-latin, lower-greek, hiragana, hiragana-iroha, katakana, katakana-iroha</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="disc">
   <b><a href="#disc">#disc</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-disc">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a> <a href="#ref-for-disc①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="circle">
   <b><a href="#circle">#circle</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-circle">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="square">
   <b><a href="#square">#square</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-square">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="disclosure-open">
   <b><a href="#disclosure-open">#disclosure-open</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-disclosure-open">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a> <a href="#ref-for-disclosure-open①">(2)</a> <a href="#ref-for-disclosure-open②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="disclosure-closed">
   <b><a href="#disclosure-closed">#disclosure-closed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-disclosure-closed">6.3. 
Symbolic: disc, circle, square, disclosure-open, disclosure-closed</a> <a href="#ref-for-disclosure-closed①">(2)</a> <a href="#ref-for-disclosure-closed②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-cjk-earthly-branch">
   <b><a href="#valdef-counter-style-name-cjk-earthly-branch">#valdef-counter-style-name-cjk-earthly-branch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-cjk-earthly-branch">6.4. 
Fixed: cjk-earthly-branch, cjk-heavenly-stem</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-cjk-heavenly-stem">
   <b><a href="#valdef-counter-style-name-cjk-heavenly-stem">#valdef-counter-style-name-cjk-heavenly-stem</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-cjk-heavenly-stem">6.4. 
Fixed: cjk-earthly-branch, cjk-heavenly-stem</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="japanese-informal">
   <b><a href="#japanese-informal">#japanese-informal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-japanese-informal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-japanese-informal①">7.1.1. 
Japanese: japanese-informal and japanese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="japanese-formal">
   <b><a href="#japanese-formal">#japanese-formal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-japanese-formal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-japanese-formal①">7.1.1. 
Japanese: japanese-informal and japanese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="korean-hangul-formal">
   <b><a href="#korean-hangul-formal">#korean-hangul-formal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-korean-hangul-formal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-korean-hangul-formal①">7.1.2. 
Korean: korean-hangul-formal, korean-hanja-informal, and korean-hanja-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="korean-hanja-informal">
   <b><a href="#korean-hanja-informal">#korean-hanja-informal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-korean-hanja-informal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-korean-hanja-informal①">7.1.2. 
Korean: korean-hangul-formal, korean-hanja-informal, and korean-hanja-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="korean-hanja-formal">
   <b><a href="#korean-hanja-formal">#korean-hanja-formal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-korean-hanja-formal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-korean-hanja-formal①">7.1.2. 
Korean: korean-hangul-formal, korean-hanja-informal, and korean-hanja-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="simp-chinese-informal">
   <b><a href="#simp-chinese-informal">#simp-chinese-informal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-simp-chinese-informal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-simp-chinese-informal①">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a> <a href="#ref-for-simp-chinese-informal②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="simp-chinese-formal">
   <b><a href="#simp-chinese-formal">#simp-chinese-formal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-simp-chinese-formal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-simp-chinese-formal①">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="trad-chinese-informal">
   <b><a href="#trad-chinese-informal">#trad-chinese-informal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-trad-chinese-informal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-trad-chinese-informal①">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a> <a href="#ref-for-trad-chinese-informal②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="trad-chinese-formal">
   <b><a href="#trad-chinese-formal">#trad-chinese-formal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-trad-chinese-formal">7.1. 
Longhand East Asian Counter Styles</a>
    <li><a href="#ref-for-trad-chinese-formal①">7.1.3. 
Chinese: simp-chinese-informal, simp-chinese-formal, trad-chinese-informal, and trad-chinese-formal</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-counter-style-name-ethiopic-numeric">
   <b><a href="#valdef-counter-style-name-ethiopic-numeric">#valdef-counter-style-name-ethiopic-numeric</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-counter-style-name-ethiopic-numeric">7.2. 
Ethiopic Numeric Counter Style: ethiopic-numeric</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="csscounterstylerule">
   <b><a href="#csscounterstylerule">#csscounterstylerule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csscounterstylerule">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-name">
   <b><a href="#dom-csscounterstylerule-name">#dom-csscounterstylerule-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-name">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-system">
   <b><a href="#dom-csscounterstylerule-system">#dom-csscounterstylerule-system</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-system">9.2. 
The CSSCounterStyleRule interface</a> <a href="#ref-for-dom-csscounterstylerule-system①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-symbols">
   <b><a href="#dom-csscounterstylerule-symbols">#dom-csscounterstylerule-symbols</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-symbols">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-additivesymbols">
   <b><a href="#dom-csscounterstylerule-additivesymbols">#dom-csscounterstylerule-additivesymbols</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-additivesymbols">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-negative">
   <b><a href="#dom-csscounterstylerule-negative">#dom-csscounterstylerule-negative</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-negative">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-prefix">
   <b><a href="#dom-csscounterstylerule-prefix">#dom-csscounterstylerule-prefix</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-prefix">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-suffix">
   <b><a href="#dom-csscounterstylerule-suffix">#dom-csscounterstylerule-suffix</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-suffix">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-range">
   <b><a href="#dom-csscounterstylerule-range">#dom-csscounterstylerule-range</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-range">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-pad">
   <b><a href="#dom-csscounterstylerule-pad">#dom-csscounterstylerule-pad</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-pad">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-speakas">
   <b><a href="#dom-csscounterstylerule-speakas">#dom-csscounterstylerule-speakas</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-speakas">9.2. 
The CSSCounterStyleRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csscounterstylerule-fallback">
   <b><a href="#dom-csscounterstylerule-fallback">#dom-csscounterstylerule-fallback</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csscounterstylerule-fallback">9.2. 
The CSSCounterStyleRule interface</a>
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
            </script><a class='link-error' href='/bikeshed/css-counter-styles-3/' id='generator' title='Bikeshed Link Errors'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>