<!doctype html><html lang="en">
 <head>
  <meta charset="utf-8">
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="#3c790a" name="theme-color">
  <title>Fetch Standard</title>
  <link crossorigin href="https://resources.whatwg.org/spec.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/standard.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/standard-shared-with-dev.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/logo-fetch.svg" rel="icon">
<script async crossorigin src="https://resources.whatwg.org/file-issue.js"></script>
<script async crossorigin src="https://resources.whatwg.org/commit-snapshot-shortcut-key.js"></script>
  <meta content="Bikeshed version c1dbacab, updated Mon Mar 30 18:56:12 2020 -0700" name="generator">
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
 <body class="h-entry status-LS">
  <div class="head">
    <a class="logo" href="https://whatwg.org/"> <img alt="WHATWG" crossorigin height="100" src="https://resources.whatwg.org/logo-fetch.svg"> </a> 
   <hgroup>
    <h1 class="p-name no-ref" id="title">Fetch</h1>
    <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Living Standard — Last Updated <time class="dt-updated" datetime="2020-04-06">6 April 2020</time></span></h2>
   </hgroup>
   <div data-fill-with="spec-metadata">
    <dl>
     <dt>Participate:
     <dd><a href="https://github.com/whatwg/fetch">GitHub whatwg/fetch</a> (<a href="https://github.com/whatwg/fetch/issues/new">new issue</a>, <a href="https://github.com/whatwg/fetch/issues">open issues</a>)
     <dd><a href="https://wiki.whatwg.org/wiki/IRC">IRC: #whatwg on Freenode</a>
     <dt>Commits:
     <dd><a href="https://github.com/whatwg/fetch/commits">GitHub whatwg/fetch/commits</a>
     <dd><a href="/commit-snapshots/1eb53eafe0d2cd6f76489cd3ef6d20c2325e382b/" id="commit-snapshot-link">Snapshot as of this commit</a>
     <dd><a href="https://twitter.com/fetchstandard">@fetchstandard</a>
     <dt>Tests:
     <dd><a href="https://github.com/web-platform-tests/wpt/tree/master/fetch">web-platform-tests fetch/</a> (<a href="https://github.com/web-platform-tests/wpt/labels/fetch">ongoing work</a>)
     <dt>Translations <small>(non-normative)</small>:
     <dd><span title="Japanese"><a href="https://triple-underscore.github.io/Fetch-ja.html" hreflang="ja" lang="ja" rel="alternate">日本語</a></span>
    </dl>
   </div>
   <div data-fill-with="warning"></div>
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>The Fetch standard defines requests, responses, and the process that binds them: fetching.</p>
  </div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li><a href="#goals"><span class="secno"></span> <span class="content">Goals</span></a>
    <li><a href="#preface"><span class="secno">1</span> <span class="content">Preface</span></a>
    <li>
     <a href="#infrastructure"><span class="secno">2</span> <span class="content">Infrastructure</span></a>
     <ol class="toc">
      <li><a href="#url"><span class="secno">2.1</span> <span class="content">URL</span></a>
      <li>
       <a href="#http"><span class="secno">2.2</span> <span class="content">HTTP</span></a>
       <ol class="toc">
        <li><a href="#methods"><span class="secno">2.2.1</span> <span class="content">Methods</span></a>
        <li><a href="#terminology-headers"><span class="secno">2.2.2</span> <span class="content">Headers</span></a>
        <li><a href="#statuses"><span class="secno">2.2.3</span> <span class="content">Statuses</span></a>
        <li><a href="#bodies"><span class="secno">2.2.4</span> <span class="content">Bodies</span></a>
        <li><a href="#requests"><span class="secno">2.2.5</span> <span class="content">Requests</span></a>
        <li><a href="#responses"><span class="secno">2.2.6</span> <span class="content">Responses</span></a>
        <li><a href="#miscellaneous"><span class="secno">2.2.7</span> <span class="content">Miscellaneous</span></a>
       </ol>
      <li><a href="#authentication-entries"><span class="secno">2.3</span> <span class="content">Authentication entries</span></a>
      <li><a href="#fetch-groups"><span class="secno">2.4</span> <span class="content">Fetch groups</span></a>
      <li><a href="#connections"><span class="secno">2.5</span> <span class="content">Connections</span></a>
      <li><a href="#port-blocking"><span class="secno">2.6</span> <span class="content">Port blocking</span></a>
      <li><a href="#should-response-to-request-be-blocked-due-to-mime-type?"><span class="secno">2.7</span> <span class="content">Should <var>response</var> to <var>request</var> be blocked due to its MIME type?</span></a>
      <li>
       <a href="#streams"><span class="secno">2.8</span> <span class="content">Streams</span></a>
       <ol class="toc">
        <li><a href="#readablestream"><span class="secno">2.8.1</span> <span class="content">ReadableStream</span></a>
       </ol>
     </ol>
    <li>
     <a href="#http-extensions"><span class="secno">3</span> <span class="content">HTTP extensions</span></a>
     <ol class="toc">
      <li><a href="#origin-header"><span class="secno">3.1</span> <span class="content">`<code>Origin</code>` header</span></a>
      <li>
       <a href="#http-cors-protocol"><span class="secno">3.2</span> <span class="content">CORS protocol</span></a>
       <ol class="toc">
        <li><a href="#general"><span class="secno">3.2.1</span> <span class="content">General</span></a>
        <li><a href="#http-requests"><span class="secno">3.2.2</span> <span class="content">HTTP requests</span></a>
        <li><a href="#http-responses"><span class="secno">3.2.3</span> <span class="content">HTTP responses</span></a>
        <li><a href="#http-new-header-syntax"><span class="secno">3.2.4</span> <span class="content">HTTP new-header syntax</span></a>
        <li><a href="#cors-protocol-and-credentials"><span class="secno">3.2.5</span> <span class="content">CORS protocol and credentials</span></a>
        <li><a href="#cors-protocol-examples"><span class="secno">3.2.6</span> <span class="content">Examples</span></a>
        <li><a href="#cors-protocol-exceptions"><span class="secno">3.2.7</span> <span class="content">CORS protocol exceptions</span></a>
       </ol>
      <li><a href="#content-type-header"><span class="secno">3.3</span> <span class="content">`<code>Content-Type</code>` header</span></a>
      <li>
       <a href="#x-content-type-options-header"><span class="secno">3.4</span> <span class="content">`<code>X-Content-Type-Options</code>` header</span></a>
       <ol class="toc">
        <li><a href="#should-response-to-request-be-blocked-due-to-nosniff?"><span class="secno">3.4.1</span> <span class="content">Should <var>response</var> to <var>request</var> be blocked due to nosniff?</span></a>
       </ol>
      <li><a href="#corb"><span class="secno">3.5</span> <span class="content">CORB</span></a>
      <li><a href="#cross-origin-resource-policy-header"><span class="secno">3.6</span> <span class="content">`<code>Cross-Origin-Resource-Policy</code>` header</span></a>
     </ol>
    <li>
     <a href="#fetching"><span class="secno">4</span> <span class="content">Fetching</span></a>
     <ol class="toc">
      <li><a href="#main-fetch"><span class="secno">4.1</span> <span class="content">Main fetch</span></a>
      <li><a href="#scheme-fetch"><span class="secno">4.2</span> <span class="content">Scheme fetch</span></a>
      <li><a href="#http-fetch"><span class="secno">4.3</span> <span class="content">HTTP fetch</span></a>
      <li><a href="#http-redirect-fetch"><span class="secno">4.4</span> <span class="content">HTTP-redirect fetch</span></a>
      <li><a href="#http-network-or-cache-fetch"><span class="secno">4.5</span> <span class="content">HTTP-network-or-cache fetch</span></a>
      <li><a href="#http-network-fetch"><span class="secno">4.6</span> <span class="content">HTTP-network fetch</span></a>
      <li><a href="#cors-preflight-fetch"><span class="secno">4.7</span> <span class="content">CORS-preflight fetch</span></a>
      <li><a href="#cors-preflight-cache"><span class="secno">4.8</span> <span class="content">CORS-preflight cache</span></a>
      <li><a href="#cors-check"><span class="secno">4.9</span> <span class="content">CORS check</span></a>
      <li><a href="#tao-check"><span class="secno">4.10</span> <span class="content">TAO check</span></a>
     </ol>
    <li>
     <a href="#fetch-api"><span class="secno">5</span> <span class="content">Fetch API</span></a>
     <ol class="toc">
      <li><a href="#headers-class"><span class="secno">5.1</span> <span class="content">Headers class</span></a>
      <li><a href="#body-mixin"><span class="secno">5.2</span> <span class="content">Body mixin</span></a>
      <li><a href="#request-class"><span class="secno">5.3</span> <span class="content">Request class</span></a>
      <li><a href="#response-class"><span class="secno">5.4</span> <span class="content">Response class</span></a>
      <li><a href="#fetch-method"><span class="secno">5.5</span> <span class="content">Fetch method</span></a>
      <li><a href="#garbage-collection"><span class="secno">5.6</span> <span class="content">Garbage collection</span></a>
     </ol>
    <li>
     <a href="#websocket-protocol"><span class="secno">6</span> <span class="content">WebSocket protocol alterations</span></a>
     <ol class="toc">
      <li><a href="#websocket-connections"><span class="secno">6.1</span> <span class="content">Connections</span></a>
      <li><a href="#websocket-opening-handshake"><span class="secno">6.2</span> <span class="content">Opening handshake</span></a>
     </ol>
    <li><a href="#data-urls"><span class="secno">7</span> <span class="content"><code>data:</code> URLs</span></a>
    <li>
     <a href="#background-reading"><span class="secno"></span> <span class="content">Background reading</span></a>
     <ol class="toc">
      <li><a href="#http-header-layer-division"><span class="secno"></span> <span class="content">HTTP header layer division</span></a>
      <li><a href="#atomic-http-redirect-handling"><span class="secno"></span> <span class="content">Atomic HTTP redirect handling</span></a>
      <li><a href="#basic-safe-cors-protocol-setup"><span class="secno"></span> <span class="content">Basic safe CORS protocol setup</span></a>
      <li><a href="#cors-protocol-and-http-caches"><span class="secno"></span> <span class="content">CORS protocol and HTTP caches</span></a>
     </ol>
    <li><a href="#acknowledgments"><span class="secno"></span> <span class="content">Acknowledgments</span></a>
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
   <h2 class="no-num short heading settled" id="goals"><span class="content">Goals</span></h2>
   <p>To unify fetching across the web platform this specification supplants a number of algorithms and
specifications: </p>
   <ul class="brief no-backref">
    <li>HTML Standard’s fetch and potentially CORS-enabled fetch algorithms <a data-link-type="biblio" href="#biblio-html">[HTML]</a> 
    <li>CORS <a data-link-type="biblio" href="#biblio-cors">[CORS]</a> 
    <li>HTTP `<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin"><code>Origin</code></a>` header semantics <a data-link-type="biblio" href="#biblio-origin">[ORIGIN]</a> 
   </ul>
   <p>Unifying fetching provides consistent handling of: </p>
   <ul class="brief">
    <li>URL schemes 
    <li>Redirects 
    <li>Cross-origin semantics 
    <li>CSP <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> 
    <li>Service workers <a data-link-type="biblio" href="#biblio-sw">[SW]</a> 
    <li>Mixed Content <a data-link-type="biblio" href="#biblio-mix">[MIX]</a> 
    <li>`<code>Referer</code>` <a data-link-type="biblio" href="#biblio-referrer">[REFERRER]</a> 
   </ul>
   <h2 class="short heading settled" data-level="1" id="preface"><span class="secno">1. </span><span class="content">Preface</span><a class="self-link" href="#preface"></a></h2>
   <p>At a high level, fetching a resource is a fairly simple operation. A request goes in, a
response comes out. The details of that operation are
however quite involved and used to not be written down carefully and differ from one API
to the next. </p>
   <p>Numerous APIs provide the ability to fetch a resource, e.g. HTML’s <code>img</code> and <code>script</code> element, CSS' <code>cursor</code> and <code>list-style-image</code>,
the <code>navigator.sendBeacon()</code> and <code>self.importScripts()</code> JavaScript
APIs. The Fetch Standard provides a unified architecture for these features so they are
all consistent when it comes to various aspects of fetching, such as redirects and the
CORS protocol. </p>
   <p>The Fetch Standard also defines the <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch"><code>fetch()</code></a> JavaScript API, which exposes most of the networking functionality at a fairly low level
of abstraction. </p>
   <h2 class="heading settled" data-level="2" id="infrastructure"><span class="secno">2. </span><span class="content">Infrastructure</span><a class="self-link" href="#infrastructure"></a></h2>
   <p>This specification depends on the Infra Standard. <a data-link-type="biblio" href="#biblio-infra">[INFRA]</a> </p>
   <p>This specification uses terminology from the ABNF, Encoding, HTML, HTTP, IDL, MIME Sniffing,
Streams, and URL Standards. <a data-link-type="biblio" href="#biblio-abnf">[ABNF]</a> <a data-link-type="biblio" href="#biblio-encoding">[ENCODING]</a> <a data-link-type="biblio" href="#biblio-html">[HTML]</a> <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a> <a data-link-type="biblio" href="#biblio-mimesniff">[MIMESNIFF]</a> <a data-link-type="biblio" href="#biblio-streams">[STREAMS]</a> <a data-link-type="biblio" href="#biblio-url">[URL]</a> </p>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="abnf">ABNF</dfn> means ABNF as augmented by HTTP (in particular the addition <code>#</code>) and
RFC 7405. <a data-link-type="biblio" href="#biblio-rfc7405">[RFC7405]</a> </p>
   <hr>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="credentials">Credentials</dfn> are HTTP cookies, TLS client certificates, and <a data-link-type="dfn" href="#authentication-entry" id="ref-for-authentication-entry">authentication entries</a> (for HTTP authentication). <a data-link-type="biblio" href="#biblio-cookies">[COOKIES]</a> <a data-link-type="biblio" href="#biblio-tls">[TLS]</a> <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> </p>
   <hr>
   <p><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-task" id="ref-for-concept-task">Tasks</a> that are <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task" id="ref-for-queue-a-task">queued</a> by this standard are annotated as one
of: </p>
   <ul class="brief">
    <li><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="process-request-body">process request body</dfn> 
    <li id="process-request-end-of-file"><a class="self-link" href="#process-request-end-of-file"></a><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="process-request-end-of-body">process request end-of-body</dfn> 
    <li><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="process-response">process response</dfn> 
    <li id="process-response-end-of-file"><a class="self-link" href="#process-response-end-of-file"></a><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="process-response-end-of-body">process response end-of-body</dfn> 
    <li><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="process-response-done">process response done</dfn> 
   </ul>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="queue-a-fetch-task">queue a fetch task</dfn> on <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request">request</a> <var>request</var> to <var>run an operation</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client">client</a> is
 null, terminate these steps. </p>
    <li>
     <p><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task" id="ref-for-queue-a-task①">Queue a task</a> to <var>run an operation</var> on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-event-loop" id="ref-for-responsible-event-loop">responsible event loop</a> using the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#networking-task-source" id="ref-for-networking-task-source">networking task source</a>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="queue-a-fetch-request-done-task">queue a fetch-request-done task</dfn>, given a <var>request</var>, <a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task">queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-request-end-of-body" id="ref-for-process-request-end-of-body">process request end-of-body</a> for <var>request</var>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="serialize-an-integer">serialize an integer</dfn>, represent it as a string of the shortest possible decimal
number. </p>
   <p class="XXX">This will be replaced by a more descriptive algorithm in Infra. See <a href="https://github.com/whatwg/infra/issues/201">infra/201</a>. </p>
   <h3 class="heading settled" data-level="2.1" id="url"><span class="secno">2.1. </span><span class="content">URL</span><a class="self-link" href="#url"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="local-scheme">local scheme</dfn> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme">scheme</a> that is "<code>about</code>",
"<code>blob</code>", or "<code>data</code>". </p>
   <p>A <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url">URL</a> <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="is-local">is local</dfn> if its <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①">scheme</a> is a <a data-link-type="dfn" href="#local-scheme" id="ref-for-local-scheme">local scheme</a>. </p>
   <p class="note" role="note">This definition is also used by <cite>Referrer Policy</cite>. <a data-link-type="biblio" href="#biblio-referrer">[REFERRER]</a> </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="http-scheme">HTTP(S) scheme</dfn> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme②">scheme</a> that is
"<code>http</code>" or "<code>https</code>". </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="network-scheme">network scheme</dfn> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme③">scheme</a> that is "<code>ftp</code>" or an <a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme">HTTP(S) scheme</a>. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="fetch-scheme">fetch scheme</dfn> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme④">scheme</a> that is "<code>about</code>",
"<code>blob</code>", "<code>data</code>", "<code>file</code>", or a <a data-link-type="dfn" href="#network-scheme" id="ref-for-network-scheme">network scheme</a>. </p>
   <p class="note no-backref" role="note"><a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme①">HTTP(S) scheme</a>, <a data-link-type="dfn" href="#network-scheme" id="ref-for-network-scheme①">network scheme</a>, and <a data-link-type="dfn" href="#fetch-scheme" id="ref-for-fetch-scheme">fetch scheme</a> are
also used by <cite>HTML</cite>. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <hr>
   <p id="fetch-url">A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="response-url">response URL</dfn> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①">URL</a> for which implementations need not
store the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-fragment" id="ref-for-concept-url-fragment">fragment</a> as it is never exposed. When <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer">serialized</a>, the <i>exclude fragment flag</i> is set, meaning
implementations can store the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-fragment" id="ref-for-concept-url-fragment①">fragment</a> nonetheless. </p>
   <h3 class="heading settled" data-level="2.2" id="http"><span class="secno">2.2. </span><span class="content">HTTP</span><a class="self-link" href="#http"></a></h3>
   <p>While <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch">fetching</a> encompasses more than just HTTP, it
borrows a number of concepts from HTTP and applies these to resources obtained via other
means (e.g., <code>data</code> URLs). </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="http-tab-or-space">HTTP tab or space</dfn> is U+0009 TAB or U+0020 SPACE. </p>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="http-whitespace">HTTP whitespace</dfn> is U+000A LF, U+000D CR, or an <a data-link-type="dfn" href="#http-tab-or-space" id="ref-for-http-tab-or-space">HTTP tab or space</a>. </p>
   <p class="note no-backref" role="note"><a data-link-type="dfn" href="#http-whitespace" id="ref-for-http-whitespace">HTTP whitespace</a> is only useful for specific constructs that are
reused outside the context of HTTP headers (e.g., <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type" id="ref-for-mime-type">MIME types</a>). For HTTP header values,
using <a data-link-type="dfn" href="#http-tab-or-space" id="ref-for-http-tab-or-space①">HTTP tab or space</a> is preferred, and outside that context <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-whitespace" id="ref-for-ascii-whitespace">ASCII whitespace</a> is
preferred. Unlike <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-whitespace" id="ref-for-ascii-whitespace①">ASCII whitespace</a> this excludes U+000C FF. </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="http-newline-byte">HTTP newline byte</dfn> is 0x0A (LF) or 0x0D (CR). </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="http-tab-or-space-byte">HTTP tab or space byte</dfn> is 0x09 (HT) or 0x20 (SP). </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="http-whitespace-byte">HTTP whitespace byte</dfn> is an <a data-link-type="dfn" href="#http-newline-byte" id="ref-for-http-newline-byte">HTTP newline byte</a> or <a data-link-type="dfn" href="#http-tab-or-space-byte" id="ref-for-http-tab-or-space-byte">HTTP tab or space byte</a>. </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-https-state-value">HTTPS state value</dfn> is "<code>none</code>",
"<code>deprecated</code>", or "<code>modern</code>". </p>
   <p class="note no-backref" role="note">A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response">response</a> delivered over HTTPS will
typically have its <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state">HTTPS state</a> set to
"<code>modern</code>". A user agent can use "<code>deprecated</code>" in a transition
period. E.g., while removing support for a hash function, weak cipher suites, certificates for an
"Internal Name", or certificates with an overly long validity period. How exactly a user agent can
use "<code>deprecated</code>" is not defined by this specification. An <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object">environment settings object</a> typically derives its <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#https-state" id="ref-for-https-state">HTTPS state</a> from a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①">response</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="collect an HTTP quoted string|collecting an HTTP quoted string" id="collect-an-http-quoted-string">collect an HTTP quoted string</dfn> from a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string" id="ref-for-string">string</a> <var>input</var>, given a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string-position-variable" id="ref-for-string-position-variable">position variable</a> <var>position</var> and optionally an <var>extract-value flag</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>positionStart</var> be <var>position</var>. </p>
    <li>
     <p>Let <var>value</var> be the empty string. </p>
    <li>
     <p>Assert: the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point">code point</a> at <var>position</var> within <var>input</var> is U+0022 ("). </p>
    <li>
     <p>Advance <var>position</var> by 1. </p>
    <li>
     <p>While true: </p>
     <ol>
      <li>
       <p>Append the result of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#collect-a-sequence-of-code-points" id="ref-for-collect-a-sequence-of-code-points">collecting a sequence of code points</a> that are not U+0022 (")
   or U+005C (\) from <var>input</var>, given <var>position</var>, to <var>value</var>. </p>
      <li>
       <p>If <var>position</var> is past the end of <var>input</var>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break">break</a>. </p>
      <li>
       <p>Let <var>quoteOrBackslash</var> be the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point①">code point</a> at <var>position</var> within <var>input</var>. </p>
      <li>
       <p>Advance <var>position</var> by 1. </p>
      <li>
       <p>If <var>quoteOrBackslash</var> is U+005C (\), then: </p>
       <ol>
        <li>
         <p>If <var>position</var> is past the end of <var>input</var>, then append U+005C (\) to <var>value</var> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break①">break</a>. </p>
        <li>
         <p>Append the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point②">code point</a> at <var>position</var> within <var>input</var> to <var>value</var>. </p>
        <li>
         <p>Advance <var>position</var> by 1. </p>
       </ol>
      <li>
       <p>Otherwise: </p>
       <ol>
        <li>
         <p>Assert: <var>quoteOrBackslash</var> is U+0022 ("). </p>
        <li>
         <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break②">Break</a>. </p>
       </ol>
     </ol>
    <li>
     <p>If the <var>extract-value flag</var> is set, then return <var>value</var>. </p>
    <li>
     <p>Return the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point③">code points</a> from <var>positionStart</var> to <var>position</var>,
 inclusive, within <var>input</var>. </p>
   </ol>
   <p class="note no-backref" role="note">The <var>extract-value flag</var> argument makes this algorithm suitable
for <a data-link-type="dfn" href="#concept-header-list-get-decode-split" id="ref-for-concept-header-list-get-decode-split">getting, decoding, and splitting</a> and <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parse-a-mime-type" id="ref-for-parse-a-mime-type">parse a MIME type</a>, as well
as other header value parsers that might need this. </p>
   <h4 class="heading settled" data-level="2.2.1" id="methods"><span class="secno">2.2.1. </span><span class="content">Methods</span><a class="self-link" href="#methods"></a></h4>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-method">method</dfn> is a byte sequence that matches the <a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.1.1" id="ref-for-section-3.1.1">method</a> token production. </p>
   <p id="simple-method">A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-safelisted-method">CORS-safelisted method</dfn> is a <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method">method</a> that is `<code>GET</code>`,
`<code>HEAD</code>`, or `<code>POST</code>`. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="forbidden-method">forbidden method</dfn> is a <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method①">method</a> that is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive">byte-case-insensitive</a> match for `<code>CONNECT</code>`,
`<code>TRACE</code>`, or `<code>TRACK</code>`. <a data-link-type="biblio" href="#biblio-httpverbsec1">[HTTPVERBSEC1]</a>, <a data-link-type="biblio" href="#biblio-httpverbsec2">[HTTPVERBSEC2]</a>, <a data-link-type="biblio" href="#biblio-httpverbsec3">[HTTPVERBSEC3]</a> </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="method" data-dfn-type="dfn" data-export id="concept-method-normalize">normalize</dfn> a <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method②">method</a>, if it is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①">byte-case-insensitive</a> match for `<code>DELETE</code>`, `<code>GET</code>`,
`<code>HEAD</code>`, `<code>OPTIONS</code>`, `<code>POST</code>`, or
`<code>PUT</code>`, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-uppercase" id="ref-for-byte-uppercase">byte-uppercase</a> it. </p>
   <p class="note no-backref" role="note"><a data-link-type="dfn" href="#concept-method-normalize" id="ref-for-concept-method-normalize">Normalization</a> is
done for backwards compatibility and consistency across APIs as <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method③">methods</a> are actually "case-sensitive". </p>
   <p class="example" id="example-normalization"><a class="self-link" href="#example-normalization"></a>Using `<code>patch</code>` is highly likely to result in a
`<code>405 Method Not Allowed</code>`. `<code>PATCH</code>` is much more likely to
succeed. </p>
   <p class="note no-backref" role="note">There are no restrictions on <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method④">methods</a>.
`<code>CHICKEN</code>` is perfectly acceptable (and not a misspelling of
`<code>CHECKIN</code>`). Other than those that are <a data-link-type="dfn" href="#concept-method-normalize" id="ref-for-concept-method-normalize①">normalized</a> there are no casing restrictions either.
`<code>Egg</code>` or `<code>eGg</code>` would be fine, though uppercase is encouraged
for consistency. </p>
   <h4 class="heading settled" data-level="2.2.2" id="terminology-headers"><span class="secno">2.2.2. </span><span class="content">Headers</span><a class="self-link" href="#terminology-headers"></a></h4>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-header-list">header list</dfn> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list">list</a> of zero or more <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header">headers</a>. It is initially the empty list. </p>
   <p class="note no-backref" role="note">A <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list">header list</a> is essentially a
specialized multimap. An ordered list of key-value pairs with potentially duplicate keys. </p>
   <p>To <dfn data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-get-structured-header">get a structured header<a class="self-link" href="#concept-header-list-get-structured-header"></a></dfn> given a <var>name</var> and a <var>type</var> from a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①">header list</a> <var>list</var>, run
these steps: </p>
   <ol>
    <li>
     <p>Assert: <var>type</var> is one of "<code>dictionary</code>", "<code>list</code>", or
 "<code>item</code>". </p>
    <li>
     <p>Let <var>value</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get">getting</a> <var>name</var> from <var>list</var>. </p>
    <li>
     <p>If <var>value</var> is null, then return null. </p>
    <li>
     <p>Let <var>result</var> be the result of executing the <a data-link-type="dfn" href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-4.2" id="ref-for-section-4.2">parsing structured headers</a> algorithm with <var>input_string</var> set to <var>value</var>, and <var>header_type</var> set to <var>type</var>. </p>
    <li>
     <p>If parsing failed, then return failure. </p>
    <li>
     <p>Return <var>result</var>. </p>
   </ol>
   <p>To <dfn data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-set-structured-header">set a structured header<a class="self-link" href="#concept-header-list-set-structured-header"></a></dfn> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name">name</a>/<a data-link-type="dfn" href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-2" id="ref-for-section-2">structured header value</a> <var>name</var>/<var>structuredValue</var> pair in a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list②">header list</a> <var>list</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>serializedValue</var> be the result of executing the <a data-link-type="dfn" href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-4.1" id="ref-for-section-4.1">serializing structured headers</a> algorithm on <var>structuredValue</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-set" id="ref-for-concept-header-list-set">Set</a> <var>name</var>/<var>serializedValue</var> in <var>list</var>. </p>
   </ol>
   <p class="note" role="note"><a data-link-type="dfn" href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-2" id="ref-for-section-2①">Structured header values</a> are defined as objects which HTTP can (eventually)
serialize in interesting and efficient ways. For the moment, Fetch only supports <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①">header</a> <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value">values</a> as <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence" id="ref-for-byte-sequence">byte sequences</a>, which means that these objects can be set
in <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list③">header lists</a> only via serialization, and they can be obtained from <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list④">header lists</a> only by parsing. In the future the fact that they are objects might be
preserved end-to-end. <a data-link-type="biblio" href="#biblio-header-structure">[HEADER-STRUCTURE]</a> </p>
   <hr>
   <p>A <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list⑤">header list</a> <var>list</var> <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export data-lt="contains|does not contain" id="header-list-contains">contains</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①">name</a> <var>name</var> if <var>list</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain">contains</a> a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②">name</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive②">byte-case-insensitive</a> match for <var>name</var>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-get">get</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③">name</a> <var>name</var> from a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list⑥">header list</a> <var>list</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains">does not contain</a> <var>name</var>, then return
 null. </p>
    <li>
     <p>Return the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①">values</a> of all <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③">headers</a> in <var>list</var> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④">name</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive③">byte-case-insensitive</a> match for <var>name</var>, separated
 from each other by 0x2C 0x20, in order. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export data-lt="get, decode, and split|getting, decoding, and splitting" id="concept-header-list-get-decode-split">get, decode, and split</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤">name</a> <var>name</var> from <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list⑦">header list</a> <var>list</var>, run these
steps: </p>
   <ol>
    <li>
     <p>Let <var>initialValue</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get①">getting</a> <var>name</var> from <var>list</var>. </p>
    <li>
     <p>If <var>initialValue</var> is null, then return null. </p>
    <li>
     <p>Let <var>input</var> be the result of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-decode" id="ref-for-isomorphic-decode">isomorphic decoding</a> <var>initialValue</var>. </p>
    <li>
     <p>Let <var>position</var> be a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string-position-variable" id="ref-for-string-position-variable①">position variable</a> for <var>input</var>,
 initially pointing at the start of <var>input</var>. </p>
    <li>
     <p>Let <var>values</var> be a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list①">list</a> of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string" id="ref-for-string①">strings</a>, initially empty. </p>
    <li>
     <p>Let <var>value</var> be the empty string. </p>
    <li>
     <p>While <var>position</var> is not past the end of <var>input</var>: </p>
     <ol>
      <li>
       <p>Append the result of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#collect-a-sequence-of-code-points" id="ref-for-collect-a-sequence-of-code-points①">collecting a sequence of code points</a> that are not U+0022 (") or
    U+002C (,) from <var>input</var>, given <var>position</var>, to <var>value</var>. </p>
       <p class="note" role="note">The result might be the empty string. </p>
      <li>
       <p>If <var>position</var> is not past the end of <var>input</var>, then: </p>
       <ol>
        <li>
         <p>If the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point④">code point</a> at <var>position</var> within <var>input</var> is
      U+0022 ("), then: </p>
         <ol>
          <li>
           <p>Append the result of <a data-link-type="dfn" href="#collect-an-http-quoted-string" id="ref-for-collect-an-http-quoted-string">collecting an HTTP quoted string</a> from <var>input</var>,
       given <var>position</var>, to <var>value</var>. </p>
          <li>If <var>position</var> is not past the end of <var>input</var>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue">continue</a>. 
         </ol>
        <li>
         <p>Otherwise: </p>
         <ol>
          <li>
           <p>Assert: the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point⑤">code point</a> at <var>position</var> within <var>input</var> is
       U+002C (,). </p>
          <li>
           <p>Advance <var>position</var> by 1. </p>
         </ol>
       </ol>
      <li>
       <p>Remove all <a data-link-type="dfn" href="#http-tab-or-space" id="ref-for-http-tab-or-space②">HTTP tab or space</a> from the start and end of <var>value</var>. </p>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append">Append</a> <var>value</var> to <var>values</var>. </p>
      <li>
       <p>Set <var>value</var> to the empty string. </p>
     </ol>
    <li>
     <p>Return <var>values</var>. </p>
   </ol>
   <div class="example" id="example-header-list-get-decode-split">
    <a class="self-link" href="#example-header-list-get-decode-split"></a> 
    <p>This is how <a data-link-type="dfn" href="#concept-header-list-get-decode-split" id="ref-for-concept-header-list-get-decode-split①">get, decode, and split</a> functions in practice with `<code>A</code>` as the <var>name</var> argument: </p>
    <table>
     <tbody>
      <tr>
       <th>Headers (as on the network) 
       <th>Output 
      <tr>
       <td>
<pre><code class="lang-http highlight">A: nosniff,
</code></pre>
       <td rowspan="2">« "<code>nosniff</code>", "" » 
      <tr>
       <td>
<pre><code class="lang-http highlight">A: nosniff
B: sniff
A:
</code></pre>
      <tr>
       <td>
<pre><code class="lang-http highlight">A: text/html;", x/x</code></pre>
       <td rowspan="2">« "<code>text/html;", x/x</code>" » 
      <tr>
       <td>
<pre><code class="lang-http highlight">A: text/html;"
A: x/x
</code></pre>
      <tr>
       <td>
<pre><code class="lang-http highlight">A: x/x;test="hi",y/y
</code></pre>
       <td rowspan="2">« "<code>x/x;test="hi"</code>", "<code>y/y</code>" » 
      <tr>
       <td>
<pre><code class="lang-http highlight">A: x/x;test="hi"
C: **bingo**
A: y/y
</code></pre>
      <tr>
       <td>
<pre><code class="lang-http highlight">A: x / x,,,1
</code></pre>
       <td rowspan="2">« "<code>x / x</code>", "", "", "<code>1</code>" » 
      <tr>
       <td>
<pre><code class="lang-http highlight">A: x / x
A: ,
A: 1
</code></pre>
      <tr>
       <td>
<pre><code class="lang-http highlight">A: "1,2", 3
</code></pre>
       <td rowspan="2">« "<code>"1,2"</code>", "<code>3</code>" » 
      <tr>
       <td>
<pre><code class="lang-http highlight">A: "1,2"
D: 4
A: 3
</code></pre>
    </table>
   </div>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-append">append</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑥">name</a>/<a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②">value</a> <var>name</var>/<var>value</var> pair to a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list⑧">header list</a> <var>list</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①">contains</a> <var>name</var>, then set <var>name</var> to the first such <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④">header</a>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑦">name</a>. </p>
     <p class="note no-backref" role="note">This reuses the casing of the <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑧">name</a> of the <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤">header</a> already in <var>list</var>, if any. If there are multiple matched <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥">headers</a> their <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑨">names</a> will all be identical. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append①">Append</a> a new <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑦">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①⓪">name</a> is <var>name</var> and <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③">value</a> is <var>value</var> to <var>list</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-delete">delete</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①①">name</a> <var>name</var> from a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list⑨">header list</a> <var>list</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-remove" id="ref-for-list-remove">remove</a> all <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑧">headers</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①②">name</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive④">byte-case-insensitive</a> match for <var>name</var> from <var>list</var>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-set">set</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①③">name</a>/<a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value④">value</a> <var>name</var>/<var>value</var> pair in a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①⓪">header list</a> <var>list</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②">contains</a> <var>name</var>, then set the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value⑤">value</a> of the first such <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑨">header</a> to <var>value</var> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-remove" id="ref-for-list-remove①">remove</a> the others. </p>
    <li>
     <p>Otherwise, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append②">append</a> a new <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①⓪">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①④">name</a> is <var>name</var> and <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value⑥">value</a> is <var>value</var> to <var>list</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-combine">combine</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①⑤">name</a>/<a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value⑦">value</a> <var>name</var>/<var>value</var> pair in a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①①">header list</a> <var>list</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains③">contains</a> <var>name</var>, then set the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value⑧">value</a> of the first such <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①①">header</a> to its <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value⑨">value</a>,
 followed by 0x2C 0x20, followed by <var>value</var>. </p>
    <li>
     <p>Otherwise, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append③">append</a> a new <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①②">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①⑥">name</a> is <var>name</var> and <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①⓪">value</a> is <var>value</var> to <var>list</var>. </p>
   </ol>
   <p class="note no-backref" role="note"><a data-link-type="dfn" href="#concept-header-list-combine" id="ref-for-concept-header-list-combine">Combine</a> is used by <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest">XMLHttpRequest</a></code> and the <a data-link-type="dfn" href="#concept-websocket-establish" id="ref-for-concept-websocket-establish">WebSocket protocol handshake</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="convert-header-names-to-a-sorted-lowercase-set">convert header names to a sorted-lowercase set</dfn>, given a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list②">list</a> of <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①⑦">names</a> <var>headerNames</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>headerNamesSet</var> be a new <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-set" id="ref-for-ordered-set">ordered set</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate">For each</a> <var>name</var> of <var>headerNames</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#set-append" id="ref-for-set-append">append</a> the result of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-lowercase" id="ref-for-byte-lowercase">byte-lowercasing</a> <var>name</var> to <var>headerNamesSet</var>. </p>
    <li>
     <p>Return the result of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-sort-in-ascending-order" id="ref-for-list-sort-in-ascending-order">sorting</a> <var>headerNamesSet</var> in ascending order
 with <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-less-than" id="ref-for-byte-less-than">byte less than</a>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export id="concept-header-list-sort-and-combine">sort and combine</dfn> a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①②">header list</a> <var>list</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>headers</var> be an empty <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list③">list</a> of <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①⑧">name</a>-<a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①①">value</a> pairs with the key being the <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name①⑨">name</a> and value the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①②">value</a>. </p>
    <li>
     <p>Let <var>names</var> be the result of <a data-link-type="dfn" href="#convert-header-names-to-a-sorted-lowercase-set" id="ref-for-convert-header-names-to-a-sorted-lowercase-set">convert header names to a sorted-lowercase set</a> with all the <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②⓪">names</a> of the <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①③">headers</a> in <var>list</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate①">For each</a> <var>name</var> in <var>names</var>: </p>
     <ol>
      <li>
       <p>Let <var>value</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get②">getting</a> <var>name</var> from <var>list</var>. </p>
      <li>
       <p>Assert: <var>value</var> is not null. </p>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append④">Append</a> <var>name</var>-<var>value</var> to <var>headers</var>. </p>
     </ol>
    <li>
     <p>Return <var>headers</var>. </p>
   </ol>
   <hr>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-header">header</dfn> consists of a <dfn class="dfn-paneled" data-dfn-for="header" data-dfn-type="dfn" data-export id="concept-header-name">name</dfn> and <dfn class="dfn-paneled" data-dfn-for="header" data-dfn-type="dfn" data-export id="concept-header-value">value</dfn>. </p>
   <p>A <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②①">name</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence" id="ref-for-byte-sequence①">byte sequence</a> that matches the <a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.2" id="ref-for-section-3.2">field-name</a> token production. </p>
   <p>A <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①③">value</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence" id="ref-for-byte-sequence②">byte sequence</a> that matches the following conditions: </p>
   <ul class="brief">
    <li>
     <p>Has no leading or trailing <a data-link-type="dfn" href="#http-tab-or-space-byte" id="ref-for-http-tab-or-space-byte①">HTTP tab or space bytes</a>. </p>
    <li>
     <p>Contains no 0x00 (NUL) or <a data-link-type="dfn" href="#http-newline-byte" id="ref-for-http-newline-byte①">HTTP newline bytes</a>. </p>
   </ul>
   <p class="note" role="note">The definition of <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①④">value</a> is not defined in terms of an HTTP token
production as <a href="https://github.com/httpwg/http11bis/issues/19" title="fix field-value ABNF">it is broken</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header/value" data-dfn-type="dfn" data-export id="concept-header-value-normalize">normalize</dfn> a <var>potentialValue</var>, remove any leading and trailing <a data-link-type="dfn" href="#http-whitespace-byte" id="ref-for-http-whitespace-byte">HTTP whitespace bytes</a> from <var>potentialValue</var>. </p>
   <hr>
   <p id="simple-header">To determine whether a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①④">header</a> <var>header</var> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-safelisted-request-header">CORS-safelisted request-header</dfn>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>value</var> be <var>header</var>’s <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①⑤">value</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-lowercase" id="ref-for-byte-lowercase①">Byte-lowercase</a> <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②②">name</a> and switch on the result: </p>
     <dl class="switch">
      <dt>`<code>accept</code>` 
      <dd>
       <p>If <var>value</var> contains a <a data-link-type="dfn" href="#cors-unsafe-request-header-byte" id="ref-for-cors-unsafe-request-header-byte">CORS-unsafe request-header byte</a>, then return false. </p>
      <dt>`<code>accept-language</code>` 
      <dt>`<code>content-language</code>` 
      <dd>
       <p>If <var>value</var> contains a byte that is not in the range 0x30 (0) to 0x39 (9),
   inclusive, is not in the range 0x41 (A) to 0x5A (Z), inclusive, is not in the range 0x61 (a) to
   0x7A (z), inclusive, and is not 0x20 (SP), 0x2A (*), 0x2C (,), 0x2D (-), 0x2E (.), 0x3B (;), or
   0x3D (=), then return false. </p>
      <dt>`<code>content-type</code>` 
      <dd>
       <ol>
        <li>
         <p>If <var>value</var> contains a <a data-link-type="dfn" href="#cors-unsafe-request-header-byte" id="ref-for-cors-unsafe-request-header-byte①">CORS-unsafe request-header byte</a>, then return
     false. </p>
        <li>
         <p>Let <var>mimeType</var> be the result of <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parse-a-mime-type" id="ref-for-parse-a-mime-type①">parsing</a> <var>value</var>. </p>
        <li>
         <p>If <var>mimeType</var> is failure, then return false. </p>
        <li>
         <p>If <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence">essence</a> is not
     "<code>application/x-www-form-urlencoded</code>", "<code>multipart/form-data</code>", or
     "<code>text/plain</code>", then return false. </p>
       </ol>
       <p class="warning">This intentionally does not use <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type">extract a MIME type</a> as that algorithm is
    rather forgiving and servers are not expected to implement it. </p>
       <div class="example no-backref" id="example-cors-safelisted-request-header-content-type">
        <a class="self-link" href="#example-cors-safelisted-request-header-content-type"></a> 
        <p>If <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type①">extract a MIME type</a> were used the following request would not result in a CORS
     preflight and a naïve parser on the server might treat the request body as JSON: </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"https://victim.example/naïve-endpoint"</c-><c- p>,</c-> <c- p>{</c->
  method<c- o>:</c-> <c- u>"POST"</c-><c- p>,</c->
  headers<c- o>:</c-> <c- p>[</c->
    <c- p>[</c-><c- u>"Content-Type"</c-><c- p>,</c-> <c- u>"application/json"</c-><c- p>],</c->
    <c- p>[</c-><c- u>"Content-Type"</c-><c- p>,</c-> <c- u>"text/plain"</c-><c- p>]</c->
  <c- p>],</c->
  credentials<c- o>:</c-> <c- u>"include"</c-><c- p>,</c->
  body<c- o>:</c-> JSON<c- p>.</c->stringify<c- p>(</c->exerciseForTheReader<c- p>)</c->
<c- p>});</c->
</code></pre>
       </div>
      <dt>Otherwise 
      <dd>
       <p>Return false. </p>
     </dl>
    <li>
     <p>If <var>value</var>’s <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence-length" id="ref-for-byte-sequence-length">length</a> is greater than 128, then return
 false. </p>
    <li>
     <p>Return true. </p>
   </ol>
   <p class="note" role="note">There are limited exceptions to the `<code>Content-Type</code>` header safelist, as
documented in <a href="#cors-protocol-exceptions">CORS protocol exceptions</a>. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="cors-unsafe-request-header-byte">CORS-unsafe request-header byte</dfn> is a byte <var>byte</var> for which one of the
following is true: </p>
   <ul class="brief">
    <li>
     <p><var>byte</var> is less than 0x20 and is not 0x09 HT </p>
    <li>
     <p><var>byte</var> is 0x22 ("), 0x28 (left parenthesis), 0x29 (right parenthesis), 0x3A (:),
 0x3C (&lt;), 0x3E (>), 0x3F (?), 0x40 (@), 0x5B ([), 0x5C (\), 0x5D (]), 0x7B ({), 0x7D (}), or
 0x7F DEL. </p>
   </ul>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="cors-unsafe-request-header-names">CORS-unsafe request-header names</dfn>, given a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①③">header list</a> <var>headers</var>, are determined as follows: </p>
   <ol>
    <li>
     <p>Let <var>unsafeNames</var> be a new <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list④">list</a>. </p>
    <li>
     <p>Let <var>potentiallyUnsafeNames</var> be a new <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list⑤">list</a>. </p>
    <li>
     <p>Let <var>safelistValueSize</var> be 0. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate②">For each</a> <var>header</var> of <var>headers</var>: </p>
     <ol>
      <li>
       <p>If <var>header</var> is not a <a data-link-type="dfn" href="#cors-safelisted-request-header" id="ref-for-cors-safelisted-request-header">CORS-safelisted request-header</a>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append⑤">append</a> <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②③">name</a> to <var>unsafeNames</var>. </p>
      <li>
       <p>Otherwise, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append⑥">append</a> <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②④">name</a> to <var>potentiallyUnsafeNames</var> and increase <var>safelistValueSize</var> by <var>header</var>’s <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①⑥">value</a>’s <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence-length" id="ref-for-byte-sequence-length①">length</a>. </p>
     </ol>
    <li>
     <p>If <var>safelistValueSize</var> is greater than 1024, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate③">for each</a> <var>name</var> of <var>potentiallyUnsafeNames</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append⑦">append</a> <var>name</var> to <var>unsafeNames</var>. </p>
    <li>
     <p>Return the result of <a data-link-type="dfn" href="#convert-header-names-to-a-sorted-lowercase-set" id="ref-for-convert-header-names-to-a-sorted-lowercase-set①">convert header names to a sorted-lowercase set</a> with <var>unsafeNames</var>. </p>
   </ol>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-non-wildcard-request-header-name">CORS non-wildcard request-header name</dfn> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive⑤">byte-case-insensitive</a> match
for `<code>Authorization</code>`. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="privileged-no-cors-request-header-name">privileged no-CORS request-header name</dfn> is a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①⑤">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②⑤">name</a> that is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive⑥">byte-case-insensitive</a> match for one of </p>
   <ul class="brief">
    <li>`<code>Range</code>`. 
   </ul>
   <div class="note no-backref" role="note">
    <p>These are headers that can be set by privileged APIs, and will be preserved if their associated
 request object is copied, but will be removed if the request is modified by unprivilaged APIs. </p>
    <p>`<code>Range</code>` headers are commonly used by <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/links.html#downloading-hyperlinks" id="ref-for-downloading-hyperlinks">downloads</a> and <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/media.html#concept-media-load-resource" id="ref-for-concept-media-load-resource">media fetches</a>, although neither of these currently specify
 how. <a href="https://github.com/whatwg/html/pull/2814">html/2914</a> aims to solve this. </p>
    <p>A helper is provided to <a data-link-type="dfn" href="#concept-request-add-range-header" id="ref-for-concept-request-add-range-header">add a range header</a> to a particular request. </p>
   </div>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-safelisted-response-header-name">CORS-safelisted response-header name</dfn>, given a <a data-link-type="dfn" href="#concept-response-cors-exposed-header-name-list" id="ref-for-concept-response-cors-exposed-header-name-list">CORS-exposed header-name list</a> <var>list</var>, is a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①⑥">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②⑥">name</a> that is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive⑦">byte-case-insensitive</a> match for one of </p>
   <ul class="brief">
    <li>`<code>Cache-Control</code>` 
    <li>`<code>Content-Language</code>` 
    <li>`<code>Content-Length</code>` 
    <li>`<code>Content-Type</code>` 
    <li>`<code>Expires</code>` 
    <li>`<code>Last-Modified</code>` 
    <li>`<code>Pragma</code>` 
    <li>Any <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①⑦">value</a> in <var>list</var> that is not a <a data-link-type="dfn" href="#forbidden-response-header-name" id="ref-for-forbidden-response-header-name">forbidden response-header name</a>. 
   </ul>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="no-cors-safelisted-request-header-name">no-CORS-safelisted request-header name</dfn> is a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①⑦">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②⑦">name</a> that is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive⑧">byte-case-insensitive</a> match for one of </p>
   <ul class="brief">
    <li>`<code>Accept</code>` 
    <li>`<code>Accept-Language</code>` 
    <li>`<code>Content-Language</code>` 
    <li>`<code>Content-Type</code>` 
   </ul>
   <p>To determine whether a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①⑧">header</a> <var>header</var> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="no-cors-safelisted-request-header">no-CORS-safelisted request-header</dfn>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②⑧">name</a> is not a <a data-link-type="dfn" href="#no-cors-safelisted-request-header-name" id="ref-for-no-cors-safelisted-request-header-name">no-CORS-safelisted request-header name</a>, then return false. </p>
    <li>
     <p>Return whether <var>header</var> is a <a data-link-type="dfn" href="#cors-safelisted-request-header" id="ref-for-cors-safelisted-request-header①">CORS-safelisted request-header</a>. </p>
   </ol>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="forbidden-header-name">forbidden header name</dfn> is a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header①⑨">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name②⑨">name</a> that
is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive⑨">byte-case-insensitive</a> match for one of </p>
   <ul class="brief">
    <li>`<code>Accept-Charset</code>` 
    <li>`<code>Accept-Encoding</code>` 
    <li>`<a data-link-type="http-header" href="#http-access-control-request-headers" id="ref-for-http-access-control-request-headers"><code>Access-Control-Request-Headers</code></a>` 
    <li>`<a data-link-type="http-header" href="#http-access-control-request-method" id="ref-for-http-access-control-request-method"><code>Access-Control-Request-Method</code></a>` 
    <li>`<code>Connection</code>` 
    <li>`<code>Content-Length</code>` 
    <li>`<code>Cookie</code>` 
    <li>`<code>Cookie2</code>` 
    <li>`<code>Date</code>` 
    <li>`<code>DNT</code>` 
    <li>`<code>Expect</code>` 
    <li>`<code>Host</code>` 
    <li>`<code>Keep-Alive</code>` 
    <li>`<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin①"><code>Origin</code></a>` 
    <li>`<code>Referer</code>` 
    <li>`<code>TE</code>` 
    <li>`<code>Trailer</code>` 
    <li>`<code>Transfer-Encoding</code>` 
    <li>`<code>Upgrade</code>` 
    <li>`<code>Via</code>` 
   </ul>
   <p>or a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②⓪">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③⓪">name</a> that
starts with a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①⓪">byte-case-insensitive</a> match for `<code>Proxy-</code>` or `<code>Sec-</code>`
(including being a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①①">byte-case-insensitive</a> match for just `<code>Proxy-</code>` or
`<code>Sec-</code>`). </p>
   <p class="note" role="note">These are forbidden so the user agent remains in full control over them. <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③①">Names</a> starting with `<code>Sec-</code>` are
reserved to allow new <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②①">headers</a> to be minted that are safe
from APIs using <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①">fetch</a> that allow control over <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②②">headers</a> by developers, such as <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest①">XMLHttpRequest</a></code>. <a data-link-type="biblio" href="#biblio-xhr">[XHR]</a> </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="forbidden-response-header-name">forbidden response-header name</dfn> is a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②③">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③②">name</a> that is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①②">byte-case-insensitive</a> match for one of: </p>
   <ul class="brief">
    <li>`<code>Set-Cookie</code>` 
    <li>`<code>Set-Cookie2</code>` 
   </ul>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="request-body-header-name">request-body-header name</dfn> is a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②④">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③③">name</a> that
is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①③">byte-case-insensitive</a> match for one of: </p>
   <ul class="brief">
    <li>`<code>Content-Encoding</code>` 
    <li>`<code>Content-Language</code>` 
    <li>`<code>Content-Location</code>` 
    <li>`<code>Content-Type</code>` 
   </ul>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="extract header values|extracting header values" id="extract-header-values">extract header values</dfn> given a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②⑤">header</a> <var>header</var>, run these steps: </p>
   <ol>
    <li>
     <p>If parsing <var>header</var>’s <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①⑧">value</a>, per the <a data-link-type="dfn" href="#abnf" id="ref-for-abnf">ABNF</a> for <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③④">name</a>, fails, then return failure. </p>
    <li>
     <p>Return one or more <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value①⑨">values</a> resulting from parsing <var>header</var>’s <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②⓪">value</a>, per the <a data-link-type="dfn" href="#abnf" id="ref-for-abnf①">ABNF</a> for <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③⑤">name</a>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="extract header list values|extracting header list values" id="extract-header-list-values">extract header list values</dfn> given a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③⑥">name</a> <var>name</var> and a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①④">header list</a> <var>list</var>,
run these steps: </p>
   <ol>
    <li>
     <p>If <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains④">does not contain</a> <var>name</var>, then return
 null. </p>
    <li>
     <p>If the <a data-link-type="dfn" href="#abnf" id="ref-for-abnf②">ABNF</a> for <var>name</var> allows a single <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②⑥">header</a> and <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains⑤">contains</a> more than one, then return failure. </p>
     <p class="note no-backref" role="note">If different error handling is needed, extract the desired <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②⑦">header</a> first. </p>
    <li>
     <p>Let <var>values</var> be an empty <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list⑥">list</a>. </p>
    <li>
     <p>For each <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②⑧">header</a> <var>header</var> <var>list</var> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains⑥">contains</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③⑦">name</a> is <var>name</var>: </p>
     <ol>
      <li>
       <p>Let <var>extract</var> be the result of <a data-link-type="dfn" href="#extract-header-values" id="ref-for-extract-header-values">extracting header values</a> from <var>header</var>. </p>
      <li>
       <p>If <var>extract</var> is failure, then return failure. </p>
      <li>
       <p>Append each <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②①">value</a> in <var>extract</var>, in order, to <var>values</var>. </p>
     </ol>
    <li>
     <p>Return <var>values</var>. </p>
   </ol>
   <hr>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="default-user-agent-value">default `<code>User-Agent</code>` value</dfn> is a
user-agent-defined <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②②">value</a> for the
`<code>User-Agent</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header②⑨">header</a>. </p>
   <h4 class="heading settled" data-level="2.2.3" id="statuses"><span class="secno">2.2.3. </span><span class="content">Statuses</span><a class="self-link" href="#statuses"></a></h4>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-status">status</dfn> is a code. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="null-body-status">null body status</dfn> is a <a data-link-type="dfn" href="#concept-status" id="ref-for-concept-status">status</a> that is <code>101</code>, <code>204</code>, <code>205</code>, or <code>304</code>. </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="ok-status">ok status</dfn> is any <a data-link-type="dfn" href="#concept-status" id="ref-for-concept-status①">status</a> in the range <code>200</code> to <code>299</code>, inclusive. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="redirect-status">redirect status</dfn> is a <a data-link-type="dfn" href="#concept-status" id="ref-for-concept-status②">status</a> that is <code>301</code>, <code>302</code>, <code>303</code>, <code>307</code>, or <code>308</code>. </p>
   <h4 class="heading settled" data-level="2.2.4" id="bodies"><span class="secno">2.2.4. </span><span class="content">Bodies</span><a class="self-link" href="#bodies"></a></h4>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-body">body</dfn> consists of: </p>
   <ul>
    <li>
     <p>A <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-stream">stream</dfn> (null or a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream">ReadableStream</a></code> object). </p>
    <li>
     <p>A <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-transmitted">transmitted bytes</dfn> (an integer), initially 0. </p>
    <li>
     <p>A <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-total-bytes">total bytes</dfn> (an
 integer), initially 0. </p>
    <li>
     <p>A <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-source">source</dfn>, initially null. </p>
   </ul>
   <p>A <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body">body</a> <var>body</var> is said to be <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-done">done</dfn> if <var>body</var> is null or <var>body</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream">stream</a> is <a data-link-type="dfn" href="#concept-readablestream-closed" id="ref-for-concept-readablestream-closed">closed</a> or <a data-link-type="dfn" href="#concept-readablestream-errored" id="ref-for-concept-readablestream-errored">errored</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-wait">wait</dfn> for a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body①">body</a> <var>body</var>, wait for <var>body</var> to be <a data-link-type="dfn" href="#concept-body-done" id="ref-for-concept-body-done">done</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="body" data-dfn-type="dfn" data-export id="concept-body-clone">clone</dfn> a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body②">body</a> <var>body</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let «<var>out1</var>, <var>out2</var>» be the result of <a data-link-type="dfn" href="#concept-tee-readablestream" id="ref-for-concept-tee-readablestream">teeing</a> <var>body</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①">stream</a>. </p>
    <li>
     <p>Set <var>body</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream②">stream</a> to <var>out1</var>. </p>
    <li>
     <p>Return a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body③">body</a> whose <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream③">stream</a> is <var>out2</var> and other members are copied from <var>body</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="handle-content-codings">handle content codings</dfn> given <var>codings</var> and <var>bytes</var>, run
these steps: </p>
   <ol>
    <li>
     <p>If <var>codings</var> are not supported, then return <var>bytes</var>. </p>
    <li>
     <p>Return the result of decoding <var>bytes</var> with <var>codings</var> as explained in HTTP,
 if decoding does not result in an error, and failure otherwise. <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-http-semantics">[HTTP-SEMANTICS]</a> </p>
   </ol>
   <h4 class="heading settled" data-level="2.2.5" id="requests"><span class="secno">2.2.5. </span><span class="content">Requests</span><a class="self-link" href="#requests"></a></h4>
   <p>The input to <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②">fetch</a> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-request">request</dfn>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-method">method</dfn> (a <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method⑤">method</a>). Unless stated otherwise it is
`<code>GET</code>`. </p>
   <p class="note no-backref" role="note">This can be updated during redirects to `<code>GET</code>` as
described in <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch">HTTP fetch</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-url">URL</dfn> (a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url②">URL</a>). </p>
   <p class="note no-backref" role="note">Implementations are encouraged to make this a pointer to the first <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url③">URL</a> in <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③">request</a>’s <a data-link-type="dfn" href="#concept-request-url-list" id="ref-for-concept-request-url-list">URL list</a>. It is provided as a distinct
field solely for the convenience of other standards hooking into Fetch. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④">request</a> has an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="local-urls-only-flag">local-URLs-only flag</dfn>. Unless stated otherwise it is
unset. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-header-list">header list</dfn> (a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①⑤">header list</a>). Unless stated otherwise it is empty. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="unsafe-request-flag">unsafe-request flag</dfn>. Unless stated otherwise it
is unset. </p>
   <p class="note no-backref" role="note">The <a data-link-type="dfn" href="#unsafe-request-flag" id="ref-for-unsafe-request-flag">unsafe-request flag</a> is set by APIs such as <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch①"><code>fetch()</code></a> and <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest②">XMLHttpRequest</a></code> to ensure a <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0">CORS-preflight fetch</a> is done based on the supplied <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method">method</a> and <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list">header list</a>. It does not free an API from
outlawing <a data-link-type="dfn" href="#forbidden-method" id="ref-for-forbidden-method">forbidden methods</a> and <a data-link-type="dfn" href="#forbidden-header-name" id="ref-for-forbidden-header-name">forbidden header names</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-body">body</dfn> (null or a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body④">body</a>). Unless stated otherwise it is null. </p>
   <p class="note no-backref" role="note">This can be updated during redirects to null as described in <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch①">HTTP fetch</a>. </p>
   <hr>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-client">client</dfn> (null or an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object①">environment settings object</a>). </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-reserved-client">reserved client</dfn> (null, an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment" id="ref-for-environment">environment</a>, or an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object②">environment settings object</a>). Unless stated otherwise it is null. </p>
   <p class="note no-backref" role="note">This is only used by <a data-link-type="dfn" href="#navigation-request" id="ref-for-navigation-request">navigation requests</a> and worker
requests, but not service worker requests. It references an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment" id="ref-for-environment①">environment</a> for a <a data-link-type="dfn" href="#navigation-request" id="ref-for-navigation-request①">navigation request</a> and an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object③">environment settings object</a> for a worker request. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪">request</a> has an associated <dfn data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-replaces-client-id">replaces client id<a class="self-link" href="#concept-request-replaces-client-id"></a></dfn> (a string). Unless stated otherwise it is the empty string. </p>
   <p class="note no-backref" role="note">This is only used by <a data-link-type="dfn" href="#navigation-request" id="ref-for-navigation-request②">navigation requests</a>. It is the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-id" id="ref-for-concept-environment-id">id</a> of the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-target-browsing-context" id="ref-for-concept-environment-target-browsing-context">target browsing context</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document">active document</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object④">environment settings object</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①①">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-window">window</dfn> ("<code>no-window</code>", "<code>client</code>", or an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object⑤">environment settings object</a> whose <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global" id="ref-for-concept-settings-object-global">global object</a> is a <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window">Window</a></code> object). Unless stated otherwise it is
"<code>client</code>". </p>
   <p class="note no-backref" role="note">The "<code>client</code>" value is changed to "<code>no-window</code>" or <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①②">request</a>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client②">client</a> during <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch③">fetching</a>. It provides a convenient way for standards to not have to
explicitly set <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①③">request</a>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window">window</a>. </p>
   <p id="keep-alive-flag">A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①④">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="request-keepalive-flag">keepalive flag</dfn>. Unless stated otherwise it is unset. </p>
   <p class="note no-backref" role="note">This can be used to allow the request to outlive the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object⑥">environment settings object</a>, e.g., <code>navigator.sendBeacon</code> and the HTML <code>img</code> element set this flag. Requests with
this flag set are subject to additional processing requirements. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⑤">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="request-service-workers-mode">service-workers mode</dfn>, that
is "<code>all</code>" or "<code>none</code>". Unless stated otherwise it is "<code>all</code>". </p>
   <div class="note" role="note">
    <p>This determines which service workers will receive a <code class="idl"><a class="idl-code" data-link-type="event" href="https://w3c.github.io/ServiceWorker/#service-worker-global-scope-fetch-event" id="ref-for-service-worker-global-scope-fetch-event">fetch</a></code> event for this fetch. </p>
    <dl>
     <dt>"<code>all</code>" 
     <dd>Relevant service workers will get a <code class="idl"><a class="idl-code" data-link-type="event" href="https://w3c.github.io/ServiceWorker/#service-worker-global-scope-fetch-event" id="ref-for-service-worker-global-scope-fetch-event①">fetch</a></code> event for this fetch. 
     <dt>"<code>none</code>" 
     <dd>No service workers will get events for this fetch. 
    </dl>
   </div>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⑥">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-initiator">initiator</dfn>, which is
the empty string,
"<code>download</code>",
"<code>imageset</code>",
"<code>manifest</code>",
"<code>prefetch</code>",
"<code>prerender</code>", or
"<code>xslt</code>". Unless stated otherwise it is the empty string. </p>
   <p class="note no-backref" role="note">A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⑦">request</a>’s <a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator">initiator</a> is not particularly granular for
the time being as other specifications do not require it to be. It is primarily a
specification device to assist defining CSP and Mixed Content. It is not exposed to
JavaScript. <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> <a data-link-type="biblio" href="#biblio-mix">[MIX]</a> </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⑧">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-destination">destination</dfn>, which is
the empty string,
"<code>audio</code>",
"<code>audioworklet</code>",
"<code>document</code>",
"<code>embed</code>",
"<code>font</code>",
"<code>image</code>",
"<code>manifest</code>",
"<code>object</code>",
"<code>paintworklet</code>",
"<code>report</code>",
"<code>script</code>",
"<code>serviceworker</code>",
"<code>sharedworker</code>",
"<code>style</code>",
"<code>track</code>",
"<code>video</code>",
"<code>worker</code>", or
"<code>xslt</code>". Unless stated otherwise it is the empty string. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⑨">request</a>’s <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination">destination</a> is <dfn class="dfn-paneled" data-dfn-for="request/destination" data-dfn-type="dfn" data-export id="request-destination-script-like">script-like</dfn> if it is "<code>audioworklet</code>",
"<code>paintworklet</code>", "<code>script</code>", "<code>serviceworker</code>",
"<code>sharedworker</code>", or "<code>worker</code>". </p>
   <p class="warning">Algorithms that use <a data-link-type="dfn" href="#request-destination-script-like" id="ref-for-request-destination-script-like">script-like</a> should also consider
"<code>xslt</code>" as that too can cause script execution. It is not included in the list as it is
not always relevant and might require different behavior. </p>
   <div class="note" role="note">
    <p>The following table illustrates the relationship between a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②⓪">request</a>’s <a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator①">initiator</a>, <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①">destination</a>, CSP directives, and features. It is
 not exhaustive with respect to features. Features need to have the relevant values defined in their
 respective standards. </p>
    <table>
     <tbody>
      <tr>
       <th><a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator②">Initiator</a> 
       <th><a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination②">Destination</a> 
       <th>CSP directive 
       <th>Features 
      <tr>
       <td rowspan="18">"" 
       <td>"<code>report</code>" 
       <td rowspan="2">— 
       <td>CSP, NEL reports. 
      <tr>
       <td>"<code>document</code>" 
       <td>HTML’s navigate algorithm. 
      <tr>
       <td>"<code>document</code>" 
       <td><code>child-src</code> 
       <td>HTML’s <code>&lt;iframe></code> and <code>&lt;frame></code> 
      <tr>
       <td>"" 
       <td><code>connect-src</code> 
       <td><code>navigator.sendBeacon()</code>, <code>EventSource</code>,
   HTML’s <code>&lt;a ping=""></code> and <code>&lt;area ping=""></code>, <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch②"><code>fetch()</code></a>, <code>XMLHttpRequest</code>, <code>WebSocket</code>, Cache API 
      <tr>
       <td>"<code>object</code>" 
       <td><code>object-src</code> 
       <td>HTML’s <code>&lt;object></code> 
      <tr>
       <td>"<code>embed</code>" 
       <td><code>object-src</code> 
       <td>HTML’s <code>&lt;embed></code> 
      <tr>
       <td>"<code>audio</code>" 
       <td><code>media-src</code> 
       <td>HTML’s <code>&lt;audio></code> 
      <tr>
       <td>"<code>font</code>" 
       <td><code>font-src</code> 
       <td>CSS' <code>@font-face</code> 
      <tr>
       <td>"<code>image</code>" 
       <td><code>img-src</code> 
       <td>HTML’s <code>&lt;img src></code>, <code>/favicon.ico</code> resource,
   SVG’s <code>&lt;image></code>, CSS' <code>background-image</code>, CSS' <code>cursor</code>, CSS' <code>list-style-image</code>, … 
      <tr>
       <td>"<code>audioworklet</code>" 
       <td><code>script-src</code> 
       <td><code>audioWorklet.addModule()</code> 
      <tr>
       <td>"<code>paintworklet</code>" 
       <td><code>script-src</code> 
       <td><code>CSS.paintWorklet.addModule()</code> 
      <tr>
       <td>"<code>script</code>" 
       <td><code>script-src</code> 
       <td>HTML’s <code>&lt;script></code>, <code>importScripts()</code> 
      <tr>
       <td>"<code>serviceworker</code>" 
       <td><code>child-src</code>, <code>script-src</code>, <code>worker-src</code> 
       <td><code>navigator.serviceWorker.register()</code> 
      <tr>
       <td>"<code>sharedworker</code>" 
       <td><code>child-src</code>, <code>script-src</code>, <code>worker-src</code> 
       <td><code>SharedWorker</code> 
      <tr>
       <td>"<code>worker</code>" 
       <td><code>child-src</code>, <code>script-src</code>, <code>worker-src</code> 
       <td><code>Worker</code> 
      <tr>
       <td>"<code>style</code>" 
       <td><code>style-src</code> 
       <td>HTML’s <code>&lt;link rel=stylesheet></code>, CSS' <code>@import</code> 
      <tr>
       <td>"<code>track</code>" 
       <td><code>media-src</code> 
       <td>HTML’s <code>&lt;track></code> 
      <tr>
       <td>"<code>video</code>" 
       <td><code>media-src</code> 
       <td>HTML’s <code>&lt;video></code> element 
      <tr>
       <td>"<code>download</code>" 
       <td>"" 
       <td>— 
       <td>HTML’s <code>download=""</code>, "Save Link As…" UI 
      <tr>
       <td>"<code>imageset</code>" 
       <td>"<code>image</code>" 
       <td><code>img-src</code> 
       <td>HTML’s <code>&lt;img srcset></code> and <code>&lt;picture></code> 
      <tr>
       <td>"<code>manifest</code>" 
       <td>"<code>manifest</code>" 
       <td><code>manifest-src</code> 
       <td>HTML’s <code>&lt;link rel=manifest></code> 
      <tr>
       <td>"<code>prefetch</code>" 
       <td rowspan="2">"" 
       <td rowspan="2"><code>prefetch-src</code> 
       <td>HTML’s <code>&lt;link rel=prefetch></code> 
      <tr>
       <td>"<code>prerender</code>" 
       <td>HTML’s <code>&lt;link rel=prerender></code> 
      <tr>
       <td>"<code>xslt</code>" 
       <td>"<code>xslt</code>" 
       <td><code>script-src</code> 
       <td><code>&lt;?xml-stylesheet></code> 
    </table>
    <p>CSP’s <code>form-action</code> needs to be a hook directly in HTML’s navigate or form
 submission algorithm. </p>
    <p>CSP will also need to check <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②①">request</a>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client③">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context">responsible browsing context</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#ancestor-browsing-context" id="ref-for-ancestor-browsing-context">ancestor browsing contexts</a> for various CSP directives. </p>
   </div>
   <hr>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②②">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-priority">priority</dfn> (null or a
user-agent-defined object). Unless otherwise stated it is null. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②③">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-origin">origin</dfn>, which is
"<code>client</code>" or an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin">origin</a>. Unless stated otherwise it is
"<code>client</code>". </p>
   <p class="note no-backref" role="note">"<code>client</code>" is changed to an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin①">origin</a> during <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch④">fetching</a>. It provides a convenient way for standards to not have to set <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②④">request</a>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin">origin</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②⑤">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-referrer">referrer</dfn>, which is
"<code>no-referrer</code>", "<code>client</code>", or a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url④">URL</a>. Unless stated otherwise it
is "<code>client</code>". </p>
   <p class="note no-backref" role="note">"<code>client</code>" is changed to "<code>no-referrer</code>" or a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url⑤">URL</a> during <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch⑤">fetching</a>. It provides a convenient way for standards
to not have to set <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②⑥">request</a>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer">referrer</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②⑦">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-referrer-policy">referrer policy</dfn>, which is a <a data-link-type="dfn" href="https://w3c.github.io/webappsec-referrer-policy/#referrer-policy" id="ref-for-referrer-policy">referrer policy</a>. Unless stated otherwise it is the empty string. <a data-link-type="biblio" href="#biblio-referrer">[REFERRER]</a> </p>
   <p class="note no-backref" role="note">This can be used to override a referrer policy associated with an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object⑦">environment settings object</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②⑧">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="synchronous-flag">synchronous flag</dfn>. Unless stated otherwise it is
unset. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request②⑨">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-mode">mode</dfn>, which is
"<code>same-origin</code>", "<code>cors</code>", "<code>no-cors</code>",
"<code>navigate</code>", or "<code>websocket</code>". Unless stated otherwise, it is
"<code>no-cors</code>". </p>
   <div class="note no-backref" role="note">
    <dl>
     <dt>"<code>same-origin</code>" 
     <dd>Used to ensure requests are made to same-origin URLs. <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch⑥">Fetch</a> will return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error">network error</a> if the request is not made to a same-origin URL. 
     <dt>"<code>cors</code>" 
     <dd>Makes the request a <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request">CORS request</a>. Fetch will return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①">network error</a> if the
  requested resource does not understand the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol">CORS protocol</a>. 
     <dt>"<code>no-cors</code>" 
     <dd>Restricts requests to using <a data-link-type="dfn" href="#cors-safelisted-method" id="ref-for-cors-safelisted-method">CORS-safelisted methods</a> and <a data-link-type="dfn" href="#cors-safelisted-request-header" id="ref-for-cors-safelisted-request-header②">CORS-safelisted request-headers</a>. Upon success, fetch will return an <a data-link-type="dfn" href="#concept-filtered-response-opaque" id="ref-for-concept-filtered-response-opaque">opaque filtered response</a>. 
     <dt>"<code>navigate</code>" 
     <dd>This is a special mode used only when <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsing-the-web.html#navigate" id="ref-for-navigate">navigating</a> between documents. 
     <dt>"<code>websocket</code>" 
     <dd>This is a special mode used only when <a data-link-type="dfn" href="#concept-websocket-establish" id="ref-for-concept-websocket-establish①">establishing
  a WebSocket connection</a>. 
    </dl>
    <p>Even though the default <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③⓪">request</a> <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode">mode</a> is "<code>no-cors</code>",
 standards are highly discouraged from using it for new features. It is rather unsafe. </p>
   </div>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③①">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="use-cors-preflight-flag">use-CORS-preflight flag</dfn>. Unless stated
otherwise, it is unset. </p>
   <p class="note no-backref" role="note">The <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag">use-CORS-preflight flag</a> being set is one of several conditions
that results in a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request">CORS-preflight request</a>. The <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag①">use-CORS-preflight flag</a> is set if either
one or more event listeners are registered on an <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequestupload" id="ref-for-xmlhttprequestupload">XMLHttpRequestUpload</a></code> object or if a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①">ReadableStream</a></code> object is used in a request. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③②">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-credentials-mode">credentials mode</dfn>,
which is "<code>omit</code>", "<code>same-origin</code>", or
"<code>include</code>". Unless stated otherwise, it is "<code>omit</code>". </p>
   <div class="note no-backref" role="note">
    <dl>
     <dt>"<code>omit</code>" 
     <dd>Excludes credentials from this request. 
     <dt>"<code>same-origin</code>" 
     <dd>Include credentials with requests made to same-origin URLs. 
     <dt>"<code>include</code>" 
     <dd>Always includes credentials with this request. 
    </dl>
    <p><a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③③">Request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode">credentials mode</a> controls the flow of <a data-link-type="dfn" href="#credentials" id="ref-for-credentials">credentials</a> during a <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch⑦">fetch</a>. When <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③④">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①">mode</a> is "<code>navigate</code>", its <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①">credentials mode</a> is
 assumed to be "<code>include</code>" and <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch⑧">fetch</a> does not currently account for other
 values. If <cite>HTML</cite> changes here, this standard will need corresponding changes. </p>
   </div>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③⑤">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-use-url-credentials-flag">use-URL-credentials flag</dfn>.
Unless stated otherwise, it is unset. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③⑥">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-cache-mode">cache mode</dfn>, which is
"<code>default</code>", "<code>no-store</code>", "<code>reload</code>",
"<code>no-cache</code>", "<code>force-cache</code>", or
"<code>only-if-cached</code>". Unless stated otherwise, it is "<code>default</code>". </p>
   <div class="note no-backref" role="note">
    <dl>
     <dt>"<code>default</code>" 
     <dd><a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch⑨">Fetch</a> will inspect the HTTP cache on the way to the network. If the HTTP cache
  contains a matching <a data-link-type="dfn" href="#concept-fresh-response" id="ref-for-concept-fresh-response">fresh response</a> it will be returned. If the HTTP cache contains a
  matching <a data-link-type="dfn" href="#concept-stale-while-revalidate-response" id="ref-for-concept-stale-while-revalidate-response">stale-while-revalidate response</a> it will be returned, and a conditional network
  fetch will be made to update the entry in the HTTP cache. If the HTTP cache contains a matching <a data-link-type="dfn" href="#concept-stale-response" id="ref-for-concept-stale-response">stale response</a>, a conditional network fetch will be returned to update the entry in
  the HTTP cache. Otherwise, a non-conditional network fetch will be returned to update the entry
  in the HTTP cache. <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-http-semantics">[HTTP-SEMANTICS]</a> <a data-link-type="biblio" href="#biblio-http-cond">[HTTP-COND]</a> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> <a data-link-type="biblio" href="#biblio-stale-while-revalidate">[STALE-WHILE-REVALIDATE]</a> 
     <dt>"<code>no-store</code>" 
     <dd>Fetch behaves as if there is no HTTP cache at all. 
     <dt>"<code>reload</code>" 
     <dd>Fetch behaves as if there is no HTTP cache on the way to the network. Ergo, it creates a
  normal request and updates the HTTP cache with the response. 
     <dt>"<code>no-cache</code>" 
     <dd>Fetch creates a conditional request if there is a response in the HTTP cache and a normal
  request otherwise. It then updates the HTTP cache with the response. 
     <dt>"<code>force-cache</code>" 
     <dd>Fetch uses any response in the HTTP cache matching the request, not paying attention to
  staleness. If there was no response, it creates a normal request and updates the HTTP cache with
  the response. 
     <dt>"<code>only-if-cached</code>" 
     <dd>Fetch uses any response in the HTTP cache matching the request, not paying attention to
  staleness. If there was no response, it returns a network error. (Can only be used when <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③⑦">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode②">mode</a> is
  "<code>same-origin</code>". Any cached redirects will be followed assuming <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③⑧">request</a>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode">redirect mode</a> is "<code>follow</code>" and the
  redirects do not violate <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request③⑨">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode③">mode</a>.) 
    </dl>
    <p>If <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains⑦">contains</a> `<code>If-Modified-Since</code>`,
 `<code>If-None-Match</code>`,
 `<code>If-Unmodified-Since</code>`,
 `<code>If-Match</code>`, or
 `<code>If-Range</code>`, <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①⓪">fetch</a> will set <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode">cache mode</a> to "<code>no-store</code>" if it is
 "<code>default</code>". </p>
   </div>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④⓪">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-redirect-mode">redirect mode</dfn>, which is
"<code>follow</code>", "<code>error</code>", or "<code>manual</code>".
Unless stated otherwise, it is "<code>follow</code>". </p>
   <div class="note no-backref" role="note">
    <dl>
     <dt>"<code>follow</code>" 
     <dd>Follow all redirects incurred when fetching a resource. 
     <dt>"<code>error</code>" 
     <dd>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②">network error</a> when a request is met with a redirect. 
     <dt>"<code>manual</code>" 
     <dd>Retrieves an <a data-link-type="dfn" href="#concept-filtered-response-opaque-redirect" id="ref-for-concept-filtered-response-opaque-redirect">opaque-redirect filtered response</a> when a request is met with a redirect,
  to allow a service worker to replay the redirect offline. The response is otherwise
  indistinguishable from a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③">network error</a>, to not violate <a data-link-type="dfn" href="#atomic-http-redirect-handling" id="ref-for-atomic-http-redirect-handling">atomic HTTP redirect handling</a>. 
    </dl>
   </div>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④①">request</a> has associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-integrity-metadata">integrity metadata</dfn> (a string). Unless stated otherwise, it is the empty string. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④②">request</a> has associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-nonce-metadata">cryptographic nonce metadata</dfn> (a string). Unless stated otherwise, it is the empty string. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④③">request</a> has associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-parser-metadata">parser metadata</dfn> which is the empty string, "<code>parser-inserted</code>", or
"<code>not-parser-inserted</code>". Unless otherwise stated, it is the empty string. </p>
   <p class="note no-backref" role="note">A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④④">request</a>’s <a data-link-type="dfn" href="#concept-request-nonce-metadata" id="ref-for-concept-request-nonce-metadata">cryptographic nonce metadata</a> and <a data-link-type="dfn" href="#concept-request-parser-metadata" id="ref-for-concept-request-parser-metadata">parser metadata</a> are generally populated from attributes and flags on the HTML
element responsible for creating a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④⑤">request</a>. They are used by various algorithms in <cite>Content Security Policy</cite> to determine whether requests or responses are to be blocked in
a given context. <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④⑥">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-reload-navigation-flag">reload-navigation flag</dfn>.
Unless stated otherwise, it is unset. </p>
   <p class="note no-backref" role="note">This flag is for exclusive use by HTML’s navigate algorithm. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④⑦">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-history-navigation-flag">history-navigation flag</dfn>.
Unless stated otherwise, it is unset. </p>
   <p class="note no-backref" role="note">This flag is for exclusive use by HTML’s navigate algorithm. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <hr>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④⑧">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-noexport id="concept-request-tainted-origin">tainted origin flag</dfn>. Unless stated
otherwise, it is unset. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request④⑨">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-url-list">URL list</dfn> (a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list⑦">list</a> of one or
more <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url⑥">URLs</a>). Unless stated otherwise, it is a list containing a copy of <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤⓪">request</a>’s <a data-link-type="dfn" href="#concept-request-url" id="ref-for-concept-request-url">URL</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤①">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-current-url">current URL</dfn>. It is a pointer to the
last <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url⑦">URL</a> in <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤②">request</a>’s <a data-link-type="dfn" href="#concept-request-url-list" id="ref-for-concept-request-url-list①">URL list</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤③">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-redirect-count">redirect count</dfn>.
Unless stated otherwise, it is zero. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤④">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-response-tainting">response tainting</dfn>,
which is "<code>basic</code>", "<code>cors</code>", or "<code>opaque</code>".
Unless stated otherwise, it is "<code>basic</code>". </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤⑤">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="no-cache-prevent-cache-control">prevent no-cache cache-control header modification flag</dfn>.
Unless stated otherwise, it is unset. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤⑥">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="done-flag">done flag</dfn>.
Unless stated otherwise, it is unset. </p>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤⑦">request</a> has an associated <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="timing-allow-failed">timing allow failed flag</dfn>. Unless stated
otherwise, it is unset. </p>
   <p class="note no-backref" role="note">A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤⑧">request</a>’s <a data-link-type="dfn" href="#concept-request-tainted-origin" id="ref-for-concept-request-tainted-origin">tainted origin flag</a>, <a data-link-type="dfn" href="#concept-request-url-list" id="ref-for-concept-request-url-list②">URL list</a>, <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url">current URL</a>, <a data-link-type="dfn" href="#concept-request-redirect-count" id="ref-for-concept-request-redirect-count">redirect count</a>, <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting">response tainting</a>, <a data-link-type="dfn" href="#done-flag" id="ref-for-done-flag">done flag</a>, and <a data-link-type="dfn" href="#timing-allow-failed" id="ref-for-timing-allow-failed">timing allow failed flag</a> are used as bookkeeping details by the <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①①">fetch</a> algorithm. </p>
   <hr>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="subresource-request">subresource request</dfn> is a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑤⑨">request</a> whose <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination③">destination</a> is "<code>audio</code>", "<code>audioworklet</code>",
"<code>font</code>", "<code>image</code>", "<code>manifest</code>", "<code>paintworklet</code>",
"<code>script</code>", "<code>style</code>", "<code>track</code>", "<code>video</code>",
"<code>xslt</code>", or the empty string. </p>
   <p>A <dfn data-dfn-type="dfn" data-export id="potential-navigation-or-subresource-request">potential-navigation-or-subresource request<a class="self-link" href="#potential-navigation-or-subresource-request"></a></dfn> is a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥⓪">request</a> whose <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination④">destination</a> is
"<code>object</code>" or "<code>embed</code>". </p>
   <p>A <dfn data-dfn-type="dfn" data-export id="non-subresource-request">non-subresource request<a class="self-link" href="#non-subresource-request"></a></dfn> is a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥①">request</a> whose <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination⑤">destination</a> is "<code>document</code>",
"<code>report</code>", "<code>serviceworker</code>", "<code>sharedworker</code>",
or "<code>worker</code>". </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="navigation-request">navigation request</dfn> is a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥②">request</a> whose <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination⑥">destination</a> is
"<code>document</code>". </p>
   <p class="note" role="note">See <a data-link-type="dfn" href="https://w3c.github.io/ServiceWorker/#handle-fetch" id="ref-for-handle-fetch">handle fetch</a> for usage of these terms. <a data-link-type="biblio" href="#biblio-sw">[SW]</a> </p>
   <hr>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="serializing-a-request-origin">Serializing a request origin</dfn>, given a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥③">request</a> <var>request</var>, is to
run these steps: </p>
   <ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-tainted-origin" id="ref-for-concept-request-tainted-origin①">tainted origin flag</a> is set, then return
 "<code>null</code>". </p>
    <li>
     <p>Return <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①">origin</a>, <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#ascii-serialisation-of-an-origin" id="ref-for-ascii-serialisation-of-an-origin">serialized</a>. </p>
   </ol>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="byte-serializing-a-request-origin">Byte-serializing a request origin</dfn>, given a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥④">request</a> <var>request</var>,
is to return the result of <a data-link-type="dfn" href="#serializing-a-request-origin" id="ref-for-serializing-a-request-origin">serializing a request origin</a> with <var>request</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode">isomorphic encoded</a>. </p>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-clone">clone</dfn> a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥⑤">request</a> <var>request</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>newRequest</var> be a copy of <var>request</var>, except for its <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body">body</a>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①">body</a> is non-null, set <var>newRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②">body</a> to the result of <a data-link-type="dfn" href="#concept-body-clone" id="ref-for-concept-body-clone">cloning</a> <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③">body</a>. </p>
    <li>
     <p>Return <var>newRequest</var>. </p>
   </ol>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-transmit-body">transmit body</dfn> for a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥⑥">request</a> <var>request</var>, run these steps: </p>
   <ol>
    <li>Let <var>body</var> be <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body④">body</a>. 
    <li>
     <p>If <var>body</var> is null, then <a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task①">queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-request-end-of-body" id="ref-for-process-request-end-of-body①">process request end-of-body</a> for <var>request</var> and abort these steps. </p>
    <li>
     <p>Let <var>reader</var> be the result of <a data-link-type="dfn" href="#concept-get-reader" id="ref-for-concept-get-reader">getting
  a reader</a> from <var>body</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream④">stream</a>. </p>
     <p class="note no-backref" role="note">This operation cannot throw an exception. </p>
    <li>
     <p>Let <var>read</var> be the result of <a data-link-type="dfn" href="#concept-read-chunk-from-readablestream" id="ref-for-concept-read-chunk-from-readablestream">reading a
 chunk</a> from <var>body</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream⑤">stream</a> with <var>reader</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel">In parallel</a>, while true: </p>
     <ol>
      <li>
       <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate">terminated</a>: </p>
       <ol>
        <li>
         <p>Wait for <var>read</var> to be fulfilled or rejected. </p>
        <li>
         <p>If <var>read</var> is fulfilled with an object whose <code>done</code> property is false
      and whose <code>value</code> property is a <code>Uint8Array</code> object, then run these
      steps: </p>
         <ol>
          <li>
           <p>Let <var>bs</var> be the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence" id="ref-for-byte-sequence③">byte sequence</a> represented by the <code>Uint8Array</code> object. </p>
          <li>
           <p>Transmit <var>bs</var>. Whenever one or more bytes are transmitted, increase <var>body</var>’s <a data-link-type="dfn" href="#concept-body-transmitted" id="ref-for-concept-body-transmitted">transmitted bytes</a> by the number of transmitted bytes and <a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task②">queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-request-body" id="ref-for-process-request-body">process request body</a> for <var>request</var>. </p>
           <p class="note no-backref" role="note">This step blocks until <var>bs</var> is fully transmitted. </p>
          <li>
           <p>Set <var>read</var> to the result of <a data-link-type="dfn" href="#concept-read-chunk-from-readablestream" id="ref-for-concept-read-chunk-from-readablestream①">reading a
       chunk</a> from <var>body</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream⑥">stream</a> with <var>reader</var>. </p>
         </ol>
        <li>
         <p>Otherwise, if <var>read</var> is fulfilled with an object whose <code>done</code> property is true, then <a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task③">queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-request-end-of-body" id="ref-for-process-request-end-of-body②">process request end-of-body</a> for <var>request</var> and abort these in-parallel steps. </p>
        <li>
         <p>Otherwise, if <var>read</var> is rejected with an
     "<code><a class="idl-code" data-link-type="exception" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException">DOMException</a></code>, <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①">terminate</a> the ongoing fetch with the aborted flag set. </p>
        <li>
         <p>Otherwise, <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate②">terminate</a> the ongoing fetch. </p>
       </ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted">If aborted</a>, then abort these in-parallel steps. </p>
     </ol>
   </ol>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-for="request" data-dfn-type="dfn" data-export id="concept-request-add-range-header">add a range header</dfn> to a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥⑦">request</a> <var>request</var>, with an integer <var>first</var>, and an optional integer <var>last</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>rangeValue</var> be `<code>bytes </code>`. </p>
    <li>
     <p><a data-link-type="dfn" href="#serialize-an-integer" id="ref-for-serialize-an-integer">Serialize</a> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode①">isomorphic encode</a> <var>first</var>,
 and append the result to <var>rangeValue</var>. </p>
    <li>
     <p>Append 0x2D (-) to <var>rangeValue</var>. </p>
    <li>
     <p>If <var>last</var> is given, then <a data-link-type="dfn" href="#serialize-an-integer" id="ref-for-serialize-an-integer①">serialize</a> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode②">isomorphic encode</a> it, and append the result to <var>rangeValue</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append">Append</a> `<code>Range</code>`/<var>rangeValue</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②">header list</a>. </p>
   </ol>
   <p class="note" role="note">A range header denotes an inclusive byte range. There a range header where <var>first</var> is 0 and <var>last</var> is 500, is a range of 501 bytes. </p>
   <p class="note" role="note">Features that combine multiple responses into one logical resource are historically a
source of security bugs. Please seek security review for features that deal with partial responses. </p>
   <h4 class="heading settled" data-level="2.2.6" id="responses"><span class="secno">2.2.6. </span><span class="content">Responses</span><a class="self-link" href="#responses"></a></h4>
   <p>The result of <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①②">fetch</a> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-response">response</dfn>. A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②">response</a> evolves over time. That is, not all its fields are available straight away. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-type">type</dfn> which is
"<code>basic</code>",
"<code>cors</code>",
"<code>default</code>",
"<code>error</code>",
"<code>opaque</code>", or
"<code>opaqueredirect</code>".
Unless stated otherwise, it is "<code>default</code>". </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④">response</a> can have an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-aborted">aborted flag</dfn>, which is initially unset. </p>
   <p class="note" role="note">This indicates that the request was intentionally aborted by the developer or
end-user. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-url">URL</dfn>. It is a pointer to the last <a data-link-type="dfn" href="#response-url" id="ref-for-response-url">response URL</a> in <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑥">response</a>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list">URL list</a> and null if <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑦">response</a>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list①">URL list</a> is the empty list. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑧">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-url-list">URL list</dfn> (a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list⑧">list</a> of zero or
more <a data-link-type="dfn" href="#response-url" id="ref-for-response-url①">response URLs</a>). Unless stated otherwise, it is the empty list. </p>
   <p class="note no-backref" role="note">Except for the last <a data-link-type="dfn" href="#response-url" id="ref-for-response-url②">response URL</a>, if any, a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑨">response</a>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list②">URL list</a> cannot be exposed to script. That would violate <a data-link-type="dfn" href="#atomic-http-redirect-handling" id="ref-for-atomic-http-redirect-handling①">atomic HTTP redirect handling</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①⓪">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-status">status</dfn>, which is a <a data-link-type="dfn" href="#concept-status" id="ref-for-concept-status③">status</a>. Unless stated otherwise it is <code>200</code>. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①①">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-status-message">status message</dfn>. Unless stated
otherwise it is the empty byte sequence. </p>
   <p class="note" role="note">Responses over an HTTP/2 connection will always have the empty byte sequence as status
message as HTTP/2 does not support them. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①②">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-header-list">header list</dfn> (a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①⑥">header list</a>). Unless stated otherwise it is empty. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①③">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-body">body</dfn> (null or a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body⑤">body</a>). Unless stated otherwise it is null. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①④">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-cache-state">cache state</dfn> (the empty string or
"<code>local</code>"). Unlesss stated otherwise, it is the empty string. </p>
   <p class="note" role="note">This is intended solely for usage by service workers. <a data-link-type="biblio" href="#biblio-sw">[SW]</a> </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①⑤">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-https-state">HTTPS state</dfn> (an <a data-link-type="dfn" href="#concept-https-state-value" id="ref-for-concept-https-state-value">HTTPS state value</a>). Unless stated otherwise, it is
"<code>none</code>". </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①⑥">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-csp-list">CSP list</dfn>, which is a
list of <a href="https://w3c.github.io/webappsec-csp/#policy">Content Security Policy objects</a> for the <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①⑦">response</a>. The list is empty unless otherwise
specified. <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①⑧">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-cors-exposed-header-name-list">CORS-exposed header-name list</dfn> (a list of zero or more <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③⓪">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③⑧">names</a>). The list is empty unless otherwise specified. </p>
   <p class="note no-backref" role="note">A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response①⑨">response</a> will typically get its <a data-link-type="dfn" href="#concept-response-cors-exposed-header-name-list" id="ref-for-concept-response-cors-exposed-header-name-list①">CORS-exposed header-name list</a> set by <a data-link-type="dfn" href="#extract-header-values" id="ref-for-extract-header-values①">extracting header values</a> from the
`<a data-link-type="http-header" href="#http-access-control-expose-headers" id="ref-for-http-access-control-expose-headers"><code>Access-Control-Expose-Headers</code></a>` header. This list is used by a <a data-link-type="dfn" href="#concept-filtered-response-cors" id="ref-for-concept-filtered-response-cors">CORS filtered response</a> to determine which headers to expose. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②⓪">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-noexport id="concept-response-range-requested-flag">range-requested flag</dfn>, which is
initially unset. </p>
   <p class="note" role="note">This is used to ensure to prevent a partial response from an earlier ranged request
being provided to an API that didn’t make a range request. See the flag’s usage for a detailed
description of the attack. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②①">response</a> has an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-noexport id="concept-response-timing-allow-passed">timing allow passed flag</dfn>, which is
initially unset. </p>
   <p class="note" role="note">This is used so that the caller to a fetch can determine if sensitive timing data is
allowed on the resource fetched by looking at the flag of the response returned. Because the flag on
the response of a redirect has to be set if it was set for previous responses in the redirect chain,
this is also tracked internally using the request’s <a data-link-type="dfn" href="#timing-allow-failed" id="ref-for-timing-allow-failed①">timing allow failed flag</a>. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②②">response</a> can have an associated <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-location-url">location URL</dfn> (null, failure, or a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url⑧">URL</a>). Unless specified otherwise, <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②③">response</a> has no <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url">location URL</a>. </p>
   <p class="note no-backref" role="note">This concept is used for redirect handling in Fetch and in HTML’s
navigate algorithm. It ensures `<code>Location</code>` has <a data-link-type="dfn" href="#extract-header-values" id="ref-for-extract-header-values②">its value extracted</a> consistently and only once. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <hr>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②④">response</a> whose <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type">type</a> is "<code>error</code>" and <a data-link-type="dfn" href="#concept-response-aborted" id="ref-for-concept-response-aborted">aborted flag</a> is set is
known as an <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-aborted-network-error">aborted network error</dfn>. </p>
   <p>A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②⑤">response</a> whose <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type①">type</a> is "<code>error</code>" is known as a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-network-error">network error</dfn>. </p>
   <p>A <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④">network error</a> is a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②⑥">response</a> whose <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status">status</a> is always <code>0</code>, <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message">status message</a> is always the empty byte sequence, <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list">header list</a> is always empty, and <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body">body</a> is always null. </p>
   <hr>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-filtered-response">filtered response</dfn> is a limited view on a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②⑦">response</a> that is not a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤">network error</a>. This <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②⑧">response</a> is referred to as the <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response">filtered response</a>’s associated <dfn class="dfn-paneled" data-dfn-for="internal" data-dfn-type="dfn" data-export id="concept-internal-response">internal response</dfn>. </p>
   <p class="note no-backref" role="note">The <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①③">fetch</a> algorithm returns such a view to ensure APIs do
not accidentally leak information. If the information needs to be exposed for legacy reasons, e.g.,
to feed image data to a decoder, the associated <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response">internal response</a> can be used,
which is only "accessible" to internal specification algorithms and is never a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response①">filtered response</a> itself. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-filtered-response-basic">basic filtered response</dfn> is a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response②">filtered response</a> whose <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type②">type</a> is "<code>basic</code>" and <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①">header list</a> excludes any <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③①">headers</a> in <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response①">internal response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②">header list</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name③⑨">name</a> is a <a data-link-type="dfn" href="#forbidden-response-header-name" id="ref-for-forbidden-response-header-name①">forbidden response-header name</a>. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-filtered-response-cors">CORS filtered response</dfn> is a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response③">filtered response</a> whose <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type③">type</a> is "<code>cors</code>" and <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③">header list</a> excludes any <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③②">headers</a> in <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response②">internal response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list④">header list</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④⓪">name</a> is <em>not</em> a <a data-link-type="dfn" href="#cors-safelisted-response-header-name" id="ref-for-cors-safelisted-response-header-name">CORS-safelisted response-header name</a>, given <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response③">internal response</a>’s <a data-link-type="dfn" href="#concept-response-cors-exposed-header-name-list" id="ref-for-concept-response-cors-exposed-header-name-list②">CORS-exposed header-name list</a>. </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-filtered-response-opaque">opaque filtered response</dfn> is a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response④">filtered response</a> whose <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type④">type</a> is "<code>opaque</code>", <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list③">URL list</a> is the empty list, <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①">status</a> is <code>0</code>, <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message①">status message</a> is the empty byte sequence, <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list⑤">header list</a> is empty, and <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①">body</a> is null. </p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-filtered-response-opaque-redirect">opaque-redirect filtered response</dfn> is a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response⑤">filtered response</a> whose <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type⑤">type</a> is "<code>opaqueredirect</code>", <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②">status</a> is <code>0</code>, <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message②">status message</a> is the empty byte sequence, <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list⑥">header list</a> is empty, and <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②">body</a> is null. </p>
   <div class="note no-backref" role="note">
    <p>Exposing the <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list④">URL list</a> for <a data-link-type="dfn" href="#concept-filtered-response-opaque-redirect" id="ref-for-concept-filtered-response-opaque-redirect①">opaque-redirect filtered responses</a> is harmless since
 no redirects are followed. </p>
    <p>In other words, an <a data-link-type="dfn" href="#concept-filtered-response-opaque" id="ref-for-concept-filtered-response-opaque①">opaque filtered response</a> and an <a data-link-type="dfn" href="#concept-filtered-response-opaque-redirect" id="ref-for-concept-filtered-response-opaque-redirect②">opaque-redirect filtered response</a> are
 nearly indistinguishable from a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑥">network error</a>. When
 introducing new APIs, do not use the <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response④">internal response</a> for internal specification algorithms as that will leak information. </p>
    <p>This also means that JavaScript APIs, such as <a class="idl-code" data-link-type="attribute" href="#dom-response-ok" id="ref-for-dom-response-ok"><code>response.ok</code></a>,
 will return rather useless results. </p>
   </div>
   <p>To <dfn class="dfn-paneled" data-dfn-for="response" data-dfn-type="dfn" data-export id="concept-response-clone">clone</dfn> a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response②⑨">response</a> <var>response</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>response</var> is a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response⑥">filtered response</a>, then return a new identical filtered
 response whose <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response⑤">internal response</a> is a <a data-link-type="dfn" href="#concept-response-clone" id="ref-for-concept-response-clone">clone</a> of <var>response</var>’s <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response⑥">internal response</a>. </p>
    <li>
     <p>Let <var>newResponse</var> be a copy of <var>response</var>, except for its <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body③">body</a>. </p>
    <li>
     <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body④">body</a> is non-null, then set <var>newResponse</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body⑤">body</a> to the result of <a data-link-type="dfn" href="#concept-body-clone" id="ref-for-concept-body-clone①">cloning</a> <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body⑥">body</a>. </p>
    <li>
     <p>Return <var>newResponse</var>. </p>
   </ol>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-fresh-response">fresh response</dfn> is a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③⓪">response</a> whose <a href="https://tools.ietf.org/html/rfc7234#section-4.2.3">current age</a> is within its <a href="https://tools.ietf.org/html/rfc7234#section-4.2.1">freshness lifetime</a>. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-stale-while-revalidate-response">stale-while-revalidate response</dfn> is a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③①">response</a> that is not a <a data-link-type="dfn" href="#concept-fresh-response" id="ref-for-concept-fresh-response①">fresh response</a> and whose <a href="https://tools.ietf.org/html/rfc7234#section-4.2.3">current age</a> is within the <a href="https://tools.ietf.org/html/rfc5861#section-3">stale-while-revalidate lifetime</a>. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-stale-response">stale response</dfn> is a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③②">response</a> is a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③③">response</a> that is not a <a data-link-type="dfn" href="#concept-fresh-response" id="ref-for-concept-fresh-response②">fresh response</a> or a <a data-link-type="dfn" href="#concept-stale-while-revalidate-response" id="ref-for-concept-stale-while-revalidate-response①">stale-while-revalidate response</a>. </p>
   <h4 class="heading settled" data-level="2.2.7" id="miscellaneous"><span class="secno">2.2.7. </span><span class="content">Miscellaneous</span><a class="self-link" href="#miscellaneous"></a></h4>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-potential-destination">potential destination</dfn> is
"<code>fetch</code>" or a <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination⑦">destination</a> which is not the empty string. </p>
   <p>To <dfn data-dfn-for="destination" data-dfn-type="dfn" data-export id="concept-potential-destination-translate">translate<a class="self-link" href="#concept-potential-destination-translate"></a></dfn> a <a data-link-type="dfn" href="#concept-potential-destination" id="ref-for-concept-potential-destination">potential destination</a> <var>potentialDestination</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>potentialDestination</var> is "<code>fetch</code>", then return the empty string. </p>
    <li>
     <p>Assert: <var>potentialDestination</var> is a <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination⑧">destination</a>. </p>
    <li>
     <p>Return <var>potentialDestination</var>. </p>
   </ol>
   <h3 class="heading settled" data-level="2.3" id="authentication-entries"><span class="secno">2.3. </span><span class="content">Authentication entries</span><a class="self-link" href="#authentication-entries"></a></h3>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="authentication-entry">authentication entry</dfn> and a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="proxy-authentication-entry">proxy-authentication entry</dfn> are
tuples of username, password, and realm, used for HTTP authentication and HTTP proxy authentication,
and associated with one or more <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥⑧">requests</a>. </p>
   <p>User agents should allow both to be cleared together with HTTP cookies and similar tracking
functionality. </p>
   <p>Further details are defined by HTTP. <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-http-semantics">[HTTP-SEMANTICS]</a> <a data-link-type="biblio" href="#biblio-http-cond">[HTTP-COND]</a> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> </p>
   <h3 class="heading settled" data-level="2.4" id="fetch-groups"><span class="secno">2.4. </span><span class="content">Fetch groups</span><a class="self-link" href="#fetch-groups"></a></h3>
   <p>Each <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object⑧">environment settings object</a> has an associated <dfn class="dfn-paneled" data-dfn-for="fetch" data-dfn-type="dfn" data-export id="concept-fetch-group">fetch group</dfn>. </p>
   <p>A <a data-link-type="dfn" href="#concept-fetch-group" id="ref-for-concept-fetch-group">fetch group</a> holds an ordered list of <dfn class="dfn-paneled" data-dfn-for="fetch group" data-dfn-type="dfn" data-export data-lt="fetch record" id="concept-fetch-record">fetch records</dfn>. </p>
   <p>A <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record">fetch record</a> has an associated <dfn class="dfn-paneled" data-dfn-for="fetch record" data-dfn-type="dfn" data-export id="concept-fetch-record-request">request</dfn> (a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑥⑨">request</a>). </p>
   <p>A <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record①">fetch record</a> has an associated <dfn class="dfn-paneled" data-dfn-for="fetch record" data-dfn-type="dfn" data-export id="concept-fetch-record-fetch">fetch</dfn> (a <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①④">fetch</a> algorithm or null). </p>
   <hr>
   <p>When a <a data-link-type="dfn" href="#concept-fetch-group" id="ref-for-concept-fetch-group①">fetch group</a> is <dfn data-dfn-for="fetch group" data-dfn-type="dfn" data-export id="concept-fetch-group-terminate">terminated<a class="self-link" href="#concept-fetch-group-terminate"></a></dfn>,
for each associated <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record②">fetch record</a> whose <a data-link-type="dfn" href="#concept-fetch-record-request" id="ref-for-concept-fetch-record-request">request</a>’s <a data-link-type="dfn" href="#done-flag" id="ref-for-done-flag①">done flag</a> or <a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag">keepalive flag</a> is unset, <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate③">terminate</a> the <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record③">fetch record</a>’s <a data-link-type="dfn" href="#concept-fetch-record-fetch" id="ref-for-concept-fetch-record-fetch">fetch</a>. </p>
   <h3 class="heading settled" data-level="2.5" id="connections"><span class="secno">2.5. </span><span class="content">Connections</span><a class="self-link" href="#connections"></a></h3>
   <p>A user agent has an associated <dfn class="dfn-paneled" data-dfn-for="connection" data-dfn-type="dfn" data-export id="concept-connection-pool">connection pool</dfn>. A <a data-link-type="dfn" href="#concept-connection-pool" id="ref-for-concept-connection-pool">connection pool</a> consists of zero or more <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="connection" id="concept-connection">connections</dfn>. Each <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection">connection</a> is identified by an <b>origin</b> (an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin②">origin</a>) and <b>credentials</b> (a boolean). </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="connection" data-dfn-type="dfn" data-export id="concept-connection-obtain">obtain a connection</dfn>, given an <var>origin</var> and <var>credentials</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <a data-link-type="dfn" href="#concept-connection-pool" id="ref-for-concept-connection-pool①">connection pool</a> contains a <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection①">connection</a> whose <b>origin</b> is <var>origin</var> and <b>credentials</b> is <var>credentials</var>, then return that <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection②">connection</a>. </p>
    <li>
     <p>Let <var>connection</var> be null. </p>
    <li>
     <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when①">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate④">terminated</a>: </p>
     <ol>
      <li>
       <p>Set <var>connection</var> to the result of establishing an HTTP connection to <var>origin</var>. <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-http-semantics">[HTTP-SEMANTICS]</a> <a data-link-type="biblio" href="#biblio-http-cond">[HTTP-COND]</a> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> <a data-link-type="biblio" href="#biblio-tls">[TLS]</a> </p>
       <p>If <var>credentials</var> is false, then do <em>not</em> send a TLS client certificate. </p>
       <p>If establishing a connection does not succeed (e.g., a DNS, TCP, or TLS error), then return
    failure. </p>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted①">If aborted</a>, then: </p>
     <ol>
      <li>
       <p>If <var>connection</var> is not null, then close <var>connection</var>. </p>
      <li>
       <p>Return failure. </p>
     </ol>
    <li>
     <p>Add <var>connection</var> to the <a data-link-type="dfn" href="#concept-connection-pool" id="ref-for-concept-connection-pool②">connection pool</a> with <b>origin</b> being <var>origin</var> and <b>credentials</b> being <var>credentials</var>. </p>
    <li>
     <p>Return <var>connection</var>. </p>
   </ol>
   <p class="note no-backref" role="note">This is intentionally a little vague as the finer points are still
evolving. Describing this helps explain the <code>&lt;link rel=preconnect></code> feature and
clearly stipulates that <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection③">connections</a> are keyed on <b>credentials</b>. The latter clarifies that e.g., TLS session identifiers are not reused across <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection④">connections</a> whose <b>credentials</b> are false with <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection⑤">connections</a> whose <b>credentials</b> are true. </p>
   <h3 class="heading settled" data-level="2.6" id="port-blocking"><span class="secno">2.6. </span><span class="content">Port blocking</span><a class="self-link" href="#port-blocking"></a></h3>
   <p>To determine whether fetching a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦⓪">request</a> <var>request</var> <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="block bad port" id="block-bad-port">should be blocked due to a bad port</dfn>,
run these steps: </p>
   <ol>
    <li>
     <p>Let <var>url</var> be <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①">current URL</a>. </p>
    <li>
     <p>Let <var>scheme</var> be <var>url</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme⑤">scheme</a>. </p>
    <li>
     <p>Let <var>port</var> be <var>url</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-port" id="ref-for-concept-url-port">port</a>. </p>
    <li>
     <p>If <var>scheme</var> is "<code>ftp</code>" and <var>port</var> is 20 or 21, then
 return <b>allowed</b>. </p>
    <li>
     <p>Otherwise, if <var>scheme</var> is a <a data-link-type="dfn" href="#network-scheme" id="ref-for-network-scheme②">network scheme</a> and <var>port</var> is a <a data-link-type="dfn" href="#bad-port" id="ref-for-bad-port">bad port</a>, then return <b>blocked</b>. </p>
    <li>
     <p>Return <b>allowed</b>. </p>
   </ol>
   <p>A <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-port" id="ref-for-concept-url-port①">port</a> is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="bad-port">bad port</dfn> if it is listed in the first column of the following table. </p>
   <table>
    <tbody>
     <tr>
      <th>Port
      <th>Typical service 
     <tr>
      <td>1
      <td>tcpmux 
     <tr>
      <td>7
      <td>echo 
     <tr>
      <td>9
      <td>discard 
     <tr>
      <td>11
      <td>systat 
     <tr>
      <td>13
      <td>daytime 
     <tr>
      <td>15
      <td>netstat 
     <tr>
      <td>17
      <td>qotd 
     <tr>
      <td>19
      <td>chargen 
     <tr>
      <td>20
      <td>ftp-data 
     <tr>
      <td>21
      <td>ftp 
     <tr>
      <td>22
      <td>ssh 
     <tr>
      <td>23
      <td>telnet 
     <tr>
      <td>25
      <td>smtp 
     <tr>
      <td>37
      <td>time 
     <tr>
      <td>42
      <td>name 
     <tr>
      <td>43
      <td>nicname 
     <tr>
      <td>53
      <td>domain 
     <tr>
      <td>77
      <td>priv-rjs 
     <tr>
      <td>79
      <td>finger 
     <tr>
      <td>87
      <td>ttylink 
     <tr>
      <td>95
      <td>supdup 
     <tr>
      <td>101
      <td>hostriame 
     <tr>
      <td>102
      <td>iso-tsap 
     <tr>
      <td>103
      <td>gppitnp 
     <tr>
      <td>104
      <td>acr-nema 
     <tr>
      <td>109
      <td>pop2 
     <tr>
      <td>110
      <td>pop3 
     <tr>
      <td>111
      <td>sunrpc 
     <tr>
      <td>113
      <td>auth 
     <tr>
      <td>115
      <td>sftp 
     <tr>
      <td>117
      <td>uucp-path 
     <tr>
      <td>119
      <td>nntp 
     <tr>
      <td>123
      <td>ntp 
     <tr>
      <td>135
      <td>loc-srv / epmap 
     <tr>
      <td>139
      <td>netbios 
     <tr>
      <td>143
      <td>imap2 
     <tr>
      <td>179
      <td>bgp 
     <tr>
      <td>389
      <td>ldap 
     <tr>
      <td>427
      <td>afp (alternate) 
     <tr>
      <td>465
      <td>smtp (alternate) 
     <tr>
      <td>512
      <td>print / exec 
     <tr>
      <td>513
      <td>login 
     <tr>
      <td>514
      <td>shell 
     <tr>
      <td>515
      <td>printer 
     <tr>
      <td>526
      <td>tempo 
     <tr>
      <td>530
      <td>courier 
     <tr>
      <td>531
      <td>chat 
     <tr>
      <td>532
      <td>netnews 
     <tr>
      <td>540
      <td>uucp 
     <tr>
      <td>548
      <td>afp 
     <tr>
      <td>556
      <td>remotefs 
     <tr>
      <td>563
      <td>nntp+ssl 
     <tr>
      <td>587
      <td>smtp (outgoing) 
     <tr>
      <td>601
      <td>syslog-conn 
     <tr>
      <td>636
      <td>ldap+ssl 
     <tr>
      <td>993
      <td>ldap+ssl 
     <tr>
      <td>995
      <td>pop3+ssl 
     <tr>
      <td>2049
      <td>nfs 
     <tr>
      <td>3659
      <td>apple-sasl 
     <tr>
      <td>4045
      <td>lockd 
     <tr>
      <td>6000
      <td>x11 
     <tr>
      <td>6665
      <td>irc (alternate) 
     <tr>
      <td>6666
      <td>irc (alternate) 
     <tr>
      <td>6667
      <td>irc (default) 
     <tr>
      <td>6668
      <td>irc (alternate) 
     <tr>
      <td>6669
      <td>irc (alternate) 
     <tr>
      <td>6697
      <td>irc+tls 
   </table>
   <h3 class="heading settled dfn-paneled" data-dfn-type="dfn" data-export data-level="2.7" data-lt="should response to request be blocked due to mime type" id="should-response-to-request-be-blocked-due-to-mime-type?"><span class="secno">2.7. </span><span class="content">Should <var>response</var> to <var>request</var> be blocked due to its MIME type?</span></h3>
   <p>Run these steps: </p>
   <ol>
    <li>
     <p>Let <var>mimeType</var> be the result of <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type②">extracting a MIME type</a> from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list⑦">header list</a>. </p>
    <li>
     <p>If <var>mimeType</var> is failure, then return <b>allowed</b>. </p>
    <li>
     <p>Let <var>destination</var> be <var>request</var>’s <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination⑨">destination</a>. </p>
    <li>
     <p>If <var>destination</var> is <a data-link-type="dfn" href="#request-destination-script-like" id="ref-for-request-destination-script-like①">script-like</a> and one of the
  following is true, then return <b>blocked</b>: </p>
     <ul class="brief">
      <li><var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence①">essence</a> starts with "<code>audio/</code>",
   "<code>image/</code>", or "<code>video/</code>". 
      <li><var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence②">essence</a> is "<code>text/csv</code>". 
     </ul>
    <li>
     <p>Return <b>allowed</b>. </p>
   </ol>
   <h3 class="heading settled" data-level="2.8" id="streams"><span class="secno">2.8. </span><span class="content">Streams</span><a class="self-link" href="#streams"></a></h3>
   <p class="note no-backref" role="note">This section might be integrated into other standards, such as IDL. </p>
   <h4 class="heading settled" data-level="2.8.1" id="readablestream"><span class="secno">2.8.1. </span><span class="content">ReadableStream</span><a class="self-link" href="#readablestream"></a></h4>
   <p>A <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="concept-readablestream"><code>ReadableStream</code></dfn> object
represents a <a href="https://streams.spec.whatwg.org/#rs-class">stream of data</a>. In this section,
we define common operations for <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②">ReadableStream</a></code> objects. <a data-link-type="biblio" href="#biblio-streams">[STREAMS]</a> </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-enqueue-readablestream">enqueue</dfn> <var>chunk</var> into a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream③">ReadableStream</a></code> object <var>stream</var>, run these steps: </p>
   <ol>
    <li>
     <p>Call <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-default-controller-enqueue" id="ref-for-readable-stream-default-controller-enqueue">ReadableStreamDefaultControllerEnqueue</a>(<var>stream</var>.[[readableStreamController]], <var>chunk</var>). </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="abstract-op" data-export id="concept-close-readablestream">close</dfn> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream④">ReadableStream</a></code> object <var>stream</var>, run these steps: </p>
   <ol>
    <li>
     <p>Call <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-default-controller-close" id="ref-for-readable-stream-default-controller-close">ReadableStreamDefaultControllerClose</a>(<var>stream</var>.[[readableStreamController]]). </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="abstract-op" data-export id="concept-error-readablestream">error</dfn> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream⑤">ReadableStream</a></code> object <var>stream</var> with given <var>reason</var>, run these steps: </p>
   <ol>
    <li>
     <p>Call <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-default-controller-error" id="ref-for-readable-stream-default-controller-error">ReadableStreamDefaultControllerError</a>(<var>stream</var>.[[readableStreamController]]). <var>reason</var>). </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-construct-readablestream">construct a <code>ReadableStream</code> object</dfn> optionally with a <var>highWaterMark</var>, <var>sizeAlgorithm</var> algorithm, <var>pull</var> action, and <var>cancel</var> action, run these steps: </p>
   <p class="note" role="note">This algorithm used to take a <var>strategy</var> parameter, whose <code>highWaterMark</code> and <code>sizeAlgorithm</code> members were extracted to provide what are
now separate parameters. If another specification still passes that <var>strategy</var> parameter, please update it. </p>
   <ol>
    <li>
     <p>Let <var>startAlgorithm</var> be an algorithm that returns undefined. </p>
    <li>
     <p>If <var>pull</var> is not given, then set it to an action that does nothing. </p>
    <li>
     <p>Let <var>pullAlgorithm</var> be an algorithm that runs these steps: </p>
     <ol>
      <li>
       <p>Run <var>pull</var>. </p>
      <li>
       <p>Return <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-promise-resolved-with" id="ref-for-a-promise-resolved-with">a promise resolved with</a> undefined. </p>
     </ol>
    <li>
     <p>If <var>cancel</var> is not given, then set it to an action that does nothing. </p>
    <li>
     <p>Let <var>cancelAlgorithm</var> be an algorithm that runs these steps: </p>
     <ol>
      <li>
       <p>Run <var>cancel</var>. </p>
      <li>
       <p>Return <a data-link-type="dfn" href="https://heycam.github.io/webidl/#a-promise-resolved-with" id="ref-for-a-promise-resolved-with①">a promise resolved with</a> undefined. </p>
     </ol>
    <li>
     <p>If <var>highWaterMark</var> is not given, then set it to 1. </p>
    <li>
     <p>If <var>sizeAlgorithm</var> is not given, then set it to an algorithm that returns 1. </p>
    <li>
     <p>Return <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#create-readable-stream" id="ref-for-create-readable-stream">CreateReadableStream</a>(<var>startAlgorithm</var>, <var>pullAlgorithm</var>, <var>cancelAlgorithm</var>, <var>highWaterMark</var>, <var>sizeAlgorithm</var>). </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-construct-fixed-readablestream">construct a fixed <code>ReadableStream</code> object</dfn> with given <var>chunks</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>stream</var> be the result of <a data-link-type="dfn" href="#concept-construct-readablestream" id="ref-for-concept-construct-readablestream">constructing</a> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream⑥">ReadableStream</a></code> object. </p>
    <li>
     <p>For each <var>chunk</var> in <var>chunks</var>, <a data-link-type="dfn" href="#concept-enqueue-readablestream" id="ref-for-concept-enqueue-readablestream">enqueue</a> <var>chunk</var> into <var>stream</var>. </p>
    <li>
     <p><a data-link-type="abstract-op" href="#concept-close-readablestream" id="ref-for-concept-close-readablestream">Close</a> <var>stream</var>. </p>
    <li>Return <var>stream</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-get-reader">get a reader</dfn> from a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream⑦">ReadableStream</a></code> object <var>stream</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>reader</var> be the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#acquire-readable-stream-reader" id="ref-for-acquire-readable-stream-reader">AcquireReadableStreamDefaultReader</a>(<var>stream</var>). </p>
    <li>
     <p>Return <var>reader</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-read-chunk-from-readablestream">read a chunk</dfn> from a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream⑧">ReadableStream</a></code> object with <var>reader</var>, return the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-default-reader-read" id="ref-for-readable-stream-default-reader-read">ReadableStreamDefaultReaderRead</a>(<var>reader</var>). </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-read-all-bytes-from-readablestream">read all bytes</dfn> from a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream⑨">ReadableStream</a></code> object with <var>reader</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>promise</var> be a new promise. </p>
    <li>
     <p>Let <var>bytes</var> be an empty byte sequence. </p>
    <li>
     <p>Let <var>read</var> be the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-default-reader-read" id="ref-for-readable-stream-default-reader-read①">ReadableStreamDefaultReaderRead</a>(<var>reader</var>). </p>
     <ul>
      <li>
       <p>When <var>read</var> is fulfilled with an object whose <code>done</code> property is false and whose <code>value</code> property is a <code>Uint8Array</code> object, append the <code>value</code> property to <var>bytes</var> and run the above step again. </p>
      <li>
       <p>When <var>read</var> is fulfilled with an object whose <code>done</code> property is true, resolve <var>promise</var> with <var>bytes</var>. </p>
      <li>
       <p>When <var>read</var> is fulfilled with a value that matches with neither of the
  above patterns, reject <var>promise</var> with a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror">TypeError</a></code>. </p>
      <li>
       <p>When <var>read</var> is rejected with an error, reject <var>promise</var> with that error. </p>
     </ul>
    <li>
     <p>Return <var>promise</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-cancel-readablestream">cancel</dfn> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①⓪">ReadableStream</a></code> object <var>stream</var> with <var>reason</var>, return the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-cancel" id="ref-for-readable-stream-cancel">ReadableStreamCancel</a>(<var>stream</var>, <var>reason</var>). </p>
   <p class="note no-backref" role="note">Because the reader grants exclusive access, the actual mechanism of how
to read cannot be observed. Implementations could use more direct mechanism if convenient. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-tee-readablestream">tee</dfn> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①①">ReadableStream</a></code> object <var>stream</var>, run these steps: </p>
   <ol>
    <li>
     <p>Return the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-tee" id="ref-for-readable-stream-tee">ReadableStreamTee</a>(<var>stream</var>, true). </p>
   </ol>
   <p>An <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-empty-readablestream">empty</dfn> <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①②">ReadableStream</a></code> object is the result of <a data-link-type="dfn" href="#concept-construct-fixed-readablestream" id="ref-for-concept-construct-fixed-readablestream">constructing</a> a fixed <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①③">ReadableStream</a></code> object with an empty list. </p>
   <p class="note no-backref" role="note">Constructing an <a data-link-type="dfn" href="#concept-empty-readablestream" id="ref-for-concept-empty-readablestream">empty</a> <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①④">ReadableStream</a></code> object will not throw an
exception. </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①⑤">ReadableStream</a></code> object <var>stream</var> is said to be <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-readablestream-readable">readable</dfn> if <var>stream</var>.[[state]] is "readable". </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①⑥">ReadableStream</a></code> object <var>stream</var> is said to be <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-readablestream-closed">closed</dfn> if <var>stream</var>.[[state]] is "closed". </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①⑦">ReadableStream</a></code> object <var>stream</var> is said to be <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-readablestream-errored">errored</dfn> if <var>stream</var>.[[state]] is "errored". </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①⑧">ReadableStream</a></code> object <var>stream</var> is said to be <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-readablestream-locked">locked</dfn> if the
result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#is-readable-stream-locked" id="ref-for-is-readable-stream-locked">IsReadableStreamLocked</a>(<var>stream</var>) is
true. </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream①⑨">ReadableStream</a></code> object <var>stream</var> is said to <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-readablestream-need-more-data">need more data</dfn> if the following conditions hold: </p>
   <ul>
    <li>
     <p><var>stream</var> is <a data-link-type="dfn" href="#concept-readablestream-readable" id="ref-for-concept-readablestream-readable">readable</a>. </p>
    <li>
     <p>The result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-default-controller-get-desired-size" id="ref-for-readable-stream-default-controller-get-desired-size">ReadableStreamDefaultControllerGetDesiredSize</a>(<var>stream</var>.[[readableStreamController]]).
 is positive. </p>
   </ul>
   <p>A <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②⓪">ReadableStream</a></code> object <var>stream</var> is said to be <dfn class="dfn-paneled" data-dfn-for="ReadableStream" data-dfn-type="dfn" data-export id="concept-readablestream-disturbed">disturbed</dfn> if the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#is-readable-stream-disturbed" id="ref-for-is-readable-stream-disturbed">IsReadableStreamDisturbed</a>(<var>stream</var>) is true. </p>
   <h2 class="heading settled" data-level="3" id="http-extensions"><span class="secno">3. </span><span class="content">HTTP extensions</span><a class="self-link" href="#http-extensions"></a></h2>
   <h3 class="heading settled" data-level="3.1" id="origin-header"><span class="secno">3.1. </span><span class="content">`<code>Origin</code>` header</span><a class="self-link" href="#origin-header"></a></h3>
   <p>The `<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-origin"><code>Origin</code></dfn>`
request <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③③">header</a> indicates where a <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①⑤">fetch</a> originates from. </p>
   <p class="note no-backref" role="note">The `<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin②"><code>Origin</code></a>` header is a version of the
`<code>Referer</code>` [sic] header that does not reveal a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-path" id="ref-for-concept-url-path">path</a>. It is used for all <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch②">HTTP fetches</a> whose <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦①">request</a>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①">response tainting</a> is "<code>cors</code>", as well as those where <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦②">request</a>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①">method</a> is neither `<code>GET</code>` nor
`<code>HEAD</code>`. Due to compatibility constraints it is not included in all <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①⑥">fetches</a>. </p>
   <p>Its <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②③">value</a> <a data-link-type="dfn" href="#abnf" id="ref-for-abnf③">ABNF</a>: </p>
<pre><code class="lang-abnf highlight"><c- nc>Origin</c->                           <c- o>=</c-> <c- nc>origin-or-null</c->

<c- nc>origin-or-null</c->                   <c- o>=</c-> <c- nc>origin</c-> <c- o>/</c-> <c- l>%s"null"</c-> <c- c1>; case-sensitive</c->
<c- nc>origin</c->                           <c- o>=</c-> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme⑥"><c- nc>scheme</c-></a> <c- l>"://"</c-> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-host" id="ref-for-concept-url-host"><c- nc>host</c-></a> <c- p>[</c-> <c- l>":"</c-> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-port" id="ref-for-concept-url-port②"><c- nc>port</c-></a> <c- p>]</c->
</code></pre>
   <p class="note no-backref" role="note">This supplants the `<code>Origin</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③④">header</a>. <a data-link-type="biblio" href="#biblio-origin">[ORIGIN]</a> </p>
   <hr>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="append-a-request-origin-header">append a request `<code>Origin</code>` header</dfn>,
given a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦③">request</a> <var>request</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>serializedOrigin</var> be the result of <a data-link-type="dfn" href="#byte-serializing-a-request-origin" id="ref-for-byte-serializing-a-request-origin">byte-serializing a request origin</a> with <var>request</var>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting②">response tainting</a> is "<code>cors</code>" or <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode④">mode</a> is "<code>websocket</code>", then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①">append</a> `<code>Origin</code>`/<var>serializedOrigin</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③">header list</a>. </p>
    <li>
     <p>Otherwise, if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method②">method</a> is neither `<code>GET</code>` nor
  `<code>HEAD</code>`, then: </p>
     <ol>
      <li>
       <p>Switch on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy">referrer policy</a>: </p>
       <dl class="switch">
        <dt>"<code>no-referrer</code>" 
        <dd>
         <p>Set <var>serializedOrigin</var> to `<code>null</code>`. </p>
        <dt>"<code>no-referrer-when-downgrade</code>" 
        <dt>"<code>strict-origin</code>" 
        <dt>"<code>strict-origin-when-cross-origin</code>" 
        <dd>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin②">origin</a> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin-tuple" id="ref-for-concept-origin-tuple">tuple origin</a>, its <var>scheme</var> is "<code>https</code>", and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②">current URL</a>’s <var>scheme</var> is not "<code>https</code>", then set <var>serializedOrigin</var> to `<code>null</code>`. </p>
        <dt>"<code>same-origin</code>" 
        <dd>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin③">origin</a> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin">same origin</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin">origin</a>, then set <var>serializedOrigin</var> to `<code>null</code>`. </p>
        <dt>Otherwise 
        <dd>Do nothing. 
       </dl>
      <li>
       <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②">Append</a> `<code>Origin</code>`/<var>serializedOrigin</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④">header list</a>. </p>
     </ol>
   </ol>
   <p class="note" role="note">A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦④">request</a>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy①">referrer policy</a> is taken into account for
all fetches where the fetcher did not explicitly opt into sharing their <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin③">origin</a> with the
server, e.g., via using the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①">CORS protocol</a>. </p>
   <h3 class="heading settled" data-level="3.2" id="http-cors-protocol"><span class="secno">3.2. </span><span class="content">CORS protocol</span><a class="self-link" href="#http-cors-protocol"></a></h3>
   <p>To allow sharing responses cross-origin and allow for more versatile <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①⑦">fetches</a> than possible with HTML’s <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element" id="ref-for-the-form-element">form</a></code> element, the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-protocol">CORS protocol</dfn> exists. It
is layered on top of HTTP and allows responses to declare they can be shared with other <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin④">origins</a>. </p>
   <p class="note" role="note">It needs to be an opt-in mechanism to prevent leaking data from responses behind a
firewall (intranets). Additionally, for <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦⑤">requests</a> including <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①">credentials</a> it needs to be opt-in to prevent leaking potentially-sensitive data. </p>
   <p>This section explains the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol②">CORS protocol</a> as it pertains to server developers.
Requirements for user agents are part of the <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①⑧">fetch</a> algorithm,
except for the <a href="#http-new-header-syntax">new HTTP header syntax</a>. </p>
   <h4 class="heading settled" data-level="3.2.1" id="general"><span class="secno">3.2.1. </span><span class="content">General</span><a class="self-link" href="#general"></a></h4>
   <p>The <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol③">CORS protocol</a> consists of a set of headers that indicates whether a response can
be shared cross-origin. </p>
   <p>For <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦⑥">requests</a> that are more involved than what is possible with HTML’s <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element" id="ref-for-the-form-element①">form</a></code> element, a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request①">CORS-preflight request</a> is performed, to ensure <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦⑦">request</a>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url④">current URL</a> supports the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol④">CORS protocol</a>. </p>
   <h4 class="heading settled" data-level="3.2.2" id="http-requests"><span class="secno">3.2.2. </span><span class="content">HTTP requests</span><a class="self-link" href="#http-requests"></a></h4>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-request">CORS request</dfn> is an HTTP request that includes an
`<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin③"><code>Origin</code></a>` header. It cannot be reliably identified as participating in
the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol⑤">CORS protocol</a> as the `<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin④"><code>Origin</code></a>` header is also included for
all <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦⑧">requests</a> whose <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method③">method</a> is neither `<code>GET</code>` nor
`<code>HEAD</code>`. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="cors-preflight-request">CORS-preflight request</dfn> is a <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request①">CORS request</a> that checks to see
if the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol⑥">CORS protocol</a> is understood. It uses `<code>OPTIONS</code>` as <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method⑥">method</a> and includes these <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③⑤">headers</a>: </p>
   <dl>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-request-method"><code>Access-Control-Request-Method</code></dfn>` 
    <dd>
     <p>Indicates which <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method⑦">method</a> a future <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request②">CORS request</a> to the same resource might use. </p>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-request-headers"><code>Access-Control-Request-Headers</code></dfn>` 
    <dd>
     <p>Indicates which <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③⑥">headers</a> a future <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request③">CORS request</a> to the same resource might use. </p>
   </dl>
   <h4 class="heading settled" data-level="3.2.3" id="http-responses"><span class="secno">3.2.3. </span><span class="content">HTTP responses</span><a class="self-link" href="#http-responses"></a></h4>
   <p>An HTTP response to a <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request④">CORS request</a> can include the following <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③⑦">headers</a>: </p>
   <dl>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-allow-origin"><code>Access-Control-Allow-Origin</code></dfn>` 
    <dd>
     <p>Indicates whether the response can be shared, via returning the literal <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②④">value</a> of the
 `<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin⑤"><code>Origin</code></a>` request <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③⑧">header</a> (which can be `<code>null</code>`) or `<code>*</code>` in a response. </p>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-allow-credentials"><code>Access-Control-Allow-Credentials</code></dfn>` 
    <dd>
     <p>Indicates whether the response can be shared when <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑦⑨">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode②">credentials mode</a> is
  "<code>include</code>". </p>
     <p class="note" role="note">For a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request②">CORS-preflight request</a>, <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧⓪">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode③">credentials mode</a> is always
  "<code>omit</code>", but for any subsequent <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request⑤">CORS requests</a> it might not be. Support therefore needs
  to be indicated as part of the HTTP response to the <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request③">CORS-preflight request</a> as well. </p>
   </dl>
   <p>An HTTP response to a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request④">CORS-preflight request</a> can include the following <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header③⑨">headers</a>: </p>
   <dl>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-allow-methods"><code>Access-Control-Allow-Methods</code></dfn>` 
    <dd>
     <p>Indicates which <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method⑧">methods</a> are supported by the <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③④">response</a>’s <a data-link-type="dfn" href="#concept-response-url" id="ref-for-concept-response-url">URL</a> for the purposes of the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol⑦">CORS protocol</a>. </p>
     <p class="note" role="note">The `<code>Allow</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④⓪">header</a> is
  not relevant for the purposes of the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol⑧">CORS protocol</a>. </p>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-allow-headers"><code>Access-Control-Allow-Headers</code></dfn>` 
    <dd>
     <p>Indicates which <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④①">headers</a> are supported by the <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③⑤">response</a>’s <a data-link-type="dfn" href="#concept-response-url" id="ref-for-concept-response-url①">URL</a> for the purposes of the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol⑨">CORS protocol</a>. </p>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-max-age"><code>Access-Control-Max-Age</code></dfn>` 
    <dd>
     <p>Indicates the number of seconds (5 by default) the information provided by the
 `<a data-link-type="http-header" href="#http-access-control-allow-methods" id="ref-for-http-access-control-allow-methods"><code>Access-Control-Allow-Methods</code></a>` and
 `<a data-link-type="http-header" href="#http-access-control-allow-headers" id="ref-for-http-access-control-allow-headers"><code>Access-Control-Allow-Headers</code></a>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④②">headers</a> can be cached. </p>
   </dl>
   <p>An HTTP response to a <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request⑥">CORS request</a> that is not a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request⑤">CORS-preflight request</a> can also include the following <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④③">header</a>: </p>
   <dl>
    <dt>`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-access-control-expose-headers"><code>Access-Control-Expose-Headers</code></dfn>` 
    <dd>
     <p>Indicates which <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④④">headers</a> can be exposed as part
 of the response by listing their <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④①">names</a>. </p>
   </dl>
   <hr>
   <p>In case a server does not wish to participate in the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①⓪">CORS protocol</a>, its HTTP response to
the <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request⑦">CORS</a> or <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request⑥">CORS-preflight request</a> must not include any of the above <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④⑤">headers</a>. The server is encouraged to use the <code>403</code> <a data-link-type="dfn" href="#concept-status" id="ref-for-concept-status④">status</a> in
such HTTP responses. </p>
   <h4 class="heading settled" data-level="3.2.4" id="http-new-header-syntax"><span class="secno">3.2.4. </span><span class="content">HTTP new-header syntax</span><a class="self-link" href="#http-new-header-syntax"></a></h4>
   <p><a data-link-type="dfn" href="#abnf" id="ref-for-abnf④">ABNF</a> for the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②⑤">values</a> of the <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④⑥">headers</a> used by the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①①">CORS protocol</a>: </p>
<pre><code class="lang-abnf highlight"><c- nc>Access-Control-Request-Method</c->    <c- o>=</c-> <a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.1.1" id="ref-for-section-3.1.1①"><c- nc>method</c-></a>
<c- nc>Access-Control-Request-Headers</c->   <c- o>=</c-> <c- o>1</c->#<a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.2" id="ref-for-section-3.2①"><c- nc>field-name</c-></a>

<c- nc>wildcard</c->                         <c- o>=</c-> <c- l>"*"</c->
<c- nc>Access-Control-Allow-Origin</c->      <c- o>=</c-> <c- nc>origin-or-null</c-> <c- o>/</c-> <c- nc>wildcard</c->
<c- nc>Access-Control-Allow-Credentials</c-> <c- o>=</c-> <c- l>%s"true"</c-> <c- c1>; case-sensitive</c->
<c- nc>Access-Control-Expose-Headers</c->    <c- o>=</c-> #<a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.2" id="ref-for-section-3.2②"><c- nc>field-name</c-></a>
<c- nc>Access-Control-Max-Age</c->           <c- o>=</c-> <a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7234#section-1.2.1" id="ref-for-section-1.2.1"><c- nc>delta-seconds</c-></a>
<c- nc>Access-Control-Allow-Methods</c->     <c- o>=</c-> #<a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.1.1" id="ref-for-section-3.1.1②"><c- nc>method</c-></a>
<c- nc>Access-Control-Allow-Headers</c->     <c- o>=</c-> #<a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.2" id="ref-for-section-3.2③"><c- nc>field-name</c-></a>
</code></pre>
   <p class="note" role="note">For `<code>Access-Control-Expose-Headers</code>`,
`<code>Access-Control-Allow-Methods</code>`, and `<code>Access-Control-Allow-Headers</code>`
response <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④⑦">headers</a> the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②⑥">value</a> `<code>*</code>` counts as a wildcard for <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧①">requests</a> without <a data-link-type="dfn" href="#credentials" id="ref-for-credentials②">credentials</a>. For such <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧②">requests</a> there is no
way to solely match a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④⑧">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④②">name</a> or <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method⑨">method</a> that is
`<code>*</code>`. </p>
   <h4 class="heading settled" data-level="3.2.5" id="cors-protocol-and-credentials"><span class="secno">3.2.5. </span><span class="content">CORS protocol and credentials</span><a class="self-link" href="#cors-protocol-and-credentials"></a></h4>
   <p>When <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧③">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode④">credentials mode</a> is "<code>include</code>" it
has an impact on the functioning of the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①②">CORS protocol</a> other than including <a data-link-type="dfn" href="#credentials" id="ref-for-credentials③">credentials</a> in the <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch①⑨">fetch</a>. </p>
   <div class="example" id="example-xhr-credentials">
    <a class="self-link" href="#example-xhr-credentials"></a> 
    <p>In the old days, <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest③">XMLHttpRequest</a></code> could be used to set <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧④">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode⑤">credentials mode</a> to "<code>include</code>": </p>
<pre><code class="lang-javascript highlight"><c- a>var</c-> client <c- o>=</c-> <c- k>new</c-> XMLHttpRequest<c- p>()</c->
client<c- p>.</c->open<c- p>(</c-><c- u>"GET"</c-><c- p>,</c-> <c- u>"./"</c-><c- p>)</c->
client<c- p>.</c->withCredentials <c- o>=</c-> <c- kc>true</c->
<c- d>/* … */</c->
</code></pre>
    <p>Nowadays, <code>fetch("./", { credentials:"include" }).then(/* … */)</code> suffices. </p>
   </div>
   <p>A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧⑤">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode⑥">credentials mode</a> is not necessarily observable
on the server; only when <a data-link-type="dfn" href="#credentials" id="ref-for-credentials④">credentials</a> exist for a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧⑥">request</a> can it be observed by virtue of the <a data-link-type="dfn" href="#credentials" id="ref-for-credentials⑤">credentials</a> being included. Note that even so, a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request⑦">CORS-preflight request</a> never includes <a data-link-type="dfn" href="#credentials" id="ref-for-credentials⑥">credentials</a>. </p>
   <p>The server developer therefore needs to decide whether or not responses "tainted" with <a data-link-type="dfn" href="#credentials" id="ref-for-credentials⑦">credentials</a> can be shared. And also needs to decide if <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧⑦">requests</a> necessitating a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request⑧">CORS-preflight request</a> can
include <a data-link-type="dfn" href="#credentials" id="ref-for-credentials⑧">credentials</a>. Generally speaking, both sharing responses and allowing requests
with <a data-link-type="dfn" href="#credentials" id="ref-for-credentials⑨">credentials</a> is rather unsafe, and extreme care has to be taken to avoid the <a href="https://en.wikipedia.org/wiki/Confused_deputy_problem">confused deputy problem</a>. </p>
   <p>To share responses with <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①⓪">credentials</a>, the
`<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin"><code>Access-Control-Allow-Origin</code></a>` and
`<a data-link-type="http-header" href="#http-access-control-allow-credentials" id="ref-for-http-access-control-allow-credentials"><code>Access-Control-Allow-Credentials</code></a>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header④⑨">headers</a> are
important. The following table serves to illustrate the various legal and illegal combinations for a
request to <code>https://rabbit.invalid/</code>: </p>
   <table>
    <tbody>
     <tr>
      <th>Request’s credentials mode 
      <th>`<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin①"><code>Access-Control-Allow-Origin</code></a>` 
      <th>`<a data-link-type="http-header" href="#http-access-control-allow-credentials" id="ref-for-http-access-control-allow-credentials①"><code>Access-Control-Allow-Credentials</code></a>` 
      <th>Shared? 
      <th>Notes 
     <tr>
      <td>"<code>omit</code>" 
      <td>`<code>*</code>` 
      <td>Omitted 
      <td>✅ 
      <td>—<wbr>
     <tr>
      <td>"<code>omit</code>" 
      <td>`<code>*</code>` 
      <td>`<code>true</code>` 
      <td>✅ 
      <td>If credentials mode is not "<code>include</code>", then
  `<a data-link-type="http-header" href="#http-access-control-allow-credentials" id="ref-for-http-access-control-allow-credentials②"><code>Access-Control-Allow-Credentials</code></a>` is ignored. 
     <tr>
      <td>"<code>omit</code>" 
      <td>`<code>https://rabbit.invalid/`</code> 
      <td>Omitted 
      <td>❌ 
      <td>A serialized origin has no trailing slash. 
     <tr>
      <td>"<code>omit</code>" 
      <td>`<code>https://rabbit.invalid`</code> 
      <td>Omitted 
      <td>✅ 
      <td>—<wbr>
     <tr>
      <td>"<code>include</code>" 
      <td>`<code>*</code>` 
      <td>`<code>true</code>` 
      <td>❌ 
      <td>If credentials mode is "<code>include</code>", then
  `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin②"><code>Access-Control-Allow-Origin</code></a>` cannot be
  `<code>*</code>`. 
     <tr>
      <td>"<code>include</code>" 
      <td>`<code>https://rabbit.invalid`</code> 
      <td>`<code>true</code>` 
      <td>✅ 
      <td>—<wbr>
     <tr>
      <td>"<code>include</code>" 
      <td>`<code>https://rabbit.invalid`</code> 
      <td>`<code>True</code>` 
      <td>❌ 
      <td>`<code>true</code>` is (byte) case-sensitive. 
   </table>
   <p>Similarly, `<a data-link-type="http-header" href="#http-access-control-expose-headers" id="ref-for-http-access-control-expose-headers①"><code>Access-Control-Expose-Headers</code></a>`,
`<a data-link-type="http-header" href="#http-access-control-allow-methods" id="ref-for-http-access-control-allow-methods①"><code>Access-Control-Allow-Methods</code></a>`, and
`<a data-link-type="http-header" href="#http-access-control-allow-headers" id="ref-for-http-access-control-allow-headers①"><code>Access-Control-Allow-Headers</code></a>` response headers can only use
`<code>*</code>` as value when <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧⑧">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode⑦">credentials mode</a> is not
"<code>include</code>". </p>
   <h4 class="heading settled" data-level="3.2.6" id="cors-protocol-examples"><span class="secno">3.2.6. </span><span class="content">Examples</span><a class="self-link" href="#cors-protocol-examples"></a></h4>
   <div class="example" id="example-simple-cors">
    <a class="self-link" href="#example-simple-cors"></a> 
    <p>A script at <code>https://foo.invalid/</code> wants to fetch some data from <code>https://bar.invalid/</code>. (Neither <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①①">credentials</a> nor response header access is
 important.) </p>
<pre id="unicorn"><code class="lang-javascript highlight"><c- a>var</c-> url <c- o>=</c-> <c- u>"https://bar.invalid/api?key=730d67a37d7f3d802e96396d00280768773813fbe726d116944d814422fc1a45&amp;data=about:unicorn"</c-><c- p>;</c->
fetch<c- p>(</c->url<c- p>).</c->then<c- p>(</c->success<c- p>,</c-> failure<c- p>)</c->
</code></pre>
    <p>This will use the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①③">CORS protocol</a>, though this is entirely transparent to the
 developer from <code>foo.invalid</code>. As part of the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①④">CORS protocol</a>, the user agent
 will include the `<a data-link-type="http-header" href="#http-origin" id="ref-for-http-origin⑥"><code>Origin</code></a>` header in the request: </p>
<pre><code class="lang-http highlight">Origin: https://foo.invalid
</code></pre>
    <p>Upon receiving a response from <code>bar.invalid</code>, the user agent will verify the
 `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin③"><code>Access-Control-Allow-Origin</code></a>` response header. If its value is
 either `<code>https://foo.invalid</code>` or `<code>*</code>`, the user agent will invoke the <code>success</code> callback. If it has any other value, or is missing, the user agent will invoke
 the <code>failure</code> callback. </p>
   </div>
   <div class="example" id="example-cors-with-response-header">
    <a class="self-link" href="#example-cors-with-response-header"></a> 
    <p>The developer of <code>foo.invalid</code> is back, and now wants to fetch some data from <code>bar.invalid</code> while also accessing a response header. </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c->url<c- p>).</c->then<c- p>(</c->response <c- p>=></c-> <c- p>{</c->
  <c- a>var</c-> hsts <c- o>=</c-> response<c- p>.</c->headers<c- p>.</c->get<c- p>(</c-><c- u>"strict-transport-security"</c-><c- p>),</c->
      csp <c- o>=</c-> response<c- p>.</c->headers<c- p>.</c->get<c- p>(</c-><c- u>"content-security-policy"</c-><c- p>)</c->
  log<c- p>(</c->hsts<c- p>,</c-> csp<c- p>)</c->
<c- p>})</c->
</code></pre>
    <p><code>bar.invalid</code> provides a correct
 `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin④"><code>Access-Control-Allow-Origin</code></a>` response header per the earlier
 example. The values of <code>hsts</code> and <code>csp</code> will depend on the
 `<a data-link-type="http-header" href="#http-access-control-expose-headers" id="ref-for-http-access-control-expose-headers②"><code>Access-Control-Expose-Headers</code></a>` response header. For example, if
 the response included the following headers </p>
<pre><code class="lang-http highlight">Content-Security-Policy: default-src 'self'
Strict-Transport-Security: max-age=31536000; includeSubdomains; preload
Access-Control-Expose-Headers: Content-Security-Policy
</code></pre>
    <p>then <code>hsts</code> would be null and <code>csp</code> would be
 "<code>default-src 'self'</code>", even though the response did include both headers. This is
 because <code>bar.invalid</code> needs to explicitly share each header by listing their names in
 the `<a data-link-type="http-header" href="#http-access-control-expose-headers" id="ref-for-http-access-control-expose-headers③"><code>Access-Control-Expose-Headers</code></a>` response header. </p>
    <p>Alternatively, if <code>bar.invalid</code> wanted to share all its response headers, for
 requests that do not include <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①②">credentials</a>, it could use `<code>*</code>` as value for
 the `<a data-link-type="http-header" href="#http-access-control-expose-headers" id="ref-for-http-access-control-expose-headers④"><code>Access-Control-Expose-Headers</code></a>` response header. If the request
 would have included <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①③">credentials</a>, the response header names would have to be listed
 explicitly and `<code>*</code>` could not be used. </p>
   </div>
   <div class="example" id="example-cors-with-credentials">
    <a class="self-link" href="#example-cors-with-credentials"></a> 
    <p>The developer of <code>foo.invalid</code> returns, now fetching some data from <code>bar.invalid</code> while including <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①④">credentials</a>. This time around the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①⑤">CORS protocol</a> is no longer transparent to the developer as <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①⑤">credentials</a> require an explicit opt-in: </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c->url<c- p>,</c-> <c- p>{</c-> credentials<c- o>:</c-><c- u>"include"</c-> <c- p>}).</c->then<c- p>(</c->success<c- p>,</c-> failure<c- p>)</c->
</code></pre>
    <p>This also makes any `<code>Set-Cookie</code>` response headers <code>bar.invalid</code> includes fully functional (they are ignored otherwise). </p>
    <p>The user agent will make sure to include any relevant <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①⑥">credentials</a> in the request.
 It will also put stricter requirements on the response. Not only will <code>bar.invalid</code> need
 to list `<code>https://foo.invalid</code>` as value for the
 `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin⑤"><code>Access-Control-Allow-Origin</code></a>` header (`<code>*</code>` is not
 allowed when <a data-link-type="dfn" href="#credentials" id="ref-for-credentials①⑦">credentials</a> are involved), the
 `<a data-link-type="http-header" href="#http-access-control-allow-credentials" id="ref-for-http-access-control-allow-credentials③"><code>Access-Control-Allow-Credentials</code></a>` header has to be present too: </p>
<pre><code class="lang-http highlight">Access-Control-Allow-Origin: https://foo.invalid
Access-Control-Allow-Credentials: true
</code></pre>
    <p>If the response does not include those two headers with those values, the <code>failure</code> callback will be invoked. However, any `<code>Set-Cookie</code>` response headers will be
 respected. </p>
   </div>
   <h4 class="heading settled" data-level="3.2.7" id="cors-protocol-exceptions"><span class="secno">3.2.7. </span><span class="content">CORS protocol exceptions</span><a class="self-link" href="#cors-protocol-exceptions"></a></h4>
   <p>Specifications have allowed limited exceptions to the CORS safelist for non-safelisted
`<code>Content-Type</code>` header values. These exceptions are made for requests that can be
triggered by web content but whose headers and bodies can be only minimally controlled by the web
content. Therefore, servers should expect cross-origin web content to be allowed to trigger
non-preflighted requests with the following non-safelisted `<code>Content-Type</code>` header
values: </p>
   <ul class="brief">
    <li>`<code>application/csp-report</code>` <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> 
    <li>`<code>application/expect-ct-report+json</code>` <a data-link-type="biblio" href="#biblio-expect-ct">[EXPECT-CT]</a> 
    <li>`<code>application/xss-auditor-report</code>` 
    <li>`<code>application/ocsp-request</code>` <a data-link-type="biblio" href="#biblio-ocsp">[OCSP]</a> 
   </ul>
   <p>Specifications should avoid introducing new exceptions and should only do so with careful
consideration for the security consequences. New exceptions can be proposed by <a href="https://github.com/whatwg/fetch/issues/new">filing an issue</a>. </p>
   <h3 class="heading settled" data-level="3.3" id="content-type-header"><span class="secno">3.3. </span><span class="content">`<code>Content-Type</code>` header</span><a class="self-link" href="#content-type-header"></a></h3>
   <p>The `<code>Content-Type</code>` header is largely defined in HTTP. Its processing model is
defined here as the ABNF defined in HTTP is not compatible with web content. <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="header list" data-dfn-type="dfn" data-export data-lt="extract a MIME type|extracting a MIME type" id="concept-header-extract-mime-type">extract a MIME type</dfn> from a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①⑦">header list</a> <var>headers</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>charset</var> be null. </p>
    <li>
     <p>Let <var>essence</var> be null. </p>
    <li>
     <p>Let <var>mimeType</var> be null. </p>
    <li>
     <p>Let <var>values</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get-decode-split" id="ref-for-concept-header-list-get-decode-split②">getting, decoding, and splitting</a> `<code>Content-Type</code>` from <var>headers</var>. </p>
    <li>
     <p>If <var>values</var> is null, then return failure. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate④">For each</a> <var>value</var> of <var>values</var>: </p>
     <ol>
      <li>
       <p>Let <var>temporaryMimeType</var> be the result of <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parse-a-mime-type" id="ref-for-parse-a-mime-type②">parsing</a> <var>value</var>. </p>
      <li>
       <p>If <var>temporaryMimeType</var> is failure or its <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence③">essence</a> is
   "<code>*/*</code>", then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue①">continue</a>. </p>
      <li>
       <p>Set <var>mimeType</var> to <var>temporaryMimeType</var>. </p>
      <li>
       <p>If <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence④">essence</a> is not <var>essence</var>, then: </p>
       <ol>
        <li>
         <p>Set <var>charset</var> to null. </p>
        <li>
         <p>If <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parameters" id="ref-for-parameters">parameters</a>["<code>charset</code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists">exists</a>, then set <var>charset</var> to <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parameters" id="ref-for-parameters①">parameters</a>["<code>charset</code>"]. </p>
        <li>
         <p>Set <var>essence</var> to <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence⑤">essence</a>. </p>
       </ol>
      <li>
       <p>Otherwise, if <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parameters" id="ref-for-parameters②">parameters</a>["<code>charset</code>"] does not <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①">exist</a>, and <var>charset</var> is non-null, set <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parameters" id="ref-for-parameters③">parameters</a>["<code>charset</code>"] to <var>charset</var>. </p>
     </ol>
    <li>
     <p>If <var>mimeType</var> is null, then return failure. </p>
    <li>
     <p>Return <var>mimeType</var>. </p>
   </ol>
   <p class="warning">When <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type③">extract a MIME type</a> returns failure or a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type" id="ref-for-mime-type①">MIME type</a> whose <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence⑥">essence</a> is incorrect for a given format, treat this as a fatal error.
Existing web platform features have not always followed this pattern, which has been a major source
of security vulnerabilities in those features over the years. In contrast, a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type" id="ref-for-mime-type②">MIME type</a>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parameters" id="ref-for-parameters④">parameters</a> can typically be safely ignored. </p>
   <div class="example" id="example-extract-a-mime-type">
    <a class="self-link" href="#example-extract-a-mime-type"></a> 
    <p>This is how <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type④">extract a MIME type</a> functions in practice: </p>
    <table>
     <tbody>
      <tr>
       <th>Headers (as on the network) 
       <th>Output (<a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#serialize-a-mime-type" id="ref-for-serialize-a-mime-type">serialized</a>) 
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/plain;charset=gbk, text/html
</code></pre>
       <td><code>text/html</code> 
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/html;charset=gbk;a=b, text/html;x=y
</code></pre>
       <td rowspan="2"><code>text/html;x=y;charset=gbk</code> 
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/html;charset=gbk;a=b
Content-Type: text/html;x=y
</code></pre>
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/html;charset=gbk
Content-Type: x/x
Content-Type: text/html;x=y
</code></pre>
       <td><code>text/html;x=y</code> 
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/html
Content-Type: cannot-parse
</code></pre>
       <td rowspan="3"><code>text/html</code> 
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/html
Content-Type: */*
</code></pre>
      <tr>
       <td>
<pre><code class="lang-http highlight">Content-Type: text/html
Content-Type:
</code></pre>
    </table>
   </div>
   <h3 class="heading settled" data-level="3.4" id="x-content-type-options-header"><span class="secno">3.4. </span><span class="content">`<code>X-Content-Type-Options</code>` header</span><a class="self-link" href="#x-content-type-options-header"></a></h3>
   <p>The
`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-x-content-type-options"><code>X-Content-Type-Options</code></dfn>`
response <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤⓪">header</a> can be used to require checking of a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③⑥">response</a>’s
`<code>Content-Type</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤①">header</a> against the <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①⓪">destination</a> of a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑧⑨">request</a>. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="determine-nosniff">determine nosniff</dfn>, given a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①⑧">header list</a> <var>list</var>, run
these steps: </p>
   <ol>
    <li>
     <p>Let <var>values</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get-decode-split" id="ref-for-concept-header-list-get-decode-split③">getting, decoding, and splitting</a> `<a data-link-type="http-header" href="#http-x-content-type-options" id="ref-for-http-x-content-type-options"><code>X-Content-Type-Options</code></a>` from <var>list</var>. </p>
    <li>
     <p>If <var>values</var> is null, then return false. </p>
    <li>
     <p>If <var>values</var>[0] is an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive">ASCII case-insensitive</a> match for
 "<code>nosniff</code>", then return true. </p>
    <li>
     <p>Return false. </p>
   </ol>
   <p>Web developers and conformance checkers must use the following <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②⑦">value</a> <a data-link-type="dfn" href="#abnf" id="ref-for-abnf⑤">ABNF</a> for `<a data-link-type="http-header" href="#http-x-content-type-options" id="ref-for-http-x-content-type-options①"><code>X-Content-Type-Options</code></a>`: </p>
<pre><code class="lang-abnf highlight"><c- nc>X-Content-Type-Options</c->           <c- o>=</c-> <c- l>"nosniff"</c-> <c- c1>; case-insensitive</c->
</code></pre>
   <h4 class="heading settled dfn-paneled" data-dfn-type="dfn" data-level="3.4.1" data-lt="should response to request be blocked due to nosniff" data-noexport id="should-response-to-request-be-blocked-due-to-nosniff?"><span class="secno">3.4.1. </span><span class="content">Should <var>response</var> to <var>request</var> be blocked due to nosniff?</span></h4>
   <p>Run these steps: </p>
   <ol>
    <li>
     <p>If <a data-link-type="dfn" href="#determine-nosniff" id="ref-for-determine-nosniff">determine nosniff</a> with <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list⑧">header list</a> is
 false, then return <b>allowed</b>. </p>
    <li>
     <p>Let <var>mimeType</var> be the result of <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type⑤">extracting a MIME type</a> from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list⑨">header list</a>. </p>
    <li>
     <p>Let <var>destination</var> be <var>request</var>’s <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①①">destination</a>. </p>
    <li>
     <p>If <var>destination</var> is <a data-link-type="dfn" href="#request-destination-script-like" id="ref-for-request-destination-script-like②">script-like</a> and <var>mimeType</var> is failure or is not a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#javascript-mime-type" id="ref-for-javascript-mime-type">JavaScript MIME type</a>, then return <b>blocked</b>. </p>
    <li>
     <p>If <var>destination</var> is "<code>style</code>" and <var>mimeType</var> is failure or its <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence⑦">essence</a> is not "<code>text/css</code>", then return <b>blocked</b>. </p>
    <li>
     <p>Return <b>allowed</b>. </p>
   </ol>
   <p class="note no-backref" role="note">Only <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨⓪">request</a> <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①②">destinations</a> that are <a data-link-type="dfn" href="#request-destination-script-like" id="ref-for-request-destination-script-like③">script-like</a> or "<code>style</code>" are considered as any exploits
pertain to them. Also, considering "<code>image</code>" was not compatible with deployed content. </p>
   <h3 class="heading settled" data-level="3.5" id="corb"><span class="secno">3.5. </span><span class="content">CORB</span><a class="self-link" href="#corb"></a></h3>
   <p class="note" role="note">Cross-origin read blocking, better known as CORB, is an algorithm which identifies
dubious cross-origin resource fetches (e.g., fetches that would fail anyway like attempts to render
JSON inside an <code>img</code> element) and blocks them before they reach a web page. CORB reduces
the risk of leaking sensitive data by keeping it further from cross-origin web pages. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="corb-protected-mime-type">CORB-protected MIME type</dfn> is an <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#html-mime-type" id="ref-for-html-mime-type">HTML MIME type</a>, a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#json-mime-type" id="ref-for-json-mime-type">JSON MIME type</a>, or an <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#xml-mime-type" id="ref-for-xml-mime-type">XML MIME type</a> excluding <code>image/svg+xml</code>. </p>
   <p class="note no-backref" role="note">Even without CORB, accessing the content of cross-origin resources with <a data-link-type="dfn" href="#corb-protected-mime-type" id="ref-for-corb-protected-mime-type">CORB-protected MIME types</a> is either managed by the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①⑥">CORS protocol</a> (e.g., in case of <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest④">XMLHttpRequest</a></code>), not observable (e.g., in case of pings or CSP reports which ignore the
response), or would result in an error (e.g., when failing to decode an HTML document embedded in an <code>img</code> element as an image). This means that CORB can block <a data-link-type="dfn" href="#corb-protected-mime-type" id="ref-for-corb-protected-mime-type①">CORB-protected MIME types</a> resources without being disruptive to web pages. </p>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="corb-check">CORB check</dfn>, given a <var>request</var> and <var>response</var>,
run these steps:</p>
   <ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator③">initiator</a> is "<code>download</code>", then return <b>allowed</b>. </p>
     <p class="XXX">If we recast downloading as navigation this step can be removed. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url⑤">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme⑦">scheme</a> is not an <a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme②">HTTP(S) scheme</a>, then return <b>allowed</b>. </p>
    <li>
     <p>Let <var>mimeType</var> be the result of <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type⑥">extracting a MIME type</a> from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①⓪">header list</a>. </p>
    <li>
     <p>If <var>mimeType</var> is failure, then return <b>allowed</b>. </p>
    <li>
     <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status③">status</a> is <code>206</code> and <var>mimeType</var> is a <a data-link-type="dfn" href="#corb-protected-mime-type" id="ref-for-corb-protected-mime-type②">CORB-protected MIME type</a>, then return <b>blocked</b>. </p>
    <li>
     <p>If <a data-link-type="dfn" href="#determine-nosniff" id="ref-for-determine-nosniff①">determine nosniff</a> with <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①①">header list</a> is true
  and <var>mimeType</var> is a <a data-link-type="dfn" href="#corb-protected-mime-type" id="ref-for-corb-protected-mime-type③">CORB-protected MIME type</a> or its <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence⑧">essence</a> is "<code>text/plain</code>", then return <b>blocked</b>. </p>
     <p class="note no-backref" role="note">CORB only protects <code>text/plain</code> responses with a
  `<code>X-Content-Type-Options: nosniff</code>` header. Unfortunately, protecting such responses
  without that header when their <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status④">status</a> is <code>206</code> would break too many
  existing video responses that have a <code>text/plain</code> <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type" id="ref-for-mime-type③">MIME type</a>. </p>
    <li>
     <p>Return <b>allowed</b>. </p>
   </ol>
   <h3 class="heading settled" data-level="3.6" id="cross-origin-resource-policy-header"><span class="secno">3.6. </span><span class="content">`<code>Cross-Origin-Resource-Policy</code>` header</span><a class="self-link" href="#cross-origin-resource-policy-header"></a></h3>
   <p>The
`<dfn class="dfn-paneled" data-dfn-type="http-header" data-export id="http-cross-origin-resource-policy"><code>Cross-Origin-Resource-Policy</code></dfn>`
response <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤②">header</a> can be used to require checking a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨①">request</a>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url⑥">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin①">origin</a> against a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨②">request</a>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin④">origin</a> when <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨③">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode⑤">mode</a> is
"<code>no-cors</code>". </p>
   <p>Its <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②⑧">value</a> <a data-link-type="dfn" href="#abnf" id="ref-for-abnf⑥">ABNF</a>: </p>
<pre><code class="lang-abnf highlight"><c- nc>Cross-Origin-Resource-Policy</c->     <c- o>=</c-> <c- l>%s"same-origin"</c-> <c- o>/</c-> <c- l>%s"same-site"</c-> <c- o>/</c-> <c- l>%s"cross-origin"</c-> <c- c1>; case-sensitive</c->
</code></pre>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="cross-origin-resource-policy-check">cross-origin resource policy check</dfn>, given a <var>request</var> and <var>response</var>, run these steps:</p>
   <ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode⑥">mode</a> is not "<code>no-cors</code>", then return <b>allowed</b>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin⑤">origin</a> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin①">same origin</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url⑦">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin②">origin</a>, then return <b>allowed</b>. </p>
     <p class="note no-backref" role="note">While redirects that carry  a
  `<a data-link-type="http-header" href="#http-cross-origin-resource-policy" id="ref-for-http-cross-origin-resource-policy"><code>Cross-Origin-Resource-Policy</code></a>` header are checked, redirects
  without such a header resulting in <var>response</var> do not affect the outcome as the default is <b>allowed</b>. </p>
    <li>
     <p>Let <var>policy</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get③">getting</a> `<a data-link-type="http-header" href="#http-cross-origin-resource-policy" id="ref-for-http-cross-origin-resource-policy①"><code>Cross-Origin-Resource-Policy</code></a>` from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①②">header list</a>. </p>
     <p class="note" role="note">This means that `<code>Cross-Origin-Resource-Policy: same-site, same-origin</code>`
  ends up as <b>allowed</b> below as it will never match anything. Two or more
  `<a data-link-type="http-header" href="#http-cross-origin-resource-policy" id="ref-for-http-cross-origin-resource-policy②"><code>Cross-Origin-Resource-Policy</code></a>` headers will have the same effect. </p>
    <li>
     <p>If <var>policy</var> is `<code>same-origin</code>`, then return <b>blocked</b>. </p>
    <li>
     <p>If the following are true </p>
     <ul class="brief">
      <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin⑥">origin</a> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#schemelessly-same-site" id="ref-for-schemelessly-same-site">schemelessly same site</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url⑧">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin③">origin</a> 
      <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin⑦">origin</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme⑧">scheme</a> is
   "<code>https</code>" or <var>response</var>’s <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state①">HTTPS state</a> is
   "<code>none</code>" 
     </ul>
     <p>then return <b>allowed</b>. </p>
     <p class="note" role="note">This prevents HTTPS responses with
  `<code>Cross-Origin-Resource-Policy: same-site</code>` from being accessed without secure
  transport. </p>
    <li>
     <p>If <var>policy</var> is `<code>same-site</code>`, then return <b>blocked</b>. </p>
    <li>
     <p>Return <b>allowed</b>. </p>
   </ol>
   <h2 class="heading settled" data-level="4" id="fetching"><span class="secno">4. </span><span class="content">Fetching</span><a class="self-link" href="#fetching"></a></h2>
   <div class="note no-backref" role="note">
    <p>The algorithm below defines <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②⓪">fetching</a>. In broad
 strokes, it takes a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨④">request</a> and outputs a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③⑦">response</a>. </p>
    <p>That is, it either returns a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③⑧">response</a> if <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨⑤">request</a>’s <a data-link-type="dfn" href="#synchronous-flag" id="ref-for-synchronous-flag">synchronous flag</a> is set, or it <a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task④">queues tasks</a> annotated <a data-link-type="dfn" href="#process-response" id="ref-for-process-response">process response</a>, <a data-link-type="dfn" href="#process-response-end-of-body" id="ref-for-process-response-end-of-body">process response end-of-body</a>, and <a data-link-type="dfn" href="#process-response-done" id="ref-for-process-response-done">process response done</a> for the <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response③⑨">response</a>. </p>
    <p>To capture uploads, if <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨⑥">request</a>’s <a data-link-type="dfn" href="#synchronous-flag" id="ref-for-synchronous-flag①">synchronous flag</a> is unset, <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-task" id="ref-for-concept-task①">tasks</a> annotated <a data-link-type="dfn" href="#process-request-body" id="ref-for-process-request-body①">process request body</a> and <a data-link-type="dfn" href="#process-request-end-of-body" id="ref-for-process-request-end-of-body③">process request end-of-body</a> for the <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨⑦">request</a> can be <a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task⑤">queued</a>. </p>
   </div>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-fetch">fetch</dfn> using <var>request</var>, run
the steps below. An ongoing <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②①">fetch</a> can be <dfn class="dfn-paneled" data-dfn-for="fetch" data-dfn-type="dfn" data-export id="concept-fetch-terminate">terminated</dfn> with flag <var>aborted</var>,
which is unset unless otherwise specified. </p>
   <p>The user agent may be asked to <dfn class="dfn-paneled" data-dfn-for="fetch" data-dfn-type="dfn" data-export id="concept-fetch-suspend">suspend</dfn> the ongoing fetch.
The user agent may either accept or ignore the suspension request. The suspended fetch can be <dfn class="dfn-paneled" data-dfn-for="fetch" data-dfn-type="dfn" data-export id="concept-fetch-resume">resumed</dfn>. The user agent should
ignore the suspension request if the ongoing fetch is updating the response in the HTTP cache for
the request. </p>
   <p class="note no-backref" role="note">The user agent does not update the entry in the HTTP cache for a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨⑧">request</a> if request’s cache mode is "no-store" or a
`<code>Cache-Control: no-store</code>` header appears in the response. <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> </p>
   <ol>
    <li>
     <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when②">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate⑤">terminated</a>: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window①">window</a> is
   "<code>client</code>", set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window②">window</a> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client④">client</a>, if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client⑤">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global" id="ref-for-concept-settings-object-global①">global object</a> is a <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window①">Window</a></code> object, and to "<code>no-window</code>"
   otherwise. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin⑧">origin</a> is
   "<code>client</code>", set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin⑨">origin</a> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client⑥">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin">origin</a>. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑤">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains⑧">does not contain</a> `<code>Accept</code>`, then: </p>
       <ol>
        <li>
         <p>Let <var>value</var> be `<code>*/*</code>`. </p>
        <li>
         <p>If <var>request</var> is a <a data-link-type="dfn" href="#navigation-request" id="ref-for-navigation-request③">navigation request</a>, a user agent should set <var>value</var> to
     `<code>text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8</code>`. </p>
        <li>
         <p>Otherwise, a user agent should set <var>value</var> to the first matching statement, if
      any, switching on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①③">destination</a>: </p>
         <dl class="switch">
          <dt>"<code>image</code>" 
          <dd>`<code>image/png,image/svg+xml,image/*;q=0.8,*/*;q=0.5</code>` 
          <dt>"<code>style</code>" 
          <dd>`<code>text/css,*/*;q=0.1</code>` 
         </dl>
        <li>
         <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append③">Append</a> `<code>Accept</code>`/<var>value</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑥">header list</a>. </p>
       </ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑦">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains⑨">does not contain</a> `<code>Accept-Language</code>`, user agents should <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append④">append</a> `<code>Accept-Language</code>`/an appropriate <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value②⑨">value</a> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑧">header list</a>. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-priority" id="ref-for-concept-request-priority">priority</a> is null, then use <var>request</var>’s <a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator④">initiator</a> and <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①④">destination</a> appropriately in setting <var>request</var>’s <a data-link-type="dfn" href="#concept-request-priority" id="ref-for-concept-request-priority①">priority</a> to a user-agent-defined object. </p>
       <p class="note" role="note">The user-agent-defined object could encompass stream weight and dependency
    for HTTP/2, and equivalent information used to prioritize dispatch and processing of
    HTTP/1 fetches. </p>
      <li>
       <p>If <var>request</var> is a <a data-link-type="dfn" href="#subresource-request" id="ref-for-subresource-request">subresource request</a>, then: </p>
       <ol>
        <li>
         <p>Let <var>record</var> be a new <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record④">fetch record</a> consisting of <var>request</var> and this instance of the <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②②">fetch</a> algorithm. </p>
        <li>
         <p>Append <var>record</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client⑦">client</a>’s <a data-link-type="dfn" href="#concept-fetch-group" id="ref-for-concept-fetch-group②">fetch group</a> list of <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record⑤">fetch records</a>. </p>
       </ol>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted②">If aborted</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
      <li>
       <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error">aborted network error</a>. </p>
      <li>
       <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑦">network error</a>. </p>
     </ol>
    <li>
     <p>Return the result of performing a <a data-link-type="dfn" href="#concept-main-fetch" id="ref-for-concept-main-fetch">main fetch</a> using <var>request</var>. </p>
   </ol>
   <h3 class="heading settled" data-level="4.1" id="main-fetch"><span class="secno">4.1. </span><span class="content">Main fetch</span><a class="self-link" href="#main-fetch"></a></h3>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-for="main" data-dfn-type="dfn" data-noexport id="concept-main-fetch">main fetch</dfn> using <var>request</var>,
optionally with a <i>recursive flag</i>, run these steps: </p>
   <p class="note" role="note">When <a data-link-type="dfn" href="#concept-main-fetch" id="ref-for-concept-main-fetch①">main fetch</a> is invoked recursively <i>recursive flag</i> is set. </p>
   <ol>
    <li>
     <p>Let <var>response</var> be null. </p>
    <li>
     <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when③">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate⑥">terminated</a>: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#local-urls-only-flag" id="ref-for-local-urls-only-flag">local-URLs-only flag</a> is set and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url⑨">current URL</a> is not <a data-link-type="dfn" href="#is-local" id="ref-for-is-local">local</a>, then set <var>response</var> to
   a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑧">network error</a>. </p>
      <li>
       <p>Execute <a href="https://w3c.github.io/webappsec-csp/#report-for-request">Report Content Security Policy violations for <var>request</var></a>. <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> </p>
      <li>
       <p><a href="https://w3c.github.io/webappsec-upgrade-insecure-requests/#upgrade-request">Upgrade <var>request</var> to a potentially secure URL, if appropriate</a>. <a data-link-type="biblio" href="#biblio-upgrade">[UPGRADE]</a> </p>
      <li>
       <p>If <a data-link-type="dfn" href="#block-bad-port" id="ref-for-block-bad-port">should fetching <var>request</var> be blocked due to a bad port</a>, <a href="https://w3c.github.io/webappsec-mixed-content/#should-block-fetch">should fetching <var>request</var> be blocked as mixed content</a>,
   or <a href="https://w3c.github.io/webappsec-csp/#should-block-request">should fetching <var>request</var> be blocked by Content Security Policy</a> returns <b>blocked</b>, set <var>response</var> to a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑨">network error</a>. <a data-link-type="biblio" href="#biblio-mix">[MIX]</a> <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy②">referrer policy</a> is the empty string and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client⑧">client</a> is non-null, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy③">referrer policy</a> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client⑨">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-referrer-policy" id="ref-for-concept-settings-object-referrer-policy">referrer policy</a>. <a data-link-type="biblio" href="#biblio-referrer">[REFERRER]</a> </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy④">referrer policy</a> is the empty string, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy⑤">referrer policy</a> to
    "<code>no-referrer-when-downgrade</code>". </p>
       <p class="note no-backref" role="note">We use "<code>no-referrer-when-downgrade</code>" because it is the
    historical default. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①">referrer</a> is not "<code>no-referrer</code>", set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer②">referrer</a> to the result of invoking <a data-link-type="dfn" href="https://w3c.github.io/webappsec-referrer-policy/#determine-requests-referrer" id="ref-for-determine-requests-referrer">determine <var>request</var>’s referrer</a>. <a data-link-type="biblio" href="#biblio-referrer">[REFERRER]</a> </p>
       <p class="note no-backref" role="note">As stated in <cite>Referrer Policy</cite>, user agents can
    provide the end user with options to override <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer③">referrer</a> to "<code>no-referrer</code>" or
    have it expose less sensitive information. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①⓪">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme⑨">scheme</a> is
    "<code>ftp</code>", <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①⓪">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-creation-url" id="ref-for-concept-environment-creation-url">creation URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①⓪">scheme</a> is not "<code>ftp</code>", and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-reserved-client" id="ref-for-concept-request-reserved-client">reserved client</a> is either null or an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment" id="ref-for-environment②">environment</a> whose <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-target-browsing-context" id="ref-for-concept-environment-target-browsing-context①">target browsing context</a> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context" id="ref-for-nested-browsing-context">nested browsing context</a>, then set <var>response</var> to a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①⓪">network error</a>. </p>
      <li>
       <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①①">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①①">scheme</a> to
    "<code>https</code>" if all of the following conditions are true: </p>
       <ul class="brief">
        <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①②">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①②">scheme</a> is
     "<code>http</code>" 
        <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①③">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-host" id="ref-for-concept-url-host①">host</a> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-domain" id="ref-for-concept-domain">domain</a> 
        <li>Matching <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①④">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-host" id="ref-for-concept-url-host②">host</a> per <a href="https://tools.ietf.org/html/rfc6797#section-8.2">Known HSTS Host Domain Name Matching</a> results in either a superdomain match with an asserted <code>includeSubDomains</code> directive
     or a congruent match (with or without an asserted <code>includeSubDomains</code> directive). <a data-link-type="biblio" href="#biblio-hsts">[HSTS]</a> 
       </ul>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted③">If aborted</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
      <li>
       <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error①">aborted network error</a>. </p>
      <li>
       <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①①">network error</a>. </p>
     </ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#synchronous-flag" id="ref-for-synchronous-flag②">synchronous flag</a> is unset and <i>recursive flag</i> is unset, run the remaining steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel①">in parallel</a>. </p>
    <li>
     <p>If <var>response</var> is null, then set <var>response</var> to the result of running the steps
  corresponding to the first matching statement: </p>
     <dl class="switch">
      <dt><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①⑤">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin④">origin</a> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin②">same origin</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①⓪">origin</a>, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting③">response tainting</a> is "<code>basic</code>" 
      <dt><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①⑥">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①③">scheme</a> is
   "<code>data</code>" 
      <dt><var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode⑦">mode</a> is
   "<code>navigate</code>" or "<code>websocket</code>" 
      <dd>
       <ol>
        <li>
         <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting④">response tainting</a> to "<code>basic</code>". </p>
        <li>
         <p>Return the result of performing a <a data-link-type="dfn" href="#concept-scheme-fetch" id="ref-for-concept-scheme-fetch">scheme fetch</a> using <var>request</var>. </p>
       </ol>
       <p class="note no-backref" role="note">HTML assigns any documents and workers created from <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url⑨">URLs</a> whose <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①④">scheme</a> is "<code>data</code>" a unique <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin-opaque" id="ref-for-concept-origin-opaque">opaque origin</a>. Service
    workers can only be created from <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①⓪">URLs</a> whose <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①⑤">scheme</a> is an <a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme③">HTTP(S) scheme</a>. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> <a data-link-type="biblio" href="#biblio-sw">[SW]</a> </p>
      <dt><var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode⑧">mode</a> is
   "<code>same-origin</code>" 
      <dd>
       <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①②">network error</a>. </p>
      <dt><var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode⑨">mode</a> is
   "<code>no-cors</code>" 
      <dd>
       <ol>
        <li>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode①">redirect mode</a> is not "<code>follow</code>",
     then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①③">network error</a>. </p>
        <li>
         <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting⑤">response tainting</a> to
     "<code>opaque</code>". </p>
        <li>
         <p>Let <var>noCorsResponse</var> be the result of performing a <a data-link-type="dfn" href="#concept-scheme-fetch" id="ref-for-concept-scheme-fetch①">scheme fetch</a> using <var>request</var>. </p>
        <li>
         <p>If <var>noCorsResponse</var> is a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response⑦">filtered response</a> or the <a data-link-type="dfn" href="#corb-check" id="ref-for-corb-check">CORB check</a> with <var>request</var> and <var>noCorsResponse</var> returns <b>allowed</b>, then return <var>noCorsResponse</var>. </p>
        <li>
         <p>Return a new <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④⓪">response</a> whose <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status⑤">status</a> is <var>noCorsResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status⑥">status</a>, <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state②">HTTPS state</a> is <var>noCorsResponse</var>’s <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state③">HTTPS state</a>, and <a data-link-type="dfn" href="#concept-response-csp-list" id="ref-for-concept-response-csp-list">CSP list</a> is <var>noCorsResponse</var>’s <a data-link-type="dfn" href="#concept-response-csp-list" id="ref-for-concept-response-csp-list①">CSP list</a>. </p>
         <p class="warning">This is only an effective defense against side channel attacks if <var>noCorsResponse</var> is kept isolated from the process that initiated the request. </p>
       </ol>
      <dt><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①⑦">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①⑥">scheme</a> is not an <a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme④">HTTP(S) scheme</a> 
      <dd>
       <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①④">network error</a>. </p>
      <dt><var>request</var>’s <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag②">use-CORS-preflight flag</a> is set 
      <dt><var>request</var>’s <a data-link-type="dfn" href="#unsafe-request-flag" id="ref-for-unsafe-request-flag①">unsafe-request flag</a> is set and either <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method④">method</a> is not a <a data-link-type="dfn" href="#cors-safelisted-method" id="ref-for-cors-safelisted-method①">CORS-safelisted method</a> or <a data-link-type="dfn" href="#cors-unsafe-request-header-names" id="ref-for-cors-unsafe-request-header-names">CORS-unsafe request-header names</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑨">header list</a> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty">is not empty</a> 
      <dd>
       <ol>
        <li>
         <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting⑥">response tainting</a> to
     "<code>cors</code>". </p>
        <li>
         <p>Let <var>corsWithPreflightResponse</var> be the result of performing an <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch③">HTTP fetch</a> using <var>request</var> with the <i>CORS-preflight flag</i> set. </p>
        <li>
         <p>If <var>corsWithPreflightResponse</var> is a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①⑤">network error</a>, then <a data-link-type="dfn" href="#concept-cache-clear" id="ref-for-concept-cache-clear">clear cache entries</a> using <var>request</var>. </p>
        <li>
         <p>Return <var>corsWithPreflightResponse</var>. </p>
       </ol>
      <dt>Otherwise 
      <dd>
       <ol>
        <li>
         <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting⑦">response tainting</a> to
     "<code>cors</code>". </p>
        <li>
         <p>Return the result of performing an <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch④">HTTP fetch</a> using <var>request</var>. </p>
       </ol>
     </dl>
    <li>
     <p>If the <i>recursive flag</i> is set, return <var>response</var>. </p>
    <li>
     <p>If <var>response</var> is not a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①⑥">network error</a> and <var>response</var> is not a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response⑧">filtered response</a>, then: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting⑧">response tainting</a> is "<code>cors</code>", then: </p>
       <ol>
        <li>
         <p>Let <var>headerNames</var> be the result of <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values">extracting header list values</a> given
     `<a data-link-type="http-header" href="#http-access-control-expose-headers" id="ref-for-http-access-control-expose-headers⑤"><code>Access-Control-Expose-Headers</code></a>` and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①③">header list</a>. </p>
        <li>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode⑧">credentials mode</a> is not
     "<code>include</code>" and <var>headerNames</var> contains `<code>*</code>`, then set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-cors-exposed-header-name-list" id="ref-for-concept-response-cors-exposed-header-name-list③">CORS-exposed header-name list</a> to all unique <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤③">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④③">names</a> in <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①④">header list</a>. </p>
        <li>
         <p>Otherwise, if <var>headerNames</var> is not null or failure, then set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-cors-exposed-header-name-list" id="ref-for-concept-response-cors-exposed-header-name-list④">CORS-exposed header-name list</a> to <var>headerNames</var>. </p>
         <p class="note" role="note">One of the <var>headerNames</var> can still be `<code>*</code>` at this point,
      but will only match a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤④">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④④">name</a> is `<code>*</code>`. </p>
       </ol>
      <li>
       <p>Set <var>response</var> to the following <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response⑨">filtered response</a> with <var>response</var> as its <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response⑦">internal response</a>, depending on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting⑨">response tainting</a>: </p>
       <dl class="switch compact">
        <dt>"<code>basic</code>" 
        <dd><a data-link-type="dfn" href="#concept-filtered-response-basic" id="ref-for-concept-filtered-response-basic">basic filtered response</a> 
        <dt>"<code>cors</code>" 
        <dd><a data-link-type="dfn" href="#concept-filtered-response-cors" id="ref-for-concept-filtered-response-cors①">CORS filtered response</a> 
        <dt>"<code>opaque</code>" 
        <dd><a data-link-type="dfn" href="#concept-filtered-response-opaque" id="ref-for-concept-filtered-response-opaque②">opaque filtered response</a> 
       </dl>
     </ol>
    <li>
     <p>Let <var>internalResponse</var> be <var>response</var>, if <var>response</var> is a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①⑦">network error</a>, and <var>response</var>’s <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response⑧">internal response</a> otherwise. </p>
    <li>
     <p>If <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list⑤">URL list</a> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty①">is empty</a>, then
  set it to a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-clone" id="ref-for-list-clone">clone</a> of <var>request</var>’s <a data-link-type="dfn" href="#concept-request-url-list" id="ref-for-concept-request-url-list③">URL list</a>. </p>
     <p class="note" role="note">A <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④①">response</a>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list⑥">URL list</a> will typically be empty at
  this point, unless it came from a service worker, in which case it will only be empty if it was
  created through <a class="idl-code" data-link-type="constructor" href="#dom-response" id="ref-for-dom-response"><code>new Response()</code></a>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#timing-allow-failed" id="ref-for-timing-allow-failed②">timing allow failed flag</a> is unset, then set <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-timing-allow-passed" id="ref-for-concept-response-timing-allow-passed">timing allow passed flag</a>. </p>
    <li>
     <p><a href="https://w3c.github.io/webappsec-csp/#set-response-csp-list">Set <var>internalResponse</var>’s CSP list</a>. <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> </p>
    <li>
     <p>If <var>response</var> is not a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①⑧">network error</a> and any
  of the following algorithms returns <b>blocked</b>, then set <var>response</var> and <var>internalResponse</var> to a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error①⑨">network error</a>: </p>
     <ul class="brief">
      <li><a href="https://w3c.github.io/webappsec-mixed-content/#should-block-response">should <var>internalResponse</var> to <var>request</var> be blocked as mixed content</a> <a data-link-type="biblio" href="#biblio-mix">[MIX]</a> 
      <li><a href="https://w3c.github.io/webappsec-csp/#should-block-response">should <var>internalResponse</var> to <var>request</var> be blocked by Content Security Policy</a> <a data-link-type="biblio" href="#biblio-csp">[CSP]</a> 
      <li><a data-link-type="dfn" href="#should-response-to-request-be-blocked-due-to-mime-type?" id="ref-for-should-response-to-request-be-blocked-due-to-mime-type?">should <var>internalResponse</var> to <var>request</var> be blocked due to its MIME type</a> 
      <li><a data-link-type="dfn" href="#should-response-to-request-be-blocked-due-to-nosniff?" id="ref-for-should-response-to-request-be-blocked-due-to-nosniff?">should <var>internalResponse</var> to <var>request</var> be blocked due to nosniff</a> 
     </ul>
    <li>
     <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type⑥">type</a> is "<code>opaque</code>", <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status⑦">status</a> is <code>206</code>, <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-range-requested-flag" id="ref-for-concept-response-range-requested-flag">range-requested flag</a> is set, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①⓪">header list</a> does not <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①⓪">contain</a> `<code>Range</code>`, then set <var>response</var> and <var>internalResponse</var> to a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②⓪">network error</a>. </p>
     <div class="note" role="note">
      <p>Traditionally, APIs accept a ranged response even if a range was not requested. This prevents
   a partial response from an earlier ranged request being provided to an API that did not make a
   range request. </p>
      <details>
       <summary>Further details</summary>
       <p>The above steps prevent the following attack: </p>
       <p>A media element is used to request a range of a cross-origin HTML resource. Although this is
    invalid media, a reference to a clone of the response can be retained in a service worker. This
    can later be used as the response to a script element’s fetch. If the partial response is valid
    JavaScript (even though the whole resource is not), executing it would leak private data. </p>
      </details>
     </div>
    <li>
     <p>If <var>response</var> is not a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②①">network error</a> and
  either <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method⑤">method</a> is
  `<code>HEAD</code>` or `<code>CONNECT</code>`, or <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status⑧">status</a> is a <a data-link-type="dfn" href="#null-body-status" id="ref-for-null-body-status">null body status</a>,
  set <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body⑦">body</a> to
  null and disregard any enqueuing toward it (if any). </p>
     <p class="note" role="note">This standardizes the error handling for servers that violate HTTP. </p>
    <li>
     <p>If <var>response</var> is not a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②②">network error</a> and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-integrity-metadata" id="ref-for-concept-request-integrity-metadata">integrity metadata</a> is not the empty string, then: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="#concept-body-wait" id="ref-for-concept-body-wait">Wait</a> for <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body⑧">body</a>. </p>
      <li>
       <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body⑨">body</a>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream⑦">stream</a> has not <a data-link-type="dfn" href="#concept-readablestream-errored" id="ref-for-concept-readablestream-errored①">errored</a>, and <var>response</var> does not <a href="https://w3c.github.io/webappsec-subresource-integrity/#does-response-match-metadatalist">match</a> <var>request</var>’s <a data-link-type="dfn" href="#concept-request-integrity-metadata" id="ref-for-concept-request-integrity-metadata①">integrity metadata</a>, set <var>response</var> and <var>internalResponse</var> to a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②③">network error</a>. <a data-link-type="biblio" href="#biblio-sri">[SRI]</a> </p>
     </ol>
     <p class="note" role="note">This operates on <var>response</var> as this algorithm is not supposed to observe <var>internalResponse</var>. That would allow an attacker to use hashes as an oracle. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#synchronous-flag" id="ref-for-synchronous-flag③">synchronous flag</a> is set, <a data-link-type="dfn" href="#concept-body-wait" id="ref-for-concept-body-wait①">wait</a> for <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①⓪">body</a>, and then return <var>response</var>. </p>
     <p class="note no-backref" role="note">This terminates <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②③">fetch</a>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①⑧">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①⑦">scheme</a> is an <a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme⑤">HTTP(S) scheme</a>, then: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body⑤">body</a> is <a data-link-type="dfn" href="#concept-body-done" id="ref-for-concept-body-done①">done</a>, <a data-link-type="dfn" href="#queue-a-fetch-request-done-task" id="ref-for-queue-a-fetch-request-done-task">queue a fetch-request-done task</a> for <var>request</var>. </p>
      <li>
       <p>Otherwise, <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel②">in parallel</a>, <a data-link-type="dfn" href="#concept-body-wait" id="ref-for-concept-body-wait②">wait</a> for <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body⑥">body</a>, and then <a data-link-type="dfn" href="#queue-a-fetch-request-done-task" id="ref-for-queue-a-fetch-request-done-task①">queue a fetch-request-done task</a> for <var>request</var>. </p>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task⑥">Queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-response" id="ref-for-process-response①">process response</a> for <var>response</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-body-wait" id="ref-for-concept-body-wait③">Wait</a> for <var>internalResponse</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①①">body</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task⑦">Queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-response-end-of-body" id="ref-for-process-response-end-of-body①">process response end-of-body</a> for <var>response</var>. </p>
    <li>
     <p>Set <var>request</var>’s <a data-link-type="dfn" href="#done-flag" id="ref-for-done-flag②">done flag</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#queue-a-fetch-task" id="ref-for-queue-a-fetch-task⑧">Queue a fetch task</a> on <var>request</var> to <a data-link-type="dfn" href="#process-response-done" id="ref-for-process-response-done①">process response done</a> for <var>response</var>. </p>
   </ol>
   <h3 class="heading settled" data-level="4.2" id="scheme-fetch"><span class="secno">4.2. </span><span class="content">Scheme fetch</span><span id="basic-fetch"></span><a class="self-link" href="#scheme-fetch"></a></h3>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-scheme-fetch">scheme fetch<span id="concept-basic-fetch"></span></dfn> using <var>request</var>, switch on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url①⑨">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①⑧">scheme</a>, and run the associated steps: </p>
   <dl class="switch">
    <dt>"<code>about</code>" 
    <dd>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②⓪">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag" id="ref-for-url-cannot-be-a-base-url-flag">cannot-be-a-base-URL flag</a> is
  set and <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-path" id="ref-for-concept-url-path①">path</a> contains a single string "<code>blank</code>", then return a new <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④②">response</a> whose <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message③">status message</a> is `<code>OK</code>`, <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①⑤">header list</a> consist of a single <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤⑤">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④⑤">name</a> is `<code>Content-Type</code>` and <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③⓪">value</a> is
  `<code>text/html;charset=utf-8</code>`, <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①②">body</a> is the empty byte sequence, and <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state④">HTTPS state</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①①">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#https-state" id="ref-for-https-state①">HTTPS state</a> if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①②">client</a> is non-null. </p>
     <p>Otherwise, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②④">network error</a>. </p>
     <p class="note no-backref" role="note"><a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①①">URLs</a> such as "<code>about:config</code>" are handled
  during <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsing-the-web.html#navigate" id="ref-for-navigate①">navigation</a> and result in a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②⑤">network error</a> in the context of <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②④">fetching</a>. </p>
    <dt>"<code>blob</code>" 
    <dd>
     <ol>
      <li>
       <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when④">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate⑦">terminated</a>: </p>
       <ol>
        <li>
         <p>Let <var>blob</var> be <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②①">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-blob-entry" id="ref-for-concept-url-blob-entry">blob URL entry</a>’s <a data-link-type="dfn" href="https://w3c.github.io/FileAPI/#blob-url-entry-object" id="ref-for-blob-url-entry-object">object</a>. </p>
        <li>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method⑥">method</a> is not `<code>GET</code>` or <var>blob</var> is not a <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-Blob" id="ref-for-dfn-Blob">Blob</a></code> object, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②⑥">network error</a>. <a data-link-type="biblio" href="#biblio-fileapi">[FILEAPI]</a> </p>
         <p class="note" role="note">The `<code>GET</code>` <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method①⓪">method</a> restriction serves no useful purpose
      other than being interoperable. </p>
        <li>
         <p>Let <var>response</var> be a new <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④③">response</a> whose <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message④">status message</a> is `<code>OK</code>`. </p>
        <li>
         <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append⑤">Append</a> `<code>Content-Length</code>`/<var>blob</var>’s <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-size" id="ref-for-dfn-size">size</a></code> attribute value to <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①⑥">header list</a>. </p>
        <li>
         <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append⑥">Append</a> `<code>Content-Type</code>`/<var>blob</var>’s <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-type" id="ref-for-dfn-type">type</a></code> attribute value to <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①⑦">header list</a>. </p>
        <li>
         <p>Set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state⑤">HTTPS state</a> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①③">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#https-state" id="ref-for-https-state②">HTTPS state</a> if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①④">client</a> is non-null. </p>
        <li>
         <p>Set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①③">body</a> to
     the result of performing the <a data-link-type="dfn" href="https://w3c.github.io/FileAPI/#readOperation" id="ref-for-readOperation">read operation</a> on <var>blob</var>. </p>
        <li>
         <p>Return <var>response</var>. </p>
       </ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted④">If aborted</a>, then: </p>
       <ol>
        <li>
         <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
        <li>
         <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error②">aborted network error</a>. </p>
        <li>
         <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②⑦">network error</a>. </p>
       </ol>
     </ol>
    <dt>"<code>data</code>" 
    <dd>
     <ol>
      <li>
       <p>Let <var>dataURLStruct</var> be the result of running the <a data-link-type="dfn" href="#data-url-processor" id="ref-for-data-url-processor"><code>data:</code> URL processor</a> on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②②">current URL</a>. </p>
      <li>
       <p>If <var>dataURLStruct</var> is failure, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②⑧">network error</a>. </p>
      <li>
       <p>Return a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④④">response</a> whose <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message⑤">status message</a> is
   `<code>OK</code>`, <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①⑧">header list</a> consist of a single <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤⑥">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④⑥">name</a> is `<code>Content-Type</code>` and <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③①">value</a> is <var>dataURLStruct</var>’s <a data-link-type="dfn" href="#data-url-struct-mime-type" id="ref-for-data-url-struct-mime-type">MIME type</a>, <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#serialize-a-mime-type-to-bytes" id="ref-for-serialize-a-mime-type-to-bytes">serialized</a>, <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①④">body</a> is <var>dataURLStruct</var>’s <a data-link-type="dfn" href="#data-url-struct-body" id="ref-for-data-url-struct-body">body</a>, and <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state⑥">HTTPS state</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①⑤">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#https-state" id="ref-for-https-state③">HTTPS state</a> if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①⑥">client</a> is non-null. </p>
     </ol>
    <dt>"<code>file</code>" 
    <dd>
     <p>For now, unfortunate as it is, <code>file</code> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①②">URLs</a> are left as an exercise for
  the reader. </p>
     <p>When in doubt, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error②⑨">network error</a>. </p>
    <dt>"<code>ftp</code>" 
    <dd>
     <p>For now, unfortunate as it is, <code>ftp</code> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①③">URLs</a> are mostly left as an
  exercise for the reader. </p>
     <ol>
      <li>
       <p>Let <var>body</var> be the result of the user agent obtaining content from <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②③">current URL</a> from the network via FTP. <a data-link-type="biblio" href="#biblio-rfc959">[RFC959]</a> </p>
      <li>
       <p>Let mime be `<code>application/octet-stream</code>`. </p>
      <li>
       <p>If <var>body</var> is the result of the user agent generating a directory listing page for
   the result of FTP’s LIST command, then set <var>mime</var> to `<code>text/ftp-dir</code>`. </p>
      <li>
       <p>Return a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④⑤">response</a> whose <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message⑥">status message</a> is
   `<code>OK</code>`, <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list①⑨">header list</a> consists of a single <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤⑦">header</a> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④⑦">name</a> is `<code>Content-Type</code>` and whose <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③②">value</a> is <var>mime</var>, <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①⑤">body</a> is <var>body</var>, and <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state⑦">HTTPS state</a> is "<code>none</code>". </p>
     </ol>
     <p>When in doubt, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③⓪">network error</a>. </p>
    <dt><a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme⑥">HTTP(S) scheme</a> 
    <dd>
     <p>Return the result of performing an <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch⑤">HTTP fetch</a> using <var>request</var>. </p>
    <dt>Otherwise 
    <dd>
     <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③①">network error</a>. </p>
   </dl>
   <h3 class="heading settled" data-level="4.3" id="http-fetch"><span class="secno">4.3. </span><span class="content">HTTP fetch</span><a class="self-link" href="#http-fetch"></a></h3>
   <p>To perform an <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-http-fetch">HTTP fetch</dfn> using <var>request</var> with an
optional <i>CORS-preflight flag</i>, run these steps: </p>
   <p class="note no-backref" role="note">The <i>CORS-preflight flag</i> bookkeeping detail indicates a <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request⑨">CORS-preflight request</a> is needed. </p>
   <ol>
    <li>
     <p>Let <var>response</var> be null. </p>
    <li>
     <p>Let <var>actualResponse</var> be null. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#request-service-workers-mode" id="ref-for-request-service-workers-mode">service-workers mode</a> is "<code>all</code>", then: </p>
     <ol>
      <li>
       <p>Set <var>response</var> to the result of invoking <a data-link-type="dfn" href="https://w3c.github.io/ServiceWorker/#handle-fetch" id="ref-for-handle-fetch①">handle fetch</a> for <var>request</var>. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> <a data-link-type="biblio" href="#biblio-sw">[SW]</a> </p>
      <li>
       <p>If <var>response</var> is not null, then: </p>
       <ol>
        <li>
         <p><a data-link-type="dfn" href="#concept-request-transmit-body" id="ref-for-concept-request-transmit-body">Transmit body</a> for <var>request</var>. </p>
        <li>
         <p>Set <var>actualResponse</var> to <var>response</var>, if <var>response</var> is not a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response①⓪">filtered response</a>, and to <var>response</var>’s <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response⑨">internal response</a> otherwise. </p>
        <li>
         <p>If one of the following is true </p>
         <ul class="brief">
          <li>
           <p><var>response</var>’s <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type⑦">type</a> is "<code>error</code>" </p>
          <li>
           <p><var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①⓪">mode</a> is "<code>same-origin</code>" and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type⑧">type</a> is "<code>cors</code>" </p>
          <li>
           <p><var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①①">mode</a> is not "<code>no-cors</code>" and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type⑨">type</a> is "<code>opaque</code>" </p>
          <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode②">redirect mode</a> is not "<code>manual</code>" and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type①⓪">type</a> is "<code>opaqueredirect</code>" 
          <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode③">redirect mode</a> is not "<code>follow</code>" and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list⑦">URL list</a> has more than one item. 
         </ul>
         <p>then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③②">network error</a>. </p>
       </ol>
     </ol>
    <li>
     <p>If <var>response</var> is null, then: </p>
     <ol>
      <li>
       <p>If the <i>CORS-preflight flag</i> is set and one of these conditions is true: </p>
       <ul class="brief">
        <li>
         <p>There is no <a data-link-type="dfn" href="#concept-cache-match-method" id="ref-for-concept-cache-match-method">method cache entry match</a> for <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method⑦">method</a> using <var>request</var>, and either <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method⑧">method</a> is a not a <a data-link-type="dfn" href="#cors-safelisted-method" id="ref-for-cors-safelisted-method②">CORS-safelisted method</a> or <var>request</var>’s <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag③">use-CORS-preflight flag</a> is set. </p>
        <li>There is at least one <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-item" id="ref-for-list-item">item</a> in the <a data-link-type="dfn" href="#cors-unsafe-request-header-names" id="ref-for-cors-unsafe-request-header-names①">CORS-unsafe request-header names</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①①">header list</a> for which there is no <a data-link-type="dfn" href="#concept-cache-match-header" id="ref-for-concept-cache-match-header">header-name cache entry match</a> using <var>request</var>. 
       </ul>
       <p>Then: </p>
       <ol>
        <li>
         <p>Let <var>preflightResponse</var> be the result of performing a <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0①">CORS-preflight fetch</a> using <var>request</var>. </p>
        <li>
         <p>If <var>preflightResponse</var> is a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③③">network error</a>, then return <var>preflightResponse</var>. </p>
       </ol>
       <p class="note no-backref" role="note">This step checks the <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache">CORS-preflight cache</a> and if there is no suitable entry it
    performs a <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0②">CORS-preflight fetch</a> which, if successful, populates the cache. The
    purpose of the <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0③">CORS-preflight fetch</a> is to ensure the <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②⑤">fetched</a> resource is familiar with the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①⑦">CORS protocol</a>. The cache is there to minimize the number of <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0④">CORS-preflight fetches</a>. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode④">redirect mode</a> is "<code>follow</code>", then set <var>request</var>’s <a data-link-type="dfn" href="#request-service-workers-mode" id="ref-for-request-service-workers-mode①">service-workers mode</a> to "<code>none</code>". </p>
       <p class="note no-backref" role="note">Redirects coming from the network (as opposed to from a service
    worker) are not to be exposed to a service worker. </p>
      <li>
       <p>Set <var>response</var> and <var>actualResponse</var> to the result of performing an <a data-link-type="dfn" href="#concept-http-network-or-cache-fetch" id="ref-for-concept-http-network-or-cache-fetch">HTTP-network-or-cache fetch</a> using <var>request</var>. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①⓪">response tainting</a> is "<code>cors</code>" and a <a data-link-type="dfn" href="#concept-cors-check" id="ref-for-concept-cors-check">CORS check</a> for <var>request</var> and <var>response</var> returns failure, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③④">network error</a>. </p>
       <p class="note no-backref" role="note">As the <a data-link-type="dfn" href="#concept-cors-check" id="ref-for-concept-cors-check①">CORS check</a> is not to be applied to <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④⑥">responses</a> whose <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status⑨">status</a> is <code>304</code> or <code>407</code>,
    or <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④⑦">responses</a> from a service worker for that matter, it is applied here. </p>
      <li>
       <p>If the <a data-link-type="dfn" href="#concept-tao-check" id="ref-for-concept-tao-check">TAO check</a> for <var>request</var> and <var>response</var> returns failure,
   then set <var>request</var>’s <a data-link-type="dfn" href="#timing-allow-failed" id="ref-for-timing-allow-failed③">timing allow failed flag</a>. </p>
     </ol>
    <li>
     <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①⓪">status</a> is a <a data-link-type="dfn" href="#redirect-status" id="ref-for-redirect-status">redirect status</a>, then: </p>
     <ol>
      <li>
       <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①①">status</a> is not <code>303</code>, <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body⑦">body</a> is not null, and the <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection⑥">connection</a> uses HTTP/2,
    then user agents may, and are even encouraged to, transmit an <code>RST_STREAM</code> frame. </p>
       <p class="note" role="note"><code>303</code> is excluded as certain communities ascribe special status to it. </p>
      <li>
       <p>Let <var>location</var> be the result of <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values①">extracting header list values</a> given
   `<code>Location</code>` and <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②⓪">header list</a>. </p>
      <li>
       <p>If <var>location</var> is a <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③③">value</a>, then set <var>location</var> to the
   result of <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-parser" id="ref-for-concept-url-parser">parsing</a> <var>location</var> with <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-url" id="ref-for-concept-response-url②">URL</a>. </p>
      <li>
       <p>Set <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url①">location URL</a> to <var>location</var>. </p>
      <li>
       <p>Switch on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode⑤">redirect mode</a>: </p>
       <dl class="switch">
        <dt>"<code>error</code>" 
        <dd>
         <p>Set <var>response</var> to a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③⑤">network error</a>. </p>
        <dt>"<code>manual</code>" 
        <dd>
         <p>Set <var>response</var> to an <a data-link-type="dfn" href="#concept-filtered-response-opaque-redirect" id="ref-for-concept-filtered-response-opaque-redirect③">opaque-redirect filtered response</a> whose <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response①⓪">internal response</a> is <var>actualResponse</var>. </p>
        <dt>"<code>follow</code>" 
        <dd>
         <p>Set <var>response</var> to the result of performing <a data-link-type="dfn" href="#concept-http-redirect-fetch" id="ref-for-concept-http-redirect-fetch">HTTP-redirect fetch</a> using <var>request</var> and <var>response</var>. </p>
       </dl>
     </ol>
    <li>
     <p>Return <var>response</var>. <span class="note no-backref">Typically <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①⑥">body</a>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream⑧">stream</a> is still being enqueued to after returning.</span> </p>
   </ol>
   <h3 class="heading settled" data-level="4.4" id="http-redirect-fetch"><span class="secno">4.4. </span><span class="content">HTTP-redirect fetch</span><a class="self-link" href="#http-redirect-fetch"></a></h3>
   <p class="note no-backref" role="note">This algorithm is used by HTML’s navigate algorithm in addition to <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch⑥">HTTP fetch</a> above. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
   <p>To perform an <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-http-redirect-fetch">HTTP-redirect fetch</dfn> using <var>request</var> and <var>response</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>actualResponse</var> be <var>response</var>, if <var>response</var> is not a <a data-link-type="dfn" href="#concept-filtered-response" id="ref-for-concept-filtered-response①①">filtered response</a>, and <var>response</var>’s <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response①①">internal response</a> otherwise. </p>
    <li>
     <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url②">location URL</a> is null, then return <var>response</var>. </p>
    <li>
     <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url③">location URL</a> is failure, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③⑥">network error</a>. </p>
    <li>
     <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url④">location URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme①⑨">scheme</a> is <em>not</em> an <a data-link-type="dfn" href="#http-scheme" id="ref-for-http-scheme⑦">HTTP(S) scheme</a>, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③⑦">network error</a>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-count" id="ref-for-concept-request-redirect-count①">redirect count</a> is
 twenty, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③⑧">network error</a>. </p>
    <li>
     <p>Increase <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-count" id="ref-for-concept-request-redirect-count②">redirect count</a> by one. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①②">mode</a> is "<code>cors</code>", <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url⑤">location URL</a> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#include-credentials" id="ref-for-include-credentials">includes credentials</a>, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①①">origin</a> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin③">same origin</a> with <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url⑥">location URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin⑤">origin</a>, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error③⑨">network error</a>. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①①">response tainting</a> is "<code>cors</code>" and <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url⑦">location URL</a> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#include-credentials" id="ref-for-include-credentials①">includes credentials</a>, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④⓪">network error</a>. </p>
     <p class="note" role="note">This catches a cross-origin resource redirecting to a same-origin URL. </p>
    <li>
     <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①②">status</a> is not <code>303</code>, <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body⑧">body</a> is non-null, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body⑨">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source">source</a> is null, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④①">network error</a>. </p>
    <li>
     <p>If <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url⑧">location URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin⑥">origin</a> is
 not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin④">same origin</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②④">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin⑦">origin</a> and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①②">origin</a> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin⑤">same origin</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②⑤">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin⑧">origin</a>, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-tainted-origin" id="ref-for-concept-request-tainted-origin②">tainted origin flag</a>. </p>
    <li>
     <p>If one of the following is true </p>
     <ul class="brief">
      <li>
       <p><var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①③">status</a> is <code>301</code> or <code>302</code> and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method⑨">method</a> is `<code>POST</code>` </p>
      <li>
       <p><var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①④">status</a> is <code>303</code> and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①⓪">method</a> is not `<code>GET</code>` or `<code>HEAD</code>` </p>
     </ul>
     <p>then: </p>
     <ol>
      <li>
       <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①①">method</a> to `<code>GET</code>` and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①⓪">body</a> to null. </p>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate⑤">For each</a> <var>headerName</var> of <a data-link-type="dfn" href="#request-body-header-name" id="ref-for-request-body-header-name">request-body-header name</a>, <a data-link-type="dfn" href="#concept-header-list-delete" id="ref-for-concept-header-list-delete">delete</a> <var>headerName</var> from <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①②">header list</a>. </p>
     </ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①①">body</a> is non-null, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①②">body</a> to the first return value of <a data-link-type="dfn" href="#bodyinit-safely-extract" id="ref-for-bodyinit-safely-extract">safely extracting</a> <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①③">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source①">source</a>. </p>
     <p class="note no-backref" role="note"><var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①④">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source②">source</a>’s
  nullity has already been checked. </p>
    <li>
     <p>Append <var>actualResponse</var>’s <a data-link-type="dfn" href="#concept-response-location-url" id="ref-for-concept-response-location-url⑨">location URL</a> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-url-list" id="ref-for-concept-request-url-list④">URL list</a>. </p>
    <li>
     <p>Invoke <a data-link-type="dfn" href="https://w3c.github.io/webappsec-referrer-policy/#set-requests-referrer-policy-on-redirect" id="ref-for-set-requests-referrer-policy-on-redirect">set <var>request</var>’s referrer policy on redirect</a> on <var>request</var> and <var>actualResponse</var>. <a data-link-type="biblio" href="#biblio-referrer">[REFERRER]</a> </p>
    <li>
     <p>Return the result of performing a <a data-link-type="dfn" href="#concept-main-fetch" id="ref-for-concept-main-fetch②">main fetch</a> using <var>request</var> with <i>recursive flag</i> set if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode⑥">redirect mode</a> is not
  "<code>manual</code>". </p>
     <p class="note" role="note">It can only be "<code>manual</code>" here when this algorithm is invoked directly
  from HTML’s navigate algorithm. </p>
     <p class="note no-backref" role="note">This has to invoke <a data-link-type="dfn" href="#concept-main-fetch" id="ref-for-concept-main-fetch③">main fetch</a> to
  get <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①②">response tainting</a> correct. </p>
   </ol>
   <h3 class="heading settled" data-level="4.5" id="http-network-or-cache-fetch"><span class="secno">4.5. </span><span class="content">HTTP-network-or-cache fetch</span><a class="self-link" href="#http-network-or-cache-fetch"></a></h3>
   <p>To perform an <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-http-network-or-cache-fetch">HTTP-network-or-cache fetch</dfn> using <var>request</var> with an optional <i>authentication-fetch flag</i>, run these steps: </p>
   <p class="note" role="note">The <i>authentication-fetch flag</i> is a bookkeeping detail. </p>
   <p class="note" role="note">Some implementations might support caching of partial content, as per <cite>HTTP
Range Requests</cite>. <a data-link-type="biblio" href="#biblio-http-range">[HTTP-RANGE]</a> However, this is not widely supported by browser caches. </p>
   <ol>
    <li>
     <p>Let <var>httpRequest</var> be null. </p>
    <li>
     <p>Let <var>response</var> be null. </p>
    <li>
     <p>Let <var>storedResponse</var> be null. </p>
    <li>
     <p>Let the <var>revalidatingFlag</var> be unset. </p>
    <li>
     <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when⑤">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate⑧">terminated</a>: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window③">window</a> is "<code>no-window</code>" and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode⑦">redirect mode</a> is "<code>error</code>", then set <var>httpRequest</var> to <var>request</var>. </p>
      <li>
       <p>Otherwise: </p>
       <ol>
        <li>
         <p>Set <var>httpRequest</var> to a copy of <var>request</var> except for its <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①⑤">body</a>. </p>
        <li>
         <p>Let <var>body</var> be <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①⑥">body</a>. </p>
        <li>
         <p>Set <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①⑦">body</a> to <var>body</var>. </p>
        <li>
         <p>If <var>body</var> is non-null, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①⑧">body</a> to
     a new <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body⑥">body</a> whose <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream⑨">stream</a> is null and whose <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source③">source</a> is <var>body</var>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source④">source</a>. </p>
       </ol>
       <p class="note no-backref" role="note"><var>request</var> is copied as <var>httpRequest</var> here as we
    need to be able to add headers to <var>httpRequest</var> and read its <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body①⑨">body</a> without affecting <var>request</var>. Namely, <var>request</var> can be reused with redirects,
    authentication, and proxy authentication. We copy rather than clone in order to reduce memory
    consumption. In case <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②⓪">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source⑤">source</a> is
    null, redirects and authentication will end up failing the fetch. </p>
      <li>
       <p>Let <i>credentials flag</i> be set if one of </p>
       <ul class="brief">
        <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode⑨">credentials mode</a> is
     "<code>include</code>" 
        <li><var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①⓪">credentials mode</a> is
     "<code>same-origin</code>" and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①③">response tainting</a> is "<code>basic</code>" 
       </ul>
       <p>is true, and unset otherwise. </p>
      <li>
       <p>Let <var>contentLengthValue</var> be null. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②①">body</a> is null and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①②">method</a> is
   `<code>POST</code>` or `<code>PUT</code>`, then set <var>contentLengthValue</var> to
   `<code>0</code>`. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②②">body</a> is non-null and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②③">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source⑥">source</a> is non-null, then set <var>contentLengthValue</var> to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②④">body</a>’s <a data-link-type="dfn" href="#concept-body-total-bytes" id="ref-for-concept-body-total-bytes">total bytes</a>, <a data-link-type="dfn" href="#serialize-an-integer" id="ref-for-serialize-an-integer②">serialized</a> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode③">isomorphic encoded</a>. </p>
      <li>
       <p>If <var>contentLengthValue</var> is non-null, <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append⑦">append</a> `<code>Content-Length</code>`/<var>contentLengthValue</var> to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①③">header list</a>. </p>
      <li>
       <p>If <var>contentLengthValue</var> is non-null and <var>httpRequest</var>’s <a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag①">keepalive flag</a> is set, then: </p>
       <ol>
        <li>
         <p>Let <var>inflightKeepaliveBytes</var> be zero. </p>
        <li>
         <p>Let <var>group</var> be <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①⑦">client</a>’s <a data-link-type="dfn" href="#concept-fetch-group" id="ref-for-concept-fetch-group③">fetch group</a>. </p>
        <li>
         <p>Let <var>inflightRecords</var> be the set of <a data-link-type="dfn" href="#concept-fetch-record" id="ref-for-concept-fetch-record⑥">fetch records</a> in <var>group</var> whose <a data-link-type="dfn" href="#concept-fetch-record-request" id="ref-for-concept-fetch-record-request①">request</a> has its <a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag②">keepalive flag</a> set and <a data-link-type="dfn" href="#done-flag" id="ref-for-done-flag③">done flag</a> unset. </p>
        <li>
         <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate⑥">For each</a> <var>fetchRecord</var> in <var>inflightRecords</var>: </p>
         <ol>
          <li>
           <p>Let <var>inflightRequest</var> be <var>fetchRecord</var>’s <a data-link-type="dfn" href="#concept-fetch-record-request" id="ref-for-concept-fetch-record-request②">request</a>. </p>
          <li>
           <p>Increment <var>inflightKeepaliveBytes</var> by <var>inflightRequest</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②⑤">body</a>’s <a data-link-type="dfn" href="#concept-body-total-bytes" id="ref-for-concept-body-total-bytes①">total bytes</a>. </p>
         </ol>
        <li>
         <p>If the sum of <var>contentLengthValue</var> and <var>inflightKeepaliveBytes</var> is
     greater than 64 kibibytes, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④②">network error</a>. </p>
       </ol>
       <p class="note no-backref" role="note">The above limit ensures that requests that are allowed to outlive the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object⑨">environment settings object</a> and contain a body, have a bounded size and are not allowed
    to stay alive indefinitely. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer④">referrer</a> is a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①④">URL</a>, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append⑧">append</a> `<code>Referer</code>`/<var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer⑤">referrer</a>, <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer①">serialized</a> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode④">isomorphic encoded</a>,
   to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①④">header list</a>. </p>
      <li>
       <p><a data-link-type="dfn" href="#append-a-request-origin-header" id="ref-for-append-a-request-origin-header">Append a request `<code>Origin</code>` header</a> for <var>httpRequest</var>. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①⑤">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①①">does not contain</a> `<code>User-Agent</code>`, then user agents should <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append⑨">append</a> `<code>User-Agent</code>`/<a data-link-type="dfn" href="#default-user-agent-value" id="ref-for-default-user-agent-value">default `<code>User-Agent</code>` value</a> to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①⑥">header list</a>. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①">cache mode</a> is "<code>default</code>" and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①⑦">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①②">contains</a> `<code>If-Modified-Since</code>`,
   `<code>If-None-Match</code>`,
   `<code>If-Unmodified-Since</code>`,
   `<code>If-Match</code>`, or
   `<code>If-Range</code>`, then set <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode②">cache mode</a> to "<code>no-store</code>". </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode③">cache mode</a> is "<code>no-cache</code>", <var>httpRequest</var>’s <a data-link-type="dfn" href="#no-cache-prevent-cache-control" id="ref-for-no-cache-prevent-cache-control">prevent no-cache cache-control header modification flag</a> is unset, and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①⑧">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①③">does not contain</a> `<code>Cache-Control</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①⓪">append</a> `<code>Cache-Control</code>`/`<code>max-age=0</code>` to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list①⑨">header list</a>. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode④">cache mode</a> is "<code>no-store</code>" or
    "<code>reload</code>", then: </p>
       <ol>
        <li>
         <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②⓪">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①④">does not contain</a> `<code>Pragma</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①①">append</a> `<code>Pragma</code>`/`<code>no-cache</code>` to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②①">header list</a>. </p>
        <li>
         <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②②">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①⑤">does not contain</a> `<code>Cache-Control</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①②">append</a> `<code>Cache-Control</code>`/`<code>no-cache</code>` to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②③">header list</a>. </p>
       </ol>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②④">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①⑥">contains</a> `<code>Range</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①③">append</a> `<code>Accept-Encoding</code>`/`<code>identity</code>` to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②⑤">header list</a>. </p>
       <div class="note no-backref" role="note">
        <p>This avoids a failure when <a data-link-type="dfn" href="#handle-content-codings" id="ref-for-handle-content-codings">handling content codings</a> with
     a part of an encoded <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④⑧">response</a>. </p>
        <p>Additionally, <a href="https://jakearchibald.github.io/accept-encoding-range-test/">many servers</a> mistakenly ignore `<code>Range</code>` headers if a non-identity encoding is accepted. </p>
       </div>
      <li>
       <p>Modify <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②⑥">header list</a> per HTTP. Do not <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①④">append</a> a given <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤⑧">header</a> if <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②⑦">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①⑦">contains</a> that <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑤⑨">header</a>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④⑧">name</a>. </p>
       <p class="note no-backref" role="note">It would be great if we could make this more normative
    somehow. At this point <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥⓪">headers</a> such as
    `<code>Accept-Encoding</code>`,
    `<code>Connection</code>`,
    `<code>DNT</code>`, and
    `<code>Host</code>`,
    are to be <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①⑤">appended</a> if necessary. </p>
       <p>`<code>Accept</code>`,
    `<code>Accept-Charset</code>`, and
    `<code>Accept-Language</code>` must not be included at this point. </p>
       <p class="note no-backref" role="note">`<code>Accept</code>` and
    `<code>Accept-Language</code>` are already included (unless <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch③"><code>fetch()</code></a> is used, which does not include the latter by
    default), and `<code>Accept-Charset</code>` is a waste of bytes. See <a data-link-type="dfn" href="#http-header-layer-division" id="ref-for-http-header-layer-division">HTTP header layer division</a> for more details. </p>
      <li>
       <p>If <i>credentials flag</i> is set, then: </p>
       <ol>
        <li>
         <p>If the user agent is not configured to block cookies for <var>httpRequest</var> (see <a href="https://tools.ietf.org/html/rfc6265#section-7">section 7</a> of <a data-link-type="biblio" href="#biblio-cookies">[COOKIES]</a>), then: </p>
         <ol>
          <li>
           <p>Let <var>cookies</var> be the result of running the "cookie-string" algorithm (see <a href="https://tools.ietf.org/html/rfc6265#section-5.4">section 5.4</a> of <a data-link-type="biblio" href="#biblio-cookies">[COOKIES]</a>) with
       the user agent’s cookie store and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②⑥">current URL</a>. </p>
          <li>If <var>cookies</var> is not the empty string, append
       `<code>Cookie</code>`/<var>cookies</var> to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②⑧">header list</a>. 
         </ol>
        <li>
         <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list②⑨">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①⑧">does not contain</a> `<code>Authorization</code>`, then: </p>
         <ol>
          <li>
           <p>Let <var>authorizationValue</var> be null. </p>
          <li>
           <p>If there’s an <a data-link-type="dfn" href="#authentication-entry" id="ref-for-authentication-entry①">authentication entry</a> for <var>httpRequest</var> and either <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-use-url-credentials-flag" id="ref-for-concept-request-use-url-credentials-flag">use-URL-credentials flag</a> is unset or <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②⑦">current URL</a> does not <a data-link-type="dfn" href="https://url.spec.whatwg.org/#include-credentials" id="ref-for-include-credentials②">include credentials</a>,
       then set <var>authorizationValue</var> to <a data-link-type="dfn" href="#authentication-entry" id="ref-for-authentication-entry②">authentication entry</a>. </p>
          <li>
           <p>Otherwise, if <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②⑧">current URL</a> does <a data-link-type="dfn" href="https://url.spec.whatwg.org/#include-credentials" id="ref-for-include-credentials③">include credentials</a> and <i>authentication-fetch flag</i> is set, set <var>authorizationValue</var> to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url②⑨">current URL</a>, <span class="XXX">converted to an `<code>Authorization</code>` value</span>. </p>
          <li>
           <p>If <var>authorizationValue</var> is non-null, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①⑥">append</a> `<code>Authorization</code>`/<var>authorizationValue</var> to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③⓪">header list</a>. </p>
         </ol>
       </ol>
      <li>
       <p>If there’s a <a data-link-type="dfn" href="#proxy-authentication-entry" id="ref-for-proxy-authentication-entry">proxy-authentication entry</a>, use it as appropriate. </p>
       <p class="note no-backref" role="note">This intentionally does not depend on <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①①">credentials mode</a>. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode⑤">cache mode</a> is neither "<code>no-store</code>"
    nor "<code>reload</code>", then: </p>
       <ol>
        <li>
         <p>Set <var>storedResponse</var> to the result of selecting a response from the HTTP cache,
      possibly needing validation, as per the
      "<a href="https://tools.ietf.org/html/rfc7234#section-4">Constructing Responses from Caches</a>"
      chapter of <cite>HTTP Caching</cite> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a>, if any. </p>
         <p class="note" role="note">As mandated by HTTP, this still takes the `<code>Vary</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥①">header</a> into account. </p>
        <li>
         <p>If <var>storedResponse</var> is non-null, then: </p>
         <ol>
          <li>
           <p>If <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode⑥">cache mode</a> is "<code>default</code>", <var>storedResponse</var> is a <a data-link-type="dfn" href="#concept-stale-while-revalidate-response" id="ref-for-concept-stale-while-revalidate-response②">stale-while-revalidate response</a>, and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①⑧">client</a> is non-null, then: </p>
           <ol>
            <li>
             <p>Set <var>response</var> to <var>storedResponse</var>. </p>
            <li>
             <p>Set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-cache-state" id="ref-for-concept-response-cache-state">cache state</a> to "<code>local</code>". </p>
            <li>
             <p>Let <var>revalidateRequest</var> be a <a data-link-type="dfn" href="#concept-request-clone" id="ref-for-concept-request-clone">clone</a> of <var>request</var>. </p>
            <li>
             <p>Set <var>revalidateRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode⑦">cache mode</a> set to
         "<code>no-cache</code>". </p>
            <li>
             <p>Set <var>revalidateRequest</var>’s <a data-link-type="dfn" href="#no-cache-prevent-cache-control" id="ref-for-no-cache-prevent-cache-control①">prevent no-cache cache-control header modification flag</a>. </p>
            <li>
             <p>Set <var>revalidateRequest</var>’s <a data-link-type="dfn" href="#request-service-workers-mode" id="ref-for-request-service-workers-mode②">service-workers mode</a> set to
         "<code>none</code>". </p>
            <li>
             <p><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel③">In parallel</a>, perform <a data-link-type="dfn" href="#concept-main-fetch" id="ref-for-concept-main-fetch④">main fetch</a> using <var>revalidateRequest</var>. </p>
             <p class="note" role="note">This fetch is only meant to update the state of the HTTP cache and the
          response will be unused until another cache access. The stale response will be used as the
          response to current request. This fetch is issued in the context of a client so if it goes
          away the request will be terminated. </p>
           </ol>
          <li>
           <p>Otherwise: </p>
           <ol>
            <li>
             <p>If <var>storedResponse</var> is a <a data-link-type="dfn" href="#concept-stale-response" id="ref-for-concept-stale-response①">stale response</a>, then set the <var>revalidatingFlag</var>. </p>
            <li>
             <p>If the <var>revalidatingFlag</var> is set and <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode⑧">cache mode</a> is neither "<code>force-cache</code>" nor
          "<code>only-if-cached</code>", then: </p>
             <ol>
              <li>
               <p>If <var>storedResponse</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②①">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains①⑨">contains</a> `<code>ETag</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①⑦">append</a> `<code>If-None-Match</code>` with its value to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③①">header list</a>. </p>
              <li>
               <p>If <var>storedResponse</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②②">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②⓪">contains</a> `<code>Last-Modified</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①⑧">append</a> `<code>If-Modified-Since</code>` with its value to <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③②">header list</a>. </p>
             </ol>
             <p class="note" role="note">See also the
          "<a href="https://tools.ietf.org/html/rfc7234#section-4.3.4">Sending a Validation Request</a>"
          chapter of <cite>HTTP Caching</cite> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a>. </p>
            <li>
             <p>Otherwise, set <var>response</var> to <var>storedResponse</var> and set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-cache-state" id="ref-for-concept-response-cache-state①">cache state</a> to "<code>local</code>". </p>
           </ol>
         </ol>
       </ol>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted⑤">If aborted</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
      <li>
       <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error③">aborted network error</a>. </p>
      <li>
       <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④③">network error</a>. </p>
     </ol>
    <li>
     <p>If <var>response</var> is null, then: </p>
     <ol>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode⑨">cache mode</a> is
   "<code>only-if-cached</code>", then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④④">network error</a>. </p>
      <li>
       <p>Let <var>forwardResponse</var> be the result of making an <a data-link-type="dfn" href="#concept-http-network-fetch" id="ref-for-concept-http-network-fetch">HTTP-network fetch</a> using <var>httpRequest</var> with <i>credentials flag</i> if set. </p>
      <li>
       <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①③">method</a> is <a href="https://tools.ietf.org/html/rfc7231#safe.methods">unsafe</a> and <var>forwardResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①⑤">status</a> is in the range <code>200</code> to <code>399</code>, inclusive, invalidate appropriate stored responses in the HTTP cache, as per
   the "<a href="https://tools.ietf.org/html/rfc7234#section-4.4">Invalidation</a>" chapter of <cite>HTTP Caching</cite>, and set <var>storedResponse</var> to null. <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> </p>
      <li>
       <p>If the <var>revalidatingFlag</var> is set and <var>forwardResponse</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①⑥">status</a> is <code>304</code>, then: </p>
       <ol>
        <li>
         <p>Update <var>storedResponse</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②③">header list</a> using <var>forwardResponse</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②④">header list</a>, as per the
      "<a href="https://tools.ietf.org/html/rfc7234#section-4.3.4">Freshening Stored Responses upon Validation</a>"
      chapter of <cite>HTTP Caching</cite>. <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> </p>
         <p class="note" role="note">This updates the stored response in cache as well. </p>
        <li>
         <p>Set <var>response</var> to <var>storedResponse</var>. </p>
       </ol>
      <li>
       <p>If <var>response</var> is null, then: </p>
       <ol>
        <li>
         <p>Set <var>response</var> to <var>forwardResponse</var>. </p>
        <li>
         <p>Store <var>httpRequest</var> and <var>forwardResponse</var> in the HTTP cache, as per the
      "<a href="https://tools.ietf.org/html/rfc7234#section-3">Storing Responses in Caches</a>"
      chapter of <cite>HTTP Caching</cite>. <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> </p>
         <p class="note" role="note">If <var>forwardResponse</var> is a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④⑤">network error</a>, this effectively caches
      the network error, which is sometimes known as "negative caching". </p>
       </ol>
     </ol>
    <li>
     <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③③">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②①">contains</a> `<code>Range</code>`, then set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-range-requested-flag" id="ref-for-concept-response-range-requested-flag①">range-requested flag</a>. </p>
    <li>
     <p>If <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①④">response tainting</a> is not "<code>cors</code>"
 and the <a data-link-type="dfn" href="#cross-origin-resource-policy-check" id="ref-for-cross-origin-resource-policy-check">cross-origin resource policy check</a> with <var>request</var> and <var>response</var> returns <b>blocked</b>, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④⑥">network error</a>. </p>
    <li>
     <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①⑦">status</a> is <code>401</code>, <var>httpRequest</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①⑤">response tainting</a> is not "<code>cors</code>", the <i>credentials flag</i> is set, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window④">window</a> is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object①⓪">environment settings object</a>, then: </p>
     <ol>
      <li class="XXX">
       <p>Needs testing: multiple `<code>WWW-Authenticate</code>` headers, missing,
   parsing issues. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②⑥">body</a> is non-null, then: </p>
       <ol>
        <li>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②⑦">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source⑦">source</a> is null,
     then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④⑦">network error</a>. </p>
        <li>
         <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②⑧">body</a> to the first return value of <a data-link-type="dfn" href="#bodyinit-safely-extract" id="ref-for-bodyinit-safely-extract①">safely extracting</a> <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body②⑨">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source⑧">source</a>. </p>
       </ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-use-url-credentials-flag" id="ref-for-concept-request-use-url-credentials-flag①">use-URL-credentials flag</a> is unset or <i>authentication-fetch flag</i> is set, then: </p>
       <ol>
        <li>
         <p>If the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate⑨">terminated</a>, then: </p>
         <ol>
          <li>
           <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
          <li>
           <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error④">aborted network error</a>. </p>
          <li>
           <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④⑧">network error</a>. </p>
         </ol>
        <li>
         <p>Let <var>username</var> and <var>password</var> be the result of prompting the end user
     for a username and password, respectively, in <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window⑤">window</a>. </p>
        <li>
         <p><a data-link-type="dfn" href="https://url.spec.whatwg.org/#set-the-username" id="ref-for-set-the-username">Set the username</a> given <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③⓪">current URL</a> and <var>username</var>. </p>
        <li>
         <p><a data-link-type="dfn" href="https://url.spec.whatwg.org/#set-the-password" id="ref-for-set-the-password">Set the password</a> given <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③①">current URL</a> and <var>password</var>. </p>
       </ol>
      <li>
       <p>Set <var>response</var> to the result of performing an <a data-link-type="dfn" href="#concept-http-network-or-cache-fetch" id="ref-for-concept-http-network-or-cache-fetch①">HTTP-network-or-cache fetch</a> using <var>request</var> with <i>authentication-fetch flag</i> set. </p>
     </ol>
    <li>
     <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①⑧">status</a> is <code>407</code>, then: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window⑥">window</a> is
   "<code>no-window</code>", then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error④⑨">network error</a>. </p>
      <li class="XXX">
       <p>Needs testing: multiple `<code>Proxy-Authenticate</code>` headers, missing,
   parsing issues. </p>
      <li>
       <p>If the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①⓪">terminated</a>, then: </p>
       <ol>
        <li>
         <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
        <li>
         <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error⑤">aborted network error</a>. </p>
        <li>
         <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤⓪">network error</a>. </p>
       </ol>
      <li>
       <p>Prompt the end user as appropriate in <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window⑦">window</a> and store the result as a <a data-link-type="dfn" href="#proxy-authentication-entry" id="ref-for-proxy-authentication-entry①">proxy-authentication entry</a>. <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> </p>
       <p class="note" role="note">Remaining details surrounding proxy authentication are defined by HTTP. </p>
      <li>
       <p>Set <var>response</var> to the result of performing an <a data-link-type="dfn" href="#concept-http-network-or-cache-fetch" id="ref-for-concept-http-network-or-cache-fetch②">HTTP-network-or-cache fetch</a> using <var>request</var>. </p>
     </ol>
    <li>
     <p>If <i>authentication-fetch flag</i> is set, then create an <a data-link-type="dfn" href="#authentication-entry" id="ref-for-authentication-entry③">authentication entry</a> for <var>request</var> and the given realm. </p>
    <li>
     <p>Return <var>response</var>. <span class="note no-backref">Typically <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①⑦">body</a>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①⓪">stream</a> is still being enqueued to after returning.</span> </p>
   </ol>
   <h3 class="heading settled" data-level="4.6" id="http-network-fetch"><span class="secno">4.6. </span><span class="content">HTTP-network fetch</span><a class="self-link" href="#http-network-fetch"></a></h3>
   <p>To perform an <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-http-network-fetch">HTTP-network fetch</dfn> using <var>request</var> with an optional <i>credentials flag</i>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>credentials</var> be true if <i>credentials flag</i> is set, and false otherwise. </p>
    <li>
     <p>Let <var>response</var> be null. </p>
    <li>
     <p>Switch on <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①③">mode</a>: </p>
     <dl>
      <dt>"<code>websocket</code>" 
      <dd>
       <p>Let <var>connection</var> be the result of <a data-link-type="dfn" href="#concept-websocket-connection-obtain" id="ref-for-concept-websocket-connection-obtain">obtaining a WebSocket connection</a>, given <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③②">current URL</a>. </p>
      <dt>Otherwise 
      <dd>
       <p>Let <var>connection</var> be the result of <a data-link-type="dfn" href="#concept-connection-obtain" id="ref-for-concept-connection-obtain">obtaining a connection</a>, given <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③③">current URL</a>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin⑨">origin</a> and <var>credentials</var>. </p>
     </dl>
    <li>
     <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when⑥">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①①">terminated</a>: </p>
     <ol>
      <li>
       <p>If <var>connection</var> is failure, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤①">network error</a>. </p>
      <li>
       <p>If <var>connection</var> is not an HTTP/2 connection, <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③⓪">body</a> is non-null, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③①">body</a>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source⑨">source</a> is null, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append①⑨">append</a> `<code>Transfer-Encoding</code>`/`<code>chunked</code>` to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③④">header list</a>. </p>
      <li>
       <p>Set <var>response</var> to the result of making an HTTP request over <var>connection</var> using <var>request</var> with the following caveats: </p>
       <ul>
        <li>
         <p>Follow the relevant requirements from HTTP. <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-http-semantics">[HTTP-SEMANTICS]</a> <a data-link-type="biblio" href="#biblio-http-cond">[HTTP-COND]</a> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> </p>
        <li>
         <p>Wait until all the <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥②">headers</a> are transmitted. </p>
        <li>
         <p>Any <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response④⑨">responses</a> whose <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status①⑨">status</a> is in the range <code>100</code> to <code>199</code>, inclusive, and is not <code>101</code>, are to be ignored. </p>
         <p class="note no-backref" role="note">These kind of <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤⓪">responses</a> are
      eventually followed by a "final" <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤①">response</a>. </p>
       </ul>
       <p class="note" role="note">The exact layering between Fetch and HTTP still needs to be sorted through and
    therefore <var>response</var> represents both a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤②">response</a> and
    an HTTP response here. </p>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③⑤">header list</a> contains
    `<code>Transfer-Encoding</code>`/`<code>chunked</code>` and <var>response</var> is transferred
    via HTTP/1.0 or older, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤②">network error</a>. </p>
       <p>If the HTTP request results in a TLS client certificate dialog, then: </p>
       <ol>
        <li>
         <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window⑧">window</a> is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object①①">environment settings object</a>, make the dialog
     available in <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window⑨">window</a>. </p>
        <li>
         <p>Otherwise, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤③">network error</a>. </p>
       </ol>
       <p>If <var>response</var> was retrieved over HTTPS, set its <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state⑧">HTTPS state</a> to either
    "<code>deprecated</code>" or "<code>modern</code>". <a data-link-type="biblio" href="#biblio-tls">[TLS]</a> </p>
       <p class="note no-backref" role="note">The exact determination here is up to user agents for the
    time being. User agents are strongly encouraged to only succeed HTTPS connections with
    strong security properties and return <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤④">network errors</a> otherwise. Using the
    "<code>deprecated</code>" state value ought to be a temporary and last resort kind
    of option. </p>
       <p><a data-link-type="dfn" href="#concept-request-transmit-body" id="ref-for-concept-request-transmit-body①">Transmit body</a> for <var>request</var>. </p>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted⑥">If aborted</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
      <li>
       <p>If <var>connection</var> uses HTTP/2, then transmit an <code>RST_STREAM</code> frame. </p>
      <li>
       <p>If <var>aborted</var> is set, then return an <a data-link-type="dfn" href="#concept-aborted-network-error" id="ref-for-concept-aborted-network-error⑥">aborted network error</a>. </p>
      <li>
       <p>Return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤⑤">network error</a>. </p>
     </ol>
    <li>
     <p>Let <var>highWaterMark</var> be a non-negative, non-NaN number, chosen by the user agent. </p>
    <li>
     <p>Let <var>sizeAlgorithm</var> be an algorithm that accepts a <a data-link-type="dfn" href="https://streams.spec.whatwg.org/#chunk" id="ref-for-chunk">chunk</a> object and returns
 a non-negative, non-NaN, non-infinite number, chosen by the user agent. </p>
    <li>
     <p>Let <var>pull</var> be an action that <a data-link-type="dfn" href="#concept-fetch-resume" id="ref-for-concept-fetch-resume">resumes</a> the ongoing fetch
 if it is <a data-link-type="dfn" href="#concept-fetch-suspend" id="ref-for-concept-fetch-suspend">suspended</a>. </p>
    <li>
     <p>Let <var>cancel</var> be an action that <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①②">terminates</a> the
 ongoing fetch with the aborted flag set. </p>
    <li>
     <p>Let <var>stream</var> be the result of <a data-link-type="dfn" href="#concept-construct-readablestream" id="ref-for-concept-construct-readablestream①">constructing</a> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②①">ReadableStream</a></code> object with <var>highWaterMark</var>, <var>sizeAlgorithm</var>, <var>pull</var>, and <var>cancel</var>. </p>
     <p class="note no-backref" role="note">This construction operation will not throw an exception. </p>
    <li>
     <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when⑦">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①③">terminated</a>: </p>
     <ol>
      <li>
       <p>Set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①⑧">body</a> to a new <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body⑦">body</a> whose <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①①">stream</a> is <var>stream</var>. </p>
      <li>
       <p>If <var>response</var> has a payload body length, then set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body①⑨">body</a>’s <a data-link-type="dfn" href="#concept-body-total-bytes" id="ref-for-concept-body-total-bytes②">total bytes</a> to that payload body length. </p>
      <li>
       <p>If <var>response</var> is not a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤⑥">network error</a> and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①⓪">cache mode</a> is not "<code>no-store</code>",
   update <var>response</var> in the HTTP cache for <var>request</var>. </p>
      <li>
       <p>If <i>credentials flag</i> is set and the user agent is not configured to block cookies for <var>request</var> (see <a href="https://tools.ietf.org/html/rfc6265#section-7">section 7</a> of <a data-link-type="biblio" href="#biblio-cookies">[COOKIES]</a>), then run the "set-cookie-string" parsing algorithm (see <a href="https://tools.ietf.org/html/rfc6265#section-5.2">section 5.2</a> of <a data-link-type="biblio" href="#biblio-cookies">[COOKIES]</a>) on the <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③④">value</a> of each <var>header</var> whose <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name④⑨">name</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①④">byte-case-insensitive</a> match for `<code>Set-Cookie</code>` in <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②⑤">header list</a>, if any, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③④">current URL</a>. </p>
       <p class="note" role="note">This is a fingerprinting vector. </p>
     </ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted⑦">If aborted</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
      <li>
       <p>If <var>aborted</var> is set, then set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-aborted" id="ref-for-concept-response-aborted①">aborted flag</a>. </p>
      <li>
       <p>Return <var>response</var>. </p>
     </ol>
    <li>
     <p>Run these steps <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel④">in parallel</a>: </p>
     <ol>
      <li>
       <p>Run these steps, but <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#abort-when" id="ref-for-abort-when⑧">abort when</a> the ongoing fetch is <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①④">terminated</a>: </p>
       <ol>
        <li>
         <p>While true: </p>
         <ol>
          <li>
           <p>If one or more bytes have been transmitted from <var>response</var>’s message body, then: </p>
           <ol>
            <li>
             <p>Let <var>bytes</var> be the transmitted bytes. </p>
            <li>
             <p>Increase <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②⓪">body</a>’s <a data-link-type="dfn" href="#concept-body-transmitted" id="ref-for-concept-body-transmitted①">transmitted
         bytes</a> with <var>bytes</var>’ length. </p>
            <li>
             <p>Let <var>codings</var> be the result of <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values②">extracting header list values</a> given
         `<code>Content-Encoding</code>` and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②⑥">header list</a>. </p>
            <li>
             <p>Set <var>bytes</var> to the result of <a data-link-type="dfn" href="#handle-content-codings" id="ref-for-handle-content-codings①">handling content
          codings</a> given <var>codings</var> and <var>bytes</var>. </p>
             <p class="note no-backref" role="note">This makes the `<code>Content-Length</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥③">header</a> unreliable to the extent that it was reliable to begin with. </p>
            <li>
             <p>If <var>bytes</var> is failure, then <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①⑤">terminate</a> the
         ongoing fetch. </p>
            <li>
             <p><a data-link-type="dfn" href="#concept-enqueue-readablestream" id="ref-for-concept-enqueue-readablestream①">Enqueue</a> a <code>Uint8Array</code> object wrapping an <code>ArrayBuffer</code> containing <var>bytes</var> to <var>stream</var>. If that threw an
         exception, <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①⑥">terminate</a> the ongoing fetch, and <a data-link-type="abstract-op" href="#concept-error-readablestream" id="ref-for-concept-error-readablestream">error</a> <var>stream</var> with that exception. </p>
            <li>
             <p>If <var>stream</var> doesn’t <a data-link-type="dfn" href="#concept-readablestream-need-more-data" id="ref-for-concept-readablestream-need-more-data">need more
         data</a> and <var>request</var>’s <a data-link-type="dfn" href="#synchronous-flag" id="ref-for-synchronous-flag④">synchronous flag</a> is unset, ask the user agent to <a data-link-type="dfn" href="#concept-fetch-suspend" id="ref-for-concept-fetch-suspend①">suspend</a> the ongoing fetch. </p>
           </ol>
          <li>
           <p>Otherwise, if the bytes transmission for <var>response</var>’s message body is done
       normally and <var>stream</var> is <a data-link-type="dfn" href="#concept-readablestream-readable" id="ref-for-concept-readablestream-readable①">readable</a>, then <a data-link-type="abstract-op" href="#concept-close-readablestream" id="ref-for-concept-close-readablestream①">close</a> <var>stream</var> and abort these in-parallel steps. </p>
         </ol>
       </ol>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#if-aborted" id="ref-for-if-aborted⑧">If aborted</a>, then: </p>
       <ol>
        <li>
         <p>Let <var>aborted</var> be the termination’s aborted flag. </p>
        <li>
         <p>If <var>aborted</var> is set, then: </p>
         <ol>
          <li>
           <p>Set <var>response</var>’s <a data-link-type="dfn" href="#concept-response-aborted" id="ref-for-concept-response-aborted②">aborted flag</a>. </p>
          <li>
           <p>If <var>stream</var> is <a data-link-type="dfn" href="#concept-readablestream-readable" id="ref-for-concept-readablestream-readable②">readable</a>, <a data-link-type="abstract-op" href="#concept-error-readablestream" id="ref-for-concept-error-readablestream①">error</a> <var>stream</var> with an "<code><a class="idl-code" data-link-type="exception" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror①">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException①">DOMException</a></code>. </p>
         </ol>
        <li>
         <p>Otherwise, if <var>stream</var> is <a data-link-type="dfn" href="#concept-readablestream-readable" id="ref-for-concept-readablestream-readable③">readable</a>, <a data-link-type="abstract-op" href="#concept-error-readablestream" id="ref-for-concept-error-readablestream②">error</a> <var>stream</var> with a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①">TypeError</a></code>. </p>
        <li>
         <p>If <var>connection</var> uses HTTP/2, then transmit an <code>RST_STREAM</code> frame. </p>
        <li>
         <p>Otherwise, the user agent should close <var>connection</var> unless it would be bad for
      performance to do so. </p>
         <p class="note" role="note">For instance, the user agent could keep the connection open if it knows there’s
      only a few bytes of transfer remaining on a reusable connection. In this case it could be
      worse to close the connection and go through the handshake process again for the next fetch. </p>
       </ol>
     </ol>
     <p class="note no-backref" role="note">These are run <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel⑤">in parallel</a> as at this point it is unclear whether <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②①">body</a> is relevant (<var>response</var> might be a
  redirect). </p>
    <li>
     <p>Return <var>response</var>. <span class="note no-backref">Typically <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②②">body</a>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①②">stream</a> is still being enqueued to after
 returning.</span> </p>
   </ol>
   <h3 class="heading settled" data-level="4.7" id="cors-preflight-fetch"><span class="secno">4.7. </span><span class="content">CORS-preflight fetch</span><a class="self-link" href="#cors-preflight-fetch"></a></h3>
   <p class="note no-backref" role="note">This is effectively the user agent implementation of the check to see if
the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①⑧">CORS protocol</a> is understood. The so-called <a data-link-type="dfn" href="#cors-preflight-request" id="ref-for-cors-preflight-request①⓪">CORS-preflight request</a>. If
successful it populates the <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache①">CORS-preflight cache</a> to minimize the
number of these <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0⑤">fetches</a>. </p>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="cors-preflight-fetch-0">CORS-preflight fetch</dfn> using <var>request</var>,
run these steps: </p>
   <ol>
    <li>
     <p>Let <var>preflight</var> be a new <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request⑨⑨">request</a> whose <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①④">method</a> is `<code>OPTIONS</code>`, <a data-link-type="dfn" href="#concept-request-url" id="ref-for-concept-request-url①">URL</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③⑤">current URL</a>, <a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator⑤">initiator</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-initiator" id="ref-for-concept-request-initiator⑥">initiator</a>, <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①⑤">destination</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①⑥">destination</a>, <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①③">origin</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①④">origin</a>, <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer⑥">referrer</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer⑦">referrer</a>, <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy⑥">referrer policy</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy⑦">referrer policy</a>, <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①④">mode</a> is "<code>cors</code>", <a data-link-type="dfn" href="#concept-request-tainted-origin" id="ref-for-concept-request-tainted-origin③">tainted origin flag</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-tainted-origin" id="ref-for-concept-request-tainted-origin④">tainted origin flag</a>, and <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①⑥">response tainting</a> is "<code>cors</code>". </p>
     <p class="note no-backref" role="note">The <a data-link-type="dfn" href="#request-service-workers-mode" id="ref-for-request-service-workers-mode③">service-workers mode</a> of <var>preflight</var> does not matter as this algorithm uses <a data-link-type="dfn" href="#concept-http-network-or-cache-fetch" id="ref-for-concept-http-network-or-cache-fetch③">HTTP-network-or-cache fetch</a> rather than <a data-link-type="dfn" href="#concept-http-fetch" id="ref-for-concept-http-fetch⑦">HTTP fetch</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②⓪">Append</a> `<code>Accept</code>`/`<code>*/*</code>` to <var>preflight</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③⑥">header list</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②①">Append</a> `<a data-link-type="http-header" href="#http-access-control-request-method" id="ref-for-http-access-control-request-method①"><code>Access-Control-Request-Method</code></a>`
 to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①⑤">method</a> in <var>preflight</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③⑦">header list</a>. </p>
    <li>
     <p>Let <var>headers</var> be the <a data-link-type="dfn" href="#cors-unsafe-request-header-names" id="ref-for-cors-unsafe-request-header-names②">CORS-unsafe request-header names</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③⑧">header list</a>. </p>
    <li>
     <p>If <var>headers</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty②">is not empty</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>value</var> be the items in <var>headers</var> separated from each other by
   `<code>,</code>`. </p>
      <li>
       <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②②">Append</a> `<a data-link-type="http-header" href="#http-access-control-request-headers" id="ref-for-http-access-control-request-headers①"><code>Access-Control-Request-Headers</code></a>` to <var>value</var> in <var>preflight</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list③⑨">header list</a>. </p>
     </ol>
     <p class="note" role="note">This intentionally does not use <a data-link-type="dfn" href="#concept-header-list-combine" id="ref-for-concept-header-list-combine①">combine</a>, as 0x20 following
  0x2C is not the way this was implemented, for better or worse. </p>
    <li>
     <p>Let <var>response</var> be the result of performing an <a data-link-type="dfn" href="#concept-http-network-or-cache-fetch" id="ref-for-concept-http-network-or-cache-fetch④">HTTP-network-or-cache fetch</a> using <var>preflight</var>. </p>
    <li>
     <p>If a <a data-link-type="dfn" href="#concept-cors-check" id="ref-for-concept-cors-check②">CORS check</a> for <var>request</var> and <var>response</var> returns success and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②⓪">status</a> is an <a data-link-type="dfn" href="#ok-status" id="ref-for-ok-status">ok status</a>, then: </p>
     <p class="note no-backref" role="note">The <a data-link-type="dfn" href="#concept-cors-check" id="ref-for-concept-cors-check③">CORS check</a> is done on <var>request</var> rather than <var>preflight</var> to ensure the correct <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①②">credentials mode</a> is used. </p>
     <ol>
      <li>
       <p>Let <var>methods</var> be the result of <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values③">extracting header list values</a> given
   `<a data-link-type="http-header" href="#http-access-control-allow-methods" id="ref-for-http-access-control-allow-methods②"><code>Access-Control-Allow-Methods</code></a>` and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②⑦">header list</a>. </p>
      <li>
       <p>Let <var>headerNames</var> be the result of <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values④">extracting header list values</a> given
   `<a data-link-type="http-header" href="#http-access-control-allow-headers" id="ref-for-http-access-control-allow-headers②"><code>Access-Control-Allow-Headers</code></a>` and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②⑧">header list</a>. </p>
      <li>
       <p>If either <var>methods</var> or <var>headerNames</var> is failure,
   return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤⑦">network error</a>. </p>
      <li>
       <p>If <var>methods</var> is null and <var>request</var>’s <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag④">use-CORS-preflight flag</a> is set, then set <var>methods</var> to a new list containing <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①⑥">method</a>. </p>
       <p class="note no-backref" role="note">This ensures that a <a data-link-type="dfn" href="#cors-preflight-fetch-0" id="ref-for-cors-preflight-fetch-0⑥">CORS-preflight fetch</a> that
    happened due to <var>request</var>’s <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag⑤">use-CORS-preflight flag</a> being set is <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache②">cached</a>. </p>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①⑦">method</a> is not in <var>methods</var>, <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①⑧">method</a> is not a <a data-link-type="dfn" href="#cors-safelisted-method" id="ref-for-cors-safelisted-method③">CORS-safelisted method</a>, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①③">credentials mode</a> is "<code>include</code>" or <var>methods</var> does not contain `<code>*</code>`, then return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤⑧">network error</a>. </p>
      <li>
       <p>If one of <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④⓪">header list</a>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤⓪">names</a> is a <a data-link-type="dfn" href="#cors-non-wildcard-request-header-name" id="ref-for-cors-non-wildcard-request-header-name">CORS non-wildcard request-header name</a> and is not a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①⑤">byte-case-insensitive</a> match for an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-item" id="ref-for-list-item①">item</a> in <var>headerNames</var>, then
   return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑤⑨">network error</a>. </p>
      <li>
       <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate⑦">For each</a> <var>unsafeName</var> in the <a data-link-type="dfn" href="#cors-unsafe-request-header-names" id="ref-for-cors-unsafe-request-header-names③">CORS-unsafe request-header names</a> with <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④①">header list</a>, if <var>unsafeName</var> is not a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①⑥">byte-case-insensitive</a> match for an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-item" id="ref-for-list-item②">item</a> in <var>headerNames</var> and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①④">credentials mode</a> is "<code>include</code>" or <var>headerNames</var> does not
   contain `<code>*</code>`, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑥⓪">network error</a>. </p>
      <li>
       <p>Let <var>max-age</var> be the result of <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values⑤">extracting header list values</a> given
   `<a data-link-type="http-header" href="#http-access-control-max-age" id="ref-for-http-access-control-max-age"><code>Access-Control-Max-Age</code></a>` and <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list②⑨">header list</a>. </p>
      <li>
       <p>If <var>max-age</var> is failure or null, then set <var>max-age</var> to 5. </p>
      <li>
       <p>If <var>max-age</var> is greater than an imposed limit on <a data-link-type="dfn" href="#concept-cache-max-age" id="ref-for-concept-cache-max-age">max-age</a>, then set <var>max-age</var> to the imposed limit. </p>
      <li>
       <p>If the user agent does not provide for a <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache③">cache</a>, then
   return <var>response</var>. </p>
      <li>
       <p>For each <var>method</var> in <var>methods</var> for which there is a <a data-link-type="dfn" href="#concept-cache-match-method" id="ref-for-concept-cache-match-method①">method cache entry match</a> using <var>request</var>, set matching entry’s <a data-link-type="dfn" href="#concept-cache-max-age" id="ref-for-concept-cache-max-age①">max-age</a> to <var>max-age</var>. </p>
      <li>
       <p>For each <var>method</var> in <var>methods</var> for which there is no <a data-link-type="dfn" href="#concept-cache-match-method" id="ref-for-concept-cache-match-method②">method cache entry match</a> using <var>request</var>, <a data-link-type="dfn" href="#concept-cache-create-entry" id="ref-for-concept-cache-create-entry">create a new cache entry</a> with <var>request</var>, <var>max-age</var>, <var>method</var>, and null. </p>
      <li>
       <p>For each <var>headerName</var> in <var>headerNames</var> for which there is a <a data-link-type="dfn" href="#concept-cache-match-header" id="ref-for-concept-cache-match-header①">header-name cache entry match</a> using <var>request</var>, set matching entry’s <a data-link-type="dfn" href="#concept-cache-max-age" id="ref-for-concept-cache-max-age②">max-age</a> to <var>max-age</var>. </p>
      <li>
       <p>For each <var>headerName</var> in <var>headerNames</var> for which there is no <a data-link-type="dfn" href="#concept-cache-match-header" id="ref-for-concept-cache-match-header②">header-name cache entry match</a> using <var>request</var>, <a data-link-type="dfn" href="#concept-cache-create-entry" id="ref-for-concept-cache-create-entry①">create a new cache entry</a> with <var>request</var>, <var>max-age</var>, null, and <var>headerName</var>. </p>
      <li>
       <p>Return <var>response</var>. </p>
     </ol>
    <li>
     <p>Otherwise, return a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑥①">network error</a>. </p>
   </ol>
   <h3 class="heading settled" data-level="4.8" id="cors-preflight-cache"><span class="secno">4.8. </span><span class="content">CORS-preflight cache</span><a class="self-link" href="#cors-preflight-cache"></a></h3>
   <p>A user agent has an associated <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache④">CORS-preflight cache</a>. A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cache">CORS-preflight cache</dfn> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list⑨">list</a> of <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry">cache entries</a>. </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="cache-entry">cache entry</dfn> consists of: </p>
   <ul class="brief">
    <li><dfn class="dfn-paneled" data-dfn-for="cache entry" data-dfn-type="dfn" data-noexport id="concept-cache-origin">byte-serialized origin</dfn> (a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence" id="ref-for-byte-sequence④">byte sequence</a>) 
    <li><dfn class="dfn-paneled" data-dfn-for="cache entry" data-dfn-type="dfn" data-noexport id="concept-cache-url">URL</dfn> (a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①⑤">URL</a>) 
    <li><dfn class="dfn-paneled" data-dfn-for="cache entry" data-dfn-type="dfn" data-noexport id="concept-cache-max-age">max-age</dfn> (a number of seconds) 
    <li><dfn class="dfn-paneled" data-dfn-for="cache entry" data-dfn-type="dfn" data-noexport id="concept-cache-credentials">credentials</dfn> (a boolean) 
    <li><dfn class="dfn-paneled" data-dfn-for="cache entry" data-dfn-type="dfn" data-noexport id="concept-cache-method">method</dfn> (null, `<code>*</code>`, or a <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method①①">method</a>) 
    <li><dfn class="dfn-paneled" data-dfn-for="cache entry" data-dfn-type="dfn" data-noexport id="concept-cache-header-name">header name</dfn> (null, `<code>*</code>`,
 or a <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥④">header</a> <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤①">name</a>) 
   </ul>
   <p><a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry①">Cache entries</a> must be removed after the seconds specified in their <a data-link-type="dfn" href="#concept-cache-max-age" id="ref-for-concept-cache-max-age③">max-age</a> field have passed since storing the entry. <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry②">Cache entries</a> may
be removed before that moment arrives. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cache-create-entry">create a new cache entry</dfn>, given <var>request</var>, <var>max-age</var>, <var>method</var>, and <var>headerName</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>entry</var> be a <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry③">cache entry</a>, initialized as follows: </p>
     <dl>
      <dt><a data-link-type="dfn" href="#concept-cache-origin" id="ref-for-concept-cache-origin">byte-serialized origin</a> 
      <dd>
       <p>The result of <a data-link-type="dfn" href="#byte-serializing-a-request-origin" id="ref-for-byte-serializing-a-request-origin①">byte-serializing a request origin</a> with <var>request</var> </p>
      <dt><a data-link-type="dfn" href="#concept-cache-url" id="ref-for-concept-cache-url">URL</a> 
      <dd>
       <p><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③⑥">current URL</a> </p>
      <dt><a data-link-type="dfn" href="#concept-cache-max-age" id="ref-for-concept-cache-max-age④">max-age</a> 
      <dd>
       <p><var>max-age</var> </p>
      <dt><a data-link-type="dfn" href="#concept-cache-credentials" id="ref-for-concept-cache-credentials">credentials</a> 
      <dd>
       <p>True if <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①⑤">credentials mode</a> is
   "<code>include</code>", and false otherwise </p>
      <dt><a data-link-type="dfn" href="#concept-cache-method" id="ref-for-concept-cache-method">method</a> 
      <dd>
       <p><var>method</var> </p>
      <dt><a data-link-type="dfn" href="#concept-cache-header-name" id="ref-for-concept-cache-header-name">header name</a> 
      <dd>
       <p><var>headerName</var> </p>
     </dl>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append⑧">Append</a> <var>entry</var> to the user agent’s <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache⑤">CORS-preflight cache</a>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cache-clear">clear cache entries</dfn>, given a <var>request</var>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-remove" id="ref-for-list-remove②">remove</a> any <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry④">cache entries</a> in the user agent’s <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache⑥">CORS-preflight cache</a> whose <a data-link-type="dfn" href="#concept-cache-origin" id="ref-for-concept-cache-origin①">byte-serialized origin</a> is the result of <a data-link-type="dfn" href="#byte-serializing-a-request-origin" id="ref-for-byte-serializing-a-request-origin②">byte-serializing a request origin</a> with <var>request</var> and whose <a data-link-type="dfn" href="#concept-cache-url" id="ref-for-concept-cache-url①">URL</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③⑦">current URL</a>. </p>
   <p>There is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cache-match">cache entry match</dfn> for a <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry⑤">cache entry</a> <var>entry</var> with <var>request</var> if <var>entry</var>’s <a data-link-type="dfn" href="#concept-cache-origin" id="ref-for-concept-cache-origin②">byte-serialized origin</a> is the result of <a data-link-type="dfn" href="#byte-serializing-a-request-origin" id="ref-for-byte-serializing-a-request-origin③">byte-serializing a request origin</a> with <var>request</var>, <var>entry</var>’s <a data-link-type="dfn" href="#concept-cache-url" id="ref-for-concept-cache-url②">URL</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③⑧">current URL</a>, and one of </p>
   <ul class="brief">
    <li><var>entry</var>’s <a data-link-type="dfn" href="#concept-cache-credentials" id="ref-for-concept-cache-credentials①">credentials</a> is true 
    <li><var>entry</var>’s <a data-link-type="dfn" href="#concept-cache-credentials" id="ref-for-concept-cache-credentials②">credentials</a> is false and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①⑥">credentials mode</a> is not "<code>include</code>". 
   </ul>
   <p>is true. </p>
   <p>There is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cache-match-method">method cache entry match</dfn> for <var>method</var> using <var>request</var> when there is a <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry⑥">cache entry</a> in the user agent’s <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache⑦">CORS-preflight cache</a> for which there is a <a data-link-type="dfn" href="#concept-cache-match" id="ref-for-concept-cache-match">cache entry match</a> with <var>request</var> and its <a data-link-type="dfn" href="#concept-cache-method" id="ref-for-concept-cache-method①">method</a> is <var>method</var> or `<code>*</code>`. </p>
   <p>There is a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cache-match-header">header-name cache entry match</dfn> for <var>headerName</var> using <var>request</var> when there is a <a data-link-type="dfn" href="#cache-entry" id="ref-for-cache-entry⑦">cache entry</a> in the user
agent’s <a data-link-type="dfn" href="#concept-cache" id="ref-for-concept-cache⑧">CORS-preflight cache</a> for which there is a <a data-link-type="dfn" href="#concept-cache-match" id="ref-for-concept-cache-match①">cache entry match</a> with <var>request</var> and one of </p>
   <ul class="brief">
    <li>its <a data-link-type="dfn" href="#concept-cache-header-name" id="ref-for-concept-cache-header-name①">header name</a> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-case-insensitive" id="ref-for-byte-case-insensitive①⑦">byte-case-insensitive</a> match for <var>headerName</var> 
    <li>its <a data-link-type="dfn" href="#concept-cache-header-name" id="ref-for-concept-cache-header-name②">header name</a> is `<code>*</code>` and <var>headerName</var> is not
 a <a data-link-type="dfn" href="#cors-non-wildcard-request-header-name" id="ref-for-cors-non-wildcard-request-header-name①">CORS non-wildcard request-header name</a> 
   </ul>
   <p>is true. </p>
   <h3 class="heading settled" data-level="4.9" id="cors-check"><span class="secno">4.9. </span><span class="content">CORS check</span><a class="self-link" href="#cors-check"></a></h3>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-cors-check">CORS check</dfn> for a <var>request</var> and <var>response</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>origin</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get④">getting</a> `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin⑥"><code>Access-Control-Allow-Origin</code></a>` from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③⓪">header list</a>. </p>
    <li>
     <p>If <var>origin</var> is null, then return failure. </p>
     <p class="note" role="note">Null is not `<code>null</code>`. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①⑦">credentials mode</a> is not "<code>include</code>"
 and <var>origin</var> is `<code>*</code>`, then return success. </p>
    <li>
     <p>If the result of <a data-link-type="dfn" href="#byte-serializing-a-request-origin" id="ref-for-byte-serializing-a-request-origin④">byte-serializing a request origin</a> with <var>request</var> is not <var>origin</var>, then return failure. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①⑧">credentials mode</a> is not "<code>include</code>",
 then return success. </p>
    <li>
     <p>Let <var>credentials</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get⑤">getting</a> `<a data-link-type="http-header" href="#http-access-control-allow-credentials" id="ref-for-http-access-control-allow-credentials④"><code>Access-Control-Allow-Credentials</code></a>` from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③①">header list</a>. </p>
    <li>
     <p>If <var>credentials</var> is `<code>true</code>`, then return success. </p>
    <li>
     <p>Return failure. </p>
   </ol>
   <h3 class="heading settled" data-level="4.10" id="tao-check"><span class="secno">4.10. </span><span class="content">TAO check</span><a class="self-link" href="#tao-check"></a></h3>
   <p>To perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-tao-check">TAO check</dfn> for a <var>request</var> and <var>response</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#timing-allow-failed" id="ref-for-timing-allow-failed④">timing allow failed flag</a> is set, then return
 failure. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-response-tainting" id="ref-for-concept-request-response-tainting①⑦">response tainting</a> is "<code>basic</code>", then
 return success. </p>
    <li>
     <p>Let <var>values</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get-decode-split" id="ref-for-concept-header-list-get-decode-split④">getting, decoding, and splitting</a> `<code>Timing-Allow-Origin</code>` from <var>response</var>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③②">header list</a>. </p>
    <li>
     <p>If <var>values</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain①">contains</a> "<code>*</code>", then return success. </p>
    <li>
     <p>If <var>values</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain②">contains</a> the result of <a data-link-type="dfn" href="#serializing-a-request-origin" id="ref-for-serializing-a-request-origin①">serializing a request origin</a> with <var>request</var>, then return success. </p>
    <li>
     <p>Return failure. </p>
   </ol>
   <h2 class="heading settled" data-level="5" id="fetch-api"><span class="secno">5. </span><span class="content">Fetch API</span><a class="self-link" href="#fetch-api"></a></h2>
   <p class="no-backref">The <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch④"><code>fetch()</code></a> method is relatively
low-level API for <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②⑥">fetching</a> resources. It covers slightly
more ground than <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest⑤">XMLHttpRequest</a></code>, although it is
currently lacking when it comes to request progression (not response progression). </p>
   <div class="example no-backref" id="fetch-blob-example">
    <a class="self-link" href="#fetch-blob-example"></a> 
    <p>The <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch⑤"><code>fetch()</code></a> method makes it quite straightforward
 to <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②⑦">fetch</a> a resource and extract its contents as a <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-Blob" id="ref-for-dfn-Blob①">Blob</a></code>: </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"/music/pk/altes-kamuffel.flac"</c-><c- p>)</c->
  <c- p>.</c->then<c- p>(</c->res <c- p>=></c-> res<c- p>.</c->blob<c- p>()).</c->then<c- p>(</c->playBlob<c- p>)</c->
</code></pre>
    <p>If you just care to log a particular response header: </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"/"</c-><c- p>,</c-> <c- p>{</c->method<c- o>:</c-><c- u>"HEAD"</c-><c- p>})</c->
  <c- p>.</c->then<c- p>(</c->res <c- p>=></c-> log<c- p>(</c->res<c- p>.</c->headers<c- p>.</c->get<c- p>(</c-><c- u>"strict-transport-security"</c-><c- p>)))</c->
</code></pre>
    <p>If you want to check a particular response header and then process the response of a
 cross-origin resources: </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"https://pk.example/berlin-calling.json"</c-><c- p>,</c-> <c- p>{</c->mode<c- o>:</c-><c- u>"cors"</c-><c- p>})</c->
  <c- p>.</c->then<c- p>(</c->res <c- p>=></c-> <c- p>{</c->
    <c- k>if</c-><c- p>(</c->res<c- p>.</c->headers<c- p>.</c->get<c- p>(</c-><c- u>"content-type"</c-><c- p>)</c-> <c- o>&amp;&amp;</c->
       res<c- p>.</c->headers<c- p>.</c->get<c- p>(</c-><c- u>"content-type"</c-><c- p>).</c->toLowerCase<c- p>().</c->indexOf<c- p>(</c-><c- u>"application/json"</c-><c- p>)</c-> <c- o>>=</c-> <c- mi>0</c-><c- p>)</c-> <c- p>{</c->
      <c- k>return</c-> res<c- p>.</c->json<c- p>()</c->
    <c- p>}</c-> <c- k>else</c-> <c- p>{</c->
      <c- k>throw</c-> <c- k>new</c-> TypeError<c- p>()</c->
    <c- p>}</c->
  <c- p>}).</c->then<c- p>(</c->processJSON<c- p>)</c->
</code></pre>
    <p>If you want to work with URL query parameters: </p>
<pre><code class="lang-javascript highlight"><c- a>var</c-> url <c- o>=</c-> <c- k>new</c-> URL<c- p>(</c-><c- u>"https://geo.example.org/api"</c-><c- p>),</c->
    params <c- o>=</c-> <c- p>{</c->lat<c- o>:</c-><c- mf>35.696233</c-><c- p>,</c-> <c- kr>long</c-><c- o>:</c-><c- mf>139.570431</c-><c- p>}</c->
Object<c- p>.</c->keys<c- p>(</c->params<c- p>).</c->forEach<c- p>(</c->key <c- p>=></c-> url<c- p>.</c->searchParams<c- p>.</c->append<c- p>(</c->key<c- p>,</c-> params<c- p>[</c->key<c- p>]))</c->
fetch<c- p>(</c->url<c- p>).</c->then<c- p>(</c-><c- d>/* … */</c-><c- p>)</c->
</code></pre>
    <p>If you want to receive the body data progressively: </p>
<pre><code class="lang-javascript highlight"><c- a>function</c-> consume<c- p>(</c->reader<c- p>)</c-> <c- p>{</c->
  <c- a>var</c-> total <c- o>=</c-> <c- mi>0</c->
  <c- k>return</c-> pump<c- p>()</c->
  <c- a>function</c-> pump<c- p>()</c-> <c- p>{</c->
    <c- k>return</c-> reader<c- p>.</c->read<c- p>().</c->then<c- p>(({</c->done<c- p>,</c-> value<c- p>})</c-> <c- p>=></c-> <c- p>{</c->
      <c- k>if</c-> <c- p>(</c->done<c- p>)</c-> <c- p>{</c->
        <c- k>return</c->
      <c- p>}</c->
      total <c- o>+=</c-> value<c- p>.</c->byteLength
      log<c- p>(</c-><c- sb>`received </c-><c- si>${</c->value<c- p>.</c->byteLength<c- si>}</c-><c- sb> bytes (</c-><c- si>${</c->total<c- si>}</c-><c- sb> bytes in total)`</c-><c- p>)</c->
      <c- k>return</c-> pump<c- p>()</c->
    <c- p>})</c->
  <c- p>}</c->
<c- p>}</c->

fetch<c- p>(</c-><c- u>"/music/pk/altes-kamuffel.flac"</c-><c- p>)</c->
  <c- p>.</c->then<c- p>(</c->res <c- p>=></c-> consume<c- p>(</c->res<c- p>.</c->body<c- p>.</c->getReader<c- p>()))</c->
  <c- p>.</c->then<c- p>(()</c-> <c- p>=></c-> log<c- p>(</c-><c- u>"consumed the entire body without keeping the whole thing in memory!"</c-><c- p>))</c->
  <c- p>.</c-><c- k>catch</c-><c- p>(</c->e <c- p>=></c-> log<c- p>(</c-><c- u>"something went wrong: "</c-> <c- o>+</c-> e<c- p>))</c->
</code></pre>
   </div>
   <h3 class="heading settled" data-level="5.1" id="headers-class"><span class="secno">5.1. </span><span class="content">Headers class</span><a class="self-link" href="#headers-class"></a></h3>
<pre class="idl highlight def"><c- b>typedef</c-> (<c- b>sequence</c->&lt;<c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString"><c- b>ByteString</c-></a>>> <c- b>or</c-> <c- b>record</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①"><c- b>ByteString</c-></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString②"><c- b>ByteString</c-></a>>) <dfn class="dfn-paneled idl-code" data-dfn-type="typedef" data-export id="typedefdef-headersinit"><code><c- g>HeadersInit</c-></code></dfn>;

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="headers"><code><c- g>Headers</c-></code></dfn> {
  <a class="idl-code" data-link-type="constructor" href="#dom-headers" id="ref-for-dom-headers"><c- g>constructor</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#typedefdef-headersinit" id="ref-for-typedefdef-headersinit"><c- n>HeadersInit</c-></a> <dfn class="idl-code" data-dfn-for="Headers/Headers(init), Headers/constructor(init), Headers/Headers(), Headers/constructor()" data-dfn-type="argument" data-export id="dom-headers-headers-init-init"><code><c- g>init</c-></code><a class="self-link" href="#dom-headers-headers-init-init"></a></dfn>);

  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-headers-append" id="ref-for-dom-headers-append"><c- g>append</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString③"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/append(name, value)" data-dfn-type="argument" data-export id="dom-headers-append-name-value-name"><code><c- g>name</c-></code><a class="self-link" href="#dom-headers-append-name-value-name"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString④"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/append(name, value)" data-dfn-type="argument" data-export id="dom-headers-append-name-value-value"><code><c- g>value</c-></code><a class="self-link" href="#dom-headers-append-name-value-value"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-headers-delete" id="ref-for-dom-headers-delete"><c- g>delete</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString⑤"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/delete(name)" data-dfn-type="argument" data-export id="dom-headers-delete-name-name"><code><c- g>name</c-></code><a class="self-link" href="#dom-headers-delete-name-name"></a></dfn>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString⑥"><c- b>ByteString</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-headers-get" id="ref-for-dom-headers-get"><c- g>get</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString⑦"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/get(name)" data-dfn-type="argument" data-export id="dom-headers-get-name-name"><code><c- g>name</c-></code><a class="self-link" href="#dom-headers-get-name-name"></a></dfn>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="method" href="#dom-headers-has" id="ref-for-dom-headers-has"><c- g>has</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString⑧"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/has(name)" data-dfn-type="argument" data-export id="dom-headers-has-name-name"><code><c- g>name</c-></code><a class="self-link" href="#dom-headers-has-name-name"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-headers-set" id="ref-for-dom-headers-set"><c- g>set</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString⑨"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/set(name, value)" data-dfn-type="argument" data-export id="dom-headers-set-name-value-name"><code><c- g>name</c-></code><a class="self-link" href="#dom-headers-set-name-value-name"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①⓪"><c- b>ByteString</c-></a> <dfn class="idl-code" data-dfn-for="Headers/set(name, value)" data-dfn-type="argument" data-export id="dom-headers-set-name-value-value"><code><c- g>value</c-></code><a class="self-link" href="#dom-headers-set-name-value-value"></a></dfn>);
  <c- b>iterable</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①①"><c- b>ByteString</c-></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①②"><c- b>ByteString</c-></a>>;
};
</pre>
   <p class="note" role="note">Unlike a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list①⑨">header list</a>, a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers">Headers</a></code> object cannot represent more than one
`<code>Set-Cookie</code>` <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥⑤">header</a>. In a way this is problematic as unlike all other
headers `<code>Set-Cookie</code>` headers cannot be combined, but since `<code>Set-Cookie</code>`
headers are not exposed to client-side JavaScript this is deemed an acceptable compromise.
Implementations could chose the more efficient <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①">Headers</a></code> object representation even for a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list②⓪">header list</a>, as long as they also support an associated data structure for
`<code>Set-Cookie</code>` headers. </p>
   <div class="example" id="example-headers-class">
    <a class="self-link" href="#example-headers-class"></a> 
    <p>A <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers②">Headers</a></code> object can be initialized with various JavaScript data structures: </p>
<pre><code class="lang-javascript highlight"><c- a>var</c-> meta <c- o>=</c-> <c- p>{</c-> <c- u>"Content-Type"</c-><c- o>:</c-> <c- u>"text/xml"</c-><c- p>,</c-> <c- u>"Breaking-Bad"</c-><c- o>:</c-> <c- u>"&lt;3"</c-> <c- p>}</c->
<c- k>new</c-> Headers<c- p>(</c->meta<c- p>)</c->

<c- c1>// The above is equivalent to</c->
<c- a>var</c-> meta <c- o>=</c-> <c- p>[</c->
  <c- p>[</c-> <c- u>"Content-Type"</c-><c- p>,</c-> <c- u>"text/xml"</c-> <c- p>],</c->
  <c- p>[</c-> <c- u>"Breaking-Bad"</c-><c- p>,</c-> <c- u>"&lt;3"</c-> <c- p>]</c->
<c- p>]</c->
<c- k>new</c-> Headers<c- p>(</c->meta<c- p>)</c->
</code></pre>
   </div>
   <p>A <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers③">Headers</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-for="Headers" data-dfn-type="dfn" data-export id="concept-headers-header-list">header list</dfn> (a <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list②①">header list</a>), which is initially empty. <span class="note">This
can be a pointer to the <a data-link-type="dfn" href="#concept-header-list" id="ref-for-concept-header-list②②">header list</a> of something else, e.g.,
of a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪⓪">request</a> as demonstrated by <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request">Request</a></code> objects.</span> </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers④">Headers</a></code> object also has an associated <dfn class="dfn-paneled" data-dfn-for="Headers" data-dfn-type="dfn" data-export id="concept-headers-guard">guard</dfn>, which is
"<code>immutable</code>",
"<code>request</code>",
"<code>request-no-cors</code>",
"<code>response</code>" or
"<code>none</code>". </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="Headers" data-dfn-type="dfn" data-export id="concept-headers-append">append</dfn> a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤②">name</a>/<a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③⑤">value</a> <var>name</var>/<var>value</var> pair to a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers⑤">Headers</a></code> object (<var>headers</var>), run these steps: </p>
   <ol>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-value-normalize" id="ref-for-concept-header-value-normalize">Normalize</a> <var>value</var>. </p>
    <li>
     <p>If <var>name</var> is not a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤③">name</a> or <var>value</var> is not a <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③⑥">value</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②">TypeError</a></code>. </p>
    <li>
     <p>If <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard">guard</a> is "<code>immutable</code>", then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror③">TypeError</a></code>. </p>
    <li>
     <p>Otherwise, if <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①">guard</a> is "<code>request</code>" and <var>name</var> is a <a data-link-type="dfn" href="#forbidden-header-name" id="ref-for-forbidden-header-name①">forbidden header name</a>, return. </p>
    <li>
     <p>Otherwise, if <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②">guard</a> is "<code>request-no-cors</code>": </p>
     <ol>
      <li>
       <p>Let <var>temporaryValue</var> be the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get⑥">getting</a> <var>name</var> from <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list">header list</a>. </p>
      <li>
       <p>If <var>temporaryValue</var> is null, then set <var>temporaryValue</var> to <var>value</var>. </p>
      <li>
       <p>Otherwise, set <var>temporaryValue</var> to <var>temporaryValue</var>, followed by
   0x2C 0x20, followed by <var>value</var>. </p>
      <li>
       <p>If <var>name</var>/<var>temporaryValue</var> is not a <a data-link-type="dfn" href="#no-cors-safelisted-request-header" id="ref-for-no-cors-safelisted-request-header">no-CORS-safelisted request-header</a>, then return. </p>
     </ol>
    <li>
     <p>Otherwise, if <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard③">guard</a> is "<code>response</code>" and <var>name</var> is a <a data-link-type="dfn" href="#forbidden-response-header-name" id="ref-for-forbidden-response-header-name②">forbidden response-header name</a>, return. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②③">Append</a> <var>name</var>/<var>value</var> to <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①">header list</a>. </p>
    <li>
     <p>If <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard④">guard</a> is "<code>request-no-cors</code>", then <a data-link-type="dfn" href="#concept-headers-remove-privileged-no-cors-request-headers" id="ref-for-concept-headers-remove-privileged-no-cors-request-headers">remove privileged no-CORS request headers</a> from <var>headers</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="Headers" data-dfn-type="dfn" data-export id="concept-headers-fill">fill</dfn> a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers⑥">Headers</a></code> object (<var>headers</var>) with a given object (<var>object</var>),
run these steps: </p>
   <ol>
    <li>
     <p>If <var>object</var> is a <a data-link-type="dfn" href="https://heycam.github.io/webidl/#idl-sequence" id="ref-for-idl-sequence">sequence</a>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate⑧">for each</a> <var>header</var> in <var>object</var>: </p>
     <ol>
      <li>
       <p>If <var>header</var> does not contain exactly two items, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror④">TypeError</a></code>. </p>
      <li>
       <p><a data-link-type="dfn" href="#concept-headers-append" id="ref-for-concept-headers-append">Append</a> <var>header</var>’s first item/<var>header</var>’s
   second item to <var>headers</var>. </p>
     </ol>
    <li>
     <p>Otherwise, <var>object</var> is a <a data-link-type="dfn" href="https://heycam.github.io/webidl/#idl-record" id="ref-for-idl-record">record</a>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-iterate" id="ref-for-map-iterate">for each</a> <var>key</var> → <var>value</var> in <var>object</var>, <a data-link-type="dfn" href="#concept-headers-append" id="ref-for-concept-headers-append①">append</a> <var>key</var>/<var>value</var> to <var>headers</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-for="Headers" data-dfn-type="dfn" data-noexport id="concept-headers-remove-privileged-no-cors-request-headers">remove privileged no-CORS request headers</dfn> from a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers⑦">Headers</a></code> object (<var>headers</var>), run these steps: </p>
   <ol>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate⑨">For each</a> <var>headerName</var> of <a data-link-type="dfn" href="#privileged-no-cors-request-header-name" id="ref-for-privileged-no-cors-request-header-name">privileged no-CORS request-header names</a>: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="#concept-header-list-delete" id="ref-for-concept-header-list-delete①">Delete</a> <var>headerName</var> from <var>headers</var>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list②">header list</a>. </p>
     </ol>
   </ol>
   <p class="note" role="note">This is called when headers are modified by unprivileged code. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Headers" data-dfn-type="constructor" data-export data-lt="Headers(init)|constructor(init)|Headers()|constructor()" id="dom-headers"><code>Headers(<var>init</var>)</code></dfn> constructor, when invoked, must run these steps: </p>
   <ol>
    <li>
     <p>Let <var>headers</var> be a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers⑧">Headers</a></code> object whose <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard⑤">guard</a> is "<code>none</code>". </p>
    <li>
     <p>If <var>init</var> is given, then <a data-link-type="dfn" href="#concept-headers-fill" id="ref-for-concept-headers-fill">fill</a> <var>headers</var> with <var>init</var>. </p>
    <li>
     <p>Return <var>headers</var>. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Headers" data-dfn-type="method" data-export id="dom-headers-append"><code>append(<var>name</var>, <var>value</var>)</code></dfn> method, when invoked, must <a data-link-type="dfn" href="#concept-headers-append" id="ref-for-concept-headers-append②">append</a> <var>name</var>/<var>value</var> to the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object">context object</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Headers" data-dfn-type="method" data-export id="dom-headers-delete"><code>delete(<var>name</var>)</code></dfn> method, when invoked, must run these steps: </p>
   <ol>
    <li>
     <p>If <var>name</var> is not a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤④">name</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw③">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror⑤">TypeError</a></code>. </p>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard⑥">guard</a> is "<code>immutable</code>", then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw④">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror⑥">TypeError</a></code>. </p>
    <li>
     <p>Otherwise, if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard⑦">guard</a> is "<code>request</code>"
 and <var>name</var> is a <a data-link-type="dfn" href="#forbidden-header-name" id="ref-for-forbidden-header-name②">forbidden header name</a>, return. </p>
    <li>
     <p>Otherwise, if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard⑧">guard</a> is
 "<code>request-no-cors</code>", <var>name</var> is not a <a data-link-type="dfn" href="#no-cors-safelisted-request-header-name" id="ref-for-no-cors-safelisted-request-header-name①">no-CORS-safelisted request-header name</a>, and <var>name</var> is not a <a data-link-type="dfn" href="#privileged-no-cors-request-header-name" id="ref-for-privileged-no-cors-request-header-name①">privileged no-CORS request-header name</a>, return. </p>
    <li>
     <p>Otherwise, if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard⑨">guard</a> is
 "<code>response</code>" and <var>name</var> is a <a data-link-type="dfn" href="#forbidden-response-header-name" id="ref-for-forbidden-response-header-name③">forbidden response-header name</a>, return. </p>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑤">context object</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list③">header list</a> does not <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②②">contain</a> <var>name</var>, then return. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-delete" id="ref-for-concept-header-list-delete②">Delete</a> <var>name</var> from the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑥">context object</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list④">header list</a>. </p>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑦">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①⓪">guard</a> is "<code>request-no-cors</code>",
 then <a data-link-type="dfn" href="#concept-headers-remove-privileged-no-cors-request-headers" id="ref-for-concept-headers-remove-privileged-no-cors-request-headers①">remove privileged no-CORS request headers</a> from the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑧">context object</a>. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Headers" data-dfn-type="method" data-export id="dom-headers-get"><code>get(<var>name</var>)</code></dfn> method, when
invoked, must run these steps: </p>
   <ol>
    <li>
     <p>If <var>name</var> is not a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤⑤">name</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑤">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror⑦">TypeError</a></code>. </p>
    <li>
     <p>Return the result of <a data-link-type="dfn" href="#concept-header-list-get" id="ref-for-concept-header-list-get⑦">getting</a> <var>name</var> from the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑨">context object</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list⑤">header list</a>. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Headers" data-dfn-type="method" data-export id="dom-headers-has"><code>has(<var>name</var>)</code></dfn> method,
when invoked, must run these steps: </p>
   <ol>
    <li>
     <p>If <var>name</var> is not a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤⑥">name</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑥">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror⑧">TypeError</a></code>. </p>
    <li>
     <p>Return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①⓪">context object</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list⑥">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②③">contains</a> <var>name</var>, and false otherwise. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Headers" data-dfn-type="method" data-export id="dom-headers-set"><code>set(<var>name</var>, <var>value</var>)</code></dfn> method, when invoked, must run these steps: </p>
   <ol>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-value-normalize" id="ref-for-concept-header-value-normalize①">Normalize</a> <var>value</var>. </p>
    <li>
     <p>If <var>name</var> is not a <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤⑦">name</a> or <var>value</var> is not a <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③⑦">value</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑦">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror⑨">TypeError</a></code>. </p>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①①">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①①">guard</a> is "<code>immutable</code>", then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑧">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①⓪">TypeError</a></code>. </p>
    <li>
     <p>Otherwise, if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①②">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①②">guard</a> is "<code>request</code>"
 and <var>name</var> is a <a data-link-type="dfn" href="#forbidden-header-name" id="ref-for-forbidden-header-name③">forbidden header name</a>, return. </p>
    <li>
     <p>Otherwise, if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①③">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①③">guard</a> is
 "<code>request-no-cors</code>" and <var>name</var>/<var>value</var> is not a <a data-link-type="dfn" href="#no-cors-safelisted-request-header" id="ref-for-no-cors-safelisted-request-header①">no-CORS-safelisted request-header</a>, return. </p>
    <li>
     <p>Otherwise, if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①④">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①④">guard</a> is
 "<code>response</code>" and <var>name</var> is a <a data-link-type="dfn" href="#forbidden-response-header-name" id="ref-for-forbidden-response-header-name④">forbidden response-header name</a>, return. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-set" id="ref-for-concept-header-list-set①">Set</a> <var>name</var>/<var>value</var> in the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①⑤">context object</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list⑦">header list</a>. </p>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①⑥">context object</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①⑤">guard</a> is "<code>request-no-cors</code>",
 then <a data-link-type="dfn" href="#concept-headers-remove-privileged-no-cors-request-headers" id="ref-for-concept-headers-remove-privileged-no-cors-request-headers②">remove privileged no-CORS request headers</a> from the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①⑦">context object</a>. </p>
   </ol>
   <p>The <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-value-pairs-to-iterate-over" id="ref-for-dfn-value-pairs-to-iterate-over">value pairs to iterate over</a> are the return value of running <a data-link-type="dfn" href="#concept-header-list-sort-and-combine" id="ref-for-concept-header-list-sort-and-combine">sort and combine</a> with the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①⑧">context object</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list⑧">header list</a>. </p>
   <h3 class="heading settled" data-level="5.2" id="body-mixin"><span class="secno">5.2. </span><span class="content">Body mixin</span><a class="self-link" href="#body-mixin"></a></h3>
<pre class="idl highlight def"><c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="https://w3c.github.io/FileAPI/#dfn-Blob" id="ref-for-dfn-Blob②"><c- n>Blob</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://heycam.github.io/webidl/#BufferSource" id="ref-for-BufferSource"><c- n>BufferSource</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://xhr.spec.whatwg.org/#formdata" id="ref-for-formdata"><c- n>FormData</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://url.spec.whatwg.org/#urlsearchparams" id="ref-for-urlsearchparams"><c- n>URLSearchParams</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="#concept-readablestream" id="ref-for-concept-readablestream②②"><c- n>ReadableStream</c-></a> <c- b>or</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString"><c- b>USVString</c-></a>) <dfn class="dfn-paneled idl-code" data-dfn-type="typedef" data-export id="bodyinit"><code><c- g>BodyInit</c-></code></dfn>;</pre>
   <p>To <dfn class="dfn-paneled" data-dfn-for="BodyInit" data-dfn-type="dfn" data-export id="bodyinit-safely-extract">safely extract</dfn> a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body⑧">body</a> and a
`<code>Content-Type</code>` <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③⑧">value</a> from <var>object</var>, run these steps: </p>
   <ol>
    <li>
     <p>If <var>object</var> is a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②③">ReadableStream</a></code> object, then: </p>
     <ol>
      <li>
       <p>Assert: <var>object</var> is neither <a data-link-type="dfn" href="#concept-readablestream-disturbed" id="ref-for-concept-readablestream-disturbed">disturbed</a> nor <a data-link-type="dfn" href="#concept-readablestream-locked" id="ref-for-concept-readablestream-locked">locked</a>. </p>
     </ol>
    <li>
     <p>Return the results of <a data-link-type="dfn" href="#concept-bodyinit-extract" id="ref-for-concept-bodyinit-extract">extracting</a> <var>object</var>. </p>
   </ol>
   <p class="note no-backref" role="note">The <a data-link-type="dfn" href="#bodyinit-safely-extract" id="ref-for-bodyinit-safely-extract②">safely extract</a> operation is a subset of the <a data-link-type="dfn" href="#concept-bodyinit-extract" id="ref-for-concept-bodyinit-extract①">extract</a> operation that is guaranteed to not throw an exception. </p>
   <p>To <dfn class="dfn-paneled" data-dfn-for="BodyInit" data-dfn-type="dfn" data-export id="concept-bodyinit-extract">extract</dfn> a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body⑨">body</a> and a
`<code>Content-Type</code>` <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value③⑨">value</a> from <var>object</var>, with an optional <var>keepalive flag</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>stream</var> be the result of <a data-link-type="dfn" href="#concept-construct-readablestream" id="ref-for-concept-construct-readablestream②">constructing</a> a <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②④">ReadableStream</a></code> object. </p>
    <li>
     <p>Let <var>Content-Type</var> be null. </p>
    <li>
     <p>Let <var>action</var> be null. </p>
    <li>
     <p>Let <var>source</var> be null. </p>
    <li>
     <p>Switch on <var>object</var>’s type: </p>
     <dl class="switch">
      <dt><code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-Blob" id="ref-for-dfn-Blob③">Blob</a></code> 
      <dd>
       <p>Set <var>action</var> to an action that reads <var>object</var>. </p>
       <p>If <var>object</var>’s <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-type" id="ref-for-dfn-type①">type</a></code> attribute is not the empty byte sequence, set <var>Content-Type</var> to its value. </p>
       <p>Set <var>source</var> to <var>object</var>. </p>
      <dt><code>BufferSource</code> 
      <dd>
       <p><a data-link-type="dfn" href="#concept-enqueue-readablestream" id="ref-for-concept-enqueue-readablestream②">Enqueue</a> a <code>Uint8Array</code> object
    wrapping an <code>ArrayBuffer</code> containing a copy of the bytes held by <var>object</var> to <var>stream</var> and <a data-link-type="abstract-op" href="#concept-close-readablestream" id="ref-for-concept-close-readablestream②">close</a> <var>stream</var>. If that threw an exception, <a data-link-type="abstract-op" href="#concept-error-readablestream" id="ref-for-concept-error-readablestream③">error</a> <var>stream</var> with that exception. </p>
       <p>Set <var>source</var> to <var>object</var>. </p>
      <dt><code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#formdata" id="ref-for-formdata①">FormData</a></code> 
      <dd>
       <p>Set <var>action</var> to an action that runs the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-encoding-algorithm" id="ref-for-multipart/form-data-encoding-algorithm"><code>multipart/form-data</code> encoding algorithm</a>, with <var>object</var> as <var>form data set</var> and with <a data-link-type="dfn" href="https://encoding.spec.whatwg.org/#utf-8" id="ref-for-utf-8">UTF-8</a> as the explicit character encoding. </p>
       <p>Set <var>Content-Type</var> to `<code>multipart/form-data; boundary=</code>`, followed by the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-boundary-string" id="ref-for-multipart/form-data-boundary-string"><code>multipart/form-data</code> boundary string</a> generated by the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-encoding-algorithm" id="ref-for-multipart/form-data-encoding-algorithm①"><code>multipart/form-data</code> encoding algorithm</a>. </p>
       <p>Set <var>source</var> to <var>object</var>. </p>
      <dt><code class="idl"><a data-link-type="idl" href="https://url.spec.whatwg.org/#urlsearchparams" id="ref-for-urlsearchparams①">URLSearchParams</a></code> 
      <dd>
       <p>Set <var>action</var> to an action that runs the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-urlencoded-serializer" id="ref-for-concept-urlencoded-serializer"><code>application/x-www-form-urlencoded</code> serializer</a> with <var>object</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-urlsearchparams-list" id="ref-for-concept-urlsearchparams-list">list</a>. </p>
       <p>Set <var>Content-Type</var> to
    `<code>application/x-www-form-urlencoded;charset=UTF-8</code>`. </p>
       <p>Set <var>source</var> to <var>object</var>. </p>
      <dt><code>USVString</code> 
      <dd>
       <p>Set <var>action</var> to an action that runs <a data-link-type="dfn" href="https://encoding.spec.whatwg.org/#utf-8-encode" id="ref-for-utf-8-encode">UTF-8 encode</a> on <var>object</var>. </p>
       <p>Set <var>Content-Type</var> to `<code>text/plain;charset=UTF-8</code>`. </p>
       <p>Set <var>source</var> to <var>object</var>. </p>
      <dt><code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②⑤">ReadableStream</a></code> 
      <dd>
       <p>If the <var>keepalive flag</var> is set, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑨">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①①">TypeError</a></code>. </p>
       <p>If <var>object</var> is <a data-link-type="dfn" href="#concept-readablestream-disturbed" id="ref-for-concept-readablestream-disturbed①">disturbed</a> or <a data-link-type="dfn" href="#concept-readablestream-locked" id="ref-for-concept-readablestream-locked①">locked</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⓪">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①②">TypeError</a></code>. </p>
       <p>Set <var>stream</var> to <var>object</var>. </p>
     </dl>
    <li>
     <p>If <var>action</var> is non-null, run <var>action</var> <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel⑥">in parallel</a>: </p>
     <ol>
      <li>
       <p>Whenever one or more bytes are available, let <var>bytes</var> be the bytes and <a data-link-type="dfn" href="#concept-enqueue-readablestream" id="ref-for-concept-enqueue-readablestream③">enqueue</a> a <code>Uint8Array</code> object
   wrapping an <code>ArrayBuffer</code> containing <var>bytes</var> to <var>stream</var>. If
   creating the <code>ArrayBuffer</code> threw an exception, <a data-link-type="abstract-op" href="#concept-error-readablestream" id="ref-for-concept-error-readablestream④">error</a> <var>stream</var> with that exception
   and cancel running <var>action</var>. </p>
      <li>
       <p>When running <var>action</var> is done, <a data-link-type="abstract-op" href="#concept-close-readablestream" id="ref-for-concept-close-readablestream③">close</a> <var>stream</var>. </p>
     </ol>
    <li>
     <p>Let <var>body</var> be a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body①⓪">body</a> whose <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①③">stream</a> is <var>stream</var> and whose <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source①⓪">source</a> is <var>source</var>. </p>
    <li>
     <p>Return <var>body</var> and <var>Content-Type</var>. </p>
   </ol>
<pre class="idl highlight def"><c- b>interface</c-> <c- b>mixin</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="body"><code><c- g>Body</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#concept-readablestream" id="ref-for-concept-readablestream②⑥"><c- n>ReadableStream</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="ReadableStream?" href="#dom-body-body" id="ref-for-dom-body-body"><c- g>body</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-body-bodyused" id="ref-for-dom-body-bodyused"><c- g>bodyUsed</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ArrayBuffer" id="ref-for-idl-ArrayBuffer"><c- b>ArrayBuffer</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-arraybuffer" id="ref-for-dom-body-arraybuffer"><c- g>arrayBuffer</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject①"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="https://w3c.github.io/FileAPI/#dfn-Blob" id="ref-for-dfn-Blob④"><c- n>Blob</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-blob" id="ref-for-dom-body-blob"><c- g>blob</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject②"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="https://xhr.spec.whatwg.org/#formdata" id="ref-for-formdata②"><c- n>FormData</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-formdata" id="ref-for-dom-body-formdata"><c- g>formData</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject③"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<c- b>any</c->> <a class="idl-code" data-link-type="method" href="#dom-body-json" id="ref-for-dom-body-json"><c- g>json</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject④"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①"><c- b>USVString</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-text" id="ref-for-dom-body-text"><c- g>text</c-></a>();
};</pre>
   <p class="note" role="note">Formats you would not want a network layer to be dependent upon, such as
HTML, will likely not be exposed here. Rather, an HTML parser API might accept a stream in
due course. </p>
   <p>Objects implementing the <code class="idl"><a data-link-type="idl" href="#body" id="ref-for-body">Body</a></code> mixin gain an associated <dfn class="dfn-paneled" data-dfn-for="Body" data-dfn-type="dfn" data-noexport id="concept-body-body">body</dfn> (null or a <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body①①">body</a>) and
a <dfn class="dfn-paneled" data-dfn-for="Body" data-dfn-type="dfn" data-noexport id="concept-body-mime-type">MIME type</dfn> (failure or a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type" id="ref-for-mime-type④">MIME type</a>). </p>
   <p>An object implementing the <code class="idl"><a data-link-type="idl" href="#body" id="ref-for-body①">Body</a></code> mixin is said to be <dfn class="dfn-paneled" data-dfn-for="Body" data-dfn-type="dfn" data-export id="concept-body-disturbed">disturbed</dfn> if <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body">body</a> is
non-null and its <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①④">stream</a> is <a data-link-type="dfn" href="#concept-readablestream-disturbed" id="ref-for-concept-readablestream-disturbed②">disturbed</a>. </p>
   <p>An object implementing the <code class="idl"><a data-link-type="idl" href="#body" id="ref-for-body②">Body</a></code> mixin is said to be <dfn class="dfn-paneled" data-dfn-for="Body" data-dfn-type="dfn" data-export id="concept-body-locked">locked</dfn> if <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body①">body</a> is
non-null and its <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①⑤">stream</a> is <a data-link-type="dfn" href="#concept-readablestream-locked" id="ref-for-concept-readablestream-locked②">locked</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="attribute" data-export id="dom-body-body"><code>body</code></dfn> attribute’s getter must return null if <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body②">body</a> is null and <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body③">body</a>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①⑥">stream</a> otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="attribute" data-export id="dom-body-bodyused"><code>bodyUsed</code></dfn> attribute’s getter must
return true if <a data-link-type="dfn" href="#concept-body-disturbed" id="ref-for-concept-body-disturbed">disturbed</a>, and false otherwise. </p>
   <p>Objects implementing the <code class="idl"><a data-link-type="idl" href="#body" id="ref-for-body③">Body</a></code> mixin also have an associated <dfn class="dfn-paneled" data-dfn-for="Body" data-dfn-type="dfn" data-noexport id="concept-body-package-data">package data</dfn> algorithm, given <var>bytes</var>, a <var>type</var> and a <var>mimeType</var>, switches on <var>type</var>, and
runs the associated steps: </p>
   <dl class="switch">
    <dt><i>ArrayBuffer</i> 
    <dd>
     <p>Return a new <code>ArrayBuffer</code> whose contents are <var>bytes</var>. </p>
     <p class="note" role="note">Allocating an <code>ArrayBuffer</code> can throw a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-rangeerror" id="ref-for-exceptiondef-rangeerror">RangeError</a></code>. </p>
    <dt><i>Blob</i> 
    <dd>
     <p>Return a <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-Blob" id="ref-for-dfn-Blob⑤">Blob</a></code> whose contents are <var>bytes</var> and <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-type" id="ref-for-dfn-type②">type</a></code> attribute is <var>mimeType</var>. </p>
    <dt><i>FormData</i> 
    <dd>
     <p>If <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence⑨">essence</a> is "<code>multipart/form-data</code>",
  then: </p>
     <ol>
      <li>
       <p>Parse <var>bytes</var>, using the value of the `<code>boundary</code>` parameter from <var>mimeType</var>, per the rules set forth in <cite>Returning Values from Forms: multipart/form-data</cite>. <a data-link-type="biblio" href="#biblio-rfc7578">[RFC7578]</a></p>
       <p>Each part whose `<code>Content-Disposition</code>` header contains a `<code>filename</code>`
    parameter must be parsed into an <a data-link-type="dfn" href="https://xhr.spec.whatwg.org/#concept-formdata-entry" id="ref-for-concept-formdata-entry">entry</a> whose value is a <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-file" id="ref-for-dfn-file">File</a></code> object
    whose contents are the contents of the part. The <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-name" id="ref-for-dfn-name">name</a></code> attribute of the <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-file" id="ref-for-dfn-file①">File</a></code> object
    must have the value of the `<code>filename</code>` parameter of the part. The <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-type" id="ref-for-dfn-type③">type</a></code> attribute of the <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/FileAPI/#dfn-file" id="ref-for-dfn-file②">File</a></code> object must have the value of the `<code>Content-Type</code>` header
    of the part if the part has such header, and `<code>text/plain</code>` (the default defined by <a data-link-type="biblio" href="#biblio-rfc7578">[RFC7578]</a> section 4.4) otherwise.</p>
       <p>Each part whose `<code>Content-Disposition</code>` header does not contain a
    `<code>filename</code>` parameter must be parsed into an <a data-link-type="dfn" href="https://xhr.spec.whatwg.org/#concept-formdata-entry" id="ref-for-concept-formdata-entry①">entry</a> whose value
    is the <a data-link-type="dfn" href="https://encoding.spec.whatwg.org/#utf-8-decode-without-bom" id="ref-for-utf-8-decode-without-bom">UTF-8 decoded without BOM</a> content of the part. <span class="note">This is done regardless of the presence or the value of a
    `<code>Content-Type</code>` header and regardless of the presence or the value of a
    `<code>charset</code>` parameter.</span></p>
       <p class="note" role="note">A part whose `<code>Content-Disposition</code>` header contains a
    `<code>name</code>` parameter whose value is `<code>_charset_</code>` is parsed like any other
    part. It does not change the encoding.</p>
      <li>
       <p>If that fails for some reason, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①①">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①③">TypeError</a></code>. </p>
      <li>
       <p>Return a new <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#formdata" id="ref-for-formdata③">FormData</a></code> object, appending each <a data-link-type="dfn" href="https://xhr.spec.whatwg.org/#concept-formdata-entry" id="ref-for-concept-formdata-entry②">entry</a>, resulting from
   the parsing operation, to <a data-link-type="dfn" href="https://xhr.spec.whatwg.org/#concept-formdata-entry" id="ref-for-concept-formdata-entry③">entries</a>. </p>
     </ol>
     <p class="XXX">The above is a rough approximation of what is needed for
  `<code>multipart/form-data</code>`, a more detailed parsing specification is to be
  written. Volunteers welcome. </p>
     <p>Otherwise, if <var>mimeType</var>’s <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type-essence" id="ref-for-mime-type-essence①⓪">essence</a> is
  "<code>application/x-www-form-urlencoded</code>", then: </p>
     <ol>
      <li>
       <p>Let <var>entries</var> be the result of <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-urlencoded-parser" id="ref-for-concept-urlencoded-parser">parsing</a> <var>bytes</var>. </p>
      <li>
       <p>If <var>entries</var> is failure, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①②">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①④">TypeError</a></code>. </p>
      <li>
       <p>Return a new <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#formdata" id="ref-for-formdata④">FormData</a></code> object whose <a data-link-type="dfn" href="https://xhr.spec.whatwg.org/#concept-formdata-entry" id="ref-for-concept-formdata-entry④">entries</a> are <var>entries</var>. </p>
     </ol>
     <p>Otherwise, <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①③">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①⑤">TypeError</a></code>. </p>
    <dt><i>JSON</i> 
    <dd>
     <p>Return the result of running <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#parse-json-from-bytes" id="ref-for-parse-json-from-bytes">parse JSON from bytes</a> on <var>bytes</var>. </p>
    <dt><i>text</i> 
    <dd>
     <p>Return the result of running <a data-link-type="dfn" href="https://encoding.spec.whatwg.org/#utf-8-decode" id="ref-for-utf-8-decode">UTF-8 decode</a> on <var>bytes</var>. </p>
   </dl>
   <p>Objects implementing the <code class="idl"><a data-link-type="idl" href="#body" id="ref-for-body④">Body</a></code> mixin also have an associated <dfn class="dfn-paneled" data-dfn-for="Body" data-dfn-type="dfn" data-noexport id="concept-body-consume-body">consume body</dfn> algorithm, given a <var>type</var>,
runs these steps: </p>
   <ol>
    <li>
     <p>If this object is <a data-link-type="dfn" href="#concept-body-disturbed" id="ref-for-concept-body-disturbed①">disturbed</a> or <a data-link-type="dfn" href="#concept-body-locked" id="ref-for-concept-body-locked">locked</a>, return a new promise
 rejected with a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①⑥">TypeError</a></code>. </p>
    <li>
     <p>Let <var>stream</var> be <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body④">body</a>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①⑦">stream</a> if <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body⑤">body</a> is
 non-null, or an <a data-link-type="dfn" href="#concept-empty-readablestream" id="ref-for-concept-empty-readablestream①">empty</a> <code class="idl"><a data-link-type="idl" href="#concept-readablestream" id="ref-for-concept-readablestream②⑦">ReadableStream</a></code> object otherwise. </p>
    <li>
     <p>Let <var>reader</var> be the result of <a data-link-type="dfn" href="#concept-get-reader" id="ref-for-concept-get-reader①">getting
 a reader</a> from <var>stream</var>. If that threw an exception, return a new promise rejected
 with that exception. </p>
    <li>
     <p>Let <var>promise</var> be the result of <a data-link-type="dfn" href="#concept-read-all-bytes-from-readablestream" id="ref-for-concept-read-all-bytes-from-readablestream">reading all bytes</a> from <var>stream</var> with <var>reader</var>. </p>
    <li>
     <p>Return the result of transforming <var>promise</var> by a fulfillment handler that
 returns the result of the <a data-link-type="dfn" href="#concept-body-package-data" id="ref-for-concept-body-package-data">package data</a> algorithm
 with its first argument, <var>type</var> and this object’s <a data-link-type="dfn" href="#concept-body-mime-type" id="ref-for-concept-body-mime-type">MIME type</a>. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="method" data-export id="dom-body-arraybuffer"><code>arrayBuffer()</code></dfn> method, when invoked, must return the result of running <a data-link-type="dfn" href="#concept-body-consume-body" id="ref-for-concept-body-consume-body">consume body</a> with <i>ArrayBuffer</i>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="method" data-export id="dom-body-blob"><code>blob()</code></dfn> method, when
invoked, must return the result of running <a data-link-type="dfn" href="#concept-body-consume-body" id="ref-for-concept-body-consume-body①">consume body</a> with <i>Blob</i>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="method" data-export id="dom-body-formdata"><code>formData()</code></dfn> method,
when invoked, must return the result of running <a data-link-type="dfn" href="#concept-body-consume-body" id="ref-for-concept-body-consume-body②">consume body</a> with <i>FormData</i>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="method" data-export id="dom-body-json"><code>json()</code></dfn> method, when
invoked, must return the result of running <a data-link-type="dfn" href="#concept-body-consume-body" id="ref-for-concept-body-consume-body③">consume body</a> with <i>JSON</i>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Body" data-dfn-type="method" data-export id="dom-body-text"><code>text()</code></dfn> method, when
invoked, must return the result of running <a data-link-type="dfn" href="#concept-body-consume-body" id="ref-for-concept-body-consume-body④">consume body</a> with <i>text</i>. </p>
   <h3 class="heading settled" data-level="5.3" id="request-class"><span class="secno">5.3. </span><span class="content">Request class</span><a class="self-link" href="#request-class"></a></h3>
<pre class="idl highlight def"><c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="#request" id="ref-for-request①"><c- n>Request</c-></a> <c- b>or</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString②"><c- b>USVString</c-></a>) <dfn class="dfn-paneled idl-code" data-dfn-type="typedef" data-export id="requestinfo"><code><c- g>RequestInfo</c-></code></dfn>;

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="request"><code><c- g>Request</c-></code></dfn> {
  <a class="idl-code" data-link-type="constructor" href="#dom-request" id="ref-for-dom-request"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="#requestinfo" id="ref-for-requestinfo"><c- n>RequestInfo</c-></a> <dfn class="idl-code" data-dfn-for="Request/Request(input, init), Request/constructor(input, init), Request/Request(input), Request/constructor(input)" data-dfn-type="argument" data-export id="dom-request-request-input-init-input"><code><c- g>input</c-></code><a class="self-link" href="#dom-request-request-input-init-input"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#requestinit" id="ref-for-requestinit"><c- n>RequestInit</c-></a> <dfn class="idl-code" data-dfn-for="Request/Request(input, init), Request/constructor(input, init), Request/Request(input), Request/constructor(input)" data-dfn-type="argument" data-export id="dom-request-request-input-init-init"><code><c- g>init</c-></code><a class="self-link" href="#dom-request-request-input-init-init"></a></dfn> = {});

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①③"><c- b>ByteString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ByteString" href="#dom-request-method" id="ref-for-dom-request-method"><c- g>method</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString③"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-request-url" id="ref-for-dom-request-url"><c- g>url</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#headers" id="ref-for-headers⑨"><c- n>Headers</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Headers" href="#dom-request-headers" id="ref-for-dom-request-headers"><c- g>headers</c-></a>;

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestdestination" id="ref-for-requestdestination"><c- n>RequestDestination</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestDestination" href="#dom-request-destination" id="ref-for-dom-request-destination"><c- g>destination</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString④"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-request-referrer" id="ref-for-dom-request-referrer"><c- g>referrer</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://w3c.github.io/webappsec-referrer-policy/#enumdef-referrerpolicy" id="ref-for-enumdef-referrerpolicy"><c- n>ReferrerPolicy</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ReferrerPolicy" href="#dom-request-referrerpolicy" id="ref-for-dom-request-referrerpolicy"><c- g>referrerPolicy</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestmode" id="ref-for-requestmode"><c- n>RequestMode</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestMode" href="#dom-request-mode" id="ref-for-dom-request-mode"><c- g>mode</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestcredentials" id="ref-for-requestcredentials"><c- n>RequestCredentials</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestCredentials" href="#dom-request-credentials" id="ref-for-dom-request-credentials"><c- g>credentials</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestcache" id="ref-for-requestcache"><c- n>RequestCache</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestCache" href="#dom-request-cache" id="ref-for-dom-request-cache"><c- g>cache</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestredirect" id="ref-for-requestredirect"><c- n>RequestRedirect</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestRedirect" href="#dom-request-redirect" id="ref-for-dom-request-redirect"><c- g>redirect</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString" href="#dom-request-integrity" id="ref-for-dom-request-integrity"><c- g>integrity</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean②"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-request-keepalive" id="ref-for-dom-request-keepalive"><c- g>keepalive</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean③"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-request-isreloadnavigation" id="ref-for-dom-request-isreloadnavigation"><c- g>isReloadNavigation</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean④"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-request-ishistorynavigation" id="ref-for-dom-request-ishistorynavigation"><c- g>isHistoryNavigation</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal"><c- n>AbortSignal</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="AbortSignal" href="#dom-request-signal" id="ref-for-dom-request-signal"><c- g>signal</c-></a>;

  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject⑤"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#request" id="ref-for-request②"><c- n>Request</c-></a> <a class="idl-code" data-link-type="method" href="#dom-request-clone" id="ref-for-dom-request-clone"><c- g>clone</c-></a>();
};
<a class="n" data-link-type="idl-name" href="#request" id="ref-for-request③"><c- n>Request</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#body" id="ref-for-body⑤"><c- n>Body</c-></a>;

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="requestinit"><code><c- g>RequestInit</c-></code></dfn> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①④"><c- b>ByteString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="ByteString " id="dom-requestinit-method"><code><c- g>method</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#typedefdef-headersinit" id="ref-for-typedefdef-headersinit①"><c- n>HeadersInit</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="HeadersInit " id="dom-requestinit-headers"><code><c- g>headers</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#bodyinit" id="ref-for-bodyinit"><c- n>BodyInit</c-></a>? <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="BodyInit? " id="dom-requestinit-body"><code><c- g>body</c-></code></dfn>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑤"><c- b>USVString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="USVString " id="dom-requestinit-referrer"><code><c- g>referrer</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="https://w3c.github.io/webappsec-referrer-policy/#enumdef-referrerpolicy" id="ref-for-enumdef-referrerpolicy①"><c- n>ReferrerPolicy</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="ReferrerPolicy " id="dom-requestinit-referrerpolicy"><code><c- g>referrerPolicy</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#requestmode" id="ref-for-requestmode①"><c- n>RequestMode</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="RequestMode " id="dom-requestinit-mode"><code><c- g>mode</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#requestcredentials" id="ref-for-requestcredentials①"><c- n>RequestCredentials</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="RequestCredentials " id="dom-requestinit-credentials"><code><c- g>credentials</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#requestcache" id="ref-for-requestcache①"><c- n>RequestCache</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="RequestCache " id="dom-requestinit-cache"><code><c- g>cache</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="#requestredirect" id="ref-for-requestredirect①"><c- n>RequestRedirect</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="RequestRedirect " id="dom-requestinit-redirect"><code><c- g>redirect</c-></code></dfn>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString①"><c- b>DOMString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="DOMString " id="dom-requestinit-integrity"><code><c- g>integrity</c-></code></dfn>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean⑤"><c- b>boolean</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="boolean " id="dom-requestinit-keepalive"><code><c- g>keepalive</c-></code></dfn>;
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal①"><c- n>AbortSignal</c-></a>? <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="AbortSignal? " id="dom-requestinit-signal"><code><c- g>signal</c-></code></dfn>;
  <c- b>any</c-> <dfn class="dfn-paneled idl-code" data-dfn-for="RequestInit" data-dfn-type="dict-member" data-export data-type="any " id="dom-requestinit-window"><code><c- g>window</c-></code></dfn>; // can only be set to null
};

<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="requestdestination"><code><c- g>RequestDestination</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination"><code><c- s>""</c-></code><a class="self-link" href="#dom-requestdestination"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-audio"><code><c- s>"audio"</c-></code><a class="self-link" href="#dom-requestdestination-audio"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-audioworklet"><code><c- s>"audioworklet"</c-></code><a class="self-link" href="#dom-requestdestination-audioworklet"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-document"><code><c- s>"document"</c-></code><a class="self-link" href="#dom-requestdestination-document"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-embed"><code><c- s>"embed"</c-></code><a class="self-link" href="#dom-requestdestination-embed"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-font"><code><c- s>"font"</c-></code><a class="self-link" href="#dom-requestdestination-font"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-image"><code><c- s>"image"</c-></code><a class="self-link" href="#dom-requestdestination-image"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-manifest"><code><c- s>"manifest"</c-></code><a class="self-link" href="#dom-requestdestination-manifest"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-object"><code><c- s>"object"</c-></code><a class="self-link" href="#dom-requestdestination-object"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-paintworklet"><code><c- s>"paintworklet"</c-></code><a class="self-link" href="#dom-requestdestination-paintworklet"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-report"><code><c- s>"report"</c-></code><a class="self-link" href="#dom-requestdestination-report"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-script"><code><c- s>"script"</c-></code><a class="self-link" href="#dom-requestdestination-script"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-sharedworker"><code><c- s>"sharedworker"</c-></code><a class="self-link" href="#dom-requestdestination-sharedworker"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-style"><code><c- s>"style"</c-></code><a class="self-link" href="#dom-requestdestination-style"></a></dfn>,  <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-track"><code><c- s>"track"</c-></code><a class="self-link" href="#dom-requestdestination-track"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-video"><code><c- s>"video"</c-></code><a class="self-link" href="#dom-requestdestination-video"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-worker"><code><c- s>"worker"</c-></code><a class="self-link" href="#dom-requestdestination-worker"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestDestination" data-dfn-type="enum-value" data-export id="dom-requestdestination-xslt"><code><c- s>"xslt"</c-></code><a class="self-link" href="#dom-requestdestination-xslt"></a></dfn> };
<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="requestmode"><code><c- g>RequestMode</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="RequestMode" data-dfn-type="enum-value" data-export id="dom-requestmode-navigate"><code><c- s>"navigate"</c-></code><a class="self-link" href="#dom-requestmode-navigate"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestMode" data-dfn-type="enum-value" data-export id="dom-requestmode-same-origin"><code><c- s>"same-origin"</c-></code><a class="self-link" href="#dom-requestmode-same-origin"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestMode" data-dfn-type="enum-value" data-export id="dom-requestmode-no-cors"><code><c- s>"no-cors"</c-></code><a class="self-link" href="#dom-requestmode-no-cors"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestMode" data-dfn-type="enum-value" data-export id="dom-requestmode-cors"><code><c- s>"cors"</c-></code><a class="self-link" href="#dom-requestmode-cors"></a></dfn> };
<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="requestcredentials"><code><c- g>RequestCredentials</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="RequestCredentials" data-dfn-type="enum-value" data-export id="dom-requestcredentials-omit"><code><c- s>"omit"</c-></code><a class="self-link" href="#dom-requestcredentials-omit"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCredentials" data-dfn-type="enum-value" data-export id="dom-requestcredentials-same-origin"><code><c- s>"same-origin"</c-></code><a class="self-link" href="#dom-requestcredentials-same-origin"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCredentials" data-dfn-type="enum-value" data-export id="dom-requestcredentials-include"><code><c- s>"include"</c-></code><a class="self-link" href="#dom-requestcredentials-include"></a></dfn> };
<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="requestcache"><code><c- g>RequestCache</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="RequestCache" data-dfn-type="enum-value" data-export id="dom-requestcache-default"><code><c- s>"default"</c-></code><a class="self-link" href="#dom-requestcache-default"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCache" data-dfn-type="enum-value" data-export id="dom-requestcache-no-store"><code><c- s>"no-store"</c-></code><a class="self-link" href="#dom-requestcache-no-store"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCache" data-dfn-type="enum-value" data-export id="dom-requestcache-reload"><code><c- s>"reload"</c-></code><a class="self-link" href="#dom-requestcache-reload"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCache" data-dfn-type="enum-value" data-export id="dom-requestcache-no-cache"><code><c- s>"no-cache"</c-></code><a class="self-link" href="#dom-requestcache-no-cache"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCache" data-dfn-type="enum-value" data-export id="dom-requestcache-force-cache"><code><c- s>"force-cache"</c-></code><a class="self-link" href="#dom-requestcache-force-cache"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestCache" data-dfn-type="enum-value" data-export id="dom-requestcache-only-if-cached"><code><c- s>"only-if-cached"</c-></code><a class="self-link" href="#dom-requestcache-only-if-cached"></a></dfn> };
<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="requestredirect"><code><c- g>RequestRedirect</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="RequestRedirect" data-dfn-type="enum-value" data-export id="dom-requestredirect-follow"><code><c- s>"follow"</c-></code><a class="self-link" href="#dom-requestredirect-follow"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestRedirect" data-dfn-type="enum-value" data-export id="dom-requestredirect-error"><code><c- s>"error"</c-></code><a class="self-link" href="#dom-requestredirect-error"></a></dfn>, <dfn class="idl-code" data-dfn-for="RequestRedirect" data-dfn-type="enum-value" data-export id="dom-requestredirect-manual"><code><c- s>"manual"</c-></code><a class="self-link" href="#dom-requestredirect-manual"></a></dfn> };
</pre>
   <p class="note no-backref" role="note">"<code>serviceworker</code>" is omitted from <a class="idl-code" data-link-type="enum" href="#requestdestination" id="ref-for-requestdestination①"><code>RequestDestination</code></a> as it cannot be observed from JavaScript. Implementations
will still need to support it as a <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①⑦">destination</a>. "<code>websocket</code>" is
omitted from <a class="idl-code" data-link-type="enum" href="#requestmode" id="ref-for-requestmode②"><code>RequestMode</code></a> as it cannot be used nor observed from JavaScript. </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request④">Request</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-for="Request" data-dfn-type="dfn" data-export id="concept-request-request">request</dfn> (a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪①">request</a>). </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request⑤">Request</a></code> object also has an associated <dfn class="dfn-paneled" data-dfn-for="Request" data-dfn-type="dfn" data-export id="request-headers">headers</dfn> (null or a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①⓪">Headers</a></code> object), initially null. </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request⑥">Request</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-for="Request" data-dfn-type="dfn" data-noexport id="request-signal">signal</dfn> (an <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal②">AbortSignal</a></code> object),
initially a new <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal③">AbortSignal</a></code> object. </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request⑦">Request</a></code> object’s <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body⑥">body</a> is its <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request">request</a>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③②">body</a>. </p>
   <dl class="domintro">
    <dt><code><var>request</var> = new <a class="idl-code" data-link-type="constructor" href="#dom-request" id="ref-for-dom-request①">Request</a>(<var>input</var> [, <var>init</var>])</code> 
    <dd>
     <p>Returns a new <var>request</var> whose <code class="idl"><a data-link-type="idl" href="#dom-request-url" id="ref-for-dom-request-url①">url</a></code> property is <var>input</var> if <var>input</var> is a string, and <var>input</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-url" id="ref-for-dom-request-url②">url</a></code> if <var>input</var> is a <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request⑧">Request</a></code> object. </p>
     <p>The <var>init</var> argument is an object whose properties can be set as follows:</p>
     <dl>
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-method" id="ref-for-dom-requestinit-method">method</a></code> 
      <dd>A string to set <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-method" id="ref-for-dom-request-method①">method</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-headers" id="ref-for-dom-requestinit-headers">headers</a></code> 
      <dd>A <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①①">Headers</a></code> object, an object literal, or an array of two-item arrays to set <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-headers" id="ref-for-dom-request-headers①">headers</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-body" id="ref-for-dom-requestinit-body">body</a></code> 
      <dd>A <code class="idl"><a data-link-type="idl" href="#bodyinit" id="ref-for-bodyinit①">BodyInit</a></code> object or null to set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③③">body</a>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-referrer" id="ref-for-dom-requestinit-referrer">referrer</a></code> 
      <dd>A string whose value is a same-origin URL, "<code>about:client</code>", or the empty string,
   to set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer⑧">referrer</a>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-referrerpolicy" id="ref-for-dom-requestinit-referrerpolicy">referrerPolicy</a></code> 
      <dd>A <a data-link-type="dfn" href="https://w3c.github.io/webappsec-referrer-policy/#referrer-policy" id="ref-for-referrer-policy①">referrer policy</a> to set <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-referrerpolicy" id="ref-for-dom-request-referrerpolicy①">referrerPolicy</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-mode" id="ref-for-dom-requestinit-mode">mode</a></code> 
      <dd>A string to indicate whether the request will use CORS, or will be restricted to same-origin
   URLs. Sets <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-mode" id="ref-for-dom-request-mode①">mode</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-credentials" id="ref-for-dom-requestinit-credentials">credentials</a></code> 
      <dd>A string indicating whether credentials will be sent with the request always, never, or only
   when sent to a same-origin URL. Sets <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-credentials" id="ref-for-dom-request-credentials①">credentials</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-cache" id="ref-for-dom-requestinit-cache">cache</a></code> 
      <dd>A string indicating how the request will interact with the browser’s cache to set <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-cache" id="ref-for-dom-request-cache①">cache</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-redirect" id="ref-for-dom-requestinit-redirect">redirect</a></code> 
      <dd>A string indicating whether <var>request</var> follows redirects, results in an error upon
   encountering a redirect, or returns the redirect (in an opaque fashion). Sets <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-redirect" id="ref-for-dom-request-redirect①">redirect</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-integrity" id="ref-for-dom-requestinit-integrity">integrity</a></code> 
      <dd>A cryptographic hash of the resource to be fetched by <var>request</var>. Sets <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-integrity" id="ref-for-dom-request-integrity①">integrity</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-keepalive" id="ref-for-dom-requestinit-keepalive">keepalive</a></code> 
      <dd>A boolean to set <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-keepalive" id="ref-for-dom-request-keepalive①">keepalive</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-signal" id="ref-for-dom-requestinit-signal">signal</a></code> 
      <dd>An <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal④">AbortSignal</a></code> to set <var>request</var>’s <code class="idl"><a data-link-type="idl" href="#dom-request-signal" id="ref-for-dom-request-signal①">signal</a></code>. 
      <dt><code class="idl"><a data-link-type="idl" href="#dom-requestinit-window" id="ref-for-dom-requestinit-window">window</a></code> 
      <dd>Can only be null. Used to disassociate <var>request</var> from any <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window②">Window</a></code>. 
     </dl>
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-method" id="ref-for-dom-request-method②">method</a></code> 
    <dd>Returns <var>request</var>’s HTTP method, which is "<code>GET</code>" by default. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-url" id="ref-for-dom-request-url③">url</a></code> 
    <dd>Returns the URL of <var>request</var> as a string. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-headers" id="ref-for-dom-request-headers②">headers</a></code> 
    <dd>Returns a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①②">Headers</a></code> object consisting of the headers associated with <var>request</var>.
 Note that headers added in the network layer by the user agent will not be accounted for in this
 object, e.g., the "<code>Host</code>" header. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-destination" id="ref-for-dom-request-destination①">destination</a></code> 
    <dd>Returns the kind of resource requested by <var>request</var>, e.g., "<code>document</code>" or
 "<code>script</code>". 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-referrer" id="ref-for-dom-request-referrer①">referrer</a></code> 
    <dd>Returns the referrer of <var>request</var>. Its value can be a same-origin URL if
 explicitly set in <var>init</var>, the empty string to indicate no referrer, and
 "<code>about:client</code>" when defaulting to the global’s default. This is used during
 fetching to determine the value of the `<code>Referer</code>` header of the request being made. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-referrerpolicy" id="ref-for-dom-request-referrerpolicy②">referrerPolicy</a></code> 
    <dd>Returns the referrer policy associated with <var>request</var>. This is used during
 fetching to compute the value of the <var>request</var>’s referrer. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-mode" id="ref-for-dom-request-mode②">mode</a></code> 
    <dd>Returns the <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①⑤">mode</a> associated with <var>request</var>, which is a string indicating
 whether the request will use CORS, or will be restricted to same-origin URLs. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-credentials" id="ref-for-dom-request-credentials②">credentials</a></code> 
    <dd>Returns the <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode①⑨">credentials mode</a> associated with <var>request</var>, which is a string
 indicating whether credentials will be sent with the request always, never, or only when sent to a
 same-origin URL. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-cache" id="ref-for-dom-request-cache②">cache</a></code> 
    <dd>Returns the <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①①">cache mode</a> associated with <var>request</var>, which is a string indicating
 how the request will interact with the browser’s cache when fetching. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-redirect" id="ref-for-dom-request-redirect②">redirect</a></code> 
    <dd>Returns the <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode⑧">redirect mode</a> associated with <var>request</var>, which is a string
 indicating how redirects for the request will be handled during fetching. A <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪②">request</a> will follow redirects by default. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-integrity" id="ref-for-dom-request-integrity②">integrity</a></code> 
    <dd>Returns <var>request</var>’s subresource integrity metadata, which is a cryptographic hash of
 the resource being fetched. Its value consists of multiple hashes separated by whitespace. <a data-link-type="biblio" href="#biblio-sri">[SRI]</a> 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-keepalive" id="ref-for-dom-request-keepalive②">keepalive</a></code> 
    <dd>Returns a boolean indicating whether or not <var>request</var> can outlive the global in which
 it was created. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-isreloadnavigation" id="ref-for-dom-request-isreloadnavigation①">isReloadNavigation</a></code> 
    <dd>Returns a boolean indicating whether or not <var>request</var> is for a reload navigation. 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-ishistorynavigation" id="ref-for-dom-request-ishistorynavigation①">isHistoryNavigation</a></code> 
    <dd>Returns a boolean indicating whether or not <var>request</var> is for a history
 navigation (a.k.a. back-foward navigation). 
    <dt><code><var>request</var> . <a class="idl-code" data-link-type="attribute" href="#dom-request-signal" id="ref-for-dom-request-signal②">signal</a></code> 
    <dd>Returns the signal associated with <var>request</var>, which is an <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#abortsignal" id="ref-for-abortsignal⑤">AbortSignal</a></code> object indicating whether or not <var>request</var> has been aborted, and its abort
 event handler. 
   </dl>
   <hr>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="constructor" data-export data-lt="Request(input, init)|constructor(input, init)|Request(input)|constructor(input)" id="dom-request"><code>Request(<var>input</var>, <var>init</var>)</code></dfn> constructor must run these steps: </p>
   <ol>
    <li>
     <p>Let <var>request</var> be null. </p>
    <li>
     <p>Let <var>fallbackMode</var> be null. </p>
    <li>
     <p>Let <var>fallbackCredentials</var> be null. </p>
    <li>
     <p>Let <var>baseURL</var> be <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object">current settings object</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#api-base-url" id="ref-for-api-base-url">API base URL</a>. </p>
    <li>
     <p>Let <var>signal</var> be null. </p>
    <li>
     <p>If <var>input</var> is a string, then: </p>
     <ol>
      <li>
       <p>Let <var>parsedURL</var> be the result of <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-parser" id="ref-for-concept-url-parser①">parsing</a> <var>input</var> with <var>baseURL</var>. </p>
      <li>
       <p>If <var>parsedURL</var> is failure, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①④">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①⑦">TypeError</a></code>. </p>
      <li>
       <p>If <var>parsedURL</var> <a data-link-type="dfn" href="https://url.spec.whatwg.org/#include-credentials" id="ref-for-include-credentials④">includes credentials</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⑤">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①⑧">TypeError</a></code>. </p>
      <li>
       <p>Set <var>request</var> to a new <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪③">request</a> whose <a data-link-type="dfn" href="#concept-request-url" id="ref-for-concept-request-url②">url</a> is <var>parsedURL</var>. </p>
      <li>
       <p>Set <var>fallbackMode</var> to "<code>cors</code>". </p>
      <li>
       <p>Set <var>fallbackCredentials</var> to "<code>same-origin</code>". </p>
     </ol>
    <li>
     <p>Otherwise (<var>input</var> is a <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request⑨">Request</a></code> object): </p>
     <ol>
      <li>
       <p>Set <var>request</var> to <var>input</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①">request</a>. </p>
      <li>
       <p>Set <var>signal</var> to <var>input</var>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal">signal</a>. </p>
     </ol>
    <li>
     <p>Let <var>origin</var> be <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object①">current settings object</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin①">origin</a>. </p>
    <li>
     <p>Let <var>window</var> be "<code>client</code>". </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window①⓪">window</a> is
 an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object" id="ref-for-environment-settings-object①②">environment settings object</a> and its <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin" id="ref-for-concept-settings-object-origin②">origin</a> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin⑥">same origin</a> with <var>origin</var>, set <var>window</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window①①">window</a>. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-window" id="ref-for-dom-requestinit-window①">window</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists②">exists</a> and is non-null, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⑥">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror①⑨">TypeError</a></code>. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-window" id="ref-for-dom-requestinit-window②">window</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists③">exists</a>, then set <var>window</var> to "<code>no-window</code>". </p>
    <li>
     <p>Set <var>request</var> to a new <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪④">request</a> with the following properties: </p>
     <dl>
      <dt><a data-link-type="dfn" href="#concept-request-url" id="ref-for-concept-request-url③">URL</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-current-url" id="ref-for-concept-request-current-url③⑨">current URL</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method①⑨">method</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method②⓪">method</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④②">header list</a> 
      <dd>A copy of <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④③">header list</a>. 
      <dt><a data-link-type="dfn" href="#unsafe-request-flag" id="ref-for-unsafe-request-flag②">unsafe-request flag</a> 
      <dd>Set. 
      <dt><a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client①⑨">client</a> 
      <dd><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object②">Current settings object</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-window" id="ref-for-concept-request-window①②">window</a> 
      <dd><var>window</var>. 
      <dt><a data-link-type="dfn" href="#concept-request-priority" id="ref-for-concept-request-priority②">priority</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-priority" id="ref-for-concept-request-priority③">priority</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-origin" id="ref-for-concept-request-origin①⑤">origin</a> 
      <dd>"<code>client</code>". 
      <dt><a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer⑨">referrer</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①⓪">referrer</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy⑧">referrer policy</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy⑨">referrer policy</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①⑥">mode</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①⑦">mode</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode②⓪">credentials mode</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode②①">credentials mode</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①②">cache mode</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①③">cache mode</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode⑨">redirect mode</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode①⓪">redirect mode</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-integrity-metadata" id="ref-for-concept-request-integrity-metadata②">integrity metadata</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-integrity-metadata" id="ref-for-concept-request-integrity-metadata③">integrity metadata</a>. 
      <dt><a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag③">keepalive flag</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag④">keepalive flag</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-reload-navigation-flag" id="ref-for-concept-request-reload-navigation-flag">reload-navigation flag</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-reload-navigation-flag" id="ref-for-concept-request-reload-navigation-flag①">reload-navigation flag</a>. 
      <dt><a data-link-type="dfn" href="#concept-request-history-navigation-flag" id="ref-for-concept-request-history-navigation-flag">history-navigation flag</a> 
      <dd><var>request</var>’s <a data-link-type="dfn" href="#concept-request-history-navigation-flag" id="ref-for-concept-request-history-navigation-flag①">history-navigation flag</a>. 
     </dl>
    <li>
     <p>If <var>init</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-is-empty" id="ref-for-map-is-empty">is not empty</a>, then: </p>
     <ol>
      <li>
       <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①⑧">mode</a> is
   "<code>navigate</code>", then set it to "<code>same-origin</code>". </p>
      <li>
       <p>Unset <var>request</var>’s <a data-link-type="dfn" href="#concept-request-reload-navigation-flag" id="ref-for-concept-request-reload-navigation-flag②">reload-navigation flag</a>. </p>
      <li>
       <p>Unset <var>request</var>’s <a data-link-type="dfn" href="#concept-request-history-navigation-flag" id="ref-for-concept-request-history-navigation-flag②">history-navigation flag</a>. </p>
      <li>
       <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①①">referrer</a> to
   "<code>client</code>" </p>
      <li>
       <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy①⓪">referrer policy</a> to the empty string. </p>
     </ol>
     <p class="note" role="note">This is done to ensure that when a service worker "redirects" a request, e.g., from
  an image in a cross-origin style sheet, and makes modifications, it no longer appears to come from
  the original source (i.e., the cross-origin style sheet), but instead from the service worker that
  "redirected" the request. This is important as the original source might not even be able to
  generate the same kind of requests as the service worker. Services that trust the original source
  could therefore be exploited were this not done, although that is somewhat farfetched. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-referrer" id="ref-for-dom-requestinit-referrer①">referrer</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists④">exists</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>referrer</var> be <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-referrer" id="ref-for-dom-requestinit-referrer②">referrer</a></code>"]. </p>
      <li>
       <p>If <var>referrer</var> is the empty string, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①②">referrer</a> to "<code>no-referrer</code>". </p>
      <li>
       <p>Otherwise: </p>
       <ol>
        <li>
         <p>Let <var>parsedReferrer</var> be the result of <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-parser" id="ref-for-concept-url-parser②">parsing</a> <var>referrer</var> with <var>baseURL</var>. </p>
        <li>
         <p>If <var>parsedReferrer</var> is failure, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⑦">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②⓪">TypeError</a></code>. </p>
        <li>
         <p>If one of the following is true </p>
         <ul class="brief">
          <li>
           <p><var>parsedReferrer</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag" id="ref-for-url-cannot-be-a-base-url-flag①">cannot-be-a-base-URL flag</a> is set, <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme②⓪">scheme</a> is "<code>about</code>", and <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-path" id="ref-for-concept-url-path②">path</a> contains a single
       string "<code>client</code>" </p>
          <li>
           <p><var>parsedReferrer</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-origin" id="ref-for-concept-url-origin①⓪">origin</a> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#same-origin" id="ref-for-same-origin⑦">same origin</a> with <var>origin</var> </p>
         </ul>
         <p>then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①③">referrer</a> to "<code>client</code>". </p>
        <li>
         <p>Otherwise, set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①④">referrer</a> to <var>parsedReferrer</var>. </p>
       </ol>
     </ol>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-referrerpolicy" id="ref-for-dom-requestinit-referrerpolicy①">referrerPolicy</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑤">exists</a>, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy①①">referrer policy</a> to it. </p>
    <li>
     <p>Let <var>mode</var> be <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-mode" id="ref-for-dom-requestinit-mode①">mode</a></code>"] if it <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑥">exists</a>,
 and <var>fallbackMode</var> otherwise. </p>
    <li>
     <p>If <var>mode</var> is "<code>navigate</code>", then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⑧">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②①">TypeError</a></code>. </p>
    <li>
     <p>If <var>mode</var> is non-null, set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode①⑨">mode</a> to <var>mode</var>. </p>
    <li>
     <p>Let <var>credentials</var> be <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-credentials" id="ref-for-dom-requestinit-credentials①">credentials</a></code>"] if it <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑦">exists</a>, and <var>fallbackCredentials</var> otherwise. </p>
    <li>
     <p>If <var>credentials</var> is non-null, set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode②②">credentials mode</a> to <var>credentials</var>. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-cache" id="ref-for-dom-requestinit-cache①">cache</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑧">exists</a>, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①④">cache mode</a> to it. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①⑤">cache mode</a> is "<code>only-if-cached</code>" and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode②⓪">mode</a> is <em>not</em> "<code>same-origin</code>", then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⑨">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②②">TypeError</a></code>. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-redirect" id="ref-for-dom-requestinit-redirect①">redirect</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists⑨">exists</a>, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode①①">redirect mode</a> to it. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-integrity" id="ref-for-dom-requestinit-integrity①">integrity</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①⓪">exists</a>, then set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-integrity-metadata" id="ref-for-concept-request-integrity-metadata④">integrity metadata</a> to it. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-keepalive" id="ref-for-dom-requestinit-keepalive①">keepalive</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①①">exists</a>, then set <var>request</var>’s <a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag⑤">keepalive flag</a> if <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-keepalive" id="ref-for-dom-requestinit-keepalive②">keepalive</a></code>"] is true,
 and unset it otherwise. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-method" id="ref-for-dom-requestinit-method①">method</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①②">exists</a>, then: </p>
     <ol>
      <li>
       <p>Let <var>method</var> be <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-method" id="ref-for-dom-requestinit-method②">method</a></code>"]. </p>
      <li>
       <p>If <var>method</var> is not a <a data-link-type="dfn" href="#concept-method" id="ref-for-concept-method①②">method</a> or <var>method</var> is a <a data-link-type="dfn" href="#forbidden-method" id="ref-for-forbidden-method①">forbidden method</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②⓪">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②③">TypeError</a></code>. </p>
      <li>
       <p><a data-link-type="dfn" href="#concept-method-normalize" id="ref-for-concept-method-normalize②">Normalize</a> <var>method</var>. </p>
      <li>
       <p>Set <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method②①">method</a> to <var>method</var>. </p>
     </ol>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-signal" id="ref-for-dom-requestinit-signal①">signal</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①③">exists</a>, then set <var>signal</var> to it. </p>
    <li>
     <p>Let <var>r</var> be a new <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request①⓪">Request</a></code> object associated with <var>request</var>. </p>
    <li>
     <p>If <var>signal</var> is not null, then make <var>r</var>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal①">signal</a> <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#abortsignal-follow" id="ref-for-abortsignal-follow">follow</a> <var>signal</var>. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers">headers</a> to a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①③">Headers</a></code> object, whose <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list⑨">header list</a> is <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④④">header list</a>, and <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①⑥">guard</a> is "<code>request</code>". </p>
    <li>
     <p>If <var>init</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-is-empty" id="ref-for-map-is-empty①">is not empty</a>, then: </p>
     <p class="note" role="note">The headers are sanitised as they might contain headers that are not allowed by this
  mode. Otherwise, they were previously sanitised or are unmodified since creation by a privileged
  API. </p>
     <ol>
      <li>
       <p>Let <var>headers</var> be a copy of <var>r</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers①">headers</a> and its
   associated <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①⓪">header list</a>. </p>
      <li>
       <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-headers" id="ref-for-dom-requestinit-headers①">headers</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①④">exists</a>, then set <var>headers</var> to <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-headers" id="ref-for-dom-requestinit-headers②">headers</a></code>"]. </p>
      <li>
       <p>Empty <var>r</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers②">headers</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①①">header list</a>. </p>
      <li>
       <p>If <var>r</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode②①">mode</a> is
    "<code>no-cors</code>", then: </p>
       <ol>
        <li>
         <p>If <var>r</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request③">request</a>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method②②">method</a> is not a <a data-link-type="dfn" href="#cors-safelisted-method" id="ref-for-cors-safelisted-method④">CORS-safelisted method</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②①">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②④">TypeError</a></code>. </p>
        <li>
         <p>Set <var>r</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers③">headers</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①⑦">guard</a> to
     "<code>request-no-cors</code>". </p>
       </ol>
      <li>
       <p>If <var>headers</var> is a <code>Headers</code> object, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate①⓪">for each</a> <var>header</var> in its <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①②">header list</a>, <a data-link-type="dfn" href="#concept-headers-append" id="ref-for-concept-headers-append③">append</a> <var>header</var>’s <a data-link-type="dfn" href="#concept-header-name" id="ref-for-concept-header-name⑤⑧">name</a>/<var>header</var>’s <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value④⓪">value</a> to <var>r</var>’s <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①④">Headers</a></code> object. </p>
      <li>
       <p>Otherwise, <a data-link-type="dfn" href="#concept-headers-fill" id="ref-for-concept-headers-fill①">fill</a> <var>r</var>’s <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①⑤">Headers</a></code> object with <var>headers</var>. </p>
     </ol>
    <li>
     <p>Let <var>inputBody</var> be <var>input</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request④">request</a>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③④">body</a> if <var>input</var> is a <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request①①">Request</a></code> object, and null otherwise. </p>
    <li>
     <p>If either <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-body" id="ref-for-dom-requestinit-body①">body</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①⑤">exists</a> and is non-null or <var>inputBody</var> is non-null, and <var>request</var>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method②③">method</a> is
 `<code>GET</code>` or `<code>HEAD</code>`, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②②">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②⑤">TypeError</a></code>. </p>
    <li>
     <p>Let <var>body</var> be <var>inputBody</var>. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-body" id="ref-for-dom-requestinit-body②">body</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①⑥">exists</a> and is non-null, then: </p>
     <ol>
      <li>
       <p>Let <var>Content-Type</var> be null. </p>
      <li>
       <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-keepalive" id="ref-for-dom-requestinit-keepalive③">keepalive</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①⑦">exists</a> and is true, then
   set <var>body</var> and <var>Content-Type</var> to the result of <a data-link-type="dfn" href="#concept-bodyinit-extract" id="ref-for-concept-bodyinit-extract②">extracting</a> <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-body" id="ref-for-dom-requestinit-body③">body</a></code>"], with the <var>keepalive flag</var> set. </p>
      <li>
       <p>Otherwise, set <var>body</var> and <var>Content-Type</var> to the result of <a data-link-type="dfn" href="#concept-bodyinit-extract" id="ref-for-concept-bodyinit-extract③">extracting</a> <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-requestinit-body" id="ref-for-dom-requestinit-body④">body</a></code>"]. </p>
      <li>
       <p>If <var>Content-Type</var> is non-null and <var>r</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers④">headers</a>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①③">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②④">does not contain</a> `<code>Content-Type</code>`, then <a data-link-type="dfn" href="#concept-headers-append" id="ref-for-concept-headers-append④">append</a> `<code>Content-Type</code>`/<var>Content-Type</var> to <var>r</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers⑤">headers</a>. </p>
     </ol>
    <li>
     <p>If <var>body</var> is non-null and <var>body</var>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source①①">source</a> is null, then: </p>
     <ol>
      <li>
       <p>If <var>r</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request⑤">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode②②">mode</a> is neither
   "<code>same-origin</code>" nor "<code>cors</code>", then throw a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②⑥">TypeError</a></code>. </p>
      <li>
       <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request⑥">request</a>’s <a data-link-type="dfn" href="#use-cors-preflight-flag" id="ref-for-use-cors-preflight-flag⑥">use-CORS-preflight flag</a>. </p>
     </ol>
    <li>
     <p>If <var>inputBody</var> is <var>body</var> and <var>input</var> is <a data-link-type="dfn" href="#concept-body-disturbed" id="ref-for-concept-body-disturbed②">disturbed</a> or <a data-link-type="dfn" href="#concept-body-locked" id="ref-for-concept-body-locked①">locked</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②③">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②⑦">TypeError</a></code>. </p>
    <li>
     <p>If <var>inputBody</var> is <var>body</var> and <var>inputBody</var> is non-null, then: </p>
     <ol>
      <li>
       <p>Let <var>ws</var> and <var>rs</var> be the <a data-link-type="dfn" href="https://streams.spec.whatwg.org/#writable-side" id="ref-for-writable-side">writable side</a> and <a data-link-type="dfn" href="https://streams.spec.whatwg.org/#readable-side" id="ref-for-readable-side">readable side</a> of an <a data-link-type="dfn" href="https://streams.spec.whatwg.org/#identity-transform-stream" id="ref-for-identity-transform-stream">identity transform stream</a>, respectively.</p>
      <li>
       <p>Let <var>promise</var> be the result of calling <a data-link-type="abstract-op" href="https://streams.spec.whatwg.org/#readable-stream-pipe-to" id="ref-for-readable-stream-pipe-to">ReadableStreamPipeTo</a>(<var>inputBody</var>, <var>ws</var>, false,
    false, false, undefined). </p>
       <p class="note no-backref" role="note">This makes <var>inputBody</var>’s <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①⑧">stream</a> <a data-link-type="dfn" href="#concept-readablestream-locked" id="ref-for-concept-readablestream-locked③">locked</a> and <a data-link-type="dfn" href="#concept-readablestream-disturbed" id="ref-for-concept-readablestream-disturbed③">disturbed</a> immediately. </p>
      <li>
       <p>Set <var>promise</var>.[[PromiseIsHandled]] to true. </p>
      <li>
       <p>Set <var>body</var> to a new <a data-link-type="dfn" href="#concept-body" id="ref-for-concept-body①②">body</a> whose <a data-link-type="dfn" href="#concept-body-stream" id="ref-for-concept-body-stream①⑨">stream</a> is <var>rs</var>, whose <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source①②">source</a> is <var>inputBody</var>’s <a data-link-type="dfn" href="#concept-body-source" id="ref-for-concept-body-source①③">source</a>, and
   whose <a data-link-type="dfn" href="#concept-body-total-bytes" id="ref-for-concept-body-total-bytes③">total bytes</a> is <var>inputBody</var>’s <a data-link-type="dfn" href="#concept-body-total-bytes" id="ref-for-concept-body-total-bytes④">total bytes</a>. </p>
     </ol>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request⑦">request</a>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③⑤">body</a> to <var>body</var>. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-body-mime-type" id="ref-for-concept-body-mime-type①">MIME type</a> to the result of <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type⑦">extracting a MIME type</a> from <var>r</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request⑧">request</a>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④⑤">header list</a>. </p>
    <li>
     <p>Return <var>r</var>. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-method"><code>method</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①⑨">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request⑨">request</a>’s <a data-link-type="dfn" href="#concept-request-method" id="ref-for-concept-request-method②④">method</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-url"><code>url</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②⓪">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①⓪">request</a>’s <a data-link-type="dfn" href="#concept-request-url" id="ref-for-concept-request-url④">URL</a>, <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer②">serialized</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-headers"><code>headers</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②①">context object</a>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers⑥">headers</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-destination"><code>destination</code></dfn> attribute’s getter, when invoked,
must return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②②">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①①">request</a>’s <a data-link-type="dfn" href="#concept-request-destination" id="ref-for-concept-request-destination①⑧">destination</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-referrer"><code>referrer</code></dfn> attribute’s getter, when invoked, must
return the empty string if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②③">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①②">request</a>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①⑤">referrer</a> is "<code>no-referrer</code>", "<code>about:client</code>" if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②④">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①③">request</a>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①⑥">referrer</a> is
"<code>client</code>", and the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②⑤">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①④">request</a>’s <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①⑦">referrer</a>, <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer③">serialized</a>, otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-referrerpolicy"><code>referrerPolicy</code></dfn> attribute’s getter, when
invoked, must return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②⑥">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①⑤">request</a>’s <a data-link-type="dfn" href="#concept-request-referrer-policy" id="ref-for-concept-request-referrer-policy①②">referrer policy</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-mode"><code>mode</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②⑦">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①⑥">request</a>’s <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode②③">mode</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-credentials"><code>credentials</code></dfn> attribute’s getter, when invoked,
must return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②⑧">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①⑦">request</a>’s <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode②③">credentials mode</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-cache"><code>cache</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②⑨">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①⑧">request</a>’s <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①⑥">cache mode</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-redirect"><code>redirect</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③⓪">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request①⑨">request</a>’s <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode①②">redirect mode</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-integrity"><code>integrity</code></dfn> attribute’s getter, when invoked,
must return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③①">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②⓪">request</a>’s <a data-link-type="dfn" href="#concept-request-integrity-metadata" id="ref-for-concept-request-integrity-metadata⑤">integrity metadata</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-keepalive"><code>keepalive</code></dfn> attribute’s getter, when invoked,
must return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③②">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②①">request</a>’s <a data-link-type="dfn" href="#request-keepalive-flag" id="ref-for-request-keepalive-flag⑥">keepalive flag</a> is set, and false otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-isreloadnavigation"><code>isReloadNavigation</code></dfn> attribute’s getter, when
invoked, must return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③③">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②②">request</a>’s <a data-link-type="dfn" href="#concept-request-reload-navigation-flag" id="ref-for-concept-request-reload-navigation-flag③">reload-navigation flag</a> is set, and false otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-ishistorynavigation"><code>isHistoryNavigation</code></dfn> attribute’s getter, when
invoked, must return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③④">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②③">request</a>’s <a data-link-type="dfn" href="#concept-request-history-navigation-flag" id="ref-for-concept-request-history-navigation-flag③">history-navigation flag</a> is set, and false otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="attribute" data-export id="dom-request-signal"><code>signal</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③⑤">context object</a>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal②">signal</a>. </p>
   <hr>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Request" data-dfn-type="method" data-export id="dom-request-clone"><code>clone()</code></dfn> method, when invoked, must
run these steps: </p>
   <ol>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③⑥">context object</a> is <a data-link-type="dfn" href="#concept-body-disturbed" id="ref-for-concept-body-disturbed③">disturbed</a> or <a data-link-type="dfn" href="#concept-body-locked" id="ref-for-concept-body-locked②">locked</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②④">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②⑧">TypeError</a></code>. </p>
    <li>
     <p>Let <var>clonedRequestObject</var> be a new <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request①②">Request</a></code> object. </p>
    <li>
     <p>Let <var>clonedRequest</var> be the result of <a data-link-type="dfn" href="#concept-request-clone" id="ref-for-concept-request-clone①">cloning</a> the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③⑦">context object</a>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②④">request</a>. </p>
    <li>
     <p>Set <var>clonedRequestObject</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②⑤">request</a> to <var>clonedRequest</var>. </p>
    <li>
     <p>Set <var>clonedRequestObject</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers⑦">headers</a> to a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①⑥">Headers</a></code> object
  with the following properties: </p>
     <dl>
      <dt><a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①④">header list</a> 
      <dd><var>clonedRequest</var>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①⑤">header list</a>. 
      <dt><a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①⑧">guard</a> 
      <dd>The <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③⑧">context object</a>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers⑧">headers</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard①⑨">guard</a>. 
     </dl>
    <li>
     <p>Make <var>clonedRequestObject</var>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal③">signal</a> <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#abortsignal-follow" id="ref-for-abortsignal-follow①">follow</a> the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③⑨">context object</a>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal④">signal</a>. </p>
    <li>
     <p>Return <var>clonedRequestObject</var>. </p>
   </ol>
   <h3 class="heading settled" data-level="5.4" id="response-class"><span class="secno">5.4. </span><span class="content">Response class</span><a class="self-link" href="#response-class"></a></h3>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="response"><code><c- g>Response</c-></code></dfn> {
  <a class="idl-code" data-link-type="constructor" href="#dom-response" id="ref-for-dom-response①"><c- g>constructor</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#bodyinit" id="ref-for-bodyinit②"><c- n>BodyInit</c-></a>? <dfn class="idl-code" data-dfn-for="Response/Response(body, init), Response/constructor(body, init), Response/Response(body), Response/constructor(body), Response/Response(), Response/constructor()" data-dfn-type="argument" data-export id="dom-response-response-body-init-body"><code><c- g>body</c-></code><a class="self-link" href="#dom-response-response-body-init-body"></a></dfn> = <c- b>null</c->, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#responseinit" id="ref-for-responseinit"><c- n>ResponseInit</c-></a> <dfn class="idl-code" data-dfn-for="Response/Response(body, init), Response/constructor(body, init), Response/Response(body), Response/constructor(body), Response/Response(), Response/constructor()" data-dfn-type="argument" data-export id="dom-response-response-body-init-init"><code><c- g>init</c-></code><a class="self-link" href="#dom-response-response-body-init-init"></a></dfn> = {});

  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject⑥"><c- g>NewObject</c-></a>] <c- b>static</c-> <a class="n" data-link-type="idl-name" href="#response" id="ref-for-response"><c- n>Response</c-></a> <a class="idl-code" data-link-type="method" href="#dom-response-error" id="ref-for-dom-response-error"><c- g>error</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject⑦"><c- g>NewObject</c-></a>] <c- b>static</c-> <a class="n" data-link-type="idl-name" href="#response" id="ref-for-response①"><c- n>Response</c-></a> <a class="idl-code" data-link-type="method" href="#dom-response-redirect" id="ref-for-dom-response-redirect"><c- g>redirect</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑥"><c- b>USVString</c-></a> <dfn class="idl-code" data-dfn-for="Response/redirect(url, status), Response/redirect(url)" data-dfn-type="argument" data-export id="dom-response-redirect-url-status-url"><code><c- g>url</c-></code><a class="self-link" href="#dom-response-redirect-url-status-url"></a></dfn>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="Response/redirect(url, status), Response/redirect(url)" data-dfn-type="argument" data-export id="dom-response-redirect-url-status-status"><code><c- g>status</c-></code><a class="self-link" href="#dom-response-redirect-url-status-status"></a></dfn> = 302);

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#responsetype" id="ref-for-responsetype"><c- n>ResponseType</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ResponseType" href="#dom-response-type" id="ref-for-dom-response-type"><c- g>type</c-></a>;

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString⑦"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-response-url" id="ref-for-dom-response-url"><c- g>url</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean⑥"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-response-redirected" id="ref-for-dom-response-redirected"><c- g>redirected</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short①"><c- b>unsigned</c-> <c- b>short</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned short" href="#dom-response-status" id="ref-for-dom-response-status"><c- g>status</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean⑦"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-response-ok" id="ref-for-dom-response-ok①"><c- g>ok</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①⑤"><c- b>ByteString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ByteString" href="#dom-response-statustext" id="ref-for-dom-response-statustext"><c- g>statusText</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject①"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#headers" id="ref-for-headers①⑦"><c- n>Headers</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Headers" href="#dom-response-headers" id="ref-for-dom-response-headers"><c- g>headers</c-></a>;

  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject⑧"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#response" id="ref-for-response②"><c- n>Response</c-></a> <a class="idl-code" data-link-type="method" href="#dom-response-clone" id="ref-for-dom-response-clone"><c- g>clone</c-></a>();
};
<a class="n" data-link-type="idl-name" href="#response" id="ref-for-response③"><c- n>Response</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#body" id="ref-for-body⑥"><c- n>Body</c-></a>;

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="responseinit"><code><c- g>ResponseInit</c-></code></dfn> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short②"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="dfn-paneled idl-code" data-default="200" data-dfn-for="ResponseInit" data-dfn-type="dict-member" data-export data-type="unsigned short " id="dom-responseinit-status"><code><c- g>status</c-></code></dfn> = 200;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString" id="ref-for-idl-ByteString①⑥"><c- b>ByteString</c-></a> <dfn class="dfn-paneled idl-code" data-default="&quot;&quot;" data-dfn-for="ResponseInit" data-dfn-type="dict-member" data-export data-type="ByteString " id="dom-responseinit-statustext"><code><c- g>statusText</c-></code></dfn> = "";
  <a class="n" data-link-type="idl-name" href="#typedefdef-headersinit" id="ref-for-typedefdef-headersinit②"><c- n>HeadersInit</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="ResponseInit" data-dfn-type="dict-member" data-export data-type="HeadersInit " id="dom-responseinit-headers"><code><c- g>headers</c-></code></dfn>;
};

<c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="responsetype"><code><c- g>ResponseType</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="ResponseType" data-dfn-type="enum-value" data-export id="dom-responsetype-basic"><code><c- s>"basic"</c-></code><a class="self-link" href="#dom-responsetype-basic"></a></dfn>, <dfn class="idl-code" data-dfn-for="ResponseType" data-dfn-type="enum-value" data-export id="dom-responsetype-cors"><code><c- s>"cors"</c-></code><a class="self-link" href="#dom-responsetype-cors"></a></dfn>, <dfn class="idl-code" data-dfn-for="ResponseType" data-dfn-type="enum-value" data-export id="dom-responsetype-default"><code><c- s>"default"</c-></code><a class="self-link" href="#dom-responsetype-default"></a></dfn>, <dfn class="idl-code" data-dfn-for="ResponseType" data-dfn-type="enum-value" data-export id="dom-responsetype-error"><code><c- s>"error"</c-></code><a class="self-link" href="#dom-responsetype-error"></a></dfn>, <dfn class="idl-code" data-dfn-for="ResponseType" data-dfn-type="enum-value" data-export id="dom-responsetype-opaque"><code><c- s>"opaque"</c-></code><a class="self-link" href="#dom-responsetype-opaque"></a></dfn>, <dfn class="idl-code" data-dfn-for="ResponseType" data-dfn-type="enum-value" data-export id="dom-responsetype-opaqueredirect"><code><c- s>"opaqueredirect"</c-></code><a class="self-link" href="#dom-responsetype-opaqueredirect"></a></dfn> };
</pre>
   <p>A <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response④">Response</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-for="Response" data-dfn-type="dfn" data-export id="concept-response-response">response</dfn> (a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤③">response</a>). </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response⑤">Response</a></code> object also has an associated <dfn class="dfn-paneled" data-dfn-for="Response" data-dfn-type="dfn" data-export id="response-headers">headers</dfn> (null or a <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①⑧">Headers</a></code> object), initially null. </p>
   <p>A <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response⑥">Response</a></code> object’s <a data-link-type="dfn" href="#concept-body-body" id="ref-for-concept-body-body⑦">body</a> is its <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response">response</a>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②③">body</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="constructor" data-export data-lt="Response(body, init)|constructor(body, init)|Response(body)|constructor(body)|Response()|constructor()" id="dom-response"><code>Response(<var>body</var>, <var>init</var>)</code></dfn> constructor, when invoked, must run these steps: </p>
   <ol>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-status" id="ref-for-dom-responseinit-status">status</a></code>"] is not in the range <code>200</code> to <code>599</code>, inclusive, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②⑤">throw</a> a <code>RangeError</code>. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-statustext" id="ref-for-dom-responseinit-statustext">statusText</a></code>"] does not match the <a data-link-type="dfn" href="https://tools.ietf.org/html/rfc7230#section-3.1.2" id="ref-for-section-3.1.2">reason-phrase</a> token production, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②⑥">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror②⑨">TypeError</a></code>. </p>
    <li>
     <p>Let <var>r</var> be a new <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response⑦">Response</a></code> object associated with a new <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤④">response</a>. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#response-headers" id="ref-for-response-headers">headers</a> to a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers①⑨">Headers</a></code> object, whose <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①⑥">header list</a> is <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①">response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③③">header list</a>, and <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②⓪">guard</a> is "<code>response</code>". </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response②">response</a>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②①">status</a> to <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-status" id="ref-for-dom-responseinit-status①">status</a></code>"]. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response③">response</a>’s <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message⑦">status message</a> to <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-statustext" id="ref-for-dom-responseinit-statustext①">statusText</a></code>"]. </p>
    <li>
     <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-headers" id="ref-for-dom-responseinit-headers">headers</a></code>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①⑧">exists</a>, then <a data-link-type="dfn" href="#concept-headers-fill" id="ref-for-concept-headers-fill②">fill</a> <var>r</var>’s <a data-link-type="dfn" href="#response-headers" id="ref-for-response-headers①">headers</a> with <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-headers" id="ref-for-dom-responseinit-headers①">headers</a></code>"]. </p>
    <li>
     <p>If <var>body</var> is non-null, then: </p>
     <ol>
      <li>
       <p>If <var>init</var>["<code class="idl"><a data-link-type="idl" href="#dom-responseinit-status" id="ref-for-dom-responseinit-status②">status</a></code>"] is a <a data-link-type="dfn" href="#null-body-status" id="ref-for-null-body-status①">null body status</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②⑦">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror③⓪">TypeError</a></code>. </p>
       <p class="note no-backref" role="note"><code>101</code> is included in <a data-link-type="dfn" href="#null-body-status" id="ref-for-null-body-status②">null body status</a> due to its use elsewhere. It does not affect this step. </p>
      <li>
       <p>Let <var>Content-Type</var> be null. </p>
      <li>
       <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response④">response</a>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②④">body</a> and <var>Content-Type</var> to the result of <a data-link-type="dfn" href="#concept-bodyinit-extract" id="ref-for-concept-bodyinit-extract④">extracting</a> <var>body</var>. </p>
      <li>
       <p>If <var>Content-Type</var> is non-null and <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response⑤">response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③④">header list</a> <a data-link-type="dfn" href="#header-list-contains" id="ref-for-header-list-contains②⑤">does not contain</a> `<code>Content-Type</code>`, then <a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②④">append</a> `<code>Content-Type</code>`/<var>Content-Type</var> to <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response⑥">response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③⑤">header list</a>. </p>
     </ol>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-body-mime-type" id="ref-for-concept-body-mime-type②">MIME type</a> to the result of <a data-link-type="dfn" href="#concept-header-extract-mime-type" id="ref-for-concept-header-extract-mime-type⑧">extracting a MIME type</a> from <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response⑦">response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③⑥">header list</a>. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response⑧">response</a>’s <a data-link-type="dfn" href="#concept-response-https-state" id="ref-for-concept-response-https-state⑨">HTTPS state</a> to <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object③">current settings object</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#https-state" id="ref-for-https-state④">HTTPS state</a>. </p>
    <li>
     <p>Return <var>r</var>. </p>
   </ol>
   <p>The static <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="method" data-export id="dom-response-error"><code>error()</code></dfn> method, when invoked, must run
these steps: </p>
   <ol>
    <li>
     <p>Let <var>r</var> be a new <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response⑧">Response</a></code> object, whose <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response⑨">response</a> is a new <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑥②">network error</a>. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#response-headers" id="ref-for-response-headers②">headers</a> to a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers②⓪">Headers</a></code> object whose <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②①">guard</a> is "<code>immutable</code>". </p>
    <li>
     <p>Return <var>r</var>. </p>
   </ol>
   <p>The static <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="method" data-export data-lt="redirect(url, status)|redirect(url)" id="dom-response-redirect"><code>redirect(<var>url</var>, <var>status</var>)</code></dfn> method, when invoked, must run these steps: </p>
   <ol>
    <li>
     <p>Let <var>parsedURL</var> be the result of <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-parser" id="ref-for-concept-url-parser③">parsing</a> <var>url</var> with <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object" id="ref-for-current-settings-object④">current settings object</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#api-base-url" id="ref-for-api-base-url①">API base URL</a>. </p>
    <li>
     <p>If <var>parsedURL</var> is failure, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②⑧">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror③①">TypeError</a></code>. </p>
    <li>
     <p>If <var>status</var> is not a <a data-link-type="dfn" href="#redirect-status" id="ref-for-redirect-status①">redirect status</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②⑨">throw</a> a <code>RangeError</code>. </p>
    <li>
     <p>Let <var>r</var> be a new <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response⑨">Response</a></code> object, whose <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①⓪">response</a> is a new <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤⑤">response</a>. </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#response-headers" id="ref-for-response-headers③">headers</a> to a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers②①">Headers</a></code> object whose <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②②">guard</a> is "<code>immutable</code>". </p>
    <li>
     <p>Set <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①①">response</a>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②②">status</a> to <var>status</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②⑤">Append</a> `<code>Location</code>` to <var>parsedURL</var>, <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer④">serialized</a> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode⑤">isomorphic encoded</a>, in <var>r</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①②">response</a>’s <a data-link-type="dfn" href="#concept-response-header-list" id="ref-for-concept-response-header-list③⑦">header list</a>. </p>
    <li>
     <p>Return <var>r</var>. </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-type"><code>type</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④⓪">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①③">response</a>’s <a data-link-type="dfn" href="#concept-response-type" id="ref-for-concept-response-type①①">type</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-url"><code>url</code></dfn> attribute’s getter, when invoked, must
return the empty string if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④①">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①④">response</a>’s <a data-link-type="dfn" href="#concept-response-url" id="ref-for-concept-response-url③">URL</a> is null and the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④②">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①⑤">response</a>’s <a data-link-type="dfn" href="#concept-response-url" id="ref-for-concept-response-url④">URL</a>, <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer⑤">serialized</a> with the <i>exclude-fragment flag</i> set, otherwise. <a data-link-type="biblio" href="#biblio-url">[URL]</a> </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-redirected"><code>redirected</code></dfn> attribute’s getter, when invoked,
must return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④③">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①⑥">response</a>’s <a data-link-type="dfn" href="#concept-response-url-list" id="ref-for-concept-response-url-list⑧">URL list</a> has more than one item, and false otherwise. </p>
   <p class="note" role="note">To filter out <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤⑥">responses</a> that are the result of a
redirect, do this directly through the API, e.g., <code>fetch(url, { redirect:"error" })</code>.
This way a potentially unsafe <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤⑦">response</a> cannot accidentally leak. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-status"><code>status</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④④">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①⑦">response</a>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②③">status</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-ok"><code>ok</code></dfn> attribute’s getter, when invoked, must
return true if the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④⑤">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①⑧">response</a>’s <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②④">status</a> is an <a data-link-type="dfn" href="#ok-status" id="ref-for-ok-status①">ok status</a>, and false otherwise. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-statustext"><code>statusText</code></dfn> attribute’s getter, when invoked,
must return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④⑥">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response①⑨">response</a>’s <a data-link-type="dfn" href="#concept-response-status-message" id="ref-for-concept-response-status-message⑧">status message</a>. </p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="attribute" data-export id="dom-response-headers"><code>headers</code></dfn> attribute’s getter, when invoked, must
return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④⑦">context object</a>’s <a data-link-type="dfn" href="#response-headers" id="ref-for-response-headers④">headers</a>. </p>
   <hr>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Response" data-dfn-type="method" data-export id="dom-response-clone"><code>clone()</code></dfn> method, when invoked, must
run these steps: </p>
   <ol>
    <li>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④⑧">context object</a> is <a data-link-type="dfn" href="#concept-body-disturbed" id="ref-for-concept-body-disturbed④">disturbed</a> or <a data-link-type="dfn" href="#concept-body-locked" id="ref-for-concept-body-locked③">locked</a>, then <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw③⓪">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror③②">TypeError</a></code>. </p>
    <li>
     <p>Let <var>clonedResponseObject</var> be a new <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response①⓪">Response</a></code> object. </p>
    <li>
     <p>Let <var>clonedResponse</var> be the result of <a data-link-type="dfn" href="#concept-response-clone" id="ref-for-concept-response-clone①">cloning</a> the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④⑨">context object</a>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response②⓪">response</a>. </p>
    <li>
     <p>Set <var>clonedResponseObject</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response②①">response</a> to <var>clonedResponse</var>. </p>
    <li>
     <p>Set <var>clonedResponseObject</var>’s <a data-link-type="dfn" href="#request-headers" id="ref-for-request-headers⑨">headers</a> to a new <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers②②">Headers</a></code> object
 whose <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①⑦">header list</a> is set to <var>clonedResponse</var>’s <a data-link-type="dfn" href="#concept-headers-header-list" id="ref-for-concept-headers-header-list①⑧">header list</a>, and <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②③">guard</a> is the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑤⓪">context object</a>’s <a data-link-type="dfn" href="#response-headers" id="ref-for-response-headers⑤">headers</a>’s <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②④">guard</a>. </p>
    <li>
     <p>Return <var>clonedResponseObject</var>. </p>
    <li>
     <p>Return <var>clonedResponse</var>. </p>
   </ol>
   <h3 class="heading settled" data-level="5.5" id="fetch-method"><span class="secno">5.5. </span><span class="content">Fetch method</span><a class="self-link" href="#fetch-method"></a></h3>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/webappapis.html#windoworworkerglobalscope" id="ref-for-windoworworkerglobalscope"><c- g>WindowOrWorkerGlobalScope</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject⑨"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#response" id="ref-for-response①①"><c- n>Response</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-global-fetch" id="ref-for-dom-global-fetch⑥"><c- g>fetch</c-></a>(<a class="n" data-link-type="idl-name" href="#requestinfo" id="ref-for-requestinfo①"><c- n>RequestInfo</c-></a> <dfn class="idl-code" data-dfn-for="WindowOrWorkerGlobalScope/fetch(input, init), WindowOrWorkerGlobalScope/fetch(input)" data-dfn-type="argument" data-export id="dom-windoworworkerglobalscope-fetch-input-init-input"><code><c- g>input</c-></code><a class="self-link" href="#dom-windoworworkerglobalscope-fetch-input-init-input"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#requestinit" id="ref-for-requestinit①"><c- n>RequestInit</c-></a> <dfn class="idl-code" data-dfn-for="WindowOrWorkerGlobalScope/fetch(input, init), WindowOrWorkerGlobalScope/fetch(input)" data-dfn-type="argument" data-export id="dom-windoworworkerglobalscope-fetch-input-init-init"><code><c- g>init</c-></code><a class="self-link" href="#dom-windoworworkerglobalscope-fetch-input-init-init"></a></dfn> = {});
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="WindowOrWorkerGlobalScope" data-dfn-type="method" data-export data-lt="fetch(input, init)|fetch(input)" id="dom-global-fetch"><code>fetch(<var>input</var>, <var>init</var>)</code></dfn> method, must run these steps: </p>
   <ol>
    <li>
     <p>Let <var>p</var> be a new promise. </p>
    <li>
     <p>Let <var>requestObject</var> be the result of invoking the initial value of <code class="idl"><a data-link-type="idl" href="#request" id="ref-for-request①③">Request</a></code> as
 constructor with <var>input</var> and <var>init</var> as arguments. If this throws an exception,
 reject <var>p</var> with it and return <var>p</var>. </p>
    <li>
     <p>Let <var>request</var> be <var>requestObject</var>’s <a data-link-type="dfn" href="#concept-request-request" id="ref-for-concept-request-request②⑥">request</a>. </p>
    <li>
     <p>If <var>requestObject</var>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal⑤">signal</a>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#abortsignal-aborted-flag" id="ref-for-abortsignal-aborted-flag">aborted flag</a> is set, then: </p>
     <ol>
      <li>
       <p><a data-link-type="dfn" href="#abort-fetch" id="ref-for-abort-fetch">Abort fetch</a> with <var>p</var>, <var>request</var>, and null. </p>
      <li>
       <p>Return <var>p</var>. </p>
     </ol>
    <li>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client②⓪">client</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global" id="ref-for-concept-settings-object-global②">global object</a> is a <code class="idl"><a data-link-type="idl" href="https://w3c.github.io/ServiceWorker/#serviceworkerglobalscope" id="ref-for-serviceworkerglobalscope">ServiceWorkerGlobalScope</a></code> object,
 then set <var>request</var>’s <a data-link-type="dfn" href="#request-service-workers-mode" id="ref-for-request-service-workers-mode④">service-workers mode</a> to "<code>none</code>". 
    <li>
     <p>Let <var>responseObject</var> be a new <code class="idl"><a data-link-type="idl" href="#response" id="ref-for-response①②">Response</a></code> object and a new associated <code class="idl"><a data-link-type="idl" href="#headers" id="ref-for-headers②③">Headers</a></code> object whose <a data-link-type="dfn" href="#concept-headers-guard" id="ref-for-concept-headers-guard②⑤">guard</a> is
 "<code>immutable</code>". </p>
    <li>
     <p>Let <var>locallyAborted</var> be false. </p>
     <p class="note" role="note">This lets us reject promises with predictable timing, when the request to abort
  comes from the same thread as the call to fetch. </p>
    <li>
     <p><a data-link-type="dfn" href="https://dom.spec.whatwg.org/#abortsignal-add" id="ref-for-abortsignal-add">Add the following abort steps</a> to <var>requestObject</var>’s <a data-link-type="dfn" href="#request-signal" id="ref-for-request-signal⑥">signal</a>: </p>
     <ol>
      <li>
       <p>Set <var>locallyAborted</var> to true. </p>
      <li>
       <p><a data-link-type="dfn" href="#abort-fetch" id="ref-for-abort-fetch①">Abort fetch</a> with <var>p</var>, <var>request</var>, and <var>responseObject</var>. </p>
      <li>
       <p><a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①⑦">Terminate</a> the ongoing fetch with the aborted flag set. </p>
     </ol>
    <li>
     <p>Run the following <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel" id="ref-for-in-parallel⑦">in parallel</a>: </p>
     <p><a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②⑧">Fetch</a> <var>request</var>. </p>
     <p>To <a data-link-type="dfn" href="#process-response" id="ref-for-process-response②">process response</a> for <var>response</var>, run these substeps: </p>
     <ol>
      <li>
       <p>If <var>locallyAborted</var> is true, terminate these substeps. </p>
      <li>
       <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-aborted" id="ref-for-concept-response-aborted③">aborted flag</a> is set, then <a data-link-type="dfn" href="#abort-fetch" id="ref-for-abort-fetch②">abort fetch</a> with <var>p</var>, <var>request</var>, and <var>responseObject</var>, and terminate these
   substeps. </p>
      <li>
       <p>If <var>response</var> is a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑥③">network error</a>, then reject <var>p</var> with a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror③③">TypeError</a></code> and terminate these substeps. </p>
      <li>
       <p>Associate <var>responseObject</var> with <var>response</var>. </p>
      <li>
       <p>Resolve <var>p</var> with <var>responseObject</var>. </p>
     </ol>
    <li>
     <p>Return <var>p</var>. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="abort-fetch">abort fetch</dfn> with a <var>promise</var>, <var>request</var>, and <var>responseObject</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>error</var> be an "<code><a class="idl-code" data-link-type="exception" href="https://heycam.github.io/webidl/#aborterror" id="ref-for-aborterror②">AbortError</a></code>" <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMException" id="ref-for-idl-DOMException②">DOMException</a></code>. </p>
    <li>
     <p>Reject <var>promise</var> with <var>error</var>. </p>
     <p class="note" role="note">This is a no-op if <var>promise</var> has already fulfilled. </p>
    <li>
     <p>If <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③⑥">body</a> is not null and is <a data-link-type="dfn" href="#concept-readablestream-readable" id="ref-for-concept-readablestream-readable④">readable</a>, then <a data-link-type="dfn" href="#concept-cancel-readablestream" id="ref-for-concept-cancel-readablestream">cancel</a> <var>request</var>’s <a data-link-type="dfn" href="#concept-request-body" id="ref-for-concept-request-body③⑦">body</a> with <var>error</var>. </p>
    <li>
     <p>If <var>responseObject</var> is null, then return. </p>
    <li>
     <p>Let <var>response</var> be <var>responseObject</var>’s <a data-link-type="dfn" href="#concept-response-response" id="ref-for-concept-response-response②②">response</a>. </p>
    <li>
     <p>If <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②⑤">body</a> is not null and is <a data-link-type="dfn" href="#concept-readablestream-readable" id="ref-for-concept-readablestream-readable⑤">readable</a>, then <a data-link-type="abstract-op" href="#concept-error-readablestream" id="ref-for-concept-error-readablestream⑤">error</a> <var>response</var>’s <a data-link-type="dfn" href="#concept-response-body" id="ref-for-concept-response-body②⑥">body</a> with <var>error</var>. </p>
   </ol>
   <h3 class="heading settled" data-level="5.6" id="garbage-collection"><span class="secno">5.6. </span><span class="content">Garbage collection</span><a class="self-link" href="#garbage-collection"></a></h3>
   <p>The user agent may <a data-link-type="dfn" href="#concept-fetch-terminate" id="ref-for-concept-fetch-terminate①⑧">terminate</a> an ongoing fetch if that termination
is not observable through script. </p>
   <p class="note no-backref" role="note">"Observable through script" means observable through <a data-link-type="functionish" href="#dom-global-fetch" id="ref-for-dom-global-fetch⑦"><code>fetch()</code></a>’s arguments and return value. Other ways, such as
communicating with the server through a side-channel are not included. </p>
   <p class="note no-backref" role="note">The server being able to observe garbage collection has precedent, e.g.,
with <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/web-sockets.html#websocket" id="ref-for-websocket">WebSocket</a></code> and <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest⑥">XMLHttpRequest</a></code> objects. </p>
   <div class="example no-backref" id="terminate-examples">
    <a class="self-link" href="#terminate-examples"></a> 
    <p>The user agent can terminate the fetch because the termination cannot be observed. </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"https://www.example.com/"</c-><c- p>)</c->
</code></pre>
    <p>The user agent cannot terminate the fetch because the termination can be observed through
 the promise. </p>
<pre><code class="lang-javascript highlight">window<c- p>.</c->promise <c- o>=</c-> fetch<c- p>(</c-><c- u>"https://www.example.com/"</c-><c- p>)</c->
</code></pre>
    <p>The user agent can terminate the fetch because the associated body is not observable. </p>
<pre><code class="lang-javascript highlight">window<c- p>.</c->promise <c- o>=</c-> fetch<c- p>(</c-><c- u>"https://www.example.com/"</c-><c- p>).</c->then<c- p>(</c->res <c- p>=></c-> res<c- p>.</c->headers<c- p>)</c->
</code></pre>
    <p>The user agent can terminate the fetch because the termination cannot be observed. </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"https://www.example.com/"</c-><c- p>).</c->then<c- p>(</c->res <c- p>=></c-> res<c- p>.</c->body<c- p>.</c->getReader<c- p>().</c->closed<c- p>)</c->
</code></pre>
    <p>The user agent cannot terminate the fetch because one can observe the termination by registering
 a handler for the promise object. </p>
<pre><code class="lang-javascript highlight">window<c- p>.</c->promise <c- o>=</c-> fetch<c- p>(</c-><c- u>"https://www.example.com/"</c-><c- p>)</c->
  <c- p>.</c->then<c- p>(</c->res <c- p>=></c-> res<c- p>.</c->body<c- p>.</c->getReader<c- p>().</c->closed<c- p>)</c->
</code></pre>
    <p>The user agent cannot terminate the fetch as termination would be observable via the registered
 handler. </p>
<pre><code class="lang-javascript highlight">fetch<c- p>(</c-><c- u>"https://www.example.com/"</c-><c- p>)</c->
  <c- p>.</c->then<c- p>(</c->res <c- p>=></c-> <c- p>{</c->
    res<c- p>.</c->body<c- p>.</c->getReader<c- p>().</c->closed<c- p>.</c->then<c- p>(()</c-> <c- p>=></c-> console<c- p>.</c->log<c- p>(</c-><c- u>"stream closed!"</c-><c- p>))</c->
  <c- p>})</c->
</code></pre>
    <p>(The above examples of non-observability assume that built-in properties and functions, such as <code class="idl"><a data-link-type="idl" href="https://streams.spec.whatwg.org/#rs-get-reader" id="ref-for-rs-get-reader">body.getReader()</a></code>, have not been overwritten.) </p>
   </div>
   <h2 class="heading settled" data-level="6" id="websocket-protocol"><span class="secno">6. </span><span class="content">WebSocket protocol alterations</span><a class="self-link" href="#websocket-protocol"></a></h2>
   <div class="note" role="note">
    <p>This section replaces part of the WebSocket protocol opening handshake client requirement to
 integrate it with algorithms defined in Fetch. This way CSP, cookies, HSTS, and other Fetch-related
 protocols are handled in a single location. Ideally the RFC would be updated with this language,
 but it is never that easy. The WebSocket API, defined in the HTML Standard, has been updated to use
 this language. <a data-link-type="biblio" href="#biblio-wsp">[WSP]</a> <a data-link-type="biblio" href="#biblio-html">[HTML]</a> </p>
    <p>The way this works is by replacing The WebSocket Protocol’s "establish a WebSocket connection"
 algorithm with a new one that integrates with Fetch. "Establish a WebSocket connection" consists of
 three algorithms: setting up a connection, creating and transmiting a handshake request, and
 validating the handshake response. That layering is different from Fetch, which first creates a
 handshake, then sets up a connection and transmits the handshake, and finally validates the
 response. Keep that in mind while reading these alterations. </p>
   </div>
   <h3 class="heading settled" data-level="6.1" id="websocket-connections"><span class="secno">6.1. </span><span class="content">Connections</span><a class="self-link" href="#websocket-connections"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-websocket-connection-obtain">obtain a WebSocket connection</dfn>, given a <var>url</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>host</var> be <var>url</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-host" id="ref-for-concept-url-host③">host</a>. </p>
    <li>
     <p>Let <var>port</var> be <var>url</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-port" id="ref-for-concept-url-port③">port</a>. </p>
    <li>
     <p>Let <var>secure</var> be false, if <var>url</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme②①">scheme</a> is
 "<code>http</code>", and true otherwise. </p>
    <li>
     <p>Follow the requirements stated in step 2 to 5, inclusive, of the first set of steps in <a href="http://tools.ietf.org/html/rfc6455#section-4.1">section 4.1</a> of The WebSocket Protocol
 to establish a <a data-link-type="dfn" href="#concept-websocket-connection-obtain" id="ref-for-concept-websocket-connection-obtain①">WebSocket connection</a>. <a data-link-type="biblio" href="#biblio-wsp">[WSP]</a> </p>
    <li>
     <p>If that established a connection, return it, and return failure otherwise. </p>
   </ol>
   <p class="note" role="note">Although structured a little differently, carrying different properties, and
therefore not shareable, a WebSocket connection is very close to identical to an "ordinary" <a data-link-type="dfn" href="#concept-connection" id="ref-for-concept-connection⑦">connection</a>. </p>
   <h3 class="heading settled" data-level="6.2" id="websocket-opening-handshake"><span class="secno">6.2. </span><span class="content">Opening handshake</span><a class="self-link" href="#websocket-opening-handshake"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-websocket-establish">establish a WebSocket connection</dfn>, given a <var>url</var>, <var>protocols</var>, and <var>client</var>, run these steps: </p>
   <ol>
    <li>
     <p>Let <var>requestURL</var> be a copy of <var>url</var>, with its <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme②②">scheme</a> set to
  "<code>http</code>", if <var>url</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme②③">scheme</a> is "<code>ws</code>", and
  to "<code>https</code>" otherwise. </p>
     <p class="note no-backref" role="note">This change of scheme is essential to integrate well with <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch②⑨">fetching</a>. E.g., HSTS would not work without it. There is no real
  reason for WebSocket to have distinct schemes, it’s a legacy artefact. <a data-link-type="biblio" href="#biblio-hsts">[HSTS]</a> </p>
    <li>
     <p>Let <var>request</var> be a new <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪⑤">request</a>, whose <a data-link-type="dfn" href="#concept-request-url" id="ref-for-concept-request-url⑤">URL</a> is <var>requestURL</var>, <a data-link-type="dfn" href="#concept-request-client" id="ref-for-concept-request-client②①">client</a> is <var>client</var>, <a data-link-type="dfn" href="#request-service-workers-mode" id="ref-for-request-service-workers-mode⑤">service-workers mode</a> is "<code>none</code>", <a data-link-type="dfn" href="#concept-request-referrer" id="ref-for-concept-request-referrer①⑧">referrer</a> is "<code>no-referrer</code>", <a data-link-type="dfn" href="#synchronous-flag" id="ref-for-synchronous-flag⑤">synchronous flag</a> is set, <a data-link-type="dfn" href="#concept-request-mode" id="ref-for-concept-request-mode②④">mode</a> is "<code>websocket</code>", <a data-link-type="dfn" href="#concept-request-credentials-mode" id="ref-for-concept-request-credentials-mode②④">credentials mode</a> is
 "<code>include</code>", <a data-link-type="dfn" href="#concept-request-cache-mode" id="ref-for-concept-request-cache-mode①⑦">cache mode</a> is "<code>no-store</code>", and <a data-link-type="dfn" href="#concept-request-redirect-mode" id="ref-for-concept-request-redirect-mode①③">redirect mode</a> is "<code>error</code>". </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②⑥">Append</a> `<code>Upgrade</code>`/`<code>websocket</code>` to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④⑥">header list</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②⑦">Append</a> `<code>Connection</code>`/`<code>Upgrade</code>` to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④⑦">header list</a>. </p>
    <li>
     <p>Let <var>keyValue</var> be a nonce consisting of a randomly selected 16-byte value that has
  been <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#forgiving-base64-encode" id="ref-for-forgiving-base64-encode">forgiving-base64-encoded</a> and <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-encode" id="ref-for-isomorphic-encode⑥">isomorphic encoded</a>. </p>
     <p class="example" id="example-random-value"><a class="self-link" href="#example-random-value"></a>If the randomly selected value was the byte sequence 0x01 0x02 0x03 0x04 0x05
  0x06 0x07 0x08 0x09 0x0a 0x0b 0x0c 0x0d 0x0e 0x0f 0x10, <var>keyValue</var> would be
  forgiving-base64-encoded to "<code>AQIDBAUGBwgJCgsMDQ4PEC==</code>" and isomorphic encoded
  to `<code>AQIDBAUGBwgJCgsMDQ4PEC==</code>`. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②⑧">Append</a> `<code>Sec-WebSocket-Key</code>`/<var>keyValue</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④⑧">header list</a>. </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append②⑨">Append</a> `<code>Sec-WebSocket-Version</code>`/`<code>13</code>` to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list④⑨">header list</a>. </p>
    <li>
     <p>For each <var>protocol</var> in <var>protocols</var>, <a data-link-type="dfn" href="#concept-header-list-combine" id="ref-for-concept-header-list-combine②">combine</a> `<code>Sec-WebSocket-Protocol</code>`/<var>protocol</var> in <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑤⓪">header list</a>. </p>
    <li>
     <p>Let <var>permessageDeflate</var> be a user-agent defined
  "<code>permessage-deflate</code>" extension <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥⑥">header</a> <a data-link-type="dfn" href="#concept-header-value" id="ref-for-concept-header-value④①">value</a>. <a data-link-type="biblio" href="#biblio-wsp">[WSP]</a> </p>
     <p class="example" id="example-permessage-deflate"><a class="self-link" href="#example-permessage-deflate"></a>`<code>permessage-deflate; client_max_window_bits</code>` </p>
    <li>
     <p><a data-link-type="dfn" href="#concept-header-list-append" id="ref-for-concept-header-list-append③⓪">Append</a> `<code>Sec-WebSocket-Extensions</code>`/<var>permessageDeflate</var> to <var>request</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑤①">header list</a>. </p>
    <li>
     <p>Let <var>response</var> be the result of <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch③⓪">fetching</a> <var>request</var>. </p>
    <li>
     <p>If <var>response</var> is a <a data-link-type="dfn" href="#concept-network-error" id="ref-for-concept-network-error⑥④">network error</a> or its <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②⑤">status</a> is not <code>101</code>, <a data-link-type="dfn" href="#fail-the-websocket-connection" id="ref-for-fail-the-websocket-connection">fail the WebSocket connection</a>. </p>
    <li>
     <p>If <var>protocols</var> is not the empty list and <a data-link-type="dfn" href="#extract-header-list-values" id="ref-for-extract-header-list-values⑥">extracting header list values</a> given
  `<code>Sec-WebSocket-Protocol</code>` and <var>response</var>’s <a data-link-type="dfn" href="#concept-request-header-list" id="ref-for-concept-request-header-list⑤②">header list</a> results in null, failure, or the empty byte sequence, then <a data-link-type="dfn" href="#fail-the-websocket-connection" id="ref-for-fail-the-websocket-connection①">fail the WebSocket connection</a>. </p>
     <p class="note" role="note">This is different from the check on this header defined by The WebSocket Protocol.
  That only covers a subprotocol not requested by the client. This covers a subprotocol requested by
  the client, but not acknowledged by the server. </p>
    <li>
     <p>Follow the requirements stated step 2 to step 6, inclusive, of the last set of steps in <a href="http://tools.ietf.org/html/rfc6455#section-4.1">section 4.1</a> of The WebSocket Protocol
 to validate <var>response</var>. This either results in <a data-link-type="dfn" href="#fail-the-websocket-connection" id="ref-for-fail-the-websocket-connection②">fail the WebSocket connection</a> or <a data-link-type="dfn" href="#the-websocket-connection-is-established" id="ref-for-the-websocket-connection-is-established">the WebSocket connection is established</a>. </p>
   </ol>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="fail-the-websocket-connection">Fail the WebSocket connection</dfn> and <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="the-websocket-connection-is-established">the WebSocket connection is established</dfn> are defined by The WebSocket Protocol. <a data-link-type="biblio" href="#biblio-wsp">[WSP]</a> </p>
   <p class="warning">The reason redirects are not followed and this handshake is generally restricted is
because it could introduce serious security problems in a web browser context. For example, consider
a host with a WebSocket server at one path and an open HTTP redirector at another. Suddenly, any
script that can be given a particular WebSocket URL can be tricked into communicating to (and
potentially sharing secrets with) any host on the internet, even if the script checks that the URL
has the right hostname. </p>
   <h2 class="heading settled" data-level="7" id="data-urls"><span class="secno">7. </span><span class="content"><code>data:</code> URLs</span><a class="self-link" href="#data-urls"></a></h2>
   <p>For an informative description of <code>data:</code> URLs, see RFC 2397. This section replaces
that RFC’s normative processing requirements to be compatible with deployed content. <a data-link-type="biblio" href="#biblio-rfc2397">[RFC2397]</a> </p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="data-url-struct"><code>data:</code> URL struct</dfn> is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#struct" id="ref-for-struct">struct</a> that consists of a <dfn class="dfn-paneled" data-dfn-for="data: URL struct" data-dfn-type="dfn" data-noexport id="data-url-struct-mime-type">MIME type</dfn> (a <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#mime-type" id="ref-for-mime-type⑤">MIME type</a>) and a <dfn class="dfn-paneled" data-dfn-for="data: URL struct" data-dfn-type="dfn" data-noexport id="data-url-struct-body">body</dfn> (a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#byte-sequence" id="ref-for-byte-sequence⑤">byte sequence</a>). </p>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="data-url-processor"><code>data:</code> URL processor</dfn> takes a <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①⑥">URL</a> <var>dataURL</var> and then runs these steps: </p>
   <ol>
    <li>
     <p>Assert: <var>dataURL</var>’s <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-scheme" id="ref-for-concept-url-scheme②④">scheme</a> is "<code>data</code>". </p>
    <li>
     <p>Let <var>input</var> be the result of running the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer⑥">URL serializer</a> on <var>dataURL</var> with the <i>exclude fragment flag</i> set. </p>
    <li>
     <p>Remove the leading "<code>data:</code>" string from <var>input</var>. </p>
    <li>
     <p>Let <var>position</var> point at the start of <var>input</var>. </p>
    <li>
     <p>Let <var>mimeType</var> be the result of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#collect-a-sequence-of-code-points" id="ref-for-collect-a-sequence-of-code-points②">collecting a sequence of code points</a> that
 are not equal to U+002C (,), given <var>position</var>. </p>
    <li>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#strip-leading-and-trailing-ascii-whitespace" id="ref-for-strip-leading-and-trailing-ascii-whitespace">Strip leading and trailing ASCII whitespace</a> from <var>mimeType</var>. </p>
     <p class="note" role="note">This will only remove U+0020 SPACE <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point⑥">code points</a>, if any. </p>
    <li>
     <p>If <var>position</var> is past the end of <var>input</var>, then return failure. </p>
    <li>
     <p>Advance <var>position</var> by 1. </p>
    <li>
     <p>Let <var>encodedBody</var> be the remainder of <var>input</var>. </p>
    <li>
     <p>Let <var>body</var> be the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#string-percent-decode" id="ref-for-string-percent-decode">string percent decoding</a> of <var>encodedBody</var>. </p>
    <li>
     <p>If <var>mimeType</var> ends with U+003B (;), followed by zero or more U+0020 SPACE, followed by
  an <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-case-insensitive" id="ref-for-ascii-case-insensitive①">ASCII case-insensitive</a> match for "<code>base64</code>", then: </p>
     <ol>
      <li>
       <p>Let <var>stringBody</var> be the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#isomorphic-decode" id="ref-for-isomorphic-decode①">isomorphic decode</a> of <var>body</var>. </p>
      <li>
       <p>Set <var>body</var> to the <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#forgiving-base64-decode" id="ref-for-forgiving-base64-decode">forgiving-base64 decode</a> of <var>stringBody</var>. </p>
      <li>
       <p>If <var>body</var> is failure, then return failure. </p>
      <li>
       <p>Remove the last 6 <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point⑦">code points</a> from <var>mimeType</var>. </p>
      <li>
       <p>Remove trailing U+0020 SPACE <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point⑧">code points</a> from <var>mimeType</var>, if any. </p>
      <li>
       <p>Remove the last U+003B (;) <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-point" id="ref-for-code-point⑨">code point</a> from <var>mimeType</var>. </p>
     </ol>
    <li>
     <p>If <var>mimeType</var> starts with U+003B (;), then prepend "<code>text/plain</code>"
 to <var>mimeType</var>. </p>
    <li>
     <p>Let <var>mimeTypeRecord</var> be the result of <a data-link-type="dfn" href="https://mimesniff.spec.whatwg.org/#parse-a-mime-type" id="ref-for-parse-a-mime-type③">parsing</a> <var>mimeType</var>. </p>
    <li>
     <p>If <var>mimeTypeRecord</var> is failure, then set <var>mimeTypeRecord</var> to <code>text/plain;charset=US-ASCII</code>. </p>
    <li>
     <p>Return a new <a data-link-type="dfn" href="#data-url-struct" id="ref-for-data-url-struct"><code>data:</code> URL struct</a> whose <a data-link-type="dfn" href="#data-url-struct-mime-type" id="ref-for-data-url-struct-mime-type①">MIME type</a> is <var>mimeTypeRecord</var> and <a data-link-type="dfn" href="#data-url-struct-body" id="ref-for-data-url-struct-body①">body</a> is <var>body</var>. </p>
   </ol>
   <h2 class="no-num heading settled" id="background-reading"><span class="content">Background reading</span><a class="self-link" href="#background-reading"></a></h2>
   <p><em>This section and its subsections are informative only.</em> </p>
   <h3 class="no-num heading settled dfn-paneled" data-dfn-type="dfn" data-noexport id="http-header-layer-division"><span class="content">HTTP header layer division</span></h3>
   <p>For the purposes of fetching, there is an API layer (HTML’s <code>img</code>, CSS' <code>background-image</code>), early fetch layer,
service worker layer, and network &amp; cache layer.
`<code>Accept</code>` and
`<code>Accept-Language</code>` are set in the early fetch layer
(typically by the user agent). Most other headers controlled by the user agent, such as
`<code>Accept-Encoding</code>`,
`<code>Host</code>`, and `<code>Referer</code>`, are
set in the network &amp; cache layer. Developers can set headers either at the API layer
or in the service worker layer (typically through a <a data-link-type="dfn" href="#concept-request" id="ref-for-concept-request①⓪⑥"><code>Request</code></a> object).
Developers have almost no control over <a data-link-type="dfn" href="#forbidden-header-name" id="ref-for-forbidden-header-name④">forbidden headers</a>, but can control
`<code>Accept</code>` and have the means to constrain and omit
`<code>Referer</code>` for instance. </p>
   <h3 class="no-num heading settled dfn-paneled" data-dfn-type="dfn" data-noexport id="atomic-http-redirect-handling"><span class="content">Atomic HTTP redirect handling</span></h3>
   <p>Redirects (a <a data-link-type="dfn" href="#concept-response" id="ref-for-concept-response⑤⑧">response</a> whose <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②⑥">status</a> or <a data-link-type="dfn" href="#concept-internal-response" id="ref-for-concept-internal-response①②">internal response</a>’s (if any) <a data-link-type="dfn" href="#concept-response-status" id="ref-for-concept-response-status②⑦">status</a> is a <a data-link-type="dfn" href="#redirect-status" id="ref-for-redirect-status②">redirect status</a>) are not exposed
to APIs. Exposing redirects might leak information not otherwise available through a cross-site
scripting attack. </p>
   <p class="example" id="example-xss-redirect"><a class="self-link" href="#example-xss-redirect"></a>A fetch to <code>https://example.org/auth</code> that includes a <code>Cookie</code> marked <code>HttpOnly</code> could result in a redirect to <code>https://other-origin.invalid/4af955781ea1c84a3b11</code>. This new URL contains a
secret. If we expose redirects that secret would be available through a cross-site
scripting attack. </p>
   <h3 class="no-num heading settled" id="basic-safe-cors-protocol-setup"><span class="content">Basic safe CORS protocol setup</span><a class="self-link" href="#basic-safe-cors-protocol-setup"></a></h3>
   <p>For resources where data is protected through IP authentication or a firewall
(unfortunately relatively common still), using the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol①⑨">CORS protocol</a> is <strong>unsafe</strong>. (This is the reason why the <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol②⓪">CORS protocol</a> had to be
invented.) </p>
   <p>However, otherwise using the following <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥⑦">header</a> is <strong>safe</strong>: </p>
<pre><code class="lang-http highlight">Access-Control-Allow-Origin: *
</code></pre>
   <p>Even if a resource exposes additional information based on cookie or HTTP
authentication, using the above <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥⑧">header</a> will not reveal
it. It will share the resource with APIs such as <code class="idl"><a data-link-type="idl" href="https://xhr.spec.whatwg.org/#xmlhttprequest" id="ref-for-xmlhttprequest⑦">XMLHttpRequest</a></code>, much like it is already shared with <code>curl</code> and <code>wget</code>. </p>
   <p>Thus in other words, if a resource cannot be accessed from a random device connected to
the web using <code>curl</code> and <code>wget</code> the aforementioned <a data-link-type="dfn" href="#concept-header" id="ref-for-concept-header⑥⑨">header</a> is not to be included. If it can be accessed
however, it is perfectly fine to do so. </p>
   <h3 class="no-num heading settled" id="cors-protocol-and-http-caches"><span class="content">CORS protocol and HTTP caches</span><a class="self-link" href="#cors-protocol-and-http-caches"></a></h3>
   <p>If <a data-link-type="dfn" href="#cors-protocol" id="ref-for-cors-protocol②①">CORS protocol</a> requirements are more complicated than setting
`<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin⑦"><code>Access-Control-Allow-Origin</code></a>` to <code>*</code> or a static <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑤">origin</a>, `<code>Vary</code>` is to be used. <a data-link-type="biblio" href="#biblio-html">[HTML]</a> <a data-link-type="biblio" href="#biblio-http">[HTTP]</a> <a data-link-type="biblio" href="#biblio-http-semantics">[HTTP-SEMANTICS]</a> <a data-link-type="biblio" href="#biblio-http-cond">[HTTP-COND]</a> <a data-link-type="biblio" href="#biblio-http-caching">[HTTP-CACHING]</a> <a data-link-type="biblio" href="#biblio-http-auth">[HTTP-AUTH]</a> </p>
<pre class="example" id="example-vary-origin"><a class="self-link" href="#example-vary-origin"></a><code class="lang-http highlight">Vary: Origin
</code></pre>
   <p>In particular, consider what happens if `<code>Vary</code>` is <em>not</em> used and a server is
configured to send `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin⑧"><code>Access-Control-Allow-Origin</code></a>` for a certain
resource only in response to a <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request⑧">CORS request</a>. When a user agent receives a response to a
non-<a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request⑨">CORS request</a> for that resource (for example, as the result of a <a data-link-type="dfn" href="#navigation-request" id="ref-for-navigation-request④">navigation
request</a>), the response will lack `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin⑨"><code>Access-Control-Allow-Origin</code></a>`
and the user agent will cache that response. Then, if the user agent subsequently encounters a <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request①⓪">CORS request</a> for the resource, it will use that cached response from the previous
non-<a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request①①">CORS request</a>, without `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin①⓪"><code>Access-Control-Allow-Origin</code></a>`. </p>
   <p>But if `<code>Vary: Origin</code>` is used in the same scenario described above, it will cause
the user agent to <a data-link-type="dfn" href="#concept-fetch" id="ref-for-concept-fetch③①">fetch</a> a response that includes
`<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin①①"><code>Access-Control-Allow-Origin</code></a>`, rather than using the cached response
from the previous non-<a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request①②">CORS request</a> that lacks
`<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin①②"><code>Access-Control-Allow-Origin</code></a>`. </p>
   <p>However, if `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin①③"><code>Access-Control-Allow-Origin</code></a>` is set to <code>*</code> or a static <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin⑥">origin</a> for a particular resource, then configure the server
to always send `<a data-link-type="http-header" href="#http-access-control-allow-origin" id="ref-for-http-access-control-allow-origin①④"><code>Access-Control-Allow-Origin</code></a>` in responses for the
resource — for non-<a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request①③">CORS requests</a> as well as <a data-link-type="dfn" href="#cors-request" id="ref-for-cors-request①④">CORS
requests</a> — and do not use `<code>Vary</code>`. </p>
   <h2 class="no-num heading settled" id="acknowledgments"><span class="content">Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>Thanks to
Adam Barth,
Adam Lavin,
Alan Jeffrey,
Alexey Proskuryakov,
Andrés Gutiérrez,
Andrew Sutherland,
Ángel González,
Anssi Kostiainen,
Arkadiusz Michalski,
Arne Johannessen,
Artem Skoretskiy,
Arthur Barstow,
Asanka Herath,
Axel Rauschmayer,
Ben Kelly,
Benjamin Gruenbaum,
Benjamin Hawkes-Lewis,
Bert Bos,
Björn Höhrmann,
Boris Zbarsky,
Brad Hill,
Brad Porter,
Bryan Smith,
Caitlin Potter,
Cameron McCormack,
Chris Rebert,
Clement Pellerin,
Collin Jackson,
Daniel Robertson,
Daniel Veditz,
Dave Tapuska,
David Benjamin,
David Håsäther,
David Orchard,
Dean Jackson,
Devdatta Akhawe,
Domenic Denicola,
Dominic Farolino,
Dominique Hazaël-Massieux,
Doug Turner,
Douglas Creager,
Eero Häkkinen,
Ehsan Akhgari,
Emily Stark,
Eric Lawrence,
François Marier,
Frank Ellerman,
Frederick Hirsch,
Gary Blackwood,
Gavin Carothers,
Glenn Maynard,
Graham Klyne,
Hal Lockhart,
Hallvord R. M. Steen,
Harris Hancock,
Henri Sivonen,
Henry Story,
Hiroshige Hayashizaki,
Honza Bambas,
Ian Hickson,
Ilya Grigorik,
isonmad,
Jake Archibald,
James Graham,
Janusz Majnert,
Jeena Lee,
Jeff Carpenter,
Jeff Hodges,
Jeffrey Yasskin,
Jesse M. Heines,
Jianjun Chen,
Jinho Bang,
Jochen Eisinger,
John Wilander,
Jonas Sicking,
Jonathan Kingston,
Jonathan Watt,
최종찬 (Jongchan Choi),
Jörn Zaefferer,
Joseph Pecoraro,
Josh Matthews,
Julian Krispel-Samsel,
Julian Reschke,
송정기 (Jungkee Song),
Jussi Kalliokoski,
Jxck,
Kagami Sascha Rosylight,
Keith Yeung,
Kenji Baheux,
Lachlan Hunt,
Larry Masinter,
Liam Brummitt,
Louis Ryan,
Lucas Gonze,
Łukasz Anforowicz,
呂康豪 (Kang-Hao Lu),
Maciej Stachowiak,
Malisa,
Manfred Stock,
Manish Goregaokar,
Marc Silbey,
Marcos Caceres,
Marijn Kruisselbrink,
Mark Nottingham,
Mark S. Miller,
Martin Dürst,
Martin Thomson,
Matt Andrews,
Matt Falkenhagen,
Matt Oshry,
Matt Seddon,
Matt Womer,
Mhano Harkness,
Michael Kohler,
Michael™ Smith,
Mike Pennisi,
Mike West,
Mohamed Zergaoui,
Mohammed Zubair Ahmed,
Moritz Kneilmann,
Ms2ger,
Nico Schlömer,
Nicolás Peña Moreno,
Nikhil Marathe,
Nikki Bee,
Nikunj Mehta,
Odin Hørthe Omdal,
Ondřej Žára,
O. Opsec,
Perry Jiang,
Philip Jägenstedt,
R. Auburn,
Raphael Kubo da Costa,
Rondinelly,
Rory Hewitt,
Ryan Sleevi,
Sébastien Cevey,
Sendil Kumar N,
Shao-xuan Kang,
Sharath Udupa,
Shivakumar Jagalur Matt,
Sigbjørn Finne,
Simon Pieters,
Simon Sapin,
Srirama Chandra Sekhar Mogali,
Stephan Paul,
Steven Salat,
Sunava Dutta,
Surya Ismail,
Takashi Toyoshima,
吉野剛史 (Takeshi Yoshino),
Thomas Roessler,
Thomas Steiner,
Thomas Wisniewski,
Tiancheng "Timothy" Gu,
Tobie Langel,
Tom Schuster,
Tomás Aparicio,
保呂毅 (Tsuyoshi Horo),
Tyler Close,
Ujjwal Sharma,
Vignesh Shanmugam,
Vladimir Dzhuvinov,
Wayne Carr,
Xabier Rodríguez,
Yehuda Katz,
Yoav Weiss,
Youenn Fablet,
平野裕 (Yutaka Hirano), and
Zhenbin Xu
for being awesome. </p>
   <p>This standard is written by <a href="https://annevankesteren.nl/" lang="nl">Anne van Kesteren</a> (<a href="https://www.mozilla.org/">Mozilla</a>, <a href="mailto:annevk@annevk.nl">annevk@annevk.nl</a>). </p>
   <p>Copyright © 2020 WHATWG (Apple, Google, Mozilla, Microsoft). This work is licensed under a <a href="https://creativecommons.org/licenses/by/4.0/" rel="license">Creative Commons Attribution
4.0 International License</a>. </p>
  </main>
<script>
"use strict";
if ("serviceWorker" in navigator) {
  navigator.serviceWorker.register("/service-worker.js");
}
</script>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#dom-requestdestination">""</a><span>, in §5.3</span>
   <li><a href="#abnf">ABNF</a><span>, in §2</span>
   <li><a href="#concept-response-aborted">aborted flag</a><span>, in §2.2.6</span>
   <li><a href="#concept-aborted-network-error">aborted network error</a><span>, in §2.2.6</span>
   <li><a href="#abort-fetch">abort fetch</a><span>, in §5.5</span>
   <li><a href="#http-access-control-allow-credentials">Access-Control-Allow-Credentials</a><span>, in §3.2.3</span>
   <li><a href="#http-access-control-allow-headers">Access-Control-Allow-Headers</a><span>, in §3.2.3</span>
   <li><a href="#http-access-control-allow-methods">Access-Control-Allow-Methods</a><span>, in §3.2.3</span>
   <li><a href="#http-access-control-allow-origin">Access-Control-Allow-Origin</a><span>, in §3.2.3</span>
   <li><a href="#http-access-control-expose-headers">Access-Control-Expose-Headers</a><span>, in §3.2.3</span>
   <li><a href="#http-access-control-max-age">Access-Control-Max-Age</a><span>, in §3.2.3</span>
   <li><a href="#http-access-control-request-headers">Access-Control-Request-Headers</a><span>, in §3.2.2</span>
   <li><a href="#http-access-control-request-method">Access-Control-Request-Method</a><span>, in §3.2.2</span>
   <li><a href="#concept-request-add-range-header">add a range header</a><span>, in §2.2.5</span>
   <li>
    append
    <ul>
     <li><a href="#concept-headers-append">dfn for Headers</a><span>, in §5.1</span>
     <li><a href="#concept-header-list-append">dfn for header list</a><span>, in §2.2.2</span>
    </ul>
   <li><a href="#append-a-request-origin-header">append a request `Origin` header</a><span>, in §3.1</span>
   <li><a href="#dom-headers-append">append(name, value)</a><span>, in §5.1</span>
   <li><a href="#dom-body-arraybuffer">arrayBuffer()</a><span>, in §5.2</span>
   <li><a href="#atomic-http-redirect-handling">Atomic HTTP redirect handling</a><span>, in §Unnumbered section</span>
   <li><a href="#dom-requestdestination-audio">"audio"</a><span>, in §5.3</span>
   <li><a href="#dom-requestdestination-audioworklet">"audioworklet"</a><span>, in §5.3</span>
   <li><a href="#authentication-entry">authentication entry</a><span>, in §2.3</span>
   <li><a href="#bad-port">bad port</a><span>, in §2.6</span>
   <li><a href="#dom-responsetype-basic">"basic"</a><span>, in §5.4</span>
   <li><a href="#concept-filtered-response-basic">basic filtered response</a><span>, in §2.2.6</span>
   <li><a href="#dom-body-blob">blob()</a><span>, in §5.2</span>
   <li><a href="#block-bad-port">block bad port</a><span>, in §2.6</span>
   <li><a href="#body">Body</a><span>, in §5.2</span>
   <li>
    body
    <ul>
     <li><a href="#dom-body-body">attribute for Body</a><span>, in §5.2</span>
     <li><a href="#concept-body">definition of</a><span>, in §2.2.4</span>
     <li><a href="#concept-body-body">dfn for Body</a><span>, in §5.2</span>
     <li><a href="#data-url-struct-body">dfn for data: URL struct</a><span>, in §7</span>
     <li><a href="#concept-request-body">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#concept-response-body">dfn for response</a><span>, in §2.2.6</span>
     <li><a href="#dom-requestinit-body">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#bodyinit">BodyInit</a><span>, in §5.2</span>
   <li><a href="#dom-body-bodyused">bodyUsed</a><span>, in §5.2</span>
   <li><a href="#concept-cache-origin">byte-serialized origin</a><span>, in §4.8</span>
   <li><a href="#byte-serializing-a-request-origin">Byte-serializing a request origin</a><span>, in §2.2.5</span>
   <li>
    cache
    <ul>
     <li><a href="#dom-request-cache">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-requestinit-cache">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#cache-entry">cache entry</a><span>, in §4.8</span>
   <li><a href="#concept-cache-match">cache entry match</a><span>, in §4.8</span>
   <li><a href="#concept-request-cache-mode">cache mode</a><span>, in §2.2.5</span>
   <li><a href="#concept-response-cache-state">cache state</a><span>, in §2.2.6</span>
   <li><a href="#concept-cancel-readablestream">cancel</a><span>, in §2.8.1</span>
   <li><a href="#concept-cache-clear">clear cache entries</a><span>, in §4.8</span>
   <li><a href="#concept-request-client">client</a><span>, in §2.2.5</span>
   <li>
    clone
    <ul>
     <li><a href="#concept-body-clone">dfn for body</a><span>, in §2.2.4</span>
     <li><a href="#concept-request-clone">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#concept-response-clone">dfn for response</a><span>, in §2.2.6</span>
    </ul>
   <li>
    clone()
    <ul>
     <li><a href="#dom-request-clone">method for Request</a><span>, in §5.3</span>
     <li><a href="#dom-response-clone">method for Response</a><span>, in §5.4</span>
    </ul>
   <li><a href="#concept-close-readablestream">close</a><span>, in §2.8.1</span>
   <li><a href="#concept-readablestream-closed">closed</a><span>, in §2.8.1</span>
   <li><a href="#collect-an-http-quoted-string">collect an HTTP quoted string</a><span>, in §2.2</span>
   <li><a href="#collect-an-http-quoted-string">collecting an HTTP quoted string</a><span>, in §2.2</span>
   <li><a href="#concept-header-list-combine">combine</a><span>, in §2.2.2</span>
   <li><a href="#concept-connection">connection</a><span>, in §2.5</span>
   <li><a href="#concept-connection-pool">connection pool</a><span>, in §2.5</span>
   <li><a href="#concept-construct-fixed-readablestream">construct a fixed ReadableStream object</a><span>, in §2.8.1</span>
   <li><a href="#concept-construct-readablestream">construct a ReadableStream object</a><span>, in §2.8.1</span>
   <li>
    constructor()
    <ul>
     <li><a href="#dom-headers">constructor for Headers</a><span>, in §5.1</span>
     <li><a href="#dom-response">constructor for Response</a><span>, in §5.4</span>
    </ul>
   <li><a href="#dom-response">constructor(body)</a><span>, in §5.4</span>
   <li><a href="#dom-response">constructor(body, init)</a><span>, in §5.4</span>
   <li><a href="#dom-headers">constructor(init)</a><span>, in §5.1</span>
   <li><a href="#dom-request">constructor(input)</a><span>, in §5.3</span>
   <li><a href="#dom-request">constructor(input, init)</a><span>, in §5.3</span>
   <li><a href="#concept-body-consume-body">consume body</a><span>, in §5.2</span>
   <li><a href="#header-list-contains">contains</a><span>, in §2.2.2</span>
   <li><a href="#convert-header-names-to-a-sorted-lowercase-set">convert header names to a sorted-lowercase set</a><span>, in §2.2.2</span>
   <li><a href="#corb-check">CORB check</a><span>, in §3.5</span>
   <li><a href="#corb-protected-mime-type">CORB-protected MIME type</a><span>, in §3.5</span>
   <li>
    "cors"
    <ul>
     <li><a href="#dom-requestmode-cors">enum-value for RequestMode</a><span>, in §5.3</span>
     <li><a href="#dom-responsetype-cors">enum-value for ResponseType</a><span>, in §5.4</span>
    </ul>
   <li><a href="#concept-cors-check">CORS check</a><span>, in §4.9</span>
   <li><a href="#concept-response-cors-exposed-header-name-list">CORS-exposed header-name list</a><span>, in §2.2.6</span>
   <li><a href="#concept-filtered-response-cors">CORS filtered response</a><span>, in §2.2.6</span>
   <li><a href="#cors-non-wildcard-request-header-name">CORS non-wildcard request-header name</a><span>, in §2.2.2</span>
   <li><a href="#concept-cache">CORS-preflight cache</a><span>, in §4.8</span>
   <li><a href="#cors-preflight-fetch-0">CORS-preflight fetch</a><span>, in §4.7</span>
   <li><a href="#cors-preflight-request">CORS-preflight request</a><span>, in §3.2.2</span>
   <li><a href="#cors-protocol">CORS protocol</a><span>, in §3.2</span>
   <li><a href="#cors-request">CORS request</a><span>, in §3.2.2</span>
   <li><a href="#cors-safelisted-method">CORS-safelisted method</a><span>, in §2.2.1</span>
   <li><a href="#cors-safelisted-request-header">CORS-safelisted request-header</a><span>, in §2.2.2</span>
   <li><a href="#cors-safelisted-response-header-name">CORS-safelisted response-header name</a><span>, in §2.2.2</span>
   <li><a href="#cors-unsafe-request-header-byte">CORS-unsafe request-header byte</a><span>, in §2.2.2</span>
   <li><a href="#cors-unsafe-request-header-names">CORS-unsafe request-header names</a><span>, in §2.2.2</span>
   <li><a href="#concept-cache-create-entry">create a new cache entry</a><span>, in §4.8</span>
   <li><a href="#credentials">Credentials</a><span>, in §2</span>
   <li>
    credentials
    <ul>
     <li><a href="#dom-request-credentials">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#concept-cache-credentials">dfn for cache entry</a><span>, in §4.8</span>
     <li><a href="#dom-requestinit-credentials">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-request-credentials-mode">credentials mode</a><span>, in §2.2.5</span>
   <li><a href="#http-cross-origin-resource-policy">Cross-Origin-Resource-Policy</a><span>, in §3.6</span>
   <li><a href="#cross-origin-resource-policy-check">cross-origin resource policy check</a><span>, in §3.6</span>
   <li><a href="#concept-request-nonce-metadata">cryptographic nonce metadata</a><span>, in §2.2.5</span>
   <li><a href="#concept-response-csp-list">CSP list</a><span>, in §2.2.6</span>
   <li><a href="#concept-request-current-url">current URL</a><span>, in §2.2.5</span>
   <li><a href="#data-url-processor">data: URL processor</a><span>, in §7</span>
   <li><a href="#data-url-struct">data: URL struct</a><span>, in §7</span>
   <li>
    "default"
    <ul>
     <li><a href="#dom-requestcache-default">enum-value for RequestCache</a><span>, in §5.3</span>
     <li><a href="#dom-responsetype-default">enum-value for ResponseType</a><span>, in §5.4</span>
    </ul>
   <li><a href="#default-user-agent-value">default `User-Agent` value</a><span>, in §2.2.2</span>
   <li><a href="#concept-header-list-delete">delete</a><span>, in §2.2.2</span>
   <li><a href="#dom-headers-delete">delete(name)</a><span>, in §5.1</span>
   <li>
    destination
    <ul>
     <li><a href="#dom-request-destination">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#concept-request-destination">dfn for request</a><span>, in §2.2.5</span>
    </ul>
   <li><a href="#determine-nosniff">determine nosniff</a><span>, in §3.4</span>
   <li>
    disturbed
    <ul>
     <li><a href="#concept-body-disturbed">dfn for Body</a><span>, in §5.2</span>
     <li><a href="#concept-readablestream-disturbed">dfn for ReadableStream</a><span>, in §2.8.1</span>
    </ul>
   <li><a href="#dom-requestdestination-document">"document"</a><span>, in §5.3</span>
   <li><a href="#header-list-contains">does not contain</a><span>, in §2.2.2</span>
   <li><a href="#concept-body-done">done</a><span>, in §2.2.4</span>
   <li><a href="#done-flag">done flag</a><span>, in §2.2.5</span>
   <li><a href="#dom-requestdestination-embed">"embed"</a><span>, in §5.3</span>
   <li><a href="#concept-empty-readablestream">empty</a><span>, in §2.8.1</span>
   <li><a href="#concept-enqueue-readablestream">enqueue</a><span>, in §2.8.1</span>
   <li>
    "error"
    <ul>
     <li><a href="#dom-requestredirect-error">enum-value for RequestRedirect</a><span>, in §5.3</span>
     <li><a href="#dom-responsetype-error">enum-value for ResponseType</a><span>, in §5.4</span>
    </ul>
   <li><a href="#concept-error-readablestream">error</a><span>, in §2.8.1</span>
   <li><a href="#dom-response-error">error()</a><span>, in §5.4</span>
   <li><a href="#concept-readablestream-errored">errored</a><span>, in §2.8.1</span>
   <li><a href="#concept-websocket-establish">establish a WebSocket connection</a><span>, in §6.2</span>
   <li><a href="#concept-bodyinit-extract">extract</a><span>, in §5.2</span>
   <li><a href="#concept-header-extract-mime-type">extract a MIME type</a><span>, in §3.3</span>
   <li><a href="#extract-header-list-values">extract header list values</a><span>, in §2.2.2</span>
   <li><a href="#extract-header-values">extract header values</a><span>, in §2.2.2</span>
   <li><a href="#concept-header-extract-mime-type">extracting a MIME type</a><span>, in §3.3</span>
   <li><a href="#extract-header-list-values">extracting header list values</a><span>, in §2.2.2</span>
   <li><a href="#extract-header-values">extracting header values</a><span>, in §2.2.2</span>
   <li><a href="#fail-the-websocket-connection">Fail the WebSocket connection</a><span>, in §6.2</span>
   <li>
    fetch
    <ul>
     <li><a href="#concept-fetch">definition of</a><span>, in §4</span>
     <li><a href="#concept-fetch-record-fetch">dfn for fetch record</a><span>, in §2.4</span>
    </ul>
   <li><a href="#concept-fetch-group">fetch group</a><span>, in §2.4</span>
   <li><a href="#dom-global-fetch">fetch(input)</a><span>, in §5.5</span>
   <li><a href="#dom-global-fetch">fetch(input, init)</a><span>, in §5.5</span>
   <li><a href="#concept-fetch-record">fetch record</a><span>, in §2.4</span>
   <li><a href="#fetch-scheme">fetch scheme</a><span>, in §2.1</span>
   <li><a href="#concept-headers-fill">fill</a><span>, in §5.1</span>
   <li><a href="#concept-filtered-response">filtered response</a><span>, in §2.2.6</span>
   <li><a href="#dom-requestredirect-follow">"follow"</a><span>, in §5.3</span>
   <li><a href="#dom-requestdestination-font">"font"</a><span>, in §5.3</span>
   <li><a href="#forbidden-header-name">forbidden header name</a><span>, in §2.2.2</span>
   <li><a href="#forbidden-method">forbidden method</a><span>, in §2.2.1</span>
   <li><a href="#forbidden-response-header-name">forbidden response-header name</a><span>, in §2.2.2</span>
   <li><a href="#dom-requestcache-force-cache">"force-cache"</a><span>, in §5.3</span>
   <li><a href="#dom-body-formdata">formData()</a><span>, in §5.2</span>
   <li><a href="#concept-fresh-response">fresh response</a><span>, in §2.2.6</span>
   <li><a href="#concept-header-list-get">get</a><span>, in §2.2.2</span>
   <li><a href="#concept-get-reader">get a reader</a><span>, in §2.8.1</span>
   <li><a href="#concept-header-list-get-structured-header">get a structured header</a><span>, in §2.2.2</span>
   <li><a href="#concept-header-list-get-decode-split">get, decode, and split</a><span>, in §2.2.2</span>
   <li><a href="#dom-headers-get">get(name)</a><span>, in §5.1</span>
   <li><a href="#concept-header-list-get-decode-split">getting, decoding, and splitting</a><span>, in §2.2.2</span>
   <li><a href="#concept-headers-guard">guard</a><span>, in §5.1</span>
   <li><a href="#handle-content-codings">handle content codings</a><span>, in §2.2.4</span>
   <li><a href="#dom-headers-has">has(name)</a><span>, in §5.1</span>
   <li><a href="#concept-header">header</a><span>, in §2.2.2</span>
   <li>
    header list
    <ul>
     <li><a href="#concept-header-list">definition of</a><span>, in §2.2.2</span>
     <li><a href="#concept-headers-header-list">dfn for Headers</a><span>, in §5.1</span>
     <li><a href="#concept-request-header-list">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#concept-response-header-list">dfn for response</a><span>, in §2.2.6</span>
    </ul>
   <li><a href="#concept-cache-header-name">header name</a><span>, in §4.8</span>
   <li><a href="#concept-cache-match-header">header-name cache entry match</a><span>, in §4.8</span>
   <li><a href="#headers">Headers</a><span>, in §5.1</span>
   <li>
    headers
    <ul>
     <li><a href="#dom-request-headers">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-response-headers">attribute for Response</a><span>, in §5.4</span>
     <li><a href="#request-headers">dfn for Request</a><span>, in §5.3</span>
     <li><a href="#response-headers">dfn for Response</a><span>, in §5.4</span>
     <li><a href="#dom-requestinit-headers">dict-member for RequestInit</a><span>, in §5.3</span>
     <li><a href="#dom-responseinit-headers">dict-member for ResponseInit</a><span>, in §5.4</span>
    </ul>
   <li><a href="#dom-headers">Headers()</a><span>, in §5.1</span>
   <li><a href="#dom-headers">Headers(init)</a><span>, in §5.1</span>
   <li><a href="#typedefdef-headersinit">HeadersInit</a><span>, in §5.1</span>
   <li><a href="#concept-request-history-navigation-flag">history-navigation flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-http-fetch">HTTP fetch</a><span>, in §4.3</span>
   <li><a href="#http-header-layer-division">HTTP header layer division</a><span>, in §Unnumbered section</span>
   <li><a href="#concept-http-network-fetch">HTTP-network fetch</a><span>, in §4.6</span>
   <li><a href="#concept-http-network-or-cache-fetch">HTTP-network-or-cache fetch</a><span>, in §4.5</span>
   <li><a href="#http-newline-byte">HTTP newline byte</a><span>, in §2.2</span>
   <li><a href="#concept-http-redirect-fetch">HTTP-redirect fetch</a><span>, in §4.4</span>
   <li><a href="#http-scheme">HTTP(S) scheme</a><span>, in §2.1</span>
   <li><a href="#concept-response-https-state">HTTPS state</a><span>, in §2.2.6</span>
   <li><a href="#concept-https-state-value">HTTPS state value</a><span>, in §2.2</span>
   <li><a href="#http-tab-or-space">HTTP tab or space</a><span>, in §2.2</span>
   <li><a href="#http-tab-or-space-byte">HTTP tab or space byte</a><span>, in §2.2</span>
   <li><a href="#http-whitespace">HTTP whitespace</a><span>, in §2.2</span>
   <li><a href="#http-whitespace-byte">HTTP whitespace byte</a><span>, in §2.2</span>
   <li><a href="#dom-requestdestination-image">"image"</a><span>, in §5.3</span>
   <li><a href="#dom-requestcredentials-include">"include"</a><span>, in §5.3</span>
   <li><a href="#concept-request-initiator">initiator</a><span>, in §2.2.5</span>
   <li>
    integrity
    <ul>
     <li><a href="#dom-request-integrity">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-requestinit-integrity">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-request-integrity-metadata">integrity metadata</a><span>, in §2.2.5</span>
   <li><a href="#concept-internal-response">internal response</a><span>, in §2.2.6</span>
   <li><a href="#dom-request-ishistorynavigation">isHistoryNavigation</a><span>, in §5.3</span>
   <li><a href="#is-local">is local</a><span>, in §2.1</span>
   <li><a href="#dom-request-isreloadnavigation">isReloadNavigation</a><span>, in §5.3</span>
   <li><a href="#dom-body-json">json()</a><span>, in §5.2</span>
   <li>
    keepalive
    <ul>
     <li><a href="#dom-request-keepalive">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-requestinit-keepalive">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#request-keepalive-flag">keepalive flag</a><span>, in §2.2.5</span>
   <li><a href="#local-scheme">local scheme</a><span>, in §2.1</span>
   <li><a href="#local-urls-only-flag">local-URLs-only flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-response-location-url">location URL</a><span>, in §2.2.6</span>
   <li>
    locked
    <ul>
     <li><a href="#concept-body-locked">dfn for Body</a><span>, in §5.2</span>
     <li><a href="#concept-readablestream-locked">dfn for ReadableStream</a><span>, in §2.8.1</span>
    </ul>
   <li><a href="#concept-main-fetch">main fetch</a><span>, in §4.1</span>
   <li><a href="#dom-requestdestination-manifest">"manifest"</a><span>, in §5.3</span>
   <li><a href="#dom-requestredirect-manual">"manual"</a><span>, in §5.3</span>
   <li><a href="#concept-cache-max-age">max-age</a><span>, in §4.8</span>
   <li>
    method
    <ul>
     <li><a href="#dom-request-method">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#concept-method">definition of</a><span>, in §2.2.1</span>
     <li><a href="#concept-cache-method">dfn for cache entry</a><span>, in §4.8</span>
     <li><a href="#concept-request-method">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#dom-requestinit-method">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-cache-match-method">method cache entry match</a><span>, in §4.8</span>
   <li>
    MIME type
    <ul>
     <li><a href="#concept-body-mime-type">dfn for Body</a><span>, in §5.2</span>
     <li><a href="#data-url-struct-mime-type">dfn for data: URL struct</a><span>, in §7</span>
    </ul>
   <li>
    mode
    <ul>
     <li><a href="#dom-request-mode">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#concept-request-mode">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#dom-requestinit-mode">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-header-name">name</a><span>, in §2.2.2</span>
   <li><a href="#dom-requestmode-navigate">"navigate"</a><span>, in §5.3</span>
   <li><a href="#navigation-request">navigation request</a><span>, in §2.2.5</span>
   <li><a href="#concept-readablestream-need-more-data">need more data</a><span>, in §2.8.1</span>
   <li><a href="#concept-network-error">network error</a><span>, in §2.2.6</span>
   <li><a href="#network-scheme">network scheme</a><span>, in §2.1</span>
   <li><a href="#dom-requestcache-no-cache">"no-cache"</a><span>, in §5.3</span>
   <li><a href="#dom-requestmode-no-cors">"no-cors"</a><span>, in §5.3</span>
   <li><a href="#no-cors-safelisted-request-header">no-CORS-safelisted request-header</a><span>, in §2.2.2</span>
   <li><a href="#no-cors-safelisted-request-header-name">no-CORS-safelisted request-header name</a><span>, in §2.2.2</span>
   <li><a href="#non-subresource-request">non-subresource request</a><span>, in §2.2.5</span>
   <li>
    normalize
    <ul>
     <li><a href="#concept-header-value-normalize">dfn for header/value</a><span>, in §2.2.2</span>
     <li><a href="#concept-method-normalize">dfn for method</a><span>, in §2.2.1</span>
    </ul>
   <li><a href="#dom-requestcache-no-store">"no-store"</a><span>, in §5.3</span>
   <li><a href="#null-body-status">null body status</a><span>, in §2.2.3</span>
   <li><a href="#dom-requestdestination-object">"object"</a><span>, in §5.3</span>
   <li><a href="#concept-connection-obtain">obtain a connection</a><span>, in §2.5</span>
   <li><a href="#concept-websocket-connection-obtain">obtain a WebSocket connection</a><span>, in §6.1</span>
   <li><a href="#dom-response-ok">ok</a><span>, in §5.4</span>
   <li><a href="#ok-status">ok status</a><span>, in §2.2.3</span>
   <li><a href="#dom-requestcredentials-omit">"omit"</a><span>, in §5.3</span>
   <li><a href="#dom-requestcache-only-if-cached">"only-if-cached"</a><span>, in §5.3</span>
   <li><a href="#dom-responsetype-opaque">"opaque"</a><span>, in §5.4</span>
   <li><a href="#concept-filtered-response-opaque">opaque filtered response</a><span>, in §2.2.6</span>
   <li><a href="#dom-responsetype-opaqueredirect">"opaqueredirect"</a><span>, in §5.4</span>
   <li><a href="#concept-filtered-response-opaque-redirect">opaque-redirect filtered response</a><span>, in §2.2.6</span>
   <li><a href="#http-origin">Origin</a><span>, in §3.1</span>
   <li><a href="#concept-request-origin">origin</a><span>, in §2.2.5</span>
   <li><a href="#concept-body-package-data">package data</a><span>, in §5.2</span>
   <li><a href="#dom-requestdestination-paintworklet">"paintworklet"</a><span>, in §5.3</span>
   <li><a href="#concept-request-parser-metadata">parser metadata</a><span>, in §2.2.5</span>
   <li><a href="#concept-potential-destination">potential destination</a><span>, in §2.2.7</span>
   <li><a href="#potential-navigation-or-subresource-request">potential-navigation-or-subresource request</a><span>, in §2.2.5</span>
   <li><a href="#no-cache-prevent-cache-control">prevent no-cache cache-control header modification flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-request-priority">priority</a><span>, in §2.2.5</span>
   <li><a href="#privileged-no-cors-request-header-name">privileged no-CORS request-header name</a><span>, in §2.2.2</span>
   <li><a href="#process-request-body">process request body</a><span>, in §2</span>
   <li><a href="#process-request-end-of-body">process request end-of-body</a><span>, in §2</span>
   <li><a href="#process-response">process response</a><span>, in §2</span>
   <li><a href="#process-response-done">process response done</a><span>, in §2</span>
   <li><a href="#process-response-end-of-body">process response end-of-body</a><span>, in §2</span>
   <li><a href="#proxy-authentication-entry">proxy-authentication entry</a><span>, in §2.3</span>
   <li><a href="#queue-a-fetch-request-done-task">queue a fetch-request-done task</a><span>, in §2</span>
   <li><a href="#queue-a-fetch-task">queue a fetch task</a><span>, in §2</span>
   <li><a href="#concept-response-range-requested-flag">range-requested flag</a><span>, in §2.2.6</span>
   <li><a href="#concept-readablestream-readable">readable</a><span>, in §2.8.1</span>
   <li><a href="#concept-readablestream">ReadableStream</a><span>, in §2.8.1</span>
   <li><a href="#concept-read-chunk-from-readablestream">read a chunk</a><span>, in §2.8.1</span>
   <li><a href="#concept-read-all-bytes-from-readablestream">read all bytes</a><span>, in §2.8.1</span>
   <li>
    redirect
    <ul>
     <li><a href="#dom-request-redirect">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-requestinit-redirect">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-request-redirect-count">redirect count</a><span>, in §2.2.5</span>
   <li><a href="#dom-response-redirected">redirected</a><span>, in §5.4</span>
   <li><a href="#concept-request-redirect-mode">redirect mode</a><span>, in §2.2.5</span>
   <li><a href="#redirect-status">redirect status</a><span>, in §2.2.3</span>
   <li><a href="#dom-response-redirect">redirect(url)</a><span>, in §5.4</span>
   <li><a href="#dom-response-redirect">redirect(url, status)</a><span>, in §5.4</span>
   <li>
    referrer
    <ul>
     <li><a href="#dom-request-referrer">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#concept-request-referrer">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#dom-requestinit-referrer">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-request-referrer-policy">referrer policy</a><span>, in §2.2.5</span>
   <li>
    referrerPolicy
    <ul>
     <li><a href="#dom-request-referrerpolicy">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-requestinit-referrerpolicy">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#dom-requestcache-reload">"reload"</a><span>, in §5.3</span>
   <li><a href="#concept-request-reload-navigation-flag">reload-navigation flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-headers-remove-privileged-no-cors-request-headers">remove privileged no-CORS request headers</a><span>, in §5.1</span>
   <li><a href="#concept-request-replaces-client-id">replaces client id</a><span>, in §2.2.5</span>
   <li><a href="#dom-requestdestination-report">"report"</a><span>, in §5.3</span>
   <li><a href="#request">Request</a><span>, in §5.3</span>
   <li>
    request
    <ul>
     <li><a href="#concept-request">definition of</a><span>, in §2.2.5</span>
     <li><a href="#concept-request-request">dfn for Request</a><span>, in §5.3</span>
     <li><a href="#concept-fetch-record-request">dfn for fetch record</a><span>, in §2.4</span>
    </ul>
   <li><a href="#request-body-header-name">request-body-header name</a><span>, in §2.2.2</span>
   <li><a href="#requestcache">RequestCache</a><span>, in §5.3</span>
   <li><a href="#requestcredentials">RequestCredentials</a><span>, in §5.3</span>
   <li><a href="#requestdestination">RequestDestination</a><span>, in §5.3</span>
   <li><a href="#requestinfo">RequestInfo</a><span>, in §5.3</span>
   <li><a href="#requestinit">RequestInit</a><span>, in §5.3</span>
   <li><a href="#dom-request">Request(input)</a><span>, in §5.3</span>
   <li><a href="#dom-request">Request(input, init)</a><span>, in §5.3</span>
   <li><a href="#requestmode">RequestMode</a><span>, in §5.3</span>
   <li><a href="#requestredirect">RequestRedirect</a><span>, in §5.3</span>
   <li><a href="#concept-request-reserved-client">reserved client</a><span>, in §2.2.5</span>
   <li><a href="#response">Response</a><span>, in §5.4</span>
   <li>
    response
    <ul>
     <li><a href="#concept-response">definition of</a><span>, in §2.2.6</span>
     <li><a href="#concept-response-response">dfn for Response</a><span>, in §5.4</span>
    </ul>
   <li><a href="#dom-response">Response()</a><span>, in §5.4</span>
   <li><a href="#dom-response">Response(body)</a><span>, in §5.4</span>
   <li><a href="#dom-response">Response(body, init)</a><span>, in §5.4</span>
   <li><a href="#responseinit">ResponseInit</a><span>, in §5.4</span>
   <li><a href="#concept-request-response-tainting">response tainting</a><span>, in §2.2.5</span>
   <li><a href="#responsetype">ResponseType</a><span>, in §5.4</span>
   <li><a href="#response-url">response URL</a><span>, in §2.1</span>
   <li><a href="#concept-fetch-resume">resumed</a><span>, in §4</span>
   <li><a href="#bodyinit-safely-extract">safely extract</a><span>, in §5.2</span>
   <li>
    "same-origin"
    <ul>
     <li><a href="#dom-requestcredentials-same-origin">enum-value for RequestCredentials</a><span>, in §5.3</span>
     <li><a href="#dom-requestmode-same-origin">enum-value for RequestMode</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-scheme-fetch">scheme fetch</a><span>, in §4.2</span>
   <li><a href="#dom-requestdestination-script">"script"</a><span>, in §5.3</span>
   <li><a href="#request-destination-script-like">script-like</a><span>, in §2.2.5</span>
   <li><a href="#serialize-an-integer">serialize an integer</a><span>, in §2</span>
   <li><a href="#serializing-a-request-origin">Serializing a request origin</a><span>, in §2.2.5</span>
   <li><a href="#request-service-workers-mode">service-workers mode</a><span>, in §2.2.5</span>
   <li><a href="#concept-header-list-set">set</a><span>, in §2.2.2</span>
   <li><a href="#concept-header-list-set-structured-header">set a structured header</a><span>, in §2.2.2</span>
   <li><a href="#dom-headers-set">set(name, value)</a><span>, in §5.1</span>
   <li><a href="#dom-requestdestination-sharedworker">"sharedworker"</a><span>, in §5.3</span>
   <li><a href="#should-response-to-request-be-blocked-due-to-mime-type?">should response to request be blocked due to mime type</a><span>, in §2.6</span>
   <li><a href="#should-response-to-request-be-blocked-due-to-nosniff?">should response to request be blocked due to nosniff</a><span>, in §3.4</span>
   <li>
    signal
    <ul>
     <li><a href="#dom-request-signal">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#request-signal">dfn for Request</a><span>, in §5.3</span>
     <li><a href="#dom-requestinit-signal">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#concept-header-list-sort-and-combine">sort and combine</a><span>, in §2.2.2</span>
   <li><a href="#concept-body-source">source</a><span>, in §2.2.4</span>
   <li><a href="#concept-stale-response">stale response</a><span>, in §2.2.6</span>
   <li><a href="#concept-stale-while-revalidate-response">stale-while-revalidate response</a><span>, in §2.2.6</span>
   <li>
    status
    <ul>
     <li><a href="#dom-response-status">attribute for Response</a><span>, in §5.4</span>
     <li><a href="#concept-status">definition of</a><span>, in §2.2.3</span>
     <li><a href="#concept-response-status">dfn for response</a><span>, in §2.2.6</span>
     <li><a href="#dom-responseinit-status">dict-member for ResponseInit</a><span>, in §5.4</span>
    </ul>
   <li><a href="#concept-response-status-message">status message</a><span>, in §2.2.6</span>
   <li>
    statusText
    <ul>
     <li><a href="#dom-response-statustext">attribute for Response</a><span>, in §5.4</span>
     <li><a href="#dom-responseinit-statustext">dict-member for ResponseInit</a><span>, in §5.4</span>
    </ul>
   <li><a href="#concept-body-stream">stream</a><span>, in §2.2.4</span>
   <li><a href="#dom-requestdestination-style">"style"</a><span>, in §5.3</span>
   <li><a href="#subresource-request">subresource request</a><span>, in §2.2.5</span>
   <li><a href="#concept-fetch-suspend">suspend</a><span>, in §4</span>
   <li><a href="#synchronous-flag">synchronous flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-request-tainted-origin">tainted origin flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-tao-check">TAO check</a><span>, in §4.10</span>
   <li><a href="#concept-tee-readablestream">tee</a><span>, in §2.8.1</span>
   <li>
    terminated
    <ul>
     <li><a href="#concept-fetch-terminate">dfn for fetch</a><span>, in §4</span>
     <li><a href="#concept-fetch-group-terminate">dfn for fetch group</a><span>, in §2.4</span>
    </ul>
   <li><a href="#dom-body-text">text()</a><span>, in §5.2</span>
   <li><a href="#the-websocket-connection-is-established">the WebSocket connection is established</a><span>, in §6.2</span>
   <li><a href="#timing-allow-failed">timing allow failed flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-response-timing-allow-passed">timing allow passed flag</a><span>, in §2.2.6</span>
   <li><a href="#concept-body-total-bytes">total bytes</a><span>, in §2.2.4</span>
   <li><a href="#dom-requestdestination-track">"track"</a><span>, in §5.3</span>
   <li><a href="#concept-potential-destination-translate">translate</a><span>, in §2.2.7</span>
   <li><a href="#concept-request-transmit-body">transmit body</a><span>, in §2.2.5</span>
   <li><a href="#concept-body-transmitted">transmitted bytes</a><span>, in §2.2.4</span>
   <li>
    type
    <ul>
     <li><a href="#dom-response-type">attribute for Response</a><span>, in §5.4</span>
     <li><a href="#concept-response-type">dfn for response</a><span>, in §2.2.6</span>
    </ul>
   <li><a href="#unsafe-request-flag">unsafe-request flag</a><span>, in §2.2.5</span>
   <li>
    URL
    <ul>
     <li><a href="#concept-cache-url">dfn for cache entry</a><span>, in §4.8</span>
     <li><a href="#concept-request-url">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#concept-response-url">dfn for response</a><span>, in §2.2.6</span>
    </ul>
   <li>
    url
    <ul>
     <li><a href="#dom-request-url">attribute for Request</a><span>, in §5.3</span>
     <li><a href="#dom-response-url">attribute for Response</a><span>, in §5.4</span>
    </ul>
   <li>
    URL list
    <ul>
     <li><a href="#concept-request-url-list">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#concept-response-url-list">dfn for response</a><span>, in §2.2.6</span>
    </ul>
   <li><a href="#use-cors-preflight-flag">use-CORS-preflight flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-request-use-url-credentials-flag">use-URL-credentials flag</a><span>, in §2.2.5</span>
   <li><a href="#concept-header-value">value</a><span>, in §2.2.2</span>
   <li><a href="#dom-requestdestination-video">"video"</a><span>, in §5.3</span>
   <li><a href="#concept-body-wait">wait</a><span>, in §2.2.4</span>
   <li>
    window
    <ul>
     <li><a href="#concept-request-window">dfn for request</a><span>, in §2.2.5</span>
     <li><a href="#dom-requestinit-window">dict-member for RequestInit</a><span>, in §5.3</span>
    </ul>
   <li><a href="#dom-requestdestination-worker">"worker"</a><span>, in §5.3</span>
   <li><a href="#http-x-content-type-options">X-Content-Type-Options</a><span>, in §3.4</span>
   <li><a href="#dom-requestdestination-xslt">"xslt"</a><span>, in §5.3</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-abortsignal">
   <a href="https://dom.spec.whatwg.org/#abortsignal">https://dom.spec.whatwg.org/#abortsignal</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abortsignal">5.3. Request class</a> <a href="#ref-for-abortsignal①">(2)</a> <a href="#ref-for-abortsignal②">(3)</a> <a href="#ref-for-abortsignal③">(4)</a> <a href="#ref-for-abortsignal④">(5)</a> <a href="#ref-for-abortsignal⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-abortsignal-aborted-flag">
   <a href="https://dom.spec.whatwg.org/#abortsignal-aborted-flag">https://dom.spec.whatwg.org/#abortsignal-aborted-flag</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abortsignal-aborted-flag">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-abortsignal-add">
   <a href="https://dom.spec.whatwg.org/#abortsignal-add">https://dom.spec.whatwg.org/#abortsignal-add</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abortsignal-add">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-context-object">
   <a href="https://dom.spec.whatwg.org/#context-object">https://dom.spec.whatwg.org/#context-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-context-object">5.1. Headers class</a> <a href="#ref-for-context-object①">(2)</a> <a href="#ref-for-context-object②">(3)</a> <a href="#ref-for-context-object③">(4)</a> <a href="#ref-for-context-object④">(5)</a> <a href="#ref-for-context-object⑤">(6)</a> <a href="#ref-for-context-object⑥">(7)</a> <a href="#ref-for-context-object⑦">(8)</a> <a href="#ref-for-context-object⑧">(9)</a> <a href="#ref-for-context-object⑨">(10)</a> <a href="#ref-for-context-object①⓪">(11)</a> <a href="#ref-for-context-object①①">(12)</a> <a href="#ref-for-context-object①②">(13)</a> <a href="#ref-for-context-object①③">(14)</a> <a href="#ref-for-context-object①④">(15)</a> <a href="#ref-for-context-object①⑤">(16)</a> <a href="#ref-for-context-object①⑥">(17)</a> <a href="#ref-for-context-object①⑦">(18)</a> <a href="#ref-for-context-object①⑧">(19)</a>
    <li><a href="#ref-for-context-object①⑨">5.3. Request class</a> <a href="#ref-for-context-object②⓪">(2)</a> <a href="#ref-for-context-object②①">(3)</a> <a href="#ref-for-context-object②②">(4)</a> <a href="#ref-for-context-object②③">(5)</a> <a href="#ref-for-context-object②④">(6)</a> <a href="#ref-for-context-object②⑤">(7)</a> <a href="#ref-for-context-object②⑥">(8)</a> <a href="#ref-for-context-object②⑦">(9)</a> <a href="#ref-for-context-object②⑧">(10)</a> <a href="#ref-for-context-object②⑨">(11)</a> <a href="#ref-for-context-object③⓪">(12)</a> <a href="#ref-for-context-object③①">(13)</a> <a href="#ref-for-context-object③②">(14)</a> <a href="#ref-for-context-object③③">(15)</a> <a href="#ref-for-context-object③④">(16)</a> <a href="#ref-for-context-object③⑤">(17)</a> <a href="#ref-for-context-object③⑥">(18)</a> <a href="#ref-for-context-object③⑦">(19)</a> <a href="#ref-for-context-object③⑧">(20)</a> <a href="#ref-for-context-object③⑨">(21)</a>
    <li><a href="#ref-for-context-object④⓪">5.4. Response class</a> <a href="#ref-for-context-object④①">(2)</a> <a href="#ref-for-context-object④②">(3)</a> <a href="#ref-for-context-object④③">(4)</a> <a href="#ref-for-context-object④④">(5)</a> <a href="#ref-for-context-object④⑤">(6)</a> <a href="#ref-for-context-object④⑥">(7)</a> <a href="#ref-for-context-object④⑦">(8)</a> <a href="#ref-for-context-object④⑧">(9)</a> <a href="#ref-for-context-object④⑨">(10)</a> <a href="#ref-for-context-object⑤⓪">(11)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-abortsignal-follow">
   <a href="https://dom.spec.whatwg.org/#abortsignal-follow">https://dom.spec.whatwg.org/#abortsignal-follow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abortsignal-follow">5.3. Request class</a> <a href="#ref-for-abortsignal-follow①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-utf-8">
   <a href="https://encoding.spec.whatwg.org/#utf-8">https://encoding.spec.whatwg.org/#utf-8</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-utf-8">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-utf-8-decode">
   <a href="https://encoding.spec.whatwg.org/#utf-8-decode">https://encoding.spec.whatwg.org/#utf-8-decode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-utf-8-decode">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-utf-8-decode-without-bom">
   <a href="https://encoding.spec.whatwg.org/#utf-8-decode-without-bom">https://encoding.spec.whatwg.org/#utf-8-decode-without-bom</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-utf-8-decode-without-bom">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-utf-8-encode">
   <a href="https://encoding.spec.whatwg.org/#utf-8-encode">https://encoding.spec.whatwg.org/#utf-8-encode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-utf-8-encode">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-Blob">
   <a href="https://w3c.github.io/FileAPI/#dfn-Blob">https://w3c.github.io/FileAPI/#dfn-Blob</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-Blob">4.2. Scheme fetch</a>
    <li><a href="#ref-for-dfn-Blob①">5. Fetch API</a>
    <li><a href="#ref-for-dfn-Blob②">5.2. Body mixin</a> <a href="#ref-for-dfn-Blob③">(2)</a> <a href="#ref-for-dfn-Blob④">(3)</a> <a href="#ref-for-dfn-Blob⑤">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-file">
   <a href="https://w3c.github.io/FileAPI/#dfn-file">https://w3c.github.io/FileAPI/#dfn-file</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-file">5.2. Body mixin</a> <a href="#ref-for-dfn-file①">(2)</a> <a href="#ref-for-dfn-file②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-name">
   <a href="https://w3c.github.io/FileAPI/#dfn-name">https://w3c.github.io/FileAPI/#dfn-name</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-name">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-blob-url-entry-object">
   <a href="https://w3c.github.io/FileAPI/#blob-url-entry-object">https://w3c.github.io/FileAPI/#blob-url-entry-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-blob-url-entry-object">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readOperation">
   <a href="https://w3c.github.io/FileAPI/#readOperation">https://w3c.github.io/FileAPI/#readOperation</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readOperation">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-size">
   <a href="https://w3c.github.io/FileAPI/#dfn-size">https://w3c.github.io/FileAPI/#dfn-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-size">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-type">
   <a href="https://w3c.github.io/FileAPI/#dfn-type">https://w3c.github.io/FileAPI/#dfn-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-type">4.2. Scheme fetch</a>
    <li><a href="#ref-for-dfn-type①">5.2. Body mixin</a> <a href="#ref-for-dfn-type②">(2)</a> <a href="#ref-for-dfn-type③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-4.2">
   <a href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-4.2">https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-4.2</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-4.2">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-4.1">
   <a href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-4.1">https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-4.1</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-4.1">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-2">
   <a href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-2">https://tools.ietf.org/html/draft-ietf-httpbis-header-structure#section-2</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-2">2.2.2. Headers</a> <a href="#ref-for-section-2①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-websocket">
   <a href="https://html.spec.whatwg.org/multipage/web-sockets.html#websocket">https://html.spec.whatwg.org/multipage/web-sockets.html#websocket</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-websocket">5.6. Garbage collection</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#window">https://html.spec.whatwg.org/multipage/window-object.html#window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-window">2.2.5. Requests</a>
    <li><a href="#ref-for-window①">4. Fetching</a>
    <li><a href="#ref-for-window②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-windoworworkerglobalscope">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#windoworworkerglobalscope">https://html.spec.whatwg.org/multipage/webappapis.html#windoworworkerglobalscope</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-windoworworkerglobalscope">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-active-document">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#active-document">https://html.spec.whatwg.org/multipage/browsers.html#active-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-active-document">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ancestor-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#ancestor-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#ancestor-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ancestor-browsing-context">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-api-base-url">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#api-base-url">https://html.spec.whatwg.org/multipage/webappapis.html#api-base-url</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-api-base-url">5.3. Request class</a>
    <li><a href="#ref-for-api-base-url①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-serialisation-of-an-origin">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#ascii-serialisation-of-an-origin">https://html.spec.whatwg.org/multipage/origin.html#ascii-serialisation-of-an-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-serialisation-of-an-origin">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-environment-creation-url">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-creation-url">https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-creation-url</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-environment-creation-url">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-current-settings-object">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object">https://html.spec.whatwg.org/multipage/webappapis.html#current-settings-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-current-settings-object">5.3. Request class</a> <a href="#ref-for-current-settings-object①">(2)</a> <a href="#ref-for-current-settings-object②">(3)</a>
    <li><a href="#ref-for-current-settings-object③">5.4. Response class</a> <a href="#ref-for-current-settings-object④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-downloading-hyperlinks">
   <a href="https://html.spec.whatwg.org/multipage/links.html#downloading-hyperlinks">https://html.spec.whatwg.org/multipage/links.html#downloading-hyperlinks</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-downloading-hyperlinks">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-environment">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#environment">https://html.spec.whatwg.org/multipage/webappapis.html#environment</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-environment">2.2.5. Requests</a> <a href="#ref-for-environment①">(2)</a>
    <li><a href="#ref-for-environment②">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-environment-settings-object">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object">https://html.spec.whatwg.org/multipage/webappapis.html#environment-settings-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-environment-settings-object">2.2. HTTP</a>
    <li><a href="#ref-for-environment-settings-object①">2.2.5. Requests</a> <a href="#ref-for-environment-settings-object②">(2)</a> <a href="#ref-for-environment-settings-object③">(3)</a> <a href="#ref-for-environment-settings-object④">(4)</a> <a href="#ref-for-environment-settings-object⑤">(5)</a> <a href="#ref-for-environment-settings-object⑥">(6)</a> <a href="#ref-for-environment-settings-object⑦">(7)</a>
    <li><a href="#ref-for-environment-settings-object⑧">2.4. Fetch groups</a>
    <li><a href="#ref-for-environment-settings-object⑨">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-environment-settings-object①⓪">(2)</a>
    <li><a href="#ref-for-environment-settings-object①①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-environment-settings-object①②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-form-element">
   <a href="https://html.spec.whatwg.org/multipage/forms.html#the-form-element">https://html.spec.whatwg.org/multipage/forms.html#the-form-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-form-element">3.2. CORS protocol</a>
    <li><a href="#ref-for-the-form-element①">3.2.1. General</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-settings-object-global">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global">https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-global</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-settings-object-global">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-settings-object-global①">4. Fetching</a>
    <li><a href="#ref-for-concept-settings-object-global②">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-https-state">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#https-state">https://html.spec.whatwg.org/multipage/webappapis.html#https-state</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-https-state">2.2. HTTP</a>
    <li><a href="#ref-for-https-state①">4.2. Scheme fetch</a> <a href="#ref-for-https-state②">(2)</a> <a href="#ref-for-https-state③">(3)</a>
    <li><a href="#ref-for-https-state④">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-environment-id">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-id">https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-id</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-environment-id">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-in-parallel">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel">https://html.spec.whatwg.org/multipage/infrastructure.html#in-parallel</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-in-parallel">2.2.5. Requests</a>
    <li><a href="#ref-for-in-parallel①">4.1. Main fetch</a> <a href="#ref-for-in-parallel②">(2)</a>
    <li><a href="#ref-for-in-parallel③">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-in-parallel④">4.6. HTTP-network fetch</a> <a href="#ref-for-in-parallel⑤">(2)</a>
    <li><a href="#ref-for-in-parallel⑥">5.2. Body mixin</a>
    <li><a href="#ref-for-in-parallel⑦">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-multipart/form-data-boundary-string">
   <a href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-boundary-string">https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-boundary-string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-multipart/form-data-boundary-string">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-multipart/form-data-encoding-algorithm">
   <a href="https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-encoding-algorithm">https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#multipart/form-data-encoding-algorithm</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-multipart/form-data-encoding-algorithm">5.2. Body mixin</a> <a href="#ref-for-multipart/form-data-encoding-algorithm①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-navigate">
   <a href="https://html.spec.whatwg.org/multipage/browsing-the-web.html#navigate">https://html.spec.whatwg.org/multipage/browsing-the-web.html#navigate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-navigate">2.2.5. Requests</a>
    <li><a href="#ref-for-navigate①">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-nested-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context">https://html.spec.whatwg.org/multipage/browsers.html#nested-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-nested-browsing-context">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-networking-task-source">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#networking-task-source">https://html.spec.whatwg.org/multipage/webappapis.html#networking-task-source</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-networking-task-source">2. Infrastructure</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-origin-opaque">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin-opaque">https://html.spec.whatwg.org/multipage/origin.html#concept-origin-opaque</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-origin-opaque">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-settings-object-origin">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin">https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-settings-object-origin">4. Fetching</a>
    <li><a href="#ref-for-concept-settings-object-origin①">5.3. Request class</a> <a href="#ref-for-concept-settings-object-origin②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-queue-a-task">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task">https://html.spec.whatwg.org/multipage/webappapis.html#queue-a-task</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-queue-a-task">2. Infrastructure</a> <a href="#ref-for-queue-a-task①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-settings-object-referrer-policy">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-referrer-policy">https://html.spec.whatwg.org/multipage/webappapis.html#concept-settings-object-referrer-policy</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-settings-object-referrer-policy">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-media-load-resource">
   <a href="https://html.spec.whatwg.org/multipage/media.html#concept-media-load-resource">https://html.spec.whatwg.org/multipage/media.html#concept-media-load-resource</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-media-load-resource">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-responsible-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context">https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-responsible-browsing-context">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-responsible-event-loop">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-event-loop">https://html.spec.whatwg.org/multipage/webappapis.html#responsible-event-loop</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-responsible-event-loop">2. Infrastructure</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-same-origin">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#same-origin">https://html.spec.whatwg.org/multipage/origin.html#same-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-same-origin">3.1. `Origin` header</a>
    <li><a href="#ref-for-same-origin①">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-same-origin②">4.1. Main fetch</a>
    <li><a href="#ref-for-same-origin③">4.4. HTTP-redirect fetch</a> <a href="#ref-for-same-origin④">(2)</a> <a href="#ref-for-same-origin⑤">(3)</a>
    <li><a href="#ref-for-same-origin⑥">5.3. Request class</a> <a href="#ref-for-same-origin⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-schemelessly-same-site">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#schemelessly-same-site">https://html.spec.whatwg.org/multipage/origin.html#schemelessly-same-site</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-schemelessly-same-site">3.6. `Cross-Origin-Resource-Policy` header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-environment-target-browsing-context">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-target-browsing-context">https://html.spec.whatwg.org/multipage/webappapis.html#concept-environment-target-browsing-context</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-environment-target-browsing-context">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-environment-target-browsing-context①">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-task">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-task">https://html.spec.whatwg.org/multipage/webappapis.html#concept-task</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-task">2. Infrastructure</a>
    <li><a href="#ref-for-concept-task①">4. Fetching</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-origin-tuple">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin-tuple">https://html.spec.whatwg.org/multipage/origin.html#concept-origin-tuple</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-origin-tuple">3.1. `Origin` header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-3.2">
   <a href="https://tools.ietf.org/html/rfc7230#section-3.2">https://tools.ietf.org/html/rfc7230#section-3.2</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-3.2">2.2.2. Headers</a>
    <li><a href="#ref-for-section-3.2①">3.2.4. HTTP new-header syntax</a> <a href="#ref-for-section-3.2②">(2)</a> <a href="#ref-for-section-3.2③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-3.1.1">
   <a href="https://tools.ietf.org/html/rfc7230#section-3.1.1">https://tools.ietf.org/html/rfc7230#section-3.1.1</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-3.1.1">2.2.1. Methods</a>
    <li><a href="#ref-for-section-3.1.1①">3.2.4. HTTP new-header syntax</a> <a href="#ref-for-section-3.1.1②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-3.1.2">
   <a href="https://tools.ietf.org/html/rfc7230#section-3.1.2">https://tools.ietf.org/html/rfc7230#section-3.1.2</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-3.1.2">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-section-1.2.1">
   <a href="https://tools.ietf.org/html/rfc7234#section-1.2.1">https://tools.ietf.org/html/rfc7234#section-1.2.1</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-section-1.2.1">3.2.4. HTTP new-header syntax</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-abort-when">
   <a href="https://infra.spec.whatwg.org/#abort-when">https://infra.spec.whatwg.org/#abort-when</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abort-when">2.2.5. Requests</a>
    <li><a href="#ref-for-abort-when①">2.5. Connections</a>
    <li><a href="#ref-for-abort-when②">4. Fetching</a>
    <li><a href="#ref-for-abort-when③">4.1. Main fetch</a>
    <li><a href="#ref-for-abort-when④">4.2. Scheme fetch</a>
    <li><a href="#ref-for-abort-when⑤">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-abort-when⑥">4.6. HTTP-network fetch</a> <a href="#ref-for-abort-when⑦">(2)</a> <a href="#ref-for-abort-when⑧">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-set-append">
   <a href="https://infra.spec.whatwg.org/#set-append">https://infra.spec.whatwg.org/#set-append</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-append">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-case-insensitive">
   <a href="https://infra.spec.whatwg.org/#ascii-case-insensitive">https://infra.spec.whatwg.org/#ascii-case-insensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-case-insensitive">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-ascii-case-insensitive①">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-whitespace">
   <a href="https://infra.spec.whatwg.org/#ascii-whitespace">https://infra.spec.whatwg.org/#ascii-whitespace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-whitespace">2.2. HTTP</a> <a href="#ref-for-ascii-whitespace①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-break">
   <a href="https://infra.spec.whatwg.org/#iteration-break">https://infra.spec.whatwg.org/#iteration-break</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-break">2.2. HTTP</a> <a href="#ref-for-iteration-break①">(2)</a> <a href="#ref-for-iteration-break②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-byte-less-than">
   <a href="https://infra.spec.whatwg.org/#byte-less-than">https://infra.spec.whatwg.org/#byte-less-than</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-less-than">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-byte-sequence">
   <a href="https://infra.spec.whatwg.org/#byte-sequence">https://infra.spec.whatwg.org/#byte-sequence</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-sequence">2.2.2. Headers</a> <a href="#ref-for-byte-sequence①">(2)</a> <a href="#ref-for-byte-sequence②">(3)</a>
    <li><a href="#ref-for-byte-sequence③">2.2.5. Requests</a>
    <li><a href="#ref-for-byte-sequence④">4.8. CORS-preflight cache</a>
    <li><a href="#ref-for-byte-sequence⑤">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-byte-case-insensitive">
   <a href="https://infra.spec.whatwg.org/#byte-case-insensitive">https://infra.spec.whatwg.org/#byte-case-insensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-case-insensitive">2.2.1. Methods</a> <a href="#ref-for-byte-case-insensitive①">(2)</a>
    <li><a href="#ref-for-byte-case-insensitive②">2.2.2. Headers</a> <a href="#ref-for-byte-case-insensitive③">(2)</a> <a href="#ref-for-byte-case-insensitive④">(3)</a> <a href="#ref-for-byte-case-insensitive⑤">(4)</a> <a href="#ref-for-byte-case-insensitive⑥">(5)</a> <a href="#ref-for-byte-case-insensitive⑦">(6)</a> <a href="#ref-for-byte-case-insensitive⑧">(7)</a> <a href="#ref-for-byte-case-insensitive⑨">(8)</a> <a href="#ref-for-byte-case-insensitive①⓪">(9)</a> <a href="#ref-for-byte-case-insensitive①①">(10)</a> <a href="#ref-for-byte-case-insensitive①②">(11)</a> <a href="#ref-for-byte-case-insensitive①③">(12)</a>
    <li><a href="#ref-for-byte-case-insensitive①④">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-byte-case-insensitive①⑤">4.7. CORS-preflight fetch</a> <a href="#ref-for-byte-case-insensitive①⑥">(2)</a>
    <li><a href="#ref-for-byte-case-insensitive①⑦">4.8. CORS-preflight cache</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-byte-lowercase">
   <a href="https://infra.spec.whatwg.org/#byte-lowercase">https://infra.spec.whatwg.org/#byte-lowercase</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-lowercase">2.2.2. Headers</a> <a href="#ref-for-byte-lowercase①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-byte-uppercase">
   <a href="https://infra.spec.whatwg.org/#byte-uppercase">https://infra.spec.whatwg.org/#byte-uppercase</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-uppercase">2.2.1. Methods</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-clone">
   <a href="https://infra.spec.whatwg.org/#list-clone">https://infra.spec.whatwg.org/#list-clone</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-clone">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-code-point">
   <a href="https://infra.spec.whatwg.org/#code-point">https://infra.spec.whatwg.org/#code-point</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-code-point">2.2. HTTP</a> <a href="#ref-for-code-point①">(2)</a> <a href="#ref-for-code-point②">(3)</a> <a href="#ref-for-code-point③">(4)</a>
    <li><a href="#ref-for-code-point④">2.2.2. Headers</a> <a href="#ref-for-code-point⑤">(2)</a>
    <li><a href="#ref-for-code-point⑥">7. data: URLs</a> <a href="#ref-for-code-point⑦">(2)</a> <a href="#ref-for-code-point⑧">(3)</a> <a href="#ref-for-code-point⑨">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-collect-a-sequence-of-code-points">
   <a href="https://infra.spec.whatwg.org/#collect-a-sequence-of-code-points">https://infra.spec.whatwg.org/#collect-a-sequence-of-code-points</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-collect-a-sequence-of-code-points">2.2. HTTP</a>
    <li><a href="#ref-for-collect-a-sequence-of-code-points①">2.2.2. Headers</a>
    <li><a href="#ref-for-collect-a-sequence-of-code-points②">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-contain">
   <a href="https://infra.spec.whatwg.org/#list-contain">https://infra.spec.whatwg.org/#list-contain</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-contain">2.2.2. Headers</a>
    <li><a href="#ref-for-list-contain①">4.10. TAO check</a> <a href="#ref-for-list-contain②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-continue">
   <a href="https://infra.spec.whatwg.org/#iteration-continue">https://infra.spec.whatwg.org/#iteration-continue</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-continue">2.2.2. Headers</a>
    <li><a href="#ref-for-iteration-continue①">3.3. `Content-Type` header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-exists">
   <a href="https://infra.spec.whatwg.org/#map-exists">https://infra.spec.whatwg.org/#map-exists</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-exists">3.3. `Content-Type` header</a> <a href="#ref-for-map-exists①">(2)</a>
    <li><a href="#ref-for-map-exists②">5.3. Request class</a> <a href="#ref-for-map-exists③">(2)</a> <a href="#ref-for-map-exists④">(3)</a> <a href="#ref-for-map-exists⑤">(4)</a> <a href="#ref-for-map-exists⑥">(5)</a> <a href="#ref-for-map-exists⑦">(6)</a> <a href="#ref-for-map-exists⑧">(7)</a> <a href="#ref-for-map-exists⑨">(8)</a> <a href="#ref-for-map-exists①⓪">(9)</a> <a href="#ref-for-map-exists①①">(10)</a> <a href="#ref-for-map-exists①②">(11)</a> <a href="#ref-for-map-exists①③">(12)</a> <a href="#ref-for-map-exists①④">(13)</a> <a href="#ref-for-map-exists①⑤">(14)</a> <a href="#ref-for-map-exists①⑥">(15)</a> <a href="#ref-for-map-exists①⑦">(16)</a>
    <li><a href="#ref-for-map-exists①⑧">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-iterate">
   <a href="https://infra.spec.whatwg.org/#map-iterate">https://infra.spec.whatwg.org/#map-iterate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-iterate">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-forgiving-base64-decode">
   <a href="https://infra.spec.whatwg.org/#forgiving-base64-decode">https://infra.spec.whatwg.org/#forgiving-base64-decode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-forgiving-base64-decode">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-forgiving-base64-encode">
   <a href="https://infra.spec.whatwg.org/#forgiving-base64-encode">https://infra.spec.whatwg.org/#forgiving-base64-encode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-forgiving-base64-encode">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-if-aborted">
   <a href="https://infra.spec.whatwg.org/#if-aborted">https://infra.spec.whatwg.org/#if-aborted</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-if-aborted">2.2.5. Requests</a>
    <li><a href="#ref-for-if-aborted①">2.5. Connections</a>
    <li><a href="#ref-for-if-aborted②">4. Fetching</a>
    <li><a href="#ref-for-if-aborted③">4.1. Main fetch</a>
    <li><a href="#ref-for-if-aborted④">4.2. Scheme fetch</a>
    <li><a href="#ref-for-if-aborted⑤">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-if-aborted⑥">4.6. HTTP-network fetch</a> <a href="#ref-for-if-aborted⑦">(2)</a> <a href="#ref-for-if-aborted⑧">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-is-empty">
   <a href="https://infra.spec.whatwg.org/#list-is-empty">https://infra.spec.whatwg.org/#list-is-empty</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-is-empty">4.1. Main fetch</a> <a href="#ref-for-list-is-empty①">(2)</a>
    <li><a href="#ref-for-list-is-empty②">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-is-empty">
   <a href="https://infra.spec.whatwg.org/#map-is-empty">https://infra.spec.whatwg.org/#map-is-empty</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-is-empty">5.3. Request class</a> <a href="#ref-for-map-is-empty①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-isomorphic-decode">
   <a href="https://infra.spec.whatwg.org/#isomorphic-decode">https://infra.spec.whatwg.org/#isomorphic-decode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-isomorphic-decode">2.2.2. Headers</a>
    <li><a href="#ref-for-isomorphic-decode①">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-isomorphic-encode">
   <a href="https://infra.spec.whatwg.org/#isomorphic-encode">https://infra.spec.whatwg.org/#isomorphic-encode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-isomorphic-encode">2.2.5. Requests</a> <a href="#ref-for-isomorphic-encode①">(2)</a> <a href="#ref-for-isomorphic-encode②">(3)</a>
    <li><a href="#ref-for-isomorphic-encode③">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-isomorphic-encode④">(2)</a>
    <li><a href="#ref-for-isomorphic-encode⑤">5.4. Response class</a>
    <li><a href="#ref-for-isomorphic-encode⑥">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-item">
   <a href="https://infra.spec.whatwg.org/#list-item">https://infra.spec.whatwg.org/#list-item</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-item">4.3. HTTP fetch</a>
    <li><a href="#ref-for-list-item①">4.7. CORS-preflight fetch</a> <a href="#ref-for-list-item②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-byte-sequence-length">
   <a href="https://infra.spec.whatwg.org/#byte-sequence-length">https://infra.spec.whatwg.org/#byte-sequence-length</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-sequence-length">2.2.2. Headers</a> <a href="#ref-for-byte-sequence-length①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list">
   <a href="https://infra.spec.whatwg.org/#list">https://infra.spec.whatwg.org/#list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list">2.2.2. Headers</a> <a href="#ref-for-list①">(2)</a> <a href="#ref-for-list②">(3)</a> <a href="#ref-for-list③">(4)</a> <a href="#ref-for-list④">(5)</a> <a href="#ref-for-list⑤">(6)</a> <a href="#ref-for-list⑥">(7)</a>
    <li><a href="#ref-for-list⑦">2.2.5. Requests</a>
    <li><a href="#ref-for-list⑧">2.2.6. Responses</a>
    <li><a href="#ref-for-list⑨">4.8. CORS-preflight cache</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ordered-set">
   <a href="https://infra.spec.whatwg.org/#ordered-set">https://infra.spec.whatwg.org/#ordered-set</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ordered-set">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parse-json-from-bytes">
   <a href="https://infra.spec.whatwg.org/#parse-json-from-bytes">https://infra.spec.whatwg.org/#parse-json-from-bytes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-json-from-bytes">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string-position-variable">
   <a href="https://infra.spec.whatwg.org/#string-position-variable">https://infra.spec.whatwg.org/#string-position-variable</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string-position-variable">2.2. HTTP</a>
    <li><a href="#ref-for-string-position-variable①">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-remove">
   <a href="https://infra.spec.whatwg.org/#list-remove">https://infra.spec.whatwg.org/#list-remove</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-remove">2.2.2. Headers</a> <a href="#ref-for-list-remove①">(2)</a>
    <li><a href="#ref-for-list-remove②">4.8. CORS-preflight cache</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-sort-in-ascending-order">
   <a href="https://infra.spec.whatwg.org/#list-sort-in-ascending-order">https://infra.spec.whatwg.org/#list-sort-in-ascending-order</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-sort-in-ascending-order">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string">
   <a href="https://infra.spec.whatwg.org/#string">https://infra.spec.whatwg.org/#string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string">2.2. HTTP</a>
    <li><a href="#ref-for-string①">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-strip-leading-and-trailing-ascii-whitespace">
   <a href="https://infra.spec.whatwg.org/#strip-leading-and-trailing-ascii-whitespace">https://infra.spec.whatwg.org/#strip-leading-and-trailing-ascii-whitespace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-strip-leading-and-trailing-ascii-whitespace">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-struct">
   <a href="https://infra.spec.whatwg.org/#struct">https://infra.spec.whatwg.org/#struct</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-struct">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mime-type-essence">
   <a href="https://mimesniff.spec.whatwg.org/#mime-type-essence">https://mimesniff.spec.whatwg.org/#mime-type-essence</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mime-type-essence">2.2.2. Headers</a>
    <li><a href="#ref-for-mime-type-essence①">2.7. Should
response to request be blocked due to its MIME type?</a> <a href="#ref-for-mime-type-essence②">(2)</a>
    <li><a href="#ref-for-mime-type-essence③">3.3. `Content-Type` header</a> <a href="#ref-for-mime-type-essence④">(2)</a> <a href="#ref-for-mime-type-essence⑤">(3)</a> <a href="#ref-for-mime-type-essence⑥">(4)</a>
    <li><a href="#ref-for-mime-type-essence⑦">3.4.1. Should
response to request be blocked due to nosniff?</a>
    <li><a href="#ref-for-mime-type-essence⑧">3.5. CORB</a>
    <li><a href="#ref-for-mime-type-essence⑨">5.2. Body mixin</a> <a href="#ref-for-mime-type-essence①⓪">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-html-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#html-mime-type">https://mimesniff.spec.whatwg.org/#html-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-html-mime-type">3.5. CORB</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-javascript-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#javascript-mime-type">https://mimesniff.spec.whatwg.org/#javascript-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-javascript-mime-type">3.4.1. Should
response to request be blocked due to nosniff?</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-json-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#json-mime-type">https://mimesniff.spec.whatwg.org/#json-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-json-mime-type">3.5. CORB</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#mime-type">https://mimesniff.spec.whatwg.org/#mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mime-type">2.2. HTTP</a>
    <li><a href="#ref-for-mime-type①">3.3. `Content-Type` header</a> <a href="#ref-for-mime-type②">(2)</a>
    <li><a href="#ref-for-mime-type③">3.5. CORB</a>
    <li><a href="#ref-for-mime-type④">5.2. Body mixin</a>
    <li><a href="#ref-for-mime-type⑤">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parameters">
   <a href="https://mimesniff.spec.whatwg.org/#parameters">https://mimesniff.spec.whatwg.org/#parameters</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parameters">3.3. `Content-Type` header</a> <a href="#ref-for-parameters①">(2)</a> <a href="#ref-for-parameters②">(3)</a> <a href="#ref-for-parameters③">(4)</a> <a href="#ref-for-parameters④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parse-a-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#parse-a-mime-type">https://mimesniff.spec.whatwg.org/#parse-a-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-mime-type">2.2. HTTP</a>
    <li><a href="#ref-for-parse-a-mime-type①">2.2.2. Headers</a>
    <li><a href="#ref-for-parse-a-mime-type②">3.3. `Content-Type` header</a>
    <li><a href="#ref-for-parse-a-mime-type③">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-serialize-a-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#serialize-a-mime-type">https://mimesniff.spec.whatwg.org/#serialize-a-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-mime-type">3.3. `Content-Type` header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-serialize-a-mime-type-to-bytes">
   <a href="https://mimesniff.spec.whatwg.org/#serialize-a-mime-type-to-bytes">https://mimesniff.spec.whatwg.org/#serialize-a-mime-type-to-bytes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-mime-type-to-bytes">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-xml-mime-type">
   <a href="https://mimesniff.spec.whatwg.org/#xml-mime-type">https://mimesniff.spec.whatwg.org/#xml-mime-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-xml-mime-type">3.5. CORB</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-enumdef-referrerpolicy">
   <a href="https://w3c.github.io/webappsec-referrer-policy/#enumdef-referrerpolicy">https://w3c.github.io/webappsec-referrer-policy/#enumdef-referrerpolicy</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-referrerpolicy">5.3. Request class</a> <a href="#ref-for-enumdef-referrerpolicy①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-determine-requests-referrer">
   <a href="https://w3c.github.io/webappsec-referrer-policy/#determine-requests-referrer">https://w3c.github.io/webappsec-referrer-policy/#determine-requests-referrer</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-determine-requests-referrer">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-referrer-policy">
   <a href="https://w3c.github.io/webappsec-referrer-policy/#referrer-policy">https://w3c.github.io/webappsec-referrer-policy/#referrer-policy</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-referrer-policy">2.2.5. Requests</a>
    <li><a href="#ref-for-referrer-policy①">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-set-requests-referrer-policy-on-redirect">
   <a href="https://w3c.github.io/webappsec-referrer-policy/#set-requests-referrer-policy-on-redirect">https://w3c.github.io/webappsec-referrer-policy/#set-requests-referrer-policy-on-redirect</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-requests-referrer-policy-on-redirect">4.4. HTTP-redirect fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-acquire-readable-stream-reader">
   <a href="https://streams.spec.whatwg.org/#acquire-readable-stream-reader">https://streams.spec.whatwg.org/#acquire-readable-stream-reader</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-acquire-readable-stream-reader">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-create-readable-stream">
   <a href="https://streams.spec.whatwg.org/#create-readable-stream">https://streams.spec.whatwg.org/#create-readable-stream</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-create-readable-stream">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-is-readable-stream-disturbed">
   <a href="https://streams.spec.whatwg.org/#is-readable-stream-disturbed">https://streams.spec.whatwg.org/#is-readable-stream-disturbed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-is-readable-stream-disturbed">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-is-readable-stream-locked">
   <a href="https://streams.spec.whatwg.org/#is-readable-stream-locked">https://streams.spec.whatwg.org/#is-readable-stream-locked</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-is-readable-stream-locked">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-cancel">
   <a href="https://streams.spec.whatwg.org/#readable-stream-cancel">https://streams.spec.whatwg.org/#readable-stream-cancel</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-cancel">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-default-controller-close">
   <a href="https://streams.spec.whatwg.org/#readable-stream-default-controller-close">https://streams.spec.whatwg.org/#readable-stream-default-controller-close</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-default-controller-close">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-default-controller-enqueue">
   <a href="https://streams.spec.whatwg.org/#readable-stream-default-controller-enqueue">https://streams.spec.whatwg.org/#readable-stream-default-controller-enqueue</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-default-controller-enqueue">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-default-controller-error">
   <a href="https://streams.spec.whatwg.org/#readable-stream-default-controller-error">https://streams.spec.whatwg.org/#readable-stream-default-controller-error</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-default-controller-error">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-default-controller-get-desired-size">
   <a href="https://streams.spec.whatwg.org/#readable-stream-default-controller-get-desired-size">https://streams.spec.whatwg.org/#readable-stream-default-controller-get-desired-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-default-controller-get-desired-size">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-default-reader-read">
   <a href="https://streams.spec.whatwg.org/#readable-stream-default-reader-read">https://streams.spec.whatwg.org/#readable-stream-default-reader-read</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-default-reader-read">2.8.1. ReadableStream</a> <a href="#ref-for-readable-stream-default-reader-read①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-pipe-to">
   <a href="https://streams.spec.whatwg.org/#readable-stream-pipe-to">https://streams.spec.whatwg.org/#readable-stream-pipe-to</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-pipe-to">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-stream-tee">
   <a href="https://streams.spec.whatwg.org/#readable-stream-tee">https://streams.spec.whatwg.org/#readable-stream-tee</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-stream-tee">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-chunk">
   <a href="https://streams.spec.whatwg.org/#chunk">https://streams.spec.whatwg.org/#chunk</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-chunk">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-rs-get-reader">
   <a href="https://streams.spec.whatwg.org/#rs-get-reader">https://streams.spec.whatwg.org/#rs-get-reader</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-rs-get-reader">5.6. Garbage collection</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-identity-transform-stream">
   <a href="https://streams.spec.whatwg.org/#identity-transform-stream">https://streams.spec.whatwg.org/#identity-transform-stream</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-identity-transform-stream">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-readable-side">
   <a href="https://streams.spec.whatwg.org/#readable-side">https://streams.spec.whatwg.org/#readable-side</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-readable-side">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-writable-side">
   <a href="https://streams.spec.whatwg.org/#writable-side">https://streams.spec.whatwg.org/#writable-side</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-writable-side">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-serviceworkerglobalscope">
   <a href="https://w3c.github.io/ServiceWorker/#serviceworkerglobalscope">https://w3c.github.io/ServiceWorker/#serviceworkerglobalscope</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serviceworkerglobalscope">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-service-worker-global-scope-fetch-event">
   <a href="https://w3c.github.io/ServiceWorker/#service-worker-global-scope-fetch-event">https://w3c.github.io/ServiceWorker/#service-worker-global-scope-fetch-event</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-service-worker-global-scope-fetch-event">2.2.5. Requests</a> <a href="#ref-for-service-worker-global-scope-fetch-event①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-handle-fetch">
   <a href="https://w3c.github.io/ServiceWorker/#handle-fetch">https://w3c.github.io/ServiceWorker/#handle-fetch</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-handle-fetch">2.2.5. Requests</a>
    <li><a href="#ref-for-handle-fetch①">4.3. HTTP fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-urlsearchparams">
   <a href="https://url.spec.whatwg.org/#urlsearchparams">https://url.spec.whatwg.org/#urlsearchparams</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-urlsearchparams">5.2. Body mixin</a> <a href="#ref-for-urlsearchparams①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-blob-entry">
   <a href="https://url.spec.whatwg.org/#concept-url-blob-entry">https://url.spec.whatwg.org/#concept-url-blob-entry</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-blob-entry">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-url-cannot-be-a-base-url-flag">
   <a href="https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag">https://url.spec.whatwg.org/#url-cannot-be-a-base-url-flag</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-url-cannot-be-a-base-url-flag">4.2. Scheme fetch</a>
    <li><a href="#ref-for-url-cannot-be-a-base-url-flag①">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-domain">
   <a href="https://url.spec.whatwg.org/#concept-domain">https://url.spec.whatwg.org/#concept-domain</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-domain">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-fragment">
   <a href="https://url.spec.whatwg.org/#concept-url-fragment">https://url.spec.whatwg.org/#concept-url-fragment</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-fragment">2.1. URL</a> <a href="#ref-for-concept-url-fragment①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-host">
   <a href="https://url.spec.whatwg.org/#concept-url-host">https://url.spec.whatwg.org/#concept-url-host</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-host">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-url-host①">4.1. Main fetch</a> <a href="#ref-for-concept-url-host②">(2)</a>
    <li><a href="#ref-for-concept-url-host③">6.1. Connections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-include-credentials">
   <a href="https://url.spec.whatwg.org/#include-credentials">https://url.spec.whatwg.org/#include-credentials</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-include-credentials">4.4. HTTP-redirect fetch</a> <a href="#ref-for-include-credentials①">(2)</a>
    <li><a href="#ref-for-include-credentials②">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-include-credentials③">(2)</a>
    <li><a href="#ref-for-include-credentials④">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-urlsearchparams-list">
   <a href="https://url.spec.whatwg.org/#concept-urlsearchparams-list">https://url.spec.whatwg.org/#concept-urlsearchparams-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-urlsearchparams-list">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-origin">
   <a href="https://url.spec.whatwg.org/#concept-url-origin">https://url.spec.whatwg.org/#concept-url-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-origin">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-url-origin①">3.6. `Cross-Origin-Resource-Policy` header</a> <a href="#ref-for-concept-url-origin②">(2)</a> <a href="#ref-for-concept-url-origin③">(3)</a>
    <li><a href="#ref-for-concept-url-origin④">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-url-origin⑤">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-url-origin⑥">(2)</a> <a href="#ref-for-concept-url-origin⑦">(3)</a> <a href="#ref-for-concept-url-origin⑧">(4)</a>
    <li><a href="#ref-for-concept-url-origin⑨">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-url-origin①⓪">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-path">
   <a href="https://url.spec.whatwg.org/#concept-url-path">https://url.spec.whatwg.org/#concept-url-path</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-path">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-url-path①">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-url-path②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-port">
   <a href="https://url.spec.whatwg.org/#concept-url-port">https://url.spec.whatwg.org/#concept-url-port</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-port">2.6. Port blocking</a> <a href="#ref-for-concept-url-port①">(2)</a>
    <li><a href="#ref-for-concept-url-port②">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-url-port③">6.1. Connections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-scheme">
   <a href="https://url.spec.whatwg.org/#concept-url-scheme">https://url.spec.whatwg.org/#concept-url-scheme</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-scheme">2.1. URL</a> <a href="#ref-for-concept-url-scheme①">(2)</a> <a href="#ref-for-concept-url-scheme②">(3)</a> <a href="#ref-for-concept-url-scheme③">(4)</a> <a href="#ref-for-concept-url-scheme④">(5)</a>
    <li><a href="#ref-for-concept-url-scheme⑤">2.6. Port blocking</a>
    <li><a href="#ref-for-concept-url-scheme⑥">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-url-scheme⑦">3.5. CORB</a>
    <li><a href="#ref-for-concept-url-scheme⑧">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-concept-url-scheme⑨">4.1. Main fetch</a> <a href="#ref-for-concept-url-scheme①⓪">(2)</a> <a href="#ref-for-concept-url-scheme①①">(3)</a> <a href="#ref-for-concept-url-scheme①②">(4)</a> <a href="#ref-for-concept-url-scheme①③">(5)</a> <a href="#ref-for-concept-url-scheme①④">(6)</a> <a href="#ref-for-concept-url-scheme①⑤">(7)</a> <a href="#ref-for-concept-url-scheme①⑥">(8)</a> <a href="#ref-for-concept-url-scheme①⑦">(9)</a>
    <li><a href="#ref-for-concept-url-scheme①⑧">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-url-scheme①⑨">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-url-scheme②⓪">5.3. Request class</a>
    <li><a href="#ref-for-concept-url-scheme②①">6.1. Connections</a>
    <li><a href="#ref-for-concept-url-scheme②②">6.2. Opening handshake</a> <a href="#ref-for-concept-url-scheme②③">(2)</a>
    <li><a href="#ref-for-concept-url-scheme②④">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-set-the-password">
   <a href="https://url.spec.whatwg.org/#set-the-password">https://url.spec.whatwg.org/#set-the-password</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-the-password">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-set-the-username">
   <a href="https://url.spec.whatwg.org/#set-the-username">https://url.spec.whatwg.org/#set-the-username</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-the-username">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string-percent-decode">
   <a href="https://url.spec.whatwg.org/#string-percent-decode">https://url.spec.whatwg.org/#string-percent-decode</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string-percent-decode">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url">
   <a href="https://url.spec.whatwg.org/#concept-url">https://url.spec.whatwg.org/#concept-url</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url">2.1. URL</a> <a href="#ref-for-concept-url①">(2)</a>
    <li><a href="#ref-for-concept-url②">2.2.5. Requests</a> <a href="#ref-for-concept-url③">(2)</a> <a href="#ref-for-concept-url④">(3)</a> <a href="#ref-for-concept-url⑤">(4)</a> <a href="#ref-for-concept-url⑥">(5)</a> <a href="#ref-for-concept-url⑦">(6)</a>
    <li><a href="#ref-for-concept-url⑧">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-url⑨">4.1. Main fetch</a> <a href="#ref-for-concept-url①⓪">(2)</a>
    <li><a href="#ref-for-concept-url①①">4.2. Scheme fetch</a> <a href="#ref-for-concept-url①②">(2)</a> <a href="#ref-for-concept-url①③">(3)</a>
    <li><a href="#ref-for-concept-url①④">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-url①⑤">4.8. CORS-preflight cache</a>
    <li><a href="#ref-for-concept-url①⑥">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-parser">
   <a href="https://url.spec.whatwg.org/#concept-url-parser">https://url.spec.whatwg.org/#concept-url-parser</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-parser">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-url-parser①">5.3. Request class</a> <a href="#ref-for-concept-url-parser②">(2)</a>
    <li><a href="#ref-for-concept-url-parser③">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-url-serializer">
   <a href="https://url.spec.whatwg.org/#concept-url-serializer">https://url.spec.whatwg.org/#concept-url-serializer</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-url-serializer">2.1. URL</a>
    <li><a href="#ref-for-concept-url-serializer①">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-url-serializer②">5.3. Request class</a> <a href="#ref-for-concept-url-serializer③">(2)</a>
    <li><a href="#ref-for-concept-url-serializer④">5.4. Response class</a> <a href="#ref-for-concept-url-serializer⑤">(2)</a>
    <li><a href="#ref-for-concept-url-serializer⑥">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-urlencoded-parser">
   <a href="https://url.spec.whatwg.org/#concept-urlencoded-parser">https://url.spec.whatwg.org/#concept-urlencoded-parser</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-urlencoded-parser">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-urlencoded-serializer">
   <a href="https://url.spec.whatwg.org/#concept-urlencoded-serializer">https://url.spec.whatwg.org/#concept-urlencoded-serializer</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-urlencoded-serializer">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-aborterror">
   <a href="https://heycam.github.io/webidl/#aborterror">https://heycam.github.io/webidl/#aborterror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-aborterror">2.2.5. Requests</a>
    <li><a href="#ref-for-aborterror①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-aborterror②">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-ArrayBuffer">
   <a href="https://heycam.github.io/webidl/#idl-ArrayBuffer">https://heycam.github.io/webidl/#idl-ArrayBuffer</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-ArrayBuffer">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-BufferSource">
   <a href="https://heycam.github.io/webidl/#BufferSource">https://heycam.github.io/webidl/#BufferSource</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-BufferSource">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-ByteString">
   <a href="https://heycam.github.io/webidl/#idl-ByteString">https://heycam.github.io/webidl/#idl-ByteString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-ByteString">5.1. Headers class</a> <a href="#ref-for-idl-ByteString①">(2)</a> <a href="#ref-for-idl-ByteString②">(3)</a> <a href="#ref-for-idl-ByteString③">(4)</a> <a href="#ref-for-idl-ByteString④">(5)</a> <a href="#ref-for-idl-ByteString⑤">(6)</a> <a href="#ref-for-idl-ByteString⑥">(7)</a> <a href="#ref-for-idl-ByteString⑦">(8)</a> <a href="#ref-for-idl-ByteString⑧">(9)</a> <a href="#ref-for-idl-ByteString⑨">(10)</a> <a href="#ref-for-idl-ByteString①⓪">(11)</a> <a href="#ref-for-idl-ByteString①①">(12)</a> <a href="#ref-for-idl-ByteString①②">(13)</a>
    <li><a href="#ref-for-idl-ByteString①③">5.3. Request class</a> <a href="#ref-for-idl-ByteString①④">(2)</a>
    <li><a href="#ref-for-idl-ByteString①⑤">5.4. Response class</a> <a href="#ref-for-idl-ByteString①⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMException">
   <a href="https://heycam.github.io/webidl/#idl-DOMException">https://heycam.github.io/webidl/#idl-DOMException</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMException">2.2.5. Requests</a>
    <li><a href="#ref-for-idl-DOMException①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-idl-DOMException②">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMString">
   <a href="https://heycam.github.io/webidl/#idl-DOMString">https://heycam.github.io/webidl/#idl-DOMString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMString">5.3. Request class</a> <a href="#ref-for-idl-DOMString①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">5.1. Headers class</a>
    <li><a href="#ref-for-Exposed①">5.3. Request class</a>
    <li><a href="#ref-for-Exposed②">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-NewObject">
   <a href="https://heycam.github.io/webidl/#NewObject">https://heycam.github.io/webidl/#NewObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-NewObject">5.2. Body mixin</a> <a href="#ref-for-NewObject①">(2)</a> <a href="#ref-for-NewObject②">(3)</a> <a href="#ref-for-NewObject③">(4)</a> <a href="#ref-for-NewObject④">(5)</a>
    <li><a href="#ref-for-NewObject⑤">5.3. Request class</a>
    <li><a href="#ref-for-NewObject⑥">5.4. Response class</a> <a href="#ref-for-NewObject⑦">(2)</a> <a href="#ref-for-NewObject⑧">(3)</a>
    <li><a href="#ref-for-NewObject⑨">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-exceptiondef-rangeerror">
   <a href="https://heycam.github.io/webidl/#exceptiondef-rangeerror">https://heycam.github.io/webidl/#exceptiondef-rangeerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-exceptiondef-rangeerror">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">5.3. Request class</a>
    <li><a href="#ref-for-SameObject①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-exceptiondef-typeerror">
   <a href="https://heycam.github.io/webidl/#exceptiondef-typeerror">https://heycam.github.io/webidl/#exceptiondef-typeerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-exceptiondef-typeerror">2.8.1. ReadableStream</a>
    <li><a href="#ref-for-exceptiondef-typeerror①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-exceptiondef-typeerror②">5.1. Headers class</a> <a href="#ref-for-exceptiondef-typeerror③">(2)</a> <a href="#ref-for-exceptiondef-typeerror④">(3)</a> <a href="#ref-for-exceptiondef-typeerror⑤">(4)</a> <a href="#ref-for-exceptiondef-typeerror⑥">(5)</a> <a href="#ref-for-exceptiondef-typeerror⑦">(6)</a> <a href="#ref-for-exceptiondef-typeerror⑧">(7)</a> <a href="#ref-for-exceptiondef-typeerror⑨">(8)</a> <a href="#ref-for-exceptiondef-typeerror①⓪">(9)</a>
    <li><a href="#ref-for-exceptiondef-typeerror①①">5.2. Body mixin</a> <a href="#ref-for-exceptiondef-typeerror①②">(2)</a> <a href="#ref-for-exceptiondef-typeerror①③">(3)</a> <a href="#ref-for-exceptiondef-typeerror①④">(4)</a> <a href="#ref-for-exceptiondef-typeerror①⑤">(5)</a> <a href="#ref-for-exceptiondef-typeerror①⑥">(6)</a>
    <li><a href="#ref-for-exceptiondef-typeerror①⑦">5.3. Request class</a> <a href="#ref-for-exceptiondef-typeerror①⑧">(2)</a> <a href="#ref-for-exceptiondef-typeerror①⑨">(3)</a> <a href="#ref-for-exceptiondef-typeerror②⓪">(4)</a> <a href="#ref-for-exceptiondef-typeerror②①">(5)</a> <a href="#ref-for-exceptiondef-typeerror②②">(6)</a> <a href="#ref-for-exceptiondef-typeerror②③">(7)</a> <a href="#ref-for-exceptiondef-typeerror②④">(8)</a> <a href="#ref-for-exceptiondef-typeerror②⑤">(9)</a> <a href="#ref-for-exceptiondef-typeerror②⑥">(10)</a> <a href="#ref-for-exceptiondef-typeerror②⑦">(11)</a> <a href="#ref-for-exceptiondef-typeerror②⑧">(12)</a>
    <li><a href="#ref-for-exceptiondef-typeerror②⑨">5.4. Response class</a> <a href="#ref-for-exceptiondef-typeerror③⓪">(2)</a> <a href="#ref-for-exceptiondef-typeerror③①">(3)</a> <a href="#ref-for-exceptiondef-typeerror③②">(4)</a>
    <li><a href="#ref-for-exceptiondef-typeerror③③">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-USVString">
   <a href="https://heycam.github.io/webidl/#idl-USVString">https://heycam.github.io/webidl/#idl-USVString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-USVString">5.2. Body mixin</a> <a href="#ref-for-idl-USVString①">(2)</a>
    <li><a href="#ref-for-idl-USVString②">5.3. Request class</a> <a href="#ref-for-idl-USVString③">(2)</a> <a href="#ref-for-idl-USVString④">(3)</a> <a href="#ref-for-idl-USVString⑤">(4)</a>
    <li><a href="#ref-for-idl-USVString⑥">5.4. Response class</a> <a href="#ref-for-idl-USVString⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-a-promise-resolved-with">
   <a href="https://heycam.github.io/webidl/#a-promise-resolved-with">https://heycam.github.io/webidl/#a-promise-resolved-with</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-a-promise-resolved-with">2.8.1. ReadableStream</a> <a href="#ref-for-a-promise-resolved-with①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">5.1. Headers class</a>
    <li><a href="#ref-for-idl-boolean①">5.2. Body mixin</a>
    <li><a href="#ref-for-idl-boolean②">5.3. Request class</a> <a href="#ref-for-idl-boolean③">(2)</a> <a href="#ref-for-idl-boolean④">(3)</a> <a href="#ref-for-idl-boolean⑤">(4)</a>
    <li><a href="#ref-for-idl-boolean⑥">5.4. Response class</a> <a href="#ref-for-idl-boolean⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-record">
   <a href="https://heycam.github.io/webidl/#idl-record">https://heycam.github.io/webidl/#idl-record</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-record">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-sequence">
   <a href="https://heycam.github.io/webidl/#idl-sequence">https://heycam.github.io/webidl/#idl-sequence</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-sequence">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-throw">
   <a href="https://heycam.github.io/webidl/#dfn-throw">https://heycam.github.io/webidl/#dfn-throw</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-throw">5.1. Headers class</a> <a href="#ref-for-dfn-throw①">(2)</a> <a href="#ref-for-dfn-throw②">(3)</a> <a href="#ref-for-dfn-throw③">(4)</a> <a href="#ref-for-dfn-throw④">(5)</a> <a href="#ref-for-dfn-throw⑤">(6)</a> <a href="#ref-for-dfn-throw⑥">(7)</a> <a href="#ref-for-dfn-throw⑦">(8)</a> <a href="#ref-for-dfn-throw⑧">(9)</a>
    <li><a href="#ref-for-dfn-throw⑨">5.2. Body mixin</a> <a href="#ref-for-dfn-throw①⓪">(2)</a> <a href="#ref-for-dfn-throw①①">(3)</a> <a href="#ref-for-dfn-throw①②">(4)</a> <a href="#ref-for-dfn-throw①③">(5)</a>
    <li><a href="#ref-for-dfn-throw①④">5.3. Request class</a> <a href="#ref-for-dfn-throw①⑤">(2)</a> <a href="#ref-for-dfn-throw①⑥">(3)</a> <a href="#ref-for-dfn-throw①⑦">(4)</a> <a href="#ref-for-dfn-throw①⑧">(5)</a> <a href="#ref-for-dfn-throw①⑨">(6)</a> <a href="#ref-for-dfn-throw②⓪">(7)</a> <a href="#ref-for-dfn-throw②①">(8)</a> <a href="#ref-for-dfn-throw②②">(9)</a> <a href="#ref-for-dfn-throw②③">(10)</a> <a href="#ref-for-dfn-throw②④">(11)</a>
    <li><a href="#ref-for-dfn-throw②⑤">5.4. Response class</a> <a href="#ref-for-dfn-throw②⑥">(2)</a> <a href="#ref-for-dfn-throw②⑦">(3)</a> <a href="#ref-for-dfn-throw②⑧">(4)</a> <a href="#ref-for-dfn-throw②⑨">(5)</a> <a href="#ref-for-dfn-throw③⓪">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-short">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-short">https://heycam.github.io/webidl/#idl-unsigned-short</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-short">5.4. Response class</a> <a href="#ref-for-idl-unsigned-short①">(2)</a> <a href="#ref-for-idl-unsigned-short②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-value-pairs-to-iterate-over">
   <a href="https://heycam.github.io/webidl/#dfn-value-pairs-to-iterate-over">https://heycam.github.io/webidl/#dfn-value-pairs-to-iterate-over</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-value-pairs-to-iterate-over">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-formdata">
   <a href="https://xhr.spec.whatwg.org/#formdata">https://xhr.spec.whatwg.org/#formdata</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-formdata">5.2. Body mixin</a> <a href="#ref-for-formdata①">(2)</a> <a href="#ref-for-formdata②">(3)</a> <a href="#ref-for-formdata③">(4)</a> <a href="#ref-for-formdata④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-xmlhttprequest">
   <a href="https://xhr.spec.whatwg.org/#xmlhttprequest">https://xhr.spec.whatwg.org/#xmlhttprequest</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-xmlhttprequest">2.2.2. Headers</a> <a href="#ref-for-xmlhttprequest①">(2)</a>
    <li><a href="#ref-for-xmlhttprequest②">2.2.5. Requests</a>
    <li><a href="#ref-for-xmlhttprequest③">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-xmlhttprequest④">3.5. CORB</a>
    <li><a href="#ref-for-xmlhttprequest⑤">5. Fetch API</a>
    <li><a href="#ref-for-xmlhttprequest⑥">5.6. Garbage collection</a>
    <li><a href="#ref-for-xmlhttprequest⑦">Basic safe CORS protocol setup</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-xmlhttprequestupload">
   <a href="https://xhr.spec.whatwg.org/#xmlhttprequestupload">https://xhr.spec.whatwg.org/#xmlhttprequestupload</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-xmlhttprequestupload">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-formdata-entry">
   <a href="https://xhr.spec.whatwg.org/#concept-formdata-entry">https://xhr.spec.whatwg.org/#concept-formdata-entry</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-formdata-entry">5.2. Body mixin</a> <a href="#ref-for-concept-formdata-entry①">(2)</a> <a href="#ref-for-concept-formdata-entry②">(3)</a> <a href="#ref-for-concept-formdata-entry③">(4)</a> <a href="#ref-for-concept-formdata-entry④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-formdata-entry">
   <a href="https://xhr.spec.whatwg.org/#concept-formdata-entry">https://xhr.spec.whatwg.org/#concept-formdata-entry</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-formdata-entry">5.2. Body mixin</a> <a href="#ref-for-concept-formdata-entry①">(2)</a> <a href="#ref-for-concept-formdata-entry②">(3)</a> <a href="#ref-for-concept-formdata-entry③">(4)</a> <a href="#ref-for-concept-formdata-entry④">(5)</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-abortsignal" style="color:initial">AbortSignal</span>
     <li><span class="dfn-paneled" id="term-for-abortsignal-aborted-flag" style="color:initial">aborted flag</span>
     <li><span class="dfn-paneled" id="term-for-abortsignal-add" style="color:initial">add</span>
     <li><span class="dfn-paneled" id="term-for-context-object" style="color:initial">context object</span>
     <li><span class="dfn-paneled" id="term-for-abortsignal-follow" style="color:initial">follow</span>
    </ul>
   <li>
    <a data-link-type="biblio">[ENCODING]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-utf-8" style="color:initial">utf-8</span>
     <li><span class="dfn-paneled" id="term-for-utf-8-decode" style="color:initial">utf-8 decode</span>
     <li><span class="dfn-paneled" id="term-for-utf-8-decode-without-bom" style="color:initial">utf-8 decode without bom</span>
     <li><span class="dfn-paneled" id="term-for-utf-8-encode" style="color:initial">utf-8 encode</span>
    </ul>
   <li>
    <a data-link-type="biblio">[FILEAPI]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-dfn-Blob" style="color:initial">Blob</span>
     <li><span class="dfn-paneled" id="term-for-dfn-file" style="color:initial">File</span>
     <li><span class="dfn-paneled" id="term-for-dfn-name" style="color:initial">name</span>
     <li><span class="dfn-paneled" id="term-for-blob-url-entry-object" style="color:initial">object</span>
     <li><span class="dfn-paneled" id="term-for-readOperation" style="color:initial">read operation</span>
     <li><span class="dfn-paneled" id="term-for-dfn-size" style="color:initial">size</span>
     <li><span class="dfn-paneled" id="term-for-dfn-type" style="color:initial">type</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HEADER-STRUCTURE]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-section-4.2" style="color:initial">parsing structured headers</span>
     <li><span class="dfn-paneled" id="term-for-section-4.1" style="color:initial">serializing structured headers</span>
     <li><span class="dfn-paneled" id="term-for-section-2" style="color:initial">structured header value</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-websocket" style="color:initial">WebSocket</span>
     <li><span class="dfn-paneled" id="term-for-window" style="color:initial">Window</span>
     <li><span class="dfn-paneled" id="term-for-windoworworkerglobalscope" style="color:initial">WindowOrWorkerGlobalScope</span>
     <li><span class="dfn-paneled" id="term-for-active-document" style="color:initial">active document</span>
     <li><span class="dfn-paneled" id="term-for-ancestor-browsing-context" style="color:initial">ancestor browsing context</span>
     <li><span class="dfn-paneled" id="term-for-api-base-url" style="color:initial">api base url</span>
     <li><span class="dfn-paneled" id="term-for-ascii-serialisation-of-an-origin" style="color:initial">ascii serialization of an origin</span>
     <li><span class="dfn-paneled" id="term-for-concept-environment-creation-url" style="color:initial">creation url</span>
     <li><span class="dfn-paneled" id="term-for-current-settings-object" style="color:initial">current settings object</span>
     <li><span class="dfn-paneled" id="term-for-downloading-hyperlinks" style="color:initial">downloads a hyperlink</span>
     <li><span class="dfn-paneled" id="term-for-environment" style="color:initial">environment</span>
     <li><span class="dfn-paneled" id="term-for-environment-settings-object" style="color:initial">environment settings object</span>
     <li><span class="dfn-paneled" id="term-for-the-form-element" style="color:initial">form</span>
     <li><span class="dfn-paneled" id="term-for-concept-settings-object-global" style="color:initial">global object</span>
     <li><span class="dfn-paneled" id="term-for-https-state" style="color:initial">https state</span>
     <li><span class="dfn-paneled" id="term-for-concept-environment-id" style="color:initial">id</span>
     <li><span class="dfn-paneled" id="term-for-in-parallel" style="color:initial">in parallel</span>
     <li><span class="dfn-paneled" id="term-for-multipart/form-data-boundary-string" style="color:initial">multipart/form-data boundary string</span>
     <li><span class="dfn-paneled" id="term-for-multipart/form-data-encoding-algorithm" style="color:initial">multipart/form-data encoding algorithm</span>
     <li><span class="dfn-paneled" id="term-for-navigate" style="color:initial">navigate</span>
     <li><span class="dfn-paneled" id="term-for-nested-browsing-context" style="color:initial">nested browsing context</span>
     <li><span class="dfn-paneled" id="term-for-networking-task-source" style="color:initial">networking task source</span>
     <li><span class="dfn-paneled" id="term-for-concept-origin-opaque" style="color:initial">opaque origin</span>
     <li><span class="dfn-paneled" id="term-for-concept-settings-object-origin" style="color:initial">origin <small>(for environment settings object)</small></span>
     <li><span class="dfn-paneled" id="term-for-queue-a-task" style="color:initial">queue a task</span>
     <li><span class="dfn-paneled" id="term-for-concept-settings-object-referrer-policy" style="color:initial">referrer policy</span>
     <li><span class="dfn-paneled" id="term-for-concept-media-load-resource" style="color:initial">resource fetch algorithm</span>
     <li><span class="dfn-paneled" id="term-for-responsible-browsing-context" style="color:initial">responsible browsing context</span>
     <li><span class="dfn-paneled" id="term-for-responsible-event-loop" style="color:initial">responsible event loop</span>
     <li><span class="dfn-paneled" id="term-for-same-origin" style="color:initial">same origin</span>
     <li><span class="dfn-paneled" id="term-for-schemelessly-same-site" style="color:initial">schemelessly same site</span>
     <li><span class="dfn-paneled" id="term-for-concept-environment-target-browsing-context" style="color:initial">target browsing context</span>
     <li><span class="dfn-paneled" id="term-for-concept-task" style="color:initial">task</span>
     <li><span class="dfn-paneled" id="term-for-concept-origin-tuple" style="color:initial">tuple origin</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTTP]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-section-3.2" style="color:initial">field-name</span>
     <li><span class="dfn-paneled" id="term-for-section-3.1.1" style="color:initial">method</span>
     <li><span class="dfn-paneled" id="term-for-section-3.1.2" style="color:initial">reason-phrase</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTTP-CACHING]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-section-1.2.1" style="color:initial">delta-seconds</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-abort-when" style="color:initial">abort when</span>
     <li><span class="dfn-paneled" id="term-for-set-append" style="color:initial">append <small>(for set)</small></span>
     <li><span class="dfn-paneled" id="term-for-ascii-case-insensitive" style="color:initial">ascii case-insensitive</span>
     <li><span class="dfn-paneled" id="term-for-ascii-whitespace" style="color:initial">ascii whitespace</span>
     <li><span class="dfn-paneled" id="term-for-iteration-break" style="color:initial">break</span>
     <li><span class="dfn-paneled" id="term-for-byte-less-than" style="color:initial">byte less than</span>
     <li><span class="dfn-paneled" id="term-for-byte-sequence" style="color:initial">byte sequence</span>
     <li><span class="dfn-paneled" id="term-for-byte-case-insensitive" style="color:initial">byte-case-insensitive</span>
     <li><span class="dfn-paneled" id="term-for-byte-lowercase" style="color:initial">byte-lowercase</span>
     <li><span class="dfn-paneled" id="term-for-byte-uppercase" style="color:initial">byte-uppercase</span>
     <li><span class="dfn-paneled" id="term-for-list-clone" style="color:initial">clone</span>
     <li><span class="dfn-paneled" id="term-for-code-point" style="color:initial">code point</span>
     <li><span class="dfn-paneled" id="term-for-collect-a-sequence-of-code-points" style="color:initial">collecting a sequence of code points</span>
     <li><span class="dfn-paneled" id="term-for-list-contain" style="color:initial">contain</span>
     <li><span class="dfn-paneled" id="term-for-iteration-continue" style="color:initial">continue</span>
     <li><span class="dfn-paneled" id="term-for-map-exists" style="color:initial">exist</span>
     <li><span class="dfn-paneled" id="term-for-map-iterate" style="color:initial">for each <small>(for map)</small></span>
     <li><span class="dfn-paneled" id="term-for-forgiving-base64-decode" style="color:initial">forgiving-base64 decode</span>
     <li><span class="dfn-paneled" id="term-for-forgiving-base64-encode" style="color:initial">forgiving-base64 encode</span>
     <li><span class="dfn-paneled" id="term-for-if-aborted" style="color:initial">if aborted</span>
     <li><span class="dfn-paneled" id="term-for-list-is-empty" style="color:initial">is empty</span>
     <li><span class="dfn-paneled" id="term-for-map-is-empty" style="color:initial">is not empty <small>(for map)</small></span>
     <li><span class="dfn-paneled" id="term-for-isomorphic-decode" style="color:initial">isomorphic decode</span>
     <li><span class="dfn-paneled" id="term-for-isomorphic-encode" style="color:initial">isomorphic encode</span>
     <li><span class="dfn-paneled" id="term-for-list-item" style="color:initial">item</span>
     <li><span class="dfn-paneled" id="term-for-byte-sequence-length" style="color:initial">length</span>
     <li><span class="dfn-paneled" id="term-for-list" style="color:initial">list</span>
     <li><span class="dfn-paneled" id="term-for-ordered-set" style="color:initial">ordered set</span>
     <li><span class="dfn-paneled" id="term-for-parse-json-from-bytes" style="color:initial">parse json from bytes</span>
     <li><span class="dfn-paneled" id="term-for-string-position-variable" style="color:initial">position variable</span>
     <li><span class="dfn-paneled" id="term-for-list-remove" style="color:initial">remove</span>
     <li><span class="dfn-paneled" id="term-for-list-sort-in-ascending-order" style="color:initial">sorting</span>
     <li><span class="dfn-paneled" id="term-for-string" style="color:initial">string</span>
     <li><span class="dfn-paneled" id="term-for-strip-leading-and-trailing-ascii-whitespace" style="color:initial">strip leading and trailing ascii whitespace</span>
     <li><span class="dfn-paneled" id="term-for-struct" style="color:initial">struct</span>
    </ul>
   <li>
    <a data-link-type="biblio">[MIMESNIFF]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mime-type-essence" style="color:initial">essence</span>
     <li><span class="dfn-paneled" id="term-for-html-mime-type" style="color:initial">html mime type</span>
     <li><span class="dfn-paneled" id="term-for-javascript-mime-type" style="color:initial">javascript mime type</span>
     <li><span class="dfn-paneled" id="term-for-json-mime-type" style="color:initial">json mime type</span>
     <li><span class="dfn-paneled" id="term-for-mime-type" style="color:initial">mime type</span>
     <li><span class="dfn-paneled" id="term-for-parameters" style="color:initial">parameters</span>
     <li><span class="dfn-paneled" id="term-for-parse-a-mime-type" style="color:initial">parse a mime type</span>
     <li><span class="dfn-paneled" id="term-for-serialize-a-mime-type" style="color:initial">serialize a mime type</span>
     <li><span class="dfn-paneled" id="term-for-serialize-a-mime-type-to-bytes" style="color:initial">serialize a mime type to bytes</span>
     <li><span class="dfn-paneled" id="term-for-xml-mime-type" style="color:initial">xml mime type</span>
    </ul>
   <li>
    <a data-link-type="biblio">[REFERRER]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-enumdef-referrerpolicy" style="color:initial">ReferrerPolicy</span>
     <li><span class="dfn-paneled" id="term-for-determine-requests-referrer" style="color:initial">determine request's referrer</span>
     <li><span class="dfn-paneled" id="term-for-referrer-policy" style="color:initial">referrer policy</span>
     <li><span class="dfn-paneled" id="term-for-set-requests-referrer-policy-on-redirect" style="color:initial">set request's referrer policy on redirect</span>
    </ul>
   <li>
    <a data-link-type="biblio">[STREAMS]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-acquire-readable-stream-reader" style="color:initial">AcquireReadableStreamDefaultReader</span>
     <li><span class="dfn-paneled" id="term-for-create-readable-stream" style="color:initial">CreateReadableStream</span>
     <li><span class="dfn-paneled" id="term-for-is-readable-stream-disturbed" style="color:initial">IsReadableStreamDisturbed</span>
     <li><span class="dfn-paneled" id="term-for-is-readable-stream-locked" style="color:initial">IsReadableStreamLocked</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-cancel" style="color:initial">ReadableStreamCancel</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-default-controller-close" style="color:initial">ReadableStreamDefaultControllerClose</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-default-controller-enqueue" style="color:initial">ReadableStreamDefaultControllerEnqueue</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-default-controller-error" style="color:initial">ReadableStreamDefaultControllerError</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-default-controller-get-desired-size" style="color:initial">ReadableStreamDefaultControllerGetDesiredSize</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-default-reader-read" style="color:initial">ReadableStreamDefaultReaderRead</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-pipe-to" style="color:initial">ReadableStreamPipeTo</span>
     <li><span class="dfn-paneled" id="term-for-readable-stream-tee" style="color:initial">ReadableStreamTee</span>
     <li><span class="dfn-paneled" id="term-for-chunk" style="color:initial">chunk</span>
     <li><span class="dfn-paneled" id="term-for-rs-get-reader" style="color:initial">getReader({ mode } = {})</span>
     <li><span class="dfn-paneled" id="term-for-identity-transform-stream" style="color:initial">identity transform stream</span>
     <li><span class="dfn-paneled" id="term-for-readable-side" style="color:initial">readable side</span>
     <li><span class="dfn-paneled" id="term-for-writable-side" style="color:initial">writable side</span>
    </ul>
   <li>
    <a data-link-type="biblio">[SW]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-serviceworkerglobalscope" style="color:initial">ServiceWorkerGlobalScope</span>
     <li><span class="dfn-paneled" id="term-for-service-worker-global-scope-fetch-event" style="color:initial">fetch</span>
     <li><span class="dfn-paneled" id="term-for-handle-fetch" style="color:initial">handle fetch</span>
    </ul>
   <li>
    <a data-link-type="biblio">[URL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-urlsearchparams" style="color:initial">URLSearchParams</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-blob-entry" style="color:initial">blob url entry</span>
     <li><span class="dfn-paneled" id="term-for-url-cannot-be-a-base-url-flag" style="color:initial">cannot-be-a-base-url flag</span>
     <li><span class="dfn-paneled" id="term-for-concept-domain" style="color:initial">domain</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-fragment" style="color:initial">fragment</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-host" style="color:initial">host</span>
     <li><span class="dfn-paneled" id="term-for-include-credentials" style="color:initial">include credentials</span>
     <li><span class="dfn-paneled" id="term-for-concept-urlsearchparams-list" style="color:initial">list</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-origin" style="color:initial">origin</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-path" style="color:initial">path</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-port" style="color:initial">port</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-scheme" style="color:initial">scheme</span>
     <li><span class="dfn-paneled" id="term-for-set-the-password" style="color:initial">set the password</span>
     <li><span class="dfn-paneled" id="term-for-set-the-username" style="color:initial">set the username</span>
     <li><span class="dfn-paneled" id="term-for-string-percent-decode" style="color:initial">string percent decode</span>
     <li><span class="dfn-paneled" id="term-for-concept-url" style="color:initial">url</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-parser" style="color:initial">url parser</span>
     <li><span class="dfn-paneled" id="term-for-concept-url-serializer" style="color:initial">url serializer</span>
     <li><span class="dfn-paneled" id="term-for-concept-urlencoded-parser" style="color:initial">urlencoded parser</span>
     <li><span class="dfn-paneled" id="term-for-concept-urlencoded-serializer" style="color:initial">urlencoded serializer</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WEBIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-aborterror" style="color:initial">AbortError</span>
     <li><span class="dfn-paneled" id="term-for-idl-ArrayBuffer" style="color:initial">ArrayBuffer</span>
     <li><span class="dfn-paneled" id="term-for-BufferSource" style="color:initial">BufferSource</span>
     <li><span class="dfn-paneled" id="term-for-idl-ByteString" style="color:initial">ByteString</span>
     <li><span class="dfn-paneled" id="term-for-idl-DOMException" style="color:initial">DOMException</span>
     <li><span class="dfn-paneled" id="term-for-idl-DOMString" style="color:initial">DOMString</span>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-NewObject" style="color:initial">NewObject</span>
     <li><span class="dfn-paneled" id="term-for-exceptiondef-rangeerror" style="color:initial">RangeError</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-exceptiondef-typeerror" style="color:initial">TypeError</span>
     <li><span class="dfn-paneled" id="term-for-idl-USVString" style="color:initial">USVString</span>
     <li><span class="dfn-paneled" id="term-for-a-promise-resolved-with" style="color:initial">a promise resolved with</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-idl-record" style="color:initial">record</span>
     <li><span class="dfn-paneled" id="term-for-idl-sequence" style="color:initial">sequence</span>
     <li><span class="dfn-paneled" id="term-for-dfn-throw" style="color:initial">throw</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-short" style="color:initial">unsigned short</span>
     <li><span class="dfn-paneled" id="term-for-dfn-value-pairs-to-iterate-over" style="color:initial">value pairs to iterate over</span>
    </ul>
   <li>
    <a data-link-type="biblio">[XHR]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-formdata" style="color:initial">FormData</span>
     <li><span class="dfn-paneled" id="term-for-xmlhttprequest" style="color:initial">XMLHttpRequest</span>
     <li><span class="dfn-paneled" id="term-for-xmlhttprequestupload" style="color:initial">XMLHttpRequestUpload</span>
     <li><span class="dfn-paneled" id="term-for-concept-formdata-entry" style="color:initial">entries</span>
     <li><span class="dfn-paneled" id="term-for-concept-formdata-entry①" style="color:initial">entry</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-abnf">[ABNF]
   <dd>D. Crocker, Ed.; P. Overell. <a href="https://tools.ietf.org/html/rfc5234">Augmented BNF for Syntax Specifications: ABNF</a>. January 2008. Internet Standard. URL: <a href="https://tools.ietf.org/html/rfc5234">https://tools.ietf.org/html/rfc5234</a>
   <dt id="biblio-cookies">[COOKIES]
   <dd>A. Barth. <a href="https://httpwg.org/specs/rfc6265.html">HTTP State Management Mechanism</a>. April 2011. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc6265.html">https://httpwg.org/specs/rfc6265.html</a>
   <dt id="biblio-csp">[CSP]
   <dd>Mike West. <a href="https://w3c.github.io/webappsec-csp/">Content Security Policy Level 3</a>. URL: <a href="https://w3c.github.io/webappsec-csp/">https://w3c.github.io/webappsec-csp/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-encoding">[ENCODING]
   <dd>Anne van Kesteren. <a href="https://encoding.spec.whatwg.org/">Encoding Standard</a>. Living Standard. URL: <a href="https://encoding.spec.whatwg.org/">https://encoding.spec.whatwg.org/</a>
   <dt id="biblio-fileapi">[FILEAPI]
   <dd>Marijn Kruisselbrink; Arun Ranganathan. <a href="https://w3c.github.io/FileAPI/">File API</a>. URL: <a href="https://w3c.github.io/FileAPI/">https://w3c.github.io/FileAPI/</a>
   <dt id="biblio-header-structure">[HEADER-STRUCTURE]
   <dd>Mark Nottingham; Paul-Henning Kamp. <a href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure">Structured Headers for HTTP</a>. URL: <a href="https://tools.ietf.org/html/draft-ietf-httpbis-header-structure">https://tools.ietf.org/html/draft-ietf-httpbis-header-structure</a>
   <dt id="biblio-hsts">[HSTS]
   <dd>J. Hodges; C. Jackson; A. Barth. <a href="https://tools.ietf.org/html/rfc6797">HTTP Strict Transport Security (HSTS)</a>. November 2012. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc6797">https://tools.ietf.org/html/rfc6797</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-http">[HTTP]
   <dd>R. Fielding, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7230.html">Hypertext Transfer Protocol (HTTP/1.1): Message Syntax and Routing</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7230.html">https://httpwg.org/specs/rfc7230.html</a>
   <dt id="biblio-http-auth">[HTTP-AUTH]
   <dd>R. Fielding, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7235.html">Hypertext Transfer Protocol (HTTP/1.1): Authentication</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7235.html">https://httpwg.org/specs/rfc7235.html</a>
   <dt id="biblio-http-caching">[HTTP-CACHING]
   <dd>R. Fielding, Ed.; M. Nottingham, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7234.html">Hypertext Transfer Protocol (HTTP/1.1): Caching</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7234.html">https://httpwg.org/specs/rfc7234.html</a>
   <dt id="biblio-http-cond">[HTTP-COND]
   <dd>R. Fielding, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7232.html">Hypertext Transfer Protocol (HTTP/1.1): Conditional Requests</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7232.html">https://httpwg.org/specs/rfc7232.html</a>
   <dt id="biblio-http-semantics">[HTTP-SEMANTICS]
   <dd>R. Fielding, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7231.html">Hypertext Transfer Protocol (HTTP/1.1): Semantics and Content</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7231.html">https://httpwg.org/specs/rfc7231.html</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-mimesniff">[MIMESNIFF]
   <dd>Gordon P. Hemsley. <a href="https://mimesniff.spec.whatwg.org/">MIME Sniffing Standard</a>. Living Standard. URL: <a href="https://mimesniff.spec.whatwg.org/">https://mimesniff.spec.whatwg.org/</a>
   <dt id="biblio-mix">[MIX]
   <dd>Mike West. <a href="https://w3c.github.io/webappsec-mixed-content/">Mixed Content</a>. URL: <a href="https://w3c.github.io/webappsec-mixed-content/">https://w3c.github.io/webappsec-mixed-content/</a>
   <dt id="biblio-referrer">[REFERRER]
   <dd>Jochen Eisinger; Emily Stark. <a href="https://w3c.github.io/webappsec-referrer-policy/">Referrer Policy</a>. URL: <a href="https://w3c.github.io/webappsec-referrer-policy/">https://w3c.github.io/webappsec-referrer-policy/</a>
   <dt id="biblio-rfc7405">[RFC7405]
   <dd>P. Kyzivat. <a href="https://tools.ietf.org/html/rfc7405">Case-Sensitive String Support in ABNF</a>. December 2014. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc7405">https://tools.ietf.org/html/rfc7405</a>
   <dt id="biblio-rfc7578">[RFC7578]
   <dd>L. Masinter. <a href="https://tools.ietf.org/html/rfc7578">Returning Values from Forms: multipart/form-data</a>. July 2015. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc7578">https://tools.ietf.org/html/rfc7578</a>
   <dt id="biblio-rfc959">[RFC959]
   <dd>J. Postel; J. Reynolds. <a href="https://tools.ietf.org/html/rfc959">File Transfer Protocol</a>. October 1985. Internet Standard. URL: <a href="https://tools.ietf.org/html/rfc959">https://tools.ietf.org/html/rfc959</a>
   <dt id="biblio-sri">[SRI]
   <dd>Devdatta Akhawe; et al. <a href="https://w3c.github.io/webappsec-subresource-integrity/">Subresource Integrity</a>. URL: <a href="https://w3c.github.io/webappsec-subresource-integrity/">https://w3c.github.io/webappsec-subresource-integrity/</a>
   <dt id="biblio-stale-while-revalidate">[STALE-WHILE-REVALIDATE]
   <dd>M. Nottingham. <a href="https://httpwg.org/specs/rfc5861.html">HTTP Cache-Control Extensions for Stale Content</a>. May 2010. Informational. URL: <a href="https://httpwg.org/specs/rfc5861.html">https://httpwg.org/specs/rfc5861.html</a>
   <dt id="biblio-streams">[STREAMS]
   <dd>Adam Rice; Domenic Denicola; 吉野剛史 (Takeshi Yoshino). <a href="https://streams.spec.whatwg.org/">Streams Standard</a>. Living Standard. URL: <a href="https://streams.spec.whatwg.org/">https://streams.spec.whatwg.org/</a>
   <dt id="biblio-sw">[SW]
   <dd>Alex Russell; et al. <a href="https://w3c.github.io/ServiceWorker/">Service Workers 1</a>. URL: <a href="https://w3c.github.io/ServiceWorker/">https://w3c.github.io/ServiceWorker/</a>
   <dt id="biblio-tls">[TLS]
   <dd>E. Rescorla. <a href="https://tools.ietf.org/html/rfc8446">The Transport Layer Security (TLS) Protocol Version 1.3</a>. August 2018. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc8446">https://tools.ietf.org/html/rfc8446</a>
   <dt id="biblio-upgrade">[UPGRADE]
   <dd>Mike West. <a href="https://w3c.github.io/webappsec-upgrade-insecure-requests/">Upgrade Insecure Requests</a>. URL: <a href="https://w3c.github.io/webappsec-upgrade-insecure-requests/">https://w3c.github.io/webappsec-upgrade-insecure-requests/</a>
   <dt id="biblio-url">[URL]
   <dd>Anne van Kesteren. <a href="https://url.spec.whatwg.org/">URL Standard</a>. Living Standard. URL: <a href="https://url.spec.whatwg.org/">https://url.spec.whatwg.org/</a>
   <dt id="biblio-webidl">[WEBIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
   <dt id="biblio-wsp">[WSP]
   <dd>I. Fette; A. Melnikov. <a href="https://tools.ietf.org/html/rfc6455">The WebSocket Protocol</a>. December 2011. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc6455">https://tools.ietf.org/html/rfc6455</a>
   <dt id="biblio-xhr">[XHR]
   <dd>Anne van Kesteren. <a href="https://xhr.spec.whatwg.org/">XMLHttpRequest Standard</a>. Living Standard. URL: <a href="https://xhr.spec.whatwg.org/">https://xhr.spec.whatwg.org/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-cors">[CORS]
   <dd>Anne van Kesteren. <a href="https://www.w3.org/TR/cors/">Cross-Origin Resource Sharing</a>. 16 January 2014. REC. URL: <a href="https://www.w3.org/TR/cors/">https://www.w3.org/TR/cors/</a>
   <dt id="biblio-expect-ct">[EXPECT-CT]
   <dd>Emily Stark. <a href="https://tools.ietf.org/html/draft-ietf-httpbis-expect-ct-02">Expect-CT Extension for HTTP</a>. URL: <a href="https://tools.ietf.org/html/draft-ietf-httpbis-expect-ct-02">https://tools.ietf.org/html/draft-ietf-httpbis-expect-ct-02</a>
   <dt id="biblio-http-range">[HTTP-RANGE]
   <dd>R. Fielding, Ed.; Y. Lafon, Ed.; J. Reschke, Ed.. <a href="https://httpwg.org/specs/rfc7233.html">Hypertext Transfer Protocol (HTTP/1.1): Range Requests</a>. June 2014. Proposed Standard. URL: <a href="https://httpwg.org/specs/rfc7233.html">https://httpwg.org/specs/rfc7233.html</a>
   <dt id="biblio-httpverbsec1">[HTTPVERBSEC1]
   <dd><a href="https://www.kb.cert.org/vuls/id/867593">Multiple vendors' web servers enable HTTP TRACE method by default.</a>. URL: <a href="https://www.kb.cert.org/vuls/id/867593">https://www.kb.cert.org/vuls/id/867593</a>
   <dt id="biblio-httpverbsec2">[HTTPVERBSEC2]
   <dd><a href="https://www.kb.cert.org/vuls/id/288308">Microsoft Internet Information Server (IIS) vulnerable to cross-site scripting via HTTP TRACK method.</a>. URL: <a href="https://www.kb.cert.org/vuls/id/288308">https://www.kb.cert.org/vuls/id/288308</a>
   <dt id="biblio-httpverbsec3">[HTTPVERBSEC3]
   <dd><a href="https://www.kb.cert.org/vuls/id/150227">HTTP proxy default configurations allow arbitrary TCP connections.</a>. URL: <a href="https://www.kb.cert.org/vuls/id/150227">https://www.kb.cert.org/vuls/id/150227</a>
   <dt id="biblio-ocsp">[OCSP]
   <dd>S. Santesson; et al. <a href="https://tools.ietf.org/html/rfc6960">X.509 Internet Public Key Infrastructure Online Certificate Status Protocol - OCSP</a>. June 2013. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc6960">https://tools.ietf.org/html/rfc6960</a>
   <dt id="biblio-origin">[ORIGIN]
   <dd>A. Barth. <a href="https://tools.ietf.org/html/rfc6454">The Web Origin Concept</a>. December 2011. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc6454">https://tools.ietf.org/html/rfc6454</a>
   <dt id="biblio-rfc2397">[RFC2397]
   <dd>L. Masinter. <a href="https://tools.ietf.org/html/rfc2397">The "data" URL scheme</a>. August 1998. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc2397">https://tools.ietf.org/html/rfc2397</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>typedef</c-> (<c- b>sequence</c->&lt;<c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a>>> <c- b>or</c-> <c- b>record</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a>>) <a href="#typedefdef-headersinit"><code><c- g>HeadersInit</c-></code></a>;

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <a href="#headers"><code><c- g>Headers</c-></code></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-headers"><c- g>constructor</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#typedefdef-headersinit"><c- n>HeadersInit</c-></a> <a href="#dom-headers-headers-init-init"><code><c- g>init</c-></code></a>);

  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-headers-append"><c- g>append</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-append-name-value-name"><code><c- g>name</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-append-name-value-value"><code><c- g>value</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-headers-delete"><c- g>delete</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-delete-name-name"><code><c- g>name</c-></code></a>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-headers-get"><c- g>get</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-get-name-name"><code><c- g>name</c-></code></a>);
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="method" href="#dom-headers-has"><c- g>has</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-has-name-name"><code><c- g>name</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-headers-set"><c- g>set</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-set-name-value-name"><code><c- g>name</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a href="#dom-headers-set-name-value-value"><code><c- g>value</c-></code></a>);
  <c- b>iterable</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a>>;
};

<c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="https://w3c.github.io/FileAPI/#dfn-Blob"><c- n>Blob</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://heycam.github.io/webidl/#BufferSource"><c- n>BufferSource</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://xhr.spec.whatwg.org/#formdata"><c- n>FormData</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://url.spec.whatwg.org/#urlsearchparams"><c- n>URLSearchParams</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="#concept-readablestream"><c- n>ReadableStream</c-></a> <c- b>or</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a>) <a href="#bodyinit"><code><c- g>BodyInit</c-></code></a>;
<c- b>interface</c-> <c- b>mixin</c-> <a href="#body"><code><c- g>Body</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#concept-readablestream"><c- n>ReadableStream</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="ReadableStream?" href="#dom-body-body"><c- g>body</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-body-bodyused"><c- g>bodyUsed</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ArrayBuffer"><c- b>ArrayBuffer</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-arraybuffer"><c- g>arrayBuffer</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="https://w3c.github.io/FileAPI/#dfn-Blob"><c- n>Blob</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-blob"><c- g>blob</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="https://xhr.spec.whatwg.org/#formdata"><c- n>FormData</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-formdata"><c- g>formData</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<c- b>any</c->> <a class="idl-code" data-link-type="method" href="#dom-body-json"><c- g>json</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-body-text"><c- g>text</c-></a>();
};
<c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="#request"><c- n>Request</c-></a> <c- b>or</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a>) <a href="#requestinfo"><code><c- g>RequestInfo</c-></code></a>;

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <a href="#request"><code><c- g>Request</c-></code></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-request"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="#requestinfo"><c- n>RequestInfo</c-></a> <a href="#dom-request-request-input-init-input"><code><c- g>input</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#requestinit"><c- n>RequestInit</c-></a> <a href="#dom-request-request-input-init-init"><code><c- g>init</c-></code></a> = {});

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ByteString" href="#dom-request-method"><c- g>method</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-request-url"><c- g>url</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#headers"><c- n>Headers</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Headers" href="#dom-request-headers"><c- g>headers</c-></a>;

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestdestination"><c- n>RequestDestination</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestDestination" href="#dom-request-destination"><c- g>destination</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-request-referrer"><c- g>referrer</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://w3c.github.io/webappsec-referrer-policy/#enumdef-referrerpolicy"><c- n>ReferrerPolicy</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ReferrerPolicy" href="#dom-request-referrerpolicy"><c- g>referrerPolicy</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestmode"><c- n>RequestMode</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestMode" href="#dom-request-mode"><c- g>mode</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestcredentials"><c- n>RequestCredentials</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestCredentials" href="#dom-request-credentials"><c- g>credentials</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestcache"><c- n>RequestCache</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestCache" href="#dom-request-cache"><c- g>cache</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#requestredirect"><c- n>RequestRedirect</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="RequestRedirect" href="#dom-request-redirect"><c- g>redirect</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString" href="#dom-request-integrity"><c- g>integrity</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-request-keepalive"><c- g>keepalive</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-request-isreloadnavigation"><c- g>isReloadNavigation</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-request-ishistorynavigation"><c- g>isHistoryNavigation</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal"><c- n>AbortSignal</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="AbortSignal" href="#dom-request-signal"><c- g>signal</c-></a>;

  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#request"><c- n>Request</c-></a> <a class="idl-code" data-link-type="method" href="#dom-request-clone"><c- g>clone</c-></a>();
};
<a class="n" data-link-type="idl-name" href="#request"><c- n>Request</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#body"><c- n>Body</c-></a>;

<c- b>dictionary</c-> <a href="#requestinit"><code><c- g>RequestInit</c-></code></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a data-type="ByteString " href="#dom-requestinit-method"><code><c- g>method</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#typedefdef-headersinit"><c- n>HeadersInit</c-></a> <a data-type="HeadersInit " href="#dom-requestinit-headers"><code><c- g>headers</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#bodyinit"><c- n>BodyInit</c-></a>? <a data-type="BodyInit? " href="#dom-requestinit-body"><code><c- g>body</c-></code></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a> <a data-type="USVString " href="#dom-requestinit-referrer"><code><c- g>referrer</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="https://w3c.github.io/webappsec-referrer-policy/#enumdef-referrerpolicy"><c- n>ReferrerPolicy</c-></a> <a data-type="ReferrerPolicy " href="#dom-requestinit-referrerpolicy"><code><c- g>referrerPolicy</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#requestmode"><c- n>RequestMode</c-></a> <a data-type="RequestMode " href="#dom-requestinit-mode"><code><c- g>mode</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#requestcredentials"><c- n>RequestCredentials</c-></a> <a data-type="RequestCredentials " href="#dom-requestinit-credentials"><code><c- g>credentials</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#requestcache"><c- n>RequestCache</c-></a> <a data-type="RequestCache " href="#dom-requestinit-cache"><code><c- g>cache</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="#requestredirect"><c- n>RequestRedirect</c-></a> <a data-type="RequestRedirect " href="#dom-requestinit-redirect"><code><c- g>redirect</c-></code></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a data-type="DOMString " href="#dom-requestinit-integrity"><code><c- g>integrity</c-></code></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a data-type="boolean " href="#dom-requestinit-keepalive"><code><c- g>keepalive</c-></code></a>;
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#abortsignal"><c- n>AbortSignal</c-></a>? <a data-type="AbortSignal? " href="#dom-requestinit-signal"><code><c- g>signal</c-></code></a>;
  <c- b>any</c-> <a data-type="any " href="#dom-requestinit-window"><code><c- g>window</c-></code></a>; // can only be set to null
};

<c- b>enum</c-> <a href="#requestdestination"><code><c- g>RequestDestination</c-></code></a> { <a href="#dom-requestdestination"><code><c- s>""</c-></code></a>, <a href="#dom-requestdestination-audio"><code><c- s>"audio"</c-></code></a>, <a href="#dom-requestdestination-audioworklet"><code><c- s>"audioworklet"</c-></code></a>, <a href="#dom-requestdestination-document"><code><c- s>"document"</c-></code></a>, <a href="#dom-requestdestination-embed"><code><c- s>"embed"</c-></code></a>, <a href="#dom-requestdestination-font"><code><c- s>"font"</c-></code></a>, <a href="#dom-requestdestination-image"><code><c- s>"image"</c-></code></a>, <a href="#dom-requestdestination-manifest"><code><c- s>"manifest"</c-></code></a>, <a href="#dom-requestdestination-object"><code><c- s>"object"</c-></code></a>, <a href="#dom-requestdestination-paintworklet"><code><c- s>"paintworklet"</c-></code></a>, <a href="#dom-requestdestination-report"><code><c- s>"report"</c-></code></a>, <a href="#dom-requestdestination-script"><code><c- s>"script"</c-></code></a>, <a href="#dom-requestdestination-sharedworker"><code><c- s>"sharedworker"</c-></code></a>, <a href="#dom-requestdestination-style"><code><c- s>"style"</c-></code></a>,  <a href="#dom-requestdestination-track"><code><c- s>"track"</c-></code></a>, <a href="#dom-requestdestination-video"><code><c- s>"video"</c-></code></a>, <a href="#dom-requestdestination-worker"><code><c- s>"worker"</c-></code></a>, <a href="#dom-requestdestination-xslt"><code><c- s>"xslt"</c-></code></a> };
<c- b>enum</c-> <a href="#requestmode"><code><c- g>RequestMode</c-></code></a> { <a href="#dom-requestmode-navigate"><code><c- s>"navigate"</c-></code></a>, <a href="#dom-requestmode-same-origin"><code><c- s>"same-origin"</c-></code></a>, <a href="#dom-requestmode-no-cors"><code><c- s>"no-cors"</c-></code></a>, <a href="#dom-requestmode-cors"><code><c- s>"cors"</c-></code></a> };
<c- b>enum</c-> <a href="#requestcredentials"><code><c- g>RequestCredentials</c-></code></a> { <a href="#dom-requestcredentials-omit"><code><c- s>"omit"</c-></code></a>, <a href="#dom-requestcredentials-same-origin"><code><c- s>"same-origin"</c-></code></a>, <a href="#dom-requestcredentials-include"><code><c- s>"include"</c-></code></a> };
<c- b>enum</c-> <a href="#requestcache"><code><c- g>RequestCache</c-></code></a> { <a href="#dom-requestcache-default"><code><c- s>"default"</c-></code></a>, <a href="#dom-requestcache-no-store"><code><c- s>"no-store"</c-></code></a>, <a href="#dom-requestcache-reload"><code><c- s>"reload"</c-></code></a>, <a href="#dom-requestcache-no-cache"><code><c- s>"no-cache"</c-></code></a>, <a href="#dom-requestcache-force-cache"><code><c- s>"force-cache"</c-></code></a>, <a href="#dom-requestcache-only-if-cached"><code><c- s>"only-if-cached"</c-></code></a> };
<c- b>enum</c-> <a href="#requestredirect"><code><c- g>RequestRedirect</c-></code></a> { <a href="#dom-requestredirect-follow"><code><c- s>"follow"</c-></code></a>, <a href="#dom-requestredirect-error"><code><c- s>"error"</c-></code></a>, <a href="#dom-requestredirect-manual"><code><c- s>"manual"</c-></code></a> };

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->)]<c- b>interface</c-> <a href="#response"><code><c- g>Response</c-></code></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-response"><c- g>constructor</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#bodyinit"><c- n>BodyInit</c-></a>? <a href="#dom-response-response-body-init-body"><code><c- g>body</c-></code></a> = <c- b>null</c->, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#responseinit"><c- n>ResponseInit</c-></a> <a href="#dom-response-response-body-init-init"><code><c- g>init</c-></code></a> = {});

  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>static</c-> <a class="n" data-link-type="idl-name" href="#response"><c- n>Response</c-></a> <a class="idl-code" data-link-type="method" href="#dom-response-error"><c- g>error</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>static</c-> <a class="n" data-link-type="idl-name" href="#response"><c- n>Response</c-></a> <a class="idl-code" data-link-type="method" href="#dom-response-redirect"><c- g>redirect</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a> <a href="#dom-response-redirect-url-status-url"><code><c- g>url</c-></code></a>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-response-redirect-url-status-status"><code><c- g>status</c-></code></a> = 302);

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#responsetype"><c- n>ResponseType</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ResponseType" href="#dom-response-type"><c- g>type</c-></a>;

  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-response-url"><c- g>url</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-response-redirected"><c- g>redirected</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned short" href="#dom-response-status"><c- g>status</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-response-ok"><c- g>ok</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="ByteString" href="#dom-response-statustext"><c- g>statusText</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#headers"><c- n>Headers</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Headers" href="#dom-response-headers"><c- g>headers</c-></a>;

  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#response"><c- n>Response</c-></a> <a class="idl-code" data-link-type="method" href="#dom-response-clone"><c- g>clone</c-></a>();
};
<a class="n" data-link-type="idl-name" href="#response"><c- n>Response</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#body"><c- n>Body</c-></a>;

<c- b>dictionary</c-> <a href="#responseinit"><code><c- g>ResponseInit</c-></code></a> {
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a data-default="200" data-type="unsigned short " href="#dom-responseinit-status"><code><c- g>status</c-></code></a> = 200;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-ByteString"><c- b>ByteString</c-></a> <a data-default="&quot;&quot;" data-type="ByteString " href="#dom-responseinit-statustext"><code><c- g>statusText</c-></code></a> = "";
  <a class="n" data-link-type="idl-name" href="#typedefdef-headersinit"><c- n>HeadersInit</c-></a> <a data-type="HeadersInit " href="#dom-responseinit-headers"><code><c- g>headers</c-></code></a>;
};

<c- b>enum</c-> <a href="#responsetype"><code><c- g>ResponseType</c-></code></a> { <a href="#dom-responsetype-basic"><code><c- s>"basic"</c-></code></a>, <a href="#dom-responsetype-cors"><code><c- s>"cors"</c-></code></a>, <a href="#dom-responsetype-default"><code><c- s>"default"</c-></code></a>, <a href="#dom-responsetype-error"><code><c- s>"error"</c-></code></a>, <a href="#dom-responsetype-opaque"><code><c- s>"opaque"</c-></code></a>, <a href="#dom-responsetype-opaqueredirect"><code><c- s>"opaqueredirect"</c-></code></a> };

<c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/webappapis.html#windoworworkerglobalscope"><c- g>WindowOrWorkerGlobalScope</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <c- b>Promise</c->&lt;<a class="n" data-link-type="idl-name" href="#response"><c- n>Response</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-global-fetch"><c- g>fetch</c-></a>(<a class="n" data-link-type="idl-name" href="#requestinfo"><c- n>RequestInfo</c-></a> <a href="#dom-windoworworkerglobalscope-fetch-input-init-input"><code><c- g>input</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#requestinit"><c- n>RequestInit</c-></a> <a href="#dom-windoworworkerglobalscope-fetch-input-init-init"><code><c- g>init</c-></code></a> = {});
};

</pre>
  <aside class="dfn-panel" data-for="abnf">
   <b><a href="#abnf">#abnf</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abnf">2.2.2. Headers</a> <a href="#ref-for-abnf①">(2)</a> <a href="#ref-for-abnf②">(3)</a>
    <li><a href="#ref-for-abnf③">3.1. `Origin` header</a>
    <li><a href="#ref-for-abnf④">3.2.4. HTTP new-header syntax</a>
    <li><a href="#ref-for-abnf⑤">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-abnf⑥">3.6. `Cross-Origin-Resource-Policy` header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="credentials">
   <b><a href="#credentials">#credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-credentials">2.2.5. Requests</a>
    <li><a href="#ref-for-credentials①">3.2. CORS protocol</a>
    <li><a href="#ref-for-credentials②">3.2.4. HTTP new-header syntax</a>
    <li><a href="#ref-for-credentials③">3.2.5. CORS protocol and credentials</a> <a href="#ref-for-credentials④">(2)</a> <a href="#ref-for-credentials⑤">(3)</a> <a href="#ref-for-credentials⑥">(4)</a> <a href="#ref-for-credentials⑦">(5)</a> <a href="#ref-for-credentials⑧">(6)</a> <a href="#ref-for-credentials⑨">(7)</a> <a href="#ref-for-credentials①⓪">(8)</a>
    <li><a href="#ref-for-credentials①①">3.2.6. Examples</a> <a href="#ref-for-credentials①②">(2)</a> <a href="#ref-for-credentials①③">(3)</a> <a href="#ref-for-credentials①④">(4)</a> <a href="#ref-for-credentials①⑤">(5)</a> <a href="#ref-for-credentials①⑥">(6)</a> <a href="#ref-for-credentials①⑦">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="process-request-body">
   <b><a href="#process-request-body">#process-request-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-process-request-body">2.2.5. Requests</a>
    <li><a href="#ref-for-process-request-body①">4. Fetching</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="process-request-end-of-body">
   <b><a href="#process-request-end-of-body">#process-request-end-of-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-process-request-end-of-body">2. Infrastructure</a>
    <li><a href="#ref-for-process-request-end-of-body①">2.2.5. Requests</a> <a href="#ref-for-process-request-end-of-body②">(2)</a>
    <li><a href="#ref-for-process-request-end-of-body③">4. Fetching</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="process-response">
   <b><a href="#process-response">#process-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-process-response">4. Fetching</a>
    <li><a href="#ref-for-process-response①">4.1. Main fetch</a>
    <li><a href="#ref-for-process-response②">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="process-response-end-of-body">
   <b><a href="#process-response-end-of-body">#process-response-end-of-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-process-response-end-of-body">4. Fetching</a>
    <li><a href="#ref-for-process-response-end-of-body①">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="process-response-done">
   <b><a href="#process-response-done">#process-response-done</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-process-response-done">4. Fetching</a>
    <li><a href="#ref-for-process-response-done①">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="queue-a-fetch-task">
   <b><a href="#queue-a-fetch-task">#queue-a-fetch-task</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-queue-a-fetch-task">2. Infrastructure</a>
    <li><a href="#ref-for-queue-a-fetch-task①">2.2.5. Requests</a> <a href="#ref-for-queue-a-fetch-task②">(2)</a> <a href="#ref-for-queue-a-fetch-task③">(3)</a>
    <li><a href="#ref-for-queue-a-fetch-task④">4. Fetching</a> <a href="#ref-for-queue-a-fetch-task⑤">(2)</a>
    <li><a href="#ref-for-queue-a-fetch-task⑥">4.1. Main fetch</a> <a href="#ref-for-queue-a-fetch-task⑦">(2)</a> <a href="#ref-for-queue-a-fetch-task⑧">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="queue-a-fetch-request-done-task">
   <b><a href="#queue-a-fetch-request-done-task">#queue-a-fetch-request-done-task</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-queue-a-fetch-request-done-task">4.1. Main fetch</a> <a href="#ref-for-queue-a-fetch-request-done-task①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-an-integer">
   <b><a href="#serialize-an-integer">#serialize-an-integer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-an-integer">2.2.5. Requests</a> <a href="#ref-for-serialize-an-integer①">(2)</a>
    <li><a href="#ref-for-serialize-an-integer②">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="local-scheme">
   <b><a href="#local-scheme">#local-scheme</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-local-scheme">2.1. URL</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="is-local">
   <b><a href="#is-local">#is-local</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-is-local">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-scheme">
   <b><a href="#http-scheme">#http-scheme</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-scheme">2.1. URL</a> <a href="#ref-for-http-scheme①">(2)</a>
    <li><a href="#ref-for-http-scheme②">3.5. CORB</a>
    <li><a href="#ref-for-http-scheme③">4.1. Main fetch</a> <a href="#ref-for-http-scheme④">(2)</a> <a href="#ref-for-http-scheme⑤">(3)</a>
    <li><a href="#ref-for-http-scheme⑥">4.2. Scheme fetch</a>
    <li><a href="#ref-for-http-scheme⑦">4.4. HTTP-redirect fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="network-scheme">
   <b><a href="#network-scheme">#network-scheme</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-network-scheme">2.1. URL</a> <a href="#ref-for-network-scheme①">(2)</a>
    <li><a href="#ref-for-network-scheme②">2.6. Port blocking</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fetch-scheme">
   <b><a href="#fetch-scheme">#fetch-scheme</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fetch-scheme">2.1. URL</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="response-url">
   <b><a href="#response-url">#response-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-response-url">2.2.6. Responses</a> <a href="#ref-for-response-url①">(2)</a> <a href="#ref-for-response-url②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-tab-or-space">
   <b><a href="#http-tab-or-space">#http-tab-or-space</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-tab-or-space">2.2. HTTP</a> <a href="#ref-for-http-tab-or-space①">(2)</a>
    <li><a href="#ref-for-http-tab-or-space②">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-whitespace">
   <b><a href="#http-whitespace">#http-whitespace</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-whitespace">2.2. HTTP</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-newline-byte">
   <b><a href="#http-newline-byte">#http-newline-byte</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-newline-byte">2.2. HTTP</a>
    <li><a href="#ref-for-http-newline-byte①">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-tab-or-space-byte">
   <b><a href="#http-tab-or-space-byte">#http-tab-or-space-byte</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-tab-or-space-byte">2.2. HTTP</a>
    <li><a href="#ref-for-http-tab-or-space-byte①">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-whitespace-byte">
   <b><a href="#http-whitespace-byte">#http-whitespace-byte</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-whitespace-byte">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-https-state-value">
   <b><a href="#concept-https-state-value">#concept-https-state-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-https-state-value">2.2.6. Responses</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="collect-an-http-quoted-string">
   <b><a href="#collect-an-http-quoted-string">#collect-an-http-quoted-string</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-collect-an-http-quoted-string">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-method">
   <b><a href="#concept-method">#concept-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-method">2.2.1. Methods</a> <a href="#ref-for-concept-method①">(2)</a> <a href="#ref-for-concept-method②">(3)</a> <a href="#ref-for-concept-method③">(4)</a> <a href="#ref-for-concept-method④">(5)</a>
    <li><a href="#ref-for-concept-method⑤">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-method⑥">3.2.2. HTTP requests</a> <a href="#ref-for-concept-method⑦">(2)</a>
    <li><a href="#ref-for-concept-method⑧">3.2.3. HTTP responses</a>
    <li><a href="#ref-for-concept-method⑨">3.2.4. HTTP new-header syntax</a>
    <li><a href="#ref-for-concept-method①⓪">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-method①①">4.8. CORS-preflight cache</a>
    <li><a href="#ref-for-concept-method①②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-safelisted-method">
   <b><a href="#cors-safelisted-method">#cors-safelisted-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-safelisted-method">2.2.5. Requests</a>
    <li><a href="#ref-for-cors-safelisted-method①">4.1. Main fetch</a>
    <li><a href="#ref-for-cors-safelisted-method②">4.3. HTTP fetch</a>
    <li><a href="#ref-for-cors-safelisted-method③">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-cors-safelisted-method④">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="forbidden-method">
   <b><a href="#forbidden-method">#forbidden-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-forbidden-method">2.2.5. Requests</a>
    <li><a href="#ref-for-forbidden-method①">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-method-normalize">
   <b><a href="#concept-method-normalize">#concept-method-normalize</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-method-normalize">2.2.1. Methods</a> <a href="#ref-for-concept-method-normalize①">(2)</a>
    <li><a href="#ref-for-concept-method-normalize②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list">
   <b><a href="#concept-header-list">#concept-header-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list">2.2.2. Headers</a> <a href="#ref-for-concept-header-list①">(2)</a> <a href="#ref-for-concept-header-list②">(3)</a> <a href="#ref-for-concept-header-list③">(4)</a> <a href="#ref-for-concept-header-list④">(5)</a> <a href="#ref-for-concept-header-list⑤">(6)</a> <a href="#ref-for-concept-header-list⑥">(7)</a> <a href="#ref-for-concept-header-list⑦">(8)</a> <a href="#ref-for-concept-header-list⑧">(9)</a> <a href="#ref-for-concept-header-list⑨">(10)</a> <a href="#ref-for-concept-header-list①⓪">(11)</a> <a href="#ref-for-concept-header-list①①">(12)</a> <a href="#ref-for-concept-header-list①②">(13)</a> <a href="#ref-for-concept-header-list①③">(14)</a> <a href="#ref-for-concept-header-list①④">(15)</a>
    <li><a href="#ref-for-concept-header-list①⑤">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-header-list①⑥">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-header-list①⑦">3.3. `Content-Type` header</a>
    <li><a href="#ref-for-concept-header-list①⑧">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-concept-header-list①⑨">5.1. Headers class</a> <a href="#ref-for-concept-header-list②⓪">(2)</a> <a href="#ref-for-concept-header-list②①">(3)</a> <a href="#ref-for-concept-header-list②②">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="header-list-contains">
   <b><a href="#header-list-contains">#header-list-contains</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-header-list-contains">2.2.2. Headers</a> <a href="#ref-for-header-list-contains①">(2)</a> <a href="#ref-for-header-list-contains②">(3)</a> <a href="#ref-for-header-list-contains③">(4)</a> <a href="#ref-for-header-list-contains④">(5)</a> <a href="#ref-for-header-list-contains⑤">(6)</a> <a href="#ref-for-header-list-contains⑥">(7)</a>
    <li><a href="#ref-for-header-list-contains⑦">2.2.5. Requests</a>
    <li><a href="#ref-for-header-list-contains⑧">4. Fetching</a> <a href="#ref-for-header-list-contains⑨">(2)</a>
    <li><a href="#ref-for-header-list-contains①⓪">4.1. Main fetch</a>
    <li><a href="#ref-for-header-list-contains①①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-header-list-contains①②">(2)</a> <a href="#ref-for-header-list-contains①③">(3)</a> <a href="#ref-for-header-list-contains①④">(4)</a> <a href="#ref-for-header-list-contains①⑤">(5)</a> <a href="#ref-for-header-list-contains①⑥">(6)</a> <a href="#ref-for-header-list-contains①⑦">(7)</a> <a href="#ref-for-header-list-contains①⑧">(8)</a> <a href="#ref-for-header-list-contains①⑨">(9)</a> <a href="#ref-for-header-list-contains②⓪">(10)</a> <a href="#ref-for-header-list-contains②①">(11)</a>
    <li><a href="#ref-for-header-list-contains②②">5.1. Headers class</a> <a href="#ref-for-header-list-contains②③">(2)</a>
    <li><a href="#ref-for-header-list-contains②④">5.3. Request class</a>
    <li><a href="#ref-for-header-list-contains②⑤">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-get">
   <b><a href="#concept-header-list-get">#concept-header-list-get</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-get">2.2.2. Headers</a> <a href="#ref-for-concept-header-list-get①">(2)</a> <a href="#ref-for-concept-header-list-get②">(3)</a>
    <li><a href="#ref-for-concept-header-list-get③">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-concept-header-list-get④">4.9. CORS check</a> <a href="#ref-for-concept-header-list-get⑤">(2)</a>
    <li><a href="#ref-for-concept-header-list-get⑥">5.1. Headers class</a> <a href="#ref-for-concept-header-list-get⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-get-decode-split">
   <b><a href="#concept-header-list-get-decode-split">#concept-header-list-get-decode-split</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-get-decode-split">2.2. HTTP</a>
    <li><a href="#ref-for-concept-header-list-get-decode-split①">2.2.2. Headers</a>
    <li><a href="#ref-for-concept-header-list-get-decode-split②">3.3. `Content-Type` header</a>
    <li><a href="#ref-for-concept-header-list-get-decode-split③">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-concept-header-list-get-decode-split④">4.10. TAO check</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-append">
   <b><a href="#concept-header-list-append">#concept-header-list-append</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-append">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-header-list-append①">3.1. `Origin` header</a> <a href="#ref-for-concept-header-list-append②">(2)</a>
    <li><a href="#ref-for-concept-header-list-append③">4. Fetching</a> <a href="#ref-for-concept-header-list-append④">(2)</a>
    <li><a href="#ref-for-concept-header-list-append⑤">4.2. Scheme fetch</a> <a href="#ref-for-concept-header-list-append⑥">(2)</a>
    <li><a href="#ref-for-concept-header-list-append⑦">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-header-list-append⑧">(2)</a> <a href="#ref-for-concept-header-list-append⑨">(3)</a> <a href="#ref-for-concept-header-list-append①⓪">(4)</a> <a href="#ref-for-concept-header-list-append①①">(5)</a> <a href="#ref-for-concept-header-list-append①②">(6)</a> <a href="#ref-for-concept-header-list-append①③">(7)</a> <a href="#ref-for-concept-header-list-append①④">(8)</a> <a href="#ref-for-concept-header-list-append①⑤">(9)</a> <a href="#ref-for-concept-header-list-append①⑥">(10)</a> <a href="#ref-for-concept-header-list-append①⑦">(11)</a> <a href="#ref-for-concept-header-list-append①⑧">(12)</a>
    <li><a href="#ref-for-concept-header-list-append①⑨">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-header-list-append②⓪">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-header-list-append②①">(2)</a> <a href="#ref-for-concept-header-list-append②②">(3)</a>
    <li><a href="#ref-for-concept-header-list-append②③">5.1. Headers class</a>
    <li><a href="#ref-for-concept-header-list-append②④">5.4. Response class</a> <a href="#ref-for-concept-header-list-append②⑤">(2)</a>
    <li><a href="#ref-for-concept-header-list-append②⑥">6.2. Opening handshake</a> <a href="#ref-for-concept-header-list-append②⑦">(2)</a> <a href="#ref-for-concept-header-list-append②⑧">(3)</a> <a href="#ref-for-concept-header-list-append②⑨">(4)</a> <a href="#ref-for-concept-header-list-append③⓪">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-delete">
   <b><a href="#concept-header-list-delete">#concept-header-list-delete</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-delete">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-header-list-delete①">5.1. Headers class</a> <a href="#ref-for-concept-header-list-delete②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-set">
   <b><a href="#concept-header-list-set">#concept-header-list-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-set">2.2.2. Headers</a>
    <li><a href="#ref-for-concept-header-list-set①">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-combine">
   <b><a href="#concept-header-list-combine">#concept-header-list-combine</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-combine">2.2.2. Headers</a>
    <li><a href="#ref-for-concept-header-list-combine①">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-header-list-combine②">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="convert-header-names-to-a-sorted-lowercase-set">
   <b><a href="#convert-header-names-to-a-sorted-lowercase-set">#convert-header-names-to-a-sorted-lowercase-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-convert-header-names-to-a-sorted-lowercase-set">2.2.2. Headers</a> <a href="#ref-for-convert-header-names-to-a-sorted-lowercase-set①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-list-sort-and-combine">
   <b><a href="#concept-header-list-sort-and-combine">#concept-header-list-sort-and-combine</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-list-sort-and-combine">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header">
   <b><a href="#concept-header">#concept-header</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header">2.2.2. Headers</a> <a href="#ref-for-concept-header①">(2)</a> <a href="#ref-for-concept-header②">(3)</a> <a href="#ref-for-concept-header③">(4)</a> <a href="#ref-for-concept-header④">(5)</a> <a href="#ref-for-concept-header⑤">(6)</a> <a href="#ref-for-concept-header⑥">(7)</a> <a href="#ref-for-concept-header⑦">(8)</a> <a href="#ref-for-concept-header⑧">(9)</a> <a href="#ref-for-concept-header⑨">(10)</a> <a href="#ref-for-concept-header①⓪">(11)</a> <a href="#ref-for-concept-header①①">(12)</a> <a href="#ref-for-concept-header①②">(13)</a> <a href="#ref-for-concept-header①③">(14)</a> <a href="#ref-for-concept-header①④">(15)</a> <a href="#ref-for-concept-header①⑤">(16)</a> <a href="#ref-for-concept-header①⑥">(17)</a> <a href="#ref-for-concept-header①⑦">(18)</a> <a href="#ref-for-concept-header①⑧">(19)</a> <a href="#ref-for-concept-header①⑨">(20)</a> <a href="#ref-for-concept-header②⓪">(21)</a> <a href="#ref-for-concept-header②①">(22)</a> <a href="#ref-for-concept-header②②">(23)</a> <a href="#ref-for-concept-header②③">(24)</a> <a href="#ref-for-concept-header②④">(25)</a> <a href="#ref-for-concept-header②⑤">(26)</a> <a href="#ref-for-concept-header②⑥">(27)</a> <a href="#ref-for-concept-header②⑦">(28)</a> <a href="#ref-for-concept-header②⑧">(29)</a> <a href="#ref-for-concept-header②⑨">(30)</a>
    <li><a href="#ref-for-concept-header③⓪">2.2.6. Responses</a> <a href="#ref-for-concept-header③①">(2)</a> <a href="#ref-for-concept-header③②">(3)</a>
    <li><a href="#ref-for-concept-header③③">3.1. `Origin` header</a> <a href="#ref-for-concept-header③④">(2)</a>
    <li><a href="#ref-for-concept-header③⑤">3.2.2. HTTP requests</a> <a href="#ref-for-concept-header③⑥">(2)</a>
    <li><a href="#ref-for-concept-header③⑦">3.2.3. HTTP responses</a> <a href="#ref-for-concept-header③⑧">(2)</a> <a href="#ref-for-concept-header③⑨">(3)</a> <a href="#ref-for-concept-header④⓪">(4)</a> <a href="#ref-for-concept-header④①">(5)</a> <a href="#ref-for-concept-header④②">(6)</a> <a href="#ref-for-concept-header④③">(7)</a> <a href="#ref-for-concept-header④④">(8)</a> <a href="#ref-for-concept-header④⑤">(9)</a>
    <li><a href="#ref-for-concept-header④⑥">3.2.4. HTTP new-header syntax</a> <a href="#ref-for-concept-header④⑦">(2)</a> <a href="#ref-for-concept-header④⑧">(3)</a>
    <li><a href="#ref-for-concept-header④⑨">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-concept-header⑤⓪">3.4. `X-Content-Type-Options` header</a> <a href="#ref-for-concept-header⑤①">(2)</a>
    <li><a href="#ref-for-concept-header⑤②">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-concept-header⑤③">4.1. Main fetch</a> <a href="#ref-for-concept-header⑤④">(2)</a>
    <li><a href="#ref-for-concept-header⑤⑤">4.2. Scheme fetch</a> <a href="#ref-for-concept-header⑤⑥">(2)</a> <a href="#ref-for-concept-header⑤⑦">(3)</a>
    <li><a href="#ref-for-concept-header⑤⑧">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-header⑤⑨">(2)</a> <a href="#ref-for-concept-header⑥⓪">(3)</a> <a href="#ref-for-concept-header⑥①">(4)</a>
    <li><a href="#ref-for-concept-header⑥②">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-header⑥③">(2)</a>
    <li><a href="#ref-for-concept-header⑥④">4.8. CORS-preflight cache</a>
    <li><a href="#ref-for-concept-header⑥⑤">5.1. Headers class</a>
    <li><a href="#ref-for-concept-header⑥⑥">6.2. Opening handshake</a>
    <li><a href="#ref-for-concept-header⑥⑦">Basic safe CORS protocol setup</a> <a href="#ref-for-concept-header⑥⑧">(2)</a> <a href="#ref-for-concept-header⑥⑨">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-name">
   <b><a href="#concept-header-name">#concept-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-name">2.2.2. Headers</a> <a href="#ref-for-concept-header-name①">(2)</a> <a href="#ref-for-concept-header-name②">(3)</a> <a href="#ref-for-concept-header-name③">(4)</a> <a href="#ref-for-concept-header-name④">(5)</a> <a href="#ref-for-concept-header-name⑤">(6)</a> <a href="#ref-for-concept-header-name⑥">(7)</a> <a href="#ref-for-concept-header-name⑦">(8)</a> <a href="#ref-for-concept-header-name⑧">(9)</a> <a href="#ref-for-concept-header-name⑨">(10)</a> <a href="#ref-for-concept-header-name①⓪">(11)</a> <a href="#ref-for-concept-header-name①①">(12)</a> <a href="#ref-for-concept-header-name①②">(13)</a> <a href="#ref-for-concept-header-name①③">(14)</a> <a href="#ref-for-concept-header-name①④">(15)</a> <a href="#ref-for-concept-header-name①⑤">(16)</a> <a href="#ref-for-concept-header-name①⑥">(17)</a> <a href="#ref-for-concept-header-name①⑦">(18)</a> <a href="#ref-for-concept-header-name①⑧">(19)</a> <a href="#ref-for-concept-header-name①⑨">(20)</a> <a href="#ref-for-concept-header-name②⓪">(21)</a> <a href="#ref-for-concept-header-name②①">(22)</a> <a href="#ref-for-concept-header-name②②">(23)</a> <a href="#ref-for-concept-header-name②③">(24)</a> <a href="#ref-for-concept-header-name②④">(25)</a> <a href="#ref-for-concept-header-name②⑤">(26)</a> <a href="#ref-for-concept-header-name②⑥">(27)</a> <a href="#ref-for-concept-header-name②⑦">(28)</a> <a href="#ref-for-concept-header-name②⑧">(29)</a> <a href="#ref-for-concept-header-name②⑨">(30)</a> <a href="#ref-for-concept-header-name③⓪">(31)</a> <a href="#ref-for-concept-header-name③①">(32)</a> <a href="#ref-for-concept-header-name③②">(33)</a> <a href="#ref-for-concept-header-name③③">(34)</a> <a href="#ref-for-concept-header-name③④">(35)</a> <a href="#ref-for-concept-header-name③⑤">(36)</a> <a href="#ref-for-concept-header-name③⑥">(37)</a> <a href="#ref-for-concept-header-name③⑦">(38)</a>
    <li><a href="#ref-for-concept-header-name③⑧">2.2.6. Responses</a> <a href="#ref-for-concept-header-name③⑨">(2)</a> <a href="#ref-for-concept-header-name④⓪">(3)</a>
    <li><a href="#ref-for-concept-header-name④①">3.2.3. HTTP responses</a>
    <li><a href="#ref-for-concept-header-name④②">3.2.4. HTTP new-header syntax</a>
    <li><a href="#ref-for-concept-header-name④③">4.1. Main fetch</a> <a href="#ref-for-concept-header-name④④">(2)</a>
    <li><a href="#ref-for-concept-header-name④⑤">4.2. Scheme fetch</a> <a href="#ref-for-concept-header-name④⑥">(2)</a> <a href="#ref-for-concept-header-name④⑦">(3)</a>
    <li><a href="#ref-for-concept-header-name④⑧">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-header-name④⑨">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-header-name⑤⓪">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-header-name⑤①">4.8. CORS-preflight cache</a>
    <li><a href="#ref-for-concept-header-name⑤②">5.1. Headers class</a> <a href="#ref-for-concept-header-name⑤③">(2)</a> <a href="#ref-for-concept-header-name⑤④">(3)</a> <a href="#ref-for-concept-header-name⑤⑤">(4)</a> <a href="#ref-for-concept-header-name⑤⑥">(5)</a> <a href="#ref-for-concept-header-name⑤⑦">(6)</a>
    <li><a href="#ref-for-concept-header-name⑤⑧">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-value">
   <b><a href="#concept-header-value">#concept-header-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-value">2.2.2. Headers</a> <a href="#ref-for-concept-header-value①">(2)</a> <a href="#ref-for-concept-header-value②">(3)</a> <a href="#ref-for-concept-header-value③">(4)</a> <a href="#ref-for-concept-header-value④">(5)</a> <a href="#ref-for-concept-header-value⑤">(6)</a> <a href="#ref-for-concept-header-value⑥">(7)</a> <a href="#ref-for-concept-header-value⑦">(8)</a> <a href="#ref-for-concept-header-value⑧">(9)</a> <a href="#ref-for-concept-header-value⑨">(10)</a> <a href="#ref-for-concept-header-value①⓪">(11)</a> <a href="#ref-for-concept-header-value①①">(12)</a> <a href="#ref-for-concept-header-value①②">(13)</a> <a href="#ref-for-concept-header-value①③">(14)</a> <a href="#ref-for-concept-header-value①④">(15)</a> <a href="#ref-for-concept-header-value①⑤">(16)</a> <a href="#ref-for-concept-header-value①⑥">(17)</a> <a href="#ref-for-concept-header-value①⑦">(18)</a> <a href="#ref-for-concept-header-value①⑧">(19)</a> <a href="#ref-for-concept-header-value①⑨">(20)</a> <a href="#ref-for-concept-header-value②⓪">(21)</a> <a href="#ref-for-concept-header-value②①">(22)</a> <a href="#ref-for-concept-header-value②②">(23)</a>
    <li><a href="#ref-for-concept-header-value②③">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-header-value②④">3.2.3. HTTP responses</a>
    <li><a href="#ref-for-concept-header-value②⑤">3.2.4. HTTP new-header syntax</a> <a href="#ref-for-concept-header-value②⑥">(2)</a>
    <li><a href="#ref-for-concept-header-value②⑦">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-concept-header-value②⑧">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-concept-header-value②⑨">4. Fetching</a>
    <li><a href="#ref-for-concept-header-value③⓪">4.2. Scheme fetch</a> <a href="#ref-for-concept-header-value③①">(2)</a> <a href="#ref-for-concept-header-value③②">(3)</a>
    <li><a href="#ref-for-concept-header-value③③">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-header-value③④">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-header-value③⑤">5.1. Headers class</a> <a href="#ref-for-concept-header-value③⑥">(2)</a> <a href="#ref-for-concept-header-value③⑦">(3)</a>
    <li><a href="#ref-for-concept-header-value③⑧">5.2. Body mixin</a> <a href="#ref-for-concept-header-value③⑨">(2)</a>
    <li><a href="#ref-for-concept-header-value④⓪">5.3. Request class</a>
    <li><a href="#ref-for-concept-header-value④①">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-value-normalize">
   <b><a href="#concept-header-value-normalize">#concept-header-value-normalize</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-value-normalize">5.1. Headers class</a> <a href="#ref-for-concept-header-value-normalize①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-safelisted-request-header">
   <b><a href="#cors-safelisted-request-header">#cors-safelisted-request-header</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-safelisted-request-header">2.2.2. Headers</a> <a href="#ref-for-cors-safelisted-request-header①">(2)</a>
    <li><a href="#ref-for-cors-safelisted-request-header②">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-unsafe-request-header-byte">
   <b><a href="#cors-unsafe-request-header-byte">#cors-unsafe-request-header-byte</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-unsafe-request-header-byte">2.2.2. Headers</a> <a href="#ref-for-cors-unsafe-request-header-byte①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-unsafe-request-header-names">
   <b><a href="#cors-unsafe-request-header-names">#cors-unsafe-request-header-names</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-unsafe-request-header-names">4.1. Main fetch</a>
    <li><a href="#ref-for-cors-unsafe-request-header-names①">4.3. HTTP fetch</a>
    <li><a href="#ref-for-cors-unsafe-request-header-names②">4.7. CORS-preflight fetch</a> <a href="#ref-for-cors-unsafe-request-header-names③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-non-wildcard-request-header-name">
   <b><a href="#cors-non-wildcard-request-header-name">#cors-non-wildcard-request-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-non-wildcard-request-header-name">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-cors-non-wildcard-request-header-name①">4.8. CORS-preflight cache</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="privileged-no-cors-request-header-name">
   <b><a href="#privileged-no-cors-request-header-name">#privileged-no-cors-request-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-privileged-no-cors-request-header-name">5.1. Headers class</a> <a href="#ref-for-privileged-no-cors-request-header-name①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-safelisted-response-header-name">
   <b><a href="#cors-safelisted-response-header-name">#cors-safelisted-response-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-safelisted-response-header-name">2.2.6. Responses</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="no-cors-safelisted-request-header-name">
   <b><a href="#no-cors-safelisted-request-header-name">#no-cors-safelisted-request-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-no-cors-safelisted-request-header-name">2.2.2. Headers</a>
    <li><a href="#ref-for-no-cors-safelisted-request-header-name①">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="no-cors-safelisted-request-header">
   <b><a href="#no-cors-safelisted-request-header">#no-cors-safelisted-request-header</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-no-cors-safelisted-request-header">5.1. Headers class</a> <a href="#ref-for-no-cors-safelisted-request-header①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="forbidden-header-name">
   <b><a href="#forbidden-header-name">#forbidden-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-forbidden-header-name">2.2.5. Requests</a>
    <li><a href="#ref-for-forbidden-header-name①">5.1. Headers class</a> <a href="#ref-for-forbidden-header-name②">(2)</a> <a href="#ref-for-forbidden-header-name③">(3)</a>
    <li><a href="#ref-for-forbidden-header-name④">HTTP header layer division</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="forbidden-response-header-name">
   <b><a href="#forbidden-response-header-name">#forbidden-response-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-forbidden-response-header-name">2.2.2. Headers</a>
    <li><a href="#ref-for-forbidden-response-header-name①">2.2.6. Responses</a>
    <li><a href="#ref-for-forbidden-response-header-name②">5.1. Headers class</a> <a href="#ref-for-forbidden-response-header-name③">(2)</a> <a href="#ref-for-forbidden-response-header-name④">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request-body-header-name">
   <b><a href="#request-body-header-name">#request-body-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-body-header-name">4.4. HTTP-redirect fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="extract-header-values">
   <b><a href="#extract-header-values">#extract-header-values</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-extract-header-values">2.2.2. Headers</a>
    <li><a href="#ref-for-extract-header-values①">2.2.6. Responses</a> <a href="#ref-for-extract-header-values②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="extract-header-list-values">
   <b><a href="#extract-header-list-values">#extract-header-list-values</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-extract-header-list-values">4.1. Main fetch</a>
    <li><a href="#ref-for-extract-header-list-values①">4.3. HTTP fetch</a>
    <li><a href="#ref-for-extract-header-list-values②">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-extract-header-list-values③">4.7. CORS-preflight fetch</a> <a href="#ref-for-extract-header-list-values④">(2)</a> <a href="#ref-for-extract-header-list-values⑤">(3)</a>
    <li><a href="#ref-for-extract-header-list-values⑥">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="default-user-agent-value">
   <b><a href="#default-user-agent-value">#default-user-agent-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-default-user-agent-value">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-status">
   <b><a href="#concept-status">#concept-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-status">2.2.3. Statuses</a> <a href="#ref-for-concept-status①">(2)</a> <a href="#ref-for-concept-status②">(3)</a>
    <li><a href="#ref-for-concept-status③">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-status④">3.2.3. HTTP responses</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="null-body-status">
   <b><a href="#null-body-status">#null-body-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-null-body-status">4.1. Main fetch</a>
    <li><a href="#ref-for-null-body-status①">5.4. Response class</a> <a href="#ref-for-null-body-status②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="ok-status">
   <b><a href="#ok-status">#ok-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ok-status">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-ok-status①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="redirect-status">
   <b><a href="#redirect-status">#redirect-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-redirect-status">4.3. HTTP fetch</a>
    <li><a href="#ref-for-redirect-status①">5.4. Response class</a>
    <li><a href="#ref-for-redirect-status②">Atomic HTTP redirect handling</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body">
   <b><a href="#concept-body">#concept-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body">2.2.4. Bodies</a> <a href="#ref-for-concept-body①">(2)</a> <a href="#ref-for-concept-body②">(3)</a> <a href="#ref-for-concept-body③">(4)</a>
    <li><a href="#ref-for-concept-body④">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-body⑤">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-body⑥">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-body⑦">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-body⑧">5.2. Body mixin</a> <a href="#ref-for-concept-body⑨">(2)</a> <a href="#ref-for-concept-body①⓪">(3)</a> <a href="#ref-for-concept-body①①">(4)</a>
    <li><a href="#ref-for-concept-body①②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-stream">
   <b><a href="#concept-body-stream">#concept-body-stream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-stream">2.2.4. Bodies</a> <a href="#ref-for-concept-body-stream①">(2)</a> <a href="#ref-for-concept-body-stream②">(3)</a> <a href="#ref-for-concept-body-stream③">(4)</a>
    <li><a href="#ref-for-concept-body-stream④">2.2.5. Requests</a> <a href="#ref-for-concept-body-stream⑤">(2)</a> <a href="#ref-for-concept-body-stream⑥">(3)</a>
    <li><a href="#ref-for-concept-body-stream⑦">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-body-stream⑧">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-body-stream⑨">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-body-stream①⓪">(2)</a>
    <li><a href="#ref-for-concept-body-stream①①">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-body-stream①②">(2)</a>
    <li><a href="#ref-for-concept-body-stream①③">5.2. Body mixin</a> <a href="#ref-for-concept-body-stream①④">(2)</a> <a href="#ref-for-concept-body-stream①⑤">(3)</a> <a href="#ref-for-concept-body-stream①⑥">(4)</a> <a href="#ref-for-concept-body-stream①⑦">(5)</a>
    <li><a href="#ref-for-concept-body-stream①⑧">5.3. Request class</a> <a href="#ref-for-concept-body-stream①⑨">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-transmitted">
   <b><a href="#concept-body-transmitted">#concept-body-transmitted</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-transmitted">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-body-transmitted①">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-total-bytes">
   <b><a href="#concept-body-total-bytes">#concept-body-total-bytes</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-total-bytes">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-body-total-bytes①">(2)</a>
    <li><a href="#ref-for-concept-body-total-bytes②">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-body-total-bytes③">5.3. Request class</a> <a href="#ref-for-concept-body-total-bytes④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-source">
   <b><a href="#concept-body-source">#concept-body-source</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-source">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-body-source①">(2)</a> <a href="#ref-for-concept-body-source②">(3)</a>
    <li><a href="#ref-for-concept-body-source③">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-body-source④">(2)</a> <a href="#ref-for-concept-body-source⑤">(3)</a> <a href="#ref-for-concept-body-source⑥">(4)</a> <a href="#ref-for-concept-body-source⑦">(5)</a> <a href="#ref-for-concept-body-source⑧">(6)</a>
    <li><a href="#ref-for-concept-body-source⑨">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-body-source①⓪">5.2. Body mixin</a>
    <li><a href="#ref-for-concept-body-source①①">5.3. Request class</a> <a href="#ref-for-concept-body-source①②">(2)</a> <a href="#ref-for-concept-body-source①③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-done">
   <b><a href="#concept-body-done">#concept-body-done</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-done">2.2.4. Bodies</a>
    <li><a href="#ref-for-concept-body-done①">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-wait">
   <b><a href="#concept-body-wait">#concept-body-wait</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-wait">4.1. Main fetch</a> <a href="#ref-for-concept-body-wait①">(2)</a> <a href="#ref-for-concept-body-wait②">(3)</a> <a href="#ref-for-concept-body-wait③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-clone">
   <b><a href="#concept-body-clone">#concept-body-clone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-clone">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-body-clone①">2.2.6. Responses</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="handle-content-codings">
   <b><a href="#handle-content-codings">#handle-content-codings</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-handle-content-codings">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-handle-content-codings①">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request">
   <b><a href="#concept-request">#concept-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request">2. Infrastructure</a>
    <li><a href="#ref-for-concept-request①">2.2.5. Requests</a> <a href="#ref-for-concept-request②">(2)</a> <a href="#ref-for-concept-request③">(3)</a> <a href="#ref-for-concept-request④">(4)</a> <a href="#ref-for-concept-request⑤">(5)</a> <a href="#ref-for-concept-request⑥">(6)</a> <a href="#ref-for-concept-request⑦">(7)</a> <a href="#ref-for-concept-request⑧">(8)</a> <a href="#ref-for-concept-request⑨">(9)</a> <a href="#ref-for-concept-request①⓪">(10)</a> <a href="#ref-for-concept-request①①">(11)</a> <a href="#ref-for-concept-request①②">(12)</a> <a href="#ref-for-concept-request①③">(13)</a> <a href="#ref-for-concept-request①④">(14)</a> <a href="#ref-for-concept-request①⑤">(15)</a> <a href="#ref-for-concept-request①⑥">(16)</a> <a href="#ref-for-concept-request①⑦">(17)</a> <a href="#ref-for-concept-request①⑧">(18)</a> <a href="#ref-for-concept-request①⑨">(19)</a> <a href="#ref-for-concept-request②⓪">(20)</a> <a href="#ref-for-concept-request②①">(21)</a> <a href="#ref-for-concept-request②②">(22)</a> <a href="#ref-for-concept-request②③">(23)</a> <a href="#ref-for-concept-request②④">(24)</a> <a href="#ref-for-concept-request②⑤">(25)</a> <a href="#ref-for-concept-request②⑥">(26)</a> <a href="#ref-for-concept-request②⑦">(27)</a> <a href="#ref-for-concept-request②⑧">(28)</a> <a href="#ref-for-concept-request②⑨">(29)</a> <a href="#ref-for-concept-request③⓪">(30)</a> <a href="#ref-for-concept-request③①">(31)</a> <a href="#ref-for-concept-request③②">(32)</a> <a href="#ref-for-concept-request③③">(33)</a> <a href="#ref-for-concept-request③④">(34)</a> <a href="#ref-for-concept-request③⑤">(35)</a> <a href="#ref-for-concept-request③⑥">(36)</a> <a href="#ref-for-concept-request③⑦">(37)</a> <a href="#ref-for-concept-request③⑧">(38)</a> <a href="#ref-for-concept-request③⑨">(39)</a> <a href="#ref-for-concept-request④⓪">(40)</a> <a href="#ref-for-concept-request④①">(41)</a> <a href="#ref-for-concept-request④②">(42)</a> <a href="#ref-for-concept-request④③">(43)</a> <a href="#ref-for-concept-request④④">(44)</a> <a href="#ref-for-concept-request④⑤">(45)</a> <a href="#ref-for-concept-request④⑥">(46)</a> <a href="#ref-for-concept-request④⑦">(47)</a> <a href="#ref-for-concept-request④⑧">(48)</a> <a href="#ref-for-concept-request④⑨">(49)</a> <a href="#ref-for-concept-request⑤⓪">(50)</a> <a href="#ref-for-concept-request⑤①">(51)</a> <a href="#ref-for-concept-request⑤②">(52)</a> <a href="#ref-for-concept-request⑤③">(53)</a> <a href="#ref-for-concept-request⑤④">(54)</a> <a href="#ref-for-concept-request⑤⑤">(55)</a> <a href="#ref-for-concept-request⑤⑥">(56)</a> <a href="#ref-for-concept-request⑤⑦">(57)</a> <a href="#ref-for-concept-request⑤⑧">(58)</a> <a href="#ref-for-concept-request⑤⑨">(59)</a> <a href="#ref-for-concept-request⑥⓪">(60)</a> <a href="#ref-for-concept-request⑥①">(61)</a> <a href="#ref-for-concept-request⑥②">(62)</a> <a href="#ref-for-concept-request⑥③">(63)</a> <a href="#ref-for-concept-request⑥④">(64)</a> <a href="#ref-for-concept-request⑥⑤">(65)</a> <a href="#ref-for-concept-request⑥⑥">(66)</a> <a href="#ref-for-concept-request⑥⑦">(67)</a>
    <li><a href="#ref-for-concept-request⑥⑧">2.3. Authentication entries</a>
    <li><a href="#ref-for-concept-request⑥⑨">2.4. Fetch groups</a>
    <li><a href="#ref-for-concept-request⑦⓪">2.6. Port blocking</a>
    <li><a href="#ref-for-concept-request⑦①">3.1. `Origin` header</a> <a href="#ref-for-concept-request⑦②">(2)</a> <a href="#ref-for-concept-request⑦③">(3)</a> <a href="#ref-for-concept-request⑦④">(4)</a>
    <li><a href="#ref-for-concept-request⑦⑤">3.2. CORS protocol</a>
    <li><a href="#ref-for-concept-request⑦⑥">3.2.1. General</a> <a href="#ref-for-concept-request⑦⑦">(2)</a>
    <li><a href="#ref-for-concept-request⑦⑧">3.2.2. HTTP requests</a>
    <li><a href="#ref-for-concept-request⑦⑨">3.2.3. HTTP responses</a> <a href="#ref-for-concept-request⑧⓪">(2)</a>
    <li><a href="#ref-for-concept-request⑧①">3.2.4. HTTP new-header syntax</a> <a href="#ref-for-concept-request⑧②">(2)</a>
    <li><a href="#ref-for-concept-request⑧③">3.2.5. CORS protocol and credentials</a> <a href="#ref-for-concept-request⑧④">(2)</a> <a href="#ref-for-concept-request⑧⑤">(3)</a> <a href="#ref-for-concept-request⑧⑥">(4)</a> <a href="#ref-for-concept-request⑧⑦">(5)</a> <a href="#ref-for-concept-request⑧⑧">(6)</a>
    <li><a href="#ref-for-concept-request⑧⑨">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-concept-request⑨⓪">3.4.1. Should
response to request be blocked due to nosniff?</a>
    <li><a href="#ref-for-concept-request⑨①">3.6. `Cross-Origin-Resource-Policy` header</a> <a href="#ref-for-concept-request⑨②">(2)</a> <a href="#ref-for-concept-request⑨③">(3)</a>
    <li><a href="#ref-for-concept-request⑨④">4. Fetching</a> <a href="#ref-for-concept-request⑨⑤">(2)</a> <a href="#ref-for-concept-request⑨⑥">(3)</a> <a href="#ref-for-concept-request⑨⑦">(4)</a> <a href="#ref-for-concept-request⑨⑧">(5)</a>
    <li><a href="#ref-for-concept-request⑨⑨">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-request①⓪⓪">5.1. Headers class</a>
    <li><a href="#ref-for-concept-request①⓪①">5.3. Request class</a> <a href="#ref-for-concept-request①⓪②">(2)</a> <a href="#ref-for-concept-request①⓪③">(3)</a> <a href="#ref-for-concept-request①⓪④">(4)</a>
    <li><a href="#ref-for-concept-request①⓪⑤">6.2. Opening handshake</a>
    <li><a href="#ref-for-concept-request①⓪⑥">HTTP header layer division</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-method">
   <b><a href="#concept-request-method">#concept-request-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-method">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-method①">3.1. `Origin` header</a> <a href="#ref-for-concept-request-method②">(2)</a>
    <li><a href="#ref-for-concept-request-method③">3.2.2. HTTP requests</a>
    <li><a href="#ref-for-concept-request-method④">4.1. Main fetch</a> <a href="#ref-for-concept-request-method⑤">(2)</a>
    <li><a href="#ref-for-concept-request-method⑥">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-request-method⑦">4.3. HTTP fetch</a> <a href="#ref-for-concept-request-method⑧">(2)</a>
    <li><a href="#ref-for-concept-request-method⑨">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-request-method①⓪">(2)</a> <a href="#ref-for-concept-request-method①①">(3)</a>
    <li><a href="#ref-for-concept-request-method①②">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-method①③">(2)</a>
    <li><a href="#ref-for-concept-request-method①④">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-method①⑤">(2)</a> <a href="#ref-for-concept-request-method①⑥">(3)</a> <a href="#ref-for-concept-request-method①⑦">(4)</a> <a href="#ref-for-concept-request-method①⑧">(5)</a>
    <li><a href="#ref-for-concept-request-method①⑨">5.3. Request class</a> <a href="#ref-for-concept-request-method②⓪">(2)</a> <a href="#ref-for-concept-request-method②①">(3)</a> <a href="#ref-for-concept-request-method②②">(4)</a> <a href="#ref-for-concept-request-method②③">(5)</a> <a href="#ref-for-concept-request-method②④">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-url">
   <b><a href="#concept-request-url">#concept-request-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-url">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-url①">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-request-url②">5.3. Request class</a> <a href="#ref-for-concept-request-url③">(2)</a> <a href="#ref-for-concept-request-url④">(3)</a>
    <li><a href="#ref-for-concept-request-url⑤">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="local-urls-only-flag">
   <b><a href="#local-urls-only-flag">#local-urls-only-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-local-urls-only-flag">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-header-list">
   <b><a href="#concept-request-header-list">#concept-request-header-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-header-list">2.2.5. Requests</a> <a href="#ref-for-concept-request-header-list①">(2)</a> <a href="#ref-for-concept-request-header-list②">(3)</a>
    <li><a href="#ref-for-concept-request-header-list③">3.1. `Origin` header</a> <a href="#ref-for-concept-request-header-list④">(2)</a>
    <li><a href="#ref-for-concept-request-header-list⑤">4. Fetching</a> <a href="#ref-for-concept-request-header-list⑥">(2)</a> <a href="#ref-for-concept-request-header-list⑦">(3)</a> <a href="#ref-for-concept-request-header-list⑧">(4)</a>
    <li><a href="#ref-for-concept-request-header-list⑨">4.1. Main fetch</a> <a href="#ref-for-concept-request-header-list①⓪">(2)</a>
    <li><a href="#ref-for-concept-request-header-list①①">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-request-header-list①②">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-request-header-list①③">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-header-list①④">(2)</a> <a href="#ref-for-concept-request-header-list①⑤">(3)</a> <a href="#ref-for-concept-request-header-list①⑥">(4)</a> <a href="#ref-for-concept-request-header-list①⑦">(5)</a> <a href="#ref-for-concept-request-header-list①⑧">(6)</a> <a href="#ref-for-concept-request-header-list①⑨">(7)</a> <a href="#ref-for-concept-request-header-list②⓪">(8)</a> <a href="#ref-for-concept-request-header-list②①">(9)</a> <a href="#ref-for-concept-request-header-list②②">(10)</a> <a href="#ref-for-concept-request-header-list②③">(11)</a> <a href="#ref-for-concept-request-header-list②④">(12)</a> <a href="#ref-for-concept-request-header-list②⑤">(13)</a> <a href="#ref-for-concept-request-header-list②⑥">(14)</a> <a href="#ref-for-concept-request-header-list②⑦">(15)</a> <a href="#ref-for-concept-request-header-list②⑧">(16)</a> <a href="#ref-for-concept-request-header-list②⑨">(17)</a> <a href="#ref-for-concept-request-header-list③⓪">(18)</a> <a href="#ref-for-concept-request-header-list③①">(19)</a> <a href="#ref-for-concept-request-header-list③②">(20)</a> <a href="#ref-for-concept-request-header-list③③">(21)</a>
    <li><a href="#ref-for-concept-request-header-list③④">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-request-header-list③⑤">(2)</a>
    <li><a href="#ref-for-concept-request-header-list③⑥">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-header-list③⑦">(2)</a> <a href="#ref-for-concept-request-header-list③⑧">(3)</a> <a href="#ref-for-concept-request-header-list③⑨">(4)</a> <a href="#ref-for-concept-request-header-list④⓪">(5)</a> <a href="#ref-for-concept-request-header-list④①">(6)</a>
    <li><a href="#ref-for-concept-request-header-list④②">5.3. Request class</a> <a href="#ref-for-concept-request-header-list④③">(2)</a> <a href="#ref-for-concept-request-header-list④④">(3)</a> <a href="#ref-for-concept-request-header-list④⑤">(4)</a>
    <li><a href="#ref-for-concept-request-header-list④⑥">6.2. Opening handshake</a> <a href="#ref-for-concept-request-header-list④⑦">(2)</a> <a href="#ref-for-concept-request-header-list④⑧">(3)</a> <a href="#ref-for-concept-request-header-list④⑨">(4)</a> <a href="#ref-for-concept-request-header-list⑤⓪">(5)</a> <a href="#ref-for-concept-request-header-list⑤①">(6)</a> <a href="#ref-for-concept-request-header-list⑤②">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="unsafe-request-flag">
   <b><a href="#unsafe-request-flag">#unsafe-request-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-unsafe-request-flag">2.2.5. Requests</a>
    <li><a href="#ref-for-unsafe-request-flag①">4.1. Main fetch</a>
    <li><a href="#ref-for-unsafe-request-flag②">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-body">
   <b><a href="#concept-request-body">#concept-request-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-body">2.2.5. Requests</a> <a href="#ref-for-concept-request-body①">(2)</a> <a href="#ref-for-concept-request-body②">(3)</a> <a href="#ref-for-concept-request-body③">(4)</a> <a href="#ref-for-concept-request-body④">(5)</a>
    <li><a href="#ref-for-concept-request-body⑤">4.1. Main fetch</a> <a href="#ref-for-concept-request-body⑥">(2)</a>
    <li><a href="#ref-for-concept-request-body⑦">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-request-body⑧">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-request-body⑨">(2)</a> <a href="#ref-for-concept-request-body①⓪">(3)</a> <a href="#ref-for-concept-request-body①①">(4)</a> <a href="#ref-for-concept-request-body①②">(5)</a> <a href="#ref-for-concept-request-body①③">(6)</a> <a href="#ref-for-concept-request-body①④">(7)</a>
    <li><a href="#ref-for-concept-request-body①⑤">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-body①⑥">(2)</a> <a href="#ref-for-concept-request-body①⑦">(3)</a> <a href="#ref-for-concept-request-body①⑧">(4)</a> <a href="#ref-for-concept-request-body①⑨">(5)</a> <a href="#ref-for-concept-request-body②⓪">(6)</a> <a href="#ref-for-concept-request-body②①">(7)</a> <a href="#ref-for-concept-request-body②②">(8)</a> <a href="#ref-for-concept-request-body②③">(9)</a> <a href="#ref-for-concept-request-body②④">(10)</a> <a href="#ref-for-concept-request-body②⑤">(11)</a> <a href="#ref-for-concept-request-body②⑥">(12)</a> <a href="#ref-for-concept-request-body②⑦">(13)</a> <a href="#ref-for-concept-request-body②⑧">(14)</a> <a href="#ref-for-concept-request-body②⑨">(15)</a>
    <li><a href="#ref-for-concept-request-body③⓪">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-request-body③①">(2)</a>
    <li><a href="#ref-for-concept-request-body③②">5.3. Request class</a> <a href="#ref-for-concept-request-body③③">(2)</a> <a href="#ref-for-concept-request-body③④">(3)</a> <a href="#ref-for-concept-request-body③⑤">(4)</a>
    <li><a href="#ref-for-concept-request-body③⑥">5.5. Fetch method</a> <a href="#ref-for-concept-request-body③⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-client">
   <b><a href="#concept-request-client">#concept-request-client</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-client">2. Infrastructure</a> <a href="#ref-for-concept-request-client①">(2)</a>
    <li><a href="#ref-for-concept-request-client②">2.2.5. Requests</a> <a href="#ref-for-concept-request-client③">(2)</a>
    <li><a href="#ref-for-concept-request-client④">4. Fetching</a> <a href="#ref-for-concept-request-client⑤">(2)</a> <a href="#ref-for-concept-request-client⑥">(3)</a> <a href="#ref-for-concept-request-client⑦">(4)</a>
    <li><a href="#ref-for-concept-request-client⑧">4.1. Main fetch</a> <a href="#ref-for-concept-request-client⑨">(2)</a> <a href="#ref-for-concept-request-client①⓪">(3)</a>
    <li><a href="#ref-for-concept-request-client①①">4.2. Scheme fetch</a> <a href="#ref-for-concept-request-client①②">(2)</a> <a href="#ref-for-concept-request-client①③">(3)</a> <a href="#ref-for-concept-request-client①④">(4)</a> <a href="#ref-for-concept-request-client①⑤">(5)</a> <a href="#ref-for-concept-request-client①⑥">(6)</a>
    <li><a href="#ref-for-concept-request-client①⑦">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-client①⑧">(2)</a>
    <li><a href="#ref-for-concept-request-client①⑨">5.3. Request class</a>
    <li><a href="#ref-for-concept-request-client②⓪">5.5. Fetch method</a>
    <li><a href="#ref-for-concept-request-client②①">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-reserved-client">
   <b><a href="#concept-request-reserved-client">#concept-request-reserved-client</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-reserved-client">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-window">
   <b><a href="#concept-request-window">#concept-request-window</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-window">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-window①">4. Fetching</a> <a href="#ref-for-concept-request-window②">(2)</a>
    <li><a href="#ref-for-concept-request-window③">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-window④">(2)</a> <a href="#ref-for-concept-request-window⑤">(3)</a> <a href="#ref-for-concept-request-window⑥">(4)</a> <a href="#ref-for-concept-request-window⑦">(5)</a>
    <li><a href="#ref-for-concept-request-window⑧">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-request-window⑨">(2)</a>
    <li><a href="#ref-for-concept-request-window①⓪">5.3. Request class</a> <a href="#ref-for-concept-request-window①①">(2)</a> <a href="#ref-for-concept-request-window①②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request-keepalive-flag">
   <b><a href="#request-keepalive-flag">#request-keepalive-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-keepalive-flag">2.4. Fetch groups</a>
    <li><a href="#ref-for-request-keepalive-flag①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-request-keepalive-flag②">(2)</a>
    <li><a href="#ref-for-request-keepalive-flag③">5.3. Request class</a> <a href="#ref-for-request-keepalive-flag④">(2)</a> <a href="#ref-for-request-keepalive-flag⑤">(3)</a> <a href="#ref-for-request-keepalive-flag⑥">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request-service-workers-mode">
   <b><a href="#request-service-workers-mode">#request-service-workers-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-service-workers-mode">4.3. HTTP fetch</a> <a href="#ref-for-request-service-workers-mode①">(2)</a>
    <li><a href="#ref-for-request-service-workers-mode②">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-request-service-workers-mode③">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-request-service-workers-mode④">5.5. Fetch method</a>
    <li><a href="#ref-for-request-service-workers-mode⑤">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-initiator">
   <b><a href="#concept-request-initiator">#concept-request-initiator</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-initiator">2.2.5. Requests</a> <a href="#ref-for-concept-request-initiator①">(2)</a> <a href="#ref-for-concept-request-initiator②">(3)</a>
    <li><a href="#ref-for-concept-request-initiator③">3.5. CORB</a>
    <li><a href="#ref-for-concept-request-initiator④">4. Fetching</a>
    <li><a href="#ref-for-concept-request-initiator⑤">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-initiator⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-destination">
   <b><a href="#concept-request-destination">#concept-request-destination</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-destination">2.2.5. Requests</a> <a href="#ref-for-concept-request-destination①">(2)</a> <a href="#ref-for-concept-request-destination②">(3)</a> <a href="#ref-for-concept-request-destination③">(4)</a> <a href="#ref-for-concept-request-destination④">(5)</a> <a href="#ref-for-concept-request-destination⑤">(6)</a> <a href="#ref-for-concept-request-destination⑥">(7)</a>
    <li><a href="#ref-for-concept-request-destination⑦">2.2.7. Miscellaneous</a> <a href="#ref-for-concept-request-destination⑧">(2)</a>
    <li><a href="#ref-for-concept-request-destination⑨">2.7. Should
response to request be blocked due to its MIME type?</a>
    <li><a href="#ref-for-concept-request-destination①⓪">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-concept-request-destination①①">3.4.1. Should
response to request be blocked due to nosniff?</a> <a href="#ref-for-concept-request-destination①②">(2)</a>
    <li><a href="#ref-for-concept-request-destination①③">4. Fetching</a> <a href="#ref-for-concept-request-destination①④">(2)</a>
    <li><a href="#ref-for-concept-request-destination①⑤">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-destination①⑥">(2)</a>
    <li><a href="#ref-for-concept-request-destination①⑦">5.3. Request class</a> <a href="#ref-for-concept-request-destination①⑧">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request-destination-script-like">
   <b><a href="#request-destination-script-like">#request-destination-script-like</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-destination-script-like">2.2.5. Requests</a>
    <li><a href="#ref-for-request-destination-script-like①">2.7. Should
response to request be blocked due to its MIME type?</a>
    <li><a href="#ref-for-request-destination-script-like②">3.4.1. Should
response to request be blocked due to nosniff?</a> <a href="#ref-for-request-destination-script-like③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-priority">
   <b><a href="#concept-request-priority">#concept-request-priority</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-priority">4. Fetching</a> <a href="#ref-for-concept-request-priority①">(2)</a>
    <li><a href="#ref-for-concept-request-priority②">5.3. Request class</a> <a href="#ref-for-concept-request-priority③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-origin">
   <b><a href="#concept-request-origin">#concept-request-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-origin">2.2.5. Requests</a> <a href="#ref-for-concept-request-origin①">(2)</a>
    <li><a href="#ref-for-concept-request-origin②">3.1. `Origin` header</a> <a href="#ref-for-concept-request-origin③">(2)</a>
    <li><a href="#ref-for-concept-request-origin④">3.6. `Cross-Origin-Resource-Policy` header</a> <a href="#ref-for-concept-request-origin⑤">(2)</a> <a href="#ref-for-concept-request-origin⑥">(3)</a> <a href="#ref-for-concept-request-origin⑦">(4)</a>
    <li><a href="#ref-for-concept-request-origin⑧">4. Fetching</a> <a href="#ref-for-concept-request-origin⑨">(2)</a>
    <li><a href="#ref-for-concept-request-origin①⓪">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-request-origin①①">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-request-origin①②">(2)</a>
    <li><a href="#ref-for-concept-request-origin①③">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-origin①④">(2)</a>
    <li><a href="#ref-for-concept-request-origin①⑤">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-referrer">
   <b><a href="#concept-request-referrer">#concept-request-referrer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-referrer">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-referrer①">4.1. Main fetch</a> <a href="#ref-for-concept-request-referrer②">(2)</a> <a href="#ref-for-concept-request-referrer③">(3)</a>
    <li><a href="#ref-for-concept-request-referrer④">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-referrer⑤">(2)</a>
    <li><a href="#ref-for-concept-request-referrer⑥">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-referrer⑦">(2)</a>
    <li><a href="#ref-for-concept-request-referrer⑧">5.3. Request class</a> <a href="#ref-for-concept-request-referrer⑨">(2)</a> <a href="#ref-for-concept-request-referrer①⓪">(3)</a> <a href="#ref-for-concept-request-referrer①①">(4)</a> <a href="#ref-for-concept-request-referrer①②">(5)</a> <a href="#ref-for-concept-request-referrer①③">(6)</a> <a href="#ref-for-concept-request-referrer①④">(7)</a> <a href="#ref-for-concept-request-referrer①⑤">(8)</a> <a href="#ref-for-concept-request-referrer①⑥">(9)</a> <a href="#ref-for-concept-request-referrer①⑦">(10)</a>
    <li><a href="#ref-for-concept-request-referrer①⑧">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-referrer-policy">
   <b><a href="#concept-request-referrer-policy">#concept-request-referrer-policy</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-referrer-policy">3.1. `Origin` header</a> <a href="#ref-for-concept-request-referrer-policy①">(2)</a>
    <li><a href="#ref-for-concept-request-referrer-policy②">4.1. Main fetch</a> <a href="#ref-for-concept-request-referrer-policy③">(2)</a> <a href="#ref-for-concept-request-referrer-policy④">(3)</a> <a href="#ref-for-concept-request-referrer-policy⑤">(4)</a>
    <li><a href="#ref-for-concept-request-referrer-policy⑥">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-referrer-policy⑦">(2)</a>
    <li><a href="#ref-for-concept-request-referrer-policy⑧">5.3. Request class</a> <a href="#ref-for-concept-request-referrer-policy⑨">(2)</a> <a href="#ref-for-concept-request-referrer-policy①⓪">(3)</a> <a href="#ref-for-concept-request-referrer-policy①①">(4)</a> <a href="#ref-for-concept-request-referrer-policy①②">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="synchronous-flag">
   <b><a href="#synchronous-flag">#synchronous-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-synchronous-flag">4. Fetching</a> <a href="#ref-for-synchronous-flag①">(2)</a>
    <li><a href="#ref-for-synchronous-flag②">4.1. Main fetch</a> <a href="#ref-for-synchronous-flag③">(2)</a>
    <li><a href="#ref-for-synchronous-flag④">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-synchronous-flag⑤">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-mode">
   <b><a href="#concept-request-mode">#concept-request-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-mode">2.2.5. Requests</a> <a href="#ref-for-concept-request-mode①">(2)</a> <a href="#ref-for-concept-request-mode②">(3)</a> <a href="#ref-for-concept-request-mode③">(4)</a>
    <li><a href="#ref-for-concept-request-mode④">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-request-mode⑤">3.6. `Cross-Origin-Resource-Policy` header</a> <a href="#ref-for-concept-request-mode⑥">(2)</a>
    <li><a href="#ref-for-concept-request-mode⑦">4.1. Main fetch</a> <a href="#ref-for-concept-request-mode⑧">(2)</a> <a href="#ref-for-concept-request-mode⑨">(3)</a>
    <li><a href="#ref-for-concept-request-mode①⓪">4.3. HTTP fetch</a> <a href="#ref-for-concept-request-mode①①">(2)</a>
    <li><a href="#ref-for-concept-request-mode①②">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-request-mode①③">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-request-mode①④">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-request-mode①⑤">5.3. Request class</a> <a href="#ref-for-concept-request-mode①⑥">(2)</a> <a href="#ref-for-concept-request-mode①⑦">(3)</a> <a href="#ref-for-concept-request-mode①⑧">(4)</a> <a href="#ref-for-concept-request-mode①⑨">(5)</a> <a href="#ref-for-concept-request-mode②⓪">(6)</a> <a href="#ref-for-concept-request-mode②①">(7)</a> <a href="#ref-for-concept-request-mode②②">(8)</a> <a href="#ref-for-concept-request-mode②③">(9)</a>
    <li><a href="#ref-for-concept-request-mode②④">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="use-cors-preflight-flag">
   <b><a href="#use-cors-preflight-flag">#use-cors-preflight-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-use-cors-preflight-flag">2.2.5. Requests</a> <a href="#ref-for-use-cors-preflight-flag①">(2)</a>
    <li><a href="#ref-for-use-cors-preflight-flag②">4.1. Main fetch</a>
    <li><a href="#ref-for-use-cors-preflight-flag③">4.3. HTTP fetch</a>
    <li><a href="#ref-for-use-cors-preflight-flag④">4.7. CORS-preflight fetch</a> <a href="#ref-for-use-cors-preflight-flag⑤">(2)</a>
    <li><a href="#ref-for-use-cors-preflight-flag⑥">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-credentials-mode">
   <b><a href="#concept-request-credentials-mode">#concept-request-credentials-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-credentials-mode">2.2.5. Requests</a> <a href="#ref-for-concept-request-credentials-mode①">(2)</a>
    <li><a href="#ref-for-concept-request-credentials-mode②">3.2.3. HTTP responses</a> <a href="#ref-for-concept-request-credentials-mode③">(2)</a>
    <li><a href="#ref-for-concept-request-credentials-mode④">3.2.5. CORS protocol and credentials</a> <a href="#ref-for-concept-request-credentials-mode⑤">(2)</a> <a href="#ref-for-concept-request-credentials-mode⑥">(3)</a> <a href="#ref-for-concept-request-credentials-mode⑦">(4)</a>
    <li><a href="#ref-for-concept-request-credentials-mode⑧">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-request-credentials-mode⑨">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-credentials-mode①⓪">(2)</a> <a href="#ref-for-concept-request-credentials-mode①①">(3)</a>
    <li><a href="#ref-for-concept-request-credentials-mode①②">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-credentials-mode①③">(2)</a> <a href="#ref-for-concept-request-credentials-mode①④">(3)</a>
    <li><a href="#ref-for-concept-request-credentials-mode①⑤">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-request-credentials-mode①⑥">(2)</a>
    <li><a href="#ref-for-concept-request-credentials-mode①⑦">4.9. CORS check</a> <a href="#ref-for-concept-request-credentials-mode①⑧">(2)</a>
    <li><a href="#ref-for-concept-request-credentials-mode①⑨">5.3. Request class</a> <a href="#ref-for-concept-request-credentials-mode②⓪">(2)</a> <a href="#ref-for-concept-request-credentials-mode②①">(3)</a> <a href="#ref-for-concept-request-credentials-mode②②">(4)</a> <a href="#ref-for-concept-request-credentials-mode②③">(5)</a>
    <li><a href="#ref-for-concept-request-credentials-mode②④">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-use-url-credentials-flag">
   <b><a href="#concept-request-use-url-credentials-flag">#concept-request-use-url-credentials-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-use-url-credentials-flag">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-use-url-credentials-flag①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-cache-mode">
   <b><a href="#concept-request-cache-mode">#concept-request-cache-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-cache-mode">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-cache-mode①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-cache-mode②">(2)</a> <a href="#ref-for-concept-request-cache-mode③">(3)</a> <a href="#ref-for-concept-request-cache-mode④">(4)</a> <a href="#ref-for-concept-request-cache-mode⑤">(5)</a> <a href="#ref-for-concept-request-cache-mode⑥">(6)</a> <a href="#ref-for-concept-request-cache-mode⑦">(7)</a> <a href="#ref-for-concept-request-cache-mode⑧">(8)</a> <a href="#ref-for-concept-request-cache-mode⑨">(9)</a>
    <li><a href="#ref-for-concept-request-cache-mode①⓪">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-request-cache-mode①①">5.3. Request class</a> <a href="#ref-for-concept-request-cache-mode①②">(2)</a> <a href="#ref-for-concept-request-cache-mode①③">(3)</a> <a href="#ref-for-concept-request-cache-mode①④">(4)</a> <a href="#ref-for-concept-request-cache-mode①⑤">(5)</a> <a href="#ref-for-concept-request-cache-mode①⑥">(6)</a>
    <li><a href="#ref-for-concept-request-cache-mode①⑦">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-redirect-mode">
   <b><a href="#concept-request-redirect-mode">#concept-request-redirect-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-redirect-mode">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-redirect-mode①">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-request-redirect-mode②">4.3. HTTP fetch</a> <a href="#ref-for-concept-request-redirect-mode③">(2)</a> <a href="#ref-for-concept-request-redirect-mode④">(3)</a> <a href="#ref-for-concept-request-redirect-mode⑤">(4)</a>
    <li><a href="#ref-for-concept-request-redirect-mode⑥">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-request-redirect-mode⑦">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-request-redirect-mode⑧">5.3. Request class</a> <a href="#ref-for-concept-request-redirect-mode⑨">(2)</a> <a href="#ref-for-concept-request-redirect-mode①⓪">(3)</a> <a href="#ref-for-concept-request-redirect-mode①①">(4)</a> <a href="#ref-for-concept-request-redirect-mode①②">(5)</a>
    <li><a href="#ref-for-concept-request-redirect-mode①③">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-integrity-metadata">
   <b><a href="#concept-request-integrity-metadata">#concept-request-integrity-metadata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-integrity-metadata">4.1. Main fetch</a> <a href="#ref-for-concept-request-integrity-metadata①">(2)</a>
    <li><a href="#ref-for-concept-request-integrity-metadata②">5.3. Request class</a> <a href="#ref-for-concept-request-integrity-metadata③">(2)</a> <a href="#ref-for-concept-request-integrity-metadata④">(3)</a> <a href="#ref-for-concept-request-integrity-metadata⑤">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-nonce-metadata">
   <b><a href="#concept-request-nonce-metadata">#concept-request-nonce-metadata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-nonce-metadata">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-parser-metadata">
   <b><a href="#concept-request-parser-metadata">#concept-request-parser-metadata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-parser-metadata">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-reload-navigation-flag">
   <b><a href="#concept-request-reload-navigation-flag">#concept-request-reload-navigation-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-reload-navigation-flag">5.3. Request class</a> <a href="#ref-for-concept-request-reload-navigation-flag①">(2)</a> <a href="#ref-for-concept-request-reload-navigation-flag②">(3)</a> <a href="#ref-for-concept-request-reload-navigation-flag③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-history-navigation-flag">
   <b><a href="#concept-request-history-navigation-flag">#concept-request-history-navigation-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-history-navigation-flag">5.3. Request class</a> <a href="#ref-for-concept-request-history-navigation-flag①">(2)</a> <a href="#ref-for-concept-request-history-navigation-flag②">(3)</a> <a href="#ref-for-concept-request-history-navigation-flag③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-tainted-origin">
   <b><a href="#concept-request-tainted-origin">#concept-request-tainted-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-tainted-origin">2.2.5. Requests</a> <a href="#ref-for-concept-request-tainted-origin①">(2)</a>
    <li><a href="#ref-for-concept-request-tainted-origin②">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-request-tainted-origin③">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-request-tainted-origin④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-url-list">
   <b><a href="#concept-request-url-list">#concept-request-url-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-url-list">2.2.5. Requests</a> <a href="#ref-for-concept-request-url-list①">(2)</a> <a href="#ref-for-concept-request-url-list②">(3)</a>
    <li><a href="#ref-for-concept-request-url-list③">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-request-url-list④">4.4. HTTP-redirect fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-current-url">
   <b><a href="#concept-request-current-url">#concept-request-current-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-current-url">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-current-url①">2.6. Port blocking</a>
    <li><a href="#ref-for-concept-request-current-url②">3.1. `Origin` header</a> <a href="#ref-for-concept-request-current-url③">(2)</a>
    <li><a href="#ref-for-concept-request-current-url④">3.2.1. General</a>
    <li><a href="#ref-for-concept-request-current-url⑤">3.5. CORB</a>
    <li><a href="#ref-for-concept-request-current-url⑥">3.6. `Cross-Origin-Resource-Policy` header</a> <a href="#ref-for-concept-request-current-url⑦">(2)</a> <a href="#ref-for-concept-request-current-url⑧">(3)</a>
    <li><a href="#ref-for-concept-request-current-url⑨">4.1. Main fetch</a> <a href="#ref-for-concept-request-current-url①⓪">(2)</a> <a href="#ref-for-concept-request-current-url①①">(3)</a> <a href="#ref-for-concept-request-current-url①②">(4)</a> <a href="#ref-for-concept-request-current-url①③">(5)</a> <a href="#ref-for-concept-request-current-url①④">(6)</a> <a href="#ref-for-concept-request-current-url①⑤">(7)</a> <a href="#ref-for-concept-request-current-url①⑥">(8)</a> <a href="#ref-for-concept-request-current-url①⑦">(9)</a> <a href="#ref-for-concept-request-current-url①⑧">(10)</a>
    <li><a href="#ref-for-concept-request-current-url①⑨">4.2. Scheme fetch</a> <a href="#ref-for-concept-request-current-url②⓪">(2)</a> <a href="#ref-for-concept-request-current-url②①">(3)</a> <a href="#ref-for-concept-request-current-url②②">(4)</a> <a href="#ref-for-concept-request-current-url②③">(5)</a>
    <li><a href="#ref-for-concept-request-current-url②④">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-request-current-url②⑤">(2)</a>
    <li><a href="#ref-for-concept-request-current-url②⑥">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-current-url②⑦">(2)</a> <a href="#ref-for-concept-request-current-url②⑧">(3)</a> <a href="#ref-for-concept-request-current-url②⑨">(4)</a> <a href="#ref-for-concept-request-current-url③⓪">(5)</a> <a href="#ref-for-concept-request-current-url③①">(6)</a>
    <li><a href="#ref-for-concept-request-current-url③②">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-request-current-url③③">(2)</a> <a href="#ref-for-concept-request-current-url③④">(3)</a>
    <li><a href="#ref-for-concept-request-current-url③⑤">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-request-current-url③⑥">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-request-current-url③⑦">(2)</a> <a href="#ref-for-concept-request-current-url③⑧">(3)</a>
    <li><a href="#ref-for-concept-request-current-url③⑨">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-redirect-count">
   <b><a href="#concept-request-redirect-count">#concept-request-redirect-count</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-redirect-count">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-redirect-count①">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-request-redirect-count②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-response-tainting">
   <b><a href="#concept-request-response-tainting">#concept-request-response-tainting</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-response-tainting">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-request-response-tainting①">3.1. `Origin` header</a> <a href="#ref-for-concept-request-response-tainting②">(2)</a>
    <li><a href="#ref-for-concept-request-response-tainting③">4.1. Main fetch</a> <a href="#ref-for-concept-request-response-tainting④">(2)</a> <a href="#ref-for-concept-request-response-tainting⑤">(3)</a> <a href="#ref-for-concept-request-response-tainting⑥">(4)</a> <a href="#ref-for-concept-request-response-tainting⑦">(5)</a> <a href="#ref-for-concept-request-response-tainting⑧">(6)</a> <a href="#ref-for-concept-request-response-tainting⑨">(7)</a>
    <li><a href="#ref-for-concept-request-response-tainting①⓪">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-request-response-tainting①①">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-request-response-tainting①②">(2)</a>
    <li><a href="#ref-for-concept-request-response-tainting①③">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-request-response-tainting①④">(2)</a> <a href="#ref-for-concept-request-response-tainting①⑤">(3)</a>
    <li><a href="#ref-for-concept-request-response-tainting①⑥">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-request-response-tainting①⑦">4.10. TAO check</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="no-cache-prevent-cache-control">
   <b><a href="#no-cache-prevent-cache-control">#no-cache-prevent-cache-control</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-no-cache-prevent-cache-control">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-no-cache-prevent-cache-control①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="done-flag">
   <b><a href="#done-flag">#done-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-done-flag">2.2.5. Requests</a>
    <li><a href="#ref-for-done-flag①">2.4. Fetch groups</a>
    <li><a href="#ref-for-done-flag②">4.1. Main fetch</a>
    <li><a href="#ref-for-done-flag③">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="timing-allow-failed">
   <b><a href="#timing-allow-failed">#timing-allow-failed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-timing-allow-failed">2.2.5. Requests</a>
    <li><a href="#ref-for-timing-allow-failed①">2.2.6. Responses</a>
    <li><a href="#ref-for-timing-allow-failed②">4.1. Main fetch</a>
    <li><a href="#ref-for-timing-allow-failed③">4.3. HTTP fetch</a>
    <li><a href="#ref-for-timing-allow-failed④">4.10. TAO check</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="subresource-request">
   <b><a href="#subresource-request">#subresource-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-subresource-request">4. Fetching</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="navigation-request">
   <b><a href="#navigation-request">#navigation-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-navigation-request">2.2.5. Requests</a> <a href="#ref-for-navigation-request①">(2)</a> <a href="#ref-for-navigation-request②">(3)</a>
    <li><a href="#ref-for-navigation-request③">4. Fetching</a>
    <li><a href="#ref-for-navigation-request④">CORS protocol and HTTP caches</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serializing-a-request-origin">
   <b><a href="#serializing-a-request-origin">#serializing-a-request-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serializing-a-request-origin">2.2.5. Requests</a>
    <li><a href="#ref-for-serializing-a-request-origin①">4.10. TAO check</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="byte-serializing-a-request-origin">
   <b><a href="#byte-serializing-a-request-origin">#byte-serializing-a-request-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-byte-serializing-a-request-origin">3.1. `Origin` header</a>
    <li><a href="#ref-for-byte-serializing-a-request-origin①">4.8. CORS-preflight cache</a> <a href="#ref-for-byte-serializing-a-request-origin②">(2)</a> <a href="#ref-for-byte-serializing-a-request-origin③">(3)</a>
    <li><a href="#ref-for-byte-serializing-a-request-origin④">4.9. CORS check</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-clone">
   <b><a href="#concept-request-clone">#concept-request-clone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-clone">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-request-clone①">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-transmit-body">
   <b><a href="#concept-request-transmit-body">#concept-request-transmit-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-transmit-body">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-request-transmit-body①">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-add-range-header">
   <b><a href="#concept-request-add-range-header">#concept-request-add-range-header</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-add-range-header">2.2.2. Headers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response">
   <b><a href="#concept-response">#concept-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response">2.2. HTTP</a> <a href="#ref-for-concept-response①">(2)</a>
    <li><a href="#ref-for-concept-response②">2.2.6. Responses</a> <a href="#ref-for-concept-response③">(2)</a> <a href="#ref-for-concept-response④">(3)</a> <a href="#ref-for-concept-response⑤">(4)</a> <a href="#ref-for-concept-response⑥">(5)</a> <a href="#ref-for-concept-response⑦">(6)</a> <a href="#ref-for-concept-response⑧">(7)</a> <a href="#ref-for-concept-response⑨">(8)</a> <a href="#ref-for-concept-response①⓪">(9)</a> <a href="#ref-for-concept-response①①">(10)</a> <a href="#ref-for-concept-response①②">(11)</a> <a href="#ref-for-concept-response①③">(12)</a> <a href="#ref-for-concept-response①④">(13)</a> <a href="#ref-for-concept-response①⑤">(14)</a> <a href="#ref-for-concept-response①⑥">(15)</a> <a href="#ref-for-concept-response①⑦">(16)</a> <a href="#ref-for-concept-response①⑧">(17)</a> <a href="#ref-for-concept-response①⑨">(18)</a> <a href="#ref-for-concept-response②⓪">(19)</a> <a href="#ref-for-concept-response②①">(20)</a> <a href="#ref-for-concept-response②②">(21)</a> <a href="#ref-for-concept-response②③">(22)</a> <a href="#ref-for-concept-response②④">(23)</a> <a href="#ref-for-concept-response②⑤">(24)</a> <a href="#ref-for-concept-response②⑥">(25)</a> <a href="#ref-for-concept-response②⑦">(26)</a> <a href="#ref-for-concept-response②⑧">(27)</a> <a href="#ref-for-concept-response②⑨">(28)</a> <a href="#ref-for-concept-response③⓪">(29)</a> <a href="#ref-for-concept-response③①">(30)</a> <a href="#ref-for-concept-response③②">(31)</a> <a href="#ref-for-concept-response③③">(32)</a>
    <li><a href="#ref-for-concept-response③④">3.2.3. HTTP responses</a> <a href="#ref-for-concept-response③⑤">(2)</a>
    <li><a href="#ref-for-concept-response③⑥">3.4. `X-Content-Type-Options` header</a>
    <li><a href="#ref-for-concept-response③⑦">4. Fetching</a> <a href="#ref-for-concept-response③⑧">(2)</a> <a href="#ref-for-concept-response③⑨">(3)</a>
    <li><a href="#ref-for-concept-response④⓪">4.1. Main fetch</a> <a href="#ref-for-concept-response④①">(2)</a>
    <li><a href="#ref-for-concept-response④②">4.2. Scheme fetch</a> <a href="#ref-for-concept-response④③">(2)</a> <a href="#ref-for-concept-response④④">(3)</a> <a href="#ref-for-concept-response④⑤">(4)</a>
    <li><a href="#ref-for-concept-response④⑥">4.3. HTTP fetch</a> <a href="#ref-for-concept-response④⑦">(2)</a>
    <li><a href="#ref-for-concept-response④⑧">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-response④⑨">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-response⑤⓪">(2)</a> <a href="#ref-for-concept-response⑤①">(3)</a> <a href="#ref-for-concept-response⑤②">(4)</a>
    <li><a href="#ref-for-concept-response⑤③">5.4. Response class</a> <a href="#ref-for-concept-response⑤④">(2)</a> <a href="#ref-for-concept-response⑤⑤">(3)</a> <a href="#ref-for-concept-response⑤⑥">(4)</a> <a href="#ref-for-concept-response⑤⑦">(5)</a>
    <li><a href="#ref-for-concept-response⑤⑧">Atomic HTTP redirect handling</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-type">
   <b><a href="#concept-response-type">#concept-response-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-type">2.2.6. Responses</a> <a href="#ref-for-concept-response-type①">(2)</a> <a href="#ref-for-concept-response-type②">(3)</a> <a href="#ref-for-concept-response-type③">(4)</a> <a href="#ref-for-concept-response-type④">(5)</a> <a href="#ref-for-concept-response-type⑤">(6)</a>
    <li><a href="#ref-for-concept-response-type⑥">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-response-type⑦">4.3. HTTP fetch</a> <a href="#ref-for-concept-response-type⑧">(2)</a> <a href="#ref-for-concept-response-type⑨">(3)</a> <a href="#ref-for-concept-response-type①⓪">(4)</a>
    <li><a href="#ref-for-concept-response-type①①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-aborted">
   <b><a href="#concept-response-aborted">#concept-response-aborted</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-aborted">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-response-aborted①">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-response-aborted②">(2)</a>
    <li><a href="#ref-for-concept-response-aborted③">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-url">
   <b><a href="#concept-response-url">#concept-response-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-url">3.2.3. HTTP responses</a> <a href="#ref-for-concept-response-url①">(2)</a>
    <li><a href="#ref-for-concept-response-url②">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-response-url③">5.4. Response class</a> <a href="#ref-for-concept-response-url④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-url-list">
   <b><a href="#concept-response-url-list">#concept-response-url-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-url-list">2.2.6. Responses</a> <a href="#ref-for-concept-response-url-list①">(2)</a> <a href="#ref-for-concept-response-url-list②">(3)</a> <a href="#ref-for-concept-response-url-list③">(4)</a> <a href="#ref-for-concept-response-url-list④">(5)</a>
    <li><a href="#ref-for-concept-response-url-list⑤">4.1. Main fetch</a> <a href="#ref-for-concept-response-url-list⑥">(2)</a>
    <li><a href="#ref-for-concept-response-url-list⑦">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-response-url-list⑧">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-status">
   <b><a href="#concept-response-status">#concept-response-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-status">2.2.6. Responses</a> <a href="#ref-for-concept-response-status①">(2)</a> <a href="#ref-for-concept-response-status②">(3)</a>
    <li><a href="#ref-for-concept-response-status③">3.5. CORB</a> <a href="#ref-for-concept-response-status④">(2)</a>
    <li><a href="#ref-for-concept-response-status⑤">4.1. Main fetch</a> <a href="#ref-for-concept-response-status⑥">(2)</a> <a href="#ref-for-concept-response-status⑦">(3)</a> <a href="#ref-for-concept-response-status⑧">(4)</a>
    <li><a href="#ref-for-concept-response-status⑨">4.3. HTTP fetch</a> <a href="#ref-for-concept-response-status①⓪">(2)</a> <a href="#ref-for-concept-response-status①①">(3)</a>
    <li><a href="#ref-for-concept-response-status①②">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-response-status①③">(2)</a> <a href="#ref-for-concept-response-status①④">(3)</a>
    <li><a href="#ref-for-concept-response-status①⑤">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-response-status①⑥">(2)</a> <a href="#ref-for-concept-response-status①⑦">(3)</a> <a href="#ref-for-concept-response-status①⑧">(4)</a>
    <li><a href="#ref-for-concept-response-status①⑨">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-response-status②⓪">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-concept-response-status②①">5.4. Response class</a> <a href="#ref-for-concept-response-status②②">(2)</a> <a href="#ref-for-concept-response-status②③">(3)</a> <a href="#ref-for-concept-response-status②④">(4)</a>
    <li><a href="#ref-for-concept-response-status②⑤">6.2. Opening handshake</a>
    <li><a href="#ref-for-concept-response-status②⑥">Atomic HTTP redirect handling</a> <a href="#ref-for-concept-response-status②⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-status-message">
   <b><a href="#concept-response-status-message">#concept-response-status-message</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-status-message">2.2.6. Responses</a> <a href="#ref-for-concept-response-status-message①">(2)</a> <a href="#ref-for-concept-response-status-message②">(3)</a>
    <li><a href="#ref-for-concept-response-status-message③">4.2. Scheme fetch</a> <a href="#ref-for-concept-response-status-message④">(2)</a> <a href="#ref-for-concept-response-status-message⑤">(3)</a> <a href="#ref-for-concept-response-status-message⑥">(4)</a>
    <li><a href="#ref-for-concept-response-status-message⑦">5.4. Response class</a> <a href="#ref-for-concept-response-status-message⑧">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-header-list">
   <b><a href="#concept-response-header-list">#concept-response-header-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-header-list">2.2.6. Responses</a> <a href="#ref-for-concept-response-header-list①">(2)</a> <a href="#ref-for-concept-response-header-list②">(3)</a> <a href="#ref-for-concept-response-header-list③">(4)</a> <a href="#ref-for-concept-response-header-list④">(5)</a> <a href="#ref-for-concept-response-header-list⑤">(6)</a> <a href="#ref-for-concept-response-header-list⑥">(7)</a>
    <li><a href="#ref-for-concept-response-header-list⑦">2.7. Should
response to request be blocked due to its MIME type?</a>
    <li><a href="#ref-for-concept-response-header-list⑧">3.4.1. Should
response to request be blocked due to nosniff?</a> <a href="#ref-for-concept-response-header-list⑨">(2)</a>
    <li><a href="#ref-for-concept-response-header-list①⓪">3.5. CORB</a> <a href="#ref-for-concept-response-header-list①①">(2)</a>
    <li><a href="#ref-for-concept-response-header-list①②">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-concept-response-header-list①③">4.1. Main fetch</a> <a href="#ref-for-concept-response-header-list①④">(2)</a>
    <li><a href="#ref-for-concept-response-header-list①⑤">4.2. Scheme fetch</a> <a href="#ref-for-concept-response-header-list①⑥">(2)</a> <a href="#ref-for-concept-response-header-list①⑦">(3)</a> <a href="#ref-for-concept-response-header-list①⑧">(4)</a> <a href="#ref-for-concept-response-header-list①⑨">(5)</a>
    <li><a href="#ref-for-concept-response-header-list②⓪">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-response-header-list②①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-response-header-list②②">(2)</a> <a href="#ref-for-concept-response-header-list②③">(3)</a> <a href="#ref-for-concept-response-header-list②④">(4)</a>
    <li><a href="#ref-for-concept-response-header-list②⑤">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-response-header-list②⑥">(2)</a>
    <li><a href="#ref-for-concept-response-header-list②⑦">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-response-header-list②⑧">(2)</a> <a href="#ref-for-concept-response-header-list②⑨">(3)</a>
    <li><a href="#ref-for-concept-response-header-list③⓪">4.9. CORS check</a> <a href="#ref-for-concept-response-header-list③①">(2)</a>
    <li><a href="#ref-for-concept-response-header-list③②">4.10. TAO check</a>
    <li><a href="#ref-for-concept-response-header-list③③">5.4. Response class</a> <a href="#ref-for-concept-response-header-list③④">(2)</a> <a href="#ref-for-concept-response-header-list③⑤">(3)</a> <a href="#ref-for-concept-response-header-list③⑥">(4)</a> <a href="#ref-for-concept-response-header-list③⑦">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-body">
   <b><a href="#concept-response-body">#concept-response-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-body">2.2.6. Responses</a> <a href="#ref-for-concept-response-body①">(2)</a> <a href="#ref-for-concept-response-body②">(3)</a> <a href="#ref-for-concept-response-body③">(4)</a> <a href="#ref-for-concept-response-body④">(5)</a> <a href="#ref-for-concept-response-body⑤">(6)</a> <a href="#ref-for-concept-response-body⑥">(7)</a>
    <li><a href="#ref-for-concept-response-body⑦">4.1. Main fetch</a> <a href="#ref-for-concept-response-body⑧">(2)</a> <a href="#ref-for-concept-response-body⑨">(3)</a> <a href="#ref-for-concept-response-body①⓪">(4)</a> <a href="#ref-for-concept-response-body①①">(5)</a>
    <li><a href="#ref-for-concept-response-body①②">4.2. Scheme fetch</a> <a href="#ref-for-concept-response-body①③">(2)</a> <a href="#ref-for-concept-response-body①④">(3)</a> <a href="#ref-for-concept-response-body①⑤">(4)</a>
    <li><a href="#ref-for-concept-response-body①⑥">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-response-body①⑦">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-concept-response-body①⑧">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-response-body①⑨">(2)</a> <a href="#ref-for-concept-response-body②⓪">(3)</a> <a href="#ref-for-concept-response-body②①">(4)</a> <a href="#ref-for-concept-response-body②②">(5)</a>
    <li><a href="#ref-for-concept-response-body②③">5.4. Response class</a> <a href="#ref-for-concept-response-body②④">(2)</a>
    <li><a href="#ref-for-concept-response-body②⑤">5.5. Fetch method</a> <a href="#ref-for-concept-response-body②⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-cache-state">
   <b><a href="#concept-response-cache-state">#concept-response-cache-state</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-cache-state">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-response-cache-state①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-https-state">
   <b><a href="#concept-response-https-state">#concept-response-https-state</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-https-state">2.2. HTTP</a>
    <li><a href="#ref-for-concept-response-https-state①">3.6. `Cross-Origin-Resource-Policy` header</a>
    <li><a href="#ref-for-concept-response-https-state②">4.1. Main fetch</a> <a href="#ref-for-concept-response-https-state③">(2)</a>
    <li><a href="#ref-for-concept-response-https-state④">4.2. Scheme fetch</a> <a href="#ref-for-concept-response-https-state⑤">(2)</a> <a href="#ref-for-concept-response-https-state⑥">(3)</a> <a href="#ref-for-concept-response-https-state⑦">(4)</a>
    <li><a href="#ref-for-concept-response-https-state⑧">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-response-https-state⑨">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-csp-list">
   <b><a href="#concept-response-csp-list">#concept-response-csp-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-csp-list">4.1. Main fetch</a> <a href="#ref-for-concept-response-csp-list①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-cors-exposed-header-name-list">
   <b><a href="#concept-response-cors-exposed-header-name-list">#concept-response-cors-exposed-header-name-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-cors-exposed-header-name-list">2.2.2. Headers</a>
    <li><a href="#ref-for-concept-response-cors-exposed-header-name-list①">2.2.6. Responses</a> <a href="#ref-for-concept-response-cors-exposed-header-name-list②">(2)</a>
    <li><a href="#ref-for-concept-response-cors-exposed-header-name-list③">4.1. Main fetch</a> <a href="#ref-for-concept-response-cors-exposed-header-name-list④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-range-requested-flag">
   <b><a href="#concept-response-range-requested-flag">#concept-response-range-requested-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-range-requested-flag">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-response-range-requested-flag①">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-timing-allow-passed">
   <b><a href="#concept-response-timing-allow-passed">#concept-response-timing-allow-passed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-timing-allow-passed">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-location-url">
   <b><a href="#concept-response-location-url">#concept-response-location-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-location-url">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-response-location-url①">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-response-location-url②">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-response-location-url③">(2)</a> <a href="#ref-for-concept-response-location-url④">(3)</a> <a href="#ref-for-concept-response-location-url⑤">(4)</a> <a href="#ref-for-concept-response-location-url⑥">(5)</a> <a href="#ref-for-concept-response-location-url⑦">(6)</a> <a href="#ref-for-concept-response-location-url⑧">(7)</a> <a href="#ref-for-concept-response-location-url⑨">(8)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-aborted-network-error">
   <b><a href="#concept-aborted-network-error">#concept-aborted-network-error</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-aborted-network-error">4. Fetching</a>
    <li><a href="#ref-for-concept-aborted-network-error①">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-aborted-network-error②">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-aborted-network-error③">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-aborted-network-error④">(2)</a> <a href="#ref-for-concept-aborted-network-error⑤">(3)</a>
    <li><a href="#ref-for-concept-aborted-network-error⑥">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-network-error">
   <b><a href="#concept-network-error">#concept-network-error</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-network-error">2.2.5. Requests</a> <a href="#ref-for-concept-network-error①">(2)</a> <a href="#ref-for-concept-network-error②">(3)</a> <a href="#ref-for-concept-network-error③">(4)</a>
    <li><a href="#ref-for-concept-network-error④">2.2.6. Responses</a> <a href="#ref-for-concept-network-error⑤">(2)</a> <a href="#ref-for-concept-network-error⑥">(3)</a>
    <li><a href="#ref-for-concept-network-error⑦">4. Fetching</a>
    <li><a href="#ref-for-concept-network-error⑧">4.1. Main fetch</a> <a href="#ref-for-concept-network-error⑨">(2)</a> <a href="#ref-for-concept-network-error①⓪">(3)</a> <a href="#ref-for-concept-network-error①①">(4)</a> <a href="#ref-for-concept-network-error①②">(5)</a> <a href="#ref-for-concept-network-error①③">(6)</a> <a href="#ref-for-concept-network-error①④">(7)</a> <a href="#ref-for-concept-network-error①⑤">(8)</a> <a href="#ref-for-concept-network-error①⑥">(9)</a> <a href="#ref-for-concept-network-error①⑦">(10)</a> <a href="#ref-for-concept-network-error①⑧">(11)</a> <a href="#ref-for-concept-network-error①⑨">(12)</a> <a href="#ref-for-concept-network-error②⓪">(13)</a> <a href="#ref-for-concept-network-error②①">(14)</a> <a href="#ref-for-concept-network-error②②">(15)</a> <a href="#ref-for-concept-network-error②③">(16)</a>
    <li><a href="#ref-for-concept-network-error②④">4.2. Scheme fetch</a> <a href="#ref-for-concept-network-error②⑤">(2)</a> <a href="#ref-for-concept-network-error②⑥">(3)</a> <a href="#ref-for-concept-network-error②⑦">(4)</a> <a href="#ref-for-concept-network-error②⑧">(5)</a> <a href="#ref-for-concept-network-error②⑨">(6)</a> <a href="#ref-for-concept-network-error③⓪">(7)</a> <a href="#ref-for-concept-network-error③①">(8)</a>
    <li><a href="#ref-for-concept-network-error③②">4.3. HTTP fetch</a> <a href="#ref-for-concept-network-error③③">(2)</a> <a href="#ref-for-concept-network-error③④">(3)</a> <a href="#ref-for-concept-network-error③⑤">(4)</a>
    <li><a href="#ref-for-concept-network-error③⑥">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-network-error③⑦">(2)</a> <a href="#ref-for-concept-network-error③⑧">(3)</a> <a href="#ref-for-concept-network-error③⑨">(4)</a> <a href="#ref-for-concept-network-error④⓪">(5)</a> <a href="#ref-for-concept-network-error④①">(6)</a>
    <li><a href="#ref-for-concept-network-error④②">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-network-error④③">(2)</a> <a href="#ref-for-concept-network-error④④">(3)</a> <a href="#ref-for-concept-network-error④⑤">(4)</a> <a href="#ref-for-concept-network-error④⑥">(5)</a> <a href="#ref-for-concept-network-error④⑦">(6)</a> <a href="#ref-for-concept-network-error④⑧">(7)</a> <a href="#ref-for-concept-network-error④⑨">(8)</a> <a href="#ref-for-concept-network-error⑤⓪">(9)</a>
    <li><a href="#ref-for-concept-network-error⑤①">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-network-error⑤②">(2)</a> <a href="#ref-for-concept-network-error⑤③">(3)</a> <a href="#ref-for-concept-network-error⑤④">(4)</a> <a href="#ref-for-concept-network-error⑤⑤">(5)</a> <a href="#ref-for-concept-network-error⑤⑥">(6)</a>
    <li><a href="#ref-for-concept-network-error⑤⑦">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-network-error⑤⑧">(2)</a> <a href="#ref-for-concept-network-error⑤⑨">(3)</a> <a href="#ref-for-concept-network-error⑥⓪">(4)</a> <a href="#ref-for-concept-network-error⑥①">(5)</a>
    <li><a href="#ref-for-concept-network-error⑥②">5.4. Response class</a>
    <li><a href="#ref-for-concept-network-error⑥③">5.5. Fetch method</a>
    <li><a href="#ref-for-concept-network-error⑥④">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-filtered-response">
   <b><a href="#concept-filtered-response">#concept-filtered-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-filtered-response">2.2.6. Responses</a> <a href="#ref-for-concept-filtered-response①">(2)</a> <a href="#ref-for-concept-filtered-response②">(3)</a> <a href="#ref-for-concept-filtered-response③">(4)</a> <a href="#ref-for-concept-filtered-response④">(5)</a> <a href="#ref-for-concept-filtered-response⑤">(6)</a> <a href="#ref-for-concept-filtered-response⑥">(7)</a>
    <li><a href="#ref-for-concept-filtered-response⑦">4.1. Main fetch</a> <a href="#ref-for-concept-filtered-response⑧">(2)</a> <a href="#ref-for-concept-filtered-response⑨">(3)</a>
    <li><a href="#ref-for-concept-filtered-response①⓪">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-filtered-response①①">4.4. HTTP-redirect fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-internal-response">
   <b><a href="#concept-internal-response">#concept-internal-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-internal-response">2.2.6. Responses</a> <a href="#ref-for-concept-internal-response①">(2)</a> <a href="#ref-for-concept-internal-response②">(3)</a> <a href="#ref-for-concept-internal-response③">(4)</a> <a href="#ref-for-concept-internal-response④">(5)</a> <a href="#ref-for-concept-internal-response⑤">(6)</a> <a href="#ref-for-concept-internal-response⑥">(7)</a>
    <li><a href="#ref-for-concept-internal-response⑦">4.1. Main fetch</a> <a href="#ref-for-concept-internal-response⑧">(2)</a>
    <li><a href="#ref-for-concept-internal-response⑨">4.3. HTTP fetch</a> <a href="#ref-for-concept-internal-response①⓪">(2)</a>
    <li><a href="#ref-for-concept-internal-response①①">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-internal-response①②">Atomic HTTP redirect handling</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-filtered-response-basic">
   <b><a href="#concept-filtered-response-basic">#concept-filtered-response-basic</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-filtered-response-basic">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-filtered-response-cors">
   <b><a href="#concept-filtered-response-cors">#concept-filtered-response-cors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-filtered-response-cors">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-filtered-response-cors①">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-filtered-response-opaque">
   <b><a href="#concept-filtered-response-opaque">#concept-filtered-response-opaque</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-filtered-response-opaque">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-filtered-response-opaque①">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-filtered-response-opaque②">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-filtered-response-opaque-redirect">
   <b><a href="#concept-filtered-response-opaque-redirect">#concept-filtered-response-opaque-redirect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-filtered-response-opaque-redirect">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-filtered-response-opaque-redirect①">2.2.6. Responses</a> <a href="#ref-for-concept-filtered-response-opaque-redirect②">(2)</a>
    <li><a href="#ref-for-concept-filtered-response-opaque-redirect③">4.3. HTTP fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-clone">
   <b><a href="#concept-response-clone">#concept-response-clone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-clone">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-response-clone①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fresh-response">
   <b><a href="#concept-fresh-response">#concept-fresh-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fresh-response">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-fresh-response①">2.2.6. Responses</a> <a href="#ref-for-concept-fresh-response②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-stale-while-revalidate-response">
   <b><a href="#concept-stale-while-revalidate-response">#concept-stale-while-revalidate-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-stale-while-revalidate-response">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-stale-while-revalidate-response①">2.2.6. Responses</a>
    <li><a href="#ref-for-concept-stale-while-revalidate-response②">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-stale-response">
   <b><a href="#concept-stale-response">#concept-stale-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-stale-response">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-stale-response①">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-potential-destination">
   <b><a href="#concept-potential-destination">#concept-potential-destination</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-potential-destination">2.2.7. Miscellaneous</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="authentication-entry">
   <b><a href="#authentication-entry">#authentication-entry</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-authentication-entry">2. Infrastructure</a>
    <li><a href="#ref-for-authentication-entry①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-authentication-entry②">(2)</a> <a href="#ref-for-authentication-entry③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="proxy-authentication-entry">
   <b><a href="#proxy-authentication-entry">#proxy-authentication-entry</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-proxy-authentication-entry">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-proxy-authentication-entry①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-group">
   <b><a href="#concept-fetch-group">#concept-fetch-group</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-group">2.4. Fetch groups</a> <a href="#ref-for-concept-fetch-group①">(2)</a>
    <li><a href="#ref-for-concept-fetch-group②">4. Fetching</a>
    <li><a href="#ref-for-concept-fetch-group③">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-record">
   <b><a href="#concept-fetch-record">#concept-fetch-record</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-record">2.4. Fetch groups</a> <a href="#ref-for-concept-fetch-record①">(2)</a> <a href="#ref-for-concept-fetch-record②">(3)</a> <a href="#ref-for-concept-fetch-record③">(4)</a>
    <li><a href="#ref-for-concept-fetch-record④">4. Fetching</a> <a href="#ref-for-concept-fetch-record⑤">(2)</a>
    <li><a href="#ref-for-concept-fetch-record⑥">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-record-request">
   <b><a href="#concept-fetch-record-request">#concept-fetch-record-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-record-request">2.4. Fetch groups</a>
    <li><a href="#ref-for-concept-fetch-record-request①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-fetch-record-request②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-record-fetch">
   <b><a href="#concept-fetch-record-fetch">#concept-fetch-record-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-record-fetch">2.4. Fetch groups</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-connection-pool">
   <b><a href="#concept-connection-pool">#concept-connection-pool</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-connection-pool">2.5. Connections</a> <a href="#ref-for-concept-connection-pool①">(2)</a> <a href="#ref-for-concept-connection-pool②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-connection">
   <b><a href="#concept-connection">#concept-connection</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-connection">2.5. Connections</a> <a href="#ref-for-concept-connection①">(2)</a> <a href="#ref-for-concept-connection②">(3)</a> <a href="#ref-for-concept-connection③">(4)</a> <a href="#ref-for-concept-connection④">(5)</a> <a href="#ref-for-concept-connection⑤">(6)</a>
    <li><a href="#ref-for-concept-connection⑥">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-connection⑦">6.1. Connections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-connection-obtain">
   <b><a href="#concept-connection-obtain">#concept-connection-obtain</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-connection-obtain">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="block-bad-port">
   <b><a href="#block-bad-port">#block-bad-port</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-block-bad-port">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="bad-port">
   <b><a href="#bad-port">#bad-port</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-bad-port">2.6. Port blocking</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="should-response-to-request-be-blocked-due-to-mime-type?">
   <b><a href="#should-response-to-request-be-blocked-due-to-mime-type?">#should-response-to-request-be-blocked-due-to-mime-type?</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-should-response-to-request-be-blocked-due-to-mime-type?">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream">
   <b><a href="#concept-readablestream">#concept-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream">2.2.4. Bodies</a>
    <li><a href="#ref-for-concept-readablestream①">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-readablestream②">2.8.1. ReadableStream</a> <a href="#ref-for-concept-readablestream③">(2)</a> <a href="#ref-for-concept-readablestream④">(3)</a> <a href="#ref-for-concept-readablestream⑤">(4)</a> <a href="#ref-for-concept-readablestream⑥">(5)</a> <a href="#ref-for-concept-readablestream⑦">(6)</a> <a href="#ref-for-concept-readablestream⑧">(7)</a> <a href="#ref-for-concept-readablestream⑨">(8)</a> <a href="#ref-for-concept-readablestream①⓪">(9)</a> <a href="#ref-for-concept-readablestream①①">(10)</a> <a href="#ref-for-concept-readablestream①②">(11)</a> <a href="#ref-for-concept-readablestream①③">(12)</a> <a href="#ref-for-concept-readablestream①④">(13)</a> <a href="#ref-for-concept-readablestream①⑤">(14)</a> <a href="#ref-for-concept-readablestream①⑥">(15)</a> <a href="#ref-for-concept-readablestream①⑦">(16)</a> <a href="#ref-for-concept-readablestream①⑧">(17)</a> <a href="#ref-for-concept-readablestream①⑨">(18)</a> <a href="#ref-for-concept-readablestream②⓪">(19)</a>
    <li><a href="#ref-for-concept-readablestream②①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-readablestream②②">5.2. Body mixin</a> <a href="#ref-for-concept-readablestream②③">(2)</a> <a href="#ref-for-concept-readablestream②④">(3)</a> <a href="#ref-for-concept-readablestream②⑤">(4)</a> <a href="#ref-for-concept-readablestream②⑥">(5)</a> <a href="#ref-for-concept-readablestream②⑦">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-enqueue-readablestream">
   <b><a href="#concept-enqueue-readablestream">#concept-enqueue-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-enqueue-readablestream">2.8.1. ReadableStream</a>
    <li><a href="#ref-for-concept-enqueue-readablestream①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-enqueue-readablestream②">5.2. Body mixin</a> <a href="#ref-for-concept-enqueue-readablestream③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-close-readablestream">
   <b><a href="#concept-close-readablestream">#concept-close-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-close-readablestream">2.8.1. ReadableStream</a>
    <li><a href="#ref-for-concept-close-readablestream①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-close-readablestream②">5.2. Body mixin</a> <a href="#ref-for-concept-close-readablestream③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-error-readablestream">
   <b><a href="#concept-error-readablestream">#concept-error-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-error-readablestream">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-error-readablestream①">(2)</a> <a href="#ref-for-concept-error-readablestream②">(3)</a>
    <li><a href="#ref-for-concept-error-readablestream③">5.2. Body mixin</a> <a href="#ref-for-concept-error-readablestream④">(2)</a>
    <li><a href="#ref-for-concept-error-readablestream⑤">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-construct-readablestream">
   <b><a href="#concept-construct-readablestream">#concept-construct-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-construct-readablestream">2.8.1. ReadableStream</a>
    <li><a href="#ref-for-concept-construct-readablestream①">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-construct-readablestream②">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-construct-fixed-readablestream">
   <b><a href="#concept-construct-fixed-readablestream">#concept-construct-fixed-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-construct-fixed-readablestream">2.8.1. ReadableStream</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-get-reader">
   <b><a href="#concept-get-reader">#concept-get-reader</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-get-reader">2.2.5. Requests</a>
    <li><a href="#ref-for-concept-get-reader①">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-read-chunk-from-readablestream">
   <b><a href="#concept-read-chunk-from-readablestream">#concept-read-chunk-from-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-read-chunk-from-readablestream">2.2.5. Requests</a> <a href="#ref-for-concept-read-chunk-from-readablestream①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-read-all-bytes-from-readablestream">
   <b><a href="#concept-read-all-bytes-from-readablestream">#concept-read-all-bytes-from-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-read-all-bytes-from-readablestream">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cancel-readablestream">
   <b><a href="#concept-cancel-readablestream">#concept-cancel-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cancel-readablestream">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-tee-readablestream">
   <b><a href="#concept-tee-readablestream">#concept-tee-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tee-readablestream">2.2.4. Bodies</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-empty-readablestream">
   <b><a href="#concept-empty-readablestream">#concept-empty-readablestream</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-empty-readablestream">2.8.1. ReadableStream</a>
    <li><a href="#ref-for-concept-empty-readablestream①">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream-readable">
   <b><a href="#concept-readablestream-readable">#concept-readablestream-readable</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream-readable">2.8.1. ReadableStream</a>
    <li><a href="#ref-for-concept-readablestream-readable①">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-readablestream-readable②">(2)</a> <a href="#ref-for-concept-readablestream-readable③">(3)</a>
    <li><a href="#ref-for-concept-readablestream-readable④">5.5. Fetch method</a> <a href="#ref-for-concept-readablestream-readable⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream-closed">
   <b><a href="#concept-readablestream-closed">#concept-readablestream-closed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream-closed">2.2.4. Bodies</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream-errored">
   <b><a href="#concept-readablestream-errored">#concept-readablestream-errored</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream-errored">2.2.4. Bodies</a>
    <li><a href="#ref-for-concept-readablestream-errored①">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream-locked">
   <b><a href="#concept-readablestream-locked">#concept-readablestream-locked</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream-locked">5.2. Body mixin</a> <a href="#ref-for-concept-readablestream-locked①">(2)</a> <a href="#ref-for-concept-readablestream-locked②">(3)</a>
    <li><a href="#ref-for-concept-readablestream-locked③">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream-need-more-data">
   <b><a href="#concept-readablestream-need-more-data">#concept-readablestream-need-more-data</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream-need-more-data">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-readablestream-disturbed">
   <b><a href="#concept-readablestream-disturbed">#concept-readablestream-disturbed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-readablestream-disturbed">5.2. Body mixin</a> <a href="#ref-for-concept-readablestream-disturbed①">(2)</a> <a href="#ref-for-concept-readablestream-disturbed②">(3)</a>
    <li><a href="#ref-for-concept-readablestream-disturbed③">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-origin">
   <b><a href="#http-origin">#http-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-origin">Goals</a>
    <li><a href="#ref-for-http-origin①">2.2.2. Headers</a>
    <li><a href="#ref-for-http-origin②">3.1. `Origin` header</a>
    <li><a href="#ref-for-http-origin③">3.2.2. HTTP requests</a> <a href="#ref-for-http-origin④">(2)</a>
    <li><a href="#ref-for-http-origin⑤">3.2.3. HTTP responses</a>
    <li><a href="#ref-for-http-origin⑥">3.2.6. Examples</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="append-a-request-origin-header">
   <b><a href="#append-a-request-origin-header">#append-a-request-origin-header</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-append-a-request-origin-header">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-protocol">
   <b><a href="#cors-protocol">#cors-protocol</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-protocol">2.2.5. Requests</a>
    <li><a href="#ref-for-cors-protocol①">3.1. `Origin` header</a>
    <li><a href="#ref-for-cors-protocol②">3.2. CORS protocol</a>
    <li><a href="#ref-for-cors-protocol③">3.2.1. General</a> <a href="#ref-for-cors-protocol④">(2)</a>
    <li><a href="#ref-for-cors-protocol⑤">3.2.2. HTTP requests</a> <a href="#ref-for-cors-protocol⑥">(2)</a>
    <li><a href="#ref-for-cors-protocol⑦">3.2.3. HTTP responses</a> <a href="#ref-for-cors-protocol⑧">(2)</a> <a href="#ref-for-cors-protocol⑨">(3)</a> <a href="#ref-for-cors-protocol①⓪">(4)</a>
    <li><a href="#ref-for-cors-protocol①①">3.2.4. HTTP new-header syntax</a>
    <li><a href="#ref-for-cors-protocol①②">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-cors-protocol①③">3.2.6. Examples</a> <a href="#ref-for-cors-protocol①④">(2)</a> <a href="#ref-for-cors-protocol①⑤">(3)</a>
    <li><a href="#ref-for-cors-protocol①⑥">3.5. CORB</a>
    <li><a href="#ref-for-cors-protocol①⑦">4.3. HTTP fetch</a>
    <li><a href="#ref-for-cors-protocol①⑧">4.7. CORS-preflight fetch</a>
    <li><a href="#ref-for-cors-protocol①⑨">Basic safe CORS protocol setup</a> <a href="#ref-for-cors-protocol②⓪">(2)</a>
    <li><a href="#ref-for-cors-protocol②①">CORS protocol and HTTP caches</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-request">
   <b><a href="#cors-request">#cors-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-request">2.2.5. Requests</a>
    <li><a href="#ref-for-cors-request①">3.2.2. HTTP requests</a> <a href="#ref-for-cors-request②">(2)</a> <a href="#ref-for-cors-request③">(3)</a>
    <li><a href="#ref-for-cors-request④">3.2.3. HTTP responses</a> <a href="#ref-for-cors-request⑤">(2)</a> <a href="#ref-for-cors-request⑥">(3)</a> <a href="#ref-for-cors-request⑦">(4)</a>
    <li><a href="#ref-for-cors-request⑧">CORS protocol and HTTP caches</a> <a href="#ref-for-cors-request⑨">(2)</a> <a href="#ref-for-cors-request①⓪">(3)</a> <a href="#ref-for-cors-request①①">(4)</a> <a href="#ref-for-cors-request①②">(5)</a> <a href="#ref-for-cors-request①③">(6)</a> <a href="#ref-for-cors-request①④">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-preflight-request">
   <b><a href="#cors-preflight-request">#cors-preflight-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-preflight-request">2.2.5. Requests</a>
    <li><a href="#ref-for-cors-preflight-request①">3.2.1. General</a>
    <li><a href="#ref-for-cors-preflight-request②">3.2.3. HTTP responses</a> <a href="#ref-for-cors-preflight-request③">(2)</a> <a href="#ref-for-cors-preflight-request④">(3)</a> <a href="#ref-for-cors-preflight-request⑤">(4)</a> <a href="#ref-for-cors-preflight-request⑥">(5)</a>
    <li><a href="#ref-for-cors-preflight-request⑦">3.2.5. CORS protocol and credentials</a> <a href="#ref-for-cors-preflight-request⑧">(2)</a>
    <li><a href="#ref-for-cors-preflight-request⑨">4.3. HTTP fetch</a>
    <li><a href="#ref-for-cors-preflight-request①⓪">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-request-method">
   <b><a href="#http-access-control-request-method">#http-access-control-request-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-request-method">2.2.2. Headers</a>
    <li><a href="#ref-for-http-access-control-request-method①">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-request-headers">
   <b><a href="#http-access-control-request-headers">#http-access-control-request-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-request-headers">2.2.2. Headers</a>
    <li><a href="#ref-for-http-access-control-request-headers①">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-allow-origin">
   <b><a href="#http-access-control-allow-origin">#http-access-control-allow-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-allow-origin">3.2.5. CORS protocol and credentials</a> <a href="#ref-for-http-access-control-allow-origin①">(2)</a> <a href="#ref-for-http-access-control-allow-origin②">(3)</a>
    <li><a href="#ref-for-http-access-control-allow-origin③">3.2.6. Examples</a> <a href="#ref-for-http-access-control-allow-origin④">(2)</a> <a href="#ref-for-http-access-control-allow-origin⑤">(3)</a>
    <li><a href="#ref-for-http-access-control-allow-origin⑥">4.9. CORS check</a>
    <li><a href="#ref-for-http-access-control-allow-origin⑦">CORS protocol and HTTP caches</a> <a href="#ref-for-http-access-control-allow-origin⑧">(2)</a> <a href="#ref-for-http-access-control-allow-origin⑨">(3)</a> <a href="#ref-for-http-access-control-allow-origin①⓪">(4)</a> <a href="#ref-for-http-access-control-allow-origin①①">(5)</a> <a href="#ref-for-http-access-control-allow-origin①②">(6)</a> <a href="#ref-for-http-access-control-allow-origin①③">(7)</a> <a href="#ref-for-http-access-control-allow-origin①④">(8)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-allow-credentials">
   <b><a href="#http-access-control-allow-credentials">#http-access-control-allow-credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-allow-credentials">3.2.5. CORS protocol and credentials</a> <a href="#ref-for-http-access-control-allow-credentials①">(2)</a> <a href="#ref-for-http-access-control-allow-credentials②">(3)</a>
    <li><a href="#ref-for-http-access-control-allow-credentials③">3.2.6. Examples</a>
    <li><a href="#ref-for-http-access-control-allow-credentials④">4.9. CORS check</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-allow-methods">
   <b><a href="#http-access-control-allow-methods">#http-access-control-allow-methods</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-allow-methods">3.2.3. HTTP responses</a>
    <li><a href="#ref-for-http-access-control-allow-methods①">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-http-access-control-allow-methods②">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-allow-headers">
   <b><a href="#http-access-control-allow-headers">#http-access-control-allow-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-allow-headers">3.2.3. HTTP responses</a>
    <li><a href="#ref-for-http-access-control-allow-headers①">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-http-access-control-allow-headers②">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-max-age">
   <b><a href="#http-access-control-max-age">#http-access-control-max-age</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-max-age">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-access-control-expose-headers">
   <b><a href="#http-access-control-expose-headers">#http-access-control-expose-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-access-control-expose-headers">2.2.6. Responses</a>
    <li><a href="#ref-for-http-access-control-expose-headers①">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-http-access-control-expose-headers②">3.2.6. Examples</a> <a href="#ref-for-http-access-control-expose-headers③">(2)</a> <a href="#ref-for-http-access-control-expose-headers④">(3)</a>
    <li><a href="#ref-for-http-access-control-expose-headers⑤">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-header-extract-mime-type">
   <b><a href="#concept-header-extract-mime-type">#concept-header-extract-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-header-extract-mime-type">2.2.2. Headers</a> <a href="#ref-for-concept-header-extract-mime-type①">(2)</a>
    <li><a href="#ref-for-concept-header-extract-mime-type②">2.7. Should
response to request be blocked due to its MIME type?</a>
    <li><a href="#ref-for-concept-header-extract-mime-type③">3.3. `Content-Type` header</a> <a href="#ref-for-concept-header-extract-mime-type④">(2)</a>
    <li><a href="#ref-for-concept-header-extract-mime-type⑤">3.4.1. Should
response to request be blocked due to nosniff?</a>
    <li><a href="#ref-for-concept-header-extract-mime-type⑥">3.5. CORB</a>
    <li><a href="#ref-for-concept-header-extract-mime-type⑦">5.3. Request class</a>
    <li><a href="#ref-for-concept-header-extract-mime-type⑧">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-x-content-type-options">
   <b><a href="#http-x-content-type-options">#http-x-content-type-options</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-x-content-type-options">3.4. `X-Content-Type-Options` header</a> <a href="#ref-for-http-x-content-type-options①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="determine-nosniff">
   <b><a href="#determine-nosniff">#determine-nosniff</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-determine-nosniff">3.4.1. Should
response to request be blocked due to nosniff?</a>
    <li><a href="#ref-for-determine-nosniff①">3.5. CORB</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="should-response-to-request-be-blocked-due-to-nosniff?">
   <b><a href="#should-response-to-request-be-blocked-due-to-nosniff?">#should-response-to-request-be-blocked-due-to-nosniff?</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-should-response-to-request-be-blocked-due-to-nosniff?">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="corb-protected-mime-type">
   <b><a href="#corb-protected-mime-type">#corb-protected-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-corb-protected-mime-type">3.5. CORB</a> <a href="#ref-for-corb-protected-mime-type①">(2)</a> <a href="#ref-for-corb-protected-mime-type②">(3)</a> <a href="#ref-for-corb-protected-mime-type③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="corb-check">
   <b><a href="#corb-check">#corb-check</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-corb-check">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-cross-origin-resource-policy">
   <b><a href="#http-cross-origin-resource-policy">#http-cross-origin-resource-policy</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-cross-origin-resource-policy">3.6. `Cross-Origin-Resource-Policy` header</a> <a href="#ref-for-http-cross-origin-resource-policy①">(2)</a> <a href="#ref-for-http-cross-origin-resource-policy②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cross-origin-resource-policy-check">
   <b><a href="#cross-origin-resource-policy-check">#cross-origin-resource-policy-check</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cross-origin-resource-policy-check">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch">
   <b><a href="#concept-fetch">#concept-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch">2.2. HTTP</a>
    <li><a href="#ref-for-concept-fetch①">2.2.2. Headers</a>
    <li><a href="#ref-for-concept-fetch②">2.2.5. Requests</a> <a href="#ref-for-concept-fetch③">(2)</a> <a href="#ref-for-concept-fetch④">(3)</a> <a href="#ref-for-concept-fetch⑤">(4)</a> <a href="#ref-for-concept-fetch⑥">(5)</a> <a href="#ref-for-concept-fetch⑦">(6)</a> <a href="#ref-for-concept-fetch⑧">(7)</a> <a href="#ref-for-concept-fetch⑨">(8)</a> <a href="#ref-for-concept-fetch①⓪">(9)</a> <a href="#ref-for-concept-fetch①①">(10)</a>
    <li><a href="#ref-for-concept-fetch①②">2.2.6. Responses</a> <a href="#ref-for-concept-fetch①③">(2)</a>
    <li><a href="#ref-for-concept-fetch①④">2.4. Fetch groups</a>
    <li><a href="#ref-for-concept-fetch①⑤">3.1. `Origin` header</a> <a href="#ref-for-concept-fetch①⑥">(2)</a>
    <li><a href="#ref-for-concept-fetch①⑦">3.2. CORS protocol</a> <a href="#ref-for-concept-fetch①⑧">(2)</a>
    <li><a href="#ref-for-concept-fetch①⑨">3.2.5. CORS protocol and credentials</a>
    <li><a href="#ref-for-concept-fetch②⓪">4. Fetching</a> <a href="#ref-for-concept-fetch②①">(2)</a> <a href="#ref-for-concept-fetch②②">(3)</a>
    <li><a href="#ref-for-concept-fetch②③">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-fetch②④">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-fetch②⑤">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-fetch②⑥">5. Fetch API</a> <a href="#ref-for-concept-fetch②⑦">(2)</a>
    <li><a href="#ref-for-concept-fetch②⑧">5.5. Fetch method</a>
    <li><a href="#ref-for-concept-fetch②⑨">6.2. Opening handshake</a> <a href="#ref-for-concept-fetch③⓪">(2)</a>
    <li><a href="#ref-for-concept-fetch③①">CORS protocol and HTTP caches</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-terminate">
   <b><a href="#concept-fetch-terminate">#concept-fetch-terminate</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-terminate">2.2.5. Requests</a> <a href="#ref-for-concept-fetch-terminate①">(2)</a> <a href="#ref-for-concept-fetch-terminate②">(3)</a>
    <li><a href="#ref-for-concept-fetch-terminate③">2.4. Fetch groups</a>
    <li><a href="#ref-for-concept-fetch-terminate④">2.5. Connections</a>
    <li><a href="#ref-for-concept-fetch-terminate⑤">4. Fetching</a>
    <li><a href="#ref-for-concept-fetch-terminate⑥">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-fetch-terminate⑦">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-fetch-terminate⑧">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-fetch-terminate⑨">(2)</a> <a href="#ref-for-concept-fetch-terminate①⓪">(3)</a>
    <li><a href="#ref-for-concept-fetch-terminate①①">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-fetch-terminate①②">(2)</a> <a href="#ref-for-concept-fetch-terminate①③">(3)</a> <a href="#ref-for-concept-fetch-terminate①④">(4)</a> <a href="#ref-for-concept-fetch-terminate①⑤">(5)</a> <a href="#ref-for-concept-fetch-terminate①⑥">(6)</a>
    <li><a href="#ref-for-concept-fetch-terminate①⑦">5.5. Fetch method</a>
    <li><a href="#ref-for-concept-fetch-terminate①⑧">5.6. Garbage collection</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-suspend">
   <b><a href="#concept-fetch-suspend">#concept-fetch-suspend</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-suspend">4.6. HTTP-network fetch</a> <a href="#ref-for-concept-fetch-suspend①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-fetch-resume">
   <b><a href="#concept-fetch-resume">#concept-fetch-resume</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-fetch-resume">4.6. HTTP-network fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-main-fetch">
   <b><a href="#concept-main-fetch">#concept-main-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-main-fetch">4. Fetching</a>
    <li><a href="#ref-for-concept-main-fetch①">4.1. Main fetch</a>
    <li><a href="#ref-for-concept-main-fetch②">4.4. HTTP-redirect fetch</a> <a href="#ref-for-concept-main-fetch③">(2)</a>
    <li><a href="#ref-for-concept-main-fetch④">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-scheme-fetch">
   <b><a href="#concept-scheme-fetch">#concept-scheme-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-scheme-fetch">4.1. Main fetch</a> <a href="#ref-for-concept-scheme-fetch①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-http-fetch">
   <b><a href="#concept-http-fetch">#concept-http-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-http-fetch">2.2.5. Requests</a> <a href="#ref-for-concept-http-fetch①">(2)</a>
    <li><a href="#ref-for-concept-http-fetch②">3.1. `Origin` header</a>
    <li><a href="#ref-for-concept-http-fetch③">4.1. Main fetch</a> <a href="#ref-for-concept-http-fetch④">(2)</a>
    <li><a href="#ref-for-concept-http-fetch⑤">4.2. Scheme fetch</a>
    <li><a href="#ref-for-concept-http-fetch⑥">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-concept-http-fetch⑦">4.7. CORS-preflight fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-http-redirect-fetch">
   <b><a href="#concept-http-redirect-fetch">#concept-http-redirect-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-http-redirect-fetch">4.3. HTTP fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-http-network-or-cache-fetch">
   <b><a href="#concept-http-network-or-cache-fetch">#concept-http-network-or-cache-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-http-network-or-cache-fetch">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-http-network-or-cache-fetch①">4.5. HTTP-network-or-cache fetch</a> <a href="#ref-for-concept-http-network-or-cache-fetch②">(2)</a>
    <li><a href="#ref-for-concept-http-network-or-cache-fetch③">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-http-network-or-cache-fetch④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-http-network-fetch">
   <b><a href="#concept-http-network-fetch">#concept-http-network-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-http-network-fetch">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cors-preflight-fetch-0">
   <b><a href="#cors-preflight-fetch-0">#cors-preflight-fetch-0</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-preflight-fetch-0">2.2.5. Requests</a>
    <li><a href="#ref-for-cors-preflight-fetch-0①">4.3. HTTP fetch</a> <a href="#ref-for-cors-preflight-fetch-0②">(2)</a> <a href="#ref-for-cors-preflight-fetch-0③">(3)</a> <a href="#ref-for-cors-preflight-fetch-0④">(4)</a>
    <li><a href="#ref-for-cors-preflight-fetch-0⑤">4.7. CORS-preflight fetch</a> <a href="#ref-for-cors-preflight-fetch-0⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache">
   <b><a href="#concept-cache">#concept-cache</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-cache①">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-cache②">(2)</a> <a href="#ref-for-concept-cache③">(3)</a>
    <li><a href="#ref-for-concept-cache④">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache⑤">(2)</a> <a href="#ref-for-concept-cache⑥">(3)</a> <a href="#ref-for-concept-cache⑦">(4)</a> <a href="#ref-for-concept-cache⑧">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cache-entry">
   <b><a href="#cache-entry">#cache-entry</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cache-entry">4.8. CORS-preflight cache</a> <a href="#ref-for-cache-entry①">(2)</a> <a href="#ref-for-cache-entry②">(3)</a> <a href="#ref-for-cache-entry③">(4)</a> <a href="#ref-for-cache-entry④">(5)</a> <a href="#ref-for-cache-entry⑤">(6)</a> <a href="#ref-for-cache-entry⑥">(7)</a> <a href="#ref-for-cache-entry⑦">(8)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-origin">
   <b><a href="#concept-cache-origin">#concept-cache-origin</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-origin">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-origin①">(2)</a> <a href="#ref-for-concept-cache-origin②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-url">
   <b><a href="#concept-cache-url">#concept-cache-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-url">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-url①">(2)</a> <a href="#ref-for-concept-cache-url②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-max-age">
   <b><a href="#concept-cache-max-age">#concept-cache-max-age</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-max-age">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-cache-max-age①">(2)</a> <a href="#ref-for-concept-cache-max-age②">(3)</a>
    <li><a href="#ref-for-concept-cache-max-age③">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-max-age④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-credentials">
   <b><a href="#concept-cache-credentials">#concept-cache-credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-credentials">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-credentials①">(2)</a> <a href="#ref-for-concept-cache-credentials②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-method">
   <b><a href="#concept-cache-method">#concept-cache-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-method">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-method①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-header-name">
   <b><a href="#concept-cache-header-name">#concept-cache-header-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-header-name">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-header-name①">(2)</a> <a href="#ref-for-concept-cache-header-name②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-create-entry">
   <b><a href="#concept-cache-create-entry">#concept-cache-create-entry</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-create-entry">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-cache-create-entry①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-clear">
   <b><a href="#concept-cache-clear">#concept-cache-clear</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-clear">4.1. Main fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-match">
   <b><a href="#concept-cache-match">#concept-cache-match</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-match">4.8. CORS-preflight cache</a> <a href="#ref-for-concept-cache-match①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-match-method">
   <b><a href="#concept-cache-match-method">#concept-cache-match-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-match-method">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-cache-match-method①">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-cache-match-method②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cache-match-header">
   <b><a href="#concept-cache-match-header">#concept-cache-match-header</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cache-match-header">4.3. HTTP fetch</a>
    <li><a href="#ref-for-concept-cache-match-header①">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-cache-match-header②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-cors-check">
   <b><a href="#concept-cors-check">#concept-cors-check</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cors-check">4.3. HTTP fetch</a> <a href="#ref-for-concept-cors-check①">(2)</a>
    <li><a href="#ref-for-concept-cors-check②">4.7. CORS-preflight fetch</a> <a href="#ref-for-concept-cors-check③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-tao-check">
   <b><a href="#concept-tao-check">#concept-tao-check</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tao-check">4.3. HTTP fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedefdef-headersinit">
   <b><a href="#typedefdef-headersinit">#typedefdef-headersinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedefdef-headersinit">5.1. Headers class</a>
    <li><a href="#ref-for-typedefdef-headersinit①">5.3. Request class</a>
    <li><a href="#ref-for-typedefdef-headersinit②">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="headers">
   <b><a href="#headers">#headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-headers">5.1. Headers class</a> <a href="#ref-for-headers①">(2)</a> <a href="#ref-for-headers②">(3)</a> <a href="#ref-for-headers③">(4)</a> <a href="#ref-for-headers④">(5)</a> <a href="#ref-for-headers⑤">(6)</a> <a href="#ref-for-headers⑥">(7)</a> <a href="#ref-for-headers⑦">(8)</a> <a href="#ref-for-headers⑧">(9)</a>
    <li><a href="#ref-for-headers⑨">5.3. Request class</a> <a href="#ref-for-headers①⓪">(2)</a> <a href="#ref-for-headers①①">(3)</a> <a href="#ref-for-headers①②">(4)</a> <a href="#ref-for-headers①③">(5)</a> <a href="#ref-for-headers①④">(6)</a> <a href="#ref-for-headers①⑤">(7)</a> <a href="#ref-for-headers①⑥">(8)</a>
    <li><a href="#ref-for-headers①⑦">5.4. Response class</a> <a href="#ref-for-headers①⑧">(2)</a> <a href="#ref-for-headers①⑨">(3)</a> <a href="#ref-for-headers②⓪">(4)</a> <a href="#ref-for-headers②①">(5)</a> <a href="#ref-for-headers②②">(6)</a>
    <li><a href="#ref-for-headers②③">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-headers-header-list">
   <b><a href="#concept-headers-header-list">#concept-headers-header-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-headers-header-list">5.1. Headers class</a> <a href="#ref-for-concept-headers-header-list①">(2)</a> <a href="#ref-for-concept-headers-header-list②">(3)</a> <a href="#ref-for-concept-headers-header-list③">(4)</a> <a href="#ref-for-concept-headers-header-list④">(5)</a> <a href="#ref-for-concept-headers-header-list⑤">(6)</a> <a href="#ref-for-concept-headers-header-list⑥">(7)</a> <a href="#ref-for-concept-headers-header-list⑦">(8)</a> <a href="#ref-for-concept-headers-header-list⑧">(9)</a>
    <li><a href="#ref-for-concept-headers-header-list⑨">5.3. Request class</a> <a href="#ref-for-concept-headers-header-list①⓪">(2)</a> <a href="#ref-for-concept-headers-header-list①①">(3)</a> <a href="#ref-for-concept-headers-header-list①②">(4)</a> <a href="#ref-for-concept-headers-header-list①③">(5)</a> <a href="#ref-for-concept-headers-header-list①④">(6)</a> <a href="#ref-for-concept-headers-header-list①⑤">(7)</a>
    <li><a href="#ref-for-concept-headers-header-list①⑥">5.4. Response class</a> <a href="#ref-for-concept-headers-header-list①⑦">(2)</a> <a href="#ref-for-concept-headers-header-list①⑧">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-headers-guard">
   <b><a href="#concept-headers-guard">#concept-headers-guard</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-headers-guard">5.1. Headers class</a> <a href="#ref-for-concept-headers-guard①">(2)</a> <a href="#ref-for-concept-headers-guard②">(3)</a> <a href="#ref-for-concept-headers-guard③">(4)</a> <a href="#ref-for-concept-headers-guard④">(5)</a> <a href="#ref-for-concept-headers-guard⑤">(6)</a> <a href="#ref-for-concept-headers-guard⑥">(7)</a> <a href="#ref-for-concept-headers-guard⑦">(8)</a> <a href="#ref-for-concept-headers-guard⑧">(9)</a> <a href="#ref-for-concept-headers-guard⑨">(10)</a> <a href="#ref-for-concept-headers-guard①⓪">(11)</a> <a href="#ref-for-concept-headers-guard①①">(12)</a> <a href="#ref-for-concept-headers-guard①②">(13)</a> <a href="#ref-for-concept-headers-guard①③">(14)</a> <a href="#ref-for-concept-headers-guard①④">(15)</a> <a href="#ref-for-concept-headers-guard①⑤">(16)</a>
    <li><a href="#ref-for-concept-headers-guard①⑥">5.3. Request class</a> <a href="#ref-for-concept-headers-guard①⑦">(2)</a> <a href="#ref-for-concept-headers-guard①⑧">(3)</a> <a href="#ref-for-concept-headers-guard①⑨">(4)</a>
    <li><a href="#ref-for-concept-headers-guard②⓪">5.4. Response class</a> <a href="#ref-for-concept-headers-guard②①">(2)</a> <a href="#ref-for-concept-headers-guard②②">(3)</a> <a href="#ref-for-concept-headers-guard②③">(4)</a> <a href="#ref-for-concept-headers-guard②④">(5)</a>
    <li><a href="#ref-for-concept-headers-guard②⑤">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-headers-append">
   <b><a href="#concept-headers-append">#concept-headers-append</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-headers-append">5.1. Headers class</a> <a href="#ref-for-concept-headers-append①">(2)</a> <a href="#ref-for-concept-headers-append②">(3)</a>
    <li><a href="#ref-for-concept-headers-append③">5.3. Request class</a> <a href="#ref-for-concept-headers-append④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-headers-fill">
   <b><a href="#concept-headers-fill">#concept-headers-fill</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-headers-fill">5.1. Headers class</a>
    <li><a href="#ref-for-concept-headers-fill①">5.3. Request class</a>
    <li><a href="#ref-for-concept-headers-fill②">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-headers-remove-privileged-no-cors-request-headers">
   <b><a href="#concept-headers-remove-privileged-no-cors-request-headers">#concept-headers-remove-privileged-no-cors-request-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-headers-remove-privileged-no-cors-request-headers">5.1. Headers class</a> <a href="#ref-for-concept-headers-remove-privileged-no-cors-request-headers①">(2)</a> <a href="#ref-for-concept-headers-remove-privileged-no-cors-request-headers②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-headers">
   <b><a href="#dom-headers">#dom-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-headers">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-headers-append">
   <b><a href="#dom-headers-append">#dom-headers-append</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-headers-append">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-headers-delete">
   <b><a href="#dom-headers-delete">#dom-headers-delete</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-headers-delete">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-headers-get">
   <b><a href="#dom-headers-get">#dom-headers-get</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-headers-get">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-headers-has">
   <b><a href="#dom-headers-has">#dom-headers-has</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-headers-has">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-headers-set">
   <b><a href="#dom-headers-set">#dom-headers-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-headers-set">5.1. Headers class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="bodyinit">
   <b><a href="#bodyinit">#bodyinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-bodyinit">5.3. Request class</a> <a href="#ref-for-bodyinit①">(2)</a>
    <li><a href="#ref-for-bodyinit②">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="bodyinit-safely-extract">
   <b><a href="#bodyinit-safely-extract">#bodyinit-safely-extract</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-bodyinit-safely-extract">4.4. HTTP-redirect fetch</a>
    <li><a href="#ref-for-bodyinit-safely-extract①">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-bodyinit-safely-extract②">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-bodyinit-extract">
   <b><a href="#concept-bodyinit-extract">#concept-bodyinit-extract</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-bodyinit-extract">5.2. Body mixin</a> <a href="#ref-for-concept-bodyinit-extract①">(2)</a>
    <li><a href="#ref-for-concept-bodyinit-extract②">5.3. Request class</a> <a href="#ref-for-concept-bodyinit-extract③">(2)</a>
    <li><a href="#ref-for-concept-bodyinit-extract④">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="body">
   <b><a href="#body">#body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-body">5.2. Body mixin</a> <a href="#ref-for-body①">(2)</a> <a href="#ref-for-body②">(3)</a> <a href="#ref-for-body③">(4)</a> <a href="#ref-for-body④">(5)</a>
    <li><a href="#ref-for-body⑤">5.3. Request class</a>
    <li><a href="#ref-for-body⑥">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-body">
   <b><a href="#concept-body-body">#concept-body-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-body">5.2. Body mixin</a> <a href="#ref-for-concept-body-body①">(2)</a> <a href="#ref-for-concept-body-body②">(3)</a> <a href="#ref-for-concept-body-body③">(4)</a> <a href="#ref-for-concept-body-body④">(5)</a> <a href="#ref-for-concept-body-body⑤">(6)</a>
    <li><a href="#ref-for-concept-body-body⑥">5.3. Request class</a>
    <li><a href="#ref-for-concept-body-body⑦">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-mime-type">
   <b><a href="#concept-body-mime-type">#concept-body-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-mime-type">5.2. Body mixin</a>
    <li><a href="#ref-for-concept-body-mime-type①">5.3. Request class</a>
    <li><a href="#ref-for-concept-body-mime-type②">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-disturbed">
   <b><a href="#concept-body-disturbed">#concept-body-disturbed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-disturbed">5.2. Body mixin</a> <a href="#ref-for-concept-body-disturbed①">(2)</a>
    <li><a href="#ref-for-concept-body-disturbed②">5.3. Request class</a> <a href="#ref-for-concept-body-disturbed③">(2)</a>
    <li><a href="#ref-for-concept-body-disturbed④">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-locked">
   <b><a href="#concept-body-locked">#concept-body-locked</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-locked">5.2. Body mixin</a>
    <li><a href="#ref-for-concept-body-locked①">5.3. Request class</a> <a href="#ref-for-concept-body-locked②">(2)</a>
    <li><a href="#ref-for-concept-body-locked③">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-body">
   <b><a href="#dom-body-body">#dom-body-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-body">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-bodyused">
   <b><a href="#dom-body-bodyused">#dom-body-bodyused</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-bodyused">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-package-data">
   <b><a href="#concept-body-package-data">#concept-body-package-data</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-package-data">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-body-consume-body">
   <b><a href="#concept-body-consume-body">#concept-body-consume-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-body-consume-body">5.2. Body mixin</a> <a href="#ref-for-concept-body-consume-body①">(2)</a> <a href="#ref-for-concept-body-consume-body②">(3)</a> <a href="#ref-for-concept-body-consume-body③">(4)</a> <a href="#ref-for-concept-body-consume-body④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-arraybuffer">
   <b><a href="#dom-body-arraybuffer">#dom-body-arraybuffer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-arraybuffer">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-blob">
   <b><a href="#dom-body-blob">#dom-body-blob</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-blob">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-formdata">
   <b><a href="#dom-body-formdata">#dom-body-formdata</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-formdata">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-json">
   <b><a href="#dom-body-json">#dom-body-json</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-json">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-body-text">
   <b><a href="#dom-body-text">#dom-body-text</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-body-text">5.2. Body mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestinfo">
   <b><a href="#requestinfo">#requestinfo</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestinfo">5.3. Request class</a>
    <li><a href="#ref-for-requestinfo①">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request">
   <b><a href="#request">#request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request">5.1. Headers class</a>
    <li><a href="#ref-for-request①">5.3. Request class</a> <a href="#ref-for-request②">(2)</a> <a href="#ref-for-request③">(3)</a> <a href="#ref-for-request④">(4)</a> <a href="#ref-for-request⑤">(5)</a> <a href="#ref-for-request⑥">(6)</a> <a href="#ref-for-request⑦">(7)</a> <a href="#ref-for-request⑧">(8)</a> <a href="#ref-for-request⑨">(9)</a> <a href="#ref-for-request①⓪">(10)</a> <a href="#ref-for-request①①">(11)</a> <a href="#ref-for-request①②">(12)</a>
    <li><a href="#ref-for-request①③">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestinit">
   <b><a href="#requestinit">#requestinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestinit">5.3. Request class</a>
    <li><a href="#ref-for-requestinit①">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-method">
   <b><a href="#dom-requestinit-method">#dom-requestinit-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-method">5.3. Request class</a> <a href="#ref-for-dom-requestinit-method①">(2)</a> <a href="#ref-for-dom-requestinit-method②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-headers">
   <b><a href="#dom-requestinit-headers">#dom-requestinit-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-headers">5.3. Request class</a> <a href="#ref-for-dom-requestinit-headers①">(2)</a> <a href="#ref-for-dom-requestinit-headers②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-body">
   <b><a href="#dom-requestinit-body">#dom-requestinit-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-body">5.3. Request class</a> <a href="#ref-for-dom-requestinit-body①">(2)</a> <a href="#ref-for-dom-requestinit-body②">(3)</a> <a href="#ref-for-dom-requestinit-body③">(4)</a> <a href="#ref-for-dom-requestinit-body④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-referrer">
   <b><a href="#dom-requestinit-referrer">#dom-requestinit-referrer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-referrer">5.3. Request class</a> <a href="#ref-for-dom-requestinit-referrer①">(2)</a> <a href="#ref-for-dom-requestinit-referrer②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-referrerpolicy">
   <b><a href="#dom-requestinit-referrerpolicy">#dom-requestinit-referrerpolicy</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-referrerpolicy">5.3. Request class</a> <a href="#ref-for-dom-requestinit-referrerpolicy①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-mode">
   <b><a href="#dom-requestinit-mode">#dom-requestinit-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-mode">5.3. Request class</a> <a href="#ref-for-dom-requestinit-mode①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-credentials">
   <b><a href="#dom-requestinit-credentials">#dom-requestinit-credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-credentials">5.3. Request class</a> <a href="#ref-for-dom-requestinit-credentials①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-cache">
   <b><a href="#dom-requestinit-cache">#dom-requestinit-cache</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-cache">5.3. Request class</a> <a href="#ref-for-dom-requestinit-cache①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-redirect">
   <b><a href="#dom-requestinit-redirect">#dom-requestinit-redirect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-redirect">5.3. Request class</a> <a href="#ref-for-dom-requestinit-redirect①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-integrity">
   <b><a href="#dom-requestinit-integrity">#dom-requestinit-integrity</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-integrity">5.3. Request class</a> <a href="#ref-for-dom-requestinit-integrity①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-keepalive">
   <b><a href="#dom-requestinit-keepalive">#dom-requestinit-keepalive</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-keepalive">5.3. Request class</a> <a href="#ref-for-dom-requestinit-keepalive①">(2)</a> <a href="#ref-for-dom-requestinit-keepalive②">(3)</a> <a href="#ref-for-dom-requestinit-keepalive③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-signal">
   <b><a href="#dom-requestinit-signal">#dom-requestinit-signal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-signal">5.3. Request class</a> <a href="#ref-for-dom-requestinit-signal①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-requestinit-window">
   <b><a href="#dom-requestinit-window">#dom-requestinit-window</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-requestinit-window">5.3. Request class</a> <a href="#ref-for-dom-requestinit-window①">(2)</a> <a href="#ref-for-dom-requestinit-window②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestdestination">
   <b><a href="#requestdestination">#requestdestination</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestdestination">5.3. Request class</a> <a href="#ref-for-requestdestination①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestmode">
   <b><a href="#requestmode">#requestmode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestmode">5.3. Request class</a> <a href="#ref-for-requestmode①">(2)</a> <a href="#ref-for-requestmode②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestcredentials">
   <b><a href="#requestcredentials">#requestcredentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestcredentials">5.3. Request class</a> <a href="#ref-for-requestcredentials①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestcache">
   <b><a href="#requestcache">#requestcache</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestcache">5.3. Request class</a> <a href="#ref-for-requestcache①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="requestredirect">
   <b><a href="#requestredirect">#requestredirect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-requestredirect">5.3. Request class</a> <a href="#ref-for-requestredirect①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-request-request">
   <b><a href="#concept-request-request">#concept-request-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-request-request">5.3. Request class</a> <a href="#ref-for-concept-request-request①">(2)</a> <a href="#ref-for-concept-request-request②">(3)</a> <a href="#ref-for-concept-request-request③">(4)</a> <a href="#ref-for-concept-request-request④">(5)</a> <a href="#ref-for-concept-request-request⑤">(6)</a> <a href="#ref-for-concept-request-request⑥">(7)</a> <a href="#ref-for-concept-request-request⑦">(8)</a> <a href="#ref-for-concept-request-request⑧">(9)</a> <a href="#ref-for-concept-request-request⑨">(10)</a> <a href="#ref-for-concept-request-request①⓪">(11)</a> <a href="#ref-for-concept-request-request①①">(12)</a> <a href="#ref-for-concept-request-request①②">(13)</a> <a href="#ref-for-concept-request-request①③">(14)</a> <a href="#ref-for-concept-request-request①④">(15)</a> <a href="#ref-for-concept-request-request①⑤">(16)</a> <a href="#ref-for-concept-request-request①⑥">(17)</a> <a href="#ref-for-concept-request-request①⑦">(18)</a> <a href="#ref-for-concept-request-request①⑧">(19)</a> <a href="#ref-for-concept-request-request①⑨">(20)</a> <a href="#ref-for-concept-request-request②⓪">(21)</a> <a href="#ref-for-concept-request-request②①">(22)</a> <a href="#ref-for-concept-request-request②②">(23)</a> <a href="#ref-for-concept-request-request②③">(24)</a> <a href="#ref-for-concept-request-request②④">(25)</a> <a href="#ref-for-concept-request-request②⑤">(26)</a>
    <li><a href="#ref-for-concept-request-request②⑥">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request-headers">
   <b><a href="#request-headers">#request-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-headers">5.3. Request class</a> <a href="#ref-for-request-headers①">(2)</a> <a href="#ref-for-request-headers②">(3)</a> <a href="#ref-for-request-headers③">(4)</a> <a href="#ref-for-request-headers④">(5)</a> <a href="#ref-for-request-headers⑤">(6)</a> <a href="#ref-for-request-headers⑥">(7)</a> <a href="#ref-for-request-headers⑦">(8)</a> <a href="#ref-for-request-headers⑧">(9)</a>
    <li><a href="#ref-for-request-headers⑨">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="request-signal">
   <b><a href="#request-signal">#request-signal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-request-signal">5.3. Request class</a> <a href="#ref-for-request-signal①">(2)</a> <a href="#ref-for-request-signal②">(3)</a> <a href="#ref-for-request-signal③">(4)</a> <a href="#ref-for-request-signal④">(5)</a>
    <li><a href="#ref-for-request-signal⑤">5.5. Fetch method</a> <a href="#ref-for-request-signal⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request">
   <b><a href="#dom-request">#dom-request</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request">5.3. Request class</a> <a href="#ref-for-dom-request①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-method">
   <b><a href="#dom-request-method">#dom-request-method</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-method">5.3. Request class</a> <a href="#ref-for-dom-request-method①">(2)</a> <a href="#ref-for-dom-request-method②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-url">
   <b><a href="#dom-request-url">#dom-request-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-url">5.3. Request class</a> <a href="#ref-for-dom-request-url①">(2)</a> <a href="#ref-for-dom-request-url②">(3)</a> <a href="#ref-for-dom-request-url③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-headers">
   <b><a href="#dom-request-headers">#dom-request-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-headers">5.3. Request class</a> <a href="#ref-for-dom-request-headers①">(2)</a> <a href="#ref-for-dom-request-headers②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-destination">
   <b><a href="#dom-request-destination">#dom-request-destination</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-destination">5.3. Request class</a> <a href="#ref-for-dom-request-destination①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-referrer">
   <b><a href="#dom-request-referrer">#dom-request-referrer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-referrer">5.3. Request class</a> <a href="#ref-for-dom-request-referrer①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-referrerpolicy">
   <b><a href="#dom-request-referrerpolicy">#dom-request-referrerpolicy</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-referrerpolicy">5.3. Request class</a> <a href="#ref-for-dom-request-referrerpolicy①">(2)</a> <a href="#ref-for-dom-request-referrerpolicy②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-mode">
   <b><a href="#dom-request-mode">#dom-request-mode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-mode">5.3. Request class</a> <a href="#ref-for-dom-request-mode①">(2)</a> <a href="#ref-for-dom-request-mode②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-credentials">
   <b><a href="#dom-request-credentials">#dom-request-credentials</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-credentials">5.3. Request class</a> <a href="#ref-for-dom-request-credentials①">(2)</a> <a href="#ref-for-dom-request-credentials②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-cache">
   <b><a href="#dom-request-cache">#dom-request-cache</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-cache">5.3. Request class</a> <a href="#ref-for-dom-request-cache①">(2)</a> <a href="#ref-for-dom-request-cache②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-redirect">
   <b><a href="#dom-request-redirect">#dom-request-redirect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-redirect">5.3. Request class</a> <a href="#ref-for-dom-request-redirect①">(2)</a> <a href="#ref-for-dom-request-redirect②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-integrity">
   <b><a href="#dom-request-integrity">#dom-request-integrity</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-integrity">5.3. Request class</a> <a href="#ref-for-dom-request-integrity①">(2)</a> <a href="#ref-for-dom-request-integrity②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-keepalive">
   <b><a href="#dom-request-keepalive">#dom-request-keepalive</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-keepalive">5.3. Request class</a> <a href="#ref-for-dom-request-keepalive①">(2)</a> <a href="#ref-for-dom-request-keepalive②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-isreloadnavigation">
   <b><a href="#dom-request-isreloadnavigation">#dom-request-isreloadnavigation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-isreloadnavigation">5.3. Request class</a> <a href="#ref-for-dom-request-isreloadnavigation①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-ishistorynavigation">
   <b><a href="#dom-request-ishistorynavigation">#dom-request-ishistorynavigation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-ishistorynavigation">5.3. Request class</a> <a href="#ref-for-dom-request-ishistorynavigation①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-signal">
   <b><a href="#dom-request-signal">#dom-request-signal</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-signal">5.3. Request class</a> <a href="#ref-for-dom-request-signal①">(2)</a> <a href="#ref-for-dom-request-signal②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-request-clone">
   <b><a href="#dom-request-clone">#dom-request-clone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-request-clone">5.3. Request class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="response">
   <b><a href="#response">#response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-response">5.4. Response class</a> <a href="#ref-for-response①">(2)</a> <a href="#ref-for-response②">(3)</a> <a href="#ref-for-response③">(4)</a> <a href="#ref-for-response④">(5)</a> <a href="#ref-for-response⑤">(6)</a> <a href="#ref-for-response⑥">(7)</a> <a href="#ref-for-response⑦">(8)</a> <a href="#ref-for-response⑧">(9)</a> <a href="#ref-for-response⑨">(10)</a> <a href="#ref-for-response①⓪">(11)</a>
    <li><a href="#ref-for-response①①">5.5. Fetch method</a> <a href="#ref-for-response①②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="responseinit">
   <b><a href="#responseinit">#responseinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-responseinit">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-responseinit-status">
   <b><a href="#dom-responseinit-status">#dom-responseinit-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-responseinit-status">5.4. Response class</a> <a href="#ref-for-dom-responseinit-status①">(2)</a> <a href="#ref-for-dom-responseinit-status②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-responseinit-statustext">
   <b><a href="#dom-responseinit-statustext">#dom-responseinit-statustext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-responseinit-statustext">5.4. Response class</a> <a href="#ref-for-dom-responseinit-statustext①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-responseinit-headers">
   <b><a href="#dom-responseinit-headers">#dom-responseinit-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-responseinit-headers">5.4. Response class</a> <a href="#ref-for-dom-responseinit-headers①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="responsetype">
   <b><a href="#responsetype">#responsetype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-responsetype">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-response-response">
   <b><a href="#concept-response-response">#concept-response-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-response-response">5.4. Response class</a> <a href="#ref-for-concept-response-response①">(2)</a> <a href="#ref-for-concept-response-response②">(3)</a> <a href="#ref-for-concept-response-response③">(4)</a> <a href="#ref-for-concept-response-response④">(5)</a> <a href="#ref-for-concept-response-response⑤">(6)</a> <a href="#ref-for-concept-response-response⑥">(7)</a> <a href="#ref-for-concept-response-response⑦">(8)</a> <a href="#ref-for-concept-response-response⑧">(9)</a> <a href="#ref-for-concept-response-response⑨">(10)</a> <a href="#ref-for-concept-response-response①⓪">(11)</a> <a href="#ref-for-concept-response-response①①">(12)</a> <a href="#ref-for-concept-response-response①②">(13)</a> <a href="#ref-for-concept-response-response①③">(14)</a> <a href="#ref-for-concept-response-response①④">(15)</a> <a href="#ref-for-concept-response-response①⑤">(16)</a> <a href="#ref-for-concept-response-response①⑥">(17)</a> <a href="#ref-for-concept-response-response①⑦">(18)</a> <a href="#ref-for-concept-response-response①⑧">(19)</a> <a href="#ref-for-concept-response-response①⑨">(20)</a> <a href="#ref-for-concept-response-response②⓪">(21)</a> <a href="#ref-for-concept-response-response②①">(22)</a>
    <li><a href="#ref-for-concept-response-response②②">5.5. Fetch method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="response-headers">
   <b><a href="#response-headers">#response-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-response-headers">5.4. Response class</a> <a href="#ref-for-response-headers①">(2)</a> <a href="#ref-for-response-headers②">(3)</a> <a href="#ref-for-response-headers③">(4)</a> <a href="#ref-for-response-headers④">(5)</a> <a href="#ref-for-response-headers⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response">
   <b><a href="#dom-response">#dom-response</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response">4.1. Main fetch</a>
    <li><a href="#ref-for-dom-response①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-error">
   <b><a href="#dom-response-error">#dom-response-error</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-error">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-redirect">
   <b><a href="#dom-response-redirect">#dom-response-redirect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-redirect">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-type">
   <b><a href="#dom-response-type">#dom-response-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-type">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-url">
   <b><a href="#dom-response-url">#dom-response-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-url">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-redirected">
   <b><a href="#dom-response-redirected">#dom-response-redirected</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-redirected">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-status">
   <b><a href="#dom-response-status">#dom-response-status</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-status">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-ok">
   <b><a href="#dom-response-ok">#dom-response-ok</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-ok">2.2.6. Responses</a>
    <li><a href="#ref-for-dom-response-ok①">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-statustext">
   <b><a href="#dom-response-statustext">#dom-response-statustext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-statustext">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-headers">
   <b><a href="#dom-response-headers">#dom-response-headers</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-headers">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-response-clone">
   <b><a href="#dom-response-clone">#dom-response-clone</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-response-clone">5.4. Response class</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-global-fetch">
   <b><a href="#dom-global-fetch">#dom-global-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-global-fetch">1. Preface</a>
    <li><a href="#ref-for-dom-global-fetch①">2.2.5. Requests</a> <a href="#ref-for-dom-global-fetch②">(2)</a>
    <li><a href="#ref-for-dom-global-fetch③">4.5. HTTP-network-or-cache fetch</a>
    <li><a href="#ref-for-dom-global-fetch④">5. Fetch API</a> <a href="#ref-for-dom-global-fetch⑤">(2)</a>
    <li><a href="#ref-for-dom-global-fetch⑥">5.5. Fetch method</a>
    <li><a href="#ref-for-dom-global-fetch⑦">5.6. Garbage collection</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="abort-fetch">
   <b><a href="#abort-fetch">#abort-fetch</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-abort-fetch">5.5. Fetch method</a> <a href="#ref-for-abort-fetch①">(2)</a> <a href="#ref-for-abort-fetch②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-websocket-connection-obtain">
   <b><a href="#concept-websocket-connection-obtain">#concept-websocket-connection-obtain</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-websocket-connection-obtain">4.6. HTTP-network fetch</a>
    <li><a href="#ref-for-concept-websocket-connection-obtain①">6.1. Connections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-websocket-establish">
   <b><a href="#concept-websocket-establish">#concept-websocket-establish</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-websocket-establish">2.2.2. Headers</a>
    <li><a href="#ref-for-concept-websocket-establish①">2.2.5. Requests</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fail-the-websocket-connection">
   <b><a href="#fail-the-websocket-connection">#fail-the-websocket-connection</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fail-the-websocket-connection">6.2. Opening handshake</a> <a href="#ref-for-fail-the-websocket-connection①">(2)</a> <a href="#ref-for-fail-the-websocket-connection②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="the-websocket-connection-is-established">
   <b><a href="#the-websocket-connection-is-established">#the-websocket-connection-is-established</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-websocket-connection-is-established">6.2. Opening handshake</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="data-url-struct">
   <b><a href="#data-url-struct">#data-url-struct</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-data-url-struct">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="data-url-struct-mime-type">
   <b><a href="#data-url-struct-mime-type">#data-url-struct-mime-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-data-url-struct-mime-type">4.2. Scheme fetch</a>
    <li><a href="#ref-for-data-url-struct-mime-type①">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="data-url-struct-body">
   <b><a href="#data-url-struct-body">#data-url-struct-body</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-data-url-struct-body">4.2. Scheme fetch</a>
    <li><a href="#ref-for-data-url-struct-body①">7. data: URLs</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="data-url-processor">
   <b><a href="#data-url-processor">#data-url-processor</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-data-url-processor">4.2. Scheme fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-header-layer-division">
   <b><a href="#http-header-layer-division">#http-header-layer-division</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-header-layer-division">4.5. HTTP-network-or-cache fetch</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="atomic-http-redirect-handling">
   <b><a href="#atomic-http-redirect-handling">#atomic-http-redirect-handling</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-atomic-http-redirect-handling">2.2.5. Requests</a>
    <li><a href="#ref-for-atomic-http-redirect-handling①">2.2.6. Responses</a>
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