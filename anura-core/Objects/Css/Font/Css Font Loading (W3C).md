<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Font Loading Module Level 3</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="exploring" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="This CSS module describes events and interfaces used for dynamically loading font resources." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/css-font-loading/" rel="canonical">
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
 <script nonce='yAeFr/2gfXbyj5qFr2ACeFzMd/u5B9mzJzqSZ+B5dMw=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='yAeFr/2gfXbyj5qFr2ACeFzMd/u5B9mzJzqSZ+B5dMw=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="css-font-loading-3\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
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
   <h1 class="p-name no-ref" id="title">CSS Font Loading Module Level 3</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-02-22">22 February 2020</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/css-font-loading/">https://drafts.csswg.org/css-font-loading/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/css-font-loading/">https://www.w3.org/TR/css-font-loading/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2014/WD-css-font-loading-3-20140522/" rel="prev">https://www.w3.org/TR/2014/WD-css-font-loading-3-20140522/</a>
      <dt>Issue Tracking:
      <dd><a href="#issues-index">Inline In Spec</a>
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/css-font-loading-3">GitHub Issues</a>
      <dt class="editor">Editor:
      <dd class="editor p-author h-card vcard" data-editor-id="42199"><a class="p-name fn u-url url" href="http://xanthir.com/contact/">Tab Atkins Jr.</a> (<span class="p-org org">Google</span>)
      <dt class="editor">Former Editor:
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:jdaggett@mozilla.com">John Daggett</a> (<span class="p-org org">Mozilla</span>)
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/css-font-loading-3/Overview.bs">GitHub Editor</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This CSS module describes events and interfaces used for dynamically loading font resources.</p>
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
	When filing an issue, please put the text “css-font-loading” in the title,
	preferably like this:
	“[css-font-loading] <i data-lt>…summary of comment…</i>”.
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
     <a href="#introduction"><span class="secno">1</span> <span class="content"> Introduction</span></a>
     <ol class="toc">
      <li><a href="#values"><span class="secno">1.1</span> <span class="content"> Values</span></a>
      <li><a href="#task-source"><span class="secno">1.2</span> <span class="content"> Task Sources</span></a>
     </ol>
    <li>
     <a href="#fontface-interface"><span class="secno">2</span> <span class="content"> The <code>FontFace</code> Interface</span></a>
     <ol class="toc">
      <li><a href="#font-face-constructor"><span class="secno">2.1</span> <span class="content"> The Constructor</span></a>
      <li><a href="#font-face-load"><span class="secno">2.2</span> <span class="content"> The <code>load()</code> method</span></a>
      <li><a href="#font-face-css-connection"><span class="secno">2.3</span> <span class="content"> Interaction with CSS’s <span class="css">@font-face</span> Rule</span></a>
     </ol>
    <li>
     <a href="#FontFaceSet-interface"><span class="secno">3</span> <span class="content"> The <code>FontFaceSet</code> Interface</span></a>
     <ol class="toc">
      <li><a href="#FontFaceSet-events"><span class="secno">3.1</span> <span class="content"> Events</span></a>
      <li><a href="#font-face-set-load"><span class="secno">3.2</span> <span class="content"> The <code>load()</code> method</span></a>
      <li><a href="#font-face-set-check"><span class="secno">3.3</span> <span class="content"> The <code>check()</code> method</span></a>
      <li><a href="#font-face-set-ready"><span class="secno">3.4</span> <span class="content"> The <code>ready</code> attribute</span></a>
      <li><a href="#font-face-set-css"><span class="secno">3.5</span> <span class="content"> Interaction with CSS Font Loading and Matching</span></a>
     </ol>
    <li>
     <a href="#font-face-source"><span class="secno">4</span> <span class="content"> The <code>FontFaceSource</code> mixin</span></a>
     <ol class="toc">
      <li><a href="#fontfacesource-workers"><span class="secno">4.1</span> <span class="content"> Worker FontFaceSources</span></a>
      <li><a href="#document-font-face-set"><span class="secno">4.2</span> <span class="content"> Interaction with CSS’s <span class="css">@font-face</span> Rule</span></a>
     </ol>
    <li><a href="#font-load-event-examples"><span class="secno">5</span> <span class="content"> API Examples</span></a>
    <li><a href="#changes"><span class="secno"></span> <span class="content">Changes</span></a>
    <li><a href="#acknowledgments"><span class="secno"></span> <span class="content"> Acknowledgments</span></a>
    <li><a href="#priv-sec"><span class="secno"></span> <span class="content"> Privacy &amp; Security Considerations</span></a>
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
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
    <li><a href="#issues-index"><span class="secno"></span> <span class="content">Issues Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="introduction"><span class="secno">1. </span><span class="content"> Introduction</span><a class="self-link" href="#introduction"></a></h2>
   <p>CSS allows authors to load custom fonts from the web via the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule">@font-face</a> rule.
	While this is easy to use when authoring a stylesheet,
	it’s much more difficult to use dynamically via scripting.</p>
   <p>Further, CSS allows the user agent to choose when to actually load a font;
	if a font face isn’t <em>currently</em> used by anything on a page,
	most user agents will not download its associated file.
	This means that later use of the font face will incur a delay
	as the user agent finally notices a usage and begins downloading and parsing the font file.</p>
   <p>This specification defines a scripting interface to font faces in CSS,
	allowing font faces to be easily created and loaded from script.
	It also provides methods to track the loading status of an individual font,
	or of all the fonts on an entire page.</p>
   <p class="issue" id="issue-9cdca628"><a class="self-link" href="#issue-9cdca628"></a> Several things in this spec use normal ES objects to define behavior,
	such as various things using Promises internally,
	and FontFaceSet using a Set internally.
	I believe the intention here is that these objects
	(and their prototype chains) are pristine,
	unaffected by anything the author has done.
	Is this a good intention?
	If so, how should I indicate this in the spec?</p>
   <h3 class="heading settled" data-level="1.1" id="values"><span class="secno">1.1. </span><span class="content"> Values</span><a class="self-link" href="#values"></a></h3>
   <p>This specification uses <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise">Promise</a></code>s,
	which are defined in <a href="http://wiki.ecmascript.org/doku.php?id=harmony:specification_drafts">ECMAScript 6</a>.
	HTML5Rocks has some <a href="http://www.html5rocks.com/en/tutorials/es6/promises/">good tutorial material introducing Promises</a>.</p>
   <h3 class="heading settled" data-level="1.2" id="task-source"><span class="secno">1.2. </span><span class="content"> Task Sources</span><a class="self-link" href="#task-source"></a></h3>
   <p>Whenever this specification queues a task,
	it queues it onto the "font loading" task source.</p>
   <h2 class="heading settled" data-level="2" id="fontface-interface"><span class="secno">2. </span><span class="content"> The <code>FontFace</code> Interface</span><a class="self-link" href="#fontface-interface"></a></h2>
   <p>The <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface">FontFace</a></code> interface represents a single usable font face.
	CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①">@font-face</a> rules implicitly define FontFace objects,
	or they can be constructed manually from a url or binary data.</p>
<pre class="idl highlight def"><c- b>typedef</c-> (<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ArrayBuffer" id="ref-for-idl-ArrayBuffer"><c- b>ArrayBuffer</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://heycam.github.io/webidl/#ArrayBufferView" id="ref-for-ArrayBufferView"><c- n>ArrayBufferView</c-></a>) <dfn class="dfn-paneled idl-code" data-dfn-type="typedef" data-export id="typedefdef-binarydata"><code><c- g>BinaryData</c-></code></dfn>;

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-fontfacedescriptors"><code><c- g>FontFaceDescriptors</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;normal&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-style"><code><c- g>style</c-></code><a class="self-link" href="#dom-fontfacedescriptors-style"></a></dfn> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;normal&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-weight"><code><c- g>weight</c-></code><a class="self-link" href="#dom-fontfacedescriptors-weight"></a></dfn> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;normal&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-stretch"><code><c- g>stretch</c-></code><a class="self-link" href="#dom-fontfacedescriptors-stretch"></a></dfn> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;U+0-10FFFF&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-unicoderange"><code><c- g>unicodeRange</c-></code><a class="self-link" href="#dom-fontfacedescriptors-unicoderange"></a></dfn> = "U+0-10FFFF";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring④"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;normal&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-variant"><code><c- g>variant</c-></code><a class="self-link" href="#dom-fontfacedescriptors-variant"></a></dfn> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑤"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;normal&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-featuresettings"><code><c- g>featureSettings</c-></code><a class="self-link" href="#dom-fontfacedescriptors-featuresettings"></a></dfn> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑥"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;normal&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-variationsettings"><code><c- g>variationSettings</c-></code><a class="self-link" href="#dom-fontfacedescriptors-variationsettings"></a></dfn> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑦"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;auto&quot;" data-dfn-for="FontFaceDescriptors" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-fontfacedescriptors-display"><code><c- g>display</c-></code><a class="self-link" href="#dom-fontfacedescriptors-display"></a></dfn> = "auto";
};

<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-fontfaceloadstatus"><code><c- g>FontFaceLoadStatus</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="FontFaceLoadStatus" data-dfn-type="enum-value" data-export id="dom-fontfaceloadstatus-unloaded"><code><c- s>"unloaded"</c-></code><a class="self-link" href="#dom-fontfaceloadstatus-unloaded"></a></dfn>, <dfn class="idl-code" data-dfn-for="FontFaceLoadStatus" data-dfn-type="enum-value" data-export id="dom-fontfaceloadstatus-loading"><code><c- s>"loading"</c-></code><a class="self-link" href="#dom-fontfaceloadstatus-loading"></a></dfn>, <dfn class="idl-code" data-dfn-for="FontFaceLoadStatus" data-dfn-type="enum-value" data-export id="dom-fontfaceloadstatus-loaded"><code><c- s>"loaded"</c-></code><a class="self-link" href="#dom-fontfaceloadstatus-loaded"></a></dfn>, <dfn class="idl-code" data-dfn-for="FontFaceLoadStatus" data-dfn-type="enum-value" data-export id="dom-fontfaceloadstatus-error"><code><c- s>"error"</c-></code><a class="self-link" href="#dom-fontfaceloadstatus-error"></a></dfn> };

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="fontface"><code><c- g>FontFace</c-></code></dfn> {
  <a class="idl-code" data-link-type="constructor" href="#dom-fontface-fontface" id="ref-for-dom-fontface-fontface"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑧"><c- n>CSSOMString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace/FontFace(family, source, descriptors), FontFace/constructor(family, source, descriptors), FontFace/FontFace(family, source), FontFace/constructor(family, source)" data-dfn-type="argument" data-export id="dom-fontface-fontface-family-source-descriptors-family"><code><c- g>family</c-></code></dfn>, (<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑨"><c- n>CSSOMString</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="#typedefdef-binarydata" id="ref-for-typedefdef-binarydata"><c- n>BinaryData</c-></a>) <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace/FontFace(family, source, descriptors), FontFace/constructor(family, source, descriptors), FontFace/FontFace(family, source), FontFace/constructor(family, source)" data-dfn-type="argument" data-export id="dom-fontface-fontface-family-source-descriptors-source"><code><c- g>source</c-></code></dfn>,
                <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-fontfacedescriptors" id="ref-for-dictdef-fontfacedescriptors"><c- n>FontFaceDescriptors</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace/FontFace(family, source, descriptors), FontFace/constructor(family, source, descriptors), FontFace/FontFace(family, source), FontFace/constructor(family, source)" data-dfn-type="argument" data-export id="dom-fontface-fontface-family-source-descriptors-descriptors"><code><c- g>descriptors</c-></code></dfn> = {});
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⓪"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-family" id="ref-for-dom-fontface-family"><c- g>family</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-style" id="ref-for-dom-fontface-style"><c- g>style</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-weight" id="ref-for-dom-fontface-weight"><c- g>weight</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①③"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-stretch" id="ref-for-dom-fontface-stretch"><c- g>stretch</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①④"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-unicoderange" id="ref-for-dom-fontface-unicoderange"><c- g>unicodeRange</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑤"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-variant" id="ref-for-dom-fontface-variant"><c- g>variant</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑥"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-featuresettings" id="ref-for-dom-fontface-featuresettings"><c- g>featureSettings</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑦"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-variationsettings" id="ref-for-dom-fontface-variationsettings"><c- g>variationSettings</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑧"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-display" id="ref-for-dom-fontface-display"><c- g>display</c-></a>;

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#enumdef-fontfaceloadstatus" id="ref-for-enumdef-fontfaceloadstatus"><c- n>FontFaceLoadStatus</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="FontFaceLoadStatus" href="#dom-fontface-status" id="ref-for-dom-fontface-status"><c- g>status</c-></a>;

  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface①"><c- n>FontFace</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-fontface-load" id="ref-for-dom-fontface-load"><c- g>load</c-></a>();
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface②"><c- n>FontFace</c-></a>> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Promise<FontFace>" href="#dom-fontface-loaded" id="ref-for-dom-fontface-loaded"><c- g>loaded</c-></a>;
};
</pre>
   <p class="issue" id="issue-9ae72be4"><a class="self-link" href="#issue-9ae72be4"></a> Clarify all mentions of "the document" to be clear about which document is being referenced,
	since objects can move between documents.</p>
   <div>
    <dl>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-family"><code>family</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①⑨">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-style"><code>style</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⓪">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-weight"><code>weight</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②①">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-stretch"><code>stretch</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②②">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-unicoderange"><code>unicodeRange</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②③">CSSOMString</a></span>
     <dd data-md>
      <p>These attributes all represent the corresponding aspects of a font face,
as defined by the descriptors defined in the CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②">@font-face</a> rule.
They are parsed the same as the corresponding <span class="css" id="ref-for-at-font-face-rule③">@font-face</span> descriptors.
They are used by the font matching algorithm,
but otherwise have no effect.</p>
      <p>For example, a <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface③">FontFace</a></code> with a <code class="idl"><a data-link-type="idl" href="#dom-fontface-style" id="ref-for-dom-fontface-style①">style</a></code> of <code>"italic"</code> <em>represents</em> an italic font face;
it does not <strong>make</strong> the font face italic.</p>
      <p>On getting, return the string associated with this attribute.</p>
      <p>On setting, <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar">parse</a> the string according to the grammar for the corresponding <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule④">@font-face</a> descriptor.
If it does not match the grammar,
throw a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#syntaxerror" id="ref-for-syntaxerror">SyntaxError</a></code>;
otherwise, set the attribute to the serialization of the parsed value.</p>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-variant"><code>variant</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②④">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-featuresettings"><code>featureSettings</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⑤">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-variationsettings"><code>variationSettings</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⑥">CSSOMString</a></span>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-display"><code>display</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⑦">CSSOMString</a></span>
     <dd data-md>
      <p>These attributes have the same meaning,
and are parsed the same as,
the corresponding descriptors in the CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule⑤">@font-face</a> rules.</p>
      <p>They turn on or off specific features in fonts that support them.
Unlike the previous attributes,
these attributes actually affect the font face.</p>
      <p>On getting, return the string associated with this attribute.</p>
      <p>On setting, <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar①">parse</a> the string according to the grammar for the corresponding <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule⑥">@font-face</a> descriptor.
If it does not match the grammar,
throw a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#syntaxerror" id="ref-for-syntaxerror①">SyntaxError</a></code>;
otherwise, set the attribute to the serialization of the parsed value.</p>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-status"><code>status</code></dfn>, <span> of type <a data-link-type="idl-name" href="#enumdef-fontfaceloadstatus" id="ref-for-enumdef-fontfaceloadstatus①">FontFaceLoadStatus</a>, readonly</span>
     <dd data-md>
      <p>This attribute reflects the current status of the font face.
It must be "unloaded" for a newly-created <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④">FontFace</a></code>.</p>
      <p>It can change due to an author explicitly requesting a font face to load,
such as through the <code class="idl"><a data-link-type="idl" href="#dom-fontface-load" id="ref-for-dom-fontface-load①">load()</a></code> method on <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑤">FontFace</a></code>,
or implicitly by the user agent,
due to it detecting that the font face is needed to draw some text on the screen.</p>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-loaded"><code>loaded</code></dfn>, <span> of type Promise&lt;<a data-link-type="idl-name" href="#fontface" id="ref-for-fontface⑥">FontFace</a>>, readonly</span>
     <dd data-md>
      <p>This attribute reflects the <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot">[[FontStatusPromise]]</a></code> of the font face.</p>
    </dl>
   </div>
   <p>All <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑦">FontFace</a></code> objects contain an internal <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-fontstatuspromise-slot"><code>[[FontStatusPromise]]</code></dfn> slot,
	which tracks the status of the font.
	It starts out pending,
	and fulfills or rejects when the font is successfully loaded and parsed, or hits an error.</p>
   <p>All <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑧">FontFace</a></code> objects also contain
	internal <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-urls-slot"><code>[[Urls]]</code></dfn> and <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="attribute" data-export id="dom-fontface-data-slot"><code>[[Data]]</code></dfn> slots,
	of which one is <code>null</code> and the other is not <code>null</code> (the non-null one is set by the constructor,
		based on which data is passed in).</p>
   <h3 class="heading settled" data-level="2.1" id="font-face-constructor"><span class="secno">2.1. </span><span class="content"> The Constructor</span><a class="self-link" href="#font-face-constructor"></a></h3>
   <p>A <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑨">FontFace</a></code> can be constructed either
	from a URL pointing to a font face file,
	or from an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-ArrayBuffer" id="ref-for-idl-ArrayBuffer①">ArrayBuffer</a></code> (or <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#ArrayBufferView" id="ref-for-ArrayBufferView①">ArrayBufferView</a></code>) containing the binary representation of a font face.</p>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="constructor" data-export data-lt="FontFace(family, source, descriptors)|constructor(family, source, descriptors)|FontFace(family, source)|constructor(family, source)" id="dom-fontface-fontface"><code>FontFace(family, source, descriptors)</code></dfn> method is called,
	execute these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>font face</var> be a fresh <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①⓪">FontFace</a></code> object.
Set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status①">status</a></code> attribute to <code>"unloaded"</code>,
Set its internal <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot①">[[FontStatusPromise]]</a></code> slot to a fresh pending <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise①">Promise</a></code> object.</p>
     <p><a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar②">Parse</a> the <code class="idl"><a class="idl-code" data-link-type="argument" href="#dom-fontface-fontface-family-source-descriptors-family" id="ref-for-dom-fontface-fontface-family-source-descriptors-family">family</a></code> argument,
