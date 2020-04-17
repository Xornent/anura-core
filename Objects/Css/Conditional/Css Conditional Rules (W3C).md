<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Conditional Rules Module Level 3</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="testing" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="This module contains the features of CSS for conditional processing of parts of    style sheets, conditioned on capabilities of the processor or the    document the style sheet is being applied to.  It includes and extends the    functionality of CSS level&amp;nbsp;2 [[!CSS21]], which builds on CSS level&amp;nbsp;1    [[CSS1]].  The main extensions compared to level&amp;nbsp;2 are allowing nesting of    certain at-rules inside &apos;&apos;@media&apos;&apos;, and the addition of the &apos;&apos;@supports&apos;&apos; rule for    conditional processing." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/css3-conditional/" rel="canonical">
<script defer src="https://test.csswg.org/harness/annotate.js#!css-conditional-3_dev/css-conditional-3" type="text/javascript"></script>
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
<style>/* style-var-click-highlighting */

    var { cursor: pointer; }
    var.selected0 { background-color: #F4D200; box-shadow: 0 0 0 2px #F4D200; }
    var.selected1 { background-color: #FF87A2; box-shadow: 0 0 0 2px #FF87A2; }
    var.selected2 { background-color: #96E885; box-shadow: 0 0 0 2px #96E885; }
    var.selected3 { background-color: #3EEED2; box-shadow: 0 0 0 2px #3EEED2; }
    var.selected4 { background-color: #EACFB6; box-shadow: 0 0 0 2px #EACFB6; }
    var.selected5 { background-color: #82DDFF; box-shadow: 0 0 0 2px #82DDFF; }
    var.selected6 { background-color: #FFBCF2; box-shadow: 0 0 0 2px #FFBCF2; }
    </style>
 <script nonce='MWYQLIushdZefYTb0oqwvde59Vtj14Va3SWQ+Qc1/QY=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='MWYQLIushdZefYTb0oqwvde59Vtj14Va3SWQ+Qc1/QY=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="css-conditional-3\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
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
   <h1 class="p-name no-ref" id="title">CSS Conditional Rules Module Level 3</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2019-10-29">29 October 2019</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/css-conditional-3/">https://drafts.csswg.org/css-conditional-3/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/css3-conditional/">https://www.w3.org/TR/css3-conditional/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2013/CR-css3-conditional-20130404/" rel="prev">https://www.w3.org/TR/2013/CR-css3-conditional-20130404/</a>
      <dt>Test Suite:
      <dd><a href="http://test.csswg.org/suites/css-conditional-3_dev/nightly-unstable/">http://test.csswg.org/suites/css-conditional-3_dev/nightly-unstable/</a>
      <dt class="editor">Editor:
      <dd class="editor p-author h-card vcard" data-editor-id="15393"><a class="p-name fn u-url url" href="https://dbaron.org/">L. David Baron</a> (<a class="p-org org" href="https://www.mozilla.org/">Mozilla</a>)
      <dt>Issue Tracking:
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/css-conditional-3">GitHub Issues</a>
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/css-conditional-3/Overview.bs">GitHub Editor</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2019 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This module contains the features of CSS for conditional processing of parts of

  style sheets, conditioned on capabilities of the processor or the
  document the style sheet is being applied to.  It includes and extends the
  functionality of CSS level 2 <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a>, which builds on CSS level 1 <a data-link-type="biblio" href="#biblio-css1">[CSS1]</a>.  The main extensions compared to level 2 are allowing nesting of
  certain at-rules inside <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media">@media</a>, and the addition of the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports">@supports</a> rule for
  conditional processing.</p>
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
	When filing an issue, please put the text “css-conditional” in the title,
	preferably like this:
	“[css-conditional] <i data-lt>…summary of comment…</i>”.
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
    <li>The inclusion of @font-face rules and @keyframes rules as allowed within all of the @-rules in this specification is at risk, though only because of the relative rates of advancement of specifications.  If this specification is able to advance faster than one or both of the specifications defining those rules, then the inclusion of those rules will move from this specification to the specification defining those rules.
    <li>The addition of support for @-rules inside of conditional grouping rules is at risk; if interoperable implementations are not found, it may be removed to advance the other features in this specification to Proposed Recommendation.
   </ul>
   <p>“At-risk” is a W3C Process term-of-art, and does not necessarily imply that the feature is in danger of being dropped or delayed. It means that the WG believes the feature may have difficulty being interoperably implemented in a timely manner, and marking it as such allows the WG to drop the feature if necessary when transitioning to the Proposed Rec stage, without having to publish a new Candidate Rec without the feature first.</p>
  </div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li>
     <a href="#introduction"><span class="secno">1</span> <span class="content">Introduction</span></a>
     <ol class="toc">
      <li><a href="#context"><span class="secno">1.1</span> <span class="content">Background</span></a>
      <li><a href="#placement"><span class="secno">1.2</span> <span class="content">Module Interactions</span></a>
     </ol>
    <li><a href="#processing"><span class="secno">2</span> <span class="content">Processing of conditional group rules</span></a>
    <li><a href="#contents-of"><span class="secno">3</span> <span class="content"> Contents of conditional group rules</span></a>
    <li><a href="#use"><span class="secno">4</span> <span class="content"> Placement of conditional group rules</span></a>
    <li><a href="#at-media"><span class="secno">5</span> <span class="content"> Media-specific style sheets:  the <span class="css">@media</span> rule</span></a>
    <li>
     <a href="#at-supports"><span class="secno">6</span> <span class="content">Feature queries: the <span class="css">@supports</span> rule</span></a>
     <ol class="toc">
      <li><a href="#support-definition"><span class="secno">6.1</span> <span class="content">Definition of support</span></a>
     </ol>
    <li>
     <a href="#apis"><span class="secno">7</span> <span class="content">APIs</span></a>
     <ol class="toc">
      <li><a href="#extentions-to-cssrule-interface"><span class="secno">7.1</span> <span class="content"> Extensions to the <code class="highlight">CSSRule</code> interface</span></a>
      <li><a href="#the-cssconditionrule-interface"><span class="secno">7.2</span> <span class="content"> The <code class="highlight">CSSConditionRule</code> interface</span></a>
      <li><a href="#the-cssmediarule-interface"><span class="secno">7.3</span> <span class="content"> The <code class="highlight">CSSMediaRule</code> interface</span></a>
      <li><a href="#the-csssupportsrule-interface"><span class="secno">7.4</span> <span class="content"> The <code class="highlight">CSSSupportsRule</code> interface</span></a>
      <li><a href="#the-css-namespace"><span class="secno">7.5</span> <span class="content"> <span>The <code class="highlight">CSS</code> namespace, and the <code class="highlight" title>supports()</code> function</span></span></a>
     </ol>
    <li><a href="#priv-sec"><span class="secno"></span> <span class="content">Privacy and Security Considerations</span></a>
    <li><a href="#changes"><span class="secno">8</span> <span class="content"> Changes</span></a>
    <li><a href="#acknowledgments"><span class="secno"></span> <span class="content">Acknowledgments</span></a>
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
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="introduction"><span class="secno">1. </span><span class="content">Introduction</span><a class="self-link" href="#introduction"></a></h2>
   <h3 class="heading settled" data-level="1.1" id="context"><span class="secno">1.1. </span><span class="content">Background</span><a class="self-link" href="#context"></a></h3>
   <p><em>This section is not normative.</em></p>
   <p><a data-link-type="biblio" href="#biblio-css21">[CSS21]</a> defines one type of conditional group rule, the <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media①">@media</a> rule, and allows only style rules (not other @-rules)
  inside of it.  The <span class="css" id="ref-for-at-ruledef-media②">@media</span> rule provides the ability to
  have media-specific style sheets, which is also provided by style
  sheet linking features such as <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#at-ruledef-import" id="ref-for-at-ruledef-import">@import</a> and <code class="highlight"><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/semantics.html#the-link-element" id="ref-for-the-link-element">link</a></code>.  The restrictions on the contents of <span class="css" id="ref-for-at-ruledef-media③">@media</span> rules made them less useful; they have forced authors
  using CSS features involving @-rules in media-specific style sheets to
  use separate style sheets for each medium.</p>
   <p>This specification extends the rules for the contents of
  conditional group rules to allow other @-rules, which enables authors
  to combine CSS features involving @-rules with media specific style
  sheets within a single style sheet.</p>
   <p>This specification also defines an additional type of conditional
  group rule, <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports①">@supports</a>, to
  address author and user requirements.</p>
   <p>The <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports②">@supports</a> rule allows CSS to be conditioned on
  implementation support for CSS properties and values.  This rule makes
  it much easier for authors to use new CSS features and provide good
  fallback for implementations that do not support those features.  This
  is particularly important for CSS features that provide new layout
  mechanisms, and for other cases where a set of related styles needs to
  be conditioned on property support.</p>
   <h3 class="heading settled" data-level="1.2" id="placement"><span class="secno">1.2. </span><span class="content">Module Interactions</span><a class="self-link" href="#placement"></a></h3>
   <p>This module replaces and extends the <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media④">@media</a> rule
  feature defined in <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a> section 7.2.1 and
  incorporates the modifications previously made non-normatively by <a data-link-type="biblio" href="#biblio-mediaqueries-4">[MEDIAQUERIES-4]</a> section 1.</p>
   <h2 class="heading settled" data-level="2" id="processing"><span class="secno">2. </span><span class="content">Processing of conditional group rules</span><a class="self-link" href="#processing"></a></h2>
   <p>This specification defines some CSS <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#at-rule" id="ref-for-at-rule">at-rules</a>,
called <dfn data-dfn-type="dfn" data-export data-lt="conditional group rule" id="conditional-group-rule">conditional group rules<a class="self-link" href="#conditional-group-rule"></a></dfn>,
that associate a condition with a group of other
CSS rules.  These different rules allow testing different types of
conditions, but share common behavior for how their contents are used
when the condition is true and when the condition is false.</p>
   <div class="example" id="example-25d00670">
    <a class="self-link" href="#example-25d00670"></a> For example, this rule: 
<pre class="highlight"><c- n>@media</c-> print <c- p>{</c->
  <c- c>/* hide navigation controls when printing */</c->
  <c- f>#navigation </c-><c- p>{</c-> <c- k>display</c-><c- p>:</c-> none <c- p>}</c->
<c- p>}</c->
</pre>
    <p>causes a particular CSS rule
(making elements with ID “navigation” be display:none)
apply only when the style sheet is used for a print medium.</p>
   </div>
   <p>Each conditional group rule has a condition, which at any time
evaluates to true or false.  When the condition is true, CSS processors <strong>must</strong> apply the rules inside the group rule as though
they were at the group rule’s location; when the condition is false, CSS
processors <strong>must not</strong> apply any of rules inside the group
rule.  The current state of the condition does not affect the CSS object
model, in which the contents of the group rule always remain within the
group rule.</p>
   <p>This means that when multiple conditional group rules are nested,
a rule inside of both of them applies only when all of the rules'
conditions are true.</p>
   <div class="example" id="example-cbc86bba">
    <a class="self-link" href="#example-cbc86bba"></a>For example, with this set of nested rules: 
<pre class="highlight"><c- n>@media</c-> print <c- p>{</c-> <c- c>/* rule (1) */</c->
  <c- c>/* hide navigation controls when printing */</c->
  <c- f>#navigation </c-><c- p>{</c-> <c- k>display</c-><c- p>:</c-> none <c- p>}</c->
  <c- n>@media</c-> <c- p>(</c->max-width<c- f>: 12cm) </c-><c- p>{</c-> <c- c>/* rule (2) */</c->
    <c- c>/* keep notes in flow when printing to narrow pages */</c->
    .note { float: none }
  }
}
</pre>
    <p>the condition of the rule marked (1) is true for print media, and the
condition of the rule marked (2) is true when the width of the display
area (which for print media is the page box) is less than or equal to
12cm.  Thus the rule <span class="css">#navigation { display: none }</span> applies
whenever this style sheet is applied to print media, and the rule <span class="css">.note { float: none }</span> is applied only when the style sheet
is applied to print media <em>and</em> the width of the page box is less
than or equal to 12 centimeters.</p>
   </div>
   <p></p>
   <p>When the condition for a conditional group rule changes, CSS
processors <strong>must</strong> reflect that the rules now apply or no
longer apply, except for properties whose definitions define effects of
computed values that persist past the lifetime of that value (such as
for some properties in <a data-link-type="biblio" href="#biblio-css3-transitions">[CSS3-TRANSITIONS]</a> and <a data-link-type="biblio" href="#biblio-css3-animations">[CSS3-ANIMATIONS]</a>).</p>
   <h2 class="heading settled" data-level="3" id="contents-of"><span class="secno">3. </span><span class="content"> Contents of conditional group rules</span><a class="self-link" href="#contents-of"></a></h2>
   <p>All <a data-link-type="dfn">conditional rules</a> are defined to take a <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-stylesheet" id="ref-for-typedef-stylesheet">&lt;stylesheet></a> in their block,
which means they can accept any rule that is normally allowed at the top-level of a stylesheet,
and not otherwise restricted.
(For example, an <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#at-ruledef-import" id="ref-for-at-ruledef-import①">@import</a> rule must appear at the actual beginning of a stylesheet,
and so is not valid inside of another rule.)</p>
   <p>Invalid or unknown rules inside the <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-stylesheet" id="ref-for-typedef-stylesheet①">&lt;stylesheet></a> must be considered invalid and ignored,
but do not invalidate the <a data-link-type="dfn">conditional rule</a>.</p>
   <h2 class="heading settled" data-level="4" id="use"><span class="secno">4. </span><span class="content"> Placement of conditional group rules</span><a class="self-link" href="#use"></a></h2>
   <p>Conditional group rules are allowed at the top-level of a style
sheet, and inside other conditional group rules.  CSS processors <strong>must</strong> process such rules as <a href="#processing">described above</a>.</p>
   <p>Any rules that are not allowed after a style rule (e.g., <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-syntax-3/#at-ruledef-charset" id="ref-for-at-ruledef-charset">@charset</a>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#at-ruledef-import" id="ref-for-at-ruledef-import②">@import</a>, or <span class="css">@namespace</span> rules) are also not allowed after a
conditional group rule.  Therefore, style sheets <strong>must
not</strong> place such rules after a conditional group rules, and CSS
processors <strong>must</strong> ignore such rules.</p>
   <h2 class="heading settled" data-level="5" id="at-media"><span class="secno">5. </span><span class="content"> Media-specific style sheets:  the <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media⑤">@media</a> rule</span><a class="self-link" href="#at-media"></a></h2>
   <p>The <dfn class="dfn-paneled css" data-dfn-type="at-rule" data-export id="at-ruledef-media">@media</dfn> rule
is a conditional group rule whose condition is a media query.
Its syntax is:</p>
<pre class="prod def">@media <a class="production" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-media-query-list" id="ref-for-typedef-media-query-list">&lt;media-query-list></a> {
  <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-stylesheet" id="ref-for-typedef-stylesheet②">&lt;stylesheet></a>
}
</pre>
   <p>It consists of the at-keyword <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media⑥">@media</a> followed by a (possibly empty) media query list
(as defined in <a data-link-type="biblio" href="#biblio-mediaqueries-4">[MEDIAQUERIES-4]</a>),
followed by a block containing arbitrary rules.
The condition of the rule is the result of the media query.</p>
   <div class="example" id="example-0eba231f">
    <a class="self-link" href="#example-0eba231f"></a> This <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media⑦">@media</a> rule: 
<pre class="highlight"><c- n>@media</c-> screen and <c- p>(</c->min-width<c- f>: 35em),</c->
<c- f>       print and (min-width: 40em) </c-><c- p>{</c->
  #section_navigation { float: left; width: 10em; }
}
</pre>
    <p>has the condition <span class="css">screen and (min-width: 35em), print and (min-width: 40em)</span>,
which is true for screen displays
whose viewport is at least 35 times the initial font size
and for print displays
whose viewport is at least 40 times the initial font size.
When either of these is true,
the condition of the rule is true,
and the rule <span class="css">#section_navigation { float: left; width: 10em; }</span> is applied.</p>
   </div>
   <h2 class="heading settled" data-level="6" id="at-supports"><span class="secno">6. </span><span class="content">Feature queries: the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports③">@supports</a> rule</span><a class="self-link" href="#at-supports"></a></h2>
   <p>The <dfn class="dfn-paneled css" data-dfn-type="at-rule" data-export id="at-ruledef-supports">@supports</dfn> rule is a conditional group
rule whose condition tests whether the user agent supports CSS
property:value pairs.  Authors can use it to write style sheets that use
new features when available but degrade gracefully when those features
are not supported.  CSS has existing mechanisms for graceful
degradation, such as ignoring unsupported properties or values, but
these are not always sufficient when large groups of styles need to be
tied to the support for certain features, as is the case for use of new
layout system features.</p>
   <p>The syntax of the condition in the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports④">@supports</a> rule
is similar to that defined for <a class="production css" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-media-condition" id="ref-for-typedef-media-condition">&lt;media-condition></a> in <a data-link-type="biblio" href="#biblio-mediaqueries-4">[MEDIAQUERIES-4]</a>:</p>
   <ul>
    <li data-md>
     <p>negation is needed so that
the new-feature styles and the fallback styles
can be separated
(within the forward-compatible grammar’s rules for the syntax of @-rules),
and not required to override each other.</p>
    <li data-md>
     <p>conjunction (and) is needed so that
multiple required features can be tested.</p>
    <li data-md>
     <p>disjunction (or) is needed
when there are multiple alternative features for a set of styles,
particularly when some of those alternatives are vendor-prefixed properties or values.</p>
    <li data-md>
     <p>"unknown" values (neither true nor false) are needed
to allow for future-compatibility,
so new types of support queries can be added
and treated sensibly in older UAs.</p>
   </ul>
   <p>Therefore, the syntax of the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports⑤">@supports</a> rule allows
testing for property:value pairs, and arbitrary conjunctions (and),
disjunctions (or), and negations (not) of them.</p>
   <p>The syntax of the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports⑥">@supports</a> rule is:</p>
<pre class="prod def">@supports <a class="production" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition">&lt;supports-condition></a> {
  <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-stylesheet" id="ref-for-typedef-stylesheet③">&lt;stylesheet></a>
}
</pre>
   <p>with <a class="production css" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition①">&lt;supports-condition></a> defined as:</p>
<pre class="prod def"><dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-supports-condition">&lt;supports-condition></dfn> = not <a class="production" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens">&lt;supports-in-parens></a>
                     <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one">|</a> <a class="production" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens①">&lt;supports-in-parens></a> [ and <a class="production" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens②">&lt;supports-in-parens></a> ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-zero-plus" id="ref-for-mult-zero-plus">*</a>
                     <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①">|</a> <a class="production" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens③">&lt;supports-in-parens></a> [ or <a class="production" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens④">&lt;supports-in-parens></a> ]<a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-zero-plus" id="ref-for-mult-zero-plus①">*</a>
<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-supports-in-parens">&lt;supports-in-parens></dfn> = ( <a class="production" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition②">&lt;supports-condition></a> ) <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one②">|</a> <a class="production" data-link-type="type" href="#typedef-supports-feature" id="ref-for-typedef-supports-feature">&lt;supports-feature></a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one③">|</a> <a class="production" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed" id="ref-for-typedef-general-enclosed">&lt;general-enclosed></a>
<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-supports-feature">&lt;supports-feature></dfn> = <a class="production" data-link-type="type" href="#typedef-supports-decl" id="ref-for-typedef-supports-decl">&lt;supports-decl></a>
<dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-supports-decl">&lt;supports-decl></dfn> = ( <a class="production" data-link-type="type" href="https://drafts.csswg.org/css-cascade-4/#typedef-declaration" id="ref-for-typedef-declaration">&lt;declaration></a> )
</pre>
   <p>The above grammar is purposely very loose for forwards-compatibility reasons,
since the <a class="production css" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed" id="ref-for-typedef-general-enclosed①">&lt;general-enclosed></a> production
allows for substantial future extensibility.
Any <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports⑦">@supports</a> rule that does not parse according to the grammar above
(that is, a rule that does not match this loose grammar
which includes the <span class="production" id="ref-for-typedef-general-enclosed②">&lt;general-enclosed></span> production)
is invalid.
Style sheets <strong>must not</strong> use such a rule and
processors <strong>must</strong> ignore such a rule (including all of its contents).</p>
   <p>Each of these grammar terms is associated with a boolean result,
as follows:</p>
   <dl>
    <dt data-md><a class="production css" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition③">&lt;supports-condition></a>
    <dt data-md><a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens⑤">&lt;supports-in-parens></a>
    <dd data-md>
     <p>The result is the result of the child subexpression.</p>
    <dt data-md>not <a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens⑥">&lt;supports-in-parens></a>
    <dd data-md>
     <p>The result is the negation of the <a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens⑦">&lt;supports-in-parens></a> term.
The negation of unknown is unknown.</p>
    <dt data-md><a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens⑧">&lt;supports-in-parens></a> [ and <span class="production" id="ref-for-typedef-supports-in-parens⑨">&lt;supports-in-parens></span> ]*
    <dd data-md>
     <p>The result is true if all of the <a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens①⓪">&lt;supports-in-parens></a> child terms are true,
false if at least one of the <span class="production" id="ref-for-typedef-supports-in-parens①①">&lt;supports-in-parens></span> is false,
and unknown otherwise.</p>
    <dt data-md><a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens①②">&lt;supports-in-parens></a> [ or <span class="production" id="ref-for-typedef-supports-in-parens①③">&lt;supports-in-parens></span> ]*
    <dd data-md>
     <p>The result is false if all of the <a class="production css" data-link-type="type" href="#typedef-supports-in-parens" id="ref-for-typedef-supports-in-parens①④">&lt;supports-in-parens></a> child terms are false,
true if at least one of the <span class="production" id="ref-for-typedef-supports-in-parens①⑤">&lt;supports-in-parens></span> is true,
and unknown otherwise.</p>
    <dt data-md><a class="production css" data-link-type="type" href="#typedef-supports-decl" id="ref-for-typedef-supports-decl①">&lt;supports-decl></a>
    <dd data-md>
     <p>The result is true if the UA <a data-link-type="dfn" href="#dfn-support" id="ref-for-dfn-support">supports</a> the declaration within the parentheses.</p>
    <dt data-md><a class="production css" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed" id="ref-for-typedef-general-enclosed③">&lt;general-enclosed></a>
    <dd data-md>
     <p>The result is unknown.</p>
     <p>Authors must not use <a class="production css" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed" id="ref-for-typedef-general-enclosed④">&lt;general-enclosed></a> in their stylesheets. <span class="note">It exists only for future-compatibility,
so that new syntax additions do not invalidate too much of a <a class="production css" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition④">&lt;supports-condition></a> in older user agents.</span></p>
   </dl>
   <p>The condition of the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports⑧">@supports</a> rule
is the result of the <a class="production css" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition⑤">&lt;supports-condition></a> in its prelude.</p>
   <div class="example" id="example-85c2765a">
    <a class="self-link" href="#example-85c2765a"></a> For example, the following rule 
<pre class="highlight"><c- n>@supports</c-> <c- p>(</c-> display<c- f>: flex ) </c-><c- p>{</c->
  body<c- p>,</c-> #navigation<c- p>,</c-> #content { display: flex; }
  #navigation { background: blue; color: white; }
  #article { background: white; color: black; }
}
</pre>
    <p>applies the rules inside the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports⑨">@supports</a> rule only when <a class="css" data-link-type="propdesc" href="https://drafts.csswg.org/css-display-3/#propdef-display" id="ref-for-propdef-display">display: flex</a> is supported.</p>
   </div>
   <div class="example" id="example-affdf0ec">
    <a class="self-link" href="#example-affdf0ec"></a> The following example shows an additional <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports①⓪">@supports</a> rule that can
be used to provide an alternative for when <a class="css" data-link-type="propdesc" href="https://drafts.csswg.org/css-display-3/#propdef-display" id="ref-for-propdef-display①">display: flex</a> is not
supported: 
<pre class="highlight"><c- n>@supports</c-> not <c- p>(</c-> display<c- f>: flex ) </c-><c- p>{</c->
  body { width: 100%; height: 100%; background: white; color: black; }
  #navigation { width: 25%; }
  #article { width: 75%; }
}
</pre>
    <p>Note that the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visudet.html#propdef-width" id="ref-for-propdef-width">width</a> declarations may be harmful to the
flex-based layout, so it is important that they be present only in
the non-flex styles.</p>
   </div>
   <div class="example" id="example-eff3ddab">
    <a class="self-link" href="#example-eff3ddab"></a> The following example checks for support for the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow" id="ref-for-propdef-box-shadow">box-shadow</a> property, including checking for support for vendor-prefixed versions of
it.  When the support is present, it specifies both <span class="property" id="ref-for-propdef-box-shadow①">box-shadow</span> (with
the prefixed versions) and <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border" id="ref-for-propdef-border">border</a> in a way what would cause the box to
become invisible were <span class="property" id="ref-for-propdef-box-shadow②">box-shadow</span> not supported. 
<pre class="highlight"><c- f>.noticebox </c-><c- p>{</c->
  <c- k>border</c-><c- p>:</c-> <c- m>1</c-><c- l>px</c-> solid black<c- p>;</c->
  <c- k>padding</c-><c- p>:</c-> <c- m>1</c-><c- l>px</c-><c- p>;</c->
<c- p>}</c->
<c- n>@supports</c-> <c- p>(</c-> box-shadow<c- f>: 0 0 2px black inset ) or</c->
<c- f>          ( -moz-box-shadow: 0 0 2px black inset ) or</c->
<c- f>          ( -webkit-box-shadow: 0 0 2px black inset ) or</c->
<c- f>          ( -o-box-shadow: 0 0 2px black inset ) </c-><c- p>{</c->
  .noticebox {
    -moz-box-shadow: 0 0 2px black inset;
    -webkit-box-shadow: 0 0 2px black inset;
    -o-box-shadow: 0 0 2px black inset;
    box-shadow: 0 0 2px black inset; /* unprefixed last */
    /* override the rule above the @supports rule */
    border: none;
    padding: 2px;
  }
}
</pre>
   </div>
   <p>To avoid confusion between <span class="css">and</span> and <span class="css">or</span>, the syntax requires
that both <span class="css">and</span> and <span class="css">or</span> be specified explicitly (rather than, say,
using commas or spaces for one of them).  Likewise, to avoid confusion
caused by precedence rules, the syntax does not allow <span class="css">and</span>, <span class="css">or</span>,
and <span class="css">not</span> operators to be mixed without a layer of parentheses.</p>
   <div class="example" id="example-9f817e66">
    <a class="self-link" href="#example-9f817e66"></a> For example, the following rule is not valid: 
<pre class="illegal highlight"><c- n>@supports</c-> <c- p>(</c->transition-property<c- f>: color) or</c->
<c- f>          (animation-name: foo) and</c->
<c- f>          (transform: rotate(10deg)) </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
    <p>Instead, authors must write one of the following:</p>
<pre class="highlight"><c- n>@supports</c-> <c- p>((</c->transition-property<c- f>: color) or</c->
<c- f>           (animation-name: foo)) and</c->
<c- f>          (transform: rotate(10deg)) </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
<pre class="highlight"><c- n>@supports</c-> <c- p>(</c->transition-property<c- f>: color) or</c->
<c- f>          ((animation-name: foo) and</c->
<c- f>           (transform: rotate(10deg))) </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
   </div>
   <p>The declaration being tested must always occur within parentheses,
when it is the only thing in the expression.</p>
   <div class="example" id="example-c0c9f2d4">
    <a class="self-link" href="#example-c0c9f2d4"></a> For example, the following rule is not valid: 
<pre class="illegal highlight"><c- n>@supports</c-> display<c- f>: flex </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
    <p>Instead, authors must write:</p>
<pre class="highlight"><c- n>@supports</c-> <c- p>(</c->display<c- f>: flex) </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
   </div>
   <p>The syntax allows extra parentheses when they are not needed.  This
flexibility is sometimes useful for authors (for example, when
commenting out parts of an expression) and may also be useful for
authoring tools.</p>
   <div class="example" id="example-1ef03172">
    <a class="self-link" href="#example-1ef03172"></a> For example, authors may write: 
<pre class="highlight"><c- n>@supports</c-> <c- p>((</c->display<c- f>: flex)) </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
   </div>
   <p>A trailing <span class="css">!important</span> on a declaration being tested is allowed,
though it won’t change the validity of the declaration.</p>
   <div class="example" id="example-afd082e5">
    <a class="self-link" href="#example-afd082e5"></a> For example, the following rule is valid: 
<pre class="highlight"><c- n>@supports</c-> <c- p>(</c->display<c- f>: flex !important) </c-><c- p>{</c->
  <c- c>/* ... */</c->
<c- p>}</c->
</pre>
   </div>
   <h3 class="heading settled" data-level="6.1" id="support-definition"><span class="secno">6.1. </span><span class="content">Definition of support</span><a class="self-link" href="#support-definition"></a></h3>
   <p>For forward-compatibility, <a href="https://www.w3.org/TR/CSS21/syndata.html#declaration">section 4.1.8
(Declarations and properties)</a> of <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a> defines rules for handling invalid properties and values.
CSS processors that
do not implement or partially implement a specification <strong>must</strong> treat any part of a value that they
do not implement, or
do not have a usable level of support for,
as invalid according to this rule
for handling invalid properties and values,
and therefore <strong>must</strong> discard the declaration as a parse error.</p>
   <p>A CSS processor is considered to <dfn class="dfn-paneled" data-dfn-for="CSS" data-dfn-type="dfn" data-export id="dfn-support">support</dfn> a declaration (consisting of a property and value) if it accepts that
declaration (rather than discarding it as a parse error).
If a processor does not implement, with a usable level of support,
the value given,
then it <strong>must not</strong> accept the declaration or claim support for it.</p>
   <p class="note" role="note"><span>Note:</span> Note that properties or values
whose support is effectively disabled by user preferences
are still considered as supported by this definition.
For example, if a user has enabled a high-contrast mode
that causes colors to be overridden,
the CSS processor is still considered to support the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-4/#propdef-color" id="ref-for-propdef-color">color</a> property
even though declarations of the <span class="property" id="ref-for-propdef-color①">color</span> property may have no effect.
On the other hand, a developer-facing preference
whose purpose is to enable or disable support for an experimental CSS feature
does affect this definition of support.</p>
   <p>These rules (and the equivalence between them) allow
authors to use fallback (either in the <a data-link-type="biblio" href="#biblio-css1">[CSS1]</a> sense of declarations
that are overridden by later declarations or with the new capabilities
provided by the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports①①">@supports</a> rule in this specification) that works
correctly for the features implemented.  This applies especially to
compound values; implementations must implement all parts of the value
in order to consider the declaration supported, either inside a style rule
or in the declaration condition of an <span class="css" id="ref-for-at-ruledef-supports①②">@supports</span> rule.</p>
   <h2 class="heading settled" data-level="7" id="apis"><span class="secno">7. </span><span class="content">APIs</span><a class="self-link" href="#apis"></a></h2>
   <h3 class="heading settled" data-level="7.1" id="extentions-to-cssrule-interface"><span class="secno">7.1. </span><span class="content"> Extensions to the <code class="highlight">CSSRule</code> interface</span><a class="self-link" href="#extentions-to-cssrule-interface"></a></h3>
   <p>The <code class="highlight">CSSRule</code> interface is extended as follows:</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-supports_rule"><code class="highlight"><c- g>SUPPORTS_RULE</c-></code><a class="self-link" href="#dom-cssrule-supports_rule"></a></dfn> = 12;
};
</pre>
   <h3 class="heading settled" data-level="7.2" id="the-cssconditionrule-interface"><span class="secno">7.2. </span><span class="content"> The <code class="highlight">CSSConditionRule</code> interface</span><a class="self-link" href="#the-cssconditionrule-interface"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#cssconditionrule" id="ref-for-cssconditionrule">CSSConditionRule</a></code> interface represents
all the “conditional” at-rules,
  which consist of a condition and a statement block.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssconditionrule"><code class="highlight"><c- g>CSSConditionRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssgroupingrule" id="ref-for-cssgroupingrule"><c- n>CSSGroupingRule</c-></a> {
    <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSConditionRule" data-dfn-type="attribute" data-export data-type="CSSOMString" id="dom-cssconditionrule-conditiontext"><code class="highlight"><c- g>conditionText</c-></code><a class="self-link" href="#dom-cssconditionrule-conditiontext"></a></dfn>;
};
</pre>
   <dl class="idl-attributes">
    <dt><code class="highlight">conditionText</code> of type <code class="highlight">CSSOMString</code> 
    <dd>
      The <code class="highlight">conditionText</code> attribute represents
    the condition of the rule.
    Since what this condition does
    varies between the derived interfaces of <code class="highlight">CSSConditionRule</code>,
    those derived interfaces
    may specify different behavior for this attribute
    (see, for example, <code class="highlight">CSSMediaRule</code> below).
    In the absence of such rule-specific behavior,
    the following rules apply: 
     <p>The <code class="highlight">conditionText</code> attribute, on getting, must return
    the result of serializing the associated condition.</p>
     <p>On setting the <code class="highlight">conditionText</code> attribute these steps
      must be run:</p>
     <ol>
      <li>Trim the given value of white space. 
      <li>If the given value matches the grammar of the
        appropriate condition production for the given rule,
        replace the associated CSS condition with the given value. 
      <li>Otherwise, do nothing. 
     </ol>
   </dl>
   <h3 class="heading settled" data-level="7.3" id="the-cssmediarule-interface"><span class="secno">7.3. </span><span class="content"> The <code class="highlight">CSSMediaRule</code> interface</span><a class="self-link" href="#the-cssmediarule-interface"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#cssmediarule" id="ref-for-cssmediarule">CSSMediaRule</a></code> interface represents a <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media⑧">@media</a> at-rule:</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssmediarule"><code class="highlight"><c- g>CSSMediaRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssconditionrule" id="ref-for-cssconditionrule①"><c- n>CSSConditionRule</c-></a> {
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="https://drafts.csswg.org/cssom-1/#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext"><c- n>mediaText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#medialist" id="ref-for-medialist"><c- n>MediaList</c-></a> <dfn class="idl-code" data-dfn-for="CSSMediaRule" data-dfn-type="attribute" data-export data-readonly data-type="MediaList" id="dom-cssmediarule-media"><code class="highlight"><c- g>media</c-></code><a class="self-link" href="#dom-cssmediarule-media"></a></dfn>;
};
</pre>
   <dl class="idl-attributes">
    <dt><code class="highlight">media</code> of type <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#medialist" id="ref-for-medialist①">MediaList</a></code>, readonly 
    <dd>The <code class="highlight">media</code> attribute must return a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#medialist" id="ref-for-medialist②">MediaList</a></code> object
    for the list of media queries specified with the <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media⑨">@media</a> at-rule. 
    <dt><code class="highlight">conditionText</code> of type <code class="highlight">CSSOMString</code> (CSSMediaRule-specific definition for attribute on CSSConditionRule) 
    <dd>
     The <code class="highlight">conditionText</code> attribute (defined on the <code class="highlight">CSSConditionRule</code> parent rule),
    on getting, must return the value of <code class="highlight">media.mediaText</code> on the rule. 
     <p>Setting the <code class="highlight">conditionText</code> attribute
      must set the <code class="highlight">media.mediaText</code> attribute on the rule.</p>
   </dl>
   <h3 class="heading settled" data-level="7.4" id="the-csssupportsrule-interface"><span class="secno">7.4. </span><span class="content"> The <code class="highlight">CSSSupportsRule</code> interface</span><a class="self-link" href="#the-csssupportsrule-interface"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#csssupportsrule" id="ref-for-csssupportsrule">CSSSupportsRule</a></code> interface represents a <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports①③">@supports</a> rule.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="csssupportsrule"><code class="highlight"><c- g>CSSSupportsRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssconditionrule" id="ref-for-cssconditionrule②"><c- n>CSSConditionRule</c-></a> {
};
</pre>
   <dl class="idl-attributes">
    <dt><code class="highlight">conditionText</code> of type <code class="highlight">CSSOMString</code> (CSSSupportsRule-specific definition for attribute on CSSConditionRule) 
    <dd>The <code class="highlight">conditionText</code> attribute (defined on the <code class="highlight">CSSConditionRule</code> parent rule),
    on getting, must return the condition that was specified,
    without any logical simplifications,
    so that the returned condition will evaluate to the same result
    as the specified condition
    in any conformant implementation of this specification
    (including implementations that implement future extensions
    allowed by the <a class="production css" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed" id="ref-for-typedef-general-enclosed⑤">&lt;general-enclosed></a> extensibility mechanism in this specification).
    In other words,
    token stream simplifications are allowed
    (such as reducing whitespace to a single space
    or omitting it in cases where it is known to be optional),
    but logical simplifications (such as removal of unneeded parentheses,
    or simplification based on evaluating results) are not allowed. 
   </dl>
   <h3 class="heading settled" data-level="7.5" id="the-css-namespace"><span class="secno">7.5. </span><span class="content"> <span id="the-css-interface">The <code class="highlight">CSS</code> namespace, and the <code class="highlight" title>supports()</code> function</span></span><a class="self-link" href="#the-css-namespace"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#namespacedef-css" id="ref-for-namespacedef-css">CSS</a></code> namespace holds useful CSS-related functions that do not belong elsewhere.</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>namespace</c-> <a class="idl-code" data-link-type="namespace" href="https://drafts.csswg.org/cssom-1/#namespacedef-css" id="ref-for-namespacedef-css①"><c- g>CSS</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CSS" data-dfn-type="method" data-export data-lt="supports(property, value)" id="dom-css-supports"><code class="highlight"><c- g>supports</c-></code></dfn>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSS/supports(property, value)" data-dfn-type="argument" data-export id="dom-css-supports-property-value-property"><code class="highlight"><c- g>property</c-></code><a class="self-link" href="#dom-css-supports-property-value-property"></a></dfn>, <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSS/supports(property, value)" data-dfn-type="argument" data-export id="dom-css-supports-property-value-value"><code class="highlight"><c- g>value</c-></code><a class="self-link" href="#dom-css-supports-property-value-value"></a></dfn>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CSS" data-dfn-type="method" data-export data-lt="supports(conditionText)" id="dom-css-supports-conditiontext"><code class="highlight"><c- g>supports</c-></code></dfn>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSS/supports(conditionText)" data-dfn-type="argument" data-export id="dom-css-supports-conditiontext-conditiontext"><code class="highlight"><c- g>conditionText</c-></code><a class="self-link" href="#dom-css-supports-conditiontext-conditiontext"></a></dfn>);
};
</pre>
   <dl class="idl-methods">
    <dt><code class="highlight">supports(CSSOMString property, CSSOMString value)</code>, returns <code class="highlight">boolean</code> 
    <dt><code class="highlight">supports(CSSOMString conditionText)</code>, returns <code class="highlight">boolean</code> 
    <dd>
      When the <code class="idl"><a data-link-type="idl" href="#dom-css-supports" id="ref-for-dom-css-supports">supports(property, value)</a></code> method is invoked
		with two arguments <var>property</var> and <var>value</var>: 
     <div class="algorithm" data-algorithm="supports(property, value)">
      <ol>
       <li data-md>
        <p>If <var>property</var> is an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive">ASCII case-insensitive</a> match
for any defined CSS property that the UA supports,
and <var>value</var> successfully <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar">parses</a> according to that property’s grammar,
return <code class="highlight">true</code>.</p>
       <li data-md>
        <p>Otherwise, if <var>property</var> is a <a data-link-type="dfn" href="https://drafts.css-houdini.org/css-typed-om-1/#custom-property-name-string" id="ref-for-custom-property-name-string">custom property name string</a>,
return <code class="highlight">true</code>.</p>
       <li data-md>
        <p>Otherwise, return <code class="highlight">false</code>.</p>
      </ol>
      <p class="note" role="note"><span>Note:</span> No CSS escape or whitespace processing is performed on the property name,
      so <code class="highlight">CSS.supports(" width", "5px")</code> will return <code class="highlight">false</code>,
      as " width" isn’t the name of any property due to the leading space.</p>
     </div>
     <p>When the <code class="idl"><a data-link-type="idl" href="#dom-css-supports-conditiontext" id="ref-for-dom-css-supports-conditiontext">supports(conditionText)</a></code> method is invoked</p>
      with a single <var>conditionText</var> argument: 
     <div class="algorithm" data-algorithm="supports(conditionText)">
      <ol>
       <li data-md>
        <p>If <var>conditionText</var>, <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar①">parsed</a> and evaluated as a <a class="production css" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition⑥">&lt;supports-condition></a>,
would return true,
return <code class="highlight">true</code>.</p>
       <li data-md>
        <p>Otherwise,
If <var>conditionText</var>,
wrapped in parentheses
and then <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar②">parsed</a> and evaluated as a <a class="production css" data-link-type="type" href="#typedef-supports-condition" id="ref-for-typedef-supports-condition⑦">&lt;supports-condition></a>,
would return true,
return <code class="highlight">true</code>.</p>
       <li data-md>
        <p>Otherwise, return <code class="highlight">false</code>.</p>
      </ol>
     </div>
   </dl>
   <h2 class="no-num heading settled" id="priv-sec"><span class="content">Privacy and Security Considerations</span><a class="self-link" href="#priv-sec"></a></h2>
   <p>This spec introduces no new security considerations.</p>
   <p>Various features in this specification,
associated mainly with the <a class="css" data-link-type="maybe" href="#at-ruledef-media" id="ref-for-at-ruledef-media①⓪">@media</a> rule
but also to some degree with the <a class="css" data-link-type="maybe" href="#at-ruledef-supports" id="ref-for-at-ruledef-supports①④">@supports</a> rule,
provide information to Web content about
the user’s hardware and software and their configuration and state.
Most of the information is provided through the features in <a data-link-type="biblio" href="#biblio-mediaqueries-4">[MEDIAQUERIES-4]</a> rather than through the features in this specification.
However, the <span class="css" id="ref-for-at-ruledef-supports①⑤">@supports</span> rule may provide some additional details about the user’s software
and whether it is running with non-default settings that may enable or disable certain features.</p>
   <p>Most of this information can also be determined through other APIs.
However, the features in this specification are one of the ways this information
is exposed on the Web.</p>
   <p>This information can also, in aggregate, be used to improve the accuracy of <a href="https://www.w3.org/2001/tag/doc/unsanctioned-tracking/">fingerprinting</a> of the user.</p>
   <h2 class="heading settled" data-level="8" id="changes"><span class="secno">8. </span><span class="content"> Changes</span><a class="self-link" href="#changes"></a></h2>
   <p>The following (non-editorial) changes were made to this specification since the <a href="https://www.w3.org/TR/2013/CR-css3-conditional-20130404/">4 April 2013 Candidate Recommendation</a>:</p>
   <ul>
    <li>Drop requirement for spaces around <span class="css">and</span>, <span class="css">or</span>, and <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-not" id="ref-for-valdef-media-not">not</a> keywords
      for consistency with <a href="http://www.w3.org/TR/css3-mediaqueries/">Media Queries</a> (which are themselves constrained by compatibility with the output of some CSS minimizers
      that rely on some of the more arcane aspects of CSS tokenization).
      Note that white space--or a comment--is still required <em>after</em> these keywords,
      since without it they and the ensuing opening parenthesis will be tokenized as a function opening token. 
    <li>Allow the <code class="highlight" title>supports()</code> method
      to imply parentheses for simple declarations,
      for consistency with the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#at-ruledef-import" id="ref-for-at-ruledef-import③">@import</a> rule’s <span class="css">supports()</span> function. 
    <li>Fixed missing semicolons in IDL code. 
    <li>Updated links, terminology, and example code in response to changes to other modules. 
    <li>Added section on privacy and security considerations. 
   </ul>
   <h2 class="no-num heading settled" id="acknowledgments"><span class="content">Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>Thanks to the ideas and feedback from
Tab Atkins,
Arthur Barstow,
Ben Callahan, <span lang="tr">Tantek Çelik</span>,
Alex Danilo,
Elika Etemad,
Pascal Germroth, <span lang="de">Björn Höhrmann</span>,
Paul Irish,
Brad Kemper, <span lang="nl">Anne van Kesteren</span>,
Vitor Menezes,
Alex Mogilevsky,
Chris Moschini,
James Nurthen,
Simon Pieters, <span lang="fr">Florian Rivoal</span>, <span lang="fr">Simon Sapin</span>,
Nicholas Shanks,
Ben Ward,
Zack Weinberg,
Estelle Weyl,
Boris Zbarsky,
and all the rest of the <a href="http://lists.w3.org/Archives/Public/www-style/">www-style</a> community.</p>
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
	or are set apart from the normative text with <code class="highlight">class="example"</code>,
	like this: </p>
  <div class="example" id="example-ae2b6bc0">
   <a class="self-link" href="#example-ae2b6bc0"></a> 
   <p>This is an example of an informative example. </p>
  </div>
  <p>Informative notes begin with the word “Note” and are set apart from the
	normative text with <code class="highlight">class="note"</code>, like this: </p>
  <p class="note" role="note">Note, this is an informative note. </p>
  <p>Advisements are normative sections styled to evoke special attention and are
	set apart from other normative text with <code class="highlight">&lt;strong class="advisement"></code>, like
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-css-supports">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSS/supports" title="The CSS.supports() method returns a Boolean value indicating if the browser supports a given CSS feature, or not.">CSS/supports</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>55+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>61+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>55+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>61+</span></span><span class="webview_android yes"><span>Android WebView</span><span>61+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-css-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSS" title="The CSS interface holds useful CSS-related methods. No object with this interface are implemented: it contains only static methods and therefore is a utilitarian interface.">CSS</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>28+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>22+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>28+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssconditionrule-interface">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSConditionRule" title="An object implementing the CSSConditionRule interface represents a single condition CSS at-rule, which consists of a condition and a statement block. It is a child of CSSGroupingRule.">CSSConditionRule</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>20+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>56+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>43+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>20+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>56+</span></span><span class="webview_android yes"><span>Android WebView</span><span>56+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>43+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssmediarule-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSMediaRule" title="The CSSMediaRule interface represents a single CSS @media rule. It implements the CSSConditionRule interface, and therefore the CSSGroupingRule and the CSSRule interface with a type value of 4 (CSSRule.MEDIA_RULE).">CSSMediaRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>17+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>17+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-csssupportsrule-interface">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSSupportsRule" title="The CSSSupportsRule interface describes an object representing a single CSS @supports at-rule. It implements the CSSConditionRule interface, and therefore the CSSRule and CSSGroupingRule interfaces with a type value of 12 (CSSRule.SUPPORTS_RULE).">CSSSupportsRule</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 17+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span title="Requires setting a user preference or runtime flag.">🔰 17+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="at-media">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@media" title="The @media CSS at-rule can be used to apply part of a style sheet based on the result of one or more media queries.">@media</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1.3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9.2+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>6+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="at-supports">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@supports" title="The @supports CSS at-rule lets you specify declarations that depend on a browser&apos;s support for one or more specific CSS features. This is called a feature query. The rule may be placed at the top level of your code or nested inside any other conditional group at-rule.">@supports</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>28+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>22+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>28+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#conditional-group-rule">conditional group rule</a><span>, in §2</span>
   <li><a href="#dom-cssconditionrule-conditiontext">conditionText</a><span>, in §7.2</span>
   <li><a href="#cssconditionrule">CSSConditionRule</a><span>, in §7.2</span>
   <li><a href="#cssmediarule">CSSMediaRule</a><span>, in §7.3</span>
   <li><a href="#csssupportsrule">CSSSupportsRule</a><span>, in §7.4</span>
   <li><a href="#at-ruledef-media">@media</a><span>, in §5</span>
   <li><a href="#dom-cssmediarule-media">media</a><span>, in §7.3</span>
   <li><a href="#dfn-support">support</a><span>, in §6.1</span>
   <li><a href="#at-ruledef-supports">@supports</a><span>, in §6</span>
   <li><a href="#typedef-supports-condition">&lt;supports-condition></a><span>, in §6</span>
   <li><a href="#dom-css-supports-conditiontext">supports(conditionText)</a><span>, in §7.5</span>
   <li><a href="#typedef-supports-decl">&lt;supports-decl></a><span>, in §6</span>
   <li><a href="#typedef-supports-feature">&lt;supports-feature></a><span>, in §6</span>
   <li><a href="#typedef-supports-in-parens">&lt;supports-in-parens></a><span>, in §6</span>
   <li><a href="#dom-css-supports">supports(property, value)</a><span>, in §7.5</span>
   <li><a href="#dom-cssrule-supports_rule">SUPPORTS_RULE</a><span>, in §7.1</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-propdef-border">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border">https://drafts.csswg.org/css-backgrounds-3/#propdef-border</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-box-shadow">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow">https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-box-shadow">6. Feature queries: the @supports rule</a> <a href="#ref-for-propdef-box-shadow①">(2)</a> <a href="#ref-for-propdef-box-shadow②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-declaration">
   <a href="https://drafts.csswg.org/css-cascade-4/#typedef-declaration">https://drafts.csswg.org/css-cascade-4/#typedef-declaration</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-declaration">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-ruledef-import">
   <a href="https://drafts.csswg.org/css-cascade-4/#at-ruledef-import">https://drafts.csswg.org/css-cascade-4/#at-ruledef-import</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-import">1.1. Background</a>
    <li><a href="#ref-for-at-ruledef-import①">3. 
Contents of conditional group rules</a>
    <li><a href="#ref-for-at-ruledef-import②">4. 
Placement of conditional group rules</a>
    <li><a href="#ref-for-at-ruledef-import③">8. 
Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-color">
   <a href="https://drafts.csswg.org/css-color-4/#propdef-color">https://drafts.csswg.org/css-color-4/#propdef-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-color">6.1. Definition of support</a> <a href="#ref-for-propdef-color①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-display">
   <a href="https://drafts.csswg.org/css-display-3/#propdef-display">https://drafts.csswg.org/css-display-3/#propdef-display</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-display">6. Feature queries: the @supports rule</a> <a href="#ref-for-propdef-display①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-stylesheet">
   <a href="https://drafts.csswg.org/css-syntax-3/#typedef-stylesheet">https://drafts.csswg.org/css-syntax-3/#typedef-stylesheet</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-stylesheet">3. 
Contents of conditional group rules</a> <a href="#ref-for-typedef-stylesheet①">(2)</a>
    <li><a href="#ref-for-typedef-stylesheet②">5. 
Media-specific style sheets:  the @media rule</a>
    <li><a href="#ref-for-typedef-stylesheet③">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-ruledef-charset">
   <a href="https://drafts.csswg.org/css-syntax-3/#at-ruledef-charset">https://drafts.csswg.org/css-syntax-3/#at-ruledef-charset</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-charset">4. 
Placement of conditional group rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-rule">
   <a href="https://drafts.csswg.org/css-syntax-3/#at-rule">https://drafts.csswg.org/css-syntax-3/#at-rule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-rule">2. Processing of conditional group rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-parse-something-according-to-a-css-grammar">
   <a href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar">https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-parse-something-according-to-a-css-grammar">7.5. 
The CSS namespace, and the supports() function</a> <a href="#ref-for-css-parse-something-according-to-a-css-grammar①">(2)</a> <a href="#ref-for-css-parse-something-according-to-a-css-grammar②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-custom-property-name-string">
   <a href="https://drafts.css-houdini.org/css-typed-om-1/#custom-property-name-string">https://drafts.css-houdini.org/css-typed-om-1/#custom-property-name-string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-custom-property-name-string">7.5. 
The CSS namespace, and the supports() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-zero-plus">
   <a href="https://drafts.csswg.org/css-values-4/#mult-zero-plus">https://drafts.csswg.org/css-values-4/#mult-zero-plus</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-zero-plus">6. Feature queries: the @supports rule</a> <a href="#ref-for-mult-zero-plus①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-one">
   <a href="https://drafts.csswg.org/css-values-4/#comb-one">https://drafts.csswg.org/css-values-4/#comb-one</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-one">6. Feature queries: the @supports rule</a> <a href="#ref-for-comb-one①">(2)</a> <a href="#ref-for-comb-one②">(3)</a> <a href="#ref-for-comb-one③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-width">
   <a href="https://drafts.csswg.org/css2/visudet.html#propdef-width">https://drafts.csswg.org/css2/visudet.html#propdef-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-width">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-namespacedef-css">
   <a href="https://drafts.csswg.org/cssom-1/#namespacedef-css">https://drafts.csswg.org/cssom-1/#namespacedef-css</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-namespacedef-css">7.5. 
The CSS namespace, and the supports() function</a> <a href="#ref-for-namespacedef-css①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssgroupingrule">
   <a href="https://drafts.csswg.org/cssom-1/#cssgroupingrule">https://drafts.csswg.org/cssom-1/#cssgroupingrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssgroupingrule">7.2. 
The CSSConditionRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssomstring">
   <a href="https://drafts.csswg.org/cssom-1/#cssomstring">https://drafts.csswg.org/cssom-1/#cssomstring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">7.2. 
The CSSConditionRule interface</a>
    <li><a href="#ref-for-cssomstring①">7.5. 
The CSS namespace, and the supports() function</a> <a href="#ref-for-cssomstring②">(2)</a> <a href="#ref-for-cssomstring③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssrule">
   <a href="https://drafts.csswg.org/cssom-1/#cssrule">https://drafts.csswg.org/cssom-1/#cssrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrule">7.1. 
Extensions to the CSSRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-medialist">
   <a href="https://drafts.csswg.org/cssom-1/#medialist">https://drafts.csswg.org/cssom-1/#medialist</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-medialist">7.3. 
The CSSMediaRule interface</a> <a href="#ref-for-medialist①">(2)</a> <a href="#ref-for-medialist②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-medialist-mediatext">
   <a href="https://drafts.csswg.org/cssom-1/#dom-medialist-mediatext">https://drafts.csswg.org/cssom-1/#dom-medialist-mediatext</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-medialist-mediatext">7.3. 
The CSSMediaRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-link-element">
   <a href="https://html.spec.whatwg.org/multipage/semantics.html#the-link-element">https://html.spec.whatwg.org/multipage/semantics.html#the-link-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-link-element">1.1. Background</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-case-insensitive">
   <a href="https://infra.spec.whatwg.org/#ascii-case-insensitive">https://infra.spec.whatwg.org/#ascii-case-insensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-case-insensitive">7.5. 
The CSS namespace, and the supports() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-general-enclosed">
   <a href="https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed">https://drafts.csswg.org/mediaqueries-4/#typedef-general-enclosed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-general-enclosed">6. Feature queries: the @supports rule</a> <a href="#ref-for-typedef-general-enclosed①">(2)</a> <a href="#ref-for-typedef-general-enclosed②">(3)</a> <a href="#ref-for-typedef-general-enclosed③">(4)</a> <a href="#ref-for-typedef-general-enclosed④">(5)</a>
    <li><a href="#ref-for-typedef-general-enclosed⑤">7.4. 
The CSSSupportsRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-media-condition">
   <a href="https://drafts.csswg.org/mediaqueries-4/#typedef-media-condition">https://drafts.csswg.org/mediaqueries-4/#typedef-media-condition</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-media-condition">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-media-query-list">
   <a href="https://drafts.csswg.org/mediaqueries-4/#typedef-media-query-list">https://drafts.csswg.org/mediaqueries-4/#typedef-media-query-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-media-query-list">5. 
Media-specific style sheets:  the @media rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-media-not">
   <a href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-not">https://drafts.csswg.org/mediaqueries-4/#valdef-media-not</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-media-not">8. 
Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">7.2. 
The CSSConditionRule interface</a>
    <li><a href="#ref-for-Exposed①">7.3. 
The CSSMediaRule interface</a>
    <li><a href="#ref-for-Exposed②">7.4. 
The CSSSupportsRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-PutForwards">
   <a href="https://heycam.github.io/webidl/#PutForwards">https://heycam.github.io/webidl/#PutForwards</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-PutForwards">7.3. 
The CSSMediaRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">7.3. 
The CSSMediaRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">7.5. 
The CSS namespace, and the supports() function</a> <a href="#ref-for-idl-boolean①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-short">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-short">https://heycam.github.io/webidl/#idl-unsigned-short</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-short">7.1. 
Extensions to the CSSRule interface</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-backgrounds-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-border" style="color:initial">border</span>
     <li><span class="dfn-paneled" id="term-for-propdef-box-shadow" style="color:initial">box-shadow</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-cascade-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-declaration" style="color:initial">&lt;declaration></span>
     <li><span class="dfn-paneled" id="term-for-at-ruledef-import" style="color:initial">@import</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-color-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-color" style="color:initial">color</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-display-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-display" style="color:initial">display</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-syntax-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-stylesheet" style="color:initial">&lt;stylesheet></span>
     <li><span class="dfn-paneled" id="term-for-at-ruledef-charset" style="color:initial">@charset</span>
     <li><span class="dfn-paneled" id="term-for-at-rule" style="color:initial">at-rule</span>
     <li><span class="dfn-paneled" id="term-for-css-parse-something-according-to-a-css-grammar" style="color:initial">parse</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-typed-om-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-custom-property-name-string" style="color:initial">custom property name string</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mult-zero-plus" style="color:initial">*</span>
     <li><span class="dfn-paneled" id="term-for-comb-one" style="color:initial">|</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS21]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-width" style="color:initial">width</span>
    </ul>
   <li>
    <a data-link-type="biblio">[cssom-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-namespacedef-css" style="color:initial">CSS</span>
     <li><span class="dfn-paneled" id="term-for-cssgroupingrule" style="color:initial">CSSGroupingRule</span>
     <li><span class="dfn-paneled" id="term-for-cssomstring" style="color:initial">CSSOMString</span>
     <li><span class="dfn-paneled" id="term-for-cssrule" style="color:initial">CSSRule</span>
     <li><span class="dfn-paneled" id="term-for-medialist" style="color:initial">MediaList</span>
     <li><span class="dfn-paneled" id="term-for-dom-medialist-mediatext" style="color:initial">mediaText</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-the-link-element" style="color:initial">link</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-ascii-case-insensitive" style="color:initial">ascii case-insensitive</span>
    </ul>
   <li>
    <a data-link-type="biblio">[MEDIAQUERIES-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-general-enclosed" style="color:initial">&lt;general-enclosed></span>
     <li><span class="dfn-paneled" id="term-for-typedef-media-condition" style="color:initial">&lt;media-condition></span>
     <li><span class="dfn-paneled" id="term-for-typedef-media-query-list" style="color:initial">&lt;media-query-list></span>
     <li><span class="dfn-paneled" id="term-for-valdef-media-not" style="color:initial">not</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-PutForwards" style="color:initial">PutForwards</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-short" style="color:initial">unsigned short</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-cascade-4">[CSS-CASCADE-4]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-4/">CSS Cascading and Inheritance Level 4</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-4/">https://www.w3.org/TR/css-cascade-4/</a>
   <dt id="biblio-css-syntax-3">[CSS-SYNTAX-3]
   <dd>Tab Atkins Jr.; Simon Sapin. <a href="https://www.w3.org/TR/css-syntax-3/">CSS Syntax Module Level 3</a>. 16 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-syntax-3/">https://www.w3.org/TR/css-syntax-3/</a>
   <dt id="biblio-css-typed-om-1">[CSS-TYPED-OM-1]
   <dd>Shane Stephens; Tab Atkins Jr.; Naina Raisinghani. <a href="https://www.w3.org/TR/css-typed-om-1/">CSS Typed OM Level 1</a>. 10 April 2018. WD. URL: <a href="https://www.w3.org/TR/css-typed-om-1/">https://www.w3.org/TR/css-typed-om-1/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css21">[CSS21]
   <dd>Bert Bos; et al. <a href="https://www.w3.org/TR/CSS2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. 7 June 2011. REC. URL: <a href="https://www.w3.org/TR/CSS2/">https://www.w3.org/TR/CSS2/</a>
   <dt id="biblio-css3-animations">[CSS3-ANIMATIONS]
   <dd>Dean Jackson; et al. <a href="https://www.w3.org/TR/css-animations-1/">CSS Animations Level 1</a>. 11 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-animations-1/">https://www.w3.org/TR/css-animations-1/</a>
   <dt id="biblio-cssom-1">[CSSOM-1]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-mediaqueries-4">[MEDIAQUERIES-4]
   <dd>Florian Rivoal; Tab Atkins Jr.. <a href="https://www.w3.org/TR/mediaqueries-4/">Media Queries Level 4</a>. 5 September 2017. CR. URL: <a href="https://www.w3.org/TR/mediaqueries-4/">https://www.w3.org/TR/mediaqueries-4/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-css-backgrounds-3">[CSS-BACKGROUNDS-3]
   <dd>Bert Bos; Elika Etemad; Brad Kemper. <a href="https://www.w3.org/TR/css-backgrounds-3/">CSS Backgrounds and Borders Module Level 3</a>. 17 October 2017. CR. URL: <a href="https://www.w3.org/TR/css-backgrounds-3/">https://www.w3.org/TR/css-backgrounds-3/</a>
   <dt id="biblio-css-color-4">[CSS-COLOR-4]
   <dd>Tab Atkins Jr.; Chris Lilley. <a href="https://www.w3.org/TR/css-color-4/">CSS Color Module Level 4</a>. 5 November 2019. WD. URL: <a href="https://www.w3.org/TR/css-color-4/">https://www.w3.org/TR/css-color-4/</a>
   <dt id="biblio-css-display-3">[CSS-DISPLAY-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-display-3/">CSS Display Module Level 3</a>. 11 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-display-3/">https://www.w3.org/TR/css-display-3/</a>
   <dt id="biblio-css1">[CSS1]
   <dd>Håkon Wium Lie; Bert Bos. <a href="https://www.w3.org/TR/CSS1/">Cascading Style Sheets, level 1</a>. 13 September 2018. REC. URL: <a href="https://www.w3.org/TR/CSS1/">https://www.w3.org/TR/CSS1/</a>
   <dt id="biblio-css3-transitions">[CSS3-TRANSITIONS]
   <dd>David Baron; et al. <a href="https://www.w3.org/TR/css-transitions-1/">CSS Transitions</a>. 11 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-transitions-1/">https://www.w3.org/TR/css-transitions-1/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-supports_rule"><code class="highlight"><c- g>SUPPORTS_RULE</c-></code></a> = 12;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssconditionrule"><code class="highlight"><c- g>CSSConditionRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssgroupingrule"><c- n>CSSGroupingRule</c-></a> {
    <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-type="CSSOMString" href="#dom-cssconditionrule-conditiontext"><code class="highlight"><c- g>conditionText</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssmediarule"><code class="highlight"><c- g>CSSMediaRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssconditionrule"><c- n>CSSConditionRule</c-></a> {
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="https://drafts.csswg.org/cssom-1/#dom-medialist-mediatext"><c- n>mediaText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#medialist"><c- n>MediaList</c-></a> <a data-readonly data-type="MediaList" href="#dom-cssmediarule-media"><code class="highlight"><c- g>media</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#csssupportsrule"><code class="highlight"><c- g>CSSSupportsRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssconditionrule"><c- n>CSSConditionRule</c-></a> {
};

<c- b>partial</c-> <c- b>namespace</c-> <a class="idl-code" data-link-type="namespace" href="https://drafts.csswg.org/cssom-1/#namespacedef-css"><c- g>CSS</c-></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a href="#dom-css-supports"><code class="highlight"><c- g>supports</c-></code></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-css-supports-property-value-property"><code class="highlight"><c- g>property</c-></code></a>, <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-css-supports-property-value-value"><code class="highlight"><c- g>value</c-></code></a>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a href="#dom-css-supports-conditiontext"><code class="highlight"><c- g>supports</c-></code></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-css-supports-conditiontext-conditiontext"><code class="highlight"><c- g>conditionText</c-></code></a>);
};

</pre>
  <aside class="dfn-panel" data-for="at-ruledef-media">
   <b><a href="#at-ruledef-media">#at-ruledef-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-media①">1.1. Background</a> <a href="#ref-for-at-ruledef-media②">(2)</a> <a href="#ref-for-at-ruledef-media③">(3)</a>
    <li><a href="#ref-for-at-ruledef-media④">1.2. Module Interactions</a>
    <li><a href="#ref-for-at-ruledef-media⑤">5. 
Media-specific style sheets:  the @media rule</a> <a href="#ref-for-at-ruledef-media⑥">(2)</a> <a href="#ref-for-at-ruledef-media⑦">(3)</a>
    <li><a href="#ref-for-at-ruledef-media⑧">7.3. 
The CSSMediaRule interface</a> <a href="#ref-for-at-ruledef-media⑨">(2)</a>
    <li><a href="#ref-for-at-ruledef-media①⓪">Privacy and Security Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="at-ruledef-supports">
   <b><a href="#at-ruledef-supports">#at-ruledef-supports</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-supports①">1.1. Background</a> <a href="#ref-for-at-ruledef-supports②">(2)</a>
    <li><a href="#ref-for-at-ruledef-supports③">6. Feature queries: the @supports rule</a> <a href="#ref-for-at-ruledef-supports④">(2)</a> <a href="#ref-for-at-ruledef-supports⑤">(3)</a> <a href="#ref-for-at-ruledef-supports⑥">(4)</a> <a href="#ref-for-at-ruledef-supports⑦">(5)</a> <a href="#ref-for-at-ruledef-supports⑧">(6)</a> <a href="#ref-for-at-ruledef-supports⑨">(7)</a> <a href="#ref-for-at-ruledef-supports①⓪">(8)</a>
    <li><a href="#ref-for-at-ruledef-supports①①">6.1. Definition of support</a> <a href="#ref-for-at-ruledef-supports①②">(2)</a>
    <li><a href="#ref-for-at-ruledef-supports①③">7.4. 
The CSSSupportsRule interface</a>
    <li><a href="#ref-for-at-ruledef-supports①④">Privacy and Security Considerations</a> <a href="#ref-for-at-ruledef-supports①⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-supports-condition">
   <b><a href="#typedef-supports-condition">#typedef-supports-condition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-supports-condition">6. Feature queries: the @supports rule</a> <a href="#ref-for-typedef-supports-condition①">(2)</a> <a href="#ref-for-typedef-supports-condition②">(3)</a> <a href="#ref-for-typedef-supports-condition③">(4)</a> <a href="#ref-for-typedef-supports-condition④">(5)</a> <a href="#ref-for-typedef-supports-condition⑤">(6)</a>
    <li><a href="#ref-for-typedef-supports-condition⑥">7.5. 
The CSS namespace, and the supports() function</a> <a href="#ref-for-typedef-supports-condition⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-supports-in-parens">
   <b><a href="#typedef-supports-in-parens">#typedef-supports-in-parens</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-supports-in-parens">6. Feature queries: the @supports rule</a> <a href="#ref-for-typedef-supports-in-parens①">(2)</a> <a href="#ref-for-typedef-supports-in-parens②">(3)</a> <a href="#ref-for-typedef-supports-in-parens③">(4)</a> <a href="#ref-for-typedef-supports-in-parens④">(5)</a> <a href="#ref-for-typedef-supports-in-parens⑤">(6)</a> <a href="#ref-for-typedef-supports-in-parens⑥">(7)</a> <a href="#ref-for-typedef-supports-in-parens⑦">(8)</a> <a href="#ref-for-typedef-supports-in-parens⑧">(9)</a> <a href="#ref-for-typedef-supports-in-parens⑨">(10)</a> <a href="#ref-for-typedef-supports-in-parens①⓪">(11)</a> <a href="#ref-for-typedef-supports-in-parens①①">(12)</a> <a href="#ref-for-typedef-supports-in-parens①②">(13)</a> <a href="#ref-for-typedef-supports-in-parens①③">(14)</a> <a href="#ref-for-typedef-supports-in-parens①④">(15)</a> <a href="#ref-for-typedef-supports-in-parens①⑤">(16)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-supports-feature">
   <b><a href="#typedef-supports-feature">#typedef-supports-feature</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-supports-feature">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-supports-decl">
   <b><a href="#typedef-supports-decl">#typedef-supports-decl</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-supports-decl">6. Feature queries: the @supports rule</a> <a href="#ref-for-typedef-supports-decl①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dfn-support">
   <b><a href="#dfn-support">#dfn-support</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-support">6. Feature queries: the @supports rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssconditionrule">
   <b><a href="#cssconditionrule">#cssconditionrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssconditionrule">7.2. 
The CSSConditionRule interface</a>
    <li><a href="#ref-for-cssconditionrule①">7.3. 
The CSSMediaRule interface</a>
    <li><a href="#ref-for-cssconditionrule②">7.4. 
The CSSSupportsRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssmediarule">
   <b><a href="#cssmediarule">#cssmediarule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssmediarule">7.3. 
The CSSMediaRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="csssupportsrule">
   <b><a href="#csssupportsrule">#csssupportsrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csssupportsrule">7.4. 
The CSSSupportsRule interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-css-supports">
   <b><a href="#dom-css-supports">#dom-css-supports</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-css-supports">7.5. 
The CSS namespace, and the supports() function</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-css-supports-conditiontext">
   <b><a href="#dom-css-supports-conditiontext">#dom-css-supports-conditiontext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-css-supports-conditiontext">7.5. 
The CSS namespace, and the supports() function</a>
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
            </script>
<script>/* script-var-click-highlighting */

    document.addEventListener("click", e=>{
        if(e.target.nodeName == "VAR") {
            highlightSameAlgoVars(e.target);
        }
    });
    {
        const indexCounts = new Map();
        const indexNames = new Map();
        function highlightSameAlgoVars(v) {
            // Find the algorithm container.
            let algoContainer = null;
            let searchEl = v;
            while(algoContainer == null && searchEl != document.body) {
                searchEl = searchEl.parentNode;
                if(searchEl.hasAttribute("data-algorithm")) {
                    algoContainer = searchEl;
                }
            }

            // Not highlighting document-global vars,
            // too likely to be unrelated.
            if(algoContainer == null) return;

            const algoName = algoContainer.getAttribute("data-algorithm");
            const varName = getVarName(v);
            const addClass = !v.classList.contains("selected");
            let highlightClass = null;
            if(addClass) {
                const index = chooseHighlightIndex(algoName, varName);
                indexCounts.get(algoName)[index] += 1;
                indexNames.set(algoName+"///"+varName, index);
                highlightClass = nameFromIndex(index);
            } else {
                const index = previousHighlightIndex(algoName, varName);
                indexCounts.get(algoName)[index] -= 1;
                highlightClass = nameFromIndex(index);
            }

            // Find all same-name vars, and toggle their class appropriately.
            for(const el of algoContainer.querySelectorAll("var")) {
                if(getVarName(el) == varName) {
                    el.classList.toggle("selected", addClass);
                    el.classList.toggle(highlightClass, addClass);
                }
            }
        }
        function getVarName(el) {
            return el.textContent.replace(/(\s| )+/, " ").trim();
        }
        function chooseHighlightIndex(algoName, varName) {
            let indexes = null;
            if(indexCounts.has(algoName)) {
                indexes = indexCounts.get(algoName);
            } else {
                // 7 classes right now
                indexes = [0,0,0,0,0,0,0];
                indexCounts.set(algoName, indexes);
            }

            // If the element was recently unclicked,
            // *and* that color is still unclaimed,
            // give it back the same color.
            const lastIndex = previousHighlightIndex(algoName, varName);
            if(indexes[lastIndex] === 0) return lastIndex;

            // Find the earliest index with the lowest count.
            const minCount = Math.min.apply(null, indexes);
            let index = null;
            for(var i = 0; i < indexes.length; i++) {
                if(indexes[i] == minCount) {
                    return i;
                }
            }
        }
        function previousHighlightIndex(algoName, varName) {
            return indexNames.get(algoName+"///"+varName);
        }
        function nameFromIndex(index) {
            return "selected" + index;
        }
    }
    </script><a class='link-error' href='/bikeshed/css-conditional-3/' id='generator' title='Bikeshed Link Errors'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>