and the members of the <code class="idl"><a class="idl-code" data-link-type="argument" href="#dom-fontface-fontface-family-source-descriptors-descriptors" id="ref-for-dom-fontface-fontface-family-source-descriptors-descriptors">descriptors</a></code> argument,
according to the grammars of the corresponding descriptors of the CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule⑦">@font-face</a> rule.
If the <code class="idl"><a class="idl-code" data-link-type="argument" href="#dom-fontface-fontface-family-source-descriptors-source" id="ref-for-dom-fontface-fontface-family-source-descriptors-source">source</a></code> argument is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⑧">CSSOMString</a></code>,
parse it according to the grammar of the CSS <span class="css">src</span> descriptor of the <span class="css" id="ref-for-at-font-face-rule⑧">@font-face</span> rule.
If any of them fail to parse correctly,
reject <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot②">[[FontStatusPromise]]</a></code> with a DOMException named "SyntaxError",
set <var>font face’s</var> corresponding attributes to the empty string,
and set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status②">status</a></code> attribute to "error".
Otherwise, set <var>font face’s</var> corresponding attributes to the serialization of the parsed values.</p>
     <p class="note" role="note"><span>Note:</span> Note that this means that passing a naked url as the source argument,
like <code>"http://example.com/myFont.woff"</code>,
won’t work - it needs to be at least wrapped in a <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-values-4/#funcdef-url" id="ref-for-funcdef-url">url()</a> function,
like <code>"url(http://example.com/myFont.woff)"</code>.
In return for this inconvenience,
you get to specify multiple fallbacks,
specify the type of font each fallback is,
and refer to local fonts easily.</p>
     <p class="issue" id="issue-65bdbf2d"><a class="self-link" href="#issue-65bdbf2d"></a> Need to define the base url,
so relative urls can resolve.
Should it be the url of the document?
Is that correct for workers too,
or should they use their worker url?
Is that always defined?</p>
     <p>Return <var>font face</var>.
If <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status③">status</a></code> is "error",
terminate this algorithm;
otherwise,
complete the rest of these steps asynchronously.</p>
    <li data-md>
     <p>If the <code class="idl"><a class="idl-code" data-link-type="argument" href="#dom-fontface-fontface-family-source-descriptors-source" id="ref-for-dom-fontface-fontface-family-source-descriptors-source①">source</a></code> argument was a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②⑨">CSSOMString</a></code>,
set <var>font face’s</var> internal <code class="idl"><a data-link-type="idl" href="#dom-fontface-urls-slot" id="ref-for-dom-fontface-urls-slot">[[Urls]]</a></code> slot to the string.</p>
     <p>If the <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontface-family-source-descriptors-source" id="ref-for-dom-fontface-fontface-family-source-descriptors-source②">source</a></code> argument was a <code class="idl"><a data-link-type="idl" href="#typedefdef-binarydata" id="ref-for-typedefdef-binarydata①">BinaryData</a></code>,
set <var>font face’s</var> internal <code class="idl"><a data-link-type="idl" href="#dom-fontface-data-slot" id="ref-for-dom-fontface-data-slot">[[Data]]</a></code> slot to the passed argument.</p>
    <li data-md>
     <p>If <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-data-slot" id="ref-for-dom-fontface-data-slot①">[[Data]]</a></code> slot is not <code>null</code>,
queue a task to run the following steps synchronously:</p>
     <ol>
      <li data-md>
       <p>Set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status④">status</a></code> attribute to "loading".</p>
      <li data-md>
       <p>For each <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset">FontFaceSet</a></code> <var>font face</var> is in:</p>
       <ol>
        <li data-md>
         <p>If the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot">[[LoadingFonts]]</a></code> list is empty, <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loading" id="ref-for-switch-the-fontfaceset-to-loading">switch the FontFaceSet to loading</a>.</p>
        <li data-md>
         <p>Append <var>font face</var> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot①">[[LoadingFonts]]</a></code> list.</p>
       </ol>
     </ol>
     <p>Asynchronously, attempt to parse the data in it as a font.
When this is completed,
successfully or not,
queue a task to run the following steps synchronously:</p>
     <ol>
      <li data-md>
       <p>If the load was successful, <var>font face</var> now represents the parsed font;
fulfill <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot③">[[FontStatusPromise]]</a></code> with <var>font face</var>,
and set its <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status⑤">status</a></code> attribute to "loaded".</p>
       <p>For each <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③">FontFaceSet</a></code> <var>font face</var> is in:</p>
       <ol>
        <li data-md>
         <p>Add <var>font face</var> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadedfonts-slot" id="ref-for-dom-fontfaceset-loadedfonts-slot">[[LoadedFonts]]</a></code> list.</p>
        <li data-md>
         <p>Remove <var>font face</var> from the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑤">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot②">[[LoadingFonts]]</a></code> list.
If <var>font</var> was the last item in that list
(and so the list is now empty), <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded">switch the FontFaceSet to loaded</a>.</p>
       </ol>
      <li data-md>
       <p>Otherwise,
reject <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot④">[[FontStatusPromise]]</a></code> with a DOMException named "SyntaxError"
and set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status⑥">status</a></code> attribute to "error".</p>
       <p>For each <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑥">FontFaceSet</a></code> <var>font face</var> is in:</p>
       <ol>
        <li data-md>
         <p>Add <var>font face</var> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑦">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-failedfonts-slot" id="ref-for-dom-fontfaceset-failedfonts-slot">[[FailedFonts]]</a></code> list.</p>
        <li data-md>
         <p>Remove <var>font face</var> from the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑧">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot③">[[LoadingFonts]]</a></code> list.
If <var>font</var> was the last item in that list
(and so the list is now empty), <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded①">switch the FontFaceSet to loaded</a>.</p>
       </ol>
     </ol>
   </ol>
   <p class="note" role="note"><span>Note:</span> Newly constructed FontFace objects are not automatically added
	to the FontFaceSet associated with a document
	or a context for a worker thread.
	This means that while newly constructed fonts can be preloaded,
	they cannot actually be used until they are explicitly added to a FontFaceSet.
	See the following section for a more complete description of FontFaceSet.</p>
   <h3 class="heading settled" data-level="2.2" id="font-face-load"><span class="secno">2.2. </span><span class="content"> The <code>load()</code> method</span><a class="self-link" href="#font-face-load"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#dom-fontface-load" id="ref-for-dom-fontface-load②">load()</a></code> method of <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①①">FontFace</a></code> forces a url-based font face to request its font data and load.
	For fonts constructed from binary data,
	or fonts that are already loading or loaded,
	it does nothing.</p>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="FontFace" data-dfn-type="method" data-export id="dom-fontface-load"><code>load()</code></dfn> method is called,
	execute these steps:</p>
   <ol>
    <li> Let <var>font face</var> be the <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①②">FontFace</a></code> object on which this method was called. 
    <li> If <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-urls-slot" id="ref-for-dom-fontface-urls-slot①">[[Urls]]</a></code> slot is <code>null</code>,
			or its <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status⑦">status</a></code> attribute is anything other than <code>"unloaded"</code>,
			return <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot⑤">[[FontStatusPromise]]</a></code> and abort these steps. 
    <li> Otherwise,
			set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status⑧">status</a></code> attribute to "loading",
			return <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot⑥">[[FontStatusPromise]]</a></code>,
			and continue executing the rest of this algorithm asynchronously. 
    <li> Using the value of <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-urls-slot" id="ref-for-dom-fontface-urls-slot②">[[Urls]]</a></code> slot,
			attempt to load a font as defined in <a data-link-type="biblio" href="#biblio-css-fonts-3">[CSS-FONTS-3]</a>,
			as if it was the value of a <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule⑨">@font-face</a> rule’s <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-3/#descdef-src" id="ref-for-descdef-src">src</a> descriptor. 
    <li>
      When the load operation completes,
			successfully or not,
			queue a task to run the following steps synchronously: 
     <ol>
      <li>
        If the attempt to load fails,
					reject <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot⑦">[[FontStatusPromise]]</a></code> with
					a DOMException whose name is "NetworkError"
					and set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status⑨">status</a></code> attribute to "error". 
       <p>For each <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑨">FontFaceSet</a></code> <var>font face</var> is in:</p>
       <ol>
        <li data-md>
         <p>Add <var>font face</var> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①⓪">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-failedfonts-slot" id="ref-for-dom-fontfaceset-failedfonts-slot①">[[FailedFonts]]</a></code> list.</p>
        <li data-md>
         <p>Remove <var>font face</var> from the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①①">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot④">[[LoadingFonts]]</a></code> list.
If <var>font</var> was the last item in that list
(and so the list is now empty), <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded②">switch the FontFaceSet to loaded</a>.</p>
       </ol>
      <li>
        Otherwise, <var>font face</var> now represents the loaded font;
					fulfill <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot⑧">[[FontStatusPromise]]</a></code> with <var>font face</var> and set <var>font face’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status①⓪">status</a></code> attribute to "loaded". 
       <p>For each <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①②">FontFaceSet</a></code> <var>font face</var> is in:</p>
       <ol>
        <li data-md>
         <p>Add <var>font face</var> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①③">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadedfonts-slot" id="ref-for-dom-fontfaceset-loadedfonts-slot①">[[LoadedFonts]]</a></code> list.</p>
        <li data-md>
         <p>Remove <var>font face</var> from the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①④">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot⑤">[[LoadingFonts]]</a></code> list.
If <var>font</var> was the last item in that list
(and so the list is now empty), <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded③">switch the FontFaceSet to loaded</a>.</p>
       </ol>
     </ol>
   </ol>
   <p>User agents can initiate font loads on their own,
	whenever they determine that a given font face is necessary to render something on the page.
	When this happens,
	they must act as if they had called the corresponding <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①③">FontFace</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontface-load" id="ref-for-dom-fontface-load③">load()</a></code> method described here.</p>
   <p class="note" role="note"><span>Note:</span> Some UAs utilize a "font cache"
	which avoids having to download the same font multiple times
	on a page or on multiple pages within the same origin.
	Multiple <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①④">FontFace</a></code> objects can be mapped to the same entry in the font cache,
	which means that a <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①⑤">FontFace</a></code> object might start loading unexpectedly,
	even if it’s not in a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset①⑤">FontFaceSet</a></code>,
	because some other <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①⑥">FontFace</a></code> object pointing to the same font data
	(perhaps on a different page entirely!)
	has been loaded.</p>
   <h3 class="heading settled" data-level="2.3" id="font-face-css-connection"><span class="secno">2.3. </span><span class="content"> Interaction with CSS’s <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①⓪">@font-face</a> Rule</span><a class="self-link" href="#font-face-css-connection"></a></h3>
   <p>A CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①①">@font-face</a> rule automatically defines a corresponding <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①⑦">FontFace</a></code> object,
	which is automatically placed in the document’s <a data-link-type="dfn" href="#font-source" id="ref-for-font-source">font source</a> when the rule is parsed.
	This <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①⑧">FontFace</a></code> object is <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="css-connected">CSS-connected</dfn>.</p>
   <p>The <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface①⑨">FontFace</a></code> object corresponding to a <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①②">@font-face</a> rule
	has its <code class="idl"><a data-link-type="idl" href="#dom-fontface-family" id="ref-for-dom-fontface-family①">family</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-fontface-style" id="ref-for-dom-fontface-style②">style</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-fontface-weight" id="ref-for-dom-fontface-weight①">weight</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-fontface-stretch" id="ref-for-dom-fontface-stretch①">stretch</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-fontface-unicoderange" id="ref-for-dom-fontface-unicoderange①">unicodeRange</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-fontface-variant" id="ref-for-dom-fontface-variant①">variant</a></code>, and <code class="idl"><a data-link-type="idl" href="#dom-fontface-featuresettings" id="ref-for-dom-fontface-featuresettings①">featureSettings</a></code> attributes
	set to the same value as the corresponding descriptors in the <span class="css" id="ref-for-at-font-face-rule①③">@font-face</span> rule.
	There is a two-way connection between the two:
	any change made to a <span class="css" id="ref-for-at-font-face-rule①④">@font-face</span> descriptor is immediately reflected in the corresponding <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②⓪">FontFace</a></code> attribute,
	and vice versa.</p>
   <p class="issue" id="issue-41199acf"><a class="self-link" href="#issue-41199acf"></a> When a FontFace is transferred between documents, it’s no longer CSS-connected.</p>
   <p>The internal <code class="idl"><a data-link-type="idl" href="#dom-fontface-urls-slot" id="ref-for-dom-fontface-urls-slot③">[[Urls]]</a></code> slot of the <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②①">FontFace</a></code> object is set to the value of the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①⑤">@font-face</a> rule’s <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-3/#descdef-src" id="ref-for-descdef-src①">src</a> descriptor,
	and reflects any changes made to the <span class="property" id="ref-for-descdef-src②">src</span> descriptor.</p>
   <p>Otherwise, a <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②②">FontFace</a></code> object created by a CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①⑥">@font-face</a> rule is identical to one created manually.</p>
   <p>If a <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①⑦">@font-face</a> rule is removed from the document, its corresponding <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②③">FontFace</a></code> object is no longer <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected">CSS-connected</a>.
	The connection is not restorable by any means
	(but adding the <span class="css" id="ref-for-at-font-face-rule①⑧">@font-face</span> back to the stylesheet will create a brand new <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②④">FontFace</a></code> object which <em>is</em> <span id="ref-for-css-connected①">CSS-connected</span>).</p>
   <p>If a <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule①⑨">@font-face</a> rule has its <a class="property" data-link-type="propdesc">src</a> descriptor changed to a new value,
	the original connected <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②⑤">FontFace</a></code> object must stop being <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected②">CSS-connected</a>.
	A new <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②⑥">FontFace</a></code> reflecting its new <span class="property">src</span> must be created
	and <span id="ref-for-css-connected③">CSS-connected</span> to the <span class="css" id="ref-for-at-font-face-rule②⓪">@font-face</span>.
	(This will also remove the old and add the new <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface②⑦">FontFace</a></code> objects from any <a data-link-type="dfn" href="#font-source" id="ref-for-font-source①">font sources</a> they appear in.)</p>
   <h2 class="heading settled" data-level="3" id="FontFaceSet-interface"><span class="secno">3. </span><span class="content"> The <code>FontFaceSet</code> Interface</span><a class="self-link" href="#FontFaceSet-interface"></a></h2>
<pre class="idl highlight def"><c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-fontfacesetloadeventinit"><code><c- g>FontFaceSetLoadEventInit</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit" id="ref-for-dictdef-eventinit"><c- n>EventInit</c-></a> {
  <c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface②⑧"><c- n>FontFace</c-></a>> <dfn class="idl-code" data-default="[]" data-dfn-for="FontFaceSetLoadEventInit" data-dfn-type="dict-member" data-export data-type="sequence<FontFace> " id="dom-fontfacesetloadeventinit-fontfaces"><code><c- g>fontfaces</c-></code><a class="self-link" href="#dom-fontfacesetloadeventinit-fontfaces"></a></dfn> = [];
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="fontfacesetloadevent"><code><c- g>FontFaceSetLoadEvent</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event" id="ref-for-event"><c- n>Event</c-></a> {
  <dfn class="idl-code" data-dfn-for="FontFaceSetLoadEvent" data-dfn-type="constructor" data-export data-lt="FontFaceSetLoadEvent(type, eventInitDict)|constructor(type, eventInitDict)|FontFaceSetLoadEvent(type)|constructor(type)" id="dom-fontfacesetloadevent-fontfacesetloadevent"><code><c- g>constructor</c-></code><a class="self-link" href="#dom-fontfacesetloadevent-fontfacesetloadevent"></a></dfn>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③⓪"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="FontFaceSetLoadEvent/FontFaceSetLoadEvent(type, eventInitDict), FontFaceSetLoadEvent/constructor(type, eventInitDict), FontFaceSetLoadEvent/FontFaceSetLoadEvent(type), FontFaceSetLoadEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-fontfacesetloadevent-fontfacesetloadevent-type-eventinitdict-type"><code><c- g>type</c-></code><a class="self-link" href="#dom-fontfacesetloadevent-fontfacesetloadevent-type-eventinitdict-type"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-fontfacesetloadeventinit" id="ref-for-dictdef-fontfacesetloadeventinit"><c- n>FontFaceSetLoadEventInit</c-></a> <dfn class="idl-code" data-dfn-for="FontFaceSetLoadEvent/FontFaceSetLoadEvent(type, eventInitDict), FontFaceSetLoadEvent/constructor(type, eventInitDict), FontFaceSetLoadEvent/FontFaceSetLoadEvent(type), FontFaceSetLoadEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-fontfacesetloadevent-fontfacesetloadevent-type-eventinitdict-eventinitdict"><code><c- g>eventInitDict</c-></code><a class="self-link" href="#dom-fontfacesetloadevent-fontfacesetloadevent-type-eventinitdict-eventinitdict"></a></dfn> = {});
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <c- b>FrozenArray</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface②⑨"><c- n>FontFace</c-></a>> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSetLoadEvent" data-dfn-type="attribute" data-export data-readonly data-type="FrozenArray<FontFace>" id="dom-fontfacesetloadevent-fontfaces"><code><c- g>fontfaces</c-></code></dfn>;
};

<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-fontfacesetloadstatus"><code><c- g>FontFaceSetLoadStatus</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="FontFaceSetLoadStatus" data-dfn-type="enum-value" data-export id="dom-fontfacesetloadstatus-loading"><code><c- s>"loading"</c-></code><a class="self-link" href="#dom-fontfacesetloadstatus-loading"></a></dfn>, <dfn class="idl-code" data-dfn-for="FontFaceSetLoadStatus" data-dfn-type="enum-value" data-export id="dom-fontfacesetloadstatus-loaded"><code><c- s>"loaded"</c-></code><a class="self-link" href="#dom-fontfacesetloadstatus-loaded"></a></dfn> };

<c- b>callback</c-> <dfn class="idl-code" data-dfn-type="callback" data-export id="callbackdef-foreachcallback"><code><c- g>ForEachCallback</c-></code><a class="self-link" href="#callbackdef-foreachcallback"></a></dfn> = <c- b>void</c-> (<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface③⓪"><c- n>FontFace</c-></a> <dfn class="idl-code" data-dfn-for="ForEachCallback" data-dfn-type="argument" data-export id="dom-foreachcallback-font"><code><c- g>font</c-></code><a class="self-link" href="#dom-foreachcallback-font"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="ForEachCallback" data-dfn-type="argument" data-export id="dom-foreachcallback-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-foreachcallback-index"></a></dfn>, <a class="n" data-link-type="idl-name" href="#fontfaceset" id="ref-for-fontfaceset①⑥"><c- n>FontFaceSet</c-></a> <dfn class="idl-code" data-dfn-for="ForEachCallback" data-dfn-type="argument" data-export id="dom-foreachcallback-self"><code><c- g>self</c-></code><a class="self-link" href="#dom-foreachcallback-self"></a></dfn>);

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="fontfaceset"><code><c- g>FontFaceSet</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#eventtarget" id="ref-for-eventtarget"><c- n>EventTarget</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-fontfaceset-fontfaceset" id="ref-for-dom-fontfaceset-fontfaceset"><c- g>constructor</c-></a>(<c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface③①"><c- n>FontFace</c-></a>> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet/FontFaceSet(initialFaces), FontFaceSet/constructor(initialFaces)" data-dfn-type="argument" data-export id="dom-fontfaceset-fontfaceset-initialfaces-initialfaces"><code><c- g>initialFaces</c-></code></dfn>);

  // FontFaceSet is Set-like!
  <c- b>setlike</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface③②"><c- n>FontFace</c-></a>>;
  <a class="n" data-link-type="idl-name" href="#fontfaceset" id="ref-for-fontfaceset①⑦"><c- n>FontFaceSet</c-></a> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-add" id="ref-for-dom-fontfaceset-add"><c- g>add</c-></a>(<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface③③"><c- n>FontFace</c-></a> <dfn class="idl-code" data-dfn-for="FontFaceSet/add(font)" data-dfn-type="argument" data-export id="dom-fontfaceset-add-font-font"><code><c- g>font</c-></code><a class="self-link" href="#dom-fontfaceset-add-font-font"></a></dfn>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-delete" id="ref-for-dom-fontfaceset-delete"><c- g>delete</c-></a>(<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface③④"><c- n>FontFace</c-></a> <dfn class="idl-code" data-dfn-for="FontFaceSet/delete(font)" data-dfn-type="argument" data-export id="dom-fontfaceset-delete-font-font"><code><c- g>font</c-></code><a class="self-link" href="#dom-fontfaceset-delete-font-font"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-clear" id="ref-for-dom-fontfaceset-clear"><c- g>clear</c-></a>();

  // events for when loading state changes
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-fontfaceset-onloading"><code><c- g>onloading</c-></code></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler①"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-fontfaceset-onloadingdone"><code><c- g>onloadingdone</c-></code></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler②"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-fontfaceset-onloadingerror"><code><c- g>onloadingerror</c-></code></dfn>;

  // check and start loads if appropriate
  // and fulfill promise when all loads complete
  <c- b>Promise</c->&lt;<c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface" id="ref-for-fontface③⑤"><c- n>FontFace</c-></a>>> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-load" id="ref-for-dom-fontfaceset-load"><c- g>load</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-load-font-text-font" id="ref-for-dom-fontfaceset-load-font-text-font"><c- g>font</c-></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-load-font-text-text" id="ref-for-dom-fontfaceset-load-font-text-text"><c- g>text</c-></a> = " ");

  // return whether all fonts in the fontlist are loaded
  // (does not initiate load if not available)
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-check" id="ref-for-dom-fontfaceset-check"><c- g>check</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③③"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-check-font-text-font" id="ref-for-dom-fontfaceset-check-font-text-font"><c- g>font</c-></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③④"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-check-font-text-text" id="ref-for-dom-fontfaceset-check-font-text-text"><c- g>text</c-></a> = " ");

  // async notification that font loading and layout operations are done
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#fontfaceset" id="ref-for-fontfaceset①⑧"><c- n>FontFaceSet</c-></a>> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Promise<FontFaceSet>" href="#dom-fontfaceset-ready" id="ref-for-dom-fontfaceset-ready"><c- g>ready</c-></a>;

  // loading state, "loading" while one or more fonts loading, "loaded" otherwise
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#enumdef-fontfacesetloadstatus" id="ref-for-enumdef-fontfacesetloadstatus"><c- n>FontFaceSetLoadStatus</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export data-readonly data-type="FontFaceSetLoadStatus" id="dom-fontfaceset-status"><code><c- g>status</c-></code></dfn>;
};
</pre>
   <p><code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-load" id="ref-for-dom-fontfaceset-load①">load()</a></code></p>
   <div>
    <dl>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export id="dom-fontfaceset-ready"><code>ready</code></dfn>, <span> of type Promise&lt;<a data-link-type="idl-name" href="#fontfaceset" id="ref-for-fontfaceset①⑨">FontFaceSet</a>>, readonly</span>
     <dd data-md>
      <p>This attribute reflects the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②⓪">FontFaceSet</a></code>'s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-readypromise-slot" id="ref-for-dom-fontfaceset-readypromise-slot">[[ReadyPromise]]</a></code> slot.</p>
      <p>See <a href="#font-face-set-ready">§ 3.4 The ready attribute</a> for more details on this <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise②">Promise</a></code> and its use.</p>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="constructor" data-export data-lt="FontFaceSet(initialFaces)|constructor(initialFaces)" id="dom-fontfaceset-fontfaceset"><code>FontFaceSet(initialFaces)</code></dfn>
     <dd data-md>
      <p>The <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②①">FontFaceSet</a></code> constructor, when called,
must iterate its <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-fontfaceset-initialfaces-initialfaces" id="ref-for-dom-fontfaceset-fontfaceset-initialfaces-initialfaces">initialFaces</a></code> argument
and add each value to its <a data-link-type="dfn" href="#fontfaceset-set-entries" id="ref-for-fontfaceset-set-entries">set entries</a>.</p>
     <dt data-md><dfn data-dfn-for="FontFaceSet" data-dfn-type="dfn" data-export id="fontfaceset-iteration-order">iteration order<a class="self-link" href="#fontfaceset-iteration-order"></a></dfn>
     <dd data-md>
      <p>When iterated over,
all <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected④">CSS-connected</a> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface③⑥">FontFace</a></code> objects must come first,
in document order of their connected <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②①">@font-face</a> rules,
followed by the non-<span id="ref-for-css-connected⑤">CSS-connected</span> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface③⑦">FontFace</a></code> objects,
in insertion order.</p>
     <dt data-md><dfn class="dfn-paneled" data-dfn-for="FontFaceSet" data-dfn-type="dfn" data-noexport id="fontfaceset-set-entries">set entries</dfn>
     <dd data-md>
      <p>If a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②②">FontFaceSet</a></code> is a <a data-link-type="dfn" href="#font-source" id="ref-for-font-source②">font source</a>,
its <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-set-entries" id="ref-for-dfn-set-entries">set entries</a> are initialized as specified in <a href="#document-font-face-set">§ 4.2 Interaction with CSS’s @font-face Rule</a>.</p>
      <p>Otherwise, its <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-set-entries" id="ref-for-dfn-set-entries①">set entries</a> are initially empty.</p>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="method" data-export id="dom-fontfaceset-add"><code>add(font)</code></dfn>
     <dd data-md>
      <p>When the <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-add" id="ref-for-dom-fontfaceset-add①">add()</a></code> method is called,
execute the following steps:</p>
      <ol>
       <li data-md>
        <p>If <var>font</var> is already in the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②③">FontFaceSet</a></code>’s <a data-link-type="dfn" href="#fontfaceset-set-entries" id="ref-for-fontfaceset-set-entries①">set entries</a>,
skip to the last step of this algorithm immediately.</p>
       <li data-md>
        <p>If <var>font</var> is <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected⑥">CSS-connected</a>,
throw an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#invalidmodificationerror" id="ref-for-invalidmodificationerror">InvalidModificationError</a></code> exception
and exit this algorithm immediately.</p>
       <li data-md>
        <p>Add the <var>font</var> argument to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②④">FontFaceSet</a></code>’s <a data-link-type="dfn" href="#fontfaceset-set-entries" id="ref-for-fontfaceset-set-entries②">set entries</a>.</p>
       <li data-md>
        <p>If <var>font</var>’s <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status①①">status</a></code> attribute is "loading":</p>
        <ol>
         <li data-md>
          <p>If the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②⑤">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot⑥">[[LoadingFonts]]</a></code> list is empty, <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loading" id="ref-for-switch-the-fontfaceset-to-loading①">switch the FontFaceSet to loading</a>.</p>
         <li data-md>
          <p>Append <var>font</var> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②⑥">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot⑦">[[LoadingFonts]]</a></code> list.</p>
        </ol>
       <li data-md>
        <p>Return the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②⑦">FontFaceSet</a></code>.</p>
      </ol>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="method" data-export id="dom-fontfaceset-delete"><code>delete(font)</code></dfn>
     <dd data-md>
      <p>When the <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-delete" id="ref-for-dom-fontfaceset-delete①">delete()</a></code> method is called,
execute the following steps:</p>
      <ol>
       <li data-md>
        <p>If <var>font</var> is <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected⑦">CSS-connected</a>,
return <code class="lang-javascript highlight"><c- kc>false</c-></code> and exit this algorithm immediately.</p>
       <li data-md>
        <p>Let <var>deleted</var> be the result of removing <var>font</var> from the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②⑧">FontFaceSet</a></code>’s <a data-link-type="dfn" href="#fontfaceset-set-entries" id="ref-for-fontfaceset-set-entries③">set entries</a>.</p>
       <li data-md>
        <p>If <var>font</var> is present in the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset②⑨">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadedfonts-slot" id="ref-for-dom-fontfaceset-loadedfonts-slot②">[[LoadedFonts]]</a></code>, or <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-failedfonts-slot" id="ref-for-dom-fontfaceset-failedfonts-slot②">[[FailedFonts]]</a></code> lists,
remove it.</p>
       <li data-md>
        <p>If <var>font</var> is present in the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③⓪">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot⑧">[[LoadingFonts]]</a></code> list,
remove it.
If <var>font</var> was the last item in that list
(and so the list is now empty), <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded④">switch the FontFaceSet to loaded</a>.</p>
       <li data-md>
        <p>Return <var>deleted</var>.</p>
      </ol>
     <dt data-md><dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="method" data-export id="dom-fontfaceset-clear"><code>clear()</code></dfn>
     <dd data-md>
      <p>When the <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-clear" id="ref-for-dom-fontfaceset-clear①">clear()</a></code> method is called,
execute the following steps:</p>
      <ol>
       <li data-md>
        <p>Remove all items from the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③①">FontFaceSet</a></code>’s <a data-link-type="dfn" href="#fontfaceset-set-entries" id="ref-for-fontfaceset-set-entries④">set entries</a>,
its <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadedfonts-slot" id="ref-for-dom-fontfaceset-loadedfonts-slot③">[[LoadedFonts]]</a></code> list,
and its <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-failedfonts-slot" id="ref-for-dom-fontfaceset-failedfonts-slot③">[[FailedFonts]]</a></code> list.</p>
       <li data-md>
        <p>If the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③②">FontFaceSet</a></code>’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot⑨">[[LoadingFonts]]</a></code> list is non-empty,
remove all items from it,
then <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded⑤">switch the FontFaceSet to loaded</a>.</p>
      </ol>
    </dl>
   </div>
   <p><code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③③">FontFaceSet</a></code> objects also have internal <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export id="dom-fontfaceset-loadingfonts-slot"><code>[[LoadingFonts]]</code></dfn>, <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export id="dom-fontfaceset-loadedfonts-slot"><code>[[LoadedFonts]]</code></dfn>,
	and <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export id="dom-fontfaceset-failedfonts-slot"><code>[[FailedFonts]]</code></dfn> slots,
	all of which are initialized to empty lists,
	and a <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="attribute" data-export id="dom-fontfaceset-readypromise-slot"><code>[[ReadyPromise]]</code></dfn> slot,
	which is initialized to a fresh pending <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise③">Promise</a></code>.</p>
   <p>Because font families are loaded only when they are used,
	content sometimes needs to understand when the loading of fonts occurs.
	Authors can use the events and methods defined here to allow greater control over actions
	that are dependent upon the availability of specific fonts.</p>
   <p>A <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③④">FontFaceSet</a></code> is <dfn class="dfn-paneled" data-dfn-for="FontFaceSet" data-dfn-type="dfn" data-export id="fontfaceset-pending-on-the-environment">pending on the environment</dfn> if any of the following are true:</p>
   <ul>
    <li data-md>
     <p>the document is still loading</p>
    <li data-md>
     <p>the document has pending stylesheet requests</p>
    <li data-md>
     <p>the document has pending layout operations which might cause the user agent to request a font,
or which depend on recently-loaded fonts</p>
   </ul>
   <p class="note" role="note"><span>Note:</span> The idea is that once a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③⑤">FontFaceSet</a></code> stops being <a data-link-type="dfn" href="#fontfaceset-pending-on-the-environment" id="ref-for-fontfaceset-pending-on-the-environment">pending on the environment</a>,
	as long as nothing further changes the document,
	an author can depend on sizes/positions of things being "correct" when measured.
	If the above conditions do not fully capture this guarantee,
	they need to be amended to do so.</p>
   <h3 class="heading settled" data-level="3.1" id="FontFaceSet-events"><span class="secno">3.1. </span><span class="content"> Events</span><a class="self-link" href="#FontFaceSet-events"></a></h3>
   <p>Font load events make it easy to respond to the font-loading behavior of the entire document,
	rather than having to listen to each font specifically.
	The <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="event" data-export id="eventdef-fontfaceset-loading"><code>loading</code></dfn> event
	fires when the document begins loading fonts,
	while the <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="event" data-export id="eventdef-fontfaceset-loadingdone"><code>loadingdone</code></dfn> and <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="event" data-export id="eventdef-fontfaceset-loadingerror"><code>loadingerror</code></dfn> events
	fire when the document is done loading fonts,
	containing the fonts that successfully loaded
	or failed to load,
	respectively.</p>
   <p>The following are the event handlers (and their corresponding event handler event types)
	that must be supported by <code>FontFaceSet</code> objects as IDL attributes:</p>
   <table class="data" id="eventhandlers">
    <thead>
     <tr>
      <th>Event handler 
      <th>Event handler event type 
    <tbody>
     <tr>
      <th><code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-onloading" id="ref-for-dom-fontfaceset-onloading">onloading</a></code> 
      <td><code class="idl"><a class="idl-code" data-link-type="event" href="#eventdef-fontfaceset-loading" id="ref-for-eventdef-fontfaceset-loading">loading</a></code> 
     <tr>
      <th><code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-onloadingdone" id="ref-for-dom-fontfaceset-onloadingdone">onloadingdone</a></code> 
      <td><code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingdone" id="ref-for-eventdef-fontfaceset-loadingdone">loadingdone</a></code> 
     <tr>
      <th><code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-onloadingerror" id="ref-for-dom-fontfaceset-onloadingerror">onloadingerror</a></code> 
      <td><code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingerror" id="ref-for-eventdef-fontfaceset-loadingerror">loadingerror</a></code> 
   </table>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fire-a-font-load-event">fire a font load event</dfn> named <var>e</var> at a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③⑥">FontFaceSet</a></code> <var>target</var> with optional <var>font faces</var> means to <a href="https://www.w3.org/TR/html5/webappapis.html#event-firing">fire a simple event</a> named <var>e</var> using the <code class="idl"><a data-link-type="idl" href="#fontfacesetloadevent" id="ref-for-fontfacesetloadevent">FontFaceSetLoadEvent</a></code> interface that also meets these conditions:</p>
   <ol>
    <li> The <code class="idl"><a data-link-type="idl" href="#dom-fontfacesetloadevent-fontfaces" id="ref-for-dom-fontfacesetloadevent-fontfaces">fontfaces</a></code> attribute is initialized to
			the result of filtering <var>font faces</var> to only contain <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface③⑧">FontFace</a></code> objects contained in <var>target</var>. 
   </ol>
   <p>When asked to <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="switch-the-fontfaceset-to-loading">switch the FontFaceSet to loading</dfn> for a given <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③⑦">FontFaceSet</a></code>,
	the user agent must run the following steps:</p>
   <ol>
    <li> Let <var>font face set</var> be the given <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③⑧">FontFaceSet</a></code>. 
    <li> Set the <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-status" id="ref-for-dom-fontfaceset-status">status</a></code> attribute of <var>font face set</var> to "loading". 
    <li> If <var>font face set’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-readypromise-slot" id="ref-for-dom-fontfaceset-readypromise-slot①">[[ReadyPromise]]</a></code> slot currently holds a fulfilled promise,
			replace it with a fresh pending promise. 
    <li> Queue a task to <a data-link-type="dfn" href="#fire-a-font-load-event" id="ref-for-fire-a-font-load-event">fire a font load event</a> named <code class="idl"><a class="idl-code" data-link-type="event" href="#eventdef-fontfaceset-loading" id="ref-for-eventdef-fontfaceset-loading①">loading</a></code> at <var>font face set</var>. 
   </ol>
   <p>When asked to <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="switch-the-fontfaceset-to-loaded">switch the FontFaceSet to loaded</dfn> for a given <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset③⑨">FontFaceSet</a></code>,
	the user agent must run the following steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>font face set</var> be the given <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④⓪">FontFaceSet</a></code>.</p>
    <li data-md>
     <p>If <var>font face set</var> is <a data-link-type="dfn" href="#fontfaceset-pending-on-the-environment" id="ref-for-fontfaceset-pending-on-the-environment①">pending on the environment</a>,
mark it as <dfn class="dfn-paneled" data-dfn-for="FontFaceSet" data-dfn-type="dfn" data-export id="fontfaceset-stuck-on-the-environment">stuck on the environment</dfn>,
and exit this algorithm.</p>
    <li data-md>
     <p>Set <var>font face set’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-status" id="ref-for-dom-fontfaceset-status①">status</a></code> attribute to "loaded".</p>
    <li data-md>
     <p>Fulfill <var>font face set’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-readypromise-slot" id="ref-for-dom-fontfaceset-readypromise-slot②">[[ReadyPromise]]</a></code> attribute’s value with <var>font face set</var>.</p>
    <li data-md>
     <p>Queue a task to perform the following steps synchronously:</p>
     <ol>
      <li data-md>
       <p>Let <var>loaded fonts</var> be the (possibly empty) contents of <var>font face set’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadedfonts-slot" id="ref-for-dom-fontfaceset-loadedfonts-slot④">[[LoadedFonts]]</a></code> slot.</p>
      <li data-md>
       <p>Let <var>failed fonts</var> be the (possibly empty) contents of <var>font face set’s</var> <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-failedfonts-slot" id="ref-for-dom-fontfaceset-failedfonts-slot④">[[FailedFonts]]</a></code> slot.</p>
      <li data-md>
       <p>Reset the <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadedfonts-slot" id="ref-for-dom-fontfaceset-loadedfonts-slot⑤">[[LoadedFonts]]</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-failedfonts-slot" id="ref-for-dom-fontfaceset-failedfonts-slot⑤">[[FailedFonts]]</a></code> slots to empty lists.</p>
      <li data-md>
       <p><a data-link-type="dfn" href="#fire-a-font-load-event" id="ref-for-fire-a-font-load-event①">Fire a font load event</a> named <code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingdone" id="ref-for-eventdef-fontfaceset-loadingdone①">loadingdone</a></code> at <var>font face set</var> with <var>loaded fonts</var>.</p>
      <li data-md>
       <p>If <var>font face set’s</var> <var>failed fonts</var> is non-empty, <a data-link-type="dfn" href="#fire-a-font-load-event" id="ref-for-fire-a-font-load-event②">fire a font load event</a> named <code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingerror" id="ref-for-eventdef-fontfaceset-loadingerror①">loadingerror</a></code> at <var>font face set</var> with <var>failed fonts</var>.</p>
     </ol>
   </ol>
   <p>Whenever a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④①">FontFaceSet</a></code> goes from <a data-link-type="dfn" href="#fontfaceset-pending-on-the-environment" id="ref-for-fontfaceset-pending-on-the-environment②">pending on the environment</a> to not <span id="ref-for-fontfaceset-pending-on-the-environment③">pending on the environment</span>,
	the user agent must run the following steps:</p>
   <ol>
    <li data-md>
     <p>If the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④②">FontFaceSet</a></code> is <a data-link-type="dfn" href="#fontfaceset-stuck-on-the-environment" id="ref-for-fontfaceset-stuck-on-the-environment">stuck on the environment</a> and its <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-loadingfonts-slot" id="ref-for-dom-fontfaceset-loadingfonts-slot①⓪">[[LoadingFonts]]</a></code> list is empty, <a data-link-type="dfn" href="#switch-the-fontfaceset-to-loaded" id="ref-for-switch-the-fontfaceset-to-loaded⑥">switch the FontFaceSet to loaded</a>.</p>
    <li data-md>
     <p>If the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④③">FontFaceSet</a></code> is <a data-link-type="dfn" href="#fontfaceset-stuck-on-the-environment" id="ref-for-fontfaceset-stuck-on-the-environment①">stuck on the environment</a>,
unmark it as such.</p>
   </ol>
   <p>If asked to <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="find-the-matching-font-faces">find the matching font faces</dfn> from a FontFaceSet <var>source</var>,
	for a given font string <var>font</var> optionally some sample text <var>text</var>,
	and optionally an <var>allow system fonts</var> flag,
	run the following steps:</p>
   <ol>
    <li>
      Parse <var>font</var> using the CSS value syntax of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-3/#propdef-font" id="ref-for-propdef-font">font</a> property.
			If a syntax error occurs,
			return a syntax error. 
     <p>If the parsed value is a <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#css-wide-keywords" id="ref-for-css-wide-keywords">CSS-wide keyword</a>,
			return a syntax error.</p>
     <p>Absolutize all relative lengths against the initial values of the corresponding properties.
			(For example, a relative font weight like <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#valdef-font-weight-bolder" id="ref-for-valdef-font-weight-bolder">bolder</a> is evaluated against the initial value <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#valdef-font-weight-normal" id="ref-for-valdef-font-weight-normal">normal</a>.)</p>
    <li> If <var>text</var> was not explicitly provided,
			let it be a string containing a single space character (U+0020 SPACE). 
    <li> Let <var>font family list</var> be the list of font families parsed from <var>font</var>,
			and <var>font style</var> be the other font style attributes parsed from <var>font</var>. 
    <li> Let <var>available font faces</var> be the <a data-link-type="dfn" href="#available-font-faces" id="ref-for-available-font-faces">available font faces</a> within <var>source</var>.
			If the <var>allow system fonts</var> flag is specified,
			add all system fonts to <var>available font faces</var>. 
    <li> Let <var>matched font faces</var> initially be an empty list. 
    <li> For each family in <var>font family list</var>,
			use the font matching rules to select the font faces from <var>available font faces</var> that match the <var>font style</var>,
			and add them to <var>matched font faces</var>.
			The use of the <code class="idl"><a data-link-type="idl" href="#dom-fontface-unicoderange" id="ref-for-dom-fontface-unicoderange②">unicodeRange</a></code> attribute means that this may be more than just a single font face. 
    <li> If <var>matched font faces</var> is empty,
			set the <var>found faces</var> flag to false.
			Otherwise, set it to true. 
    <li>
      For each font face in <var>matched font faces</var>,
			if its defined <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-unicode-range" id="ref-for-descdef-font-face-unicode-range">unicode-range</a> does not include the codepoint of at least one character in <var>text</var>,
			remove it from the list. 
     <p class="note" role="note"><span>Note:</span> Therefore, if <var>text</var> is the empty string, every font will be removed.</p>
    <li> Return <var>matched font faces</var> and the <var>found faces</var> flag. 
   </ol>
   <h3 class="heading settled" data-level="3.2" id="font-face-set-load"><span class="secno">3.2. </span><span class="content"> The <code>load()</code> method</span><a class="self-link" href="#font-face-set-load"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-load" id="ref-for-dom-fontfaceset-load②">load()</a></code> method of <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④④">FontFaceSet</a></code> will determine whether all fonts in the given font list
	have been loaded and are available.
	If any fonts are downloadable fonts and have not already been loaded,
	the user agent will initiate the load of each of these fonts.
	It returns a Promise,
	which is fulfilled when all of the fonts are loaded and ready to be used,
	or rejected if any font failed to load properly.</p>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="method" data-export data-lt="load(font, text)|load(font)" id="dom-fontfaceset-load"><code>load</code></dfn>( <span> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet/load(font, text)" data-dfn-type="argument" data-export id="dom-fontfaceset-load-font-text-font"><code>font</code></dfn>, <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet/load(font, text)" data-dfn-type="argument" data-export id="dom-fontfaceset-load-font-text-text"><code>text</code></dfn> </span> ) method is called,
	execute these steps:</p>
   <ol>
    <li> Let <var>font face set</var> be the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④⑤">FontFaceSet</a></code> object this method was called on.
			Let <var>promise</var> be a newly-created promise object. 
    <li> Return <var>promise</var>.
			Complete the rest of these steps asynchronously. 
    <li> <a data-link-type="dfn" href="#find-the-matching-font-faces" id="ref-for-find-the-matching-font-faces">Find the matching font faces</a> from <var>font face set</var> using the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/css-font-loading-3/#dom-fontfacesetload-font" id="ref-for-dom-fontfacesetload-font">font</a></code> and <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/css-font-loading-3/#dom-fontfacesetload-text" id="ref-for-dom-fontfacesetload-text">text</a></code> arguments passed to the function,
			and let <var>font face list</var> be the return value
			(ignoring the <var>found faces</var> flag).
			If a syntax error was returned,
			reject <var>promise</var> with a SyntaxError exception
			and terminate these steps. 
    <li>
      Queue a task to run the following steps synchronously: 
     <ol>
      <li> For all of the font faces in the <var>font face list</var>,
					call their <code class="idl"><a data-link-type="idl" href="#dom-fontface-load" id="ref-for-dom-fontface-load④">load()</a></code> method. 
      <li> Resolve <var>promise</var> with the result of
					waiting for all of the <code class="idl"><a data-link-type="idl" href="#dom-fontface-fontstatuspromise-slot" id="ref-for-dom-fontface-fontstatuspromise-slot⑨">[[FontStatusPromise]]</a></code>s of each font face in the <var>font face list</var>, in order. 
     </ol>
   </ol>
   <h3 class="heading settled" data-level="3.3" id="font-face-set-check"><span class="secno">3.3. </span><span class="content"> The <code>check()</code> method</span><a class="self-link" href="#font-face-set-check"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-check" id="ref-for-dom-fontfaceset-check①">check()</a></code> method of <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④⑥">FontFaceSet</a></code> will determine whether you can "safely"
	render some provided text with a particular font list,
	such that it won’t cause a "font swap" later.
	If the given text/font combo will render without attempting to use any unloaded or currently-loading fonts,
	this method will return true;
	otherwise, it returns false.</p>
   <div class="note" role="note">
     Two special cases in this method’s behavior should be noted,
		as they are non-obvious: 
    <ul>
     <li data-md>
      <p>If the specified fonts exist,
but all possible faces are ruled out due to their unicode-range not covering the provided text,
the method returns <code>true</code>,
as the text will be rendered in the UA’s fallback font instead,
and won’t trigger any font loads.</p>
     <li data-md>
      <p>If none of the specified fonts exist,
even though this is technically similar to the previous case
(in that text rendered with that font list would just use the UA fallback font),
the method instead throws an error.
This is because such a situation is almost certainly either a typo,
or the result of changing the name of a downloadable font
and forgetting to update all places the old name was used,
and an error is more useful than a vacuous <code>true</code>.</p>
    </ul>
   </div>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet" data-dfn-type="method" data-export data-lt="check(font, text)|check(font)" id="dom-fontfaceset-check"><code>check</code></dfn>( <span><dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet/check(font, text)" data-dfn-type="argument" data-export id="dom-fontfaceset-check-font-text-font"><code>font</code></dfn>, <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSet/check(font, text)" data-dfn-type="argument" data-export id="dom-fontfaceset-check-font-text-text"><code>text</code></dfn>)</span> method is called,
	execute these steps:</p>
   <ol>
    <li> Let <var>font face set</var> be the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④⑦">FontFaceSet</a></code> object this method was called on. 
    <li> <a data-link-type="dfn" href="#find-the-matching-font-faces" id="ref-for-find-the-matching-font-faces①">Find the matching font faces</a> from <var>font face set</var> using the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/css-font-loading-3/#dom-fontfacesetcheck-font" id="ref-for-dom-fontfacesetcheck-font">font</a></code> and <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/css-font-loading-3/#dom-fontfacesetcheck-text" id="ref-for-dom-fontfacesetcheck-text">text</a></code> arguments passed to the function,
			and including system fonts,
			and let <var>font face list</var> be the returned list of font faces,
			and <var>found faces</var> be the returned <var>found faces</var> flag.
			If a syntax error was returned,
			throw a SyntaxError exception
			and terminate these steps. 
    <li> If <var>found faces</var> is false,
			throw an XXX error
			and abort this algorithm. 
    <li> If <var>font face list</var> is empty,
			or all fonts in the <var>font face list</var> either have a <code class="idl"><a data-link-type="idl" href="#dom-fontface-status" id="ref-for-dom-fontface-status①②">status</a></code> attribute of "loaded" or are system fonts,
			return <code>true</code>.
			Otherwise, return <code>false</code>. 
   </ol>
   <h3 class="heading settled" data-level="3.4" id="font-face-set-ready"><span class="secno">3.4. </span><span class="content"> The <code>ready</code> attribute</span><a class="self-link" href="#font-face-set-ready"></a></h3>
   <p>Because the number of fonts loaded depends on the how many fonts are used for a given piece of text,
	in some cases whether fonts need to be loaded or not may not be known.
	The <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-ready" id="ref-for-dom-fontfaceset-ready①">ready</a></code> attribute contains a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-promise" id="ref-for-idl-promise④">Promise</a></code> which is resolved when the document is done loading fonts,
	which provides a way for authors to avoid having to keep track of which fonts have or haven’t been loaded
	before examining content which may be affected by loading fonts.</p>
   <p class="note" role="note"><span>Note:</span> Authors should note that a given <var>ready promise</var> is only fulfilled once,
	but further fonts may be loaded after it fulfills.
	This is similar to listening for a <code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingdone" id="ref-for-eventdef-fontfaceset-loadingdone②">loadingdone</a></code> event to fire,
	but the callbacks passed to the <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-ready" id="ref-for-dom-fontfaceset-ready②">ready</a></code> promise will <strong>always</strong> get called,
	even when no font loads occur because the fonts in question are already loaded.
	It’s a simple, easy way to synchronize code to font loads
	without the need to keep track of what fonts are needed and precisely when they load.</p>
   <p class="note" role="note"><span>Note:</span> Note that the user agent may need to iterate over multiple font loads before the <var>ready promise</var> is fulfilled.
	This can occur with font fallback situations,
	where one font in the fontlist is loaded
	but doesn’t contain a particular glyph
	and other fonts in the fontlist need to be loaded.
	The <var>ready promise</var> is only fulfilled after layout operations complete
	and no additional font loads are necessary.</p>
   <p class="note" role="note"><span>Note:</span> Note that the Promise returned by this <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-ready" id="ref-for-dom-fontfaceset-ready③">ready</a></code> attribute is only ever fulfilled,
	never rejected,
	unlike the Promise returned by the <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface③⑨">FontFace</a></code> <code class="idl"><a data-link-type="idl" href="#dom-fontface-load" id="ref-for-dom-fontface-load⑤">load()</a></code> method.</p>
   <h3 class="heading settled" data-level="3.5" id="font-face-set-css"><span class="secno">3.5. </span><span class="content"> Interaction with CSS Font Loading and Matching</span><a class="self-link" href="#font-face-set-css"></a></h3>
   <p>When the font matching algorithm in <a data-link-type="biblio" href="#biblio-css-fonts-3">[CSS-FONTS-3]</a> is run automatically by the user-agent,
	the set of font faces it matches over must be precisely the set of fonts in the <a data-link-type="dfn" href="#font-source" id="ref-for-font-source③">font source</a> for the document,
	plus any local font faces.</p>
   <p>When a user-agent needs to load a font face,
	it must do so by calling the <code class="idl"><a data-link-type="idl" href="#dom-fontface-load" id="ref-for-dom-fontface-load⑥">load()</a></code> method
	of the corresponding <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④⓪">FontFace</a></code> object.</p>
   <p>(This means it must run the same algorithm,
	not literally call the value currently stored in the <code>load</code> property of the object.)</p>
   <div class="example" id="example-00e0f107">
    <a class="self-link" href="#example-00e0f107"></a> Fonts are available when they are added to a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④⑧">FontFaceSet</a></code>.
		Adding a new <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②②">@font-face</a> rule to a stylesheet
		also adds a new <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④①">FontFace</a></code> to the <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset④⑨">FontFaceSet</a></code> of the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document">Document</a></code> object. 
    <p>Adding a new <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②③">@font-face</a> rule:</p>
<pre class="highlight">document<c- p>.</c->styleSheets<c- p>[</c-><c- mi>0</c-><c- p>].</c->insertRule<c- p>(</c->
  <c- u>"@font-face { font-family: newfont; src: url(newfont.woff); }"</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
document<c- p>.</c->body<c- p>.</c->style<c- p>.</c->fontFamily <c- o>=</c-> <c- u>"newfont, serif"</c-><c- p>;</c->
</pre>
    <p>Constructing a new <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④②">FontFace</a></code> object and adding it to <code class="highlight">document<c- p>.</c->fonts</code>:</p>
<pre class="highlight"><c- a>var</c-> f <c- o>=</c-> <c- k>new</c-> FontFace<c- p>(</c-><c- u>"newfont"</c-><c- p>,</c-> <c- u>"url(newfont.woff)"</c-><c- p>);</c->
document<c- p>.</c->fonts<c- p>.</c->add<c- p>(</c->f<c- p>);</c->
document<c- p>.</c->body<c- p>.</c->style<c- p>.</c->fontFamily <c- o>=</c-> <c- u>"newfont, serif"</c-><c- p>;</c->
</pre>
    <p>In both cases, the loading of the font resource “newfont.woff” will be initiated by the layout engine,
		just as other <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②④">@font-face</a> rule fonts are loaded.</p>
    <p>Omitting the addition to <code class="highlight">document<c- p>.</c->fonts</code> means the font would never be loaded
		and text would be displayed in the default serif font:</p>
<pre class="highlight"><c- a>var</c-> f <c- o>=</c-> <c- k>new</c-> FontFace<c- p>(</c-><c- u>"newfont"</c-><c- p>,</c-> <c- u>"url(newtest.woff)"</c-><c- p>,</c-> <c- p>{});</c->

<c- d>/* new {{FontFace}} not added to {{FontFaceSet}},</c->
<c- d>   so the 'font-family' property can’t see it,</c->
<c- d>   and serif will be used instead */</c->
document<c- p>.</c->body<c- p>.</c->style<c- p>.</c->fontFamily <c- o>=</c-> <c- u>"newfont, serif"</c-><c- p>;</c->
</pre>
    <p>To explicitly preload a font before using it,
		authors can defer the addition of a new <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④③">FontFace</a></code> to a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑤⓪">FontFaceSet</a></code> until the load has completed:</p>
<pre class="highlight"><c- a>var</c-> f <c- o>=</c-> <c- k>new</c-> FontFace<c- p>(</c-><c- u>"newfont"</c-><c- p>,</c-> <c- u>"url(newfont.woff)"</c-><c- p>,</c-> <c- p>{});</c->
f<c- p>.</c->load<c- p>().</c->then<c- p>(</c-><c- a>function</c-> <c- p>(</c->loadedFace<c- p>)</c-> <c- p>{</c->
  document<c- p>.</c->fonts<c- p>.</c->add<c- p>(</c->loadedFace<c- p>);</c->
  document<c- p>.</c->body<c- p>.</c->style<c- p>.</c->fontFamily <c- o>=</c-> <c- u>"newfont, serif"</c-><c- p>;</c->
<c- p>});</c->
</pre>
    <p>In this case, the font resource “newfont.woff” is first downloaded.
		Once the download completes,
		the font is added to the document’s <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑤①">FontFaceSet</a></code>,
		the body font is changed,
		and the layout engine uses the new font resource.</p>
   </div>
   <h2 class="heading settled" data-level="4" id="font-face-source"><span class="secno">4. </span><span class="content"> The <code>FontFaceSource</code> mixin</span><a class="self-link" href="#font-face-source"></a></h2>
<pre class="idl highlight def"><c- b>interface</c-> <c- b>mixin</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="fontfacesource"><code><c- g>FontFaceSource</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#fontfaceset" id="ref-for-fontfaceset⑤②"><c- n>FontFaceSet</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="FontFaceSource" data-dfn-type="attribute" data-export data-readonly data-type="FontFaceSet" id="dom-fontfacesource-fonts"><code><c- g>fonts</c-></code></dfn>;
};

<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①"><c- n>Document</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#fontfacesource" id="ref-for-fontfacesource"><c- n>FontFaceSource</c-></a>;
<a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope" id="ref-for-workerglobalscope"><c- n>WorkerGlobalScope</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#fontfacesource" id="ref-for-fontfacesource①"><c- n>FontFaceSource</c-></a>;
</pre>
   <p>Any document, workers, or other context which can use fonts in some manner must include the <code class="idl"><a data-link-type="idl" href="#fontfacesource" id="ref-for-fontfacesource②">FontFaceSource</a></code> mixin.
	The value of the context’s <code class="idl"><a data-link-type="idl" href="#dom-fontfacesource-fonts" id="ref-for-dom-fontfacesource-fonts">fonts</a></code> attribute is its <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="font-source">font source</dfn>,
	which provides all of the fonts used in font-related operations,
	unless defined otherwise.
	Operations referring to “the font source” must be interpreted as referring to the <a data-link-type="dfn" href="#font-source" id="ref-for-font-source④">font source</a> of the relevant context in which the operation is taking place.</p>
   <p>For any font-related operation that takes place within one of these contexts,
	the <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④④">FontFace</a></code> objects within the <a data-link-type="dfn" href="#font-source" id="ref-for-font-source⑤">font source</a> are its <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="available-font-faces">available font faces</dfn>.</p>
   <h3 class="heading settled" data-level="4.1" id="fontfacesource-workers"><span class="secno">4.1. </span><span class="content"> Worker FontFaceSources</span><a class="self-link" href="#fontfacesource-workers"></a></h3>
   <p>Within a Worker document, the <a data-link-type="dfn" href="#font-source" id="ref-for-font-source⑥">font source</a> is initially empty.</p>
   <p class="note" role="note"><span>Note:</span> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④⑤">FontFace</a></code> objects can be constructed and added to it as normal,
	which affects CSS font-matching within the worker
	(such as, for example, drawing text into a <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/canvas.html#offscreencanvas" id="ref-for-offscreencanvas">OffscreenCanvas</a></code>).</p>
   <h3 class="heading settled" data-level="4.2" id="document-font-face-set"><span class="secno">4.2. </span><span class="content"> Interaction with CSS’s <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②⑤">@font-face</a> Rule</span><a class="self-link" href="#document-font-face-set"></a></h3>
   <p>The <a data-link-type="dfn" href="#fontfaceset-set-entries" id="ref-for-fontfaceset-set-entries⑤">set entries</a> for a document’s <a data-link-type="dfn" href="#font-source" id="ref-for-font-source⑦">font source</a> must be initially populated with all the <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected⑧">CSS-connected</a> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④⑥">FontFace</a></code> objects
	from all of the CSS <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②⑥">@font-face</a> rules in the document’s stylesheets,
	in document order.
	As <span class="css" id="ref-for-at-font-face-rule②⑦">@font-face</span> rules are added or removed from a stylesheet,
	or stylesheets containing <span class="css" id="ref-for-at-font-face-rule②⑧">@font-face</span> rules are added or removed,
	the corresponding <span id="ref-for-css-connected⑨">CSS-connected</span> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④⑦">FontFace</a></code> objects
	must be added or removed from the document’s <span id="ref-for-font-source⑧">font source</span>,
	and maintain this ordering.</p>
   <p>Any manually-added <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④⑧">FontFace</a></code> objects must be ordered <em>after</em> the <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected①⓪">CSS-connected</a> ones.</p>
   <p>When a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑤③">FontFaceSet</a></code> object’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-add" id="ref-for-dom-fontfaceset-add②">add()</a></code> method is called with a <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected①①">CSS-connected</a> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface④⑨">FontFace</a></code> object,
	if the object is already in the set,
	the operation must be a no-op;
	otherwise, the operation must do nothing,
	and throw an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#invalidmodificationerror" id="ref-for-invalidmodificationerror①">InvalidModificationError</a></code>.</p>
   <p>When a <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑤④">FontFaceSet</a></code> object’s <code class="idl"><a data-link-type="idl" href="#dom-fontfaceset-delete" id="ref-for-dom-fontfaceset-delete②">delete()</a></code> method is called with a <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected①②">CSS-connected</a> <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑤⓪">FontFace</a></code> object,
	the operation must be a no-op,
	and return <code class="lang-javascript highlight"><c- kc>false</c-></code>.</p>
   <p class="note" role="note"><span>Note:</span> Authors can still maintain references to a removed <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑤①">FontFace</a></code>,
	even if it’s been automatically removed from a <a data-link-type="dfn" href="#font-source" id="ref-for-font-source⑨">font source</a>.
	As specified in <a href="#font-face-css-connection">§ 2.3 Interaction with CSS’s @font-face Rule</a>, though,
	the <code class="idl"><a data-link-type="idl" href="#fontface" id="ref-for-fontface⑤②">FontFace</a></code> is no longer <a data-link-type="dfn" href="#css-connected" id="ref-for-css-connected①③">CSS-connected</a> at that point.</p>
   <p class="note" role="note"><span>Note:</span> It is expected that a future version of this specification
	will define ways of interacting with and querying local fonts as well.</p>
   <h2 class="heading settled" data-level="5" id="font-load-event-examples"><span class="secno">5. </span><span class="content"> API Examples</span><a class="self-link" href="#font-load-event-examples"></a></h2>
   <div class="example" id="example-c4045522">
    <a class="self-link" href="#example-c4045522"></a> To show content only after all font loads complete: 
<pre class="highlight">document<c- p>.</c->fonts<c- p>.</c->ready<c- p>.</c->then<c- p>(</c-><c- a>function</c-><c- p>()</c-> <c- p>{</c->
  <c- a>var</c-> content <c- o>=</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- u>"content"</c-><c- p>);</c->
  content<c- p>.</c->style<c- p>.</c->visibility <c- o>=</c-> <c- u>"visible"</c-><c- p>;</c->
<c- p>});</c->
</pre>
   </div>
   <div class="example" id="example-95b58c34">
    <a class="self-link" href="#example-95b58c34"></a> Drawing text in a canvas with a downloadable font, explicitly
		initiating the font download and drawing upon completion: 
<pre class="highlight"><c- a>function</c-> drawStuff<c- p>()</c-> <c- p>{</c->
  <c- a>var</c-> ctx <c- o>=</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- u>"c"</c-><c- p>).</c->getContext<c- p>(</c-><c- u>"2d"</c-><c- p>);</c->

  ctx<c- p>.</c->fillStyle <c- o>=</c-> <c- u>"red"</c-><c- p>;</c->
  ctx<c- p>.</c->font <c- o>=</c-> <c- u>"50px MyDownloadableFont"</c-><c- p>;</c->
  ctx<c- p>.</c->fillText<c- p>(</c-><c- u>"Hello!"</c-><c- p>,</c-> <c- mi>100</c-><c- p>,</c-> <c- mi>100</c-><c- p>);</c->
<c- p>}</c->

document<c- p>.</c->fonts<c- p>.</c->load<c- p>(</c-><c- u>"50px MyDownloadableFont"</c-><c- p>)</c->
              <c- p>.</c->then<c- p>(</c->drawStuff<c- p>,</c-> handleError<c- p>);</c->
</pre>
   </div>
   <div class="example" id="example-8e44fe29">
    <a class="self-link" href="#example-8e44fe29"></a> A rich text editing application may need to measure text elements
		after editing operations have taken place.  Since style changes may
		or may not require additional fonts to be downloaded, or the fonts
		may already have been downloaded, the measurement procedures need to
		occur after those font loads complete: 
<pre class="highlight"><c- a>function</c-> measureTextElements<c- p>()</c-> <c- p>{</c->
  <c- c1>// contents can now be measured using the metrics of</c->
  <c- c1>// the downloadable font(s)</c->
<c- p>}</c->

<c- a>function</c-> doEditing<c- p>()</c-> <c- p>{</c->
  <c- c1>// content/layout operations that may cause additional font loads</c->
  document<c- p>.</c->fonts<c- p>.</c->ready<c- p>.</c->then<c- p>(</c->measureTextElements<c- p>);</c->
<c- p>}</c->
</pre>
   </div>
   <div class="example" id="example-268ae257">
    <a class="self-link" href="#example-268ae257"></a> The <code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingdone" id="ref-for-eventdef-fontfaceset-loadingdone③">loadingdone</a></code> event only fires after all font related loads have completed <strong>and</strong> text has been laid out without causing additional font loads: 
<pre class="highlight"><c- p>&lt;</c-><c- f>style</c-><c- p>></c->
<c- p>@</c-><c- k>font-face</c-> <c- p>{</c->
  <c- f>font-family</c-><c- o>:</c-> <c- f>latin-serif</c-><c- o>;</c->
  <c- f>src</c-><c- o>:</c-> <c- f>url</c-><c- o>(</c-><c- f>latinserif</c-><c- p>.</c-><c- nc>woff</c-><c- o>)</c-> <c- f>format</c-><c- o>(</c-><c- u>"woff"</c-><c- o>);</c-> <c- c>/* contains no kanji/kana */</c->
<c- p>}</c->
<c- p>@</c-><c- k>font-face</c-> <c- p>{</c->
  <c- f>font-family</c-><c- o>:</c-> <c- f>jpn-mincho</c-><c- o>;</c->
  <c- f>src</c-><c- o>:</c-> <c- f>url</c-><c- o>(</c-><c- f>mincho</c-><c- p>.</c-><c- nc>woff</c-><c- o>)</c-> <c- f>format</c-><c- o>(</c-><c- u>"woff"</c-><c- o>);</c->
<c- p>}</c->
<c- p>@</c-><c- k>font-face</c-> <c- p>{</c->
  <c- f>font-family</c-><c- o>:</c-> <c- f>unused</c-><c- o>;</c->
  <c- f>src</c-><c- o>:</c-> <c- f>url</c-><c- o>(</c-><c- f>unused</c-><c- p>.</c-><c- nc>woff</c-><c- o>);</c->
<c- p>}</c->

<c- f>body</c-> <c- p>{</c-> <c- k>font-family</c-><c- p>:</c-> <c- n>latin-serif</c-><c- p>,</c-> <c- n>jpn-mincho</c-><c- p>;</c-> <c- p>}</c->
<c- p>&lt;/</c-><c- f>style</c-><c- p>></c->
<c- p>&lt;</c-><c- f>p</c-><c- p>></c->納豆はいかがでしょうか
</pre>
    <p>In this situation, the user agent first downloads “latinserif.woff”
		and then tries to use this to draw the Japanese text.
		But because no Japanese glyphs are present in that font,
		fallback occurs and the font “mincho.woff” is downloaded.
		Only after the second font is downloaded and the Japanese text laid out does the <code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingdone" id="ref-for-eventdef-fontfaceset-loadingdone④">loadingdone</a></code> event fire.</p>
    <p>The "unused" font isn’t loaded,
		but no text is using it,
		so the UA isn’t even <em>trying</em> to load it.
		It doesn’t interfere with the <code class="idl"><a data-link-type="idl" href="#eventdef-fontfaceset-loadingdone" id="ref-for-eventdef-fontfaceset-loadingdone⑤">loadingdone</a></code> event.</p>
   </div>
   <h2 class="no-num heading settled" id="changes"><span class="content">Changes</span><a class="self-link" href="#changes"></a></h2>
   <p>Changes from the <a href="https://www.w3.org/TR/2014/WD-css-font-loading-3-20140522/">May 2014 CSS Font Loading Last Call Working Draft</a>:</p>
   <ol>
    <li data-md>
     <p>Corrected the async algorithms to use "queue a task" language,
to ensure that side-effect timing is well-defined.</p>
    <li data-md>
     <p>Switched <code class="idl"><a data-link-type="idl" href="#dom-fontfacesetloadevent-fontfaces" id="ref-for-dom-fontfacesetloadevent-fontfaces①">fontfaces</a></code> to be a FrozenArray,
to match with proper IDL practice.</p>
    <li data-md>
     <p>Added <code class="idl"><a data-link-type="idl" href="#dom-fontface-variationsettings" id="ref-for-dom-fontface-variationsettings①">variationSettings</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-fontface-display" id="ref-for-dom-fontface-display①">display</a></code>, to sync with <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule②⑨">@font-face</a>.</p>
   </ol>
   <h2 class="no-num heading settled" id="acknowledgments"><span class="content"> Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>Several members of the Google Fonts team provided helpful feedback on font load events,
	as did Boris Zbarsky, Jonas Sicking and ms2ger.</p>
   <h2 class="no-num heading settled" id="priv-sec"><span class="content"> Privacy &amp; Security Considerations</span><a class="self-link" href="#priv-sec"></a></h2>
   <p>The <code class="idl"><a data-link-type="idl" href="#fontfaceset" id="ref-for-fontfaceset⑤⑤">FontFaceSet</a></code> object leaks information about the user’s installed fonts,
	but in the exact same way as the existing <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule" id="ref-for-at-font-face-rule③⓪">@font-face</a> rule;
	no new information is leaked,
	or in any appreciable easier manner.</p>
   <p>This specification introduces no new security considerations.</p>
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="FontFaceSet-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/fonts" title="The fonts property of the Document interface returns the FontFaceSet interface of the document.">Document/fonts</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>60+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>47+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>10+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>60+</span></span><span class="webview_android yes"><span>Android WebView</span><span>60+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>44+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSet" title="The FontFaceSet interface of the CSS Font Loading API manages the loading of font-faces and querying of their download status.">FontFaceSet</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>10+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="font-face-constructor">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/FontFace" title="The FontFace() constructor creates a new FontFace object.">FontFace/FontFace</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>22+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>10+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>22+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-family">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/display" title="The display property of the FontFace interface determines how a font face is displayed based on whether and when it is downloaded and ready to use. This property is equivalent to the CSS font-display descriptor.">FontFace/display</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>58+</span></span><span class="safari yes"><span>Safari</span><span>11+</span></span><span class="chrome yes"><span>Chrome</span><span>60+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>47+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>60+</span></span><span class="webview_android yes"><span>Android WebView</span><span>60+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>44+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/family" title="The FontFace.family property allows the author to get or set the font family of a FontFace object. This is equivalent to the font-family descriptor of @font-face.">FontFace/family</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-featuresettings">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/featureSettings" title="The featureSettings property of the FontFace interface retrieves or sets infrequently used font features that are not available from a font&apos;s variant properties. It is equivalent to the font-feature-settings descriptor.">FontFace/featureSettings</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="font-face-load">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/load" title="The load() method of the FontFace interface loads a font based on current object&apos;s constructor-passed requirements, including a location or source buffer, and returns a Promise that resolves with the current FontFace object.">FontFace/load</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-loaded">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/loaded" title="The loaded read-only property of the FontFace interface returns a Promise that resolves with the current FontFace object when the font specified in the object&apos;s constructor is done loading or rejects with a SyntaxError.">FontFace/loaded</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-status">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/status" title="The status read-only property of the FontFace interface returns an enumerated value indicating the status of the font, one of &quot;unloaded&quot;, &quot;loading&quot;, &quot;loaded&quot;, or &quot;error&quot;.">FontFace/status</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-stretch">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/stretch" title="The stretch property of the FontFace interface retrieves or sets how the font stretches. It is equivalent to the font-stretch descriptor.">FontFace/stretch</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-style">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/style" title="The style property of the FontFace interface retrieves or sets the font&apos;s style. It is equivalent to the font-style descriptor.">FontFace/style</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-unicoderange">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/unicodeRange" title="The unicodeRange property of the FontFace interface retrieves or sets the range of unicode codepoints encompassing the font. It is equivalent to the unicode-range descriptor.">FontFace/unicodeRange</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-variant">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/variant" title="The variant property of the FontFace interface programatically retrieves or sets font variant values. It is equivalent to the font-variant descriptor.">FontFace/variant</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontface-weight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace/weight" title="The weight property of the FontFace interface retrieves or sets the weight of the font. It is equivalent to the font-weight descriptor.">FontFace/weight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="fontface-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFace" title="The FontFace interface represents a single usable font face. It allows control of the source of the font face, being a URL to an external resource, or a buffer; it also allows control of when the font face is loaded and its current status.">FontFace</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>22+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>10+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>22+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="font-face-set-check">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSet/check" title="A Boolean that is true if the font list is available">FontFaceSet/check</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="font-face-set-load">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSet/load" title="A Promise of an Array of FontFace loaded. The promise is fulfilled when all the fonts are loaded; it is rejected if one of the fonts failed to load.">FontFaceSet/load</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>35+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>35+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontfaceset-ready">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSet/ready" title="The ready readonly property of the FontFaceSet interface returns a Promise that resolves to the given FontFaceSet.">FontFaceSet/ready</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>41+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>35+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>35+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontfacesetloadevent-fontfacesetloadevent">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSetLoadEvent/FontFaceSetLoadEvent" title="The FontFaceSetLoadEvent constructor creates a new FontFaceLoadEvent object which is fired whenever a FontFaceSet loads.">FontFaceSetLoadEvent/FontFaceSetLoadEvent</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>?</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>57+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>44+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>?</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>57+</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>7.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>43+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSetLoadEvent" title="The FontFaceSetLoadEvent interface of the the Css Font Loading API is fired whenever a FontFaceSet loads.">FontFaceSetLoadEvent</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>22+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>3.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>22+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-fontfacesetloadevent-fontfaces">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/FontFaceSetLoadEvent/fontfaces" title="The fontfaces read-only property of the FontFaceLoadEventInit interface returns an array of FontFace instances, each of which represents a single usable font.">FontFaceSetLoadEvent/fontfaces</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>35+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>22+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>35+</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>3.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>22+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#dom-fontfaceset-add">add(font)</a><span>, in §3</span>
   <li><a href="#available-font-faces">available font faces</a><span>, in §4</span>
   <li><a href="#typedefdef-binarydata">BinaryData</a><span>, in §2</span>
   <li><a href="#dom-fontfaceset-check">check(font)</a><span>, in §3.3</span>
   <li><a href="#dom-fontfaceset-check">check(font, text)</a><span>, in §3.3</span>
   <li><a href="#dom-fontfaceset-clear">clear()</a><span>, in §3</span>
   <li><a href="#dom-fontface-fontface">constructor(family, source)</a><span>, in §2.1</span>
   <li><a href="#dom-fontface-fontface">constructor(family, source, descriptors)</a><span>, in §2.1</span>
   <li><a href="#dom-fontfaceset-fontfaceset">constructor(initialFaces)</a><span>, in §3</span>
   <li><a href="#dom-fontfacesetloadevent-fontfacesetloadevent">constructor(type)</a><span>, in §3</span>
   <li><a href="#dom-fontfacesetloadevent-fontfacesetloadevent">constructor(type, eventInitDict)</a><span>, in §3</span>
   <li><a href="#css-connected">CSS-connected</a><span>, in §2.3</span>
   <li><a href="#dom-fontface-data-slot">[[Data]]</a><span>, in §2</span>
   <li><a href="#dom-fontfaceset-delete">delete(font)</a><span>, in §3</span>
   <li>
    display
    <ul>
     <li><a href="#dom-fontface-display">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-display">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li><a href="#dom-fontfaceloadstatus-error">"error"</a><span>, in §2</span>
   <li><a href="#dom-fontfaceset-failedfonts-slot">[[FailedFonts]]</a><span>, in §3</span>
   <li><a href="#dom-fontface-family">family</a><span>, in §2</span>
   <li>
    featureSettings
    <ul>
     <li><a href="#dom-fontface-featuresettings">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-featuresettings">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li><a href="#find-the-matching-font-faces">find the matching font faces</a><span>, in §3.1</span>
   <li><a href="#fire-a-font-load-event">fire a font load event</a><span>, in §3.1</span>
   <li><a href="#fontface">FontFace</a><span>, in §2</span>
   <li><a href="#dictdef-fontfacedescriptors">FontFaceDescriptors</a><span>, in §2</span>
   <li><a href="#dom-fontface-fontface">FontFace(family, source)</a><span>, in §2.1</span>
   <li><a href="#dom-fontface-fontface">FontFace(family, source, descriptors)</a><span>, in §2.1</span>
   <li><a href="#enumdef-fontfaceloadstatus">FontFaceLoadStatus</a><span>, in §2</span>
   <li>
    fontfaces
    <ul>
     <li><a href="#dom-fontfacesetloadevent-fontfaces">attribute for FontFaceSetLoadEvent</a><span>, in §3</span>
     <li><a href="#dom-fontfacesetloadeventinit-fontfaces">dict-member for FontFaceSetLoadEventInit</a><span>, in §3</span>
    </ul>
   <li><a href="#fontfaceset">FontFaceSet</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-fontfaceset">FontFaceSet(initialFaces)</a><span>, in §3</span>
   <li><a href="#fontfacesetloadevent">FontFaceSetLoadEvent</a><span>, in §3</span>
   <li><a href="#dictdef-fontfacesetloadeventinit">FontFaceSetLoadEventInit</a><span>, in §3</span>
   <li><a href="#dom-fontfacesetloadevent-fontfacesetloadevent">FontFaceSetLoadEvent(type)</a><span>, in §3</span>
   <li><a href="#dom-fontfacesetloadevent-fontfacesetloadevent">FontFaceSetLoadEvent(type, eventInitDict)</a><span>, in §3</span>
   <li><a href="#enumdef-fontfacesetloadstatus">FontFaceSetLoadStatus</a><span>, in §3</span>
   <li><a href="#fontfacesource">FontFaceSource</a><span>, in §4</span>
   <li><a href="#dom-fontfacesource-fonts">fonts</a><span>, in §4</span>
   <li><a href="#font-source">font source</a><span>, in §4</span>
   <li><a href="#dom-fontface-fontstatuspromise-slot">[[FontStatusPromise]]</a><span>, in §2</span>
   <li><a href="#callbackdef-foreachcallback">ForEachCallback</a><span>, in §3</span>
   <li><a href="#fontfaceset-iteration-order">iteration order</a><span>, in §3</span>
   <li><a href="#dom-fontface-load">load()</a><span>, in §2.2</span>
   <li>
    "loaded"
    <ul>
     <li><a href="#dom-fontfaceloadstatus-loaded">enum-value for FontFaceLoadStatus</a><span>, in §2</span>
     <li><a href="#dom-fontfacesetloadstatus-loaded">enum-value for FontFaceSetLoadStatus</a><span>, in §3</span>
    </ul>
   <li><a href="#dom-fontface-loaded">loaded</a><span>, in §2</span>
   <li><a href="#dom-fontfaceset-loadedfonts-slot">[[LoadedFonts]]</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-load">load(font)</a><span>, in §3.2</span>
   <li><a href="#dom-fontfaceset-load">load(font, text)</a><span>, in §3.2</span>
   <li>
    "loading"
    <ul>
     <li><a href="#dom-fontfaceloadstatus-loading">enum-value for FontFaceLoadStatus</a><span>, in §2</span>
     <li><a href="#dom-fontfacesetloadstatus-loading">enum-value for FontFaceSetLoadStatus</a><span>, in §3</span>
    </ul>
   <li><a href="#eventdef-fontfaceset-loading">loading</a><span>, in §3.1</span>
   <li><a href="#eventdef-fontfaceset-loadingdone">loadingdone</a><span>, in §3.1</span>
   <li><a href="#eventdef-fontfaceset-loadingerror">loadingerror</a><span>, in §3.1</span>
   <li><a href="#dom-fontfaceset-loadingfonts-slot">[[LoadingFonts]]</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-onloading">onloading</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-onloadingdone">onloadingdone</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-onloadingerror">onloadingerror</a><span>, in §3</span>
   <li><a href="#fontfaceset-pending-on-the-environment">pending on the environment</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-ready">ready</a><span>, in §3</span>
   <li><a href="#dom-fontfaceset-readypromise-slot">[[ReadyPromise]]</a><span>, in §3</span>
   <li><a href="#fontfaceset-set-entries">set entries</a><span>, in §3</span>
   <li>
    status
    <ul>
     <li><a href="#dom-fontface-status">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfaceset-status">attribute for FontFaceSet</a><span>, in §3</span>
    </ul>
   <li>
    stretch
    <ul>
     <li><a href="#dom-fontface-stretch">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-stretch">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li><a href="#fontfaceset-stuck-on-the-environment">stuck on the environment</a><span>, in §3.1</span>
   <li>
    style
    <ul>
     <li><a href="#dom-fontface-style">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-style">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li><a href="#switch-the-fontfaceset-to-loaded">switch the FontFaceSet to loaded</a><span>, in §3.1</span>
   <li><a href="#switch-the-fontfaceset-to-loading">switch the FontFaceSet to loading</a><span>, in §3.1</span>
   <li>
    unicodeRange
    <ul>
     <li><a href="#dom-fontface-unicoderange">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-unicoderange">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li><a href="#dom-fontfaceloadstatus-unloaded">"unloaded"</a><span>, in §2</span>
   <li><a href="#dom-fontface-urls-slot">[[Urls]]</a><span>, in §2</span>
   <li>
    variant
    <ul>
     <li><a href="#dom-fontface-variant">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-variant">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li>
    variationSettings
    <ul>
     <li><a href="#dom-fontface-variationsettings">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-variationsettings">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
   <li>
    weight
    <ul>
     <li><a href="#dom-fontface-weight">attribute for FontFace</a><span>, in §2</span>
     <li><a href="#dom-fontfacedescriptors-weight">dict-member for FontFaceDescriptors</a><span>, in §2</span>
    </ul>
  </ul>
  <aside class="dfn-panel" data-for="term-for-propdef-font">
   <a href="https://drafts.csswg.org/css-fonts-3/#propdef-font">https://drafts.csswg.org/css-fonts-3/#propdef-font</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-font">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-src">
   <a href="https://drafts.csswg.org/css-fonts-3/#descdef-src">https://drafts.csswg.org/css-fonts-3/#descdef-src</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-src">2.2. 
The load() method</a>
    <li><a href="#ref-for-descdef-src①">2.3. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-descdef-src②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-font-face-rule">
   <a href="https://drafts.csswg.org/css-fonts-4/#at-font-face-rule">https://drafts.csswg.org/css-fonts-4/#at-font-face-rule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-font-face-rule">1. 
Introduction</a>
    <li><a href="#ref-for-at-font-face-rule①">2. 
The FontFace Interface</a> <a href="#ref-for-at-font-face-rule②">(2)</a> <a href="#ref-for-at-font-face-rule③">(3)</a> <a href="#ref-for-at-font-face-rule④">(4)</a> <a href="#ref-for-at-font-face-rule⑤">(5)</a> <a href="#ref-for-at-font-face-rule⑥">(6)</a>
    <li><a href="#ref-for-at-font-face-rule⑦">2.1. 
The Constructor</a> <a href="#ref-for-at-font-face-rule⑧">(2)</a>
    <li><a href="#ref-for-at-font-face-rule⑨">2.2. 
The load() method</a>
    <li><a href="#ref-for-at-font-face-rule①⓪">2.3. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-at-font-face-rule①①">(2)</a> <a href="#ref-for-at-font-face-rule①②">(3)</a> <a href="#ref-for-at-font-face-rule①③">(4)</a> <a href="#ref-for-at-font-face-rule①④">(5)</a> <a href="#ref-for-at-font-face-rule①⑤">(6)</a> <a href="#ref-for-at-font-face-rule①⑥">(7)</a> <a href="#ref-for-at-font-face-rule①⑦">(8)</a> <a href="#ref-for-at-font-face-rule①⑧">(9)</a> <a href="#ref-for-at-font-face-rule①⑨">(10)</a> <a href="#ref-for-at-font-face-rule②⓪">(11)</a>
    <li><a href="#ref-for-at-font-face-rule②①">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-at-font-face-rule②②">3.5. 
Interaction with CSS Font Loading and Matching</a> <a href="#ref-for-at-font-face-rule②③">(2)</a> <a href="#ref-for-at-font-face-rule②④">(3)</a>
    <li><a href="#ref-for-at-font-face-rule②⑤">4.2. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-at-font-face-rule②⑥">(2)</a> <a href="#ref-for-at-font-face-rule②⑦">(3)</a> <a href="#ref-for-at-font-face-rule②⑧">(4)</a>
    <li><a href="#ref-for-at-font-face-rule②⑨">Changes</a>
    <li><a href="#ref-for-at-font-face-rule③⓪"> Privacy &amp; Security Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-font-weight-bolder">
   <a href="https://drafts.csswg.org/css-fonts-4/#valdef-font-weight-bolder">https://drafts.csswg.org/css-fonts-4/#valdef-font-weight-bolder</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-font-weight-bolder">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-font-weight-normal">
   <a href="https://drafts.csswg.org/css-fonts-4/#valdef-font-weight-normal">https://drafts.csswg.org/css-fonts-4/#valdef-font-weight-normal</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-font-weight-normal">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-font-face-unicode-range">
   <a href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-unicode-range">https://drafts.csswg.org/css-fonts-4/#descdef-font-face-unicode-range</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-font-face-unicode-range">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-parse-something-according-to-a-css-grammar">
   <a href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar">https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-parse-something-according-to-a-css-grammar">2. 
The FontFace Interface</a> <a href="#ref-for-css-parse-something-according-to-a-css-grammar①">(2)</a>
    <li><a href="#ref-for-css-parse-something-according-to-a-css-grammar②">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-wide-keywords">
   <a href="https://drafts.csswg.org/css-values-4/#css-wide-keywords">https://drafts.csswg.org/css-values-4/#css-wide-keywords</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-wide-keywords">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-funcdef-url">
   <a href="https://drafts.csswg.org/css-values-4/#funcdef-url">https://drafts.csswg.org/css-values-4/#funcdef-url</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-funcdef-url">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssomstring">
   <a href="https://drafts.csswg.org/cssom-1/#cssomstring">https://drafts.csswg.org/cssom-1/#cssomstring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">2. 
The FontFace Interface</a> <a href="#ref-for-cssomstring①">(2)</a> <a href="#ref-for-cssomstring②">(3)</a> <a href="#ref-for-cssomstring③">(4)</a> <a href="#ref-for-cssomstring④">(5)</a> <a href="#ref-for-cssomstring⑤">(6)</a> <a href="#ref-for-cssomstring⑥">(7)</a> <a href="#ref-for-cssomstring⑦">(8)</a> <a href="#ref-for-cssomstring⑧">(9)</a> <a href="#ref-for-cssomstring⑨">(10)</a> <a href="#ref-for-cssomstring①⓪">(11)</a> <a href="#ref-for-cssomstring①①">(12)</a> <a href="#ref-for-cssomstring①②">(13)</a> <a href="#ref-for-cssomstring①③">(14)</a> <a href="#ref-for-cssomstring①④">(15)</a> <a href="#ref-for-cssomstring①⑤">(16)</a> <a href="#ref-for-cssomstring①⑥">(17)</a> <a href="#ref-for-cssomstring①⑦">(18)</a> <a href="#ref-for-cssomstring①⑧">(19)</a> <a href="#ref-for-cssomstring①⑨">(20)</a> <a href="#ref-for-cssomstring②⓪">(21)</a> <a href="#ref-for-cssomstring②①">(22)</a> <a href="#ref-for-cssomstring②②">(23)</a> <a href="#ref-for-cssomstring②③">(24)</a> <a href="#ref-for-cssomstring②④">(25)</a> <a href="#ref-for-cssomstring②⑤">(26)</a> <a href="#ref-for-cssomstring②⑥">(27)</a> <a href="#ref-for-cssomstring②⑦">(28)</a>
    <li><a href="#ref-for-cssomstring②⑧">2.1. 
The Constructor</a> <a href="#ref-for-cssomstring②⑨">(2)</a>
    <li><a href="#ref-for-cssomstring③⓪">3. 
The FontFaceSet Interface</a> <a href="#ref-for-cssomstring③①">(2)</a> <a href="#ref-for-cssomstring③②">(3)</a> <a href="#ref-for-cssomstring③③">(4)</a> <a href="#ref-for-cssomstring③④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-document">
   <a href="https://dom.spec.whatwg.org/#document">https://dom.spec.whatwg.org/#document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-document">3.5. 
Interaction with CSS Font Loading and Matching</a>
    <li><a href="#ref-for-document①">4. 
The FontFaceSource mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event">
   <a href="https://dom.spec.whatwg.org/#event">https://dom.spec.whatwg.org/#event</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-eventinit">
   <a href="https://dom.spec.whatwg.org/#dictdef-eventinit">https://dom.spec.whatwg.org/#dictdef-eventinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-eventinit">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventtarget">
   <a href="https://dom.spec.whatwg.org/#eventtarget">https://dom.spec.whatwg.org/#eventtarget</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventtarget">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventhandler">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler">https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventhandler">3. 
The FontFaceSet Interface</a> <a href="#ref-for-eventhandler①">(2)</a> <a href="#ref-for-eventhandler②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-offscreencanvas">
   <a href="https://html.spec.whatwg.org/multipage/canvas.html#offscreencanvas">https://html.spec.whatwg.org/multipage/canvas.html#offscreencanvas</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-offscreencanvas">4.1. 
Worker FontFaceSources</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-workerglobalscope">
   <a href="https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope">https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-workerglobalscope">4. 
The FontFaceSource mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-ArrayBuffer">
   <a href="https://heycam.github.io/webidl/#idl-ArrayBuffer">https://heycam.github.io/webidl/#idl-ArrayBuffer</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-ArrayBuffer">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-idl-ArrayBuffer①">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ArrayBufferView">
   <a href="https://heycam.github.io/webidl/#ArrayBufferView">https://heycam.github.io/webidl/#ArrayBufferView</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ArrayBufferView">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-ArrayBufferView①">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-Exposed①">3. 
The FontFaceSet Interface</a> <a href="#ref-for-Exposed②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-invalidmodificationerror">
   <a href="https://heycam.github.io/webidl/#invalidmodificationerror">https://heycam.github.io/webidl/#invalidmodificationerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-invalidmodificationerror">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-invalidmodificationerror①">4.2. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-promise">
   <a href="https://heycam.github.io/webidl/#idl-promise">https://heycam.github.io/webidl/#idl-promise</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-promise">1.1. 
Values</a>
    <li><a href="#ref-for-idl-promise①">2.1. 
The Constructor</a>
    <li><a href="#ref-for-idl-promise②">3. 
The FontFaceSet Interface</a> <a href="#ref-for-idl-promise③">(2)</a>
    <li><a href="#ref-for-idl-promise④">3.4. 
The ready attribute</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-syntaxerror">
   <a href="https://heycam.github.io/webidl/#syntaxerror">https://heycam.github.io/webidl/#syntaxerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-syntaxerror">2. 
The FontFace Interface</a> <a href="#ref-for-syntaxerror①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">3. 
The FontFaceSet Interface</a> <a href="#ref-for-idl-boolean①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-long">
   <a href="https://heycam.github.io/webidl/#idl-long">https://heycam.github.io/webidl/#idl-long</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-long">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-set-entries">
   <a href="https://heycam.github.io/webidl/#dfn-set-entries">https://heycam.github.io/webidl/#dfn-set-entries</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-set-entries">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dfn-set-entries①">(2)</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[CSS-FONTS-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-font" style="color:initial">font</span>
     <li><span class="dfn-paneled" id="term-for-descdef-src" style="color:initial">src</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-fonts-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-at-font-face-rule" style="color:initial">@font-face</span>
     <li><span class="dfn-paneled" id="term-for-valdef-font-weight-bolder" style="color:initial">bolder</span>
     <li><span class="dfn-paneled" id="term-for-valdef-font-weight-normal" style="color:initial">normal</span>
     <li><span class="dfn-paneled" id="term-for-descdef-font-face-unicode-range" style="color:initial">unicode-range</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-syntax-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-css-parse-something-according-to-a-css-grammar" style="color:initial">parse</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-css-wide-keywords" style="color:initial">css-wide keywords</span>
     <li><span class="dfn-paneled" id="term-for-funcdef-url" style="color:initial">url()</span>
    </ul>
   <li>
    <a data-link-type="biblio">[cssom-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssomstring" style="color:initial">CSSOMString</span>
    </ul>
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-document" style="color:initial">Document</span>
     <li><span class="dfn-paneled" id="term-for-event" style="color:initial">Event</span>
     <li><span class="dfn-paneled" id="term-for-dictdef-eventinit" style="color:initial">EventInit</span>
     <li><span class="dfn-paneled" id="term-for-eventtarget" style="color:initial">EventTarget</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-eventhandler" style="color:initial">EventHandler</span>
     <li><span class="dfn-paneled" id="term-for-offscreencanvas" style="color:initial">OffscreenCanvas</span>
     <li><span class="dfn-paneled" id="term-for-workerglobalscope" style="color:initial">WorkerGlobalScope</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-idl-ArrayBuffer" style="color:initial">ArrayBuffer</span>
     <li><span class="dfn-paneled" id="term-for-ArrayBufferView" style="color:initial">ArrayBufferView</span>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-invalidmodificationerror" style="color:initial">InvalidModificationError</span>
     <li><span class="dfn-paneled" id="term-for-idl-promise" style="color:initial">Promise</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-syntaxerror" style="color:initial">SyntaxError</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-idl-long" style="color:initial">long</span>
     <li><span class="dfn-paneled" id="term-for-dfn-set-entries" style="color:initial">set entries</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-fonts-3">[CSS-FONTS-3]
   <dd>John Daggett; Myles Maxfield; Chris Lilley. <a href="https://www.w3.org/TR/css-fonts-3/">CSS Fonts Module Level 3</a>. 20 September 2018. REC. URL: <a href="https://www.w3.org/TR/css-fonts-3/">https://www.w3.org/TR/css-fonts-3/</a>
   <dt id="biblio-css-fonts-4">[CSS-FONTS-4]
   <dd>John Daggett; Myles Maxfield; Chris Lilley. <a href="https://www.w3.org/TR/css-fonts-4/">CSS Fonts Module Level 4</a>. 13 November 2019. WD. URL: <a href="https://www.w3.org/TR/css-fonts-4/">https://www.w3.org/TR/css-fonts-4/</a>
   <dt id="biblio-css-syntax-3">[CSS-SYNTAX-3]
   <dd>Tab Atkins Jr.; Simon Sapin. <a href="https://www.w3.org/TR/css-syntax-3/">CSS Syntax Module Level 3</a>. 16 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-syntax-3/">https://www.w3.org/TR/css-syntax-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-cssom-1">[CSSOM-1]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>typedef</c-> (<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ArrayBuffer"><c- b>ArrayBuffer</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://heycam.github.io/webidl/#ArrayBufferView"><c- n>ArrayBufferView</c-></a>) <a href="#typedefdef-binarydata"><code><c- g>BinaryData</c-></code></a>;

<c- b>dictionary</c-> <a href="#dictdef-fontfacedescriptors"><code><c- g>FontFaceDescriptors</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;normal&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-style"><code><c- g>style</c-></code></a> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;normal&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-weight"><code><c- g>weight</c-></code></a> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;normal&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-stretch"><code><c- g>stretch</c-></code></a> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;U+0-10FFFF&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-unicoderange"><code><c- g>unicodeRange</c-></code></a> = "U+0-10FFFF";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;normal&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-variant"><code><c- g>variant</c-></code></a> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;normal&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-featuresettings"><code><c- g>featureSettings</c-></code></a> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;normal&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-variationsettings"><code><c- g>variationSettings</c-></code></a> = "normal";
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;auto&quot;" data-type="CSSOMString " href="#dom-fontfacedescriptors-display"><code><c- g>display</c-></code></a> = "auto";
};

<c- b>enum</c-> <a href="#enumdef-fontfaceloadstatus"><code><c- g>FontFaceLoadStatus</c-></code></a> { <a href="#dom-fontfaceloadstatus-unloaded"><code><c- s>"unloaded"</c-></code></a>, <a href="#dom-fontfaceloadstatus-loading"><code><c- s>"loading"</c-></code></a>, <a href="#dom-fontfaceloadstatus-loaded"><code><c- s>"loaded"</c-></code></a>, <a href="#dom-fontfaceloadstatus-error"><code><c- s>"error"</c-></code></a> };

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <a href="#fontface"><code><c- g>FontFace</c-></code></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-fontface-fontface"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-fontface-fontface-family-source-descriptors-family"><code><c- g>family</c-></code></a>, (<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="#typedefdef-binarydata"><c- n>BinaryData</c-></a>) <a href="#dom-fontface-fontface-family-source-descriptors-source"><code><c- g>source</c-></code></a>,
                <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-fontfacedescriptors"><c- n>FontFaceDescriptors</c-></a> <a href="#dom-fontface-fontface-family-source-descriptors-descriptors"><code><c- g>descriptors</c-></code></a> = {});
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-family"><c- g>family</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-style"><c- g>style</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-weight"><c- g>weight</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-stretch"><c- g>stretch</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-unicoderange"><c- g>unicodeRange</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-variant"><c- g>variant</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-featuresettings"><c- g>featureSettings</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-variationsettings"><c- g>variationSettings</c-></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-fontface-display"><c- g>display</c-></a>;

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#enumdef-fontfaceloadstatus"><c- n>FontFaceLoadStatus</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="FontFaceLoadStatus" href="#dom-fontface-status"><c- g>status</c-></a>;

  <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-fontface-load"><c- g>load</c-></a>();
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Promise<FontFace>" href="#dom-fontface-loaded"><c- g>loaded</c-></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-fontfacesetloadeventinit"><code><c- g>FontFaceSetLoadEventInit</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit"><c- n>EventInit</c-></a> {
  <c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>> <a data-default="[]" data-type="sequence<FontFace> " href="#dom-fontfacesetloadeventinit-fontfaces"><code><c- g>fontfaces</c-></code></a> = [];
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <a href="#fontfacesetloadevent"><code><c- g>FontFaceSetLoadEvent</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event"><c- n>Event</c-></a> {
  <a href="#dom-fontfacesetloadevent-fontfacesetloadevent"><code><c- g>constructor</c-></code></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-fontfacesetloadevent-fontfacesetloadevent-type-eventinitdict-type"><code><c- g>type</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-fontfacesetloadeventinit"><c- n>FontFaceSetLoadEventInit</c-></a> <a href="#dom-fontfacesetloadevent-fontfacesetloadevent-type-eventinitdict-eventinitdict"><code><c- g>eventInitDict</c-></code></a> = {});
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <c- b>FrozenArray</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>> <a data-readonly data-type="FrozenArray<FontFace>" href="#dom-fontfacesetloadevent-fontfaces"><code><c- g>fontfaces</c-></code></a>;
};

<c- b>enum</c-> <a href="#enumdef-fontfacesetloadstatus"><code><c- g>FontFaceSetLoadStatus</c-></code></a> { <a href="#dom-fontfacesetloadstatus-loading"><code><c- s>"loading"</c-></code></a>, <a href="#dom-fontfacesetloadstatus-loaded"><code><c- s>"loaded"</c-></code></a> };

<c- b>callback</c-> <a href="#callbackdef-foreachcallback"><code><c- g>ForEachCallback</c-></code></a> = <c- b>void</c-> (<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a> <a href="#dom-foreachcallback-font"><code><c- g>font</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-foreachcallback-index"><code><c- g>index</c-></code></a>, <a class="n" data-link-type="idl-name" href="#fontfaceset"><c- n>FontFaceSet</c-></a> <a href="#dom-foreachcallback-self"><code><c- g>self</c-></code></a>);

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <a href="#fontfaceset"><code><c- g>FontFaceSet</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#eventtarget"><c- n>EventTarget</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-fontfaceset-fontfaceset"><c- g>constructor</c-></a>(<c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>> <a href="#dom-fontfaceset-fontfaceset-initialfaces-initialfaces"><code><c- g>initialFaces</c-></code></a>);

  // FontFaceSet is Set-like!
  <c- b>setlike</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>>;
  <a class="n" data-link-type="idl-name" href="#fontfaceset"><c- n>FontFaceSet</c-></a> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-add"><c- g>add</c-></a>(<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a> <a href="#dom-fontfaceset-add-font-font"><code><c- g>font</c-></code></a>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-delete"><c- g>delete</c-></a>(<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a> <a href="#dom-fontfaceset-delete-font-font"><code><c- g>font</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-clear"><c- g>clear</c-></a>();

  // events for when loading state changes
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-fontfaceset-onloading"><code><c- g>onloading</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-fontfaceset-onloadingdone"><code><c- g>onloadingdone</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-fontfaceset-onloadingerror"><code><c- g>onloadingerror</c-></code></a>;

  // check and start loads if appropriate
  // and fulfill promise when all loads complete
  <c- b>Promise</c->&lt;<c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="#fontface"><c- n>FontFace</c-></a>>> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-load"><c- g>load</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-load-font-text-font"><c- g>font</c-></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-load-font-text-text"><c- g>text</c-></a> = " ");

  // return whether all fonts in the fontlist are loaded
  // (does not initiate load if not available)
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="method" href="#dom-fontfaceset-check"><c- g>check</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-check-font-text-font"><c- g>font</c-></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="argument" href="#dom-fontfaceset-check-font-text-text"><c- g>text</c-></a> = " ");

  // async notification that font loading and layout operations are done
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#fontfaceset"><c- n>FontFaceSet</c-></a>> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Promise<FontFaceSet>" href="#dom-fontfaceset-ready"><c- g>ready</c-></a>;

  // loading state, "loading" while one or more fonts loading, "loaded" otherwise
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#enumdef-fontfacesetloadstatus"><c- n>FontFaceSetLoadStatus</c-></a> <a data-readonly data-type="FontFaceSetLoadStatus" href="#dom-fontfaceset-status"><code><c- g>status</c-></code></a>;
};

<c- b>interface</c-> <c- b>mixin</c-> <a href="#fontfacesource"><code><c- g>FontFaceSource</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#fontfaceset"><c- n>FontFaceSet</c-></a> <a data-readonly data-type="FontFaceSet" href="#dom-fontfacesource-fonts"><code><c- g>fonts</c-></code></a>;
};

<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#document"><c- n>Document</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#fontfacesource"><c- n>FontFaceSource</c-></a>;
<a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/workers.html#workerglobalscope"><c- n>WorkerGlobalScope</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#fontfacesource"><c- n>FontFaceSource</c-></a>;

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue"> Several things in this spec use normal ES objects to define behavior,
	such as various things using Promises internally,
	and FontFaceSet using a Set internally.
	I believe the intention here is that these objects
	(and their prototype chains) are pristine,
	unaffected by anything the author has done.
	Is this a good intention?
	If so, how should I indicate this in the spec?<a href="#issue-9cdca628"> ↵ </a></div>
   <div class="issue"> Clarify all mentions of "the document" to be clear about which document is being referenced,
	since objects can move between documents.<a href="#issue-9ae72be4"> ↵ </a></div>
   <div class="issue"> Need to define the base url,
so relative urls can resolve.
Should it be the url of the document?
Is that correct for workers too,
or should they use their worker url?
Is that always defined?<a href="#issue-65bdbf2d"> ↵ </a></div>
   <div class="issue"> When a FontFace is transferred between documents, it’s no longer CSS-connected.<a href="#issue-41199acf"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="typedefdef-binarydata">
   <b><a href="#typedefdef-binarydata">#typedefdef-binarydata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedefdef-binarydata">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-typedefdef-binarydata①">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-fontfacedescriptors">
   <b><a href="#dictdef-fontfacedescriptors">#dictdef-fontfacedescriptors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-fontfacedescriptors">2. 
The FontFace Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-fontfaceloadstatus">
   <b><a href="#enumdef-fontfaceloadstatus">#enumdef-fontfaceloadstatus</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-fontfaceloadstatus">2. 
The FontFace Interface</a> <a href="#ref-for-enumdef-fontfaceloadstatus①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontface">
   <b><a href="#fontface">#fontface</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontface">2. 
The FontFace Interface</a> <a href="#ref-for-fontface①">(2)</a> <a href="#ref-for-fontface②">(3)</a> <a href="#ref-for-fontface③">(4)</a> <a href="#ref-for-fontface④">(5)</a> <a href="#ref-for-fontface⑤">(6)</a> <a href="#ref-for-fontface⑥">(7)</a> <a href="#ref-for-fontface⑦">(8)</a> <a href="#ref-for-fontface⑧">(9)</a>
    <li><a href="#ref-for-fontface⑨">2.1. 
The Constructor</a> <a href="#ref-for-fontface①⓪">(2)</a>
    <li><a href="#ref-for-fontface①①">2.2. 
The load() method</a> <a href="#ref-for-fontface①②">(2)</a> <a href="#ref-for-fontface①③">(3)</a> <a href="#ref-for-fontface①④">(4)</a> <a href="#ref-for-fontface①⑤">(5)</a> <a href="#ref-for-fontface①⑥">(6)</a>
    <li><a href="#ref-for-fontface①⑦">2.3. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-fontface①⑧">(2)</a> <a href="#ref-for-fontface①⑨">(3)</a> <a href="#ref-for-fontface②⓪">(4)</a> <a href="#ref-for-fontface②①">(5)</a> <a href="#ref-for-fontface②②">(6)</a> <a href="#ref-for-fontface②③">(7)</a> <a href="#ref-for-fontface②④">(8)</a> <a href="#ref-for-fontface②⑤">(9)</a> <a href="#ref-for-fontface②⑥">(10)</a> <a href="#ref-for-fontface②⑦">(11)</a>
    <li><a href="#ref-for-fontface②⑧">3. 
The FontFaceSet Interface</a> <a href="#ref-for-fontface②⑨">(2)</a> <a href="#ref-for-fontface③⓪">(3)</a> <a href="#ref-for-fontface③①">(4)</a> <a href="#ref-for-fontface③②">(5)</a> <a href="#ref-for-fontface③③">(6)</a> <a href="#ref-for-fontface③④">(7)</a> <a href="#ref-for-fontface③⑤">(8)</a> <a href="#ref-for-fontface③⑥">(9)</a> <a href="#ref-for-fontface③⑦">(10)</a>
    <li><a href="#ref-for-fontface③⑧">3.1. 
Events</a>
    <li><a href="#ref-for-fontface③⑨">3.4. 
The ready attribute</a>
    <li><a href="#ref-for-fontface④⓪">3.5. 
Interaction with CSS Font Loading and Matching</a> <a href="#ref-for-fontface④①">(2)</a> <a href="#ref-for-fontface④②">(3)</a> <a href="#ref-for-fontface④③">(4)</a>
    <li><a href="#ref-for-fontface④④">4. 
The FontFaceSource mixin</a>
    <li><a href="#ref-for-fontface④⑤">4.1. 
Worker FontFaceSources</a>
    <li><a href="#ref-for-fontface④⑥">4.2. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-fontface④⑦">(2)</a> <a href="#ref-for-fontface④⑧">(3)</a> <a href="#ref-for-fontface④⑨">(4)</a> <a href="#ref-for-fontface⑤⓪">(5)</a> <a href="#ref-for-fontface⑤①">(6)</a> <a href="#ref-for-fontface⑤②">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-fontface-family-source-descriptors-family">
   <b><a href="#dom-fontface-fontface-family-source-descriptors-family">#dom-fontface-fontface-family-source-descriptors-family</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-fontface-family-source-descriptors-family">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-fontface-family-source-descriptors-source">
   <b><a href="#dom-fontface-fontface-family-source-descriptors-source">#dom-fontface-fontface-family-source-descriptors-source</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-fontface-family-source-descriptors-source">2.1. 
The Constructor</a> <a href="#ref-for-dom-fontface-fontface-family-source-descriptors-source①">(2)</a> <a href="#ref-for-dom-fontface-fontface-family-source-descriptors-source②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-fontface-family-source-descriptors-descriptors">
   <b><a href="#dom-fontface-fontface-family-source-descriptors-descriptors">#dom-fontface-fontface-family-source-descriptors-descriptors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-fontface-family-source-descriptors-descriptors">2.1. 
The Constructor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-family">
   <b><a href="#dom-fontface-family">#dom-fontface-family</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-family">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-family①">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-style">
   <b><a href="#dom-fontface-style">#dom-fontface-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-style">2. 
The FontFace Interface</a> <a href="#ref-for-dom-fontface-style①">(2)</a>
    <li><a href="#ref-for-dom-fontface-style②">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-weight">
   <b><a href="#dom-fontface-weight">#dom-fontface-weight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-weight">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-weight①">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-stretch">
   <b><a href="#dom-fontface-stretch">#dom-fontface-stretch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-stretch">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-stretch①">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-unicoderange">
   <b><a href="#dom-fontface-unicoderange">#dom-fontface-unicoderange</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-unicoderange">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-unicoderange①">2.3. 
Interaction with CSS’s @font-face Rule</a>
    <li><a href="#ref-for-dom-fontface-unicoderange②">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-variant">
   <b><a href="#dom-fontface-variant">#dom-fontface-variant</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-variant">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-variant①">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-featuresettings">
   <b><a href="#dom-fontface-featuresettings">#dom-fontface-featuresettings</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-featuresettings">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-featuresettings①">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-variationsettings">
   <b><a href="#dom-fontface-variationsettings">#dom-fontface-variationsettings</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-variationsettings">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-variationsettings①">Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-display">
   <b><a href="#dom-fontface-display">#dom-fontface-display</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-display">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-display①">Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-status">
   <b><a href="#dom-fontface-status">#dom-fontface-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-status">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-status①">2.1. 
The Constructor</a> <a href="#ref-for-dom-fontface-status②">(2)</a> <a href="#ref-for-dom-fontface-status③">(3)</a> <a href="#ref-for-dom-fontface-status④">(4)</a> <a href="#ref-for-dom-fontface-status⑤">(5)</a> <a href="#ref-for-dom-fontface-status⑥">(6)</a>
    <li><a href="#ref-for-dom-fontface-status⑦">2.2. 
The load() method</a> <a href="#ref-for-dom-fontface-status⑧">(2)</a> <a href="#ref-for-dom-fontface-status⑨">(3)</a> <a href="#ref-for-dom-fontface-status①⓪">(4)</a>
    <li><a href="#ref-for-dom-fontface-status①①">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-dom-fontface-status①②">3.3. 
The check() method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-loaded">
   <b><a href="#dom-fontface-loaded">#dom-fontface-loaded</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-loaded">2. 
The FontFace Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-fontstatuspromise-slot">
   <b><a href="#dom-fontface-fontstatuspromise-slot">#dom-fontface-fontstatuspromise-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-fontstatuspromise-slot">2. 
The FontFace Interface</a>
    <li><a href="#ref-for-dom-fontface-fontstatuspromise-slot①">2.1. 
The Constructor</a> <a href="#ref-for-dom-fontface-fontstatuspromise-slot②">(2)</a> <a href="#ref-for-dom-fontface-fontstatuspromise-slot③">(3)</a> <a href="#ref-for-dom-fontface-fontstatuspromise-slot④">(4)</a>
    <li><a href="#ref-for-dom-fontface-fontstatuspromise-slot⑤">2.2. 
The load() method</a> <a href="#ref-for-dom-fontface-fontstatuspromise-slot⑥">(2)</a> <a href="#ref-for-dom-fontface-fontstatuspromise-slot⑦">(3)</a> <a href="#ref-for-dom-fontface-fontstatuspromise-slot⑧">(4)</a>
    <li><a href="#ref-for-dom-fontface-fontstatuspromise-slot⑨">3.2. 
The load() method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-urls-slot">
   <b><a href="#dom-fontface-urls-slot">#dom-fontface-urls-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-urls-slot">2.1. 
The Constructor</a>
    <li><a href="#ref-for-dom-fontface-urls-slot①">2.2. 
The load() method</a> <a href="#ref-for-dom-fontface-urls-slot②">(2)</a>
    <li><a href="#ref-for-dom-fontface-urls-slot③">2.3. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-data-slot">
   <b><a href="#dom-fontface-data-slot">#dom-fontface-data-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-data-slot">2.1. 
The Constructor</a> <a href="#ref-for-dom-fontface-data-slot①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-fontface">
   <b><a href="#dom-fontface-fontface">#dom-fontface-fontface</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-fontface">2. 
The FontFace Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontface-load">
   <b><a href="#dom-fontface-load">#dom-fontface-load</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontface-load">2. 
The FontFace Interface</a> <a href="#ref-for-dom-fontface-load①">(2)</a>
    <li><a href="#ref-for-dom-fontface-load②">2.2. 
The load() method</a> <a href="#ref-for-dom-fontface-load③">(2)</a>
    <li><a href="#ref-for-dom-fontface-load④">3.2. 
The load() method</a>
    <li><a href="#ref-for-dom-fontface-load⑤">3.4. 
The ready attribute</a>
    <li><a href="#ref-for-dom-fontface-load⑥">3.5. 
Interaction with CSS Font Loading and Matching</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-connected">
   <b><a href="#css-connected">#css-connected</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-connected">2.3. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-css-connected①">(2)</a> <a href="#ref-for-css-connected②">(3)</a> <a href="#ref-for-css-connected③">(4)</a>
    <li><a href="#ref-for-css-connected④">3. 
The FontFaceSet Interface</a> <a href="#ref-for-css-connected⑤">(2)</a> <a href="#ref-for-css-connected⑥">(3)</a> <a href="#ref-for-css-connected⑦">(4)</a>
    <li><a href="#ref-for-css-connected⑧">4.2. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-css-connected⑨">(2)</a> <a href="#ref-for-css-connected①⓪">(3)</a> <a href="#ref-for-css-connected①①">(4)</a> <a href="#ref-for-css-connected①②">(5)</a> <a href="#ref-for-css-connected①③">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-fontfacesetloadeventinit">
   <b><a href="#dictdef-fontfacesetloadeventinit">#dictdef-fontfacesetloadeventinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-fontfacesetloadeventinit">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontfacesetloadevent">
   <b><a href="#fontfacesetloadevent">#fontfacesetloadevent</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontfacesetloadevent">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfacesetloadevent-fontfaces">
   <b><a href="#dom-fontfacesetloadevent-fontfaces">#dom-fontfacesetloadevent-fontfaces</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfacesetloadevent-fontfaces">3.1. 
Events</a>
    <li><a href="#ref-for-dom-fontfacesetloadevent-fontfaces①">Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-fontfacesetloadstatus">
   <b><a href="#enumdef-fontfacesetloadstatus">#enumdef-fontfacesetloadstatus</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-fontfacesetloadstatus">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontfaceset">
   <b><a href="#fontfaceset">#fontfaceset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontfaceset">2.1. 
The Constructor</a> <a href="#ref-for-fontfaceset①">(2)</a> <a href="#ref-for-fontfaceset②">(3)</a> <a href="#ref-for-fontfaceset③">(4)</a> <a href="#ref-for-fontfaceset④">(5)</a> <a href="#ref-for-fontfaceset⑤">(6)</a> <a href="#ref-for-fontfaceset⑥">(7)</a> <a href="#ref-for-fontfaceset⑦">(8)</a> <a href="#ref-for-fontfaceset⑧">(9)</a>
    <li><a href="#ref-for-fontfaceset⑨">2.2. 
The load() method</a> <a href="#ref-for-fontfaceset①⓪">(2)</a> <a href="#ref-for-fontfaceset①①">(3)</a> <a href="#ref-for-fontfaceset①②">(4)</a> <a href="#ref-for-fontfaceset①③">(5)</a> <a href="#ref-for-fontfaceset①④">(6)</a> <a href="#ref-for-fontfaceset①⑤">(7)</a>
    <li><a href="#ref-for-fontfaceset①⑥">3. 
The FontFaceSet Interface</a> <a href="#ref-for-fontfaceset①⑦">(2)</a> <a href="#ref-for-fontfaceset①⑧">(3)</a> <a href="#ref-for-fontfaceset①⑨">(4)</a> <a href="#ref-for-fontfaceset②⓪">(5)</a> <a href="#ref-for-fontfaceset②①">(6)</a> <a href="#ref-for-fontfaceset②②">(7)</a> <a href="#ref-for-fontfaceset②③">(8)</a> <a href="#ref-for-fontfaceset②④">(9)</a> <a href="#ref-for-fontfaceset②⑤">(10)</a> <a href="#ref-for-fontfaceset②⑥">(11)</a> <a href="#ref-for-fontfaceset②⑦">(12)</a> <a href="#ref-for-fontfaceset②⑧">(13)</a> <a href="#ref-for-fontfaceset②⑨">(14)</a> <a href="#ref-for-fontfaceset③⓪">(15)</a> <a href="#ref-for-fontfaceset③①">(16)</a> <a href="#ref-for-fontfaceset③②">(17)</a> <a href="#ref-for-fontfaceset③③">(18)</a> <a href="#ref-for-fontfaceset③④">(19)</a> <a href="#ref-for-fontfaceset③⑤">(20)</a>
    <li><a href="#ref-for-fontfaceset③⑥">3.1. 
Events</a> <a href="#ref-for-fontfaceset③⑦">(2)</a> <a href="#ref-for-fontfaceset③⑧">(3)</a> <a href="#ref-for-fontfaceset③⑨">(4)</a> <a href="#ref-for-fontfaceset④⓪">(5)</a> <a href="#ref-for-fontfaceset④①">(6)</a> <a href="#ref-for-fontfaceset④②">(7)</a> <a href="#ref-for-fontfaceset④③">(8)</a>
    <li><a href="#ref-for-fontfaceset④④">3.2. 
The load() method</a> <a href="#ref-for-fontfaceset④⑤">(2)</a>
    <li><a href="#ref-for-fontfaceset④⑥">3.3. 
The check() method</a> <a href="#ref-for-fontfaceset④⑦">(2)</a>
    <li><a href="#ref-for-fontfaceset④⑧">3.5. 
Interaction with CSS Font Loading and Matching</a> <a href="#ref-for-fontfaceset④⑨">(2)</a> <a href="#ref-for-fontfaceset⑤⓪">(3)</a> <a href="#ref-for-fontfaceset⑤①">(4)</a>
    <li><a href="#ref-for-fontfaceset⑤②">4. 
The FontFaceSource mixin</a>
    <li><a href="#ref-for-fontfaceset⑤③">4.2. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-fontfaceset⑤④">(2)</a>
    <li><a href="#ref-for-fontfaceset⑤⑤"> Privacy &amp; Security Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-fontfaceset-initialfaces-initialfaces">
   <b><a href="#dom-fontfaceset-fontfaceset-initialfaces-initialfaces">#dom-fontfaceset-fontfaceset-initialfaces-initialfaces</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-fontfaceset-initialfaces-initialfaces">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-onloading">
   <b><a href="#dom-fontfaceset-onloading">#dom-fontfaceset-onloading</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-onloading">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-onloadingdone">
   <b><a href="#dom-fontfaceset-onloadingdone">#dom-fontfaceset-onloadingdone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-onloadingdone">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-onloadingerror">
   <b><a href="#dom-fontfaceset-onloadingerror">#dom-fontfaceset-onloadingerror</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-onloadingerror">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-status">
   <b><a href="#dom-fontfaceset-status">#dom-fontfaceset-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-status">3.1. 
Events</a> <a href="#ref-for-dom-fontfaceset-status①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-ready">
   <b><a href="#dom-fontfaceset-ready">#dom-fontfaceset-ready</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-ready">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-dom-fontfaceset-ready①">3.4. 
The ready attribute</a> <a href="#ref-for-dom-fontfaceset-ready②">(2)</a> <a href="#ref-for-dom-fontfaceset-ready③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-fontfaceset">
   <b><a href="#dom-fontfaceset-fontfaceset">#dom-fontfaceset-fontfaceset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-fontfaceset">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontfaceset-set-entries">
   <b><a href="#fontfaceset-set-entries">#fontfaceset-set-entries</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontfaceset-set-entries">3. 
The FontFaceSet Interface</a> <a href="#ref-for-fontfaceset-set-entries①">(2)</a> <a href="#ref-for-fontfaceset-set-entries②">(3)</a> <a href="#ref-for-fontfaceset-set-entries③">(4)</a> <a href="#ref-for-fontfaceset-set-entries④">(5)</a>
    <li><a href="#ref-for-fontfaceset-set-entries⑤">4.2. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-add">
   <b><a href="#dom-fontfaceset-add">#dom-fontfaceset-add</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-add">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-add①">(2)</a>
    <li><a href="#ref-for-dom-fontfaceset-add②">4.2. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-delete">
   <b><a href="#dom-fontfaceset-delete">#dom-fontfaceset-delete</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-delete">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-delete①">(2)</a>
    <li><a href="#ref-for-dom-fontfaceset-delete②">4.2. 
Interaction with CSS’s @font-face Rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-clear">
   <b><a href="#dom-fontfaceset-clear">#dom-fontfaceset-clear</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-clear">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-clear①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-loadingfonts-slot">
   <b><a href="#dom-fontfaceset-loadingfonts-slot">#dom-fontfaceset-loadingfonts-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-loadingfonts-slot">2.1. 
The Constructor</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot①">(2)</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot②">(3)</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot③">(4)</a>
    <li><a href="#ref-for-dom-fontfaceset-loadingfonts-slot④">2.2. 
The load() method</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot⑤">(2)</a>
    <li><a href="#ref-for-dom-fontfaceset-loadingfonts-slot⑥">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot⑦">(2)</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot⑧">(3)</a> <a href="#ref-for-dom-fontfaceset-loadingfonts-slot⑨">(4)</a>
    <li><a href="#ref-for-dom-fontfaceset-loadingfonts-slot①⓪">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-loadedfonts-slot">
   <b><a href="#dom-fontfaceset-loadedfonts-slot">#dom-fontfaceset-loadedfonts-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-loadedfonts-slot">2.1. 
The Constructor</a>
    <li><a href="#ref-for-dom-fontfaceset-loadedfonts-slot①">2.2. 
The load() method</a>
    <li><a href="#ref-for-dom-fontfaceset-loadedfonts-slot②">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-loadedfonts-slot③">(2)</a>
    <li><a href="#ref-for-dom-fontfaceset-loadedfonts-slot④">3.1. 
Events</a> <a href="#ref-for-dom-fontfaceset-loadedfonts-slot⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-failedfonts-slot">
   <b><a href="#dom-fontfaceset-failedfonts-slot">#dom-fontfaceset-failedfonts-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-failedfonts-slot">2.1. 
The Constructor</a>
    <li><a href="#ref-for-dom-fontfaceset-failedfonts-slot①">2.2. 
The load() method</a>
    <li><a href="#ref-for-dom-fontfaceset-failedfonts-slot②">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-failedfonts-slot③">(2)</a>
    <li><a href="#ref-for-dom-fontfaceset-failedfonts-slot④">3.1. 
Events</a> <a href="#ref-for-dom-fontfaceset-failedfonts-slot⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-readypromise-slot">
   <b><a href="#dom-fontfaceset-readypromise-slot">#dom-fontfaceset-readypromise-slot</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-readypromise-slot">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-dom-fontfaceset-readypromise-slot①">3.1. 
Events</a> <a href="#ref-for-dom-fontfaceset-readypromise-slot②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontfaceset-pending-on-the-environment">
   <b><a href="#fontfaceset-pending-on-the-environment">#fontfaceset-pending-on-the-environment</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontfaceset-pending-on-the-environment">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-fontfaceset-pending-on-the-environment①">3.1. 
Events</a> <a href="#ref-for-fontfaceset-pending-on-the-environment②">(2)</a> <a href="#ref-for-fontfaceset-pending-on-the-environment③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-fontfaceset-loading">
   <b><a href="#eventdef-fontfaceset-loading">#eventdef-fontfaceset-loading</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-fontfaceset-loading">3.1. 
Events</a> <a href="#ref-for-eventdef-fontfaceset-loading①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-fontfaceset-loadingdone">
   <b><a href="#eventdef-fontfaceset-loadingdone">#eventdef-fontfaceset-loadingdone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-fontfaceset-loadingdone">3.1. 
Events</a> <a href="#ref-for-eventdef-fontfaceset-loadingdone①">(2)</a>
    <li><a href="#ref-for-eventdef-fontfaceset-loadingdone②">3.4. 
The ready attribute</a>
    <li><a href="#ref-for-eventdef-fontfaceset-loadingdone③">5. 
API Examples</a> <a href="#ref-for-eventdef-fontfaceset-loadingdone④">(2)</a> <a href="#ref-for-eventdef-fontfaceset-loadingdone⑤">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-fontfaceset-loadingerror">
   <b><a href="#eventdef-fontfaceset-loadingerror">#eventdef-fontfaceset-loadingerror</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-fontfaceset-loadingerror">3.1. 
Events</a> <a href="#ref-for-eventdef-fontfaceset-loadingerror①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fire-a-font-load-event">
   <b><a href="#fire-a-font-load-event">#fire-a-font-load-event</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fire-a-font-load-event">3.1. 
Events</a> <a href="#ref-for-fire-a-font-load-event①">(2)</a> <a href="#ref-for-fire-a-font-load-event②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="switch-the-fontfaceset-to-loading">
   <b><a href="#switch-the-fontfaceset-to-loading">#switch-the-fontfaceset-to-loading</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-switch-the-fontfaceset-to-loading">2.1. 
The Constructor</a>
    <li><a href="#ref-for-switch-the-fontfaceset-to-loading①">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="switch-the-fontfaceset-to-loaded">
   <b><a href="#switch-the-fontfaceset-to-loaded">#switch-the-fontfaceset-to-loaded</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-switch-the-fontfaceset-to-loaded">2.1. 
The Constructor</a> <a href="#ref-for-switch-the-fontfaceset-to-loaded①">(2)</a>
    <li><a href="#ref-for-switch-the-fontfaceset-to-loaded②">2.2. 
The load() method</a> <a href="#ref-for-switch-the-fontfaceset-to-loaded③">(2)</a>
    <li><a href="#ref-for-switch-the-fontfaceset-to-loaded④">3. 
The FontFaceSet Interface</a> <a href="#ref-for-switch-the-fontfaceset-to-loaded⑤">(2)</a>
    <li><a href="#ref-for-switch-the-fontfaceset-to-loaded⑥">3.1. 
Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontfaceset-stuck-on-the-environment">
   <b><a href="#fontfaceset-stuck-on-the-environment">#fontfaceset-stuck-on-the-environment</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontfaceset-stuck-on-the-environment">3.1. 
Events</a> <a href="#ref-for-fontfaceset-stuck-on-the-environment①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="find-the-matching-font-faces">
   <b><a href="#find-the-matching-font-faces">#find-the-matching-font-faces</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-find-the-matching-font-faces">3.2. 
The load() method</a>
    <li><a href="#ref-for-find-the-matching-font-faces①">3.3. 
The check() method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-load">
   <b><a href="#dom-fontfaceset-load">#dom-fontfaceset-load</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-load">3. 
The FontFaceSet Interface</a> <a href="#ref-for-dom-fontfaceset-load①">(2)</a>
    <li><a href="#ref-for-dom-fontfaceset-load②">3.2. 
The load() method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-load-font-text-font">
   <b><a href="#dom-fontfaceset-load-font-text-font">#dom-fontfaceset-load-font-text-font</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-load-font-text-font">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-load-font-text-text">
   <b><a href="#dom-fontfaceset-load-font-text-text">#dom-fontfaceset-load-font-text-text</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-load-font-text-text">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-check">
   <b><a href="#dom-fontfaceset-check">#dom-fontfaceset-check</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-check">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-dom-fontfaceset-check①">3.3. 
The check() method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-check-font-text-font">
   <b><a href="#dom-fontfaceset-check-font-text-font">#dom-fontfaceset-check-font-text-font</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-check-font-text-font">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfaceset-check-font-text-text">
   <b><a href="#dom-fontfaceset-check-font-text-text">#dom-fontfaceset-check-font-text-text</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfaceset-check-font-text-text">3. 
The FontFaceSet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fontfacesource">
   <b><a href="#fontfacesource">#fontfacesource</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fontfacesource">4. 
The FontFaceSource mixin</a> <a href="#ref-for-fontfacesource①">(2)</a> <a href="#ref-for-fontfacesource②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-fontfacesource-fonts">
   <b><a href="#dom-fontfacesource-fonts">#dom-fontfacesource-fonts</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-fontfacesource-fonts">4. 
The FontFaceSource mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="font-source">
   <b><a href="#font-source">#font-source</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-font-source">2.3. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-font-source①">(2)</a>
    <li><a href="#ref-for-font-source②">3. 
The FontFaceSet Interface</a>
    <li><a href="#ref-for-font-source③">3.5. 
Interaction with CSS Font Loading and Matching</a>
    <li><a href="#ref-for-font-source④">4. 
The FontFaceSource mixin</a> <a href="#ref-for-font-source⑤">(2)</a>
    <li><a href="#ref-for-font-source⑥">4.1. 
Worker FontFaceSources</a>
    <li><a href="#ref-for-font-source⑦">4.2. 
Interaction with CSS’s @font-face Rule</a> <a href="#ref-for-font-source⑧">(2)</a> <a href="#ref-for-font-source⑨">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="available-font-faces">
   <b><a href="#available-font-faces">#available-font-faces</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-available-font-faces">3.1. 
Events</a>
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
            </script><a class='success' href='/bikeshed/css-font-loading/' id='generator' title='Bikeshed Succeeded'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>